﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Painter.Interfaces;
using System.Threading.Tasks;
using Painter.Abstractions;

[assembly: Dependency(typeof(Painter.Forms.Droid.PainterExport))]
namespace Painter.Forms.Droid
{
    public class PainterExport : IPainterExport
    {
        IPainterExport nativePainter;

        public PainterExport()
        {
            nativePainter = new Painter.Droid.PainterExport();
        }

        public Task<byte[]> ExportCurrentImage(int width, int height, float scale, List<Stroke> strokes, Scaling scaling, ExportFormat format, int quality, Abstractions.Color BackgroundColor, bool useDevicePixelDensity, byte[] BackgroundImage = null)
        {
            return nativePainter.ExportCurrentImage(width, height, scale, strokes, scaling, format, quality, BackgroundColor, useDevicePixelDensity, BackgroundImage);
        }

        public Task<byte[]> GetCurrentImageAsJPG(int width, int height, float scale, List<Stroke> strokes, Scaling scaling = Scaling.Relative_None, int quality = 80, Abstractions.Color BackgroundColor = null, bool useDevicePixelDensity = false, byte[] BackgroundImage = null)
        {
            return nativePainter.GetCurrentImageAsJPG(width, height, scale, strokes, scaling, quality, BackgroundColor, useDevicePixelDensity, BackgroundImage);
        }

        public Task<byte[]> GetCurrentImageAsPNG(int width, int height, float scale, List<Stroke> strokes, Scaling scaling = Scaling.Relative_None, int quality = 80, Abstractions.Color BackgroundColor = null, bool useDevicePixelDensity = false, byte[] BackgroundImage = null)
        {
            return nativePainter.GetCurrentImageAsPNG(width, height, scale, strokes, scaling, quality, BackgroundColor, useDevicePixelDensity, BackgroundImage);
        }
    }
}