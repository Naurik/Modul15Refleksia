using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Modul15_Refleksia
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Console 
            Type console = typeof(Console);
            MethodInfo[] methods = console.GetMethods();
            Console.WriteLine("Список методов класса Console: \n");
            foreach (MethodInfo m in methods)
            {
                Console.Write(m.ReturnType.Name + "\t" + m.Name);
                Console.Write("\n");
            }
            Console.ReadLine();
            #endregion

            #region Refleksia
            Person person = new Person()
            {
                Name = "Muratzhan",
                Age = 16,
                City = "Nursultan"
            };
            Type type = typeof(Person);
            Console.WriteLine("Тип: " + type.Name);
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("Методы: ");
            foreach (var property in properties)
            {
                Console.WriteLine(property.PropertyType + ":\t" + property.Name);
            }
            Console.Read();
            #endregion
        }
    }
}
