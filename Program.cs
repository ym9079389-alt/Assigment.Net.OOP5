using System.Drawing;
using System.Net;

namespace Assigment.Net.OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            #region a
            //a) What happens when you assign one object variable to another object variable?
            //Only the reference is copied, not the object itself. Both variables point to the same location in memory.
            #endregion

            #region b
            //Does assigning one object to another create a new object? Explain.
            //No.It only copies the reference in the Heap, so Both variables point to the same location in memory.
            #endregion

            #region c
            //c) What is the difference between copying an object and copying its reference ?
            //Copying Reference: Creates a new variable pointing to the same object.
            //Copying Object: Creates a new object in memory containing a copy of the original object.
            #endregion

           

            #endregion
        }
    }
}
