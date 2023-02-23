---
title: Programming with Documents | Java
linktitle: Programming with Documents
type: docs
url: /java/programming-with-documents/
description: To code PUB files with Aspose.PUB for Java start with editing the file Metadata that describes its properties like author, tile, company, language, etc.
weight: 20
---

Aspose.PUB for Java facilitates you to manipulate .pub files in your applications. Its well-defined structure lets you read PUB files and work with the file properties.

## **Edit MetaData of PUB Files**

MetaData of a document describes a file in terms of its properties such as author, title, last author, company, language, and other similar information. This is useful information that is stored along with the document. Aspose.PUB for Java lets you edit metadata of a PUB file using the [DocSummaryInfo](https://reference.aspose.com/pub/java/com.aspose.pub/DocSummaryInfo) and [SummaryInfo](https://reference.aspose.com/pub/java/com.aspose.pub/SummaryInfo) classes as shown in the following code sample. 



{{< highlight java>}}
    IPubParser parser = PubFactory.createParser(fileName);
    Document document = parser.parse();

    document.getDocumentSummaryInfo().setCategory("category");
    document.getDocumentSummaryInfo().setCompany("company");
    document.getDocumentSummaryInfo().setLanguage("language");

    document.getSummaryInfo().setComments("comments");
    document.getSummaryInfo().setKeywords("keywords");
    document.getSummaryInfo().setLastAuthor("last author");
    document.getSummaryInfo().setTitle("title");
    document.getSummaryInfo().setSubject("subject");
{{< /highlight >}}


{{% alert color="primary" %}} 

To learn the complete Java code examples and data files, please go to [Aspose.PUB-Documentation for Java Github project](https://github.com/aspose-pub/Aspose.Pub-for-Java)

{{% /alert %}} 