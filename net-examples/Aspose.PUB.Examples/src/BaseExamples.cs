using System;
using System.IO;

namespace Aspose.PUB.Examples
{
    abstract class BaseExamples : IExamples
    {
        protected string dataDir;
        protected string outputDir;
        protected string licenseDir;
        protected const int AlignedTitleLength = 100;

        public BaseExamples(string folderName)
        {
            dataDir = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "Data");
            outputDir = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "Out", folderName);
            licenseDir = Path.Combine(dataDir, "License");

            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }
        }

        public BaseExamples() : this(".") { }

        public string DataDir => dataDir;

        public string OutputDir => outputDir;

        public string LicenseDir => licenseDir;

        public string DataPath(string fileName)
        {
            return Path.Combine(DataDir, fileName);
        }

        public string DataPath(params string[] paths)
        {
            return Path.Combine(DataDir, Path.Combine(paths));
        }

        public string OutputPath(string fileName)
        {
            return Path.Combine(OutputDir, fileName);
        }

        public abstract void Run();

        protected void PrintExampleTitle(string title, int exNum)
        {
            Console.WriteLine(string.Format("\n{0}, ex: {1}", title, exNum));
        }

        protected void PrintAlignedTitle(string caption, bool startFromNewLine = false, char frameSymbol = '-')
        {
            if (startFromNewLine)
            {
                Console.WriteLine();
            }
            int frameLength = (AlignedTitleLength - caption.Length) / 2;
            string frame = new string(frameSymbol, frameLength);

            Console.WriteLine(frame + caption + frame);
        }

        protected void PrintAlignedTitle(string caption, int titleLength, bool startFromNewLine = false, char frameSymbol = '-')
        {
            if (startFromNewLine)
            {
                Console.WriteLine();
            }
            int frameLength = (titleLength - caption.Length) / 2;
            string frame = new string(frameSymbol, frameLength);

            Console.WriteLine(frame + caption + frame);
        }
    }
}
