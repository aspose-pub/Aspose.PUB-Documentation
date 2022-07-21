using System;
using System.IO;
using Aspose.Pub;

namespace Aspose.PUB.Examples
{
    class ConvertToPdf : PubDocumentBaseExample
    {
        #region Constructor
        public ConvertToPdf(string pubName): base(pubName)
        {
        }
        #endregion

        public override void Run()
        {
            PrintAlignedTitle("Convert MS publisher file to PDF format example", true);

            Console.Write($"Converting publisher document '{this._pubName}' to PDF format...");
            PubFactory.CreatePdfConverter().ConvertToPdf(LoadDocument(), Path.Combine(OutputDir, this._pubName + ".pdf"));
            Console.WriteLine("OK");
        }
    }
}
