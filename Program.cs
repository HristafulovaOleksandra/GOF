using GOF.Behavioral.CoRExample;
using GOF.Behavioral.MediatorExample;
using GOF.Behavioral.ObserverExample;
using GOF.Behavioral.TemplateMethodExample;
using GOF.Structural.AdapterExample;
using GOF.Structural.BridgeExample;
using GOF.Structural.ComponentExample;
using GOF.Structural.DecoratorExample;
using GOF.Structural.FacadeExample;
using GOF.Structural.FlyweightExample;
using GOF.Structural.ProxyExample;
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
            int option=0;
            bool run = true;
            while (run) 
            {
                System.Console.WriteLine("Choose lab :");
                System.Console.WriteLine("1. Creational");
                System.Console.WriteLine("2. Stuctural");
                System.Console.WriteLine("3. Behavioral");
                System.Console.WriteLine("else. EXIT");

                option=int.Parse(System.Console.ReadLine());
                switch (option)
                {
                    case 1://CREATIONAL
                        {
                            Singletone singletone = Singletone.getInstance();
                            System.Console.WriteLine("--------------------------Singletone Example--------------------------");
                            System.Console.WriteLine(" ");
                            singletone.catMeow();

                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("--------------------------Factory Example--------------------------");
                            System.Console.WriteLine(" ");
                            FactoryFood factoryFood = new FactoryFood();
                            IFood food1 = factoryFood.getFood("burger");
                            System.Console.WriteLine("IFood's type is: " + food1.checkFood());
                            IFood food2 = factoryFood.getFood("cookie");
                            System.Console.WriteLine("IFood's type is: " + food2.checkFood());

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
                            break;

                        }
                    case 2://STUCTURAL
                        {
                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("--------------------------Adapter Example--------------------------");
                            System.Console.WriteLine(" ");
                            EuropeanPlug europeanPlug = new EuropeanPlug();
                            IAmericanSocket socket = new SocketAdapter(europeanPlug);
                            socket.PlugInAmerican();

                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("--------------------------Composit Example--------------------------");
                            System.Console.WriteLine(" ");
                            MenuItem burger = new MenuItem("Burger");
                            MenuItem salad = new MenuItem("Salad");
                            MenuItem coffee = new MenuItem("Coffee");

                            Menu lunchMenu = new Menu("Lunch");
                            lunchMenu.Add(burger);
                            lunchMenu.Add(salad);

                            Menu mainMenu = new Menu("Main menu");
                            mainMenu.Add(lunchMenu);
                            mainMenu.Add(coffee);
                            mainMenu.Display();

                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("--------------------------Proxy Example--------------------------");
                            System.Console.WriteLine(" ");
                            IVideo video = new ProxyVideo("filmAboutPatterns.mp4");
                            Console.WriteLine("First Play():");
                            video.Play(); //make RealVideo
                            Console.WriteLine("\nSecond Play():");
                            video.Play(); //don't make again

                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("--------------------------Lightweight Example--------------------------");
                            System.Console.WriteLine(" ");
                            List<Tree> forest = new List<Tree>();
                            forest.Add(new Tree(10, 20, TreeFactory.GetTreeType("AppleTree", "Green")));
                            forest.Add(new Tree(15, 25, TreeFactory.GetTreeType("AppleTree", "Green")));
                            forest.Add(new Tree(50, 80, TreeFactory.GetTreeType("PineTree", "Dark-Green")));
                            foreach (var tree in forest)
                            {
                                tree.Draw();
                            }

                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("--------------------------Facade Example--------------------------");
                            System.Console.WriteLine(" ");
                            TV tv = new TV();
                            AudioSystem audio = new AudioSystem();
                            Lights lights = new Lights();
                            DVDPlayer dvd = new DVDPlayer();

                            HomeTheaterFacade homeTheater = new HomeTheaterFacade(tv, audio, lights, dvd);
                            homeTheater.WatchMovie();

                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("--------------------------Bridge Example--------------------------");
                            System.Console.WriteLine(" ");
                            IMessageSender email = new EmailSender();
                            IMessageSender sms = new SMSSender();

                            Message regularEmail = new RegularMessage(email);
                            Message urgentSMS = new UrgentMessage(sms);

                            regularEmail.Send("Hello!");
                            urgentSMS.Send("Call me ASAP!");

                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("--------------------------Decorator Example--------------------------");
                            System.Console.WriteLine(" ");
                            IClothing outfit = new TShirt();
                            outfit = new ScarfDecorator(outfit);
                            outfit = new JacketDecorator(outfit);
                            outfit.Wear();
                            break;
                        }
                    case 3://BEHAVIORAL
                        {
                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("--------------------------Template Method Example--------------------------");
                            System.Console.WriteLine(" ");
                            Beverage tea = new Tea();
                            Console.WriteLine("Making tea...");
                            tea.PrepareRecipe();
                            Console.WriteLine();
                            Beverage coffee = new Coffee();
                            Console.WriteLine("Making coffee...");
                            coffee.PrepareRecipe();

                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("--------------------------Mediator Example--------------------------");
                            System.Console.WriteLine(" ");
                            IChatRoomMediator chatRoom = new ChatRoom();

                            User user1 = new User("Sasha", chatRoom);
                            User user2 = new User("Oleksandr", chatRoom);

                            user1.Send("Hello, Oleksandr!");
                            user2.Send("Hi, Sasha! How are you?");

                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("--------------------------Chain of Responsobility Example--------------------------");
                            System.Console.WriteLine(" ");
                            Handler low = new LowLevelHandler();
                            Handler medium = new MediumLevelHandler();
                            Handler high = new HighLevelHandler();

                            low.SetNext(medium);
                            medium.SetNext(high);

                            int[] requests = { 1, 2, 3, 4 };

                            foreach (var request in requests)
                            {
                                low.HandleRequest(request);
                            }

                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("--------------------------Observer Example--------------------------");
                            System.Console.WriteLine(" ");
                            WeatherStation station = new WeatherStation();

                            IObserver phone = new PhoneDisplay();
                            IObserver window = new WindowDisplay();

                            station.RegisterObserver(phone);
                            station.RegisterObserver(window);

                            station.SetTemperature(22.5f);
                            station.SetTemperature(25.0f);

                            station.RemoveObserver(window);
                            station.SetTemperature(20.0f);
                            break;
                        }
                    default://EXIT
                        {
                            run = false;
                            break;
                        }

                }
            }
        }
    }
}