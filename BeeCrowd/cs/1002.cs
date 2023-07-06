using System; 

class URI {

    static void Main(string[] args) { 

            double pi = 3.14159;
            double area, raio;
            raio = Convert.ToDouble(Console.ReadLine());
            area = pi * (raio * raio);
            Console.WriteLine("A={0}",area.ToString("F4"));
    }

}