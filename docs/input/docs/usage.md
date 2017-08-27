Description: Library usage instructions.
---
To use Cake.Markdown-Pdf add the following line to the top of your cake script

```c#
#addin "Cake.Markdown-Pdf"
```

After this you can use the Markdown-Pdf method alias to run markdown-pdf. See [About Cake.Markdown-Pdf](../about.html) for details.

```csharp
#reference "./bin/Cake.Markdown-Pdf.dll" // Use the relative path to your Cake.Markdown-Pdf.dll file built by Visual Studio.

var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
    MarkdownPdf(s => s.WithFilePath("README.md"));
});

RunTarget(target);
```