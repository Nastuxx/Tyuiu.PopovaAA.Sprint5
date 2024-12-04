using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using Tyuiu.PopovaAA.Sprint5.Task6.V13.Lib;
namespace Tyuiu.PopovaAA.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    while ((index = line.IndexOf("сс", index)) != -1)
                    {
                        count++;
                        index += 2;
                    }
  
                }
            }
            return count;
                         
            
        }
        
    }
}
