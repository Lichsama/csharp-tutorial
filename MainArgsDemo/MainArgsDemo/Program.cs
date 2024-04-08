namespace MainArgsDemo;
class Program
{
    static void Main(string[] args)
    {
        if(args.Length == 0)
        {
            Console.WriteLine("This is a smart app that users args ;) Please provide a argument next time. Write help for instructions");
            Console.ReadKey();
            return;
        }

        if (args[0] == "help")
        {
            Console.WriteLine("******************* Instructions");
            Console.WriteLine("* use one of the following commands followed by 2 numbers");
            Console.WriteLine("* 'add' : to add 2 numbers");
            Console.WriteLine("* 'subs' : to subtract 2 numbers");
            Console.ReadKey();

            return;
        }

        if(args.Length !=3)
        {
            Console.WriteLine("Invalid arguments, please use the help command for instructions");
            Console.ReadKey();
            return;
        }

        bool isNum1Parse = float.TryParse(args[0],out float num1);
        bool isNum2Parse = float.TryParse(args[1],out float num2);

        if(!isNum1Parse || !isNum2Parse)
        {
            Console.WriteLine("Invalid argumentsd");
            Console.ReadKey();
            return;
        }

        float result;

        switch (args[0])
        {
            case "add":
                result = num1 + num2;
                Console.WriteLine("The sum of {0}",result);
                break;


            case "sub":
                result = num1 - num2;
                Console.WriteLine("The sub of", result);
                break;


            default:
                Console.WriteLine("Invalid Argumentss");
                break;
        }

        Console.WriteLine("Hello " + args[0]);
        Console.ReadKey();
    }
}
