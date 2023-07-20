# SatDumpLauncher
 Launcher for SatDump that provides automatic updates. Runs on .NET 6. To use, download the exe from releases, place it in your main SatDump folder, and run it.

# Supported Platforms
 This program uses .NET 6, so it will run on Windows 7 or newer. Linux and Mac are not currently supported.

# Settings
 - Use Nightly Builds - If this setting is checked, the launcher will download the latest nightly build of SatDump instead of the latest release. This is helpful if you are looking for a specific feature that was recently added. Leaving this setting unchecked while having a nightly build installed will install the latest release build.
- Clean Install - Checking this setting will delete everything within the SatDump folder before installing the update, instead of overriding existing files. Useful for resetting your settings and ensuring that any potentially corrupted files are removed.