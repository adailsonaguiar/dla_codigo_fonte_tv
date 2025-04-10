public class ListImplementation
{
    int[] arr = [];

    public ListImplementation(int[] list)
    {
        arr = list;
    }

    public int getIndexOf(int value)
    {
        var returnIndex = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                returnIndex = i;
            }
        }

        return returnIndex;
    }

    public bool HasIncludes(int value)
    {
        var returnIndex = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                returnIndex = true;
            }
        }

        return returnIndex;
    }

    public int GetLastIndexOf(int value)
    {
        var returnIndex = -1;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == value)
            {
                returnIndex = i;
                break;
            }
        }

        return returnIndex;
    }

    public int[] SliceImplementation(int init, int finish)
    {
        List<int> returnValue = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (i >= init && i <= finish)
            {
                returnValue.Add(arr[i]);
            }
        }
        return returnValue.ToArray();
    }
}