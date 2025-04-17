public class UIManager{
    public void ShowMainMenu()
    {
        Console.WriteLine("고슴도치 마을에 오신 여러분 환영합니다.");
        Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
        Console.WriteLine("1. 상태 보기\n2. 인벤토리\n3. 상점");
    }
    public string GetMenuSelection() 
    {
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.Write(">>");
        return Console.ReadLine();
    }
    public void ShowWarning()
    {
        Console.WriteLine("잘못입력하셨습니다. 다시 입력하세요:)");
    }
}