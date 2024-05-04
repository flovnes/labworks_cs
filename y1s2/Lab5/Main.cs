using System.Text;
using lab5_serialization;

namespace Lab5
{
  public partial class Program
  {
    static void Main()
    {
      Console.OutputEncoding = UTF8Encoding.UTF8;
      bool get_out_out = false;
      while (!get_out_out) {
        Console.Write("\nChoose struct { Order, Train }: ");
        Console.WriteLine("[0] Exit");
        Console.WriteLine("[1] Order");
        Console.WriteLine("[2] Train");
        int objectType = int.Parse(Console.ReadLine()), choice;
        
        switch (objectType) {
          case 1:
            bool get_out = false;
            while (!get_out)
            {
              Console.WriteLine("[0] Exit");
              Console.WriteLine("[1] Write data to TXT file");
              Console.WriteLine("[2] Serialize data to XML file");
              Console.WriteLine("[3] Serialize data to JSON file");

              if (File.Exists("Order.txt"))
                Console.WriteLine("[4] Read data data TXT file");

              if (File.Exists("Order.xml"))
                Console.WriteLine("[5] Deserialize data from XML file");

              if (File.Exists("Order.json"))
                Console.WriteLine("[6] Deserialize data from JSON file");
              Console.Write("\nChoose an option: ");
              choice = int.Parse(Console.ReadLine());

              switch (choice)
              {
                case 1:
                  WriteIntoTxt(EnterObjects<Order>(), "Order.txt");
                  break;
                case 2:
                  SerializeIntoJson(EnterObjects<Order>(), "Order.xml");
                  break;
                case 3:
                  SerializeIntoXml(EnterObjects<Order>(), "Order.json");
                  break;
                case 4:
                  ReadFromTxt<Order>("Order.txt");
                  break;
                case 5:
                  DeserializeFromXml<Order>("Order.xml");
                  break;
                case 6:
                  DeserializeFromJson<Order>("Order.json");
                  break;
                case 0:
                  get_out = true;
                  break;
                default:
                  Console.WriteLine("?");
                  break;
              }
            }
          break;
          case 2:
            Console.WriteLine("[0] Exit");
            Console.WriteLine("[1] Write data to TXT file");
            Console.WriteLine("[2] Serialize data to XML file");
            Console.WriteLine("[3] Serialize data to JSON file");

            if (File.Exists("Train.txt"))
              Console.WriteLine("[4] Read data data TXT file");

            if (File.Exists("Train.xml"))
              Console.WriteLine("[5] Deserialize data from XML file");

            if (File.Exists("Train.json"))
              Console.WriteLine("[6] Deserialize data from JSON file");
            Console.Write("\nChoose an option: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
              case 1:
                WriteIntoTxt(EnterObjects<Train>(), "Train.txt");
                break;
              case 2:
                SerializeIntoJson(EnterObjects<Train>(), "Train.xml");
                break;
              case 3:
                SerializeIntoXml(EnterObjects<Train>(), "Train.json");
                break;
              case 4:
                ReadFromTxt<Train>("Train.txt");
                break;
              case 5:
                DeserializeFromXml<Train>("Train.xml");
                break;
              case 6:
                DeserializeFromJson<Train>("Train.json");
                break;
              case 0:
                get_out = true;
                break;
              default:
                Console.WriteLine("?");
                break;
            }
          break;
          case 0:
            get_out_out = true;
            break;
        }
      }
    }
  }
}
