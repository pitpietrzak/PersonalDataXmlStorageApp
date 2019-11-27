using PersonalDataXmlStorageApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PersonalDataXmlStorageApp.Services
{
    public class FileService
    {
        private readonly string _fileName =
            $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Persons.xml";

        private void AddPerson(Person person)
        {
            var doc = XDocument.Load(_fileName);
            var element = new XElement("Person");
            element.Add(new XElement("Id", person.Id));
            element.Add(new XElement("FirstName", person.FirstName));
            element.Add(new XElement("LastName", person.LastName));
            element.Add(new XElement("StreetName", person.StreetName));
            element.Add(new XElement("HouseNumber", person.HouseNumber));
            if (!string.IsNullOrEmpty(person.ApartmentNumber))
            {
                element.Add(new XElement("ApartmentNumber", person.ApartmentNumber));
            }
            element.Add(new XElement("PostalCode", person.PostalCode));
            element.Add(new XElement("Town", person.Town));
            element.Add(new XElement("PhoneNumber", person.PhoneNumber));
            element.Add(new XElement("DateOfBirth", person.DateOfBirth));


            doc.Element("ArrayOfPerson")?.Add(element);
            doc.Save(_fileName);

            person.IsDirty = false;
            person.IsNew = false;
        }

        private void EditPerson(Person person)
        {
            var xml = new XmlDocument();
            xml.Load(_fileName);

            foreach (XmlElement element in xml.SelectNodes("//Person"))
            {
                if (element.SelectSingleNode("Id")?.InnerText != Convert.ToString(person.Id)) continue;
                {
                    element.SelectSingleNode("FirstName").InnerText = person.FirstName;
                    element.SelectSingleNode("LastName").InnerText = person.LastName;
                    element.SelectSingleNode("StreetName").InnerText = person.StreetName;
                    element.SelectSingleNode("HouseNumber").InnerText = person.HouseNumber;
                    if (string.IsNullOrEmpty(person.ApartmentNumber))
                    {
                        if (element.SelectSingleNode("ApartmentNumber") != null)
                        {
                            element.RemoveChild(element.SelectSingleNode("ApartmentNumber"));
                        }
                    }
                    else
                    {
                        if (element.SelectSingleNode("ApartmentNumber") != null)
                        {
                            element.SelectSingleNode("ApartmentNumber").InnerText = person.ApartmentNumber;
                        }
                        else
                        {
                            XmlNode xApartment = xml.CreateElement("ApartmentNumber");
                            xApartment.InnerText = person.ApartmentNumber;
                            element.AppendChild(xApartment);
                        }
                    }
                    element.SelectSingleNode("PostalCode").InnerText = person.PostalCode;
                    element.SelectSingleNode("PhoneNumber").InnerText = person.PhoneNumber;
                    element.SelectSingleNode("DateOfBirth").InnerText = person.DateOfBirth;

                    xml.Save(_fileName);
                    return;
                }
            }
        }

        private void DeletePerson(Person person)
        {
            XDocument xmlDoc = XDocument.Load(_fileName);
            var connectionToDelete = (from xml2 in xmlDoc.Descendants("Person")
                where xml2.Element("Id")?.Value == person.Id.ToString()
                select xml2).FirstOrDefault();

            connectionToDelete?.Remove();
            xmlDoc.Save(_fileName);
        }

        private void SetIds(IEnumerable<Person> persons, int maxId)
        {
            foreach (var person in persons)
            {
                maxId++;
                person.Id = maxId;
            }
        }

        internal void CreateNewFile()
        {
            try
            {
                using (var writer = new StreamWriter(_fileName))
                {
                    var serializer = new XmlSerializer(typeof(List<Person>));
                    serializer.Serialize(writer, new List<Person>());
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        internal List<Person> GetDataFromFile()
        {
            try
            {
                using (var stream = new StreamReader(_fileName))
                {
                    var serializer = new XmlSerializer(typeof(List<Person>));
                    var persons = (List<Person>)serializer.Deserialize(stream);

                    foreach (var person in persons)
                    {
                        person.IsDirty = false;
                        person.IsNew = false;
                        person.IsDeleted = false;
                    }

                    return persons;
                }
            }

            catch (FileNotFoundException)
            {
                CreateNewFile();
                return new List<Person>();
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        internal void SaveDataToFile(List<Person> data, List<Person> toDelete)
        {
            try
            {
                foreach (var person in toDelete)
                {
                    DeletePerson(person);
                }

                foreach (var person in data.Where(x=>x.IsDirty && !x.IsNew))
                {
                    EditPerson(person);
                }
                var newPersons = data.Where(x => x.IsNew).ToList();
                if (!newPersons.Any()) return;
                
                SetIds(data.Where(x => x.IsNew), data.Max(x=>x.Id));
                foreach (var person in newPersons)
                {
                    AddPerson(person);
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    } 
}
