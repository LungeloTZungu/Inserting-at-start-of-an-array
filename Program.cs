using System;

namespace InsertIntoArrayatStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // inserting at start  of an array see code below


            int[] intArray = new int[6]; // inizailising the array
                                         // make a varaible to keep the length beacause .Length is based off capacity and does not track the actaul index
            int length = 0;
            // populating the array
            for (int i = 0; i < 6; i++)
            {
                intArray[length] = i;
                length++;
            }

            Console.WriteLine("Original Array:");
            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }

            //  seetting yhe fisrt index of the array to 20
            intArray[0] = 20;
            length++;
            Console.WriteLine("New Array:");
            foreach (var i in intArray)
            {
                Console.WriteLine(i);

            }
        }
    }
}
