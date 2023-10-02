using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;

namespace PowerLearn.Serialization
{
    public static class Helper
    {

        private static readonly Dictionary<Image, MemoryStream> images = new Dictionary<Image, MemoryStream>();

        public static void Clean()
        {
            foreach (var item in images)
            {
                try
                {
                    item.Value.Dispose();
                    item.Key.Dispose();
                }
                catch (Exception)
                {
                    //continue;
                }
            }
        }

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
            if (string.IsNullOrEmpty(base64))
            {
                return default;
            }
            var bytes = Convert.FromBase64String(base64);
            var ms = new MemoryStream(bytes);
            var result = Image.FromStream(ms);
            images.Add(result, ms);
            return result;
        }
    }
}
