using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    class BossInfo
    {
        public string[] DungeonNames = {"Sunwell Plateau", "Black Temple", "Hyjal Summit", "Zul'Aman", "Tempest Keep", "Serpentshrine Cavern", "Magtheridon's Lair", "Gruul's Lair"};

        #region Values
        // SWP
        public string[] SWPNames = {"Kalecgos", "Brutallus", "Felmyst", "The Eredar Twins", "M'uru", "Kil'jaeden"};
        public int[] SWPArmor = {6200, 7700, 6200, 6200, 7700, 6200};

        // BT
        public string[] BTNames = {"High Warlord Naj'entus", "Supremus", "Shade of Akama", "Teron Gorefiend", 
                                   "Gurtogg Bloodboil", "Reliquary of Souls (Phase 1)", "Reliquary of Souls(Phase 2,3)", "Mother Shahraz",
                                   "Illidari Council", "Illidan Stormrage"};
        public int[] BTArmor = {7700, 7700, 7700, 6200, 
                                7700, 0, 7700, 6200,
                                6200, 7700};

        // MH
        public string[] MHNames = {"Rage Winterchill", "Anetheron", "Kaz'rogal", "Azgalor", "Archimonde"};
        public int[] MHArmor = {6200, 6200, 6200, 6200, 6200};

        // ZA
        public string[] ZANames = {"Nalorakk", "Akil'zon", "Jan'alai", "Halazzi", "Hex Lord Malacrass", "Zul'jin"};
        public int[] ZAArmor = {7700, 7700, 7700, 7700, 6200, 7700};

        // TK
        public string[] TKNames = {"Al'ar", "Void Reaver", "High Astromancer Solarian", "Kael'thas Sunstrider"};
        public int[] TKArmor = {7700, 8800, 6200, 6200};

        // SSC
        public string[] SSCNames = {"Hydross the Unstable", "The Lurker Below", "Leotheras the Blind", "Fathom-Lord Karathress", "Morogrim Tidewalker", "Lady Vashj"};
        public int[] SSCArmor = {7700, 7700, 7700, 6200, 7700, 6200};

        // ML
        public string[] MLNames = {"Magtheridon"};
        public int[] MLArmor = {7700};
                                
        // GL
        public string[] GLNames = {"High King Maulgar", "Gruul the Dragonkiller"};
        public int[] GLArmor = {7700, 7700};
        #endregion
    }
}
