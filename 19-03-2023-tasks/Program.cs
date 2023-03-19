using System;

namespace _19_03_2023_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string name = "Abbas Hesenli";
            //Console.WriteLine(name);
            //Console.WriteLine("========");

            //DeleteWhiteSpace(ref name);
            //Console.WriteLine(name);

            //int num;

            //int[] nums = { 1, 2, 3, 4, 5 };
            

            //Car car = new Car()
            //{
            //    Name = "Passenger car",
            //    Brand="Mersedes",
            //    Color="Green",
            //    Model="G class"
            //};

            //Console.WriteLine(car.GetInfo());

            Vehicle vehicle = new Vehicle("Bus");

            Car car2= new Car("Bus","Daewo");
            Console.WriteLine(car2.GetInfo());

        }

        static string DeleteWhiteSpace(ref string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    newStr += str[i];
                }
            }
            str = newStr;
            return str;
        }
    }
}
