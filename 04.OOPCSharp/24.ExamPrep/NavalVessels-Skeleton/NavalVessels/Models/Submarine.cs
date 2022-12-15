using System;
using System.Collections.Generic;
using System.Text;
using NavalVessels.Models.Contracts;

namespace NavalVessels.Models
{
    public class Submarine : Vessel, ISubmarine
    {
        public Submarine(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, 200)
        {
        }

        public bool SubmergeMode { get; private set; }

        public void ToggleSubmergeMode()
        {
            if (SubmergeMode)
            {
                SubmergeMode = false;
                MainWeaponCaliber -= 40;
                Speed += 4;
            }
            else
            {
                SubmergeMode = true;
                MainWeaponCaliber += 40;
                Speed -= 4;
            }
        }
        public override void RepairVessel()
        {
            if (ArmorThickness < 200) ArmorThickness = 200;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Submerge mode: {(SubmergeMode ? "ON" : "OFF")}");

            return sb.ToString().TrimEnd();
        }
    }
}
