using System;
using System.Collections.Generic;
using System.Text;

namespace _19_03_2023_tasks
{
    internal class Car:Vehicle
    {
        public Car(string name,string brand):base(name)
        {
            Brand = brand;
            Price = 12000;
        }

        public string Brand;
        public string Model;
        public double Price;

        public string GetInfo()
        {
           return  $"Name : {Name} \nColor : {Color} \nBrand : {Brand} \nModel : {Model} \nPrice : {Price}";
        }
    }
}
