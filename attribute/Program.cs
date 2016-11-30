using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new test1() { Ab = true , At = 1 };


            foreach (var item in c.GetType().GetProperties())
            {
                var ca = item.GetCustomAttributes(true);
                if (ca != null  && ca.Count()>0)
                {
                    foreach (var prop in ca)
                    {
                        if (prop.GetType() == typeof(FileAttribute))
                        {
                            FileAttribute sc =  prop as FileAttribute;
                            Console.WriteLine($"item: {item.Name}: Ca:{sc.File}");
                        }
                    }
                }else
                {
                    Console.WriteLine($"item: {item.Name}:  NO CA");
                }

            }
            Console.Read();

        }
    }
}
