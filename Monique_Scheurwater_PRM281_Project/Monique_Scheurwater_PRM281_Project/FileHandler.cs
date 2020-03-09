using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Monique_Scheurwater_PRM281_Project
{
    public class FileHandler
    {
        string fn = @"info.txt";
        public List<Changes> Read(List<Changes> c)
        {
            StreamReader reader = new StreamReader(fn);
            using (reader)
            {
                string line = reader.ReadLine();
                
                while (line != null)
                {
                    string[] value;
                    value = line.Split('#');
                    c.Add(new Changes(value[0], value[1]));
                    line = reader.ReadLine();
                }
            }
            return c;
        }
        public void WriterRename(Changes c)
        {
            StreamWriter writer = new StreamWriter(fn, true);
            using (writer)
            {
                writer.WriteLine(c.ToString());
            }
        }
        
    }
}
