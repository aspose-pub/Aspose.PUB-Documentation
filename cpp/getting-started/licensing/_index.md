---
title: Licensing | C++
linktitle: Licensing
type: docs
url: /cpp/licensing/
definition: Native C++ APIs to manipulate Publisher files.  Learn the how to get a license installed to start working with Aspose.PUB for C++.
weight: 60
---

## **Evaluation Version Limitations**


The evaluation version of Aspose.PUB (without a license specified) provides full product functionality except that an evaluation version warning is displayed at the top of the converted document.
## **Apply License using File or Stream Object**
The license can be loaded from a file or stream object. Aspose.PUB for C++ will try to find the license in the following locations:

1. Explicit path.
1. The folder that contains Aspose.PUB.dll.
1. The folder that contains the assembly that called Aspose.PUB.dll.
1. The folder that contains the entry assembly (your .exe).
1. An embedded resource in the assembly that called Aspose.PUB.dll.

The easiest way to set a license is to put the license file in the same folder as the Aspose.PDF.dll file and specify the file name, without a path, as shown in the example below.
### **Loading a License from File**
The easiest way to apply a license is to put the license file in the same folder as the Aspose.PUB.dll file and specify just the file name without a path.

{{% alert color="primary" %}} 

When you call the SetLicense method, the license name that you pass should be that of the license file. For example, if you change the license file name to "Aspose.PUB.lic.xml" pass that file name to the Pdf->SetLicense(…) method.

{{% /alert %}} 

**C++**

{{< highlight csharp >}}

 auto lic = MakeObject<Aspose::Pdf::License>();

lic->SetLicense(L"Aspose.PUB.Cpp.lic");

{{< /highlight >}}
### **Loading a License from a Stream Object**
The following example shows how to load a license from a stream.

**C++**

{{< highlight csharp >}}

 intrusive_ptr<License>license = new License();

intrusive_ptr<FileStream> myStream = new FileStream(new String("Aspose.PUB.Cpp.lic"), FileMode_Open);

license->SetLicense(myStream);

{{< /highlight >}}
