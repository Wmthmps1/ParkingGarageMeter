using System;
namespace ParkingGarageMeter.Models
{
	public interface IVehicleRepository
	{
		public void CreateVehicle(Vehicle vehicle);
		public IEnumerable<Vehicle> GetVehicles();
		public Vehicle GetVehicle(string license);
		public double CalculatePrice(int time);
		public int UpdateTimePassed();
		public bool CheckTime(int timePaid, int timePassed);
		public double updatePrice(double cost, double timeElapsed);
		public void RemoveVehicle(Vehicle vehicle);
	}
}

