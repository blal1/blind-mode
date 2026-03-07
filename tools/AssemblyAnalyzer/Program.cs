using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AssemblyAnalyzer
{
    class Program
    {
        // ── YGO Master Duel — class name keywords ────────────────────────────
        static readonly string[] ClassKeywords = new[]
        {
            // YGO card zones
            "Card", "Deck", "Hand", "Grave", "Banish", "ExtraDeck", "Zone",
            // YGO summon types
            "Ritual", "Synchro", "Xyz", "Fusion", "Link", "Pendulum",
            // Duel flow
            "Duel", "LP", "Turn", "Phase", "Match", "Player", "Effect", "Monster", "Spell", "Trap",
            // UI / navigation
            "UI", "Screen", "Panel", "View", "Controller", "Manager",
            "Menu", "Navigation", "Scene", "Dialog", "Modal", "Popup",
            "Button", "Field", "ViewController", "SelectionButton", "Selector", "Window",
            // Info display
            "Tooltip", "Select", "Focus", "Input",
            "Text", "Label", "Display", "Info", "Detail",
            // YGO namespaces (filter noise)
            "YgomGame", "YgomSystem", "YgomMiniGame",
            // Game lifecycle
            "Loading", "Title", "Top",
        };

        // ── YGO Master Duel — method name keywords ───────────────────────────
        static readonly string[] MethodKeywords = new[]
        {
            // Generic getters
            "GetName", "GetText", "GetTitle", "GetDescription", "GetDesc",
            // YGO card stats
            "GetAtk", "GetDef", "GetLevel", "GetLink", "GetRank",
            // Display
            "Display", "Show", "Render", "Update", "Set", "Open", "Close",
            // Interaction
            "OnSelected", "OnDeselected", "OnPointerClick",
            "OnHover", "OnSelect", "OnClick", "OnFocus",
            // Duel-specific
            "SetLP", "ChangeLP", "Invoke", "RunEffect",
        };

        static void Main(string[] args)
        {
            // Default to BepInEx interop stubs for YGO Master Duel
            string defaultAssembly = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                @"Steam\steamapps\common\Yu-Gi-Oh!  Master Duel\BepInEx\interop\Assembly-CSharp.dll");

            string defaultOutput = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                @"..\..\analysis_results.txt");

            // --list mode: just dump all type names and exit
            if (args.Length > 0 && args[0] == "--list")
            {
                TypeLister.Run(args.Skip(1).ToArray());
                return;
            }

            string assemblyPath = args.Length > 0 ? args[0] : defaultAssembly;
            string outputPath   = args.Length > 1 ? args[1] : defaultOutput;

            Console.WriteLine("YGO Master Duel Assembly Analyzer");
            Console.WriteLine("Loading: " + assemblyPath);

            if (!File.Exists(assemblyPath))
            {
                Console.WriteLine("ERROR: Assembly not found at " + assemblyPath);
                Console.WriteLine("Run the game at least once with BepInEx installed to generate interop stubs.");
                return;
            }

            try
            {
                var results = AnalyzeAssembly(assemblyPath);
                WriteResults(results, outputPath);
                Console.WriteLine("Analysis complete. Results written to: " + outputPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static List<ClassInfo> AnalyzeAssembly(string path)
        {
            var results  = new List<ClassInfo>();
            var assembly = Assembly.LoadFrom(path);

            Type[] types;
            try
            {
                types = assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException ex)
            {
                Console.WriteLine("Warning: Some types could not be loaded. Processing available types.");
                Console.WriteLine("Loaded " + ex.Types.Count(t => t != null) + " types.");
                types = ex.Types.Where(t => t != null).ToArray();
            }

            Console.WriteLine("Total types in assembly: " + types.Length);

            Console.WriteLine("Sample type names:");
            foreach (var t in types.Take(20))
                Console.WriteLine("  " + t.FullName);

            foreach (var type in types)
            {
                try
                {
                    if (!IsRelevantClass(type.Name))
                        continue;

                    var classInfo = new ClassInfo
                    {
                        Name       = type.FullName,
                        BaseClass  = type.BaseType != null ? type.BaseType.Name : "None",
                        IsPublic   = type.IsPublic,
                        Properties = new List<string>(),
                        Methods    = new List<string>(),
                        Events     = new List<string>(),
                    };

                    try
                    {
                        foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
                        {
                            try { classInfo.Properties.Add(prop.PropertyType.Name + " " + prop.Name); }
                            catch { }
                        }
                    }
                    catch { }

                    try
                    {
                        foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
                        {
                            try
                            {
                                if (method.IsSpecialName) continue;
                                var parameters = string.Join(", ", method.GetParameters()
                                    .Select(p => p.ParameterType.Name + " " + p.Name));
                                classInfo.Methods.Add(method.ReturnType.Name + " " + method.Name + "(" + parameters + ")");
                            }
                            catch { }
                        }
                    }
                    catch { }

                    try
                    {
                        foreach (var evt in type.GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
                        {
                            try
                            {
                                var handlerName = evt.EventHandlerType != null ? evt.EventHandlerType.Name : "Unknown";
                                classInfo.Events.Add(handlerName + " " + evt.Name);
                            }
                            catch { }
                        }
                    }
                    catch { }

                    results.Add(classInfo);
                }
                catch { }
            }

            return results.OrderBy(c => c.Name).ToList();
        }

        static bool IsRelevantClass(string name)
        {
            return ClassKeywords.Any(keyword =>
                name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        static void WriteResults(List<ClassInfo> results, string outputPath)
        {
            // Ensure output directory exists
            var dir = Path.GetDirectoryName(outputPath);
            if (!string.IsNullOrEmpty(dir))
                Directory.CreateDirectory(dir);

            using (var writer = new StreamWriter(outputPath))
            {
                writer.WriteLine("YGO Master Duel Assembly Analysis Results");
                writer.WriteLine("Generated: " + DateTime.Now);
                writer.WriteLine("Total classes found: " + results.Count);
                writer.WriteLine(new string('=', 60));
                writer.WriteLine();

                // ── Section groupings for YGO ────────────────────────────────

                var titleClasses = results.Where(c =>
                    ContainsKeyword(c.Name, "Title", "Top", "Loading", "Boot")).ToList();

                var menuClasses = results.Where(c =>
                    ContainsKeyword(c.Name, "Menu", "Navigation", "ViewController", "Selector")).ToList();

                var dialogClasses = results.Where(c =>
                    ContainsKeyword(c.Name, "Dialog", "Modal", "Popup", "Window")).ToList();

                var duelCardClasses = results.Where(c =>
                    ContainsKeyword(c.Name, "Card", "Deck", "Hand", "Grave", "Banish", "ExtraDeck",
                                             "Zone", "Monster", "Spell", "Trap", "LP", "Duel")).ToList();

                var summonClasses = results.Where(c =>
                    ContainsKeyword(c.Name, "Ritual", "Synchro", "Xyz", "Fusion", "Link", "Pendulum")).ToList();

                var uiClasses = results.Where(c =>
                    ContainsKeyword(c.Name, "UI", "Screen", "Panel", "View", "Display",
                                             "Button", "SelectionButton", "Field")).ToList();

                var gameFlowClasses = results.Where(c =>
                    ContainsKeyword(c.Name, "Game", "Turn", "Phase", "Match", "Player",
                                             "Effect", "Scene", "Controller", "Manager")).ToList();

                var inputClasses = results.Where(c =>
                    ContainsKeyword(c.Name, "Tooltip", "Select", "Focus", "Input",
                                             "YgomSystem")).ToList();

                WriteSection(writer, "TITLE / STARTUP CLASSES",             titleClasses);
                WriteSection(writer, "MENU / NAVIGATION / VIEWCONTROLLER",  menuClasses);
                WriteSection(writer, "DIALOG / POPUP / WINDOW CLASSES",     dialogClasses);
                WriteSection(writer, "DUEL / CARD RELATED CLASSES",         duelCardClasses);
                WriteSection(writer, "SUMMON TYPE CLASSES",                 summonClasses);
                WriteSection(writer, "UI / PANEL / BUTTON CLASSES",         uiClasses);
                WriteSection(writer, "GAME FLOW / SCENE / MANAGER CLASSES", gameFlowClasses);
                WriteSection(writer, "INPUT / SELECTION CLASSES",           inputClasses);

                writer.WriteLine(new string('=', 60));
                writer.WriteLine("INTERESTING METHODS (display / interaction related)");
                writer.WriteLine(new string('=', 60));
                writer.WriteLine();

                foreach (var cls in results)
                {
                    var interestingMethods = cls.Methods.Where(m =>
                        MethodKeywords.Any(k => m.IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();

                    if (interestingMethods.Any())
                    {
                        writer.WriteLine("Class: " + cls.Name);
                        foreach (var method in interestingMethods)
                            writer.WriteLine("  Method: " + method);
                        writer.WriteLine();
                    }
                }
            }
        }

        static bool ContainsKeyword(string name, params string[] keywords)
        {
            return keywords.Any(k => name.IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        static void WriteSection(StreamWriter writer, string title, List<ClassInfo> classes)
        {
            writer.WriteLine(new string('=', 60));
            writer.WriteLine(title);
            writer.WriteLine("Count: " + classes.Count);
            writer.WriteLine(new string('=', 60));
            writer.WriteLine();

            foreach (var cls in classes)
            {
                writer.WriteLine("CLASS: " + cls.Name);
                writer.WriteLine("Base: " + cls.BaseClass);
                writer.WriteLine("Public: " + cls.IsPublic);

                if (cls.Properties.Any())
                {
                    writer.WriteLine("Properties:");
                    foreach (var prop in cls.Properties)
                        writer.WriteLine("  " + prop);
                }

                if (cls.Methods.Any())
                {
                    writer.WriteLine("Methods:");
                    foreach (var method in cls.Methods)
                        writer.WriteLine("  " + method);
                }

                if (cls.Events.Any())
                {
                    writer.WriteLine("Events:");
                    foreach (var evt in cls.Events)
                        writer.WriteLine("  " + evt);
                }

                writer.WriteLine(new string('-', 40));
                writer.WriteLine();
            }
        }
    }

    class ClassInfo
    {
        public string Name { get; set; } = "";
        public string BaseClass { get; set; } = "None";
        public bool IsPublic { get; set; }
        public List<string> Properties { get; set; } = new List<string>();
        public List<string> Methods { get; set; } = new List<string>();
        public List<string> Events { get; set; } = new List<string>();
    }
}
