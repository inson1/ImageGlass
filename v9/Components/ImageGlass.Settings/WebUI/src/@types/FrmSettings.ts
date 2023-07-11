import Language from '@/common/Language';
import Settings from '@/FrmSettings/Settings';
import Sidebar from '@/FrmSettings/Sidebar';
import TabAppearance from '@/FrmSettings/TabAppearance';
import TabLanguage from '@/FrmSettings/TabLanguage';

export type ILanguage = {
  FileName: string,
  Metadata: Record<string, any> & {
    Code: string,
    EnglishName: string,
    LocalName: string,
    Author: string,
    MinVersion: string,
  },
};

export type ITool = {
  ToolId: string;
  ToolName: string;
  Executable: string;
  Arguments: string;
  IsIntegrated?: boolean;
  Hotkeys?: string[];
};

export type ITheme = {
  ConfigFilePath: string,
  FolderName: string,
  FolderPath: string,
  BgColor: string,
  IsDarkMode: boolean,
  PreviewImage: string,
  Info: Record<string, any> & {
    Name: string,
    Version: string,
    Author: string,
    Email: string,
    Website: string,
    Description: string,
  },
};

export type IPageSettings = Record<string, any> & {
  initTab: string,
  config: Record<string, any>,
  langList: ILanguage[],
  toolList: ITool[],
  themeList: ITheme[],
  startUpDir: string,
  configDir: string,
  userConfigFilePath: string,
  defaultThemeDir: string,
  enums: Record<string, string[]> & {
    ImageOrderBy: string[],
    ImageOrderType: string[],
    ColorProfileOption: string[],
    AfterEditAppAction: string[],
    ImageInterpolation: string[],
    MouseWheelAction: string[],
    MouseWheelEvent: string[],
    MouseClickEvent: string[],
    BackdropStyle: string[],
    ToolbarItemModelType: string[],
  },
  icons: Record<string, string> & {
    Delete: string,
    Edit: string,
    Sun: string,
    Moon: string,
  },
  FILE_MACRO: string;

  // global functions
  setSidebarActiveMenu?: typeof Sidebar.setActiveMenu,
  loadSettings?: typeof Settings.load,
  loadLanguageList?: typeof TabLanguage.loadLanguageList,
  loadBackgroundColorConfig?: typeof TabAppearance.loadBackgroundColorConfig;
};
