﻿

using ImageGlass.Settings;
using ImageGlass.UI;

namespace ImageGlass;


/* ****************************************************** *
 * FrmMain.Theme contains methods for dynamic binding     *
 * ****************************************************** */

public partial class FrmMain
{

    public void SetUpFrmMainTheme()
    {
        UpdateTheme();
    }


    private void UpdateTheme(SystemThemeMode mode = SystemThemeMode.Unknown)
    {
        var themMode = mode;
        
        if (mode == SystemThemeMode.Unknown)
        {
            themMode = ThemeUtils.GetSystemThemeMode();
        }

        // correct theme mode
        var isDarkMode = themMode != SystemThemeMode.Light;


        // set theme
        Toolbar.Theme =
            MnuMain.Theme = Config.Theme;

        // background
        BackColor = Config.Theme.Settings.BgColor;

        // Thumbnail bar
        Sp1.SplitterBackColor =
            PanBot.BackColor = Config.Theme.Settings.ThumbnailBarBgColor;

        // Side panels
        Sp2.SplitterBackColor =
            Sp3.SplitterBackColor =
            PanLeft.BackColor =
            PanRight.BackColor = Config.Theme.Settings.ThumbnailBarBgColor;


    }

}
