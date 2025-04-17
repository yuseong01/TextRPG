using Microsoft.Win32.SafeHandles;

public class Player{
    //속성
    public int Level {get; set;}
    public string Name {get; set;}
    public string Job {get; private set;}

    public int AttackPower {get; set;}
    public int Defense {get; set;}
    public int Hp {get; set;}
    public int Gold {get; set;}

    InventoryManager inventory;
    
    public Player(string job, InventoryManager inventory)
    {
        Job = job;
        this.inventory = inventory; // 플레이어 아이템
    
        Level = 1;
        AttackPower = 10;
        Defense = 5;
        Hp = 100;
        Gold = 1500;
    }


}