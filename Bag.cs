using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bag
    {
        public static void Display()
        {
            for (int i = 0; i < 7; i++)
            {
                if (Program.inventorypoint[i] == 1)
                {
                    Console.WriteLine(Program.inventory[i]);
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        public static void Inventory()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine();
                Console.WriteLine();
                Display();
                Console.WriteLine();
                Console.WriteLine("1. 장착 관리");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.Write("원하시는 행동을 입력해주세요.\n>>");
                string input2 = Console.ReadLine();
                if (input2 == "0")
                {
                    Console.Clear();
                    return;
                }
                else if (input2 == "1")
                {
                    Console.Clear();
                    Equipment();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine();
                }

            }
        }

        public static void Equipment()
        {
            while (true)
            {
                Console.WriteLine("인벤토리 - 장비 창");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("번호로 아이템 관리");
                Console.WriteLine();
                Display();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.Write("원하시는 행동을 입력해주세요.\n>>");
                string input3 = Console.ReadLine();
                if (input3 == "0")
                {
                    Console.Clear();
                    return;
                }
                if (input3 == "1" && Program.inventorypoint[0] == 1)
                {
                    Console.Clear();
                    if (Program.IsEquipped[0] == "[E]")
                    {
                        Program.IsEquipped[0] = Program.IsEquipped[3];
                        Program.inventory[0] = $"{Program.IsEquipped[0]}{Program.itname[0]} \t {Program.itnumber[0]} \t {Program.itcom[0]}";
                        Program.PlayerSheield -= 5;
                    }
                    else
                    {
                        Program.IsEquipped[0] = "[E]";
                        Program.inventory[0] = $"{Program.IsEquipped[0]}{Program.itname[0]} \t {Program.itnumber[0]} \t {Program.itcom[0]}";
                        Program.PlayerSheield += 5;
                    }
                    continue;
                }
                if (input3 == "2" && Program.inventorypoint[1] == 1)
                {
                    Console.Clear();
                    if (Program.IsEquipped[1] == "[E]")
                    {
                        Program.IsEquipped[1] = Program.IsEquipped[3];
                        Program.inventory[1] = $"{Program.IsEquipped[1]}{Program.itname[1]} \t {Program.itnumber[1]} \t {Program.itcom[1]}";
                        Program.PlayerSheield -= 9;
                    }
                    else
                    {
                        Program.IsEquipped[1] = "[E]";
                        Program.inventory[1] = $"{Program.IsEquipped[1]}{Program.itname[1]} \t {Program.itnumber[1]} \t {Program.itcom[1]}";
                        Program.PlayerSheield += 9;
                    }
                    continue;
                }
                if (input3 == "3" && Program.inventorypoint[2] == 1)
                {
                    Console.Clear();
                    if (Program.IsEquipped[2] == "[E]")
                    {
                        Program.IsEquipped[2] = Program.IsEquipped[3];
                        Program.inventory[2] = $"{Program.IsEquipped[2]}{Program.itname[2]} \t {Program.itnumber[2]} \t {Program.itcom[2]}";
                        Program.PlayerSheield -= 15;
                    }
                    else
                    {
                        Program.IsEquipped[2] = "[E]";
                        Program.inventory[2] = $"{Program.IsEquipped[2]}{Program.itname[2]} \t {Program.itnumber[2]} \t {Program.itcom[2]}";
                        Program.PlayerSheield += 15;
                    }
                    continue;
                }
                if (input3 == "4" && Program.inventorypoint[4] == 1)
                {
                    Console.Clear();
                    if (Program.IsEquipped[4] == "[E]")
                    {
                        Program.IsEquipped[4] = Program.IsEquipped[3];
                        Program.inventory[4] = $"{Program.IsEquipped[4]}{Program.itname[4]} \t {Program.itnumber[4]} \t {Program.itcom[4]}";
                        Program.PlayerAttack -= 2;
                    }
                    else
                    {
                        Program.IsEquipped[4] = "[E]";
                        Program.inventory[4] = $"{Program.IsEquipped[4]}{Program.itname[4]} \t {Program.itnumber[4]} \t {Program.itcom[4]}";
                        Program.PlayerAttack += 2;
                    }
                    continue;
                }
                if (input3 == "5" && Program.inventorypoint[5] == 1)
                {
                    Console.Clear();
                    if (Program.IsEquipped[5] == "[E]")
                    {
                        Program.IsEquipped[5] = Program.IsEquipped[3];
                        Program.inventory[5] = $"{Program.IsEquipped[5]}{Program.itname[5]} \t {Program.itnumber[5]} \t {Program.itcom[5]}";
                        Program.PlayerAttack -= 5;
                    }
                    else
                    {
                        Program.IsEquipped[5] = "[E]";
                        Program.inventory[5] = $"{Program.IsEquipped[5]}{Program.itname[5]} \t {Program.itnumber[5]} \t {Program.itcom[5]}";
                        Program.PlayerAttack += 5;
                    }
                    continue;
                }
                if (input3 == "6" && Program.inventorypoint[6] == 1)
                {
                    Console.Clear();
                    if (Program.IsEquipped[6] == "[E]")
                    {
                        Program.IsEquipped[6] = Program.IsEquipped[3];
                        Program.inventory[6] = $"{Program.IsEquipped[6]}{Program.itname[6]} \t {Program.itnumber[6]} \t {Program.itcom[6]}";
                        Program.PlayerAttack -= 7;
                    }
                    else
                    {
                        Program.IsEquipped[6] = "[E]";
                        Program.inventory[6] = $"{Program.IsEquipped[6]}{Program.itname[6]} \t {Program.itnumber[6]} \t {Program.itcom[6]}";
                        Program.PlayerAttack += 7;
                    }
                    continue;
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
