using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Author: Jonathan Hao
 * Date Created: May 13, 2016
 * Date Modified: May 13, 2016
 * Student ID: 300869273
 * 
 * Description: This program demonstrates GitHub and version control
 * best practices.  We also expore Unit Testing.
 * 
 * Version: 0.2 - Added GetUserName method
 */


namespace COMP123_S2016_Lesson1B
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserName();
        }

 /**
 * This method reads the UserName from the Console
 *
 * @method GetUserName
 * @return {string} UserName
 */
        public static string GetUserName()
        {
            // Initialize Variables
            string UserName = "";

            Console.Write("Enter UserName: ");
            UserName = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("/n==========================");
            Console.WriteLine("You Entered: " + UserName);

            return UserName;
        }
    }
}
