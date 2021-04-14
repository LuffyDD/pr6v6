using System;

namespace pr6v6
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cp = new Class1();
            Console.WriteLine("Модель процесора ");
            cp.modelCPU = Console.ReadLine();
            Console.WriteLine("Країна виробник ");
            cp.country = Console.ReadLine();
            Console.WriteLine("кількість ядер ");
            cp.kernel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("присутня відеопамять");
            cp.VidCard = Console.ReadLine();
            Console.WriteLine("тип памяті ");
            cp.typeMemor = Console.ReadLine();
            Console.WriteLine("кількість потоків");
            cp.potokiv = Convert.ToInt32(Console.ReadLine());
            cp.CPUinfo();
        }
    }
    class Class1
    {
        public string modelCPU;
        public string country;
        public int kernel;
        public string VidCard;
        public string typeMemor;
        public int potokiv;
        public void CPUinfo()
        {
            Console.WriteLine(" Модель процесора : {0}\n країна виробник : {1}\n кількість ядер : {2}\n інтегрована відеопамять : {3}\n тип памяті : {4}\n кількість потоків : {5}", modelCPU, country, kernel, VidCard, typeMemor, potokiv);
        }
    }
}
