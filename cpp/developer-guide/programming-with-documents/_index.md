---
title: Programming with Documents | C++
linktitle: Programming with Documents
type: docs
url: /cpp/programming-with-documents/
description: To code PUB files with Aspose.PUB for C++ start with editing the file Metadata that describes its properties like author, tile, company, language, etc.
weight: 20
---

Aspose.PUB for C++ allows to work with .pub files programatically in your C++ applications. The API can manipulate .pub files without the need to undergo the underlying file format of .pub files.

## Edit MetaData of PUB Files in C++

A document's metadata describes its properties such as author, tile, company, language, and other similar information. Aspose.PUB for C++ can read the metadata information as well as update it during PUB to PDF conversion. The following sample code shows how to read a .pub file, edit its metadata and convert to PDF. But first, a license object is initialized and set with a license file located in a specific directory. 


{{< highlight cpp>}}
    // Initialize the license object
    auto license = System::MakeObject<Aspose::Pub::License>();
    // Set the license
    license->SetLicense(dataDir() + u"License\\Aspose.PUB.C++.lic");

    System::String filePub = dataDir() + u"1.pub";
    System::String filePdf = dataDir() + u"1.pdf";

    System::Console::WriteLine(u"Convert starting...");

    System::SharedPtr<IPubParser> parser = PubFactory::CreateParser(filePub);
    System::SharedPtr<Document> document = parser->Parse();

    document->get_DocumentSummaryInfo()->SetCompany(u"company");
    document->get_DocumentSummaryInfo()->SetCategory(u"category");
    document->get_DocumentSummaryInfo()->SetLanguage(u"language");

    document->get_SummaryInfo()->SetAuthor(u"author");
    document->get_SummaryInfo()->SetComments(u"comments");
    document->get_SummaryInfo()->SetTitle(u"title");
    document->get_SummaryInfo()->SetSubject(u"subject");
    document->get_SummaryInfo()->SetKeywords(u"keywords");
	
    // Convert PUB to PDF
    PubFactory::CreatePdfConverter()->ConvertToPdf(document, filePdf);

    System::Console::WriteLine(u"Convert done."); 
{{< /highlight >}}


{{% alert color="primary" %}} 

To learn the complete C++ code examples and data files, please go to [Aspose.PUB-Documentation for C++ Github project](https://github.com/aspose-pub/Aspose.Pub-for-C)

{{% /alert %}} 
