using System;

namespace CodeAssessment
{
    public class Job : IJob
    {
        private readonly string _fileName;

        public Job(string readFilePath)
        {
            _fileName = readFilePath;
        }
        public void DoJob()
        {
            // Do task here...
        }
    }
}
