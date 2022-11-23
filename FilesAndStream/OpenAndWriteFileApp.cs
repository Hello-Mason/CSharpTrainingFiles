//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FilesAndStreamDemo
//{
//    internal class OpenAndWriteFileApp
//    {
//        static void Main(string[] args)
//        {
//            FileStream fs = new FileStream("E:\\06Repos\\TrainingFiles\\CSharpTrainingFiles\\FilesAndStream\\bin\\Debug\\csharpfile.txt", FileMode.Append);
//            byte[] bdata = Encoding.Default.GetBytes("Hello File Handling!");
//            fs.Write(bdata, 0, bdata.Length);
//            fs.Close();
//            Console.WriteLine("Successfully saved file with data : Hello File Handling!");
//            Console.ReadKey();
//        }
//    }
//}
