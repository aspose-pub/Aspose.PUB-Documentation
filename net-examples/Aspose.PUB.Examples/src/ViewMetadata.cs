using System;
using System.Collections.Generic;
using Aspose.Pub;

namespace Aspose.PUB.Examples
{
    class ViewMetadata: PubDocumentBaseExample
    {
        #region Constructor
        public ViewMetadata(string pubName): base(pubName)
        { }
        #endregion

        public override void Run()
        {
            PrintAlignedTitle("View MS publisher file metadata example", true);
            PrintPubDocMetadata();
        }

        private void PrintPubDocMetadata()
        {            
            Document doc = LoadDocument();
            SummaryInfo info = doc.SummaryInfo;
            Dictionary<string, string> outInfo = new Dictionary<string, string>();
            AddInfoField("Title", info.Title, outInfo);
            AddInfoField("Subject", info.Subject, outInfo);
            AddInfoField("Author", info.Author, outInfo);
            AddInfoField("LastAuthor", info.LastAuthor, outInfo);
            AddInfoField("Keywords", info.Keywords, outInfo);
            AddInfoField("Comments", info.Comments, outInfo);            
            AddInfoField("Template", info.Template, outInfo);
            AddInfoField("RevNumber", info.RevNumber, outInfo);
            AddInfoField("AppName", info.AppName, outInfo);
            AddInfoField("PageCount", info.PageCount, outInfo);
            AddInfoField("WordCount", info.WordCount, outInfo);
            AddInfoField("CharCount", info.CharCount, outInfo);
            AddInfoField("DocSecurity", info.DocSecurity, outInfo);

            Console.WriteLine($"Metadata for document '{this._pubName}':");
            foreach (string fieldName in outInfo.Keys)
            {
                Console.WriteLine($"\"{fieldName}\": {outInfo[fieldName]}");
            }
        }

        private void AddInfoField(string fieldName, string value, Dictionary<string, string> outInfo)
        {
            if (!string.IsNullOrEmpty(value))
            {
                outInfo.Add(fieldName, value);
            }
        }

        private void AddInfoField(string fieldName, int value, Dictionary<string, string> outInfo)
        {
            if (value != 0)
            {
                outInfo.Add(fieldName, value.ToString());
            }
        }
    }
}
