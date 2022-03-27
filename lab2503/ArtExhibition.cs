using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2503
{
    [System.Xml.Serialization.XmlRoot("ArtExhibition")]
    public class ArtExhibition
    {
        [System.Xml.Serialization.XmlElement("critics")]
        public Critics Сritics { get; set; }
        [System.Xml.Serialization.XmlElement("artists")]
        public Artists Artists { get; set; }
        [System.Xml.Serialization.XmlElement("styles")]
        public Styles Styles { get; set; }
    } 
    public class Critics
    {
        [System.Xml.Serialization.XmlElement("critic")]
        public Critic[]  CriticsArr { get; set; } 
    }
    public class Critic
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlElement("cfalification", Namespace = "")]
        public string Cfalification { get; set; }
        [System.Xml.Serialization.XmlElement("countReview", Namespace = "")]
        public int CountReview { get; set; }
        [System.Xml.Serialization.XmlElement("education", Namespace = "")]
        public Education Education { get; set; }
        [System.Xml.Serialization.XmlElement("information", Namespace = "")]
       public CriticInformation Information { get; set; }
    }
    public class Information
    {
        public override string ToString()
        {
            return age + " " + familyStatus;
        }
        [System.Xml.Serialization.XmlElement("age", Namespace = "")]
        public string age { get; set; }
        [System.Xml.Serialization.XmlElement("familyStatus", Namespace = "")]
        public string familyStatus { get; set; }

    }
    public class CriticInformation : Information
    {

    }
    public class ArtistInformation : Information
    {
        public override string ToString()
        {
            return ProduceTime +" "+ age+" "+ familyStatus;
        }
        [System.Xml.Serialization.XmlElement("produceTime", Namespace = "")]
        public int ProduceTime { get; set; }

    }
    public class Education
    {
        public override string ToString()
        {
            return School.ToString()+Institute.ToString();            
        }

        [System.Xml.Serialization.XmlElement("school", Namespace = "")]
        public School School { get; set; }
        
        [System.Xml.Serialization.XmlElement("institute", Namespace = "")]
        
        public Institute Institute { get; set; }
    }
    public class Study
    {
        
        [System.Xml.Serialization.XmlAttribute("code", Namespace = "")]
        public int code { get; set; }
        [System.Xml.Serialization.XmlAttribute("country", Namespace = "")]
        public string country { get; set; }
        [System.Xml.Serialization.XmlAttribute("city", Namespace = "")]
        public string city { get; set; }
    }
    public class School : Study
    {
        public override string ToString()
        {
            return code + " " + country + " " + city;
        }
    }
    public class Institute : Study
    {
        public override string ToString()
        {
            return code + " " + country + " " + city;
        }
    }
    public class Artists
    {
        [System.Xml.Serialization.XmlElement("artist")]
        public Artist[] ArtistsArr { get; set; }
    }
    public class Artist
    {
        [System.Xml.Serialization.XmlAttribute("queue", Namespace = "")]
        public int queue { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string name { get; set; }
        [System.Xml.Serialization.XmlElement("information", Namespace = "")]
        public ArtistInformation artistInformation { get; set; }
        [System.Xml.Serialization.XmlElement("style", Namespace = "")]
        public int style { get; set; }
    }
    public class Styles
    {
        [System.Xml.Serialization.XmlElement("style")]
        public Style[] StylessArr { get; set; }
    }
    public class Style
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int id { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string name { get; set; }
        [System.Xml.Serialization.XmlElement("description", Namespace = "")]
        public Description Description { get; set; }
        [System.Xml.Serialization.XmlElement("tools", Namespace = "")]
        public Tools Tools { get; set; }
    }
    public class Description
    {
        public override string ToString()
        {
            return drawing + " " + genre;
        }
        [System.Xml.Serialization.XmlElement("drawing", Namespace = "")]
        public string drawing { get; set; }
        [System.Xml.Serialization.XmlElement("genre", Namespace = "")]
        public string genre { get; set; }
    }
    public class Tools
    {
        public override string ToString()
        {
            return  "Place:" +place +" " +"Material:"+" " + material;
        }
        [System.Xml.Serialization.XmlElement("place", Namespace = "")]
        public string place { get; set; }
        [System.Xml.Serialization.XmlElement("material", Namespace = "")]
        public string material { get; set; }
    }
}
