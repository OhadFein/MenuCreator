﻿using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        // Attributes
        public event Action m_SelectMenuItemDelegates;

        private readonly List<MenuItem> m_SubMenus = new List<MenuItem>();

        public string m_Text
        {
            get; set;
        }

        // Properties
        public List<MenuItem> SubMenus
        {
            get
            {
                return m_SubMenus;
            }
        }

        // Methods
        internal static bool isActionMenuItem(MenuItem i_MenuItem)
        {
            return i_MenuItem.m_SubMenus.Count == 1;
        }

        public MenuItem(MenuItem i_PrevMenuItem, string i_Text)
        {
            m_SubMenus.Add(i_PrevMenuItem);
            m_Text = i_Text;

            if (i_PrevMenuItem != null)
            {
                i_PrevMenuItem.m_SubMenus.Add(this);
            }
        }

        internal void printSubMenu()
        {
            int menuItemIndex = MainMenu.k_ReturnMenuItemIndex;

            Console.WriteLine("{0}", this.m_Text);

            foreach (MenuItem menuItem in m_SubMenus)
            {
                if (menuItemIndex > MainMenu.k_ReturnMenuItemIndex)
                {
                    Console.WriteLine("{0}. {1}", menuItemIndex, menuItem.m_Text);
                }

                menuItemIndex++;
            }

            Console.WriteLine("{0}. {1}", MainMenu.k_ReturnMenuItemIndex, getReturnMenuItemText());
            Console.Write("Please enter your number choice: ");
        }

        private string getReturnMenuItemText()
        {
            string returnMenuItemText;

            if (m_SubMenus[MainMenu.k_ReturnMenuItemIndex] == null)
            {
                returnMenuItemText = "Exit";
            }
            else
            {
                returnMenuItemText = "Back";
            }

            return returnMenuItemText;
        }

        internal void OnSelect()
        {
            notifySelectedMenuItemObserver();
        }

        private void notifySelectedMenuItemObserver()
        {
            if (m_SelectMenuItemDelegates != null)
            {
                m_SelectMenuItemDelegates.Invoke();
            }
        }
    }
}
