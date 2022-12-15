using System;
using System.Collections.Generic;
using System.Text;
using NavalVessels.Models.Contracts;
using NavalVessels.Utilities.Messages;

namespace NavalVessels.Models
{
    public abstract class Vessel : IVessel
    {
        private string name;
        private ICaptain captain;
        private double armorThickness;
        private double mainWeaponCaliber;
        private double speed;
        private ICollection<string> targets;

        protected Vessel(string name, double mainWeaponCaliber, double speed, double armorThickness)
        {
            Name = name;
            MainWeaponCaliber = mainWeaponCaliber;
            Speed = speed;
            ArmorThickness = armorThickness;
            targets= new List<string>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(ExceptionMessages.InvalidVesselName);
                name = value;
            }
        }
        public double MainWeaponCaliber
        {
            get { return mainWeaponCaliber; }
            protected set
            {

                mainWeaponCaliber = value;
            }
        }
        public double Speed
        {
            get { return speed; }
            protected set
            {

                speed = value;
            }
        }
        public double ArmorThickness
        {
            get { return armorThickness; }
            set
            {

                armorThickness = value;
            }
        }
        public ICaptain Captain
        {
            get { return captain; }
            set
            {
                if (value == null) throw new NullReferenceException(ExceptionMessages.InvalidCaptainToVessel);
                captain = value;
            }
        }
        public ICollection<string> Targets => targets;

        public void Attack(IVessel target)
        {
            if (target == null) throw new NullReferenceException(ExceptionMessages.InvalidTarget);

            if (target.ArmorThickness < mainWeaponCaliber)
            {
                target.ArmorThickness = 0;
            }
            else
            {
                target.ArmorThickness -= mainWeaponCaliber;
            }

            targets.Add(target.Name);
        }
        public virtual void RepairVessel()
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"- {name}");
            sb.AppendLine($" *Type: {this.GetType().Name}");
            sb.AppendLine($" *Armor thickness: {armorThickness}");
            sb.AppendLine($" *Main weapon caliber: {mainWeaponCaliber}");
            sb.AppendLine($" *Speed: {speed} knots");

            sb.Append(" *Targets: ");
            if (targets.Count == 0) sb.Append("None");
            else sb.Append(String.Join(", ", targets));

            return sb.ToString().TrimEnd();
        }
    }
}
