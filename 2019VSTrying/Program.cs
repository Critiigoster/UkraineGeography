using System;
using static System.Console;
using LINQ;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace _2019VSTrying
{

    class Program
    {
        private static object locker = new object();
        static int Wtf = 0;



        static void Main(string[] args) 
        {


            // Create like a database
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
            UkraineGeography[] NotUkraine = new UkraineGeography[] {
            new UkraineGeography { District = "Luhansk", Area = 26.684, Population = 2167802 },
            new UkraineGeography { District = "Donetsk", Area = 26.517, Population = 4200461 },
            new UkraineGeography { District = "Autonomous Republic of Crimea", Area = 26081, Population = 1968550 }
            };
            // Initialize indexes 
            Index BiggestArea = 0; Index SmallestArea = ^1; // First and Last in Array


            UkraineGeography BiggestOne = Ukraine[BiggestArea]; // Using objected indexes  instead of numeric ones
            UkraineGeography SmallestOne = Ukraine[SmallestArea]; // also -> Ukraine[^1]
            WriteLine(BiggestOne.ToString()); // Show Random district -> Biggest
            WriteLine(SmallestOne.ToString()); // Show Random district -> Smallest

            UkraineGeography CombinationBiggestAndSmallest = BiggestOne + SmallestOne; // Using operator 
            WriteLine(CombinationBiggestAndSmallest.ToString()); // Show Combination both: smallest and biggest 

            //  We do not have Autonomous Republic of Crimea and other not ukrainian lands; 
            // Let's add it trough Lists and create them: 
            List<UkraineGeography> UkraineAndNotUkraineNow = new List<UkraineGeography>(Ukraine);
            UkraineAndNotUkraineNow.AddRange(NotUkraine);
            // Here we got previous and Added elements 
            Console.WriteLine("Input District to look at info...");


             TaskAsyncFile(UkraineAndNotUkraineNow); // Supporting threading 


             // Looking for district by ReadLine
            while (true) { 

                string Put = ReadLine();
                if (Put == "Break" || Put == "break") break; // In order to stop loop

                //  Console.WriteLine("Ukraine don't consist that district"); - Here we got problem with it 


                var ShowDistrict = from Distr in UkraineAndNotUkraineNow
                               let Particular = Put
                               where Distr.District == Particular
                               select Distr;

                // Linq 
                

                foreach ( var item in ShowDistrict)
                {
                    WriteLine($"Your District -> {item.District};\nArea -> {item.Area};" +
                        $"\nPopulation -> {item.Population} ");
                                       
                }

                
            }    
            Console.WriteLine("You have aborted lookup");



           

            ReadLine();
        }

        // Add asynchronous method which will writes all countries at some file (.txt) 

        static async Task TaskAsyncFile(IList<UkraineGeography> FileInfoWillBe) {

            string path = @"D:\C#UNDWEB\2019VSTrying\2019VSTrying\AllCountriesFile.txt";

           try
            {
                using (StreamWriter asyncfileStream = new StreamWriter(path, false, System.Text.Encoding.Default)) 
                    // try .. finally (without close)
                {
                    foreach (var item in FileInfoWillBe) // all countries
                    await asyncfileStream.WriteLineAsync(item.ToString()); // async version for WriteLine()
                                                                
                }

            }
            catch (Exception aboutFile)
            {
                Console.WriteLine(aboutFile.Message);
            }
        }

        


    }
        


    }

