using System;

namespace UD9E6
{
    class Coche
    {

        public string marca;

        public string modelo;

        public int cilindrada;

        public double potencia;

        public Coche()
        {
            Console.WriteLine("Introduzca la marca del coche");
            marca = Console.ReadLine();
            Console.WriteLine("Introduzca el modelo del coche");
            modelo = Console.ReadLine();
            Console.WriteLine("Introduzca la cilindrada del coche");
            string cilindrada1 = Console.ReadLine();
            cilindrada = int.Parse(cilindrada1);
            Console.WriteLine("Introduzca la potencia del coche");
            string potencia1 = Console.ReadLine();
            potencia = double.Parse(potencia1);
        }

        public void Mostrar()
        {
            Console.WriteLine("Marca:" + marca);
            Console.WriteLine("Modelo:" + modelo);
            Console.WriteLine("Cilindrada:" + cilindrada);
            Console.WriteLine("Potencia:" + potencia);
        }
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();
            coche1.Mostrar();
            
            Console.ReadKey();
        }

    }
}
