namespace Stacks;

public class StackUsingList<T> : IStack<T>
{
    private List<T> _elements = [];

    public T Peek()
    {
        if (_elements.Count == 0)
        {
            throw new Exception("Stack is empty.");
        }
        return _elements[_elements.Count - 1];
    }

    public T Pop()
    {
        if (_elements.Count == 0)
        {
            throw new Exception("Stack is empty.");
        }
        var item = _elements[_elements.Count - 1];
        _elements.RemoveAt(_elements.Count - 1);
        return item;
    }

    public void Push(T item)
    {
        _elements.Add(item);
    }
}