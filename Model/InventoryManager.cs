public class InventoryManager{
    public ItemList items = new ItemList();
    UIManager ui;

    public InventoryManager(UIManager ui)
    {
        this.ui = ui;
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

            ui.ShowPlayerEquipItem(items);
            string input = ui.GetMenuSelection();
            if (input == "0")
            {
                break;
            } 

            if (int.TryParse(input, out int index)) 
            {
                if(index >=1 && index <items.ItemLists.Count+1)
                {
                    if(items.ItemLists[index-1].IsEquipped)
                    {
                        items.ItemLists[index-1].IsEquipped = false;
                    }
                    else
                    {
                        items.ItemLists[index-1].IsEquipped = true;
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