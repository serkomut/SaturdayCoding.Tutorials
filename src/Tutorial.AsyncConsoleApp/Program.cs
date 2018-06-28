using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Tutorial.AsyncConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Booking_History_Delta_Field_Rooms();
            var stopwatch1 = Stopwatch.StartNew();
            var carTask = Task.Factory.StartNew<int>(BookCar);
            var planeTask = Task.Factory.StartNew<int>(BookPlane);
            var hotelTask = Task.Factory.StartNew<int>(BookHotel);

            var hotelFallowUpTask = hotelTask.ContinueWith(taskPrev => Console.WriteLine("Adding view note for booking {0}", taskPrev.Result));
            hotelFallowUpTask.Wait();


            Task.WaitAll(carTask, hotelTask, planeTask);
            Console.WriteLine("Finished booking: carId : {0}, hotelId : {1}, planeId : {2}", carTask.Result, planeTask.Result, hotelTask.Result);
            Console.WriteLine("Finished int {0} sec.", stopwatch1.ElapsedMilliseconds / 1000.0);
            Console.ReadLine();

            var stopwatch2 = new Stopwatch();
            var carId = BookCar();
            var hotelId = BookHotel();
            var planeId = BookPlane();
            Console.WriteLine("Finished int {0} sec.", stopwatch2.ElapsedMilliseconds / 1000);


            var approachList = new List<String[]>();

            for (int i = 0; i < Math.Pow(Counter, Counter); i++)
            {
                if (IsAllDifferentAndNotCross(MyArray))
                {
                    int k = 0;
                    String[] tempArray = new String[Counter];
                    foreach (int item in MyArray)
                    {
                        k++;
                        tempArray[k - 1] = (k) + Alphabe[item].ToString();
                        Console.Write(tempArray[k - 1] + "  ");

                    }

                    Console.WriteLine();

                    approachList.Add(tempArray.Clone() as String[]);

                }

                MyArray[Counter - 1]++;

                SetArray();
            }


            Console.WriteLine("There is " + approachList.Count() + " different combination");

            Console.ReadLine();


            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);

            if (isoStore.FileExists("TestStore.txt"))
            {
                Console.WriteLine("The file already exists!");
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("TestStore.txt", FileMode.Open, isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        Console.WriteLine("Reading contents:");
                        Console.WriteLine(reader.ReadToEnd());
                    }
                }
            }
            else
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("TestStore.txt", FileMode.CreateNew, isoStore))
                {
                    using (StreamWriter writer = new StreamWriter(isoStream))
                    {
                        writer.WriteLine("Hello Isolated Storage");
                        Console.WriteLine("You have written to the file.");
                    }
                }
            }




        }

        static readonly int[] MyArray = new int[GetNumber()];

        static readonly char[] Alphabe = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        static readonly int Counter = MyArray.Count();

        static Boolean IsAllDifferentAndNotCross(int[] myArray)
        {
            for (var i = 0; i < Counter; i++)
            {
                for (var j = i + 1; j < Counter; j++)
                {
                    if (myArray[i] == myArray[j] || (myArray[i] - i) == (myArray[j] - j) || (myArray[i] + i) == (myArray[j] + j))
                        return false;
                }

            }

            return true;
        }

        static void SetArray()
        {
            for (int j = 0; j < Counter; j++)
            {
                if (MyArray[j] == Counter)
                {
                    if (j == 0)
                        break;
                    MyArray[j] = 0;
                    MyArray[j - 1]++;
                    break;
                }
            }

            foreach (int item in MyArray)
                if (item == Counter)
                    if (MyArray[0] != Counter)
                        SetArray();
        }

        static int GetNumber()
        {
            System.Console.WriteLine("Please insert number: ");
            return int.Parse(Console.ReadLine());
        }
        static void Booking_History_Delta_Field_Rooms()
        {
            string[] sentences =
            {
                "C# code",
                "Chapter 2: Writing Code",
                "Unicode",
                "no match here"
            };

            const string sPattern = "code";

            foreach (var s in sentences)
            {
                Console.Write("{0,24}", s);

                if (Regex.IsMatch(s, sPattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("  (match for '{0}' found)", sPattern);
                }
                else
                {
                    Console.WriteLine();
                }
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        private static int BookPlane()
        {
            Console.WriteLine("Booking car...");
            Thread.Sleep(5000);
            Console.WriteLine("Done with car.");
            return random.Next(100);
        }

        private static int BookHotel()
        {
            Console.WriteLine("Booking hotel...");
            Thread.Sleep(8000);
            Console.WriteLine("Done with hotel.");
            return random.Next(100);
        }

        private static readonly Random random = new Random();
        private static int BookCar()
        {
            Console.WriteLine("Booking plane...");
            Thread.Sleep(3000);
            Console.WriteLine("Done with plane.");
            return random.Next(100);
        }
    }

    
}
