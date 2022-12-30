namespace Laba5_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lastInput = "0";

            int count = 1000000;

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                if (input == "") 
                    continue;
                else if (input == "q") 
                    break;
                if (int.TryParse(input, out int result)) 
                    Console.WriteLine((char)result);
                if (Convert.ToDouble(input) == Convert.ToDouble(lastInput)) 
                    break;
                lastInput = input;

                count++;
            }
        }
    }
}