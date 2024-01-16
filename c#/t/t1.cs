using System;
using System.Xml;
//En c#, como contar en un xml contar las ocurrencias de un valor
class Program
{
    static void Main()
    {
        // Ruta del archivo XML
        string xmlFilePath = "ruta_del_archivo.xml";

        // Valor que deseas contar
        string valorAContar = "tu_valor";

        // Cargar el documento XML
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(xmlFilePath);

        // Contar las ocurrencias del valor en todo el documento
        int contador = ContarOcurrencias(xmlDoc, valorAContar);

        // Mostrar el resultado
        Console.WriteLine($"El valor '{valorAContar}' aparece {contador} veces en el documento XML.");
    }

    static int ContarOcurrencias(XmlDocument xmlDoc, string valor)
    {
        int contador = 0;

        // Obtener todos los elementos en el documento
        XmlNodeList nodeList = xmlDoc.SelectNodes($"//*[text()='{valor}']");

        // Contar las ocurrencias
        if (nodeList != null)
        {
            contador = nodeList.Count;
        }

        return contador;
    }
}
