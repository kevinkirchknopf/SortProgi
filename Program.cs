using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int Most = DateTime.Now.Millisecond;
            SortArray(SzazezresTomb());
            int vege = DateTime.Now.Millisecond;
            Console.WriteLine(vege-Most);
           

            int Most2 = DateTime.Now.Millisecond;
            SortList(SzazezresList());
            int vege2 = DateTime.Now.Millisecond;
            Console.WriteLine(vege - Most);




        }


        static List<int> SortList(List<int> List)
        {
            List.Sort();

            return List;
        }

        static int[] SortArray(int[] array)
        {
            Array.Sort(array);
            return array;
        }

        static List<int> SzazezresList()
        {
            Random random = new Random();
            List<int> list = new List<int>(); 
            for(int i = 0; i < 100000; i++ )
            {
                list.Add(random.Next(0,100000));
             
            }
            return list;
        }


        static int[] SzazezresTomb()
        {
            Random random = new Random();
            int[] array = new int[100000];
            for (int i = 0; i < 100000; i++)
            {
                array.Append(random.Next(0, 100000));
               
            }
            return array;
        }

    }
}