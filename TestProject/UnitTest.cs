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

        [Theory]
        [InlineData("1", "2", "3")]
        [InlineData("1", "151", "152")]
        [InlineData("5", "151", "4")]
        [InlineData("-5", "-152", "-157")]
        [InlineData("1000", "151", "999")]
        [InlineData("5", "9", "14")]
        [InlineData("14", "130", "144")]
        [InlineData("144", "20", "12")]
        [InlineData("12", "1500", "1360")]
        [InlineData("1360", "1", "1209")]
        public void DoJob(string read, string input, string expected)
        {
            // Arrange ...
            // arrange read text
            File.WriteAllText(_fileName, read);

            // Mock Console read
            var consoleRead = new StringReader(input);
            Console.SetIn(consoleRead);

            // Act ...
            IJob job = new Job(_fileName);
            job.DoJob();

            // Assert ...
            string textRead = File.ReadAllText(_fileName);
            textRead.Should().Be(expected);
        }
    }
}
