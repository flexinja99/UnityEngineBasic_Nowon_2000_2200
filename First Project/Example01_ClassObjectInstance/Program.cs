using System;

namespace Example01_ClassObjectInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            orc orc1 = new orc();
            orc1.name = "상급오크";
            orc1.height = 240.2f;
            orc1.weight = 200.0f;
            orc1.age = 140;
            orc1.genderChar = '남';
            orc1.isResting = false;

            orc orc2 = new orc();
            orc2.name = "하급오크";
            orc2.height = 140.4f;
            orc2.weight = 120.0f;
            orc2.genderChar = '여';
            orc2.isResting = true;

            if (orc1.isResting == false)
            {
                orc1.Attack();
                orc1.Dash();
                orc1.Angry();
            }
            else
            {
                Console.WriteLine(orc1.name + "(이)가 바쁘다!!");
            }
            if (orc2.isResting == false)
            {
                orc2.Jump();
                orc2.Attack();
                orc2.Angry();
            }
            else
            {
                Console.WriteLine(orc2.name + "(이)가 바쁘다!!");
            }

            orc1.ChekIsRestingAndDash();

        }
    }
    class orc
    {
        public string name;
        public float height;
        public float weight;
        public int age;
        public char genderChar;
        public bool isResting;

        public void Attack()
        {
            Console.WriteLine(name + " (이)가 공격했다!!");
        }
        public void Jump()
        {
            Console.WriteLine(name + " (이)가 뛰어올랐다!!");
        }
        public void Dash()
        {
            Console.WriteLine(name + " (이)가 돌진했다!!");
        }
        public void Angry()
        {
            Console.WriteLine(name + " (이)가 화났다!!");
        }
        public void Sleeping()
        {
            Console.WriteLine(name + " (이)가 자고있다!!");
        }

        public void ChekIsRestingAndDash()
        {
            if (isResting == true)
            {
                Sleeping();
            }
            else
            {
                Console.WriteLine(name + " (이)는 바빠서 돌진할 수 없다!!");
            }
        }
    }
}
