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

namespace Lab4
{
    public class Article : IXmlSerializable
    {
        private Author _articleAuthor;

        private string _title;

        private int _pagesNumber = 0;

        private double _honorarium = 0;
     
        public Author ArticleAuthor
        {
            get
            {
                return _articleAuthor;
            }
            set
            {
                _articleAuthor = value;
            }               
        }

        public string Title
        {
            get
            {
               return _title;
            }
            set
            {
                _title = value;
            }
        }

        public int PagesNumber
        {
            get
            {
                return _pagesNumber;
            }
            set
            {
                _pagesNumber = value;
            }                
        }

        public double Honorarium
        {
            get
            {
                return _honorarium;
            }
            set
            {
                _honorarium = value;
            }
        }
       
        public XmlSchema GetSchema()
        {
            return null;
        }
        
        public void ReadXml(XmlReader reader)
        {                      
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "Author":
                            _articleAuthor = new Author();
                            _articleAuthor.ReadXml(reader);
                            break;

                        case "Title":
                            reader.Read();
                            _title = reader.Value;
                            break;

                        case "Honorarium":
                            reader.Read();
                            _honorarium = Double.Parse(reader.Value);
                            break;

                        case "PagesNumber":
                            reader.Read();
                            _pagesNumber = Int32.Parse(reader.Value);
                            break;
                    }
                }

                if (reader.Name.Equals("Article"))
                {
                    break;
                }
            }           
        }
       
        public  void WriteXml(XmlWriter writer)
        {
           writer.WriteStartElement("Article");
              _articleAuthor.WriteXml(writer);
               writer.WriteElementString("Title", _title);
               writer.WriteElementString("PagesNumber", _pagesNumber.ToString());
               writer.WriteElementString("Honorarium", _honorarium.ToString());          
           writer.WriteEndElement();
        }

        public static List<Article> ReadArticles(XmlReader reader)
        {
            List<Article> articles = new List<Article>();
            reader.MoveToContent();
            while (reader.Read())
            {
                if (reader.IsStartElement() && !reader.Name.Equals("Articles"))
                {
                    Article article = new Article();
                    article.ReadXml(reader);
                    articles.Add(article);
                }
                else
                {
                    break;
                }
                    
            }
            return articles;            
        }

        public override string ToString()
        {
            return $"{_articleAuthor} {_title} {_pagesNumber} {_honorarium}";
        }
    }
}
