using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CheckContracts.ResharperFileGeneration
{
    internal static class Program
    {
        private static void Main()
        {
            AttributeGet.Analyze();

            using (var writer = new XmlTextWriter("CheckContracts.Nullness.Generated.xml", Encoding.UTF8))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("assembly");
                writer.WriteAttributeString("name", "CheckContracts");
                writer.WriteWhitespace(Environment.NewLine);

                foreach (var type in new[] {typeof(SafeCast), typeof(Validate)})
                {
                    foreach (var methodInfo in type.GetMethods(BindingFlags.Static | BindingFlags.Public))
                    {
                        writer.WriteStartElement("member");
                        writer.WriteAttributeString("name", methodInfo.Name);
                        writer.WriteWhitespace(Environment.NewLine);

                        WriteItemAttributes(methodInfo.GetCustomAttributes(), writer);

                        foreach (var parameterInfo in methodInfo.GetParameters())
                        {
                            writer.WriteStartElement("parameter");
                            writer.WriteAttributeString("name", parameterInfo.Name);
                            writer.WriteWhitespace(Environment.NewLine);

                            WriteItemAttributes(parameterInfo.GetCustomAttributes(), writer);

                            writer.WriteEndElement();
                        }

                        writer.WriteEndElement();
                    }
                }

                writer.WriteEndElement();

                writer.WriteEndDocument();
            }
        }

        private static void WriteItemAttributes(IEnumerable<Attribute> attributes, XmlTextWriter writer)
        {
            foreach (var attribute in attributes)
            {
                WriteAttribute(writer, attribute);
            }
        }

        private static void WriteAttribute(XmlWriter writer, Attribute attribute)
        {
            if (attribute.GetType().Name == "NotNullAttribute")
            {
                writer.WriteStartElement("attribute");
                writer.WriteAttributeString("ctor", "M:JetBrains.Annotations.NotNullAttribute.#ctor");
                writer.WriteWhitespace(Environment.NewLine);

                writer.WriteEndElement();
            }
        }
    }
}
