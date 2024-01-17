using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Ruta del archivo XML
        string xmlFilePath = "ruta_del_archivo.xml";

        // Etiqueta que deseas buscar
        string etiquetaABuscar = "nombre_de_la_etiqueta";

        try
        {
            // Cargar el documento XML
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            // Buscar la etiqueta en el documento
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName(etiquetaABuscar);

            // Mostrar los resultados
            if (nodeList.Count > 0)
            {
                Console.WriteLine($"Se encontraron {nodeList.Count} ocurrencias de la etiqueta '{etiquetaABuscar}':");

                foreach (XmlNode node in nodeList)
                {
                    Console.WriteLine(node.OuterXml);
                }
            }
            else
            {
                Console.WriteLine($"No se encontraron ocurrencias de la etiqueta '{etiquetaABuscar}'.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
