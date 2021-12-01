using System;

namespace Garage
{
    public interface IElectricVehicle
    {

        void ChargeBattery();

        int CurrentChargePercentage { get; set; }
    }

    public interface IGasVehicle
    {
        void RefuelTank();

        int CurrentTankPercentage { get; set; }
    }

}