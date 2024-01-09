LEER UN ARCHIVO XML LLAMADO "EJEMPLO.XML"

using System;
using System.Xml;
namespace LeerXml
{
	class Program
	{
		static void Main()
		{
			try
			{
				// Ruta del archivo XML
				string rutaArchivoXml = "ejemplo.xml";

				// Crear un objeto XmlDocument
				XmlDocument xmlDoc = new XmlDocument();

				// Cargar el archivo XML
				xmlDoc.Load(rutaArchivoXml);

				// Mostrar la información del archivo XML
				MostrarInformacion(xmlDoc);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}

		static void MostrarInformacion(XmlDocument xmlDoc)
		{
			// Obtener el nodo raíz
			XmlNode rootNode = xmlDoc.DocumentElement;

			// Mostrar información del nodo raíz
			Console.WriteLine($"Nodo raíz: {rootNode.Name}");

			// Mostrar información de los nodos hijos
			foreach (XmlNode node in rootNode.ChildNodes)
			{
				if (node.NodeType == XmlNodeType.Element)
				{
					Console.WriteLine($"Nombre del nodo: {node.Name}");

					if (node.HasChildNodes)
					{
						Console.WriteLine($"Contenido del nodo: {node.InnerText}");
					}
				}
			}
		}
	}
}