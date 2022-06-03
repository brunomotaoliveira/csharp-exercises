using System; 

class URI {

    static void Main(string[] args) { 

        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int x = a + b;
        string result = $"X = {x}";
        System.Console.WriteLine(result);
    }

}