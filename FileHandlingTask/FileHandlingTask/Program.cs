using Newtonsoft.Json;
using System;
using System.IO;

namespace FileHandlingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Directory.CreateDirectory(@"C:\Users\HP\Desktop\newFolder");
            //File.Create(@"C:\Users\HP\Desktop\newFolder\myTxtFile.txt");

            //StreamWriter newStreamWriter = new StreamWriter(@"C:\Users\HP\Desktop\newFolder\myTxtFile.txt");
            //newStreamWriter.WriteLine("bu bir metndir");
            //newStreamWriter.Close();
            #endregion

            #region Task 2
            Product product1 = new Product(1, "Samsung", 700);

            //Serialize
            var JSONproduct1 = JsonConvert.SerializeObject(product1);
            Console.WriteLine(JSONproduct1);

            //Deserialize
            var deserializedProduct = JsonConvert.DeserializeObject(JSONproduct1);
            Console.WriteLine(deserializedProduct);
            #endregion
        }
    }
}
