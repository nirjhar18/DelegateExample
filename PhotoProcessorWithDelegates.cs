using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Create a delegate that takes photo as parameter and returns void.
    //You can use this delegate to call different methods
    //A delegate is like a pointer to a function. It is a reference
    //type data type and it holds the reference of a method. All the delegates are implicitly derived from System.Delegate class.

    class PhotoProcessorWithDelegates
    {
        //This is a custom delegate with void return type and photo type parameter
        //Delegate Syntax:
        //<access modifier> delegate <return type> <delegate_name>(<parameters>)
        public delegate void PhotoFilterHandler(Photo photo);

        //There are inbuilt .Net Delegates that you can use instead of
        //creating custom delegates
        //Inbuild Delegates
        //a) System.Func - Generic or Non-Generic - This can be used to specify the return type
        //b) System.Action - Generic or Non-Genric
        //Instead of passing parameter type of photo, you can pass Action
        //Example:With Generic Action. You do not need Delegate declaration

        public void Process(string path, Action<Photo> filterHandler)
        {
        }

        //Pass in delegate to this function using custom delegates
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            Photo photo = new Photo();
            photo = Photo.Load(path);

            //This code means that this does not know what filters will be applied.
            //Filters will be applied by client who is using this framework or
            //application. May be they only want to call one method. Also with delegate
            //clients will not have to recompile the code. They can create and add and call
            //methods they want.
            //In this example, review Program.cs for code example on client(Consumer or developer of the frameowkr)
            //that will use this delegate to call methods.
            filterHandler(photo);

           
        }
    }
}
