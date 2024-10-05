using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Variables

            //string CustomerName = "Dogukan";
            //string CustomerSurname = "Yeni";
            //string Customerphone = "+90 559 819 55 70";
            //string Customeremail = "dogukanyeni66@gmail.com";
            //string district = "Izmit";
            //string city = "Kocaeli";

            //Console.WriteLine("******** Reservasyon ******");
            //Console.WriteLine(" ");
            //Console.WriteLine("----------------------------------");

            //Console.WriteLine("Musteri: " + CustomerName + " " + CustomerSurname);
            //Console.WriteLine("Iletisim: " + Customerphone);
            //Console.WriteLine("Email Adresi: " + Customeremail);
            //Console.WriteLine("Bolge: " + district + "/" + city);
            //Console.WriteLine("----------------------------------");

            //Console.WriteLine(" ");

            // CustomerName = "Michael";
            // CustomerSurname = "Own";
            // Customerphone = "+90 552 577 06 17";
            // Customeremail = "michaelown05@gmail.com";
            // district = "Izmit";
            // city = "Kocaeli";

            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Musteri: " + CustomerName + " " + CustomerSurname);
            //Console.WriteLine("Iletisim: " + Customerphone);
            //Console.WriteLine("Email Adresi: " + Customeremail);
            //Console.WriteLine("Bolge: " + city + "/" + district );
            //Console.WriteLine("----------------------------------");


            #endregion

            #region Integer Variables

            int HamburgerPrice = 10;
            int PizzaPrice = 7;
            int FriesPrice = 5;
            int WaterPrice = 1;
            int ColaPrice = 2;
            int DesertPrice = 3;

            Console.WriteLine("****** Restaurant Menu Price ******");
            Console.WriteLine(" ");
            Console.WriteLine("---Hamburger: " + HamburgerPrice + " $");
            Console.WriteLine("---Pizza: " + PizzaPrice + " $");
            Console.WriteLine("---Fries: " + FriesPrice + " $");
            Console.WriteLine("---Water: " + WaterPrice + " $");
            Console.WriteLine("---Cola: " + ColaPrice + " $");
            Console.WriteLine("---Desert: " + DesertPrice + " $");
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------");

            int hamburgerCount = 1;
            int pizzaCount = 3;
            int friesCount = 2;
            int waterCount = 5;
            int colaCount = 4;
            int desertCount = 2;

            int totalHamburgerPrice = hamburgerCount * HamburgerPrice;
            int totalPizzaPrice = pizzaCount * PizzaPrice;
            int totalFriesPrice = friesCount * FriesPrice;
            int totalWaterPrice = waterCount * WaterPrice;
            int totalColaPrice = colaCount * ColaPrice;
            int totalDesertPrice = desertCount * DesertPrice;

            Console.WriteLine(" ");
            Console.WriteLine("Hamburger amount:" + totalHamburgerPrice + " $");
            Console.WriteLine("Pizza amount:" + totalPizzaPrice + " $");
            Console.WriteLine("Fries amount:" + totalFriesPrice + " $");
            Console.WriteLine("Water amount:" + totalWaterPrice + " $");
            Console.WriteLine("Cola amount:" + totalColaPrice + " $");
            Console.WriteLine("Desert amount:" + totalDesertPrice + " $");
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------------");

            int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalWaterPrice + totalColaPrice + totalDesertPrice;

            Console.WriteLine(" ");
            Console.WriteLine("Total Amount:" + totalPrice + " $");




            #endregion

            Console.Read();
        }
    }
}

        
