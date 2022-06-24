using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03_DynamicArray
{
    internal class DynamicArray
    {
        // const : 해당 변수를 상수형태로 취급하겠다는 키워드
        private const int DEFAULT_SIZE = 1;
        private int[] _data = new int[DEFAULT_SIZE];

        public int Length;
        public int Capacity;

        public void Add(int item)
        {
            // Capacity가 모자를 경우 배열의 크기를 늘린다.
            if (Length >= Capacity)
            {
                int[] tmp = new int[Capacity * 2];
                tmp = _data;
                for (int i = 0; i < Length; i++)
                {
                    tmp[i] = _data[i];
                }
                _data = tmp;
            }
            _data[Length] = item;
            Length++;
        }
    }
}
