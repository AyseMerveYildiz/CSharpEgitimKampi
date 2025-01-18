using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foreach(1,2,3,4)
            //1-Değişken türü
            //2-değişken adı
            //3-In
            //4-Liste,Koleksiyon,Dizi adı

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };
            //foreach (string c in cities)
            //{
            //    Console.WriteLine(c);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Öğrenci sınav sistemi uygulaması(Foreach)
            
            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var?");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");


            //Öğrenci isimlerini ve not ortalamalarını saklayan diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları toplama
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }
            //Sınav Ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("---------------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                //Öğrencilerin ortalaması ve geçme/ kalma durumu
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("---------------------------------------");
            }
            #endregion


            Console.Read(); 
        }
    }
}

