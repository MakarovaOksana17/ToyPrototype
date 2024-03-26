using System.Collections;
using System.Xml.Serialization;
namespace ToyPrototype.Extentions
{
    public static class ExtensionMethods
    {       
        public static T DeepCopyXml<T>(this T self)
        {            
            using (var ms = new MemoryStream())
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                s.Serialize(ms, self);
                ms.Position = 0;
                var classDeserialize = s.Deserialize(ms);
                if (classDeserialize != null)
                    return (T)classDeserialize;
                else return self;
            }
        }        
    }
}
