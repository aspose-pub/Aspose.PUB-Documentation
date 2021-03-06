---
title: "Aspose.PUB for .NET 20.2 Release Notes"
type: docs
url: /net/aspose-pub-for-net-20-2-release-notes/
weight: 20
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PUB for .NET 20.2

{{% /alert %}} 
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PUBNET-115|Support [multi-page documents](/pub/net/pub-to-pdf/)|New Feature|
|PUBNET-145|Add [product version information](/pub/net/installation/#installation-getassemblybuildversioninformation): BuildVersionInfo class|New Feature|
|PUBNET-136|Refactor [Converter classes](/pub/net/pub-to-pdf/)|Enhancement|
|PUBNET-135|Refactor tests. Improve work with templates|Enhancement|
|PUBNET-52|Problem conversion multipage pub document to pdf|Bug|
## **Public API and Backward Incompatible Changes**
### **Added APIs**
- Class:Aspose.Pub.BuildVersionInfo
  - Constructor:Aspose.Pub.BuildVersionInfo
  - Property:Aspose.Pub.BuildVersionInfo.AssemblyVersion
  - Property:Aspose.Pub.BuildVersionInfo.Product
  - Property:Aspose.Pub.BuildVersionInfo.FileVersion
- Interface:Aspose.Pub.IPdfConverter
  - Method:Aspose.Pub.IPdfConverter.ConvertToPdf(Aspose.Pub.Document,System.String)
  - Method:Aspose.Pub.IPdfConverter.ConvertToPdf(Aspose.Pub.Document,System.IO.Stream)
  - Method:Aspose.Pub.PubFactory.CreatePdfConverter
### **Removed APIs**
- Interface:Aspose.Pub.IPdfConvertor
  - Method:Aspose.Pub.IPdfConvertor.ConvertToPdf(Aspose.Pub.Document,System.String)
  - Method:Aspose.Pub.IPdfConvertor.ConvertToPdf(Aspose.Pub.Document,System.IO.Stream)
  - Method:Aspose.Pub.PubFactory.CreatePdfConvertor
