using System;
using System.Collections;
using System.Drawing;
using System.Text;
using Aspose.Pub;

namespace Aspose.PUB.Examples.src
{
    class ReadPubDocument: PubDocumentBaseExample
    {
        #region Fields
        const uint EMUsesInOneInch = 914400;
        #endregion
        #region Constructor
        public ReadPubDocument(string pubName): base(pubName)
        {

        }
        #endregion

        public override void Run()
        {
            PrintAlignedTitle("View MS publisher document properties example", true);
            PrintDocProperties(LoadDocument());
        }

        private void PrintDocProperties(Document doc)
        {
            PrintAlignedTitle($"Properties of publisher document {this._pubName}", 70, true);
            Console.WriteLine($"Page width: {GetInchesString(doc.Width)}");            
            Console.WriteLine($"Page height: {GetInchesString(doc.Height)}");
            Console.WriteLine($"Field count: {doc.FieldCount}");
            string fontNames = GetCollectionString(doc.FontNames);
            if (!string.IsNullOrEmpty(fontNames))
            {
                Console.WriteLine($"Fonts used in document: {fontNames}");
            }
            string colors = GetCollectionString(doc.Colors);
            if (!string.IsNullOrEmpty(colors))
            {
                Console.WriteLine($"Colors used in document: {colors}");
            }
        }

        private string GetInchesString(uint size)
        {
            double value = (double)size / EMUsesInOneInch;
            return Convert.ToString(value) + " inches";
        }

        private string GetCollectionString(ICollection array)
        {
            if (array.Count == 0)
            {
                return null;
            }

            StringBuilder sb = new StringBuilder();
            int num = -1;
            IEnumerator enumerator = array.GetEnumerator();

            while (enumerator.MoveNext())
            {
                num++;
                sb.Append(GetObjectStirng(enumerator.Current));
                if (num < (array.Count - 1))
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }

        private string GetObjectStirng(object value)
        {
            if (value is Color)
            {
                Color colorVal = (Color)value;
                return $"RGB({colorVal.R}, {colorVal.G}, {colorVal.B})"; 
            }

            return value.ToString();
        }


    }
}
