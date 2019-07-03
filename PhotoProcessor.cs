using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class PhotoProcessor
    {
        //Delegates is a reference to a function
        //An object that knows how to call a method(or a group of methods)

        //Delegates are used to create extensible applications or frameworks.
        //For example: If photo processor is a framework and client wants to use this class 
        //but only call one of the methods, this design will not work so it is better to use a
        //delegate that will be used to call an function.
        public void Process(string path)
        {
             Photo photo = new Photo();
             photo =  Photo.Load(path);

            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);
        }
    }
}
