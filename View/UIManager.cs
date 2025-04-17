public class UIManager
{
    //메뉴관련
    public void ShowMainMenu(String name)
    {
        Console.WriteLine($"고슴도치 마을에 오신 [ {name} ]님 환영합니다.");
        Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
        Console.WriteLine("1. 상태 보기\n2. 인벤토리\n3. 상점");
    }
    public string GetMenuSelection()
    {
        Console.WriteLine("\n원하시는 행동을 입력해주세요.");
        Console.Write(">>");
        return Console.ReadLine();
    }
    public void ShowWarning()
    {
        Console.WriteLine("\n잘못입력하셨습니다. 다시 입력하세요:)");
    }

    //플레이어관련
    public string GetPlayerName()
    {
        Console.Write("플레이어의 이름을 입력하세요:");
        return Console.ReadLine();
    }
    public void ShowPlayerState(Player player)
    {
            Console.WriteLine($"Lv.{player.Level} [ {player.Name} ]");
            Console.WriteLine($"\nChad : {player.Job}");
            Console.WriteLine($"공격력 : {player.AttackPower}");
            Console.WriteLine($"방어력 : {player.Defense}");
            Console.WriteLine($"체력 : {player.Hp}");
            Console.WriteLine($"Gold : {player.Gold}");

            Console.WriteLine($"\n0. 나가기");
    }
}