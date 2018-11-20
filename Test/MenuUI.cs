using System;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class MenuUI
    {
        public readonly Interfaces.MainMenu m_MainMenuInterface = new Interfaces.MainMenu();
        public readonly Delegates.MainMenu m_MainMenuDelegate = new Delegates.MainMenu();

        // Interface menu
        private Interfaces.MenuItem m_ShowDateTimeMenuInterface;
        private Interfaces.MenuItem m_ShowTimeInterface;
        private Interfaces.MenuItem m_ShowDateInterface;
        private Interfaces.MenuItem m_VersionAndCapitalMenInterface;
        private Interfaces.MenuItem m_CountCapitalInterface;
        private Interfaces.MenuItem m_ShowVersionInterface;

        // Delegate menu
        private Delegates.MenuItem m_ShowDateTimeMenuDelegate;
        private Delegates.MenuItem m_ShowTimeDelegate;
        private Delegates.MenuItem m_ShowDateDelegate;
        private Delegates.MenuItem m_VersionAndCapitalMenDelegateu;
        private Delegates.MenuItem m_CountCapitalDelegate;
        private Delegates.MenuItem m_ShowVersionDelegate;

        public MenuUI()
        {
            showInterfaceMenu();
            showDelegateMenu();
        }

        private void showInterfaceMenu()
        {
            m_ShowDateTimeMenuInterface = new Interfaces.MenuItem(m_MainMenuInterface.RootMenu, "Show Date/Time");
            m_ShowTimeInterface = new Interfaces.MenuItem(m_ShowDateTimeMenuInterface, "Show Time");
            m_ShowTimeInterface.AttachObserver(new Time() as Interfaces.ISelectedMenuItemObserver);
            m_ShowDateInterface = new Interfaces.MenuItem(m_ShowDateTimeMenuInterface, "Show Date");
            m_ShowDateInterface.AttachObserver(new Date() as Interfaces.ISelectedMenuItemObserver);

            m_VersionAndCapitalMenInterface = new Interfaces.MenuItem(m_MainMenuInterface.RootMenu, "Version and Capitals");
            m_CountCapitalInterface = new Interfaces.MenuItem(m_VersionAndCapitalMenInterface, "Count Capital");
            m_CountCapitalInterface.AttachObserver(new CountCapital() as Interfaces.ISelectedMenuItemObserver);
            m_ShowVersionInterface = new Interfaces.MenuItem(m_VersionAndCapitalMenInterface, "Show Version");
            m_ShowVersionInterface.AttachObserver(new Version() as Interfaces.ISelectedMenuItemObserver);
        }

        private void showDelegateMenu()
        {
            m_ShowDateTimeMenuDelegate = new Delegates.MenuItem(m_MainMenuDelegate.RootMenu, "Show Date/Time");
            m_ShowTimeDelegate = new Delegates.MenuItem(m_ShowDateTimeMenuDelegate, "Show Time");
            m_ShowTimeDelegate.m_SelectMenuItemDelegates += UtilsUI.showTime;
            m_ShowDateDelegate = new Delegates.MenuItem(m_ShowDateTimeMenuDelegate, "Show Date");
            m_ShowDateDelegate.m_SelectMenuItemDelegates += UtilsUI.showDate;

            m_VersionAndCapitalMenDelegateu = new Delegates.MenuItem(m_MainMenuDelegate.RootMenu, "Version and Capitals");
            m_CountCapitalDelegate = new Delegates.MenuItem(m_VersionAndCapitalMenDelegateu, "Count Capital");
            m_CountCapitalDelegate.m_SelectMenuItemDelegates += UtilsUI.countCapitalLetterInput;
            m_ShowVersionDelegate = new Delegates.MenuItem(m_VersionAndCapitalMenDelegateu, "Show Version");
            m_ShowVersionDelegate.m_SelectMenuItemDelegates += UtilsUI.showVersion;
        }

        public void Show()
        {
            m_MainMenuInterface.Show();
            m_MainMenuDelegate.Show();
        }
    }
}
