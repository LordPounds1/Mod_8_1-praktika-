using System;

class RangeOfArray
{
    private int lowerIndex;
    private int upperIndex;
    private int[] array;

    public RangeOfArray(int lowerIndex, int upperIndex)
    {
        if (lowerIndex > upperIndex)
        {
            throw new ArgumentException("Lower index cannot be greater than upper index.");
        }

        this.lowerIndex = lowerIndex;
        this.upperIndex = upperIndex;
        int size = upperIndex - lowerIndex + 1;
        this.array = new int[size];
    }

    public int this[int index]
    {
        get
        {
            if (IsIndexValid(index))
            {
                return array[index - lowerIndex];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
        set
        {
            if (IsIndexValid(index))
            {
                array[index - lowerIndex] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
    }

    public int LowerIndex
    {
        get { return lowerIndex; }
    }

    public int UpperIndex
    {
        get { return upperIndex; }
    }

    private bool IsIndexValid(int index)
    {
        return index >= lowerIndex && index <= upperIndex;
    }
}

class Program
{
    static void Main()
    {
        RangeOfArray customArray = new RangeOfArray(6, 10);

        for (int i = customArray.LowerIndex; i <= customArray.UpperIndex; i++)
        {
            customArray[i] = i * 10;
            Console.WriteLine($"customArray[{i}] = {customArray[i]}");
        }

        Console.ReadLine();
    }
}

