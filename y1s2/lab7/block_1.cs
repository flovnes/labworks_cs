using Lib;
namespace BlockOne {
  public class Block1 {
    public static void Solution() {
      int[,] matrix = Arr.ReadMatrix();
      int counter = 0, sum = 0;
      int size = matrix.GetLength(0);
      for (int i = 0; i < size; i++) {
        for (int j = 0; j < i; j++) {
          if (matrix[i,j] < 0) {
             sum += matrix[i,j];
             counter++;
          }
          System.Console.Write($"{matrix[i,j]} ");
        }
      }
      System.Console.WriteLine($"sum: {sum}, counter: {counter}\nfor matrix:");
      Arr.Print(matrix);
    }
  }
}
