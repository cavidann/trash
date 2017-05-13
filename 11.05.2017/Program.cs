using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileManagment_ns;


namespace _11._05._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManagment fm = new FileManagment("C:/Users/Cavidan/Desktop/sill");

            fm.getAllFiles();

            Console.WriteLine("Delete Files?");
            Console.WriteLine("1. Yes delete its");
            Console.WriteLine("2. No close app");

            int response = int.Parse(Console.ReadLine());
            if (response==1)
            {
                
                fm.deleteAllFiles();
                Console.WriteLine("deleted");
                

            }
            else{
                System.Environment.Exit(-1);
           
            }


            /*Files file = new Files();
            Files file2 = new Files();

            file.sayArtir();
            file.sayArtir();
            file.sayArtir();
            

            file2.sayArtir();
            file2.sayArtir();
            file2.sayArtir();

            Console.WriteLine(Files.getSay());

            //Console.WriteLine(file.getSay());
            //Console.WriteLine(file2.getSay());

            //file.LastAccessDate = "18";//Set
            // file.LastAccessDate = "17";
            //Console.WriteLine(file.lastChangeDate); //get



            //file.setLastAccessDate("15");
            //Console.WriteLine(file.getLastAccessDate());*/
        }
    }

    internal class FiloInfo
    {
    }
}
