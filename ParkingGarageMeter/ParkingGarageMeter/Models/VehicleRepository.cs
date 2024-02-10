using System;

namespace ParkingGarageMeter.Models
{
	public class VehicleRepository : IVehicleRepository
    {
		public VehicleRepository()
		{
		}

        public bool CheckTime(int timePaid, int timePassed)
        {
            throw new NotImplementedException();
        }

        public void CreateVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicle()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            throw new NotImplementedException();
        }

        public void RemoveVehicle(int spotNumber)
        {
            throw new NotImplementedException();
        }

        public double updatePrice(double cost, double timeElapsed)
        {
            throw new NotImplementedException();
        }

        public int UpdateTimePassed()
        {
            throw new NotImplementedException();
        }
    }
}

