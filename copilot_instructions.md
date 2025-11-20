# Guide de bonnes pratiques - Développement .NET

## Configuration du projet

### Standards de configuration recommandés
- **Target Framework** : Utiliser la version LTS ou la plus récente selon les besoins
- **LangVersion** : `latest` pour les projets en production, `preview` pour l'exploration
- **Nullable** : `enable` (fortement recommandé pour les nouveaux projets)
- **ImplicitUsings** : `enable` pour réduire le boilerplate
- **TreatWarningsAsErrors** : `true` pour maintenir la qualité du code

### Organisation de code recommandée
- **Structure claire** : Séparer les couches (domain, infrastructure, application)
- **Responsabilité unique** : Un fichier, une responsabilité
- **Namespaces cohérents** : Refléter la structure des dossiers
- **Tests organisés** : Miroir de la structure source

## Conventions de codage

### Style et formatage (recommandations)
1. **Indentation** : 4 espaces (configurable via EditorConfig)
2. **Accolades** : Style K&R ou Allman selon les préférences de l'équipe
3. **Ordre des modificateurs** : `public,private,protected,internal,static,extern,new,virtual,abstract,sealed,override,readonly,unsafe,volatile,async`
4. **Utilisation de var** : Privilégier `var` quand le type est évident
5. **Expression-bodied members** : Utiliser pour les membres simples
6. **Qualification des membres** : Éviter `this.` sauf pour lever l'ambiguïté

### Documentation et annotations
1. **Documentation XML** : Obligatoire pour les APIs publiques
2. **Annotations nullable** : Utiliser les annotations appropriées (`[NotNull]`, `[CanBeNull]`, etc.)
3. **Attributs spécialisés** : `[PublicAPI]`, `[UsedImplicitly]` selon les besoins
4. **Commentaires** : Expliquer le "pourquoi", pas le "quoi"
5. **Langues** : Cohérence dans tout le projet (anglais recommandé pour l'open source)

### Conventions de nommage
1. **Classes** : PascalCase, noms descriptifs
2. **Méthodes** : PascalCase, verbes ou actions
3. **Propriétés** : PascalCase, noms ou adjectifs
4. **Variables locales** : camelCase
5. **Constantes** : PascalCase ou UPPER_CASE selon le contexte
6. **Interfaces** : Préfixer avec `I` (ex: `IRepository`)
7. **Classes d'extension** : Suffixer avec `Extensions` (ex: `StringExtensions`)
8. **Tests** : Noms explicites décrivant le comportement testé

## Patterns et bonnes pratiques

### Structure des classes
```csharp
/// <summary>Description claire et concise.</summary>
[AttributesAppropriés]
public class ExempleClasse
{
    // 1. Champs privés
    private readonly IService _service;
    
    // 2. Constructeurs
    public ExempleClasse(IService service)
    {
        _service = service ?? throw new ArgumentNullException(nameof(service));
    }
    
    // 3. Propriétés publiques
    public string Name { get; init; } = string.Empty;
    
    // 4. Méthodes publiques
    public void DoSomething()
    {
        // Implementation
    }
    
    // 5. Méthodes privées
    private void HelperMethod() { }
}
```

### Classes d'extension
```csharp
/// <summary>Extensions pour le type String.</summary>
public static class StringExtensions
{
    /// <summary>Vérifie si la chaîne est null ou vide.</summary>
    /// <param name="value">La valeur à tester.</param>
    /// <returns>True si null ou vide, false sinon.</returns>
    public static bool IsNullOrEmpty(this string? value)
        => string.IsNullOrEmpty(value);
}
```

### Tests unitaires
```csharp
/// <summary>Tests pour StringExtensions.</summary>
public sealed class StringExtensionsTests
{
    /// <summary>Teste IsNullOrEmpty avec une chaîne null.</summary>
    [Fact]
    public void IsNullOrEmpty_WithNull_ReturnsTrue()
    {
        // Arrange
        string? value = null;
        
        // Act
        var result = value.IsNullOrEmpty();
        
        // Assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData("")]
    [InlineData("test")]
    public void IsNullOrEmpty_WithEmptyAndNonEmpty_ReturnsExpectedResult(string value)
    {
        // Act & Assert
        Assert.Equal(string.IsNullOrEmpty(value), value.IsNullOrEmpty());
    }
}
```

### Gestion des erreurs
1. **Validation des paramètres** : Vérifier et lever `ArgumentNullException`, `ArgumentException`
2. **États invalides** : Utiliser `InvalidOperationException`
3. **Documentation** : Documenter toutes les exceptions possibles
4. **Fail-fast principle** : Détecter les erreurs le plus tôt possible
5. **Exception handling** : Attraper spécifiquement, éviter les catch génériques

### Performance et optimisation
1. **Types performants** : Privilégier `Span<T>`, `Memory<T>`, `ReadOnlySpan<T>`
2. **Allocations** : Éviter les allocations inutiles, utiliser les object pools
3. **Async/await** : Utiliser correctement les patterns asynchrones
4. **Collections** : Choisir la collection appropriée selon l'usage
5. **Benchmarking** : Mesurer avant d'optimiser
6. **String manipulation** : Utiliser `StringBuilder` pour les concaténations multiples

## Gestion des dépendances et outils

### Gestion des packages
**Approches recommandées :**
- **Monorepo** : `Directory.Packages.props` pour la gestion centralisée
- **Projets multiples** : `PackageReference` avec versions cohérentes
- **Versioning** : Semantic Versioning (SemVer)
- **Sécurité** : Audit régulier des vulnérabilités

### Analyseurs statiques recommandés
- **Microsoft.CodeAnalysis.NetAnalyzers** : Analyseurs .NET officiels
- **StyleCop.Analyzers** : Cohérence du style de code
- **SonarAnalyzer.CSharp** : Détection de bugs et code smells
- **Roslynator** : Refactoring et améliorations de code
- **Microsoft.CodeAnalysis.PublicApiAnalyzers** : Gestion des APIs publiques
- **Security analyzers** : Microsoft.CodeAnalysis.BannedApiAnalyzers

## Principes de qualité et revue de code

### Checklist de qualité essentielle
- [ ] **Lisibilité** : Code auto-documenté avec noms explicites
- [ ] **Responsabilité unique** : Chaque classe/méthode a une seule raison de changer
- [ ] **Documentation** : APIs publiques documentées, commentaires utiles
- [ ] **Tests** : Couverture appropriée, tests lisibles et maintenables
- [ ] **Gestion d'erreurs** : Exceptions appropriées et bien documentées
- [ ] **Performance** : Pas de goulots d'étranglement évidents
- [ ] **Sécurité** : Validation des entrées, pas de données sensibles exposées
- [ ] **Nullabilité** : Annotations nullable correctes
- [ ] **Immutabilité** : Privilégier l'immutabilité quand possible
- [ ] **Async/await** : Patterns asynchrones corrects

### Anti-patterns à éviter
1. **God classes** : Classes trop grandes avec trop de responsabilités
2. **Magic numbers/strings** : Utiliser des constantes nommées
3. **Deep nesting** : Éviter l'imbrication excessive (max 3-4 niveaux)
4. **Primitive obsession** : Créer des types métier appropriés
5. **Exception swallowing** : Ne pas ignorer silencieusement les exceptions
6. **Mutabilité excessive** : Préférer l'immutabilité quand possible
7. **Couplage fort** : Utiliser l'injection de dépendances
8. **Code dupliqué** : Factoriser le code commun

### Principes SOLID
1. **Single Responsibility** : Une classe = une responsabilité
2. **Open/Closed** : Ouvert à l'extension, fermé à la modification
3. **Liskov Substitution** : Les sous-types doivent être substituables
4. **Interface Segregation** : Interfaces spécifiques plutôt que générales
5. **Dependency Inversion** : Dépendre des abstractions, pas des implémentations

## Outils et écosystème .NET

### Frameworks de tests recommandés
- **xUnit** : Framework moderne, extensible
- **NUnit** : Framework mature avec beaucoup de fonctionnalités
- **MSTest** : Intégré à Visual Studio, simple d'usage
- **Moq/NSubstitute** : Pour les mocks et stubs
- **FluentAssertions** : Assertions expressives et lisibles

### Tests de performance
- **BenchmarkDotNet** : Standard pour les micro-benchmarks
- **NBomber** : Tests de charge et de stress
- **dotMemory/PerfView** : Analyse de la mémoire
- **Application Insights** : Monitoring en production

### Outils de développement
- **EditorConfig** : Configuration cohérente des éditeurs
- **GitVersion** : Versioning automatique basé sur Git
- **Coverlet** : Couverture de code pour .NET
- **ReportGenerator** : Rapports de couverture
- **dotnet format** : Formatage automatique du code

### CI/CD et DevOps
- **GitHub Actions** : Intégration native avec GitHub
- **Azure DevOps** : Suite complète Microsoft
- **GitLab CI** : Intégré à GitLab
- **Docker** : Containerisation des applications
- **NuGet** : Distribution des packages

## Patterns de conception courants

### Patterns créationnels
- **Factory Method** : Création d'objets sans spécifier leur classe exacte
- **Builder** : Construction d'objets complexes étape par étape
- **Singleton** : Une seule instance d'une classe (utiliser l'injection de dépendances)

### Patterns structurels
- **Adapter** : Interface entre deux classes incompatibles
- **Decorator** : Ajouter des fonctionnalités sans modifier la classe
- **Facade** : Interface simplifiée pour un système complexe

### Patterns comportementaux
- **Strategy** : Encapsuler des algorithmes interchangeables
- **Observer** : Notification automatique des changements d'état
- **Command** : Encapsuler une requête en tant qu'objet
- **Template Method** : Définir le squelette d'un algorithme

---

## Ressources et références

### Documentation officielle
- [Microsoft .NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
- [C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET API Reference](https://docs.microsoft.com/en-us/dotnet/api/)

### Guides de style
- [Microsoft C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [StyleCop Rules](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/DOCUMENTATION.md)

### Livres recommandés
- "Clean Code" par Robert C. Martin
- "Effective C#" par Bill Wagner
- "C# in Depth" par Jon Skeet
- "Patterns of Enterprise Application Architecture" par Martin Fowler

### Communautés
- [.NET Community](https://dotnet.microsoft.com/en-us/community)
- [C# Corner](https://www.c-sharpcorner.com/)
- [Stack Overflow](https://stackoverflow.com/questions/tagged/c%23)
