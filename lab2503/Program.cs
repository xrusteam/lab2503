using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace lab2503
{
    static class Program
    {
        public static ArtExhibition art = new ArtExhibition();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        
        [STAThread]
        
        static void Main()
        {
            LoadXml();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
        public static void LoadXml()
        {
            string Path = @"C:\Users\User\source\repos\lab2503\lab2503\xdata.xml";
            XmlDocument document = new XmlDocument();
            document.Load(Path);
            if (!File.Exists(Path))
            {
                return;
            }
            try
            {
                MemoryStream rawData = new MemoryStream(File.ReadAllBytes(Path));
                XmlSerializer xml = new XmlSerializer(typeof(ArtExhibition));
                art = (ArtExhibition)xml.Deserialize(rawData);
            }
            catch (Exception ex)
            {

            }



        }




    }
}

