# Changelog

All notable changes to **L2 Setup** will be documented in this file.

## [1.0.0] - 2025-11-13

### 🎉 Initial Release - L2 Setup

**Brand:** L2 - All-in-One Windows Post-Format Automation

### Core Features
- WPF application with Material Design UI and tabbed interface
- Custom tool selection with category grouping (44+ tools)
- **30+ Runtimes Installation (All-in-One)**
  - VC++ Redistributables (2005-2022, x86 + x64)
  - .NET Framework (3.5, 4.5.2-4.8.1)
  - .NET Runtimes (5.0-8.0)
  - DirectX, XNA Framework, OpenAL
  - Java 8 & 21 LTS
- GPU auto-detection (NVIDIA/AMD/Intel) and driver installation
- Brave browser backup/restore with ZIP compression
- **Customizable Windows Optimizations (30+ options)**
  - Performance, Privacy, Services, Gaming, Cleanup
  - Select individual optimizations or use presets
- Windows activation tools (MAS integration)
- WinRAR automatic license activation
- **Installer with .NET 8 Auto-Installation**
  - Automatically detects, downloads, and installs .NET 8 Runtime silently if missing
  - Installer does not close or open browser during .NET installation
- **Fix for Error 740 (Elevation Required)**
  - Implemented `RunAsAdmin.bat` wrapper to ensure the main application always launches with administrator privileges from shortcuts

### Windows Optimization Options
- **Performance**: Power Plan, Mouse Acceleration, Visual Effects, Explorer, Startup, Page File
- **Privacy**: Telemetry, Cortana, Advertising ID, Location, Diagnostics
- **Services**: Print Spooler, Fax, Windows Search, Superfetch, Windows Update
- **Gaming**: Game Mode, Game Bar, Game DVR, Hardware Accelerated GPU
- **Cleanup**: Temp Files, Recycle Bin, Windows.old, Downloads
- **Advanced**: Restore Points, OneDrive, Hibernation, Chris Titus Tech Script

### All Runtimes (30+)
- Visual C++ 2005, 2008, 2010, 2012, 2013, 2015-2022 (x86 & x64)
- .NET Framework 3.5, 4.5.2, 4.6.2, 4.7.2, 4.8, 4.8.1
- .NET Core/Modern 5.0, 6.0, 7.0, 8.0
- DirectX End-User Runtime, XNA 4.0, OpenAL
- Java Runtime 8 & 21, Visual Studio Tools for Office
- K-Lite Codec Pack (optional)

### Technical Implementation
- Admin privilege enforcement via app manifest
- Robust error handling with typed exceptions
- Asynchronous multi-threaded operations
- Download & cleanup system for runtimes
- Configurable release manager for GitHub workflow
- Self-contained single executable
- GitHub Actions CI/CD for automated builds

### Development Tools (44+)
- **Languages & Runtimes**: Git, Python 3.13, Node.js LTS, Java 21, Rust, Go
- **IDEs**: VS Code, Cursor, Notepad++, Visual Studio 2022 Community
- **Browsers**: Brave, Comet (Perplexity)
- **Gaming**: Discord, Steam
- **Utilities**: WinRAR (auto-activated), Lightshot, JDownloader 2, System Informer
- **Development**: .NET SDKs, Inno Setup 6, Postman, DBeaver
- **Package Managers**: Yarn, pnpm, Bun
- **Java Runtimes**: Corretto 8, 17, 21
- **Version Control**: GitHub Desktop

### Branding
- **Product Name**: L2 Setup
- **Executable**: L2Setup.exe
- **Installer**: L2Setup-Installer.exe
- **Repository**: L2-Setup
- **Publisher**: L2 - theDAVIDL2
- **Namespace**: L2.Setup

### Removed from Original Scope
- Docker Desktop (too large, niche)
- Obsidian (not essential)
- Cloudflare WARP (replaced with GPU driver system)

---

**Format:** Based on [Keep a Changelog](https://keepachangelog.com/)

**Versioning:** Following [Semantic Versioning](https://semver.org/)
