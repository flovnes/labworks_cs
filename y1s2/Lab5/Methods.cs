using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace Lab5
{
  public partial class Program {

    private static readonly Dictionary<Type, XmlSerializer> xmlOptions = [];

    private static readonly JsonSerializerOptions jsonOptions = new(JsonSerializerDefaults.General);
    static List<T> EnterObjects<T>() where T : struct, IComparable<T>
    {
      List<T> objects = [];
      Console.Write($"Enter number of objects you want to add: ");
      int n = int.Parse(Console.ReadLine());
      Console.WriteLine($"Example input format: <field1> <field2> <field3>");

      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"Enter object {i}:");
        Console.Write($"{i + 1}) ");
        objects.Add(AutoInput<T>(Console.ReadLine()));
      }

      objects.Sort();
      return objects;
    }

    static T AutoInput<T>(string input) where T : struct, IComparable<T>
    {
      var constructor = typeof(T).GetConstructor([typeof(string)]);
      return (T)constructor.Invoke([input]);
    }

    static void WriteIntoTxt<T>(List<T> objects, string filename) where T : struct, IComparable<T>
    {
      using (StreamWriter sw = new(filename))
      {
        foreach (var obj in objects)
          sw.WriteLine(obj.ToString());
      }
      Console.WriteLine("Done!");
    }

    static List<T> ReadFromTxt<T>(string filename) where T : struct, IComparable<T>
    {
      List<T> objects = [];
      try
      {
        StreamReader reader = new(filename);
        string line;
        while ((line = reader.ReadLine()) != null)
        {
          objects.Add(AutoInput<T>(line));
        }
      }
      catch (IOException e)
      {
        Console.WriteLine($"Error: {e.Message}");
      }

      Console.WriteLine($"Objects read from TXT:");
      foreach (var obj in objects)
      {
        Console.WriteLine(obj);
      }

      return objects;
    }

    static void SerializeIntoXml<T>(List<T> objects, string filename) where T : struct, IComparable<T>
    {
      Type listType = typeof(List<T>);
      XmlSerializer serializer;

      lock (xmlOptions)
      {
        if (!xmlOptions.TryGetValue(listType, out serializer))
        {
          serializer = new XmlSerializer(listType);
          xmlOptions.Add(listType, serializer);
        }
      }

      using (TextWriter writer = new StreamWriter(filename))
      {
        serializer.Serialize(writer, objects);
      }

      Console.WriteLine("Done!");
    }

    static List<T> DeserializeFromXml<T>(string filename) where T : struct, IComparable<T>
    {
      Type arrayType = typeof(T[]);
      XmlSerializer serializer;

      lock (xmlOptions)
      {
        if (!xmlOptions.TryGetValue(arrayType, out serializer))
        {
          serializer = new XmlSerializer(arrayType);
          xmlOptions.Add(arrayType, serializer);
        }
      }

      using FileStream fileStream = new(filename, FileMode.Open);
      var deserializedObjects = (T[])serializer.Deserialize(fileStream);

      Console.WriteLine($"Objects deserialized from XML:");
      foreach (var obj in deserializedObjects)
      {
        Console.WriteLine(obj);
      }

      return deserializedObjects.ToList();
    }

    static void SerializeIntoJson<T>(List<T> objects, string filename) where T : struct, IComparable<T>
    {
      File.WriteAllText(filename, JsonSerializer.Serialize(objects, jsonOptions), Encoding.UTF8);
      Console.WriteLine("Done!");
    }

    static List<T> DeserializeFromJson<T>(string filename) where T : struct, IComparable<T>
    {
      var deserializedObjects = JsonSerializer.Deserialize<T[]>(File.ReadAllText(filename), jsonOptions);

      Console.WriteLine($"Objects deserialized from JSON:");
      foreach (var obj in deserializedObjects) Console.WriteLine(obj);

      return deserializedObjects.ToList();
    }
  }
}
