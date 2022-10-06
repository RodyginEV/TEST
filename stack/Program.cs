// Реализуйте вручную класс, который реализует функционал стека, с функциями push/pop. Используйте Generic.
public class FixedStack<T>
{
    private T[] items; // элементы стека
    private int count;  // количество элементов
    const int n = 10;   // количество элементов в массиве по умолчанию
    public FixedStack()
    {
        items = new T[n];
    }
    public FixedStack(int length)
    {
        items = new T[length];
    }
    // пуст ли стек
    public bool IsEmpty
    {
        get { return count == 0; }
    }
    // размер стека
    public int Count
    {
        get { return count; }
    }
    // добвление элемента
        public void Push(T item)
    {
        // увеличиваем стек
        if (count == items.Length)
            Resize(items.Length + 10);
 
        items[count++] = item;
    }
    public T Pop()
    {
        // если стек пуст, выбрасываем исключение
        if (IsEmpty)
            throw new InvalidOperationException("Стек пуст");
        T item = items[--count];
        items[count] = default(T); // сбрасываем ссылку
 
        if (count > 0 && count < items.Length - 10)
            Resize(items.Length - 10);
 
        return item;
    }
    // возвращаем элемент из верхушки стека
    public T Peek()
    {
        return items[count - 1];
    }

// если вдруг в массиве больше не окажется места, то мы вызовем функцию 
    private void Resize(int max)
    {
        T[] tempItems = new T[max];
        for (int i = 0; i < count; i++)
            tempItems[i] = items[i];
        items = tempItems;
    }
}