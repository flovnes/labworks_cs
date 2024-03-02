namespace Lib {
  public class Arr { 
    public static int[,] ReadMatrix() {
      System.Console.Write("Введіть розміри матриці (<l> <h>): ");
      
      string[] data = System.Console.ReadLine().Split();
      int length = int.Parse(data[0]);
      int height = int.Parse(data[1]);
      int[,] m = new int[height, length];

      System.Console.WriteLine($"\nВведіть матрицю {length}x{height}:");

      for (int i = 0; i < height; i++) {
        data =  System.Console.ReadLine().Split();
        for (int j = 0; j < length; j++) {
          m[i, j] = int.Parse(data[j]);
        }
      }

      return m;
    }

    public static int[][] JagReadMatrix() {
      System.Console.Write("Введіть розміри матриці (<l> <h>): ");
      
      string[] data = System.Console.ReadLine().Split();
      int length = int.Parse(data[0]);
      int height = int.Parse(data[1]);
      int[][] matrix = new int[height][];
      
      System.Console.WriteLine($"\nВведіть матрицю {length}x{height}:");

      for (int i = 0; i < height; i++) {
        data = System.Console.ReadLine().Split();
        matrix[i] = new int[length];
        for (int j = 0; j < length; j++) {
          matrix[i][j] = int.Parse(data[j]);
        }
      }
      return matrix;
    }

    public static int[,] ReadSqrMatrix() {
      System.Console.WriteLine($"\nВведіть квадратну матрицю:");
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
      System.Console.WriteLine("Матриця:");
      for (int i = 0; i < a.GetLength(0); i++) {
        for (int j = 0; j < a.GetLength(1); j++) {
          System.Console.Write($"{a[i, j],2} ");
        }
        System.Console.WriteLine();
      }
    }

    public static void JagPrint(int[][] a) {
      System.Console.WriteLine("Відсортована матриця:");
      for (int i = 0; i < a.Length; i++) {
        for (int j = 0; j < a[0].Length; j++) {
          System.Console.Write($"{a[i][j],2} ");
        }
        System.Console.WriteLine();
      }
    }
  }
}
