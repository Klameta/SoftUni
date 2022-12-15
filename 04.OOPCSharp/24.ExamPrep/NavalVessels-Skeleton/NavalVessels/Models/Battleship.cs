using System;
using System.Collections.Generic;
using System.Text;
using NavalVessels.Models.Contracts;

namespace NavalVessels.Models
{
    public class Battleship : Vessel, IBattleship
    {
        public Battleship(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, 300)
        {
        }
        public bool SonarMode { get; private set; }

        public void ToggleSonarMode()
        {
            if (SonarMode)
            {
                SonarMode = false;
                MainWeaponCaliber -= 40;
                Speed += 5;
            }
            else
            {
                SonarMode = true;
                MainWeaponCaliber += 40;
                Speed -= 5;
            }
        }
        public override void RepairVessel()
        {
            if (ArmorThickness < 300) ArmorThickness = 300;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Sonar mode: {(SonarMode ? "ON" : "OFF")}");

            return sb.ToString().TrimEnd();
        }
    }
}
