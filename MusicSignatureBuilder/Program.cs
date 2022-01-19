//using System.Diagnostics;
//using MusicSignatureBuilder.Enums;

//namespace MusicSignatureBuilder;

//public class Program
//{
//    private static void Main(string[] args)
//    {
//        var basePath = @"C:\Users\serus\source\repos\ManualTests\songs\rozrywkowa";

//        var files = Directory.GetFiles(basePath);

//        Console.WriteLine(files.Length);

//        var sw = Stopwatch.StartNew();
//        //Parallel.ForEach(files, new ParallelOptions { MaxDegreeOfParallelism = -1 }, (file) =>
//        //{
//        //    try
//        //    {
//        //        var trajectory = new Trajectory(file, Resolutions.Quarter, Modes.Count);

//        //        Console.WriteLine(trajectory.ToString());
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        Console.WriteLine("Filename: " + file);
//        //        Console.WriteLine(ex.Message + "\n");
//        //    }
//        //});
//        foreach(var file in files)
//        {
//            if (!file.Contains("Clocks.mid")) continue;
//            try
//            {
//                var trajectory = new Trajectory(file, Resolutions.Quarter, Modes.Length);
//                Console.WriteLine("Filename: " + file);
//                Console.WriteLine(trajectory.ToString());
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Filename: " + file);
//                Console.WriteLine(ex.Message + "\n");
//            }
//        }

//        Console.WriteLine(sw.Elapsed);
//    }
//}
