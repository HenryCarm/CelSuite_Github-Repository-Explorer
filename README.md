# CelSuite GitHub Repository Explorer

**Windows-Explorer-grade file management for GitHub repos, packed into one HTML file. Upload, move, rename, delete, preview, edit — every action lands as a single clean atomic commit.**

* * *

## 🌟 Overview

**CelSuite GitHub Repository Explorer** is a complete browser-native repo workspace:

- **Explorer Shell:** Tabs, Nemo-style split panes (F3/F4), breadcrumbs, sidebar rails, marquee + touch selection, context menus, icons/details views.
- **Real Git Writes:** Uploads, moves, renames, deletes & text edits compile into atomic blob → tree → commit → ref transactions; name conflicts ask instead of guessing.
- **Local Cache Cloud:** Trees, text blobs & thumbnails live in an IndexedDB content-addressed cloud; repos open instantly and only refresh on Retry.
- **Preview Pipeline:** Images with live animated SVG/GIF/WebP, audio, video, font type-specimens, inline text editor.
- **Safety Rails:** Encrypted token at rest, password-manager login, READ ONLY mode, full system logs.

* * *

## 📦 Downloads & Releases

All desktop executables, mobile packages and single-file builds are produced automatically by GitHub Actions on every tag.

👉 **Download the Latest Release (v269.26.3)**

| Platform | Download Asset | Type | Description |
| :-- | :-- | :-- | :-- |
| 📱 **Android** | `CelSuite-RepoExplorer-v269.26.3.apk` | Mobile App | WebView shell, works offline, tiny |
| 🪟 **Windows** | `CelSuite-RepoExplorer-Windows-Portable.exe` | Single File | WebView2 portable executable (zero install, double-click to run) |
| 🪟 **Windows** | `CelSuite-RepoExplorer-Windows-Standalone.zip` | Standalone Folder | Unzip and run for instant cold-boot startup |
| 🐧 **Linux** | `CelSuite-RepoExplorer-Linux-Portable.bin` | AppImage | `chmod +x` and launch directly |
| 🐧 **Linux** | `CelSuite-RepoExplorer-Linux-Standalone.deb` | Debian Package | `sudo dpkg -i` and go |
| 📄 **Any OS** | `CelSuite-RepoExplorer-v269.26.3.html` | Single File | The entire app, obfuscated, double-click anywhere |
| 🗜️ **Any OS** | `CelSuite-RepoExplorer-v269.26.3-Portable.zip` | Web Pack | html + icon + wallpaper for your own server |

* * *

## ✨ Key Features

- ⚡ **Atomic Commits:** Every mutation is one clean Git commit via the Git Data API — no force-pushes, no mess.
- 🗂️ **Tabs & Split Panes:** Windows 11 tabs with Linux-Mint-Nemo instant split (F3 / F4), drag between panes.
- 🖱️ **Desktop-Grade Selection:** Marquee draw-box, Shift ranges, Ctrl combos, long-press hold-drag on touch.
- ⚡ **Cache Cloud:** Per-repo pinning; retry-only updates; commits refresh the cache themselves.
- 🎨 **Nine Themes:** Dark, OLED Dark, Light, CelSuite Red, Sunset, Ocean, Violet, Forest, Matrix + Liquid Glass modifier.
- 🖼️ **Wallpaper Engine:** Custom image behind every theme with tint slider or full disable.
- 🔐 **Encrypted Credentials:** Token encrypted at rest; login form speaks to your browser's password manager.
- 👁️ **READ ONLY Mode:** Any public repo opens browsable; writes disable themselves without push rights.
- 🧾 **System Logs:** Every API call, error and stack trace inspectable in-app.

* * *

## 🚀 How It Works

```
Browser / native shell                          GitHub Git Data API
       │                                                 │
       ├──── GET tree (recursive, cached) ──────────────>│  (Instant open)
       │                                                 │
       ├──── POST blobs (worker-encoded) ───────────────>│  (Uploads)
       │                                                 │
       ├──── POST tree (base_tree + deltas) ────────────>│  (Move/rename/delete)
       │                                                 │
       ├──── POST commit + PATCH ref ───────────────────>│  (Atomic save)
       │                                                 │
       └──── IndexedDB cloud ← trees / blobs / thumbs    │  (Offline instant)
```

* * *

## 🛠️ Quick Setup

### 📱 Android Setup:

1. Install the APK (allow unknown sources once).
2. Open, sign in with username + PAT, pick a repo. Done.

### 💻 PC Setup (Windows / Linux):

1. Download the Portable exe / Linux bin (or install the deb).
2. Launch — WebView2 ships with Windows 10/11; WebKit ships with most distros.
3. Sign in with a classic `repo` token or fine-grained **Contents: Read & write**.

### 🌐 Any-OS Setup:

1. Double-click the single html file (or unzip the Web Pack on your server).
2. Sign in, pick a repo, drag things. Every fix is one commit.

* * *

## 📜 Changelog

See CHANGELOG.md for full version history and release notes.

* * *

## 📄 License

Proprietary — © 2026 HenryJayz. All rights reserved. Shipped binaries are obfuscated; source is published for personal study only. Redistribution of unmodified binaries is welcome, claiming them as yours is not.

* * *

<div align="center"><img src="banner_footer.webp" width="100%" style="border-radius: 14px; max-width: 820px;" /></div>
<p align="center"><sub>Part of the <b>CelSuite</b> family — programs you didn't know you needed. Built late-night by HenryJayz with an AI co-dev who negotiated her credit into the About dialog.</sub></p>
