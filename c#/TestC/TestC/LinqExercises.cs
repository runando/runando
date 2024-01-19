using System;
using System.Linq;
using System.Xml;

class LinqExercises
{
    public static void LinqExercise1()
    {
        //  The first part is Data source.
        int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine("\nBasic structure of LINQ : ");
        Console.WriteLine("\n---------------------------");

        // The second part is Query creation.
        // nQuery is an IEnumerable<int>
        var nQuery =
            from VrNum in n1
            where (VrNum % 2) == 0
            select VrNum;

        // The third part is Query execution.

        Console.WriteLine("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
        foreach (int VrNum in nQuery)
        {
            Console.Write("{0} ", VrNum);
        }
        Console.WriteLine("\n\n");
    }
    public static void LinqExercise2()
    {
        int[] n1 = {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            };

        Console.Write("\nLINQ : Using multiple WHERE clause to find the positive numbers within the list : ");
        Console.Write("\n-----------------------------------------------------------------------------");

        var nQuery =
        from VrNum in n1
        where VrNum > 0
        where VrNum < 12
        select VrNum;
        Console.Write("\nThe numbers within the range of 1 to 11 are : \n");
        var test = from x in n1 
                   group x by x into y 
                   select y;
        foreach (var VrNum in test)
        {
            Console.WriteLine(VrNum.Key + "\t" + VrNum.Sum() + "\t\t\t" + VrNum.Count());
        }
        Console.Write("\n\n");
    }
    public static void LinqExercise3()
    {
        int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

        Console.Write("\nLINQ : Display numbers, number*frequency and frequency : ");
        Console.Write("\n-------------------------------------------------------\n");
        Console.Write("The numbers in the array are : \n");
        Console.Write("5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 \n\n");


        var m = from x in nums
                group x by x into y
                select y;
        Console.Write("Number" + "\t" + "Number*Frequency" + "\t" + "Frequency" + "\n");
        Console.Write("------------------------------------------------\n");

        foreach (var arrEle in m)
        {
            Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
        }
        Console.WriteLine();
    }
    public static void LinqExercise4()
    {
        int[] num = new int[7] { 55, 200, 740, 76, 230, 482, 95 };
        var numeros = from x in num
                      where x > 80
                      orderby x ascending
                      select x;
        foreach(var numer in numeros)
        {
            Console.WriteLine(numer);
        }
    }

    public static void LinqExercise5()
    {
        string input = string.Empty;
        Console.WriteLine("Entrada");
        input = Console.ReadLine();
        var upWord = input.Split(' ').Where(x => string.Equals(x, x.ToUpper(),
            StringComparison.Ordinal));
    }
    public static void XMLReadExercise1()
    {
        // Replace "yourXmlFilePath.xml" with the path to your XML file
        string xmlFilePath = "yourXmlFilePath.xml";

        try
        {
            // Create a new XmlDocument
            XmlDocument xmlDoc = new XmlDocument();

            // Load the XML file
            xmlDoc.Load(xmlFilePath);

            // Process the XML data
            ProcessXml(xmlDoc);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    public static void ProcessXml(XmlDocument xmlDoc)
    {
        // Access XML elements and attributes as needed
        XmlNodeList nodeList = xmlDoc.SelectNodes("//yourElementName");

        if (nodeList != null)
        {
            foreach (XmlNode node in nodeList)
            {
                // Access node data as needed
                string value = node.InnerText;
                Console.WriteLine($"Node Value: {value}");

                // Access attributes if any
                XmlAttribute attribute = node.Attributes["yourAttributeName"];
                if (attribute != null)
                {
                    string attributeValue = attribute.Value;
                    Console.WriteLine($"Attribute Value: {attributeValue}");
                }
            }
        }
    }
}   
