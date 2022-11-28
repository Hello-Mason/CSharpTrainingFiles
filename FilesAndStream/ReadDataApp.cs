//using System;
//using System.IO;

//namespace FilesAndStreamDemo
//{
//    internal class ReadDataApp
//    {
//        static void Main()
//        {
//            string data;
//            FileStream fsSource = new FileStream("E:\\06Repos\\TrainingFiles\\CSharpTrainingFiles\\FilesAndStream\\bin\\Debug\\csharpfile.txt", FileMode.Open, FileAccess.Read);
//            using (StreamReader sr = new StreamReader(fsSource))
//            {
//                data = sr.ReadToEnd();
//            }
//            Console.WriteLine(data);
//            Console.ReadLine();
//        }
//    }
//}
