using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class Time : Interfaces.ISelectedMenuItemObserver
    {
        public void onSelectMenuItemInterface()
        {
            UtilsUI.showTime();
        }
    }
}
