using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class Date : Interfaces.ISelectedMenuItemObserver
    {
        public void onSelectMenuItemInterface()
        {
            UtilsUI.showDate();
        }
    }
}
