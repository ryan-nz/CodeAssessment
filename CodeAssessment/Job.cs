using System;

namespace CodeAssessment
{
    public class Job : IJob
    {
        private readonly string _fileName;

        private int _valueRead { get; set; }
        private int _valueFromConsole { get; set; }
        private int _valueToWrite { get; set; }

        public Job(string readFilePath)
        {
            _fileName = readFilePath;
        }
        public void DoJob()
        {
            // 1. Read a number from file
            ReadFile();
            // 2. Read a number from console
            ReadFromConsole();
            // 3. Calculate addition
            Calculate();
            // 4. Write total into the file which is the reading file.
            WriteFile();
        }

        private void ReadFile()
        {

        }

        private void ReadFromConsole()
        {

        }

        /// <summary>
        /// This method can be overrided.
        /// This is to do addition
        /// </summary>
        protected virtual void Calculate()
        {

        }

        private void WriteFile()
        {

        }
    }
}
