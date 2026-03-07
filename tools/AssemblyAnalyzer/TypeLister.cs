using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AssemblyAnalyzer
{
    // Lists all type names in a YGO Master Duel BepInEx interop stub DLL.
    // Called from Program.Main when --list flag is passed:
    //   AssemblyAnalyzer.exe --list [dll-path] [output-path]
    static class TypeLister
    {
        internal static void Run(string[] args)
        {
            string defaultAssembly = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                @"Steam\steamapps\common\Yu-Gi-Oh!  Master Duel\BepInEx\interop\Assembly-CSharp.dll");

            string defaultOutput = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                @"..\..\typelist.txt");

            string assemblyPath = args.Length > 0 ? args[0] : defaultAssembly;
            string outputPath   = args.Length > 1 ? args[1] : defaultOutput;

            Console.WriteLine("YGO Type Lister");
            Console.WriteLine("Loading: " + assemblyPath);

            if (!File.Exists(assemblyPath))
            {
                Console.WriteLine("ERROR: Assembly not found at " + assemblyPath);
                Console.WriteLine("Run the game at least once with BepInEx installed to generate interop stubs.");
                return;
            }

            try
            {
                // Use LoadFrom (not ReflectionOnlyLoadFrom) so dependency resolution works
                var assembly = Assembly.LoadFrom(assemblyPath);
                WriteTypes(assembly.GetTypes().Select(t => t.FullName).OrderBy(n => n).ToList(),
                           assemblyPath, outputPath);
            }
            catch (ReflectionTypeLoadException ex)
            {
                Console.WriteLine("Partial load. Writing available types.");
                var types = ex.Types.Where(t => t != null)
                                    .Select(t => t.FullName)
                                    .OrderBy(n => n)
                                    .ToList();
                WriteTypes(types, assemblyPath, outputPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void WriteTypes(List<string> types, string assemblyPath, string outputPath)
        {
            var dir = Path.GetDirectoryName(outputPath);
            if (!string.IsNullOrEmpty(dir))
                Directory.CreateDirectory(dir);

            using (var writer = new StreamWriter(outputPath))
            {
                writer.WriteLine("Types in: " + Path.GetFileName(assemblyPath));
                writer.WriteLine("Total: " + types.Count);
                writer.WriteLine(new string('=', 60));

                foreach (var t in types)
                    writer.WriteLine(t);
            }

            Console.WriteLine("Found " + types.Count + " types");
            Console.WriteLine("Output: " + outputPath);
        }
    }
}
