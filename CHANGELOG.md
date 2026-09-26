# Changelog

## v269.26.3
- Native shells added to the asset matrix: Windows single-file portable exe (WebView2), Linux AppImage + deb (Tauri v2), Android signed APK — all produced by Actions on every tag
- Shipping builds are now obfuscated (control-flow flattening + base64 string array); the readable master stays local-only and is never committed
- README rebuilt to the exact CelSuite sibling template (icon/badge header dropped — siblings don't have one)
- Wallpaper `file://` probe retained (`new Image()` instead of `fetch`) so the single-file build shows its wallpaper straight from disk
- Version strings bumped to 269.26.3 (SALT untouched — saved logins stay valid)

## v269.26.2
- Finalized shipping build: wallpaper engine (tint / change / disable), Liquid Glass modifier (Dark, Light, OLED only), professional About & credits
- Fixed: marquee listener leak, OS file-drop on empty panes, sort desync across split panes, stale branch cache on Retry
- Perf: Web Worker base64 encoding, 400-node render cap with "Show more", thumbnail LRU prune, live API rate-limit chip

## v269.26.1
- Tabs + Nemo-style split view, READ ONLY mode, favourites, recents rail, global repo search, internal clipboard (copy/cut/paste), properties dialog, live animated SVG preview, OLED Dark theme, password-manager login form, encrypted token store v3

## v269.26.0
- Cache cloud (trees / blobs / thumbs / meta) with per-repo pins and retry-only refresh, 3-way conflict dialog (replace / keep both / skip), touch long-press drag with stacked-cards ghost, mobile shell + hamburger

## v269.22.0
- Explorer core: atomic commit engine (blob → tree → commit → ref), preview pipeline incl. font type-specimens, shimmer loaders, context menus, bookmarks

## v0
- The 2am prototype that started all of this, built in one late-night session with an AI co-dev. She insists on the record; the record complies.
