namespace ConsoleApp1.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Ingrese la diagonal mayor:");
            var DM = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la diagonal menor:");
            var dm = int.Parse(Console.ReadLine());

            var  ladoRombo = Math.Sqrt(Math.Pow(DM / 2, 2) + Math.Pow(dm / 2, 2));
            var perimetro = ladoRombo * 4;
            var superficie = (DM * dm) / 2;

            Console.WriteLine($"El lado es {ladoRombo:N2}");
            Console.WriteLine($"El perimetro es {perimetro:N2}");
            Console.WriteLine($"La superficie es {superficie}");





        }
    }
}
