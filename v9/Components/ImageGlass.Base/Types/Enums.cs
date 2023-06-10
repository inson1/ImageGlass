﻿/*
ImageGlass Project - Image viewer for Windows
Copyright (C) 2010 - 2023 DUONG DIEU PHAP
Project homepage: https://imageglass.org

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

namespace ImageGlass.Base;


/// <summary>
/// Define the flags to tell FrmMain update the UI
/// </summary>
[Flags]
public enum UpdateRequests
{
    #pragma warning disable format

    None                = 0,
    Language            = 1 << 1,

    MouseActions        = 1 << 8,
    RealTimeFileUpdate  = 1 << 9,
    MenuHotkeys         = 1 << 10,

    ReloadImage         = 1 << 11,
    ReloadImageList     = 1 << 12,
    Slideshow           = 1 << 13,

    ToolbarAlignment    = 1 << 14,
    ToolbarIcons        = 1 << 15,
    Gallery             = 1 << 3,

    Appearance          = 1 << 6,
    Theme               = 1 << 7,

    #pragma warning restore format
}


/// <summary>
/// Color channels of image, the value should be same as MagickImage.Channels enum
/// </summary>
public enum ColorChannel
{
    All = -1, // not applicable

    Red = 1,
    Green = 2,
    Blue = 4,
    Black = 8,
    Alpha = 16,
}


/// <summary>
/// Color profile options.
/// </summary>
public enum ColorProfileOption
{
    None,
    Custom,
    CurrentMonitorProfile,

    // ImageMagick's profiles
    AdobeRGB1998,
    AppleRGB,
    CoatedFOGRA39,
    ColorMatchRGB,
    sRGB,
    USWebCoatedSWOP,
}


/// <summary>
/// Types of path
/// </summary>
public enum PathType
{
    File,
    Dir,
    Unknown,
}


/// <summary>
/// Determines Windows OS requirement
/// </summary>
public enum WindowsOS
{
    /// <summary>
    /// Build 22621
    /// </summary>
    Win11_22H2_OrLater,

    /// <summary>
    /// Build 22000
    /// </summary>
    Win11OrLater,
    Win10,
    Win10OrLater,
}


/// <summary>
/// Exit codes of ImageGlass ultilities
/// </summary>
public enum IgExitCode : int
{
    Done = 0,
    AdminRequired = 1,
    Error = 2,
    Error_FileNotFound = 3,
}


/// <summary>
/// Flip options.
/// </summary>
[Flags]
public enum FlipOptions
{
    None = 0,
    Horizontal = 1 << 1,
    Vertical = 1 << 2,
}


/// <summary>
/// Rotate option.
/// </summary>
public enum RotateOption
{
    Left = 0,
    Right = 1,
}


/// <summary>
/// Selection aspect ratio.
/// </summary>
public enum SelectionAspectRatio
{
    FreeRatio = 0,
    Custom = 1,
    Original = 2,
    Ratio1_1 = 3,
    Ratio1_2 = 4,
    Ratio2_1 = 5,
    Ratio2_3 = 6,
    Ratio3_2 = 7,
    Ratio3_4 = 8,
    Ratio4_3 = 9,
    Ratio9_16 = 10,
    Ratio16_9 = 11,
}


/// <summary>
/// Window backdrop effect.
/// </summary>
public enum BackdropStyle
{
    /// <summary>
    /// Use default setting of Windows.
    /// </summary>
    None = 0,

    /// <summary>
    /// Mica effect.
    /// </summary>
    Mica = 2,

    /// <summary>
    /// Acrylic effect.
    /// </summary>
    Acrylic = 3,

    /// <summary>
    /// Draw the backdrop material effect corresponding to a window with a tabbed title bar.
    /// </summary>
    MicaAlt = 4,
}


/// <summary>
/// Options indicate what source of image is saved.
/// </summary>
public enum ImageSaveSource
{
    Undefined,
    SelectedArea,
    Clipboard,
    CurrentFile,
}

