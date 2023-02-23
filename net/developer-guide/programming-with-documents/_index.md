---
title: API to manipulate Publisher files in C# 
linktitle: Programming with Documents
type: docs
url: /net/programming-with-documents/
description: Programing PUB files with Aspose.PUB for .NET starts with editing the file Metadata that describes its properties like author, tile, company, language, etc.
weight: 20
---

Aspose.PUB for .NET lets you work with PUB files in your .NET applications. It supports manipulating .pub files with a simple and well-defined structure. 

## **Edit MetaData of PUB Files**

MetaData of a document describes a file in terms of its properties such as author, title, last author, company, language, and other similar information. This is useful information that is stored along with the document. Aspose.PUB for .NET lets you edit metadata of a PUB file using the [DocSummaryInfo](https://reference.aspose.com/pub/net/aspose.pub/docsummaryinfo/) and [SummaryInfo](https://reference.aspose.com/pub/net/aspose.pub/summaryinfo/) classes as shown in the following code sample.



{{< highlight csharp>}}
    string dataDir = RunExamples.GetDataDir_Data();

    string pubFile = dataDir + "document.pub";

    IPubParser parser = PubFactory.CreateParser(pubFile);
    Document document = parser.Parse();

    document.DocumentSummaryInfo.SetCategory("category");
    document.DocumentSummaryInfo.SetCompany("company");
    document.DocumentSummaryInfo.SetLanguage("language");

    document.SummaryInfo.SetComments("comments");
    document.SummaryInfo.SetKeywords("keywords");
    document.SummaryInfo.SetLastAuthor("last author");
    document.SummaryInfo.SetTitle("title");
    document.SummaryInfo.SetSubject("subject");
{{< /highlight >}}


{{% alert color="primary" %}} 

To learn all the .NET code examples and data files, please go to [Aspose.PUB-Documentation for C# Github project](https://github.com/aspose-pub/Aspose.PUB-for-.NET)

{{% /alert %}} 




