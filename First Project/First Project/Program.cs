// 파란글자 : 키워드
// 키워드(예약어) : 미리 정의되어있는 단어 -> 문법용도로 사용

// 흰글자 : 식별문자 (참조있음, 명시적 표현)

// 청록색글자 : 클래스 식별문자 (이름)

// 노란색글자 : 함수 식별문자 (이름)

// 하늘색글자 : 함수의 파라미터 (매개변수)의 식별문자 (이름)

// 주황색글자 : 문자열 상수

// 글자색이 어둡다면 : (참조 없음, 생략 가능 == 암시적 표현)


// using 키워드
// 특정 namespace를 사용하기위한 키워드
// 형식 : using namespace 이름
using System;

// namespace 키워드
// 공간을 구분하기위한 키워드
// 내부식별자를 가지고 namespace로 묶인 변수, 함수, 클래스, 인터페이스 등을 구분한다 
namespace FirstProject // Note: actual namespace depends on the project name.
{
    // internal 키워드
    // 동일 어셈블리에서만 접근가능한 키워드

    // class 키워드
    // 객체를 만들기위한 타입을 
    // 형식 : class 클래스 이름
    internal class Program
    {
        // static 키워드
        // 정적 키워드, 메모리에 동적할당이 불가능한 속성을 부여한다.

        // void 키워드
        // 아무것도 없다. (반환값이 없다)

        // Main 함수 
        // 실행파일 (.exe)을 실행했을때 가장 먼저 실행되는 함수이다.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
