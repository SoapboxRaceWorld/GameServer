using System;
using System.Diagnostics;
using System.IO;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.TypeSystem;

namespace VictoryCodeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var decompiler = new CSharpDecompiler(args[0], new DecompilerSettings
            {
                ThrowOnAssemblyResolveErrors = false
            });
            var icsdns = decompiler.TypeSystem.RootNamespace;
            INamespace victoryNamespace = icsdns.GetChildNamespace("Victory") ?? throw new Exception();

            Directory.CreateDirectory("gen-code");
            processVictory(decompiler, victoryNamespace);
        }

        private static void processVictory(CSharpDecompiler decompiler, INamespace victoryNamespace)
        {
            Debug.WriteLine(victoryNamespace.FullName);
            string nsCodePath = Path.Combine("gen-code",
                victoryNamespace.FullName.Replace('.', Path.DirectorySeparatorChar));
            Directory.CreateDirectory(nsCodePath);
            foreach (var typeDefinition in victoryNamespace.Types)
            {
                string codePath = Path.Combine(nsCodePath,
                    typeDefinition.Name + ".cs");
                Debug.WriteLine("\t{0} -> {1}", typeDefinition.FullTypeName, codePath);
                //Debug.WriteLine(CodeGenerator.TypeToCode(typeDefinition));
                File.WriteAllText(codePath, CodeGenerator.TypeToCode(typeDefinition));
                //Debug.WriteLine(decompiler.DecompileTypeAsString(typeDefinition.FullTypeName));
                //File.WriteAllText(codePath, decompiler.DecompileTypeAsString(typeDefinition.FullTypeName));
            }

            foreach (var childNamespace in victoryNamespace.ChildNamespaces)
            {
                processVictory(decompiler, childNamespace);
            }
        }
    }
}
