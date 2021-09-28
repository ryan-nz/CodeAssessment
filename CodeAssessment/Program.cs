using System;

namespace CodeAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            IJob job = new Job();
            job.DoJob();

            Console.WriteLine("Job Finished.");
            Console.ReadLine();
        }
    }
}
