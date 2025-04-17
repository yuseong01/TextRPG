public class GameManager{
    UIManager ui = new UIManager();  //입출력 담당
    Player player = new Player();
    Shop shop = new Shop();
    InventoryManager inventory = new InventoryManager();
    
    public void Run() {
        while (true) 
        {
            Thread.Sleep(700);
            Console.Clear();
            ui.ShowMainMenu();
            
            string userInput = ui.GetMenuSelection();
            int selectedMenuNumber;

            if(!int.TryParse(userInput, out selectedMenuNumber) || selectedMenuNumber<1||selectedMenuNumber>3)
            {
                ui.ShowWarning();
            }
            else 
            {
                switch (selectedMenuNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }

        }

    
    }
}