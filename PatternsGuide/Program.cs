using System;

namespace PatternsGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            char response = 'Y';
            int selection = 0;
            while(response == 'y' || response == 'Y')
            {
                Console.WriteLine("Please choose which pattern you want to run");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("1. AbstractFactoryPattern");
                Console.WriteLine("2. BuilderPatern");
                Console.WriteLine("3. FactoryPattern");
                Console.WriteLine("4. Prototype Pattern");
                Console.WriteLine("5. Singleton Pattern");
                Console.WriteLine("6. Adapter Pattern");
                Console.WriteLine("7. Bridge Pattern");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Press the appropriate number to check the pattern");
                selection = Int32.Parse(Console.ReadLine());
                
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Running AbstractFactory Pattern");
                        Console.WriteLine("----------------------------------");
                        var abstractFactoryPattern = new AbstractFactoryPattern.AbstractFactoryPattern();
                        abstractFactoryPattern.ImplementPattern();
                        Console.WriteLine("----------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("Running Builder Pattern");
                        Console.WriteLine("----------------------------------");
                        var builderPattern = new BuilderPattern.BuilderPattern();
                        builderPattern.ImplementPattern();
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("Running Factory Pattern");
                        Console.WriteLine("----------------------------------");
                        var factoryPattern = new FactoryPattern.FactoryPattern();
                        factoryPattern.ImplementPattern();
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 4:
                        Console.WriteLine("Running Prototype Pattern");
                        Console.WriteLine("----------------------------------");
                        var prototypePattern = new PrototypePattern.PrototypePattern();
                        prototypePattern.ImplementPattern();
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 5:
                        Console.WriteLine("Running Singleton Pattern");
                        Console.WriteLine("----------------------------------");
                        var singletonPattern = new SingletonPattern.SingletonPattern();
                        singletonPattern.ImplementPattern();
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 6:
                        Console.WriteLine("Running Adapter Pattern");
                        Console.WriteLine("----------------------------------");
                        var adapterPattern = new AdapterPattern.AdapterPattern();
                        adapterPattern.ImplementPattern();
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 7:
                        Console.WriteLine("Running Bridge Pattern");
                        Console.WriteLine("----------------------------------");
                        var bridgePattern = new BridgePattern.BridgePattern();
                        bridgePattern.ImplementPattern();
                        Console.WriteLine("-----------------------------------");
                        break;
                    default:
                        Console.WriteLine("No Option Selected");
                        break;
                }
                Console.WriteLine("Do you want to Continue? (Y/N)");
                response = Console.ReadLine()[0];
            }
        }
    }
}
