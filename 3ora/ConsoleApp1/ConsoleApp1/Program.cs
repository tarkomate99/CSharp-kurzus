using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class Pont
    {

        [XmlAttribute("cica")]

        public double X { get; set; }

        [XmlAttribute("kutya")]

        public double Y { get; set; }

        [XmlElement("MeresiHiba")]
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var file = File.CreateText(@"U:\valami.txt"))
                {
                    file.WriteLine("Hello File kezelés!");
                }
            }
            catch (IOException ex)
            {
                //IO esetén mindig kell
                Console.WriteLine("Hiba" + ex.ToString());
            }

            List<Pont> list = new List<Pont>()
            {

                new Pont
                {

                    X = 2,
                    Y = 3,
                    Name = "Foo"

                },
                new Pont
                {

                    X = 4,
                    Y = 8,
                    Name = "Oof"

                },
                new Pont
                {

                    X = 42,
                    Y = 42,
                    Name = "ASd"

                }

            };

            try
            {
                string jsonEncoded = JsonSerializer.Serialize(list, new JsonSerializerOptions
                { 
                    WriteIndented = true,
                });
                File.WriteAllText(@"U:\jsonExample.json", jsonEncoded);

                string vissza = File.ReadAllText(@"U:\jsonExample.json");
                List<Pont> pVissza = JsonSerializer.Deserialize<List<Pont>>(vissza);
            }
            catch (Exception ex) when ( ex is IOException || ex is JsonException)
            {

                Console.WriteLine(ex.ToString());
            }

            XmlSerializer xs = new XmlSerializer(typeof(List<Pont>));
            using (var f = File.Create(@"U:\xmlExample.xml"))
            {
                xs.Serialize(f, list);
            }

            using (var f = File.OpenRead(@"U:\xmlExample.xml"))
            {
                List<Pont> vissza = xs.Deserialize(f) as List<Pont>;
            }
        }
    }
}
