namespace ConsoleApp2
{
    internal class Programm
    {
        static void RMain(string[] args)
        {
            bool squaring;
            Console.WriteLine("Do you want to square a number? yes/no");
           string square = Console.ReadLine();
            if (square == "yes")  squaring = true;
            else if (square == "no")  squaring = false;

            if (squaring = false)
            {
                Console.WriteLine("Enter your first number:");


                string inp1 = Console.ReadLine();
                int num1 = Convert.ToInt32(inp1);



                Console.WriteLine("Enter your second number:");
                string inp2 = Console.ReadLine();
                int num2 = Convert.ToInt32(inp2);


                Console.WriteLine("Gib eine Operation (+ - / * )");
                string operation = Console.ReadLine();

                if (operation == "+")
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (operation == "-")
                {
                    Console.WriteLine(num1 - num2);
                }

                else if (operation == "/")
                {
                    Console.WriteLine(num1 / num2);
                }
                else if (operation == "*")
                {


                    Console.WriteLine(num1 * num2);


                }
            }
            
                
        
                
         
                

         
            
            else if (squaring = true)
            {
                Console.WriteLine("Enter your number:");
                string number = Console.ReadLine();
                double numberToSquare = Convert.ToDouble(number);

                Console.WriteLine(numberToSquare * numberToSquare);
            }


        }

    }
}