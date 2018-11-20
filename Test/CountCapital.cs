using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class CountCapital : Interfaces.ISelectedMenuItemObserver
    {
        public void onSelectMenuItemInterface()
        {
            UtilsUI.countCapitalLetterInput();
        }
    }
}
