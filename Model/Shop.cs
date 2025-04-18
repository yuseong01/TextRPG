public class Shop{
    UIManager ui;
    Player player;
    InventoryManager inventory;

    public Shop(UIManager ui, Player player, InventoryManager inventory)
    {
        this.ui = ui;
        this.player = player;
        this.inventory = inventory;
    }
    public void ShowShopStateFlow()
    {
        while(true)
        {
            Thread.Sleep(700);
            Console.Clear();
            
            ui.ShowShopMenu(player, inventory.ItemLists);
            string input = ui.GetMenuSelection();

            if (input == "0")
            {
                break;
            } 
            else if (input == "1") 
            {
                BuyItemMenu();
            }
            else
            {
                ui.ShowWarning();
            } 

        }
    }
    public void BuyItemMenu()
    {
        while(true)
        {
            Thread.Sleep(700);
            Console.Clear();

            ui.ShowBuyItemMenu(player, inventory.ItemLists);
            string input= ui.GetMenuSelection();

            if (input == "0")
            {
                break;
            } 

            if(int.TryParse(input, out int index))
            {
                if(index>=1&&index<=inventory.ItemLists.Count+1)
                {
                    
                }
                else
                {
                    ui.ShowWarning();
                }
            }
            else
            {
                ui.ShowWarning();
            }
        }
    }

    public void BuyItem(Player player, Item item)
    {
        if(item.IsPurchased)
        {
            ui.ShowCurrentItemBuyState(0);
        }
        
        if(player.Gold >= item.Price)
        {
            ui.ShowCurrentItemBuyState(1);
            item.IsPurchased = true;
        }
        else
        {
            ui.ShowCurrentItemBuyState(2);
        }
    }
}