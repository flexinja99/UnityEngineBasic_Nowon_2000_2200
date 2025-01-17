﻿using System;
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

        public int this[int index]
        {
            get
            {
                return _data[index];
            }

            set
            {
                _data[index] = value;
            }
        }

        public int Length; // 실제 데이터 개수
       
        // 프로퍼티 : 필드의 ㄱ밧을 쓰거나 읽을때 get 함수나 set 함수를 용이하게 만들어서 접근할 수 있는
        //            get 접근자와 set 접근자를 구현할 수 있는 멤버
        public int Capacity
        {
            get
            {
                return _data.Length;
            }
        }

        public void Add(int item)
        {
            // Capacity가 모자를 경우 배열의 크기를 늘린다.
            if (Length >= Capacity)
            {
                int[] tmp = new int[Capacity * 2];
                for (int i = 0; i < Length; i++)
                {
                    tmp[i] = _data[i];
                }
                _data = tmp;
            }
            
            _data[Length] = item;
            Length++;
        }

        public bool Remove(int item)
        {
            bool isFounded = false;
            for (int i = 0; i < Length; i++)
            {
                if (_data[i] == item)
                {
                    isFounded = true;
                    RemoveAt(i);
                    break;
                }
            }
            return isFounded;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < Length - 1; i++)
            {
                _data[i] = _data[i + 1];
            }
            _data[Length - 1] = default(int);
            Length--;
        }
    }
}
