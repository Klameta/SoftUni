using System;
using System.Collections.Generic;
using System.Text;
using NavalVessels.Core.Contracts;
using NavalVessels.Models;
using NavalVessels.Repositories;
using NavalVessels.Utilities.Messages;
using NavalVessels.Models.Contracts;
using System.Linq;

namespace NavalVessels.Core
{
    public class Controller : IController
    {
        private VesselRepository vessels;
        private List<ICaptain> captains;

        public Controller()
        {
            vessels = new VesselRepository();
            captains = new List<ICaptain>();
        }
        public string AssignCaptain(string selectedCaptainName, string selectedVesselName)
        {
            if (captains.FirstOrDefault(x => x.FullName == selectedCaptainName) == null) return $"Captain {selectedCaptainName} could not be found.";
            ICaptain captain = captains.FirstOrDefault(x => x.FullName == selectedCaptainName);

            if (vessels.FindByName(selectedVesselName) == null) return $"Vessel {selectedVesselName} could not be found.";
            IVessel vessel = vessels.FindByName(selectedVesselName);

            if (vessel.Captain != null) return $"Vessel {selectedVesselName} is already occupied.";

            vessel.Captain = captain;
            captain.AddVessel(vessel);
            return $"Captain {selectedCaptainName} command vessel {selectedVesselName}.";
        }

        public string AttackVessels(string attackingVesselName, string defendingVesselName)
        {
            var attackingvessel = vessels.FindByName(attackingVesselName);
            var defendingVessel = vessels.FindByName(defendingVesselName);

            if (attackingvessel == null)
                return $"Vessel {attackingVesselName} could not be found.";
            if (defendingVessel == null)
                return $"Vessel {defendingVesselName} could not be found.";

            if (attackingvessel.ArmorThickness == 0)
                return $"Unarmored vessel {attackingVesselName} cannot attack or be attacked.";
            if (defendingVessel.ArmorThickness == 0)
                return $"Unarmored vessel {defendingVesselName} cannot attack or be attacked.";

            attackingvessel.Attack(defendingVessel);
            defendingVessel.Captain.IncreaseCombatExperience();
            attackingvessel.Captain.IncreaseCombatExperience();

            return $"Vessel {defendingVesselName} was attacked by vessel {attackingVesselName} - current armor thickness: {defendingVessel.ArmorThickness}.";
        }

        public string CaptainReport(string captainFullName)
        {
            return captains.FirstOrDefault(x => x.FullName == captainFullName).Report();
        }

        public string HireCaptain(string fullName)
        {
            if (captains.FirstOrDefault(x => x.FullName == fullName) != null)
            {
                return $"Captain {fullName} is already hired.";
            }

            Captain captain = new Captain(fullName);
            captains.Add(captain);

            return $"Captain {fullName} is hired.";
        }

        public string ProduceVessel(string name, string vesselType, double mainWeaponCaliber, double speed)
        {
            if (vessels.FindByName(name) != null) return $"{vesselType} vessel {name} is already manufactured.";

            IVessel vessel;

            if (vesselType == "Submarine")
            {
                vessel = new Submarine(name, mainWeaponCaliber, speed);
            }
            else if (vesselType == "Battleship")
            {
                vessel = new Battleship(name, mainWeaponCaliber, speed);
            }
            else
            {
                return "Invalid vessel type.";
            }

            vessels.Add(vessel);
            return $"{vesselType} {name} is manufactured with the main weapon caliber of {mainWeaponCaliber} inches and a maximum speed of {speed} knots.";
        }

        public string ServiceVessel(string vesselName)
        {
            var vessel = vessels.FindByName(vesselName);
            if (vessel == null) return $"Vessel {vesselName} could not be found.";

            vessel.RepairVessel();
            return $"Vessel {vesselName} was repaired.";
        }

        public string ToggleSpecialMode(string vesselName)
        {
            if (vessels.FindByName(vesselName) != null)
            {
                var vessel = vessels.FindByName(vesselName);

                if (vessel.GetType().Name == "Battleship")
                {
                    Battleship battleship = (Battleship)vessel;
                    battleship.ToggleSonarMode();
                    return $"Battleship {vesselName} toggled sonar mode.";
                }

                if (vessel.GetType().Name == "Submarine")
                {
                    Submarine sub = (Submarine)vessel;
                    sub.ToggleSubmergeMode();
                    return $"Submarine {vesselName} toggled submerge mode.";
                }
            }

            return $"Vessel {vesselName} could not be found.";
        }

        public string VesselReport(string vesselName)
        {
            return vessels.FindByName(vesselName).ToString();
        }
    }
}
