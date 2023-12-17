# MimeTypes

[![.NET CI/CD Workflow](https://github.com/frankhaugen/Frank.MimeTypes/actions/workflows/main.yml/badge.svg?branch=main)](https://github.com/frankhaugen/Frank.MimeTypes/actions/workflows/main.yml)

This library provides a simple way to get the mime type of a file extension or the file extension of a mime type.

## Installation

### .NET CLI

```bash
dotnet add package Frank.MimeTypes
```

### Package Manager

```bash
Install-Package Frank.MimeTypes
```

### Package Reference

```xml
<PackageReference Include="Frank.MimeTypes" Version="*" />
```

## Usage

### Namespace

```csharp
using Frank.MimeTypes;
```

### Get mime type from file extension

```csharp
var mimeType = MimeTypes.GetMimeType("txt");
```

### Get file extension from mime type

```csharp
var fileExtension = MimeTypes.GetFileExtension("text/plain");
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details