---
title: "PUB to PDF"
type: docs
url: /java/pub-to-pdf/
keywords: "Java API, PUB to PDF using Java, Open .pub file, read .pub file, convert .pub file"
description: "This article explains how to convert PUB files to PDF using Java"
weight: 10
---

Aspose.PUB for Java can read and convert publication files (.pub) to [PDF](https://wiki.fileformat.com/view/pdf/). The [PubFactory](https://apireference.aspose.com/pub/java/com.aspose.pub/PubFactory) class creates content from a .pub file for further processing by the Document class of the API.

{{% alert color="primary" %}}

At present, the API doesn't support the conversion of images in a PUB file to output PDF.

{{% /alert %}}
# **PUB to PDF Conversion using Java**
Portable Document Format (PDF) was introduced by Adobe to represent documents that can be read on digital devices. PUB files require Microsoft Publisher to be installed on the computer in order to open these files. Aspose.PUB for Java lets you convert PUB files to PDF that can be opened on almost all computers without the need for Microsoft Publisher being installed. The following steps and code snippet show how to convert PUB to PDF in your Java applications.

{{% alert color="primary" %}}

Aspose.PUB for Java supports converting multi-page PUB documents to PDF using the same lines of code given in this article.

{{% /alert %}}



1. Create a Java console or WinForms project
1. Load the .pub file using [PubFactory](https://apireference.aspose.com/pub/java/com.aspose.pub/PubFactory) class
1. Convert .pub to .pdf using the [ConvertToPdf](https://apireference.aspose.com/pub/java/com.aspose.pub/IPdfConverter#convertToPdf-com.aspose.pub.Document-java.io.OutputStream-) method of [ipdfConverter](https://apireference.aspose.com/pub/java/com.aspose.pub/IPdfConverter) interface

{{< gist "aspose-com-gists" "0db82d4e131be0821f3fdb1b21f86e47" "Examples-src-java-convertPUBtoPDF.java" >}}
