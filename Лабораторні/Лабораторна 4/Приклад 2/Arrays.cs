namespace Приклад_2
{
    internal class Arrays
    {
        public bool error = false;
        int[] a;
        int lenght;
        public Arrays(int size)
        {
            a = new int[size];

            lenght = size;
        }

        public int Lenght
        {
            get { return lenght; }
        }

        public static Arrays generateRandomArray(Arrays array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Lenght; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            return array;
        }

        public static Arrays operator *(Arrays arrays, int mul)
        {
            Arrays resArray = new Arrays(arrays.Lenght);
            for (int i = 0; i < resArray.Lenght; i++)
            {
                resArray[i] = arrays[i] * mul;
            }
            return resArray;
        }

        public int this[int i ]
        {
            get
            {
                if (i >= 0 && i < lenght) return a[i];
                else { error = true; return 0; };
            }
            set
            {
                if (i >= 0 && i < lenght && value >= -100 && value <= 10000) a[i] = value;
                else error = true;
            }
        }
    }
}