using Lib;
namespace Solution {
  public class Block {
    public static void One() {
      System.Console.WriteLine("\n1. Сума від'ємних під діагоналлю");
      
      int[,] matrix = Arr.ReadSqrMatrix();

      int sum = 0, count = 0;
      CountNegative(matrix, ref sum, ref count);

      System.Console.WriteLine($"\nКількість: {count},\nСума: {sum}");
    }

    public static void Two() {
      System.Console.WriteLine("\n2. Максимальний/мінімальний поставити на перше/останнє місце.");

      int[,] matrix = Arr.ReadMatrix();

      MoveMinMax(matrix);

      Arr.Print(matrix);
    }

    public static void Three() {
      System.Console.WriteLine("\n3. Упорядкувати побічну діагональ.");

      int[,] matrix = Arr.ReadSqrMatrix();
      int size = matrix.GetLength(0);

      SortDiagonal(matrix);
      
      Arr.Print(matrix);
    }

    public static void Four() {
      System.Console.Write("\n4. Упорядкувати стовпчики за кількістю нулів");

      int[][] matrix = Arr.JagReadMatrix();
      int[] valuesList;

      EvaluateRows(matrix, out valuesList);
      SortRows(matrix, valuesList);

      Arr.JagPrint(matrix);
    }


    public static void CountNegative(int[,] matrix, ref int sum, ref int count) {
      int size = matrix.GetLength(0);
      for (int i = 0; i < size; i++) {
        for (int j = 0; j < i; j++) {
          if (matrix[i,j] < 0) {
             sum += matrix[i,j];
             count++;
          }
        }
      }
    }

    public static void MoveMinMax(int[,] matrix) {
      int height = matrix.GetLength(0);
      int length = matrix.GetLength(1);
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
    }

    public static void SortDiagonal(int[,] matrix) {
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
    }

    public static void EvaluateRows(int[][] matrix, out int[] valuesList) {
      int height = matrix.Length;
      int length = matrix[0].Length;
      valuesList = new int[height];
      for (int i = 0; i < height; i++) {
        for (int j = 0; j < length; j++) {
          if (matrix[i][j]==0) valuesList[i]++;
        }
      }
    }

    public static void SortRows(int[][] matrix, int[] valuesList) {
      int height = matrix.Length;
      int length = matrix[0].Length;
      for (int i = 1; i < height; i++) {
        int temp_valuesList = valuesList[i];
        int[] temp = matrix[i];
        int j = i-1;
        while (j>=0 && valuesList[j] > temp_valuesList) {
            valuesList[j+1] = valuesList[j];
            matrix[j+1] = matrix[j];
            j--;
        }

        valuesList[j+1] = temp_valuesList;
        matrix[j+1] = temp;
      }
    }

    // public static void TrMatrix(int[][] input_matrix) {
    //   int height = input_matrix.GetLength(0);
    //   int length = input_matrix.GetLength(1);
    //   int[][] matrix = new int[length][];
    //   for (int i = 0; i < length; i++) {
    //     matrix[i] = new int[height];
    //     for (int j = 0; j < height; j++) {
    //       matrix[i][j] = input_matrix[j][i]; 
    //     }
    //   }
    //   input_matrix = matrix;
    // }
    //
    // public static void SortMatrixByValue(int[][] matrix) {
    //   int[] valuesList;
    //   TrMatrix(matrix);
    //   EvaluateRows(matrix, out valuesList);
    //   SortRows();
    // }
  }
}
