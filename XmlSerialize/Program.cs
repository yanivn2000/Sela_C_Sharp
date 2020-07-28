using System;
using System.Collections;
using System.IO;
using System.Xml.Serialization;

/* There was an error reflecting type:
 * 
 - the object being serialized has no parameterless constructor
 - the object contains Dictionary
 - the object has some public Interface members
 */
namespace XmlSerialize
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private void LoadManagerMoney()        {            XmlSerializer ser = new XmlSerializer(typeof(double));//creat which type we get when we open the file
            FileStream stream = new FileStream($@"{ApplicationData.Current.LocalFolder.Path}\MyFile3.xml", FileMode.Open);//save which file we are going to open
            _moneyManager = (double)ser.Deserialize(stream);//open file and save it
            stream.Close();        }        private void SaveMoneyManager()        {            XmlSerializer ser = new XmlSerializer(typeof(double));//create that the file will money
            FileStream stream = new FileStream($@"{ApplicationData.Current.LocalFolder.Path}\MyFile3.xml", FileMode.Create);//build or open this file
            ser.Serialize(stream, _moneyManager);//add list to the infromation in the file
            stream.Close(); //close files
        } 
    }
}
