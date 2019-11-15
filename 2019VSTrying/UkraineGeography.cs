using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace _2019VSTrying
{

    class UkraineGeography : IMovable   // , IComparer<UkraineGeography>
    {
        public int Population { get; set; }
        public double Area { get; set; }
        public string District { get; set; }

        //public int Compare(UkraineGeography one, UkraineGeography two)
        //{
        //    if (one.Area > two.Area) return 1;
        //    else if (one.Area < two.Area) return -1;
        //    else return 0;

        //}
        // Call CaseInsensitiveComparer.Compare with the parameters reversed.
        
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
