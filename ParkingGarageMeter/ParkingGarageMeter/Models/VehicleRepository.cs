using System;
using System.Data;
using Dapper;

namespace ParkingGarageMeter.Models
{
	public class VehicleRepository : IVehicleRepository
    {
        private readonly IDbConnection _conn;

        public VehicleRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void CreateVehicle(Vehicle vehicle)
        {
            _conn.Execute("INSERT INTO cars (LICENSE, MAKE, MODEL, COLOR, TIMEPAIDFOR, TIMEPASSED, COST) VALUES " +
                "(@license, @make, @model, @color, @timePaidFor,@timePassed @cost);",
            new { license = vehicle.License, make = vehicle.Make, model = vehicle.Model,
            color = vehicle.Color, timePaidFor = vehicle.TimePaidFor, timePassed = 0, cost = vehicle.Cost});
            
        }
       
        public IEnumerable<Vehicle> GetVehicles()
        {
            return _conn.Query<Vehicle>("SELECT * FROM CARS;");
        }

        public bool CheckTime(int timePaid, int timePassed)
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicle()
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

