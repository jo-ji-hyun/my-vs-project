namespace ConsoleApp2
{
    internal class Program
    {
        public static int PlayerAttack = 0;
        public static int PlayerSheield = 0;

        public static int PlayerMoney = 150000;

        public static List<string> itname = new List<string>();

        public static List<string> itnumber = new List<string>();

        public static List<string> itcom = new List<string>();

        public static List<string> it = new List<string>();

        public static List<string> IsEquipped = new List<string>();

        public static List<string> inventory = new List<string>();

        public static int[] inventorypoint = new int[8];

        public static int buypoint = 0;
        

        static void Main(string[] args)
        {

            itname.Add("1. 수련자 갑옷    ");
            itname.Add("2. 무쇠 갑옷      ");
            itname.Add("3. 스파르타의 갑옷");
            itname.Add("            ");
            itname.Add("4. 낡은 검        ");
            itname.Add("5. 청동 도끼      ");
            itname.Add("6. 스파르타의 창  ");

            itnumber.Add("방어력 + 5  ");
            itnumber.Add("방어력 + 9  ");
            itnumber.Add("방어력 + 15 ");
            itnumber.Add("            ");
            itnumber.Add("공격력 + 2  ");
            itnumber.Add("공격력 + 5  ");
            itnumber.Add("공격력 + 7  ");
            

            itcom.Add("수련에 도움을 주는 갑옷입니다.                    ");
            itcom.Add("무쇠로 만들어져 튼튼한 갑옷입니다.                ");
            itcom.Add("스파르타의 전사들이 사용했다는 전설의 갑옷입니다. ");
            itcom.Add("                                                  ");
            itcom.Add("쉽게 볼 수 있는 낡은 검 입니다.                   ");
            itcom.Add("어디선가 사용됐던거 같은 도끼입니다.              ");
            itcom.Add("스파르타의 전사들이 사용했다는 전설의 창입니다.   ");

            it.Add("1000 G");
            it.Add("2000 G");
            it.Add("3500 G");
            it.Add("      ");
            it.Add("600 G ");
            it.Add("1500 G");
            it.Add("3000 G");
            it.Add("구매 완료");

            IsEquipped.Add("[E]");
            IsEquipped.Add("[E]");
            IsEquipped.Add("[E]");
            IsEquipped.Add("   ");
            IsEquipped.Add("[E]");
            IsEquipped.Add("[E]");
            IsEquipped.Add("[E]");

            inventory.Add($"{IsEquipped[0]}{itname[0]}  \t {itnumber[0]}  \t {itcom[0]}");
            inventory.Add($"{IsEquipped[1]}{itname[1]}  \t {itnumber[1]}  \t {itcom[1]}");
            inventory.Add($"{IsEquipped[2]}{itname[2]}  \t {itnumber[2]}  \t {itcom[2]}");
            inventory.Add($"");
            inventory.Add($"{IsEquipped[4]}{itname[4]}  \t {itnumber[4]}  \t {itcom[4]}");
            inventory.Add($"{IsEquipped[5]}{itname[5]}  \t {itnumber[5]}  \t {itcom[5]}");
            inventory.Add($"{IsEquipped[6]}{itname[6]}  \t {itnumber[6]}  \t {itcom[6]}");

            Menu();

        }

        public static void Menu()
        {
            bool isgame = true;

            while (isgame == true)
            {
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태창!");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine();
                Console.Write("원하시는 행동을 입력해주세요.\n>>");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Status();
                        break;
                    case "2":
                        Inventory();
                        break;
                    case "3":
                        Store();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("잘못된 입력입니다.");
                        Console.WriteLine();
                        break;
                }

            }
        }

        public static void Status()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("상태창!");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                Console.WriteLine();
                Console.WriteLine("Lv. 01");
                Console.WriteLine("Chad (전사)");
                Console.WriteLine($"공격력 : 10 (+{PlayerAttack})");
                Console.WriteLine($"방어력 : 5  (+{PlayerSheield})");
                Console.WriteLine("체력 : 100");
                Console.WriteLine($"Gold : {PlayerMoney} G");
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

        public static void Display()
        { 
            for (int i = 0; i < 7; i++) 
            {
                if (inventorypoint[i] == 1)
                {
                    Console.WriteLine(inventory[i]);
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
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.Write("원하시는 행동을 입력해주세요.\n>>");
                string input3 = Console.ReadLine();
                if (input3 == "0")
                {
                    Console.Clear();
                    return;
                }
                if(input3 == "1" && inventorypoint[0] == 1)
                {
                    Console.Clear();
                    if (IsEquipped[0] == "[E]")
                    {
                        IsEquipped[0] = IsEquipped[3];
                        inventory[0] = $"{IsEquipped[0]}{itname[0]} \t {itnumber[0]} \t {itcom[0]}";
                        PlayerSheield -= 5;
                    }
                    else
                    {
                        IsEquipped[0] = "[E]";
                        inventory[0] = $"{IsEquipped[0]}{itname[0]} \t {itnumber[0]} \t {itcom[0]}";
                        PlayerSheield += 5;
                    }
                }
                if(input3 == "2" && inventorypoint[1] == 1)
                {
                    Console.Clear();
                    if (IsEquipped[1] == "[E]")
                    {
                        IsEquipped[1] = IsEquipped[3];
                        inventory[1] = $"{IsEquipped[1]}{itname[1]} \t {itnumber[1]} \t {itcom[1]}";
                        PlayerSheield -= 9;
                    }
                    else
                    {
                        IsEquipped[1] = "[E]";
                        inventory[1] = $"{IsEquipped[1]}{itname[1]} \t {itnumber[1]} \t {itcom[1]}";
                        PlayerSheield += 9;
                    }
                }
                if(input3 == "3" && inventorypoint[2] == 1)
                {
                    Console.Clear();
                    if (IsEquipped[2] == "[E]")
                    {
                        IsEquipped[2] = IsEquipped[3];
                        inventory[2] = $"{IsEquipped[2]}{itname[2]} \t {itnumber[2]} \t {itcom[2]}";
                        PlayerSheield -= 15;
                    }
                    else
                    {
                        IsEquipped[2] = "[E]";
                        inventory[2] = $"{IsEquipped[2]}{itname[2]} \t {itnumber[2]} \t {itcom[2]}";
                        PlayerSheield += 15;
                    }
                }
                if(input3 == "4" && inventorypoint[4] == 1)
                {
                    Console.Clear();
                    if (IsEquipped[4] == "[E]")
                    {
                        IsEquipped[4] = IsEquipped[3];
                        inventory[4] = $"{IsEquipped[4]}{itname[4]} \t {itnumber[4]} \t {itcom[4]}";
                        PlayerAttack -= 2;
                    }
                    else
                    {
                        IsEquipped[4] = "[E]";
                        inventory[4] = $"{IsEquipped[4]}{itname[4]} \t {itnumber[4]} \t {itcom[4]}";
                        PlayerAttack += 2;
                    }
                }
                if(input3 == "5" && inventorypoint[5] == 1)
                {
                    Console.Clear();
                    if (IsEquipped[5] == "[E]")
                    {
                        IsEquipped[5] = IsEquipped[3];
                        inventory[5] = $"{IsEquipped[5]}{itname[5]} \t {itnumber[5]} \t {itcom[5]}";
                        PlayerAttack -= 5;
                    }
                    else
                    {
                        IsEquipped[5] = "[E]";
                        inventory[5] = $"{IsEquipped[5]}{itname[5]} \t {itnumber[5]} \t {itcom[5]}";
                        PlayerAttack += 5;
                    }
                }
                if(input3 == "6" && inventorypoint[6] == 1)
                {
                    Console.Clear();
                    if (IsEquipped[6] == "[E]")
                    {
                        IsEquipped[6] = IsEquipped[3];
                        inventory[6] = $"{IsEquipped[6]}{itname[6]} \t {itnumber[6]} \t {itcom[6]}";
                        PlayerAttack -= 7;
                    }
                    else
                    {
                        IsEquipped[6] = "[E]";
                        inventory[6] = $"{IsEquipped[6]}{itname[6]} \t {itnumber[6]} \t {itcom[6]}";
                        PlayerAttack += 7;
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

        public static void Store()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("상점");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine($"{PlayerMoney} G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine($"{itname[i]}   \t {itnumber[i]}  \t {itcom[i]}  \t {it[i]}");
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
                Console.WriteLine($"{PlayerMoney} G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("번호로 아이템 구매");
                Console.WriteLine();
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine($"{itname[i]}   \t {itnumber[i]}  \t {itcom[i]}  \t {it[i]}");
                }
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
                    if (PlayerMoney >= 1000 && it[0] != it[7])
                    {
                        Console.Clear();
                        it[0] = it[7];
                        inventorypoint[0] = 1;
                        I_tem(1);
                    }
                    else if (it[0] == it[7])
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
                    if (PlayerMoney >= 2000 && it[1] != it[7])
                    {
                        Console.Clear();
                        it[1] = it[7];
                        inventorypoint[1] = 1;
                        I_tem(2);
                    }
                    else if (it[1] == it[7])
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
                    if (PlayerMoney >= 3500 && it[2] != it[7])
                    {
                        Console.Clear();
                        it[2] = it[7];
                        inventorypoint[2] = 1;
                        I_tem(3);
                    }
                    else if (it[2] == it[7])
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
                    if (PlayerMoney >= 600 && it[4] != it[7])
                    {
                        Console.Clear();
                        it[4] = it[7];
                        inventorypoint[4] = 1;
                        I_tem(4);
                    }
                    else if (it[4] == it[7])
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
                    if (PlayerMoney >= 1500 && it[5] != it[7])
                    {
                        Console.Clear();
                        it[5] = it[7];
                        inventorypoint[5] = 1;
                        I_tem(5);
                    }
                    else if (it[5] == it[7])
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
                    if (PlayerMoney >= 3000 && it[6] != it[7])
                    {
                        Console.Clear();
                        it[6] = it[7];
                        inventorypoint[6] = 1;
                        I_tem(6);
                    }
                    else if (it[6] == it[7])
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
                PlayerMoney -= 1000;
                PlayerSheield += 5;
                Console.WriteLine("구매 완료.");
                Console.WriteLine();
                Equipment();
            }
            if (item == 2)
            {
                PlayerMoney -= 2000;
                PlayerSheield += 9;
                Console.WriteLine("구매 완료.");
                Console.WriteLine();
                Equipment();
            }
            if (item == 3)
            {
                PlayerMoney -= 3500;
                PlayerSheield += 15;
                Console.WriteLine("구매 완료.");
                Console.WriteLine();
                Equipment();
            }
            if (item == 4)
            {
                PlayerMoney -= 600;
                PlayerAttack += 2;
                Console.WriteLine("구매 완료.");
                Console.WriteLine();
                Equipment();
            }
            if (item == 5)
            {
                PlayerMoney -= 1500;
                PlayerAttack += 5;
                Console.WriteLine("구매 완료.");
                Console.WriteLine();
                Equipment();
            }
            if (item == 6)
            {
                PlayerMoney -= 3000;
                PlayerAttack += 7;
                Console.WriteLine("구매 완료.");
                Console.WriteLine();
                Equipment();
            }

        }

    }
}
