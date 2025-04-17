using Microsoft.Win32.SafeHandles;

public class Player{
    //속성
    public int Level {get; set;}
    public string Name {get; set;}
    public string Job {get; set;}

    public int AttackPower {get; set;}
    public int Defense {get; set;}
    public int Hp {get; set;}
    public int Gold {get; set;}

    InventoryManager inventory;
    UIManager ui;

    
    public Player(InventoryManager inventor, UIManager ui)
    {
        this.inventory = inventory; // 플레이어 아이템
        this.ui = ui;

        Job = "전사";
        Level = 1;
        AttackPower = 10;
        Defense = 5;
        Hp = 100;
        Gold = 1500;
    }

    public void ShowPlayerState()   
    {
        while (true)
        {
            Thread.Sleep(700);
            Console.Clear();

            ui.ShowPlayerState(this);
            string input = ui.GetMenuSelection();

            if (input == "0") break;
            else ui.ShowWarning();
        }
    }

}