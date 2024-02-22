namespace Lib {
  public class Arr { 
    public static int[,] ReadMatrix(int width, int length) {
      int[,] m = new int[width, length];
      for (int i = 0; i < width; i++)
      {
        string[] data =  System.Console.ReadLine().Split();
        for (int j = 0; j < length; j++)
        {
          m[i, j] = int.Parse(data[j]);
        }
      }
     return m;
    }

    public static int[,] ReadMatrix() {
      string[] firstLine = System.Console.ReadLine().Split();
      int size = firstLine.Length;
      int[,] m = new int[size, size];
      for (int i = 0; i < size; i++)
      {
        m[0,i] = int.Parse(firstLine[i]);
      }
      for (int i = 1; i < size; i++)
      {
        string[] data =  System.Console.ReadLine().Split();
        for (int j = 0; j < size; j++)
        {
          m[i, j] = int.Parse(data[j]);
        }
      }
      return m;
    }

    public static void Print(int[,] a) {
      for (int i = 0; i < a.GetLength(0); i++) {
        for (int j = 0; j < a.GetLength(1); j++) {
          System.Console.Write($"{a[i, j],2} ");
        }
        System.Console.WriteLine();
      }
    }
  }
}
