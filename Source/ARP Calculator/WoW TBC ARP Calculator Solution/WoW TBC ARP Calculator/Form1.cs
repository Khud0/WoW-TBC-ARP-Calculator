using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
    public partial class Form1 : Form
    {
        // Cached References
        BossInfo BI = new BossInfo();
        BossLoader BL = new BossLoader();   
        
        // ARP Values
        int totalARP = 0;        
        int faerieFire = 610; int faerieFireOn = 0; // FF - Druid's Spell
        int cor = 800; int corOn = 0; // CoR - Warlock's curse
        int executioner = 840; int executionerOn = 0; // Executioner - Weapon Enchant Proc
        int sunderArmor = 520;  // Sunder Armor - Warrior's Proc from Devastate/Sunder Armor
        int exposeArmor = 410; // Expose Armor - Rogue's CP skill;
        int madness = 300; int madnessOn = 0; // Madness of The Betrayer - trinket's Proc
        int crystal = 200; int crystalOn = 0; // Crystal Yield - Un'goro Crystal consumable
        int coil = 1000; int coilOn = 0; // Warp-Spring Coil - Rogue's trinket
        int annihilator = 200; // Annihilator - Item


        public Form1()
        {
            InitializeComponent();
        }

        // Load the Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the Dungeon Options to the ListBox lbDungeonName
            LoadDungeonNames();
            // Load SWP as the first dungeon the User sees
            lbDungeonName.SelectedIndex = 0;
            BL.LoadBoss(BI.DungeonNames[0], lbBossName);
        }

        private void LoadDungeonNames()
        {
            //BossInfo BI = new BossInfo();
            foreach (string s in BI.DungeonNames)
            {
                lbDungeonName.Items.Add(s);
            }
        }

        private void lbBossName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of a currently selected boss
            int selectedBossIndex = lbBossName.SelectedIndex; // Find which index is Selected in the ListBox at the moment;
            int selectedBossArmor = BL.ReturnBossArmor(selectedBossIndex); // Find the amount of armor this boss has;
            tbBossArmor.Text = selectedBossArmor.ToString(); // Change the TextBox.Text value, but save the int above for calculations without converting back;
            
            // Change all the TextBox values
            UpdateChecks();
        }

        private void lbDungeonName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the name of a currently selected dungeon
            string currentName = lbDungeonName.GetItemText(lbDungeonName.SelectedItem);
            // 1 - Reset the space in the lbBossName, 2 - Load appropriate Boss Names
            BL.LoadBoss(currentName, lbBossName);
            // Reset the textboxes with armor values
            ResetTextBoxes();
            // Change all the TextBox values
            UpdateChecks(); 

            Debug.WriteLine("Loading: " + currentName);
        }

        private void ResetTextBoxes()
        {
            tbBossArmor.Text = "Boss Armor";
            tbBossArmorReduced.Text = "Armor After Reduction";
            tbPercent.Text = "DR%";
        }

        private void UpdateChecks()
        {
            // Turn the booleans into 1 or 0
            faerieFireOn = cbFaerieFire.Checked ? 1 : 0;
            corOn = cbCoR.Checked ? 1 : 0;
            executionerOn = cbExecutioner.Checked ? 1 : 0;
            madnessOn = cbMadness.Checked ? 1 : 0;
            crystalOn = cbCrystal.Checked ? 1 : 0;
            coilOn = cbCoil.Checked ? 1 : 0;
            // Calculate how much ARP you have in total and change the TextBox values
            CountArmorAfterReduction();
        }

        private void CountArmorAfterReduction()
        // Count the total ARP values with all the Checks
        {
            // Count the extra+passive ARP that user types in himself
            int myARP = 0;
            bool inputIsNotText = int.TryParse(tbPassiveARP.Text, out int passive);
            if (inputIsNotText) myARP += passive;
            bool inputIsNotText2 = int.TryParse(tbExtraARP.Text, out int extra);
            if (inputIsNotText2) myARP += extra;
            
            // Count if Expose Armor > Sunder Armor in this case
            float sunderARP = trackSunder.Value * sunderArmor;
            float exposeARP = trackExpose.Value * (1f + 0.25f*trackExposeImproved.Value) * exposeArmor; // 25% and 50% more armor reduction from Talents
            int highARP = (int)Math.Max(sunderARP, exposeARP); // Value to be used in the calculation

            // Count the total ARP values with all the Checks
            totalARP = (faerieFire*faerieFireOn) + (cor*corOn) + (executioner*executionerOn) + (madness*madnessOn)
                        + (crystal*crystalOn) + (coil*coilOn) + trackAnnihilator.Value*annihilator // Other Items, Skills and Consumables
                        + highARP // ARP From Expose Armor / Sunder Armor
                        + myARP; // ARP That user typed into the Passive and Extra ARP textboxes
            tbTotalARP.Text = totalARP.ToString();            

            // Change the Text in the Armor After Reduction textbox
            try
            {
                int currentBossAmror = int.Parse(tbBossArmor.Text);
                int armorAfterReduction = currentBossAmror-totalARP;
                // Change the colour to Red if you have too much arp
                if (armorAfterReduction <= 0) tbBossArmorReduced.ForeColor = Color.Red; else tbBossArmorReduced.ForeColor = Color.DarkCyan;
                //int armorClamp = armorAfterReduction<= 0 ? 0 : armorAfterReduction;
                tbBossArmorReduced.Text = armorAfterReduction.ToString();

                float damageReduction = (armorAfterReduction / (armorAfterReduction - 22167.5f + 467.5f * 70f)) * 100; // *100%
                // Clamp the value between 0% and 75%
                if (damageReduction < 0) damageReduction = 0;
                    else if (damageReduction > 75) damageReduction = 75;
                tbPercent.Text =  damageReduction.ToString("0.00") + "%";
            }
            catch { }
        }

        private void ResetForm()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = "";                   
            }
            foreach (TextBox tb in this.gbUser.Controls.OfType<TextBox>())
            {
                tb.Text = "";                   
            }
            foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
            {
                cb.Checked = false;
            }
            foreach (TrackBar tb in this.Controls.OfType<TrackBar>())
            {
                tb.Value = 0;
            }
            
            // Reset TextBox texts and Update the values;
            UpdateChecks();
            ResetTextBoxes();
            // Reset the Dungeon/Boss pickers;
            lbDungeonName.SelectedIndex = -1;
            lbBossName.SelectedIndex = -1;            
        }

        #region Update the values if you check(tick) anything
        private void cbFaerieFire_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChecks();
        }

        private void cbCoR_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChecks();
        }

        private void cbExecutioner_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChecks();
        }

        private void tbBossArmor_TextChanged(object sender, EventArgs e)
        {
            // Boss name should no longer be chosen, because user typed in custom Boss Armor values
            lbBossName.ResetText();
            lbDungeonName.ResetText();

            UpdateChecks();
        }

        private void cbMadness_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChecks();
        }

        private void cbCrystal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChecks();
        }

        private void cbCoil_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChecks();
        }

        private void tbExtraARP_TextChanged(object sender, EventArgs e)
        {
            UpdateChecks();
        }

        private void tbPassiveARP_TextChanged(object sender, EventArgs e)
        {
            UpdateChecks();
        }

        private void trackSunder_Scroll(object sender, EventArgs e)
        {
            UpdateChecks();
        }

        private void trackExpose_Scroll(object sender, EventArgs e)
        {
            UpdateChecks();
        }

        private void trackExposeImproved_Scroll(object sender, EventArgs e)
        {
            UpdateChecks();
        }

        private void trackAnnihilator_Scroll(object sender, EventArgs e)
        {
            UpdateChecks();
        }
        #endregion


        #region Menu Strip
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void khud0authorTwitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/Khud0Steam");
        }

        private void excaliburWoW243ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.excalibur.ws");
        }

        private void sourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Khud0/WoW-TBC-ARP-Calculator");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion        
    }  
}
