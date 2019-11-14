using System;
using System.Collections.Generic;
using System.Text;

namespace _2019VSTrying
{

    class UkraineGeography : IMovable
    {
        public int Population { get; set; }
        public double Area { get; set; }
        public string District { get; set; }
        public int PopulationDensity() => Population / (int)Area;



        public void ShowInfoParticularDistrict() => Console.WriteLine($"District: {this.District}\n" +
            $"Area: {this.Area}\n" + $"Population: {this.Population}\n ");


        public static UkraineGeography operator +(UkraineGeography FirstDistrict, UkraineGeography SecondDistrict)
            => new UkraineGeography
            {
                District = FirstDistrict.District + " + " + SecondDistrict.District,
                Area = FirstDistrict.Area + SecondDistrict.Area,
                Population = FirstDistrict.Population + SecondDistrict.Population
            };




    }
}
