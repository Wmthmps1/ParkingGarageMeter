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

            _conn.Execute("INSERT INTO CARS (LEVEL, SPOTNUMBER, LICENSE, MAKE, MODEL, COLOR, TIMEPAIDFOR, COST) VALUES " +
                "(@level, @spotNumber, @license, @make, @model, @color, @timePaidFor, @cost);",
            new { level = vehicle.Level, spotNumber = vehicle.SpotNumber, license = vehicle.License,
                make = vehicle.Make, model = vehicle.Model,color = vehicle.Color, timePaidFor = vehicle.TimePaidFor,
            cost = CalculatePrice(vehicle.TimePaidFor)});
            
        }
       
        public IEnumerable<Vehicle> GetVehicles()
        {
            return _conn.Query<Vehicle>("SELECT * FROM CARS;");
        }

        public double CalculatePrice(int time)
        {
            return (time * 5);
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

