#!/usr/bin/env python3
"""
analyze_dump.py — Extracts and documents key types from the game's IL2CPP interop stubs.

Usage:
    python3 analyze_dump.py
    python3 analyze_dump.py --only enums duel card

Output: docs/analysis/*.txt

Source: decompiled/interop/Assembly-CSharp/[Namespace]/[ClassName].cs
These are IL2CppInterop-generated stubs with:
  - [Token] metadata tokens
  - [FieldOffset(Offset = "0xNN")] field memory offsets
  - [Address(RVA = "...", Offset = "...", VA = "...")] method addresses
  - Empty method bodies (stubs, not full implementations)
"""

import sys
from datetime import datetime
from pathlib import Path

INTEROP_DIR = (
    Path(__file__).parent.parent.parent.parent
    / "decompiled" / "interop" / "Assembly-CSharp"
)
OUT_DIR = Path(__file__).parent.parent / "docs" / "analysis"


# ─── Helpers ─────────────────────────────────────────────────────────────────

def read_class(rel_path: str) -> tuple[str, str] | None:
    """
    Read one interop stub file and return (display_name, content).
    Returns None (and prints a warning) if the file does not exist.
    """
    path = INTEROP_DIR / rel_path
    if not path.exists():
        print(f"  ⚠ Not found: {path}")
        return None
    return (path.stem, path.read_text(encoding="utf-8", errors="replace"))


def section(title: str, entries: list[tuple[str, str]]) -> str:
    sep = "=" * 60
    out = [sep, title, f"Count: {len(entries)}", sep, ""]
    for name, content in sorted(entries, key=lambda x: x[0]):
        out.append(f"── {name} " + "─" * max(0, 50 - len(name)))
        out.append(content.strip())
        out.append("")
    return "\n".join(out)


def write_report(name: str, header: str, sections_list: list[str]) -> None:
    OUT_DIR.mkdir(parents=True, exist_ok=True)
    path = OUT_DIR / f"analysis_{name}.txt"
    try:
        rel = INTEROP_DIR.relative_to(INTEROP_DIR.parent.parent.parent)
    except ValueError:
        rel = INTEROP_DIR
    content = "\n".join([
        f"Master Duel Assembly Analysis — {header}",
        f"Generated: {datetime.now().strftime('%Y-%m-%d %H:%M:%S')}",
        f"Source: {rel}",
        "=" * 60,
        "",
        *sections_list,
    ])
    path.write_text(content, encoding="utf-8")
    print(f"  ✓ {path.name}  ({path.stat().st_size // 1024} KB)")


def collect(paths: list[str]) -> list[tuple[str, str]]:
    """Read a list of relative paths; silently skip missing files."""
    results = []
    for p in paths:
        result = read_class(p)
        if result:
            results.append(result)
    return results


# ─── Analysis modules ────────────────────────────────────────────────────────

def run_enums(_: None = None) -> None:
    """Engine.cs — the single file that contains ALL Engine.* enums."""
    entries = collect([
        "YgomGame.Duel/Engine.cs",
    ])
    write_report("enums",
        "Engine Enums & Game Constants",
        [section("ENGINE CLASS (ViewType, Phase, SpSummonType, ResultType, …)", entries)])


def run_duel(_: None = None) -> None:
    """DuelClient, DuelLP, CardCommand — core duel patch targets."""
    entries = collect([
        "YgomGame.Duel/DuelClient.cs",
        "YgomGame.Duel/DuelLP.cs",
        "YgomGame.Duel/CardCommand.cs",
    ])
    write_report("duel",
        "Duel System Classes",
        [section("DUEL CORE CLASSES", entries)])


def run_card(_: None = None) -> None:
    """CardRoot, CardInfo*, Content — card data and field reading."""
    field_entries = collect([
        "YgomGame.Duel/CardRoot.cs",
    ])
    info_entries = collect([
        "YgomGame.Duel/CardInfo.cs",
        "YgomGame.CardFile/CardInfo.cs",
        "YgomGame.Duel/CardInfoBase.cs",
        "YgomGame.Duel/CardInfoDetail.cs",
    ])
    content_entries = collect([
        "YgomGame.Card/Content.cs",
    ])
    write_report("card",
        "Card System Classes",
        [
            section("CARD FIELD (terrain / zones)", field_entries),
            section("CARD INFO (UI panels)", info_entries),
            section("CONTENT (name/desc resolver)", content_entries),
        ])


def run_ui(_: None = None) -> None:
    """SelectionButton, ViewController, ColorContainer* — UI navigation."""
    nav_entries = collect([
        "YgomSystem.UI/SelectionButton.cs",
        "YgomSystem.UI/ViewController.cs",
    ])
    color_entries = collect([
        "YgomSystem.UI/ColorContainer.cs",
        "YgomSystem.UI/ColorContainerGraphic.cs",
        "YgomSystem.UI/ColorContainerImage.cs",
    ])
    misc_entries = collect([
        "YgomSystem.UI/ScrollRectPageSnap.cs",
        "YgomSystem.UI/RubyTextGX.cs",
        "YgomSystem.YGomTMPro/ExtendedTextMeshProUGUI.cs",
    ])
    write_report("ui",
        "UI Navigation Classes",
        [
            section("NAVIGATION (SelectionButton / ViewController)", nav_entries),
            section("COLOR CONTAINER (icon button triggers)", color_entries),
            section("MISCELLANEOUS UI HELPERS", misc_entries),
        ])


def run_phase(_: None = None) -> None:
    """PhaseSelectWindow — phases and turns."""
    entries = collect([
        "YgomGame.Duel/PhaseSelectWindow.cs",
    ])
    write_report("phase",
        "Phase & Turn System",
        [section("PHASE / TURN CLASSES", entries)])


def run_dialogs(_: None = None) -> None:
    """DuelConfirmDialog, DuelSelectDialog — in-duel dialogs."""
    entries = collect([
        "YgomGame.Duel/DuelConfirmDialog.cs",
        "YgomGame.Duel/DuelSelectDialog.cs",
        "YgomGame.Duel/DuelDialogBase.cs",
    ])
    write_report("dialogs",
        "Duel Dialog Classes",
        [section("DUEL DIALOGS", entries)])


def run_matchmaking(_: None = None) -> None:
    """PvpMenuMatchingViewController and related matchmaking types."""
    entries = collect([
        "PvpMenuMatchingViewController.cs",
        "PvpMenuMatchingViewControllerBase.cs",
    ])
    write_report("matchmaking",
        "Matchmaking Classes",
        [section("MATCHMAKING", entries)])


def run_deck(_: None = None) -> None:
    """DeckEditViewController2, CardBrowserViewController, SnapContentManager."""
    entries = collect([
        "YgomGame/DeckEditViewController2.cs",
        "YgomGame.CardBrowser/CardBrowserViewController.cs",
        "YgomSystem.UI/SnapContentManager.cs",
    ])
    write_report("deck",
        "Deck Editor & Card Browser Classes",
        [section("DECK / BROWSER", entries)])


# ─── Main ────────────────────────────────────────────────────────────────────

MODULES: dict[str, object] = {
    "enums":       run_enums,
    "duel":        run_duel,
    "card":        run_card,
    "ui":          run_ui,
    "phase":       run_phase,
    "dialogs":     run_dialogs,
    "matchmaking": run_matchmaking,
    "deck":        run_deck,
}

if __name__ == "__main__":
    args = sys.argv[1:]

    # Support: python3 analyze_dump.py --only enums duel
    if args and args[0] == "--only":
        requested = args[1:]
    else:
        requested = args if args else list(MODULES.keys())

    unknown = [m for m in requested if m not in MODULES]
    if unknown:
        print(f"Unknown modules: {unknown}. Available: {list(MODULES.keys())}")
        sys.exit(1)

    print(f"Source: {INTEROP_DIR}")
    if not INTEROP_DIR.exists():
        print(f"ERROR: interop directory not found at {INTEROP_DIR}")
        sys.exit(1)

    OUT_DIR.mkdir(parents=True, exist_ok=True)
    print(f"Output: {OUT_DIR}\n")

    for name in requested:
        print(f"Analyzing: {name}")
        MODULES[name]()   # type: ignore[operator]

    print(f"\nDone. {len(requested)} report(s) written to: {OUT_DIR}")
