using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PowerLearn
{
    public class Persons : List<Person>
    {
        private static int lastId;

        public static void SaveToFile(Persons people, string fileName)
        {
            var xml = new XmlSerializer(typeof(Persons));
            using (var w = new StreamWriter(fileName))
            {
                xml.Serialize(w, people);
            }
        }

        public static Persons ReadFromFile(string fileName)
        {
            var xml = new XmlSerializer(typeof(Persons));
            using (var r = new StreamReader(fileName))
            {
                return (Persons)xml.Deserialize(r);
            }
        }

        public new void Add(Person person)
        {
            base.Add(person);

            person.Id = ++lastId;
        }

        //public bool Copy(int index, out Person person)
        //{
        //    if (Count <= 10)
        //    {
        //        person = this[index].Copy();
        //        Add(person);
        //        return true;
        //    }
        //    person = null;
        //    return false;
        //}

        //public static bool Copy(int index, ref Persons people)
        //{
        //    if (people.Count <= 10)
        //    { 
        //        people.Add(people[index]);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
