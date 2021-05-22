using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kata_Anagram
{
    public class FileManager
    {
        private string[] privatearray = null;

        public FileManager() 
        {
            this.privatearray = new string[] { };
         }


        public FileManager(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Dirección erronea");
            }

            StreamReader sr = new StreamReader(path);
            string line = null;

            List<string> list = new List<string>();

            while((line = sr.ReadLine()) != null)
            {
                list.Add(line);
            }

            this.privatearray = list.ToArray();
        }



       public string [] getArray()
        {
            return this.privatearray;

        }
    }
}

