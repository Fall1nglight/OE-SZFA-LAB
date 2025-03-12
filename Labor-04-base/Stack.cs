using System.Text;

namespace Labor_04_base;

public class Stack
{
    // fields
    private readonly char[] _arr;
    private int _count;
    private int _lastIdx;

    // constructors
    public Stack(int size = 1)
    {
        _arr = new char[size];
        _lastIdx = size;
    }

    // methods
    public bool Push(char newItem)
    {
        if (Full())
            return false;

        // i = _count-1
        _arr[--_lastIdx] = newItem;
        _count++;
        return true;
    }

    public bool Pop(out char item)
    {
        if (Empty())
        {
            item = '\0';
            return false;
        }

        item = _arr[_lastIdx];
        _arr[_lastIdx] = char.MinValue;
        _lastIdx++;
        return true;
    }

    public bool Empty() => _lastIdx == _arr.Length;

    public bool Full() => _lastIdx == 0;

    public string GetAllItems()
    {
        StringBuilder sb = new StringBuilder("Stack: \n");

        for (var i = 0; i < _arr.Length; i++)
            sb.AppendLine($"[ {(_arr[i] != char.MinValue ? _arr[i] : "")} ]");

        return sb.ToString();
    }

    // properties
    public int NumOfElements => _count;
}
