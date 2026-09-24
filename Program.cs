using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Numerics;
using System.Reflection.Metadata;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigment.Net.OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Object Copying

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

            #region Shallow Copy vs Deep Copy

            #region a
            //a) What is a Shallow Copy ?
            //Creating a new object and copying value-type,
            //while reference-type fields only have their references copied.
            #endregion

            #region b
            //b) What is a Deep Copy ?
            //Creating a new object and duplicating all value types.
            #endregion

            #region c
            //c) What happens to reference-type members when a Shallow Copy is created?
            //Both the original and copied objects share the same reference-type members.
            #endregion

            #region d
            //d) What happens to reference-type members when a Deep Copy is created?
            //New independent object are created for reference-type membersm.
            #endregion

            #region e
            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            //When a class contains a reference object like DeliveryAddress
            //and you want to update the new shipment's address without modifying the original shipment's address.
            #endregion

            #endregion

            #region Static Members

            #region a
            //a) What is a static field, and how is it different from an instance field ?
            //A static field belongs to the static class and is shared all instances,
            //instance field belongs to a specific object.
            #endregion

            #region b
            //b) What is a static method? Can a static method directly access instance members ?
            //static method that belongs to the class and is called using the class name.
            //It cannot directly access instance members without an object instance.
            #endregion

            #region c
            //c) What is a static constructor, and when is it executed ?
            //A constructor used to initialize static fields.
            //It is executed automatically only once before the first instance is created or any static member is accessed.
            #endregion

            #region d
            //d) What is a static class? Can you create an object from a static class?
            //A class that contains only static members.
            //No.
            #endregion

            #endregion

            #region Extension Methods

            #region a
            //a) What is an Extension Method ?
            //A method that allows you to add new functions to an existing type without modifying its original code.
            #endregion

            #region b
            //b) What keyword must be used in the first parameter of an extension method ?
            //this
            #endregion

            #region c
            //c) Where must an extension method be declared ?
            //Inside a static class
            #endregion

            #region d
            //d) Can an extension method access private members of the class it extends?
            //No, it can only access public members of the extended class.
            #endregion

            #endregion

            #region Partial Classes and Partial Methods

            #region a
            //a) What is a Partial Class ?
            //A class can be split across multiple physical files,
            //which are combined into a single class at compile time.
            #endregion

            #region b
            //b) Why would a developer split one class into multiple files?
            //To organize large code,
            //allow multiple developers to work on the same class simultaneously.
            #endregion

            #region c
            //c) What is a Partial Method ?
            //A method declared in one part of a partial class, implemented in another part of the same class.
            #endregion

            #endregion
        }
    }
}
