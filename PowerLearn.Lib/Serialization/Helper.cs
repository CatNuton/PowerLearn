using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Drawing;
using System.IO;

namespace PowerLearn.Serialization
{
    public static class Helper
    {
        public static void Serialize<T>(this T o, XmlWriter writer, string root)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add(String.Empty, String.Empty);
            var xmlra = new XmlRootAttribute(root);
            var sr = new XmlSerializer(typeof(T), xmlra);//Test.Author.GetType()
            sr.Serialize(writer, o, ns);
        }
        
        public static T Deserialize<T>(this XmlReader reader, string root)
        {
            var xmlra = new XmlRootAttribute(root);
            var xmldes = new XmlSerializer(typeof(T), xmlra);
            return (T)xmldes.Deserialize(reader);
        }

        public static string ToBase64(this Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                var bytes = ms.ToArray();
                return Convert.ToBase64String(bytes);
            }
        }

        public static Image ToImage(this string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
