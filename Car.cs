using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Car
    {

        public string carManufacturer { get; set; }
        public string carModel { get; set; }
        public string regPlate { get; set; }

        public Car()
        {

            carManufacturer = "N/A";
            carModel = "N/A";
            regPlate = "N/A";

        }

        public Car(string manufacturer, string model, string regNo)
        {

            carManufacturer = manufacturer;
            carModel = model;
            regPlate = regNo;

        }

        public override string ToString()
        {

            return carManufacturer +
                " - " + carModel +
                " - " + regPlate;

        }

    }

    class AdvancedCar : Car
    {

        public DateTime lastService { get; set; }
        public DateTime lastMOT { get; set; }

        public AdvancedCar() : base()
        {

            carManufacturer = "N/A";
            carModel = "N/A";
            regPlate = "N/A";
            lastService = DateTime.Now;
            lastMOT = DateTime.Now;

        }

        public AdvancedCar(string manufacturer, string model, string regNo, DateTime lastServiceDate, DateTime lastMOTDate) : base(manufacturer, model, regNo)
        {

            carManufacturer = manufacturer;
            carModel = model;
            regPlate = regNo;
            lastService = lastServiceDate;
            lastMOT = lastMOTDate;

        }

        public override string ToString()
        {

            return carManufacturer +
                " - " + carModel +
                " - " + regPlate +
                " - " + lastService.ToShortDateString() +
                " - " + lastMOT.ToShortDateString();

        }

    }

}
