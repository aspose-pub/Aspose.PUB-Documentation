using System;
using Aspose.PUB.Examples.Licensing;
using Aspose.PUB.Examples.src;

namespace Aspose.PUB.Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aspose.PUB Examples --- START");
            Console.WriteLine("========================================");
            Console.WriteLine("");

            IExamples[] examples = new IExamples[]
            {
                 new VersionInfo(),
                 //new SetLicenseFromFile(),
                 //new SetLicenseFromStream(),
                 new ConvertToPdf("halloween-flyer"),
                 new ViewMetadata("halloween-flyer"),
                 new ReadPubDocument("halloween-flyer")
            };

            foreach (IExamples example in examples)
                example.Run();

            Console.WriteLine("");
            Console.WriteLine("========================================");
            Console.WriteLine("Aspose.PUB Examples --- END");
        }
    }    
}
