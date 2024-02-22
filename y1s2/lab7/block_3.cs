using Lib;
namespace BlockThree {
  public class Block3 {
    public static void Solution() {
      int[,] matrix = Arr.ReadMatrix();
      int size = matrix.GetLength(0);
      for (int i = 1; i < size; i++) {
        int save = matrix[i,size-i-1];
        for (int k = i-1; k >= 0;) {
          if (save < matrix[k,size-k-1]) {
            matrix[k+1,size-k-2] = matrix[k,size-k-1];
            matrix[k,size-k-1] = save;
            k--;
          } else {
            break;
          }
        }
      }
      System.Console.WriteLine("Resulting matrix:");
      Arr.Print(matrix);
    }
  }
}
