public class InventoryManager{
    public UIManager ui;
    public List<Item> ItemLists {get; set;}

    public InventoryManager(UIManager ui)
    {
        this.ui = ui;
        ItemLists = new List<Item>();
        ItemLists.Add(new Item("수련자 갑옷", "방어력", 5, "수련에 도움을 주는 갑옷입니다.", 1000));
        ItemLists.Add(new Item("무쇠갑옷", "방어력", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 1000));
        ItemLists.Add(new Item("스파르타의 갑옷", "방어력", 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500));
        ItemLists.Add(new Item("낡은 검","공격력", 2, "쉽게 볼 수 있는 낡은 검 입니다.", 600));
        ItemLists.Add(new Item("청동 도끼","공격력",5,"어디선가 사용됐던거 같은 도끼입니다.", 1500));
        ItemLists.Add(new Item("스파르타의 창", "공격력", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 2000));
    }
    

    public void ShowInventoryStateFlow()
    {
        while(true)
        {
            Thread.Sleep(700);
            Console.Clear();

            ui.ShowInventoryMenu();
            string input = ui.GetMenuSelection();

            if (input == "0")
            {
                break;
            } 
            else if (input == "1") 
            {
                ManageEquipItem();
            }
            else ui.ShowWarning();
        }
        
    }
    public void ManageEquipItem()
    {
        while(true)
        {
            Thread.Sleep(700);
            Console.Clear();

            ui.ShowPlayerEquipItem(ItemLists);
            string input = ui.GetMenuSelection();
            if (input == "0")
            {
                break;
            } 

            if (int.TryParse(input, out int index)) 
            {
                if(index >=1 && index <ItemLists.Count+1)
                {
                    if(ItemLists[index-1].IsEquipped)
                    {
                        ItemLists[index-1].IsEquipped = false;
                    }
                    else
                    {
                        ItemLists[index-1].IsEquipped = true;
                    } 
                }
                else
                {
                    ui.ShowWarning();
                }
            }
            else ui.ShowWarning();
        }
    }

}