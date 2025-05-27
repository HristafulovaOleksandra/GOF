using GOF_Lab2.Creational.FactoryExample;
using GOF_Lab2.Creational.SingletoneExample;

namespace GOF_Lab2.Creational
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singletone singletone =Singletone.getInstance();
            System.Console.WriteLine("Singletone Example");
            singletone.catMeow();

            FactoryFood factoryFood=new FactoryFood();
            Food food1 = factoryFood.getFood("burger");
            System.Console.WriteLine("Food's type is: " + food1.checkFood());
            Food food2 = factoryFood.getFood("cookie");
            System.Console.WriteLine("Food's type is: " + food2.checkFood());
        }
    }
}