namespace ConsoleApp2
{
    internal class Program
    {
        public static int PlayerAttack = 0;
        public static int PlayerSheield = 0;

        public static int PlayerMoney = 150000; //실험을위해 돈복사

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
}
