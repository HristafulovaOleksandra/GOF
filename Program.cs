using GOF_Lab2.Creational.AbstractFactoryExample;
using GOF_Lab2.Creational.BuilderExample;
using GOF_Lab2.Creational.FactoryExample;
using GOF_Lab2.Creational.PrototypeExample;
using GOF_Lab2.Creational.SingletoneExample;

namespace GOF_Lab2.Creational
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singletone singletone =Singletone.getInstance();
            System.Console.WriteLine("--------------------------Singletone Example--------------------------");
            System.Console.WriteLine(" ");
            singletone.catMeow();

            System.Console.WriteLine(" ");
            System.Console.WriteLine("--------------------------Factory Example--------------------------");
            System.Console.WriteLine(" ");
            FactoryFood factoryFood=new FactoryFood();
            Food food1 = factoryFood.getFood("burger");
            System.Console.WriteLine("Food's type is: " + food1.checkFood());
            Food food2 = factoryFood.getFood("cookie");
            System.Console.WriteLine("Food's type is: " + food2.checkFood());

            System.Console.WriteLine(" ");
            System.Console.WriteLine("--------------------------Abstract Factory Example--------------------------");
            System.Console.WriteLine(" ");
            IFurnitureFactory factory = new ModernFurnitureFactory();
            IChair chair = factory.CreateChair();
            ITable table = factory.CreateTable();
            chair.SitOn();
            table.PutOn();
            factory = new VictorianFurnitureFactory();
            chair = factory.CreateChair();
            table = factory.CreateTable();
            chair.SitOn();
            table.PutOn();

            System.Console.WriteLine(" ");
            System.Console.WriteLine("--------------------------Builder Example--------------------------");
            System.Console.WriteLine(" ");
            var cook = new Cook();
            var classicBuilder = new ClassicBurgerBuilder();
            cook.MakeBurger(classicBuilder);
            Burger classicBurger = classicBuilder.GetBurger();
            classicBurger.Show();
            var veggieBuilder = new VeggieBurgerBuilder();
            cook.MakeBurger(veggieBuilder);
            Burger veggieBurger = veggieBuilder.GetBurger();
            veggieBurger.Show();

            System.Console.WriteLine(" ");
            System.Console.WriteLine("--------------------------Prototype Example--------------------------");
            System.Console.WriteLine(" ");
            Circle circle = new Circle
            {
                X = 10,
                Y = 20,
                Color = "Red",
                Radius = 15
            };

            Circle clonedCircle = (Circle)circle.Clone();

            Rectangle rectangle = new Rectangle
            {
                X = 5,
                Y = 5,
                Color = "Blue",
                Width = 30,
                Height = 40
            };

            Rectangle clonedRectangle = (Rectangle)rectangle.Clone();
            circle.Show();
            clonedCircle.Show();
            rectangle.Show();
            clonedRectangle.Show();
        }
    }
}