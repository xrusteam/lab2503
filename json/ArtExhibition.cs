using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;



namespace json
{
    [Serializable()]
    public class ArtExhibition
    {
        [XmlElement]
        public List<Critic> Critics { get; set; }
        [XmlElement]
        public List<Artist> Artists { get; set; }
        [XmlElement]
        public List<Style> Styles { get; set; }



        public ArtExhibition(List<Critic> critics, List<Artist> artists, List<Style> styles)
        {

            Critics = critics;
            Artists = artists;
            Styles = styles;
        }
        public ArtExhibition()
        {

        }
        [Serializable()]
        public class Critic
        {
            public string Name { get; set; }
            public string Cfalification { get; set; }
            public string CountReview { get; set; }
           
            public int Id { get; set; }
            public Education Education { get; set; }
            public CriticInformation Information { get; set; }
            public Critic(int id, string name, string countReview, string cfalification)
            {
                Id = id;
                Name = name;
                CountReview = countReview;
                Cfalification = cfalification;
                

            }
            public Critic()
            {

            }
        }
        public class Education
        {
            public School School { get; set; }
            public Institute Institute { get; set; }
        }
        public class Information
        {
            public string Age { get; set; }
            public string FamilyStatus { get; set; }
        }
        public class CriticInformation : Information
        {

        }
        public class Study
        {

        
         public int code { get; set; }
            
            public string country { get; set; }
            
            public string city { get; set; }
        }
        public class School : Study
        {

        }
        public class Institute : Study
        {

        }
        public class Artist
        {
            public int Queue { get; set; }
            public string Name { get; set; }
            public int Style { get; set; }
            public ArtistInformation artistinformation { get; set; }
        }
        public class ArtistInformation:Information 
        {
            public int ProduceTime { get; set; }
        }
        public class Style
        {
            
            public int id { get; set; }
            
            public string name { get; set; }
           
            public Description Description { get; set; }
            
            public Tools Tools { get; set; }
        }
        public class Description
        {
            public string drawing { get; set; }
           
            public string genre { get; set; }
        }
        public class Tools
        {
            
            public string place { get; set; }
            
            public string material { get; set; }
        }
    }
}
