class Program
{
    static void Main()
    {
        int[] myArray = { 1, 2, 3, 4, 5 };
        ArrayHelper arrayHelper = new ArrayHelper(myArray);

        // Удаление последнего элемента
        arrayHelper.RemoveLastElement();

        // Удаление элемента по индексу (например, удаляем элемент с индексом 1)
        arrayHelper.RemoveElementAt(1);

        // Получение элемента по индексу (например, получаем элемент с индексом 2)
        int elementAtIndex = arrayHelper.GetElementAt(2);
        Console.WriteLine("Element at index 2: " + elementAtIndex);

        // Получение первого элемента массива
        int firstElement = arrayHelper.GetFirstElement();
        Console.WriteLine("First element: " + firstElement);

        // Получение последнего элемента массива
        int lastElement = arrayHelper.GetLastElement();
        Console.WriteLine("Last element: " + lastElement);

        // Получение среднего элемента массива
        double averageElement = arrayHelper.GetAverageElement();
        Console.WriteLine("Average element: " + averageElement);
    }
}