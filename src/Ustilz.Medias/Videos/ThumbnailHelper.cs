// Copyright (c) PlaceholderCompany. All rights reserved.

namespace Ustilz.Medias.Videos;

using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using JetBrains.Annotations;

/// <summary>
///     Helper class to get a thumbnail from a video file.
/// </summary>
[PublicAPI]
public class ThumbnailHelper
{
    /// <summary>
    ///     Gets a thumbnail from a video file.
    /// </summary>
    /// <param name="pathMediaFile">The path media file.</param>
    /// <param name="waitTime">We need to give MediaPlayer some time to load. The efficiency of the MediaPlayer depends.</param>
    /// <param name="position">The position in seconds where the thumbnail should be taken from.</param>
    /// <returns></returns>
    public byte[] GetThumbnail(string pathMediaFile, int waitTime, int position)
    {
        var player = new MediaPlayer
        {
            Volume = 0,
            ScrubbingEnabled = true,
        };

        try
        {
            player.Open(new(pathMediaFile));
            player.Pause();
            player.Position = TimeSpan.FromSeconds(position);

            //We need to give MediaPlayer some time to load. 
            //The efficiency of the MediaPlayer depends                 
            //upon the capabilities of the machine it is running on and 
            //would be different from time to time
            Thread.Sleep(waitTime * 1000);

            //120 = thumbnail width, 90 = thumbnail height and 96x96 = horizontal x vertical DPI
            //In an real application, you would not probably use hard coded values!
            var rtb = new RenderTargetBitmap(240, 180, 96, 96, PixelFormats.Pbgra32);
            var dv = new DrawingVisual();

            using (var dc = dv.RenderOpen())
                dc.DrawVideo(player, new(0, 0, 240, 180));

            rtb.Render(dv);
            var frame = BitmapFrame.Create(rtb).GetCurrentValueAsFrozen() as BitmapFrame;
            var encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(frame);
            using var ms = new MemoryStream();
            encoder.Save(ms);
            return ms.ToArray();
        }
        finally
        {
            player.Close();
        }
    }
}
