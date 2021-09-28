using System;

namespace CodeAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            string readFilePath = @"c:\temp\alstef-assessment.txt";

            IJob job = new Job(readFilePath);
            job.DoJob();

            Console.WriteLine("Job Finished.");
            Console.ReadLine();
        }
    }
}
