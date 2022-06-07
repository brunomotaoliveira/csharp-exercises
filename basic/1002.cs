using System;

class URI {
    static void Main(string[] args) {
        double n = 3.14159;
        double raio = Convert.ToDouble(Console.ReadLine());

        double area =  n * (raio * 2);

        System.Console.WriteLine($"A={area}");
    }
}