using AttributedCarLibrary;
using System;

namespace VehicleDescriptionAttributeReader
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** Value of VehicleDescriptionAttribute *****\n");
            ReflectOnAttributesUsingEarlyBinding();
            Console.ReadLine();
        }
        static void ReflectOnAttributesUsingEarlyBinding()
        {
            Type t = typeof(Winnebago);

            object[] customAtts = t.GetCustomAttributes(false);

            foreach (VehicleDescriptionAttribute v in customAtts)
                Console.WriteLine("->{0}", v.Description);
        }
    }
}
