using System;
using System.Collections.Generic;
using System.Xml;


namespace RobotManager
{
    public static class RobotStorage
    {
        private const string Path = @"..\..\RobotStorageList.xml";

        public static List<robot> GetRobots()
        {
            // create the list
            List<robot> robots = new List<robot>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // read past all nodes to the first Book node
            if (xmlIn.ReadToDescendant("robot"))
            {
                // create one Product object for each Product node
                do
                {
                    robot robot = new robot();
                    xmlIn.ReadStartElement("robot");
                    robot.RobotID = xmlIn.ReadElementContentAsInt();
                    robot.Company = xmlIn.ReadElementContentAsString();
                    robot.Sector = xmlIn.ReadElementContentAsString();
                    robot.Model = xmlIn.ReadElementContentAsString();
                    robot.Arms = xmlIn.ReadElementContentAsInt();
                    robot.Mobility = xmlIn.ReadElementContentAsString();
                    robot.Legs = xmlIn.ReadElementContentAsString();
                    robot.Vision = xmlIn.ReadElementContentAsString();
                    robot.Hearing = xmlIn.ReadElementContentAsString();
                    robot.Intelligence = xmlIn.ReadElementContentAsString();
                    robot.Specialty = xmlIn.ReadElementContentAsString();
                    robot.Quantity = xmlIn.ReadElementContentAsInt();
                    robot.Price = xmlIn.ReadElementContentAsDecimal();
                    xmlIn.ReadEndElement();

                    robots.Add(robot);
                }
                while (xmlIn.ReadToNextSibling("robot"));
            }

            // close the XmlReader object
            xmlIn.Close();

            return robots;
        }

        public static void SaveRobots(List<robot> robots)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = (" ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Robots");

            // write each product object to the xml file
            foreach (robot robot in robots)
            {
                xmlOut.WriteStartElement("robot");
                xmlOut.WriteElementString("RobotID", Convert.ToString(robot.RobotID));
                xmlOut.WriteElementString("Company", robot.Company);
                xmlOut.WriteElementString("Sector", robot.Sector);
                xmlOut.WriteElementString("Model", robot.Model);
                xmlOut.WriteElementString("Arms", Convert.ToString(robot.Arms));
                xmlOut.WriteElementString("Mobility", robot.Mobility);
                xmlOut.WriteElementString("Legs", robot.Legs);
                xmlOut.WriteElementString("Vision", robot.Vision);
                xmlOut.WriteElementString("Hearing", robot.Hearing);
                xmlOut.WriteElementString("Intelligence", robot.Intelligence);
                xmlOut.WriteElementString("Specialty", robot.Specialty);
                xmlOut.WriteElementString("Quantity", Convert.ToString(robot.Quantity));
                xmlOut.WriteElementString("Price", Convert.ToString(robot.Price));
                xmlOut.WriteEndElement();
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }
    }
}