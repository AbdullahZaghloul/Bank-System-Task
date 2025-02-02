namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            Console.WriteLine("enter the numbers: ");
            while (true)
            {
                bool flag = false;
                int number = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i<ints.Count; i++)
                {

                    if (number == ints[i])
                        flag = true;
                }
                try
                {
                    if (flag)
                    {
                        throw new DuplicateException("Exception: the number is Duplicated!");
                    }
                    else
                    {
                        ints.Add(number);
                    }
                }
                catch(DuplicateException de)
                {
                    Console.WriteLine(de.Message);
                }
                
                
            }
        }
    }
}
