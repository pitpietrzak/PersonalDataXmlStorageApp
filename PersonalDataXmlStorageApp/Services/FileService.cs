using PersonalDataXmlStorageApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PersonalDataXmlStorageApp.Services
{
    public class FileService
    {
        private const string _fileName = @"PersonalData.xml";

        private void CreateNewFile()
        {
            try
            {
                using (var writer = new StreamWriter($@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\{_fileName}"))
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

        internal List<Person> GetPersonsFromFile()
        {
            try
            {
                using (var stream = new StreamReader($@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\{_fileName}"))
                {
                    var serializer = new XmlSerializer(typeof(List<Person>));
                    var persons = (List<Person>)serializer.Deserialize(stream);

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
    }
}
