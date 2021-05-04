using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Lab4
{
    public class Author : IXmlSerializable
    {
        private string _firstName;

        private string _lastName;

        private DateTime _birthday;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            } 
        }

        public DateTime Birthday {
            get
            {
                return _birthday;
            }
            set
            {
                _birthday = value;
            }
        }      

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();           
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "FirstName":
                            reader.Read();
                            _firstName = reader.Value;
                            break;

                        case "LastName":
                            reader.Read();
                           _lastName = reader.Value;
                            break;

                        case "Birthday":
                            reader.Read();
                           _birthday = DateTime.Parse(reader.Value);
                            break;
                    }
                }
                if (reader.Name.Equals("Author"))
                {
                    break;
                }               
            }
        }

        public static List<Author> ReadAuthorsList(string fileName)
        {
            List<Author> authors = new List<Author>();
            if (File.Exists(fileName))
            {
                using (XmlReader reader = XmlReader.Create(fileName))
                {
                    //jump from root tag
                    reader.MoveToContent();
                    while (reader.Read())
                    {
                        //if we reach closed tag @articles@ we can make stop
                        if (reader.IsStartElement() && !reader.Name.Equals("Authors"))
                        {
                            Author author = new Author();
                            author.ReadXml(reader);
                            authors.Add(author);
                        }
                        else
                        {
                            break;
                        }
                    }
                }               
            }
            return authors;
        }
       
        public void WriteXml(XmlWriter writer)
        {          
            writer.WriteStartElement("Author");
            writer.WriteElementString("FirstName", _firstName);
            writer.WriteElementString("LastName", _lastName);
            writer.WriteElementString("Birthday", _birthday.ToString());           
            writer.WriteEndElement();
        }

        public static void WriteAuthorsToFile(string fileName,List<Author> authors)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = false;
            settings.NewLineOnAttributes = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            XmlWriter xmlWriter = XmlWriter.Create(fileName, settings);
            xmlWriter.WriteStartElement("Authors");
            authors.ForEach(author =>
            {
                author.WriteXml(xmlWriter);
            });
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} {_birthday.Date.ToString("dd/MM/yyyy")}";
        }
    }
}
