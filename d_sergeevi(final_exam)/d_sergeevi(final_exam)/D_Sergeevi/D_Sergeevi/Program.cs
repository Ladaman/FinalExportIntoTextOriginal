using D_Sergeevi.Context;
using D_Sergeevi.Modals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Sergeevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your data is ready , please enter the path of file to export information.");
            // string path = @"C:\Users\David\Desktop\HobbyStudio\D_Sergeevi\a";
            string path = Console.ReadLine();
            path = @path;
            Console.WriteLine(path);

            using (var context = new MyDbContext())
            {
                var query = from st in context.GradesSet
                            select st;

                var grades = query.FirstOrDefault<Grades>();

                if (!File.Exists(path))
                {
                    try
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine("StudentID,SubjectID,Grade");

                            foreach (var x in query)
                            {
                                sw.WriteLine(x.StudentId + "," + x.SubjectId + "," + x.Grade);
                            }
                            Console.WriteLine(query.Count() + "record(s) exported");
                        }
                    } catch(Exception e)
                    {
                        Console.WriteLine("Something went wrong , try again later \n error: " + e);
                    }
                } else
                {
                    try
                    {
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            foreach (var x in query)
                            {
                                sw.WriteLine(x.StudentId + "," + x.SubjectId + "," + x.Grade);
                            }
                            Console.WriteLine(query.Count() + "record(s) exported");
                        }
                    } catch (Exception e)
                    {
                        Console.WriteLine("Something went wrong , try again later \n error: " + e);
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
