using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Status
    {
        
        public static void Statuss()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("상태창!");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                Console.WriteLine();
                Console.WriteLine("Lv. 01");
                Console.WriteLine("Chad (전사)");
                Console.WriteLine($"공격력 : 10 (+{Program.PlayerAttack})");
                Console.WriteLine($"방어력 : 5  (+{Program.PlayerSheield})");
                Console.WriteLine("체력 : 100");
                Console.WriteLine($"Gold : {Program.PlayerMoney} G");
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.Write("원하시는 행동을 입력해주세요.\n>>");
                string input1 = Console.ReadLine();
                if (input1 == "0")
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine();
                }

            }
        }
    }
}
