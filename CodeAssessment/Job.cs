using System;
using System.IO;

namespace CodeAssessment
{
    public class Job : IJob
    {
        private readonly string _fileName;

        private int _valueRead;
        private int _valueFromConsole;
        private int _valueToWrite;

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
            _valueRead = 0;

            if (File.Exists(_fileName))
            {
                string text = File.ReadAllText(_fileName);
                Console.WriteLine(text);
                bool res = int.TryParse(text, out int number);
                if (res)
                {
                    _valueRead = number;
                }
            }
        }

        private void ReadFromConsole()
        {
            _valueFromConsole = 0;

            string value = Console.ReadLine();
            bool res = int.TryParse(value, out int number);
            if (res)
            {
                _valueFromConsole = number;
            }
        }

        /// <summary>
        /// This method can be overrided.
        /// This is to do addition
        /// </summary>
        protected virtual void Calculate()
        {
            int total = _valueRead + _valueFromConsole;
            if (total > 152)
            {
                total -= 152;
            }

            _valueToWrite = total;
        }

        private void WriteFile()
        {
            File.WriteAllText(_fileName, _valueToWrite.ToString());
        }
    }
}
