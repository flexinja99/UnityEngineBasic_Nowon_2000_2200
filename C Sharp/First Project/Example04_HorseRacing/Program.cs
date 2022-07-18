using System;
using System.Threading;
// ### - 진행방식 -
//
// 프로그램 시작시
// 말 다섯마리를 만들고 (말 클래스를 구현해야함)
// 각 다섯마리는 초당 10~20 (정수형) 범위 거리를 랜덤하게 움직임
// 각각의 말이 거리 200 에 도달하면 말의 이름과 등수를 출력해줌
//
// 말은
// 이름, 달린거리 를 멤버변수로
// 달리기 를 멤버 함수로 가짐
// 달리기 멤버함수는 입력받은 거리를 달린거리에 더해주어서 달린거리를 누적시키는 역할을 함
//
// 매초 달릴 때 마다 각 말들이 얼마나 거리를 이동했는지 콘솔창에 출력해줌
// 경주가 끝나면 1,2,3,4,5 등 말의 이름을 등수 순서대로 콘솔창에 출력해줌
//
// ### - Hint -
//
// System.Threading namespace 에 있는 Thread.Sleep(1000); 를 사용하면 현재 프로그램을 1초 지연시킬수 있음
// While 반복문에서 Thread.Sleep(1000); 을 추가하면 1초에 한번씩 반복문을 실행함

namespace Example04_HorseRacing
{
    class Program
    {
        static Random random; // 말의 달리는 속도를 랜덤하게 생성하기위한 난수 변수
        static bool isGameFinished = false; // 경주가 끝났는지 체크하는 변수 
        static int minSpeed = 10; // 달리는 속도의 최솟값
        static int maxSpeed = 20; // 달리는 속도의 최댓값
        static int finishDistance = 200; // 결승점 거리
        static void Main(string[] args)
        {
            // 말 다섯마리 만들고
            // 각각의 말 이름들 정해주고
            Horse[] arr_Horse = new Horse[5]; // 말 5마리를 인스턴스화시키기 위한 배열
            string[] arr_FinishedHorseName = new string[5]; // 결승점을 통과한 말의 이름을 저장 할 배열
            int currentGrade = 1; // 현재 등수

            int length = arr_Horse.Length; // 말들이 저장된 배열의 길이
            for (int i = 0; i < length; i++) // 말들을 인스턴스화 시키고, 말들의 이름을 저장 할 배열
            {
                arr_Horse[i] = new Horse(); // 말 인스턴스화
                arr_Horse[i].name = $"백마{i + 1}"; // 말의 이름 초기화
            }
            Console.WriteLine($"경주 START!");
            int count = 0; // while 문이 돈 횟수
            while (isGameFinished == false) // 게임이 끝날때 까지 돌아가는 while 문
            {
                Console.WriteLine($"-------------{count} 초 -------------");                
                for (int i = 0; i < length; i++) // 랜덤한 속도로 말을 달리게 하는 for 문
                {
                    if (arr_Horse[i].dontMove == false) // i번째 말이 움직일 수 있으면
                    {
                        random = new Random(); // 난수용 인스턴스
                        int tmpMoveDistance = random.Next(minSpeed, maxSpeed + 1); // minSpeed(10) ~ maxSpeed(20)  범위내의 난수 생성
                        arr_Horse[i].Run(tmpMoveDistance); // i번째 말을 tmpMoveDistnace(10~20 사이 정수)만큼 달림
                        Console.WriteLine($" {arr_Horse[i].name} 가 달린거리 : {arr_Horse[i].distance}m"); // {i번째 말 이름}가 달린거리 {i번째 말이 달린거리} 출력
                        if (arr_Horse[i].distance >= finishDistance) // 
                        {
                            arr_Horse[i].dontMove = true; //
                            arr_FinishedHorseName[currentGrade - 1] = arr_Horse[i].name; // 
                            currentGrade++; // 현재 등수를 1 증가
                        }
                    }
                }
                Console.WriteLine($"--------------------------------");
                if (currentGrade > 5) //
                {
                    isGameFinished = true;
                    Console.WriteLine("경주 End!");
                    break;
                }

                Thread.Sleep(1000);
                count++;
            }

            Console.WriteLine("------------결과 발표------------");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i + 1} 등 : {arr_FinishedHorseName[i]}");
            }            
        }
    }
    public class Horse
    {
        public string name;
        public int distance;
        public bool dontMove;
        public void Run(int moveDistance)
        {
            distance += moveDistance;
        }
    }
}
