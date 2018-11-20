using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        internal const int k_ReturnMenuItemIndex = 0;
        
        // Attributes
        private MenuItem m_RootMenu = new MenuItem(null, "Main Menu");
        private MenuItem m_CurrentMenu;

        // Methods
        public MenuItem RootMenu
        {
            get
            {
                return m_RootMenu;
            }

            set
            {
                m_RootMenu = value;
            }
        }

        public MainMenu()
        {
            m_CurrentMenu = m_RootMenu;
        }

        public void Show()
        {
            int selectedItemMenuIndex;
            bool isMenuOn = true;

            while (isMenuOn)
            {
                selectedItemMenuIndex = k_ReturnMenuItemIndex;

                if (MenuItem.isActionMenuItem(m_CurrentMenu))
                {
                    m_CurrentMenu.OnSelect();
                }
                else
                {
                    m_CurrentMenu.printSubMenu();
                    selectedItemMenuIndex = getUserInput();
                    Console.Clear();
                }

                if (m_CurrentMenu == m_RootMenu && selectedItemMenuIndex == k_ReturnMenuItemIndex)
                {
                    isMenuOn = false;
                }
                else
                {
                    m_CurrentMenu = m_CurrentMenu.SubMenus[selectedItemMenuIndex];
                }
            }
        }

        private int getUserInput()
        {
            int selectedItemMenuIndex;

            while (!(int.TryParse(Console.ReadLine(), out selectedItemMenuIndex) &&
                selectedItemMenuIndex >= 0 && selectedItemMenuIndex < m_CurrentMenu.SubMenus.Count))
            {
                Console.WriteLine("Invalid selected menu item, please try again:");
            }

            return selectedItemMenuIndex;
        }
    }
}