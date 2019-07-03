using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        //Code Example for consumer of framework
        static void Main(string[] args)
        {
            var processor = new PhotoProcessorWithDelegates();
            var filters = new PhotoFilters();

            //Create an instance of the delegate
            //filterHandler is a delegate or pointer to a function
            //Delegates derive from Multicast delegate which means it can have
            //multiple functions/method attached to it. To check you can debug and review
            //the check the filterHandler delegate innvocation List

            PhotoProcessorWithDelegates.PhotoFilterHandler filterHandler = filters.ApplyBrightness;

            //With Inbuilt .Net Delegates
            Action<Photo> filterHandlerGeneric = filters.ApplyBrightness;

            //Call another method
            filterHandler += filters.ApplyContrast;
            //Call your own method that is how delegates makes
            //the framework extensible. We added a new method and called the method without
            //changing the PhotoProcessWithDelegates Class
            filterHandler += RemoveRedEyeFilter;
            processor.Process("Test.jpg", filterHandler);
        }

        //Create a new method which should match with delegate
        //return type and parameters

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Remove Red eye");
        }
    }
}
