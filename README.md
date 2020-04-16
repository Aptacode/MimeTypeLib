# MimeTypes
A lightweight C# .net standard library containing a huge list of MimeTypes and File Extension.


### Usage

```csharp

#using Aptacode.MimeTypes;

public void Demo(){
  var mimeType              = MimeTypes.Application.Json;            //Get an extension

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

