using System.Collections.Generic;
using JetBrains.Annotations;

namespace Automation {
    public class HouseholdData {
        public HouseholdData([NotNull] string householdGuid, double targetEnergyUse, double dailyCommutingDistance,
                             ElectricCarUse useElectricCar, [NotNull] string name, [CanBeNull] JsonReference chargingStationSet, [CanBeNull] JsonReference transportationDeviceSet, [CanBeNull] JsonReference travelRouteSet)
        {
            HouseholdGuid = householdGuid;
            TargetEnergyUse = targetEnergyUse;
            DailyCommutingDistance = dailyCommutingDistance;
            UseElectricCar = useElectricCar;
            Name = name;
            ChargingStationSet = chargingStationSet;
            TransportationDeviceSet = transportationDeviceSet;
            TravelRouteSet = travelRouteSet;
        }

        public double DailyCommutingDistance { get; set; }

        [NotNull]
        public string HouseholdGuid { get; set; }

        [NotNull]
        public string Name { get; set; }

        [NotNull]
        [ItemNotNull]
        public List<PersonData> Persons { get; set; } = new List<PersonData>();

        public double TargetEnergyUse { get; set; }
        public ElectricCarUse UseElectricCar { get; set; }
        [CanBeNull]
        public JsonReference ChargingStationSet { get; set; }
        [CanBeNull]
        public JsonReference TransportationDeviceSet { get; set; }
        [CanBeNull]
        public JsonReference TravelRouteSet { get; set; }
    }
}