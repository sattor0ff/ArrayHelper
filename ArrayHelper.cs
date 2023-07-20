using System;

public class ArrayHelper
{
    private int[] array;

    public ArrayHelper(int[] array)
    {
        this.array = array;
    }

    // Удаление последнего элемента из массива
    public void RemoveLastElement()
    {
        if (array.Length > 0)
        {
            int[] newArray = new int[array.Length - 1];
            Array.Copy(array, newArray, array.Length - 1);
            array = newArray;
        }
    }

    // Удаление элемента из массива с помощью индекса
    public void RemoveElementAt(int index)
    {
        if (index >= 0 && index < array.Length)
        {
            int[] newArray = new int[array.Length - 1];
            Array.Copy(array, newArray, index);
            Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
            array = newArray;
        }
    }

    // Получение элемента из массива по индексу
    public int GetElementAt(int index)
    {
        if (index >= 0 && index < array.Length)
        {
            return array[index];
        }
        throw new IndexOutOfRangeException("Index is out of range.");
    }

    // Получение первого элемента массива
    public int GetFirstElement()
    {
        if (array.Length > 0)
        {
            return array[0];
        }
        throw new InvalidOperationException("The array is empty.");
    }

    // Получение последнего элемента массива
    public int GetLastElement()
    {
        if (array.Length > 0)
        {
            return array[array.Length - 1];
        }
        throw new InvalidOperationException("The array is empty.");
    }

    // Получение среднего элемента массива
    public double GetAverageElement()
    {
        if (array.Length > 0)
        {
            double sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum / array.Length;
        }
        throw new InvalidOperationException("The array is empty.");
    }
}