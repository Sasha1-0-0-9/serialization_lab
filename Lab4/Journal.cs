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
    public class Journal: IXmlSerializable
    {
        private string _name;

        private Periodicity? _periodicity = null;

        private List<Article> _articles = new List<Article>();

        private int totalPagesNumber = 0;

        private int authorsNumber = 0;


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public Periodicity? JournalPeriodicity
        {
            get
            {
                return _periodicity;
            }
            set
            {
                _periodicity = value;
            }            
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
            set
            {
                _articles = value;
                CalculatePagesAndAuthors();
            }           
        }

        public int TotalPagesNumber
        {
            get
            {
                return totalPagesNumber;
            }
            set
            {
                totalPagesNumber = value;
            }
        }

        public void AddArticle(Article article)
        {
            // we can set null by List<Article> Articles setter
            if (_articles == null)
            {
                _articles = new List<Article>();
            }
            _articles.Add(article);
            totalPagesNumber += article.PagesNumber;
            authorsNumber++;
        }

        public void CalculatePagesAndAuthors()
        {           
            totalPagesNumber = 0;
            authorsNumber = 0;
            if (_articles != null)
            {
                _articles.ForEach(article =>
                {
                    totalPagesNumber += article.PagesNumber;
                });
                authorsNumber = _articles.Count;
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
                        case "Name":
                            reader.Read();
                            _name = reader.Value;
                            break;

                        case "Periodicity":
                            reader.Read();
                            _periodicity = (Periodicity)Enum.Parse(typeof(Periodicity), reader.Value);
                            break;

                        case "Articles":                           
                            _articles = Article.ReadArticles(reader);
                            CalculatePagesAndAuthors();
                            break;
                    }
                }
                if (reader.Name.Equals("Journal"))
                {
                    break;
                }
            }            
        }

        public static List<Journal> ReadJournalList(string fileName)
        {
            List<Journal> journals = new List<Journal>();
            if(File.Exists(fileName))
            {
                using (XmlReader reader = XmlReader.Create(fileName))
                {
                    reader.MoveToContent();
                    while (reader.Read())
                    {
                        if (reader.IsStartElement() && !reader.Name.Equals("Journals"))
                        {
                            Journal journal = new Journal();
                            journal.ReadXml(reader);
                            journals.Add(journal);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }                          
            return journals;
        }
      
        public void WriteXml(XmlWriter writer)
        { 
            writer.WriteStartElement("Journal");
            writer.WriteElementString("Name", _name);
            writer.WriteElementString("Periodicity", _periodicity.ToString());
            writer.WriteStartElement("Articles");
            if(Articles != null)
            {
                Articles.ForEach(article =>
                {
                    article.WriteXml(writer);
                });
            }          
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        public static  void WriteJournalsToFile(string fileName, List<Journal> journals)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = false;
            settings.NewLineOnAttributes = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            XmlWriter xmlWriter = XmlWriter.Create(fileName, settings);
            xmlWriter.WriteStartElement("Journals");
            journals.ForEach(journal =>
            {
                journal.WriteXml(xmlWriter);
            });
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
        }

        public override string ToString()
        {
            return $"Name: {_name}\nTotal pages number: {totalPagesNumber}\nAuthors number: {authorsNumber}\nPeriodicity: {Enum.GetName(typeof(Periodicity), _periodicity)}";
        }

        public  string ToShortString()
        {
            return $"Name: {_name} Total pages number: {totalPagesNumber}";
        }

    }
}
