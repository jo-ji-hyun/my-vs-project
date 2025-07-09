namespace ConsoleApp2
{
    internal class Program
    {
        public static int PlayerMoney = 1500;
        
        static void Main(string[] args)
        {
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
                Console.WriteLine("공격력 : 10");
                Console.WriteLine("방어력 : 5");
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
                Console.WriteLine();
                Console.WriteLine("- 1 ");
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

            }
        }

        public static void Store()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("상점");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine("800 G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("- 수련자 갑옷   \t 방어력 +5 \t 수련에 도움을 주는 갑옷입니다.                 \t 1000 G");
                Console.WriteLine("- 무쇠 갑옷     \t 방어력 +9 \t 무쇠로 만들어져 튼튼한 갑옷입니다.              \t 2000 G");
                Console.WriteLine("- 스파르타의 갑옷 \t 방어력 +15 \t 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. \t 3500 G");
                Console.WriteLine("- 낡은 검       \t 방어력 +2 \t 쉽게 볼 수 있는 낡은 검 입니다.                  \t 600 G");
                Console.WriteLine("- 청동 도끼     \t 방어력 +5 \t 어디선가 사용됐던거 같은 도끼입니다.              \t 1500 G");
                Console.WriteLine("- 스파르타의 창 \t 방어력 +7 \t 스파르타의 전사들이 사용했다는 전설의 창입니다.  \t 3000 G");
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
                Console.WriteLine("800 G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("1. 수련자 갑옷   \t 방어력 +5 \t 수련에 도움을 주는 갑옷입니다.                 \t 1000 G");
                Console.WriteLine("2. 무쇠 갑옷     \t 방어력 +9 \t 무쇠로 만들어져 튼튼한 갑옷입니다.              \t 2000 G");
                Console.WriteLine("3. 스파르타의 갑옷 \t 방어력 +15 \t 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. \t 3500 G");
                Console.WriteLine("4. 낡은 검       \t 방어력 +2 \t 쉽게 볼 수 있는 낡은 검 입니다.                  \t 600 G");
                Console.WriteLine("5. 청동 도끼     \t 방어력 +5 \t 어디선가 사용됐던거 같은 도끼입니다.              \t 1500 G");
                Console.WriteLine("6. 스파르타의 창 \t 방어력 +7 \t 스파르타의 전사들이 사용했다는 전설의 창입니다.  \t 3000 G");
                Console.WriteLine();
                Console.WriteLine("원하시는 아이템 구매");
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
                    Console.Clear();
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
