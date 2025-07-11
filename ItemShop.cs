using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ItemShop
    {
        public static void Store()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("상점");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine($"{Program.PlayerMoney} G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine($"{Program.itname[i]}   \t {Program.itnumber[i]}  \t {Program.itcom[i]}  \t {Program.it[i]}");
                }
                Console.WriteLine();
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.Write("원하시는 행동을 입력해주세요.\n>>");
                string input4 = Console.ReadLine();
                if (input4 == "0")
                {
                    Console.Clear();
                    return;
                }
                else if (input4 == "1")
                {
                    Console.Clear();
                    storebuy();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine();
                }

            }
        }

        public static void storebuy()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("상점 - 구매중");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine($"{Program.PlayerMoney} G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("번호로 아이템 구매");
                Console.WriteLine();
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine($"{Program.itname[i]}   \t {Program.itnumber[i]}  \t {Program.itcom[i]}  \t {Program.it[i]}");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.Write("원하시는 행동을 입력해주세요.\n>>");
                string input6 = Console.ReadLine();
                if (input6 == "0")
                {
                    Console.Clear();
                    return;
                }
                else if (input6 == "1")
                {
                    if (Program.PlayerMoney >= 1000 && Program.it[0] != Program.it[7])
                    {
                        Console.Clear();
                        Program.it[0] = Program.it[7];
                        Program.inventorypoint[0] = 1;
                        I_tem(1);
                    }
                    else if (Program.it[0] == Program.it[7])
                    {
                        Console.Clear();
                        Console.WriteLine("이미 구매한 물품입니다.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Gold 가 부족합니다.");
                        Console.WriteLine();
                    }

                }
                else if (input6 == "2")
                {
                    if (Program.PlayerMoney >= 2000 && Program.it[1] != Program.it[7])
                    {
                        Console.Clear();
                        Program.it[1] = Program.it[7];
                        Program.inventorypoint[1] = 1;
                        I_tem(2);
                    }
                    else if (Program.it[1] == Program.it[7])
                    {
                        Console.Clear();
                        Console.WriteLine("이미 구매한 물품입니다.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Gold 가 부족합니다.");
                        Console.WriteLine();
                    }

                }
                else if (input6 == "3")
                {
                    if (Program.PlayerMoney >= 3500 && Program.it[2] != Program.it[7])
                    {
                        Console.Clear();
                        Program.it[2] = Program.it[7];
                        Program.inventorypoint[2] = 1;
                        I_tem(3);
                    }
                    else if (Program.it[2] == Program.it[7])
                    {
                        Console.Clear();
                        Console.WriteLine("이미 구매한 물품입니다.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Gold 가 부족합니다.");
                        Console.WriteLine();
                    }

                }
                else if (input6 == "4")
                {
                    if (Program.PlayerMoney >= 600 && Program.it[4] != Program.it[7])
                    {
                        Console.Clear();
                        Program.it[4] = Program.it[7];
                        Program.inventorypoint[4] = 1;
                        I_tem(4);
                    }
                    else if (Program.it[4] == Program.it[7])
                    {
                        Console.Clear();
                        Console.WriteLine("이미 구매한 물품입니다.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Gold 가 부족합니다.");
                        Console.WriteLine();
                    }

                }
                else if (input6 == "5")
                {
                    if (Program.PlayerMoney >= 1500 && Program.it[5] != Program.it[7])
                    {
                        Console.Clear();
                        Program.it[5] = Program.it[7];
                        Program.inventorypoint[5] = 1;
                        I_tem(5);
                    }
                    else if (Program.it[5] == Program.it[7])
                    {
                        Console.Clear();
                        Console.WriteLine("이미 구매한 물품입니다.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Gold 가 부족합니다.");
                        Console.WriteLine();
                    }

                }
                else if (input6 == "6")
                {
                    if (Program.PlayerMoney >= 3000 && Program.it[6] != Program.it[7])
                    {
                        Console.Clear();
                        Program.it[6] = Program.it[7];
                        Program.inventorypoint[6] = 1;
                        I_tem(6);
                    }
                    else if (Program.it[6] == Program.it[7])
                    {
                        Console.Clear();
                        Console.WriteLine("이미 구매한 물품입니다.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Gold 가 부족합니다.");
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine();
                }
            }
        }

        public static void I_tem(int item)
        {
            if (item == 1)
            {
                Program.PlayerMoney -= 1000;
                Program.PlayerSheield += 5;
                Console.WriteLine("구매 완료.");
                Console.WriteLine();
                Bag.Equipment();
            }
            if (item == 2)
            {
                Program.PlayerMoney -= 2000;
                Program.PlayerSheield += 9;
                Console.WriteLine("구매 완료.");
                Console.WriteLine();
                Bag.Equipment();
            }
            if (item == 3)
            {
                Program.PlayerMoney -= 3500;
                Program.PlayerSheield += 15;
                Console.WriteLine("구매 완료.");
                Console.WriteLine();
                Bag.Equipment();
            }
            if (item == 4)
            {
                Program.PlayerMoney -= 600;
                Program.PlayerAttack += 2;
                Console.WriteLine("구매 완료.");
                Console.WriteLine();
                Bag.Equipment();
            }
            if (item == 5)
            {
                Program.PlayerMoney -= 1500;
                Program.PlayerAttack += 5;
                Console.WriteLine("구매 완료.");
                Console.WriteLine();
                Bag.Equipment();
            }
            if (item == 6)
            {
                Program.PlayerMoney -= 3000;
                Program.PlayerAttack += 7;
                Console.WriteLine("구매 완료.");
                Console.WriteLine();
                Bag.Equipment();
            }

        }
    }
}
