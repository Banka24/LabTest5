using System.Collections.Generic;

namespace Lab5;

public class Variant14
{
    /// <summary>
    ///     Подсчёт количества отрицательных элементов двумерного массива
    /// </summary>
    /// <param name="values">Двумерный массив</param>
    /// <returns>Количество отрицательных элементов</returns>
    public static int GetCountNegativeValues(double[,] values)
    {
        var count = 0;

        foreach (var item in values)
        {
            if (item < 0)
            {
                count++;
            }
        }
            
        return count;
    }

    /// <summary>
    ///     Нахождение произведения положительных элементов двумерного массива
    /// </summary>
    /// <param name="values">Двумерный массив</param>
    /// <returns>Произведение положительных элементов</returns>
    public static double GetResultMultiply(double[,] values)
    {
        double product = 1;
        var rows = values.GetLength(0);

        for (var i = 0; i < rows; i++)
        {
            if (values[i, 2] > 0)
            {
                product *= values[i, 2];
            }
        }

        return product;
    }

    /// <summary>
    ///     Получение минимальных элементов в каждой строке двумерного массива
    /// </summary>
    /// <param name="values">Двумерный массив</param>
    /// <returns>Одномерный массив минимальных элементов каждой строки</returns>
    public static double[] GetArrayMinElements(double[,] values)
    {
        var rows = values.GetLength(0);
        var columns = values.GetLength(1);
        var M = new List<double>();

        for (var i = 0; i < rows; i++)
        {
            var minValue = values[i, 0];
            for (var j = 1; j < columns; j++)
            {
                if (values[i, j] < minValue)
                {
                    minValue = values[i, j];
                }
            }
                
            M.Add(minValue);
        }

        return M.ToArray();
    }

    /// <summary>
    ///     Получение отрицательных элементов двумерного массива
    /// </summary>
    /// <param name="values">Двумерный массив</param>
    /// <returns>Одномерный массив отрицательных элементов</returns>
    public static double[] GetNegativeValues(double[,] values)
    {
        var G = new List<double>();

        foreach (var item in values)
        {
            if (item < 0)
            {
                G.Add(item);
            }
        }
            
        return G.ToArray();
    }
}