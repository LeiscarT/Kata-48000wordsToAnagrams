using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Anagram
{
    public class FileManager
    {
        private string[] privatearray = null;




        public FileManager()
        {
            
        }

        public FileManager(string[] array) 
        {
            this.privatearray = array;
         }


       public string [] getArray()
        {
            return this.privatearray;

        }
    }
}

