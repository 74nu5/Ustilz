namespace Ustilz.Api.Data;

#region Usings

using System;
using System.Threading.Tasks;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using Ustilz.Data.Entities;
using Ustilz.Data.Interfaces;

#endregion

[ApiController]
[Route("api/[controller]")]
public class CrudControllerBase<TViewModel, TDetailViewModel, TApiModel, TDal, TEntity, TIdentity> : ControllerBase
    where TIdentity : IComparable<TIdentity>
    where TEntity : ATraceableDataObject<TIdentity>
    where TApiModel : ATraceableDataObject<TIdentity>
    where TDal : IBaseDAL<TEntity, TIdentity>
{
    private readonly IMapper mapper;

    private readonly TDal dal;

    public CrudControllerBase(IMapper mapper, TDal context)
    {
        this.mapper = mapper;
        this.dal = context;
    }

    [HttpPost]
    public virtual async Task<IActionResult> Create(TApiModel apiModel)
    {
        apiModel.CreationDate = DateTime.Now;
        var entity = this.mapper.Map<TApiModel, TEntity>(apiModel);
        await this.dal.AddAsync(entity);

        return this.CreatedAtAction("Detail", new { id = apiModel.Id }, apiModel);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(TIdentity id)
    {
        var exists = await this.dal.ExistsAsync(id);
        if (!exists)
        {
            return this.NotFound();
        }

        var entity = await this.dal.GetDetailsAsync(id);
        await this.dal.RemoveAsync(entity).ConfigureAwait(false);

        return this.NoContent();
    }

    [HttpGet("{id}")]
    public virtual async Task<IActionResult> Detail(TIdentity id)
    {
        var exists = await this.dal.ExistsAsync(id);
        if (!exists)
        {
            return this.NotFound();
        }

        var entity = await this.dal.GetDetailsAsync(id);
        return this.Ok(entity);
    }

    [HttpGet]
    public virtual async Task<IActionResult> List()
    {
        var entities = await this.dal.GetAllAsync();

        return this.Ok(entities);
    }

    [HttpPut("{id}")]
    public virtual async Task<IActionResult> Update(TIdentity id, TEntity entity)
    {
        if (id.CompareTo(entity.Id) != 0)
        {
            return this.BadRequest();
        }

        if (!await this.dal.ExistsAsync(id))
        {
            return this.NotFound();
        }

        entity.LastModifiedDate = DateTime.Now;

        await this.dal.UpdateAsync(entity).ConfigureAwait(false);

        return this.NoContent();
    }
}
