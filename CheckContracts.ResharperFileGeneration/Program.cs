using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using JetBrains.Annotations;

namespace CheckContracts.ResharperFileGeneration
{
    internal static class Program
    {
        private static readonly string[] SimpleAttributeTypeNames = new[] { typeof(NotNullAttribute), typeof(CanBeNullAttribute), typeof(PureAttribute) }.Select(t => t.Name).ToArray();

        private const string AttributeNamespace = "JetBrains.Annotations";

        private static void Main()
        {
            WriteData().Wait();
        }

        private async static Task WriteData()
        {
            var assembly = typeof(Validate).Assembly;
            var fileInfo = new FileInfo($"{assembly.GetName().Name}.ExternalAnnotations.xml");

            using (var file = fileInfo.Open(FileMode.Create))
            {
                var settings = new XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = "     ",
                    NewLineOnAttributes = false,
                    OmitXmlDeclaration = true,
                    Async = true,
                    Encoding = Encoding.UTF8,
                    CheckCharacters = true
                };

                using (var xmlWriter = XmlWriter.Create(file, settings))
                {
                    await xmlWriter.WriteStartDocumentAsync();

                    await xmlWriter.WriteStartElementAsync(null, "assembly", null);
                    await xmlWriter.WriteAttributeStringAsync(null, "name", null, string.Format("{0}, Version={1}", assembly.GetName().Name, assembly.GetName().Version));

                    foreach (var type in assembly.GetTypes().Where(t => t.IsPublic && !typeof(Attribute).IsAssignableFrom(t) && !t.IsEnum))
                    {
                        foreach (var method in type.GetMethods(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public))
                        {
                            var name = string.Format("M:{0}.{1}({2})", type.FullName, method.Name, string.Join(", ", method.GetParameters().Select(p => p.ParameterType.FullName)));

                            await xmlWriter.WriteStartElementAsync(null, "member", null);

                            await xmlWriter.WriteAttributeStringAsync(null, "name", null, name);

                            foreach (var attribute in method.GetCustomAttributes<Attribute>(true))
                            {
                                await WriteAttribute(xmlWriter, attribute);
                            }

                            foreach (var parameterInfo in method.GetParameters())
                            {
                                await xmlWriter.WriteStartElementAsync(null, "parameter", null);
                                await xmlWriter.WriteAttributeStringAsync(null, "name", null, parameterInfo.Name);

                                foreach (var attribute in parameterInfo.GetCustomAttributes())
                                {
                                    await WriteAttribute(xmlWriter, attribute);
                                }

                                await xmlWriter.WriteEndElementAsync();
                            }

                            await xmlWriter.WriteEndElementAsync();
                        }
                    }

                    await xmlWriter.WriteEndElementAsync();

                    await xmlWriter.WriteEndDocumentAsync();
                }
            }
        }

        private static Task WriteAttribute(XmlWriter xmlWriter, Attribute methodAttribute)
        {
            var type = methodAttribute.GetType();

            if (SimpleAttributeTypeNames.Contains(type.Name))
            {
                return WriteEmptyCtorAttribute(xmlWriter, methodAttribute);
            }

            if (typeof(StringFormatMethodAttribute) == type)
            {
                return WriteStringFormatMethodAttribute(xmlWriter, (StringFormatMethodAttribute)methodAttribute);
            }

            if (typeof(ContractAnnotationAttribute) == type)
            {
                return WriteContractAnnotationAttribute(xmlWriter, (ContractAnnotationAttribute)methodAttribute);
            }

            return Task.FromResult(0);
        }

        private static async Task WriteContractAnnotationAttribute(XmlWriter xmlWriter, ContractAnnotationAttribute attribute)
        {
            var ctorName = string.Format("M:{0}.{1}.#ctor(System.String)", AttributeNamespace, attribute.GetType().Name);

            await xmlWriter.WriteStartElementAsync(null, "attribute", null);
            await xmlWriter.WriteAttributeStringAsync(null, "ctor", null, ctorName);

            await xmlWriter.WriteElementStringAsync(null, "argument", null, attribute.Contract);

            await xmlWriter.WriteEndElementAsync();
        }

        private static async Task WriteStringFormatMethodAttribute(XmlWriter xmlWriter, StringFormatMethodAttribute attribute)
        {
            var ctorName = string.Format("M:{0}.{1}.#ctor(System.String)", AttributeNamespace, attribute.GetType().Name);

            await xmlWriter.WriteStartElementAsync(null, "attribute", null);
            await xmlWriter.WriteAttributeStringAsync(null, "ctor", null, ctorName);

            await xmlWriter.WriteElementStringAsync(null, "argument", null, attribute.FormatParameterName);

            await xmlWriter.WriteEndElementAsync();
        }

        private static async Task WriteEmptyCtorAttribute(XmlWriter xmlWriter, Attribute attribute)
        {
            var ctorName = string.Format("M:{0}.{1}.#ctor", AttributeNamespace, attribute.GetType().Name);

            await xmlWriter.WriteStartElementAsync(null, "attribute", null);
            await xmlWriter.WriteAttributeStringAsync(null, "ctor", null, ctorName);

            await xmlWriter.WriteEndElementAsync();
        }
    }
}
