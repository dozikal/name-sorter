using System;
using System.IO;
using System.Collections.Generic;

namespace NameSorter{

    public class FileHandler{

        //Read a file from the specified directory and return its content.
        public IEnumerable<string> ReadFile(string file){

            string line;

            using(var reader = File.OpenText(file)){

                while((line = reader.ReadLine()) != null){
                    yield return line;
                }
            }
        }

        //Create or overwrite a file to the same directory given the file name and content.
        public void WriteFile(string fileName, List<string> content){
            using(StreamWriter sw = File.CreateText("./" + fileName)){
                
                foreach(var item in content){
                    sw.WriteLine(item);
                }
            }
        }

    }
}