---
title: Licensing
linktitle: Licensing | Java
type: docs
url: /java/licensing/
description: To get the license of theAspose.PUB API solution for Java you can either apply it using File or Stream Object or by loading a License from File.
weight: 70
description: Evaluate Java Publisher PUB Conversion and Manipulation API and set license to avoid evaluation limitations.
---

## **Evaluation Version Limitations**
We want our customers to test our components thoroughly before buying so the evaluation version allows you to use it as you would normally. The API pastes an evaluation watermark during conversion of .pub files to PDF file format.


## **Apply License using File or Stream Object**
The license can be loaded from a file or stream object. The easiest way to set a license is to put the license file in the same folder as the aspose-pub-xx.x.jar file and specify the filename, without a path, as shown in the example below.

{{% alert color="primary" %}}

If you use are using any other Aspose for Java component along with Aspose.PUB for Java, please specify complete namespace for License like com.aspose.pub.License.

{{% /alert %}}
### **Loading a License from File**
The easiest way to apply a license is to put the license file in the same folder as the Aspose.PUB.jar file and specify just the filename without a path.

When you call the setLicense method, the license name that you pass should be that of your license file. For example, if you change the license file name to "Aspose.pub.lic.xml" pass that filename to the com.aspose.pub.License.setLicense(…) method. The license file can be specific for Aspose.PUB for Java or you can use Aspose.Total for Java license file.

{{< gist "aspose-com-gists" "0db82d4e131be0821f3fdb1b21f86e47" "Examples-src-java-setlicensefromfile.java">}}

### **Loading a License from a Stream Object**
The following example shows how to load a license from a stream.

{{< gist "aspose-com-gists" "0db82d4e131be0821f3fdb1b21f86e47" "Examples-src-java-setlicensefromstream.java">}}
