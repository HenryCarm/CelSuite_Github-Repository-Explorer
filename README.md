<p align="center"><img src="icon.webp" width="96" style="border-radius:22px" alt="icon"/></p>
<p align="center">
  <img src="https://img.shields.io/github/v/release/HenryCarm/CelSuite_Github-Repository-Explorer?style=flat-square&color=ff4d4d" alt="release">
  <img src="https://img.shields.io/badge/single--file-108KB-ff9f43?style=flat-square" alt="size">
  <img src="https://img.shields.io/badge/dependencies-zero-6ccb5f?style=flat-square" alt="deps">
  <img src="https://img.shields.io/badge/license-proprietary-8a8a8a?style=flat-square" alt="license">
</p>

# CelSuite — GitHub Repository Explorer

**Windows-Explorer-grade file management for GitHub repos, packed into one HTML file. Upload, move, rename, delete, preview, edit — every action lands as a single clean atomic commit.**

---

<p align="center"><img src="banner.webp" width="100%" style="border-radius:14px;max-width:820px"/></p>

## 🌟 Overview

**CelSuite GitHub Repository Explorer** is a browser-native repo workspace that behaves like the file manager you grew up with — tabs, split panes, marquee selection, drag & drop — except every "save" is a real Git commit built from the Git Data API (blob → tree → commit → ref). No server. No build step. No dependencies. One file and your token.

- **Explorer shell** — command bar, breadcrumbs, sidebar, status bar, context menus, icons/details views, multi-tab + Nemo-style split panes (F3/F4)
- **Real Git writes** — uploads, moves, renames, deletes and text edits compile into atomic commits; conflicts ask instead of guessing
- **Local cache cloud** — trees, text blobs and thumbnails live in IndexedDB; repos open instantly and only refresh when you hit Retry
- **Preview pipeline** — images (with live animated SVG/GIF/WebP), audio, video, font type-specimens, and an inline text editor
- **Safety rails** — encrypted token at rest, password-manager-friendly login, READ ONLY mode for repos you can't push to, detailed system logs

## 📦 Downloads & Releases

All artifacts are built and attached by GitHub Actions on every tag.

👉 **Latest: v269.26.2**

| Asset | File | Notes |
| :-- | :-- | :-- |
| 📄 Single File | `CelSuite-RepoExplorer-v269.26.2.html` | The whole app. Double-click it. |
| 🗜️ Portable Pack | `CelSuite-RepoExplorer-v269.26.2-Portable.zip` | html + icon + wallpaper, ready to carry |

## ✨ Key Features

- 🗂️ **Tabs & Split Panes** — Windows 11 tabs, Linux-Mint-Nemo split (F3 vertical / F4 horizontal), drag files between panes
- 🖱️ **Marquee + Touch** — draw-a-box selection like the desktop; long-press hold-drag on phones with a stacked-cards ghost
- ⚡ **Cache Cloud** — per-repo pinning, retry-only updates, commits refresh the cache themselves
- 🎨 **Themes** — Dark (default), OLED Dark, Light, CelSuite Red, Matrix + a Liquid Glass modifier for the first three
- 🖼️ **Wallpaper Engine** — your image behind the app with adjustable tint, custom swap, or off
- 🔐 **Encrypted Credentials** — token encrypted at rest; login form speaks to your browser's password manager
- 👁️ **READ ONLY Mode** — open any public repo; writes disable themselves when you lack push
- 🧾 **System Logs** — every API call, error and stack trace in one inspectable place
- ⭐ **Bookmarks · Recents · Favourites** — the left rail remembers what you touch

## ⌨️ Power Keys

| Key | Action |
| :-- | :-- |
| F1 | Shortcuts |
| F3 / F4 | Split vertical / horizontal |
| F5 | Retry / refresh (the only "pull latest") |
| Ctrl+T / Ctrl+W | New / close tab |
| Ctrl+C / X / V | Copy / cut / paste inside repo |
| Ctrl+Shift+F | Search whole repo |
| F2 / Del | Rename / delete |
| Alt+Enter | Properties |

## 🛠️ Quick Setup

1. Create a Personal Access Token — classic with `repo`, or fine-grained with **Contents: Read & write** on the repos you manage.
2. Download the single file (or the portable pack) and double-click it.
3. Sign in with your GitHub username + token. Your browser will offer to remember it like any normal password.
4. Pick a repo. Drag things. Break things. Every fix is one commit.

## 🕳️ Honest Limits

- 60 MB per uploaded file (GitHub blob API ceiling, not mine)
- Mega-repos with truncated recursive trees open in warning mode
- No merge-conflict wrestling — concurrent remote changes make commits refuse politely; refresh and retry
- Needs a modern browser (Chromium / Firefox / Safari 16+)

## 📜 Changelog

Full history lives in [CHANGELOG.md](CHANGELOG.md). Spoiler: it starts at 2am.

## 📄 License

Proprietary — © 2026 HenryJayz. All rights reserved. Source is published for personal use and study; redistribution of unmodified binaries is welcome, claiming them as yours is not.

<p align="center"><img src="banner_footer.webp" width="100%" style="border-radius:14px;max-width:820px"/></p>
<p align="center"><sub>Part of the <b>CelSuite</b> family — programs you didn't know you needed. Built late-night by HenryJayz with an AI co-dev who negotiated her credit into the About dialog.</sub></p>
