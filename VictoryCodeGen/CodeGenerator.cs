// This file is part of VictoryCodeGen by heyitsleo.
// 
// Created: 11/28/2019 @ 9:45 AM.

using System;
using System.Linq;
using System.Text;
using ICSharpCode.Decompiler.TypeSystem;

namespace VictoryCodeGen
{
    public static class CodeGenerator
    {
        public static string TypeToCode(ITypeDefinition typeDefinition)
        {
            return typeDefinition.Kind switch
            {
                TypeKind.Class => ClassToCode(typeDefinition),
                TypeKind.Enum => EnumToCode(typeDefinition),
                _ => throw new Exception("Cannot process type")
            };
        }

        private static string EnumToCode(ITypeDefinition typeDefinition)
        {
            StringBuilder sb = new StringBuilder(1024);

            sb.AppendFormat("namespace {0}", typeDefinition.Namespace).AppendLine().AppendLine("{");

            {
                // generate enum structure
                sb.AppendFormat("\tpublic enum {0}", typeDefinition.Name).AppendLine().AppendLine("\t{");

                foreach (var field in typeDefinition.Fields.Where(f => f.IsConst))
                {
                    object o = field.GetConstantValue();

                    sb.AppendFormat("\t\t{0} = {1}, ", field.Name, o).AppendLine();
                }

                sb.AppendLine("\t}");
            }

            sb.AppendLine("}");

            return sb.ToString();
        }

        private static string ClassToCode(ITypeDefinition typeDefinition)
        {
            StringBuilder sb = new StringBuilder(1024);
            sb.AppendLine("using System.Runtime.Serialization;");
            sb.AppendFormat("namespace {0}", typeDefinition.Namespace).AppendLine().AppendLine("{");

            {
                // generate class structure
                sb.AppendFormat("\t{0}", GenerateDataContractAttribute(typeDefinition)).AppendLine();
                sb.AppendFormat("\tpublic class {0}", typeDefinition.Name).AppendLine().AppendLine("\t{");

                foreach (var field in typeDefinition.Fields.Where(f => f.Accessibility == Accessibility.Public))
                {
                    string typeName = field.Type.FullName;
                    if (field.Type is ParameterizedType pt)
                    {
                        if (pt.TypeArguments.Count == 1)
                        {
                            typeName += $"<{pt.TypeArguments[0].FullName}>";
                        }
                        else
                        {
                            throw new Exception();
                        }
                    } 
                    //if(field.Type.Name=="List")
                    //    throw new Exception();
                    sb.AppendFormat("\t\t[DataMember]").AppendLine();
                    sb.AppendFormat("\t\tpublic {0} {1} {{get; set;}}", typeName, field.Name).AppendLine();
                }

                sb.AppendLine("\t}");
            }

            sb.AppendLine("}");

            return sb.ToString();
        }

        private static string GenerateDataContractAttribute(ITypeDefinition typeDefinition) =>
            $"[DataContract(Name = \"{typeDefinition.Name}\", Namespace = \"http://schemas.datacontract.org/2004/07/{typeDefinition.Namespace}\")]";
    }
}