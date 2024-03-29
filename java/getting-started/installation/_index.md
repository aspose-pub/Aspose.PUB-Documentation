---
title: Installation | Java
linktitle: Installation
type: docs
url: /java/installation/
definition: For installing Aspose.PUB API solution for Java from Aspose Repository you need to specify the repository configuration and define API dependency.
weight: 60
description: Install Java Publisher PUB Conversion and Manipulation API via Maven project and Maven repository.
---

## **Installing Aspose.PUB for Java from Aspose Repository**
Aspose hosts all Java APIs on [Aspose Repository](https://releases.aspose.com/java/repo/com/aspose/). You can easily use Aspose.PUB for Java API directly in your Maven Projects with simple configurations.
### **Specify Aspose Repository Configuration**
First you need to specify Aspose Repository configuration / location in your Maven pom.xml as follows:

{{< highlight java >}}

 <repositories>

     <repository>

         <id>snapshots</id>

         <name>repo</name>

         <url>https://releases.aspose.com/java/repo/</url>

     </repository>

</repositories>

{{< /highlight >}}
### **Define Aspose.PUB for Java API Dependency**
Then define Aspose.PUB for Java API dependency in your pom.xml as follows:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-pub</artifactId>

        <version>20.8</version>

    </dependency>

</dependencies>

{{< /highlight >}}

After performing above steps, Aspose.PUB for Java dependency will finally be defined in your Maven Project.
