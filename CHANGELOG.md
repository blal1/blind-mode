# Changelog

## v1.0.0 (2026-03-03)

Initial release of Master Duel Accessibility.

### Features

- **TTS** — Tolk integration for NVDA, JAWS, and SAPI
- **Keyboard shortcuts** — F1–F5, F12, Space, Alt with full help text (F1)
- **Announcement history** — F12 cycles through the last 10 announcements
- **Localization** — French (primary) and English (fallback), auto-detected from game language

### Duel

- LP change announcements (both players) with damage/heal amount
- Phase and turn change announcements
- Duel start and end (with result: win/lose/draw/timeout)
- Card summons: Normal, Special, Flip, Fusion, Synchro, Ritual, Xyz, Pendulum, Link, Maximum
- Attack declaration: attacker name + ATK vs target name + ATK
- Spell/trap activations, set, send to graveyard, banish, return to hand, shuffle
- Draw, coin flip (rock-paper-scissors), opponent thinking indicator
- Duel dialog announcements (confirm/select dialogs)
- Command menu (available actions when right-clicking a card)
- Timer announcement

### Menus

- Button focus: contextual announcements for every menu (position N of M)
- Shop: pack name, rarity, price, "New" label
- Missions: mission name, reward, time remaining
- Settings: slider value, toggle state
- Deck edit: card added/removed, deck renamed/saved, deck name on focus
- Card browser: auto-reads current card on open and on scroll
- Card crafting: create/dismantle/boost dialog + result message
- Deck selection: deck name announced on focus
- Matchmaking: searching / match found / timeout
- Notifications, friends, events, topics banners

### Technical

- MelonLoader v0.7.1 / Unity 6 IL2CPP
- Harmony patches via runtime reflection (no compile-time game DLL dependency)
- Input blocking: Tab, Ctrl (during duel), Escape (modal overlays), Space/Enter in input fields
- Deduplication of rapid repeated announcements (300 ms window)
