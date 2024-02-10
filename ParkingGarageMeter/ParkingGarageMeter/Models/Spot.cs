using System;
namespace ParkingGarageMeter.Models
{
	public class Spot
	{
		public Spot()
		{
		}

		public int SpotNumber { get; set; }
		public int Level { get; set; }
		public string License { get; set; }
	}
}
