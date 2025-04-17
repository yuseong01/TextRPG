using Microsoft.VisualBasic.FileIO;

public class GameManager
{
    UIManager ui = new UIManager();  //입출력 담당
    Shop shop = new Shop();
    InventoryManager inventory = new InventoryManager();
    Player player;

    public GameManager()
    {
        player = new Player(inventory, ui); //1. 위에서 player객체 생성하면 오류남 
    }
    public void Run()
    {
        string playerName = ui.GetPlayerName();
        player.Name = playerName;

        while (true)
        {
            Thread.Sleep(700);
            Console.Clear();

            ui.ShowMainMenu(player.Name);

            string userInput = ui.GetMenuSelection();
            int selectedMenuNumber;

            if (!int.TryParse(userInput, out selectedMenuNumber) || selectedMenuNumber < 1 || selectedMenuNumber > 3)
            {
                ui.ShowWarning();
            }
            else
            {
                switch (selectedMenuNumber)
                {
                    case 1:
                        player.ShowPlayerStateFlow();
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