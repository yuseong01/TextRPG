using Microsoft.Win32.SafeHandles;

public class Player{
    //속성
    public int Level {get; set;}
    public string Name {get; set;}
    public string Job {get; set;}

    public int BaseAttackPower {get; set;}
    public int BaseDefense {get; set;}
    public int AttackPower {get; set;}
    public int Defense {get; set;}

    public int Hp {get; set;}
    public int Gold {get; set;}

    UIManager ui;
    InventoryManager inventory;
    
    public Player(UIManager ui, InventoryManager inventory)
    {
        this.ui = ui;
        this.inventory = inventory;

        Job = "전사";
        Level = 1;
        BaseAttackPower = 10;
        BaseDefense = 5;
        AttackPower =0;
        Defense = 0;
        Hp = 100;
        Gold = 1500;
    }

    public void ShowPlayerStateFlow()
    {
        UpdatePlayerStates();
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

    public void UpdatePlayerStates()
    {
        AttackPower = 0;
        Defense = 0;

        foreach(var item in inventory.ItemLists)
        {
            if(item.IsEquipped)
            {
                if(item.Type == "공격력")
                {
                    AttackPower+=item.Stat;
                }
                else if(item.Type == "방어력")
                {
                    Defense += item.Stat;
                }
            }
        }
    }
}