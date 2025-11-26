using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    /// <summary>
    /// String Stack
    /// </summary>
    public class StringStack
    {
        /// <summary>
        /// int-variable, contains current index
        /// </summary>
        private static int index = 0;

        /// <summary>
        /// string[]-variable, contains data
        /// </summary>
        private static string[] stack;

        /// <summary>
        /// creates stack (string[])
        /// </summary>
        /// <param name="size">size of stack to be created</param>
        public static void MyStack(int size)
        {
            stack = new string[size];
        }

        /// <summary>
        /// adds an element to the stack
        /// </summary>
        /// <param name="val">element to be added</param>
        public static void Push(string val)
        {
            index++;
            stack[index] = val;

        }

        /// <summary>
        /// gets an element from the stack and delete it
        /// </summary>
        /// <returns>the element from the stack</returns>
        public static string Pop()
        {
            return stack[index];
            index--;
        }

        /// <summary>
        /// gets an element from the stack without deleting it 
        /// </summary>
        /// <returns>the element from the stack</returns>
        public static string Peak()
        { 
            return stack[index];
        }

    }
}
