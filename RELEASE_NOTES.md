## v269.26.3 — "Feathers for Everything"

One pass, four wounds closed: native shells for the whole matrix, obfuscated shipping, a sibling-exact README, and the wallpaper fix retained.

- **Native shells:** Windows portable exe + standalone zip (WebView2), Linux AppImage + deb (Tauri v2), Android signed APK (WebView) — built by Actions on every tag
- **Obfuscated shipping:** the repo and every release asset now carry obfuscated bytes; the readable master stays local-only
- **README:** rebuilt to the exact CelSuite sibling template (icon/badge header removed — siblings don't ship one)
- **Wallpaper:** `file://` probe retained so the single-file build renders its wallpaper straight from disk
- **Version:** strings bumped to 269.26.3, SALT untouched (saved logins stay valid)

### Assets

| Platform | Download Asset | Type | Description |
| :-- | :-- | :-- | :-- |
| 📱 **Android** | `CelSuite-RepoExplorer-v269.26.3.apk` | Mobile App | WebView shell, works offline, tiny |
| 🪟 **Windows** | `CelSuite-RepoExplorer-Windows-Portable.exe` | Single File | WebView2 portable executable (zero install, double-click to run) |
| 🪟 **Windows** | `CelSuite-RepoExplorer-Windows-Standalone.zip` | Standalone Folder | Unzip and run for instant cold-boot startup |
| 🐧 **Linux** | `CelSuite-RepoExplorer-Linux-Portable.bin` | AppImage | `chmod +x` and launch directly |
| 🐧 **Linux** | `CelSuite-RepoExplorer-Linux-Standalone.deb` | Debian Package | `sudo dpkg -i` and go |
| 📄 **Any OS** | `CelSuite-RepoExplorer-v269.26.3.html` | Single File | The entire app, obfuscated, double-click anywhere |
| 🗜️ **Any OS** | `CelSuite-RepoExplorer-v269.26.3-Portable.zip` | Web Pack | html + icon + wallpaper for your own server |
