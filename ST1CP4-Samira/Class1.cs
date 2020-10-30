using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ST1CP4_Samira
{
    class Class1
    {
        public void first()
        {
      
            Console.WriteLine("Enter your Name:");
            string myName = Console.ReadLine();
            Console.WriteLine("would you like to order food?");
            string anOrder = Console.ReadLine();
            

             if (anOrder == "yes") {  
                orderhere(); }
            
            else if (anOrder == "no")
            {
                exit();
            }
          
        }

        public void exit()
        {
            Console.WriteLine("OK bye then:)");
        }

        public void orderhere()

        {
            
            Console.WriteLine("Which one of our delicious pizzas you want to try? *-pizza romana *-pizza diavolo *-pizza tonno *-pizza formaggi *-pizza margarita");
            string pizza = Console.ReadLine();
            
            Console.WriteLine("which size: *-small *-big *-super");
            string size = Console.ReadLine();
            Console.WriteLine("would you like to add some drinks to your order");
            string somDrink = Console.ReadLine();
            if (somDrink == "yes") { 
                drink();}
            
            else if (somDrink == "no")
                Console.WriteLine("ok then, what time do you want your food at your door?");
            double ordTim = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("which payment method do you prefer? *-cash *-paypal *-credit card *-bitcoin");
            string payme = Console.ReadLine();
            Console.WriteLine("please enter your city:");
            string city = Console.ReadLine();
            Console.WriteLine("please enter your street name:");
            string street = Console.ReadLine();
            Console.WriteLine("please enter your house number:");
            double house = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter your phone number:");
            double phone = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("thank you");
           //Console.WriteLine("Thank you for ordering."+ myName+" here is details to your order: a "  + pizza + "size" + size + "would be delivered at: " +ordTim + "at " + city  + " " + street + " " + house);
        }

        public void drink()
        {
            Console.WriteLine("what kind of drink would you like? *-beer *-cola *-juice?");
            string mydrink = Console.ReadLine();
            Console.WriteLine("ok then, what time do you want your food at your door?");
            string ordTim = Console.ReadLine();
            Console.WriteLine("which payment method do you prefer? *-cash *-paypal *-credit card *-bitcoin");
            string payme = Console.ReadLine();
            Console.WriteLine("please enter your city:");
            string city = Console.ReadLine();
            Console.WriteLine("please enter your street number:");
            string street = Console.ReadLine();
            Console.WriteLine("please enter your house name:");
            double house = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter your phone number:");
            double phone = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("thank you");
            //Console.WriteLine("Thank you for ordering. here is details to your order: a "  + pizza + "size" + size + "would be delivered at: " +ordTim + "at " + city  + " " + street + " " + house);

        }
    }
}
