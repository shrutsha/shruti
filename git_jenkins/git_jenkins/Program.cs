using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace git_jenkins
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.Write(createMessage());
        }
        public static String createMessage()
        {
            return "Welcome to Jenkins";
        }
    }
}
