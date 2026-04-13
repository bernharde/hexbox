# HexBox - NuGet Package

**Be.Windows.Forms.HexBox** is a reusable WinForms control for viewing and editing binary data in hexadecimal format.

## Quick Start

### Installation

```bash
dotnet add package HexBox
```

Or via NuGet Package Manager:
```
Install-Package HexBox
```

### Basic Usage

```csharp
using Be.Windows.Forms;

// Create and add HexBox control to your form
HexBox hexBox = new HexBox();
this.Controls.Add(hexBox);

// Load a file
FileByteProvider provider = new FileByteProvider("path/to/file.bin");
hexBox.ByteProvider = provider;
```

## Features

- View and edit binary files in hexadecimal format
- Fast performance with large files
- Intuitive byte navigation and selection
- Multiple byte provider implementations:
  - `FileByteProvider` - read files from disk
  - `DynamicFileByteProvider` - efficient large file handling
  - `MemoryDataBlock` - in-memory binary data
- Customizable display (colors, fonts, layout)
- Find and replace functionality
- Copy/paste support
- Read-only and editable modes

## Documentation

- **API Reference**: https://github.com/bernharde/hexbox/blob/main/docs/api/
- **GitHub Repository**: https://github.com/bernharde/hexbox
- **License**: MIT

## Supported Frameworks

- .NET Framework 4.8
- .NET 8.0 (Windows)
- .NET 10.0 (Windows)

## Example

```csharp
// Create hex box with memory provider
var hexBox = new HexBox();
byte[] data = File.ReadAllBytes("binary_file.bin");
hexBox.ByteProvider = new MemoryDataBlock(data);
hexBox.ReadOnly = false; // Enable editing
this.Controls.Add(hexBox);
```

## Contributing

Contributions are welcome! Please visit the GitHub repository for guidelines.

## License

This project is licensed under the MIT License - see LICENSE file for details.

---

**Version**: 2.0+  
**Author**: Bernhard Elbl  
**Repository**: https://github.com/bernharde/hexbox
