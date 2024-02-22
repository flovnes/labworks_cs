using Lib;
namespace BlockTwo {
  public class Block2 {
    public static void Solution() {
      string[] data = System.Console.ReadLine().Split();
      int height = int.Parse(data[0]);
      int length = int.Parse(data[1]);
      System.Console.WriteLine($"\nInput a matrix {height}x{length}:");
      int[,] matrix = Arr.ReadMatrix(height, length);
      int max = 0, min = 0;
      for (int i = 0; i < height; i++) {
        for (int j = 0; j < length; j++) {
          if (matrix[i,j] > matrix[i,max]) { max = j; } 
        }
          (matrix[i, 0], matrix[i, max]) = (matrix[i,max], matrix[i,0]); 
        for (int j = 0; j < length; j++) {
          if (matrix[i,j] < matrix[i,min]) { min = j; } 
        }
        if (min != length-1) {
          (matrix[i,length-1], matrix[i,min]) = (matrix[i,min], matrix[i,length-1]); 
        }
      }
      System.Console.WriteLine("Resulting matrix:");
      Arr.Print(matrix);
    }
  }
}
