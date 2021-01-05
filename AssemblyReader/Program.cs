using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyReader
{
    class Program
    {
        static void Main(string[] args)
        {

            Assembly assemblyObject = Assembly.LoadFile("C:\\Users\\cstuser\\Downloads\\MarissaGoncalvesLab4\\AssemblyReader\\AssemblyReader\\bin\\Debug\\TracingApplication.exe");

            Type sampleEventSource = assemblyObject.GetType("TracingApplication.SampleEventSource");

            MethodInfo[] methodInformationArray = sampleEventSource.GetMethods();

            foreach(MethodInfo informationMethod in methodInformationArray)
            {
                Console.WriteLine("-> {0}", informationMethod.Name);
            }

            Console.WriteLine();

            object[] customAttributes = sampleEventSource.GetCustomAttributes(false);

            foreach(object attribute in customAttributes)
            {
                Console.WriteLine("Attribute: " + attribute.ToString());
            }

            Console.ReadKey();
        }
    }
}
