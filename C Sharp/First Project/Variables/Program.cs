using System;

int count; // 전역(글로벌) 변수

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0000(28개)... 1110
            Human.age = 13; // = 2^3 + 2^2 + 2^1
            Console.WriteLine(".");
            Console.WriteLine(Human.age);
        }
    }

    class Human
    {
        // : 해당 라인을 주석처리함
        /* */ // : 범위 내의 내용을 주석처리함 (Ctrl + Shift + /)

        // bit : 한자리 이진수 (0 과 1, 정보 처리의 최소단위)
        // byte : 8 bit로 구성 (CPU의 데이터 처리의 최소단위)
        // 4 byte : 4 * 8 bit == 32 bit
        // 표현할 수 있는 숫차범위 : 2^(bit 수)

        // 변수
        // 형식 : 자료형 변수이름
        public static int age; // 4 byte 정수 -2^31 - 2^31 - 1
        private float height; // 4 byte 실수형
        double weight; // 8 byte 실수형
        bool isResting; // 1 byte 논리형 (참과 거짓 표현)
        // 참 : 0이 아닌 숫자, 거짓 : 0
        char genderChar; // 2 byte 문자형 (ASCII 코드로 표현
        string name; // 문자열형, 문자갯수 * 2 byte + 1 byte (NULL)

        // 멤버
        // class / structure / namespace를 구성하는 구성원을 멤버라 함

    }
}