//directivas de procesamiento en un documento XML en C#. 
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Ruta del archivo XML
        string xmlFilePath = "ruta_del_archivo.xml";

        try
        {
            // Cargar el documento XML
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            // Obtener la directiva de procesamiento XML
            XmlProcessingInstruction xmlDeclaration = xmlDoc.SelectSingleNode("//processing-instruction('xml')") as XmlProcessingInstruction;

            if (xmlDeclaration != null)
            {
                Console.WriteLine($"Versión XML: {xmlDeclaration.Data}");
            }
            else
            {
                Console.WriteLine("No se encontró la directiva de procesamiento XML.");
            }

            // Obtener la directiva de hoja de estilo XML (si existe)
            XmlProcessingInstruction stylesheet = xmlDoc.SelectSingleNode("//processing-instruction('xml-stylesheet')") as XmlProcessingInstruction;

            if (stylesheet != null)
            {
                Console.WriteLine($"Hoja de estilo: {stylesheet.Data}");
            }
            else
            {
                Console.WriteLine("No se encontró la directiva de hoja de estilo XML.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
