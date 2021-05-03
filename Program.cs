using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace assignment
{


    class Program
    {


        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("data.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                Console.WriteLine("----------Data From Json File --------------------");
                Console.WriteLine(array);

              Console.WriteLine("----------Data Modification in Json File --------------------");
              array["GlobalCompany"]["USA"]["University"] = "new Univeristy";
              string output = Newtonsoft.Json.JsonConvert.SerializeObject(array, Newtonsoft.Json.Formatting.Indented);
            //   File.WriteAllText("data.json", output);
              Console.WriteLine(array);
            }

            
        }
    }
}
