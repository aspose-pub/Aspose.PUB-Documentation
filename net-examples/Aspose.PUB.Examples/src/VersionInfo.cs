using System;

namespace Aspose.PUB.Examples
{
    class VersionInfo: BaseExamples
    {
        public override void Run()
        {
            PrintAlignedTitle("Version information", true);
            Console.WriteLine("Assembly Version: {0}", Aspose.Pub.BuildVersionInfo.AssemblyVersion);
            Console.WriteLine("File Version: {0}", Aspose.Pub.BuildVersionInfo.FileVersion);
            Console.WriteLine("Product: {0}", Aspose.Pub.BuildVersionInfo.Product);
        }
    }
}
