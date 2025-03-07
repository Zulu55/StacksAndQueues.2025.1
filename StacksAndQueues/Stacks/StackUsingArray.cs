namespace Stacks;

public class StackUsingArray<T> : IStack<T>
{
    private T[] _elements;
    private int _top;

    public StackUsingArray(int capacity)
    {
        _elements = new T[capacity];
        _top = -1;
    }

    public T Peek()
    {
        if (_top < 0)
        {
            throw new Exception("Stack is empty.");
        }
        return _elements[_top];
    }

    public T Pop()
    {
        if (_top < 0)
        {
            throw new Exception("Stack is empty.");
        }
        return _elements[_top--];
    }

    public void Push(T item)
    {
        if (_top == _elements.Length - 1)
        {
            throw new Exception("Stack is full.");
        }
        _elements[++_top] = item;
    }
}