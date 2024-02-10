﻿using System;
namespace ParkingGarageMeter.Models
{
	public class Vehicle
	{
		public Vehicle()
		{
		}

		public string License { get; set; }
		public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
		public int TimePaidFor { get; set; }
		public int TimePassed { get; set; }
		public double Cost { get; set; }
		public int TimeElapsed { get; set; }

    }
}