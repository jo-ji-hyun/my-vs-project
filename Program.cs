namespace ConsoleApp2
{
    internal class Program
    {
        public static int PlayerAttack = 0;
        public static int PlayerSheield = 0;

        public static int PlayerMoney = 150000; //실험을위해 돈복사

        public static string[] itname = new string[7];

        public static string[] itnumber = new string[7];

        public static string[] itcom = new string[7];

        public static string[] it = new string[8];

        public static string[] IsEquipped = new string[7];

        public static string[] inventory = new string[7];

        public static int[] inventorypoint = new int[8];

        public static int buypoint = 0;

        static void Main(string[] args)
        {

            itname[0] = "1. 수련자 갑옷    ";
            itname[1] = "2. 무쇠 갑옷      ";
            itname[2] = "3. 스파르타의 갑옷";
            itname[3] = "                  ";
            itname[4] = "4. 낡은 검        ";
            itname[5] = "5. 청동 도끼      ";
            itname[6] = "6. 스파르타의 창  ";

            itnumber[0] = "방어력 + 5  ";
            itnumber[1] = "방어력 + 9  ";
            itnumber[2] = "방어력 + 15 ";
            itnumber[3] = "            ";
            itnumber[4] = "공격력 + 2  ";
            itnumber[5] = "공격력 + 5  ";
            itnumber[6] = "공격력 + 7  ";
            

            itcom[0] = "수련에 도움을 주는 갑옷입니다.                    ";
            itcom[1] = "무쇠로 만들어져 튼튼한 갑옷입니다.                ";
            itcom[2] = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다. ";
            itcom[3] = "                                                  ";
            itcom[4] = "쉽게 볼 수 있는 낡은 검 입니다.                   ";
            itcom[5] = "어디선가 사용됐던거 같은 도끼입니다.              ";
            itcom[6] = "스파르타의 전사들이 사용했다는 전설의 창입니다.   ";

            it[0] = "1000 G";
            it[1] = "2000 G";
            it[2] = "3500 G";
            it[3] = "      ";
            it[4] = "600 G ";
            it[5] = "1500 G";
            it[6] = "3000 G";
            it[7] = "구매 완료";

            IsEquipped[0] = "[E]";
            IsEquipped[1] = "[E]";
            IsEquipped[2] = "[E]";
            IsEquipped[3] = "   ";
            IsEquipped[4] = "[E]";
            IsEquipped[5] = "[E]";
            IsEquipped[6] = "[E]";

            inventory[0] = $"{IsEquipped[0]}{itname[0]}  \t {itnumber[0]}  \t {itcom[0]}";
            inventory[1] = $"{IsEquipped[1]}{itname[1]}  \t {itnumber[1]}  \t {itcom[1]}";
            inventory[2] = $"{IsEquipped[2]}{itname[2]}  \t {itnumber[2]}  \t {itcom[2]}";
            inventory[3] = $"";
            inventory[4] = $"{IsEquipped[4]}{itname[4]}  \t {itnumber[4]}  \t {itcom[4]}";
            inventory[5] = $"{IsEquipped[5]}{itname[5]}  \t {itnumber[5]}  \t {itcom[5]}";
            inventory[6] = $"{IsEquipped[6]}{itname[6]}  \t {itnumber[6]}  \t {itcom[6]}";
 
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
                        Status.Statuss();
                        break;
                    case "2":
                        Bag.Inventory();
                        break;
                    case "3":
                        ItemShop.Store();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("잘못된 입력입니다.");
                        Console.WriteLine();
                        break;
                }

            }
        }
       

    }
    internal class Item
    {
        public string Name { get; }
        public string StatusBonus { get; }
        public string Comment{ get; }
        public string Price { get; }

        public Item(string name, string statusbonus, string comment, string price)
        {
            Name = name;
            StatusBonus = statusbonus;
            Comment = comment;
            Price = price; 
        }
    }
    //미완성
}
