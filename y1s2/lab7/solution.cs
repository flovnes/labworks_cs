using Lib;
namespace Solution {
  public class Block {
    public static void one() {
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

    public static void Two() {
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

    public static void Three() {
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

    public static void Four() {
      int[] temp = Array.ConvertAll(System.Console.ReadLine().Split(), int.Parse);
      int height = temp[0], length = temp[1];
      int[][] input_matrix = new int[height][];
      int[][] matrix = new int[length][];
      int[] nc = new int[length];
      System.Console.WriteLine($"\nInput a input_matrix {height}x{length}:");

      for (int i = 0; i < height; i++) {
        temp = Array.ConvertAll(System.Console.ReadLine().Split(), int.Parse);
        input_matrix[i] = new int[length];
        for (int j = 0; j < length; j++) {
          input_matrix[i][j] = temp[j];
        }
      }

      for (int i = 0; i < length; i++) {
        matrix[i] = new int[height];
        for (int j = 0; j < height; j++) {
          matrix[i][j] = input_matrix[j][i]; 
        }
      }

      for (int i = 0; i < length; i++) {
        for (int j = 0; j < height; j++) {
          if (matrix[i][j]==0) nc[i]++;
        }
      }
      
      SortRows(matrix, nc);
      System.Console.WriteLine("Resulting matrix:");

      for (int i = 0; i < height; i++) {
        for (int j = 0; j < length; j++) {
          System.Console.Write($"{matrix[j][i],2} ");
        }
        System.Console.WriteLine();
      }
    }

    public static int[][] SortRows(int[][] matrix, int[] nc) {
      int height = matrix.GetLength(0);
      for (int i = 1; i < height; i++) {
        int[] t = matrix[i];
        int t_nc = nc[i];
        for (int j = i-1; j >= 0;) {
          if (t_nc < nc[j]) {
            nc[j+1] = nc[j];
            nc[j] = t_nc;
            matrix[j+1] = matrix[j];
            matrix[j] = t;
            j--;
          } else {
            break;
          }
        }
      }
      return matrix;
    }
  }
}
