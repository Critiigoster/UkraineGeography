using System;
using static System.Console;
using LINQ;
using System.Collections.Generic;


namespace _2019VSTrying
{
   
    class Program 
    {
       
        


        static void Main(string[] args)
        {


            UkraineGeography[] Ukraine = new UkraineGeography[]{
        new UkraineGeography {District = "Odesa" , Area = 33.310, Population = 2383075 },
        new UkraineGeography {District = "Dnipropetrovsk" , Area = 31.914, Population = 3231140 },
        new UkraineGeography {District = "Chernihiv" , Area = 33.865, Population = 1020078 },
        new UkraineGeography {District = "Kherson" , Area = 28.461, Population = 1046981 },
        new UkraineGeography {District = "Kharkiv" , Area = 31.415, Population = 2694007 },
        new UkraineGeography {District = "Zhytomyr" , Area = 29.832, Population = 1231239 },
        new UkraineGeography {District = "Vinnytsia" , Area = 26.513, Population = 1575808 },
        new UkraineGeography {District = "Poltava" , Area = 28.748, Population = 1413829 },
        new UkraineGeography {District = "Kiev" , Area = 29.131, Population = 2934522  },
        new UkraineGeography {District = "Ivano-Frankivsk" , Area = 13.900, Population = 1377496 },
        new UkraineGeography {District = "Zaporizhia" , Area = 27.180, Population = 1721171 },
        new UkraineGeography {District = "Luhansk" , Area = 26.684, Population =2167802  },
        new UkraineGeography {District = "Donetsk" , Area = 26.517, Population = 4200461 },
        new UkraineGeography {District = "Kirovohrad" , Area = 24.588, Population = 956250  },
        new UkraineGeography {District = "Lviv" , Area = 21.833, Population =2529608  },
        new UkraineGeography {District = "Mykolaiv" , Area = 24.598, Population = 1141324 },
        new UkraineGeography {District = "Cherkasy" , Area = 20.900, Population = 1220363 },
        new UkraineGeography {District = "Khmelnytskyi" , Area = 20.645, Population = 1274409 },
        new UkraineGeography {District = "Rivne" , Area = 20.047, Population = 1160647 },
        new UkraineGeography {District = "Ternopil" , Area = 13.823, Population = 1052312 },
        new UkraineGeography {District = "Sumy" , Area = 23.834, Population = 1094284 },
        new UkraineGeography {District = "Zakarpattia" , Area = 12.777, Population = 1258155 },
        new UkraineGeography {District = "Chernivtsi" , Area = 8.097, Population = 906701 }


        };

            UkraineGeography BiggestOne = Ukraine[0];
            UkraineGeography SmallestOne = Ukraine[Ukraine.Length - 1];
            BiggestOne.ShowInfoParticularDistrict(); // Show Random district -> Biggest
            SmallestOne.ShowInfoParticularDistrict(); // Show Random district -> Smallest

            UkraineGeography CombinationBiggestAndSmallest = BiggestOne + SmallestOne; // Using operator 
            CombinationBiggestAndSmallest.ShowInfoParticularDistrict(); // Show Combination both: smallest and biggest 
                       


            ReadLine();
         }

        
    }
}
