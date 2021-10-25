using System;

namespace Homework_2._7_Task_2
{
    class Program
    {
        static void Main()
        {
            //переменные
            string Name = "Сергей";
            string Surname = "Усков";
            string Secondname = "Евгеньевич";

            int ProgrammingGrade = 1;
            int MathsGrade = 2;
            int PhysicsGrade = 3;

            int SumGrade = ProgrammingGrade + MathsGrade + PhysicsGrade;    //сумма баллов (см коммент ниже)
            int[] array = {ProgrammingGrade, MathsGrade, PhysicsGrade};     //массив для среднего значения. изначально надо было сделать струкутуру массивом, но в задаче 1 не требовалось
            int AvgGrade = SumGrade / array.Length;                         //прошу прощения за кривоту

            Console.WriteLine(" Summing Grade: {0}\n Avg Grade: {1}\n", SumGrade, AvgGrade);

            Console.ReadKey();

        }
    }
}
