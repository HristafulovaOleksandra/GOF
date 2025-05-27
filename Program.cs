namespace GOF_Lab2.Creational
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            Singletone singletone =Singletone.getInstance();
            singletone.catMeow();
        }
    }
}