  <img width="256" height="256" src="https://github.com/Timmoth/Aptacode.MimeTypes/blob/master/Resources/banner.jpg">
A lightweight C# .net standard library containing a growing list of over 900 mimetypes and 1600 compatible extensions.

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/b4609c326d674acd98de15432bc5f69a)](https://www.codacy.com/manual/Timmoth/Aptacode.MimeTypes?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=Timmoth/Aptacode.MimeTypes&amp;utm_campaign=Badge_Grade)
[![NuGet](https://img.shields.io/nuget/v/Aptacode.MimeTypes.svg?style=flat)](https://www.nuget.org/packages/Aptacode.MimeTypes/)
![last commit](https://img.shields.io/github/last-commit/Timmoth/Aptacode.MimeTypes?style=flat-square&cacheSeconds=86000)

### Usage

```csharp

#using Aptacode.MimeTypes;

public void Demo(){
  var mimeType              = MimeTypes.Application.Json;//Get a MimeType

  var typeName              = mimeType.Type;            //"application"
  var subTypeName           = mimeType.Subtype;         //"json"
  var toString              = mimeType.ToString;        //"application/json"

  var allMimeTypes          = MimeTypes.All();          //Returns all available MimeTypes
  var filteredMimeTypes     = MimeTypes.All(".jpg");    //Returns all MimeTypes with the given extension

  var allExtensions         = MimeTypes.Extensions.All(); //Returns all available Extensions
  var filteredExtensions    = MimeTypes.Extensions.All(MimeTypes.Application.Json); //Returns all available Extensions for the given MimeType
}

```

### Adding MimeTypes
The main library's sourcecode is generated from a text file containing a list of MimeTypes, users can modify the list, build & run the SourceCodeGenerator project and then overwrite 'MimeTypeGroups.cs' and 'MimeTypeExtensions.cs' using the generated files to add statically typed MimeTypes to the library.
https://github.com/Timmoth/Aptacode.MimeTypes/blob/master/CodeGenerator/mimetypes.txt

Alternatively users can modify add new MimeTypes & modify existing ones at runtime using the static MimeTypes class.
