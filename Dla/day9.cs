public class ListImplementation
{
    int[] arr = [];

    public ListImplementation(int[] list)
    {
        arr = list;
    }

    public int getIndexOf(int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return i;
            }
        }

        return -1;
    }

    public bool HasIncludes(int value)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return true;
            }
        }

        return false;
    }

    public int GetLastIndexOf(int value)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == value)
            {
                return i;
            }
        }

        return -1;
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