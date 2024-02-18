using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingGarageMeter.Models;



namespace ParkingGarageMeter.Controllers
{
    public class VehicleController : Controller
    {
        public readonly IVehicleRepository repo;

        public VehicleController(IVehicleRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAllVehicles()
        {
            var vehicles = repo.GetVehicles();
            return View(vehicles);
        }

        public IActionResult CreateVehicle(Vehicle vehicle)
        {
            repo.CreateVehicle(vehicle);

            return RedirectToAction("ViewAllVehicles");
        }

        public IActionResult Pay(string license)
        {
            var vehicle = repo.GetVehicle(license);
            return View(vehicle);
        }


        public IActionResult RemoveVehicle(Vehicle vehicle)
        {
            repo.RemoveVehicle(vehicle);
            return RedirectToAction("ViewAllVehicles");
        }
    }
}

