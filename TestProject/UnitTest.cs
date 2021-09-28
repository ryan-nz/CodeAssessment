using CodeAssessment;
using FluentAssertions;
using System;
using System.IO;
using Xunit;

namespace TestProject
{
    public class UnitTest
    {
        private readonly string _fileName = @"c:\temp\test-unit-test.txt";

        [Fact]
        public void DoJob_NoReadFile()
        {
            // Arrange ...
            // make sure the file not exists
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }

            string textExpected = "123";
            // Mock Console read
            var input = new StringReader(textExpected);
            Console.SetIn(input);

            // Act ...
            IJob job = new Job(_fileName);
            job.DoJob();

            // Assert ...
            string textRead = File.ReadAllText(_fileName);
            textRead.Should().Be(textExpected);
        }
    }
}
