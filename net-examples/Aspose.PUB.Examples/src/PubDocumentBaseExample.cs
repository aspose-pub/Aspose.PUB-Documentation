using System;
using System.IO;
using Aspose.Pub;

namespace Aspose.PUB.Examples
{
    abstract class PubDocumentBaseExample: BaseExamples
    {
        #region Fields
        protected string _pubName;
        protected string _pubFileName;
        #endregion

        #region Constructor
        public PubDocumentBaseExample(string pubName)
        {
            this._pubName = pubName;
            this._pubFileName = Path.Combine(DataDir, pubName + ".pub");
            if (!File.Exists(this._pubFileName))
                throw new Exception($"Can't open publisher file \"{this._pubFileName}\" to process.");
        }
        #endregion

        protected Document LoadDocument()
        {
            IPubParser parser = PubFactory.CreateParser(this._pubFileName);
            return parser.Parse();
        }
    }
}
