LEER UN XML DESDE URL

using System;
using System.xml;

namespace LeerXML
{
	class Program
	{
		static void Main(string [] args)
		{
			//ruta del archivo
			String Urlruta = "http://localhost/ejemplo.xml";
			
			//cargar el archivo
			XmlTextReader reader = new XmlTextReader(Urlruta);
			
			//leer el archivo xml
			while(reader.Read())
			{
				switch (reader.NodeType)
				{
					case XmlNodeType.Element: //nodo raiz
						Console.Write("<" + reader.Name);
						while (reader.MoveToNextAttibutte()) //atributos
							Console.Write( " " + reaer.Name + "= '" + reader.Value + "'");
							Console.Write(">");
							Console.WriteLine(">");
							break;
					case XmlNodeType.Text: //texto de cada elemento
						Console.WriteLine(reader.Value);
						break;
					case XmlNodeType.EndElement: //fin del elemento
						Console.Write("<" + reader.Name);
						Console.WriteLine(">");
						break;
				}
			}
		}
	}
}

