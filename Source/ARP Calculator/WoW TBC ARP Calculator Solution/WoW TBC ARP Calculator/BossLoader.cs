using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Copyright © 2019 Khud0. All rights reserved.
   
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

namespace WoW_TBC_ARP_Calculator
{
    class BossLoader
    {
        // Reference
        BossInfo BI = new BossInfo(); // Create a BossArmor object to get the values from               
        List<string> bossNames = new List<string>(); // A temporary list to store the loaded values   
        List<int> bossArmorValues = new List<int>(); // Create a temporary list to store the loaded values   

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of the Dungeon to load Bosses from</param>
        /// <param name="lbBoss">Reference to the Boss ListBox in the Form1.cs</param>
        /// <returns></returns>
        public void LoadBoss(string dungeonName, ListBox lbBoss)
        {
            // Reset the text in the BossName listbox
            ResetBossNameList(lbBoss);

            // Choose which names to load from the BossInfo.cs
            LoadFromBossInfo(dungeonName);

            // Load these names to the lbBossNames
            if (bossNames.Count > 0)
            {
                UpdateTheListBox(lbBoss, bossNames.ToArray());
            }
        }       

        private void ResetBossNameList(ListBox lb)
        {
            lb.Items.Clear();
        }

        private void UpdateTheListBox(ListBox lb, string[] names)
        {
            foreach (string s in names)
            {
                lb.Items.Add(s);
            }
        }

        public int ReturnBossArmor(int bossIndex)
        {
            if (bossIndex < bossArmorValues.Count) return bossArmorValues[bossIndex]; else return 9999;
        }

        #region Please Don't Show This Code To Anyone
        private void LoadFromBossInfo(string dungeonName)
        {
            string[] listNames;
            int[] listArmor;

            // Define which list (array) to pick values from
            switch (dungeonName)
            {
                case "Sunwell Plateau":
                    listNames = BI.SWPNames;
                    listArmor = BI.SWPArmor;
                break;

                case "Black Temple":
                    listNames = BI.BTNames;
                    listArmor = BI.BTArmor;
                break;

                case "Hyjal Summit":
                    listNames = BI.MHNames;
                    listArmor = BI.MHArmor;
                break;

                case "Zul'Aman":
                    listNames = BI.ZANames;
                    listArmor = BI.ZAArmor;
                break;

                case "Tempest Keep":
                    listNames = BI.TKNames;
                    listArmor = BI.TKArmor;
                break;

                case "Serpentshrine Cavern":
                    listNames = BI.SSCNames;
                    listArmor = BI.SSCArmor;
                break;

                case "Magtheridon's Lair":
                    listNames = BI.MLNames;
                    listArmor = BI.MLArmor;
                break;

                case "Gruul's Lair":
                    listNames = BI.GLNames;
                    listArmor = BI.GLArmor;
                break;
                    
                default:
                    listNames = BI.SWPNames;
                    listArmor = BI.SWPArmor;
                break;
            }

            // Reset and Update the Names List
            if (listNames.Length > 0)
            {
                bossNames.Clear();
                foreach (string s in listNames)
                {
                    bossNames.Add(s);
                }
            }

            // Reset and Update the Armor Values List
            if (listArmor.Length > 0)
            {
                bossArmorValues.Clear();
                foreach (int val in listArmor)
                {
                    bossArmorValues.Add(val);
                }
            }
        }
        #endregion
    }
}
