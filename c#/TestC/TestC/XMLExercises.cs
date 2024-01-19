using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestC
{
    public class XMLExercises
    {
        // Ejemplo para leer multoples datos en XML
        public void LeerDatosXML()
        {
            try
            {
                // Ruta del archivo XML
                string filePath = "datos.xml";

                // Crear una instancia de XmlDocument
                XmlDocument xmlDoc = new XmlDocument();

                // Cargar el archivo XML
                xmlDoc.Load(filePath);

                // Obtener la lista de nodos de personas
                XmlNodeList personasList = xmlDoc.SelectNodes("//persona");

                // Recorrer cada nodo de persona y mostrar los datos
                foreach (XmlNode personaNode in personasList)
                {
                    string nombre = personaNode.SelectSingleNode("nombre").InnerText;
                    string edad = personaNode.SelectSingleNode("edad").InnerText;
                    string ciudad = personaNode.SelectSingleNode("ciudad").InnerText;

                    Console.WriteLine($"Persona: {nombre}, Edad: {edad}, Ciudad: {ciudad}");
                }

                // Obtener la lista de nodos de libros
                XmlNodeList librosList = xmlDoc.SelectNodes("//libro");

                // Recorrer cada nodo de libro y mostrar los datos
                foreach (XmlNode libroNode in librosList)
                {
                    string titulo = libroNode.SelectSingleNode("titulo").InnerText;
                    string autor = libroNode.SelectSingleNode("autor").InnerText;
                    string publicacion = libroNode.SelectSingleNode("publicacion").InnerText;

                    Console.WriteLine($"Libro: {titulo}, Autor: {autor}, Publicación: {publicacion}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo XML: " + ex.Message);
            }
        }
        // Ejemplo para contar ocurrencias de datos
        public void ContarDatosXML()
        {
            try
            {
                // Ruta del archivo XML
                string filePath = "datos.xml";

                // Crear una instancia de XmlDocument
                XmlDocument xmlDoc = new XmlDocument();

                // Cargar el archivo XML
                xmlDoc.Load(filePath);

                // Contar las ocurrencias de personas
                int totalPersonas = xmlDoc.SelectNodes("//persona").Count;

                Console.WriteLine($"Número total de personas: {totalPersonas}");

                // Contar las ocurrencias de libros
                int totalLibros = xmlDoc.SelectNodes("//libro").Count;

                Console.WriteLine($"Número total de libros: {totalLibros}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo XML: " + ex.Message);
            }
        }
        // Ejemplo para leer una sola etiqueta
        public void LeerEtiquetaXML()
        {
            try
            {
                // Ruta del archivo XML
                string filePath = "datos.xml";

                // Crear una instancia de XmlDocument
                XmlDocument xmlDoc = new XmlDocument();

                // Cargar el archivo XML
                xmlDoc.Load(filePath);

                // Seleccionar el nodo de la primera persona y obtener el contenido de la etiqueta <nombre>
                XmlNode nombreNode = xmlDoc.SelectSingleNode("//persona[1]/nombre");

                if (nombreNode != null)
                {
                    string nombre = nombreNode.InnerText;
                    Console.WriteLine($"Contenido de la etiqueta <nombre>: {nombre}");
                }
                else
                {
                    Console.WriteLine("La etiqueta <nombre> no se encontró en el archivo XML.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo XML: " + ex.Message);
            }
        }
    }

}
