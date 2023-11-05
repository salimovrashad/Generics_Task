namespace ConsoleApp1
{
    internal class ListInt
    {
        int[] _arr = new int[0];

        public ListInt(params int[] arr)
        {
            _arr = arr;
        }

        public void Add(int value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }

        public void Clear()
        {
            Array.Resize(ref _arr, 0);
        }

        public bool Exist(int value)
        {
            foreach (var item in _arr)
            {
                if (item == value)
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(int value)
        {
            foreach (var item in _arr)
            {
                if (item != value)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void Reverse()
        {
            for (int i = _arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(_arr[i]);
            }
        }

        public void Indexof(int number)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (number == _arr[i])
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void LastIndexof(int index)
        {
            for (int i = _arr.Length - 1; i >= 0; i--)
            {
                if (index == _arr[i])
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }

        public void All() 
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
