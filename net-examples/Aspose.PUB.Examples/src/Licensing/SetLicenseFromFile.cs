using System;
using System.IO;
using Aspose.Pub;

namespace Aspose.PUB.Examples.Licensing
{
    class SetLicenseFromFile : BaseExamples
    {
        public override void Run()
        {
            Console.WriteLine("Run Set License from File example");
            
            string licensePath = Path.Combine(LicenseDir, "Aspose.PUB.lic");

            License license = new License();
            license.SetLicense(licensePath);            
        }
    }
}
