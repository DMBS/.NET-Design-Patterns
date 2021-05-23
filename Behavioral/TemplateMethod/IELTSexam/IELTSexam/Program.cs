using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IELTSexam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start IELTS Exam !!!");

            var newAcademicExam = new Academic();
            newAcademicExam.StartTest();
            newAcademicExam.GetFinalOverallBand();
            Thread.Sleep(2000);
            var newGeneralExam = new General();
            newGeneralExam.StartTest();
            newGeneralExam.GetFinalOverallBand();

            Console.ReadLine();
        }
    }
}
