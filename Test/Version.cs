using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class Version : Interfaces.ISelectedMenuItemObserver
    {
        public void onSelectMenuItemInterface()
        {
            UtilsUI.showVersion();
        }
    }
}
