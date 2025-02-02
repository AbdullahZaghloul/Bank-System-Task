namespace Search2
{
    internal class Program
    {
        public static void MyString(string str)
        {
            if (str.Contains('a') || str.Contains('e') || str.Contains('i')
                || str.Contains('o') || str.Contains('u'))
                Console.WriteLine("this is okay!");
            else
                throw new VowelException("Exception: string does not contains a vowels!");
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter a string: ");
                MyString(Console.ReadLine());
            }
            catch(VowelException ve)
            {
                Console.WriteLine(ve.Message);
            }
        }
    }
}
