using System;
using System.IO;
using Aspose.PUB.Examples;
using Aspose.Pub;

namespace Aspose.PUB.Examples.Licensing
{
    class SetLicenseFromStream : BaseExamples
    {
        public override void Run()
        {
            Console.WriteLine("Run Set License from Stream example");

            using (FileStream licenseStream = new FileStream(Path.Combine(LicenseDir, "Aspose.PUB.lic"), FileMode.Open))
            {
                License license = new License();
                license.SetLicense(licenseStream);
            }
            
        }
    }
}
