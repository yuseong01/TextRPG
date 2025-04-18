using System.Reflection.Metadata;
using Microsoft.VisualBasic;

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
        Console.WriteLine($"공격력 : {player.BaseAttackPower + player.AttackPower} (+{player.AttackPower})");
        Console.WriteLine($"방어력 : {player.Defense + player.Defense} (+{player.Defense})");
        Console.WriteLine($"체력 : {player.Hp}");
        Console.WriteLine($"Gold : {player.Gold}");

        Console.WriteLine("\n0. 나가기");
    }

    //인벤토리
    public void ShowInventoryMenu()
    {
        Console.WriteLine("인벤토리");
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
        Console.WriteLine("1. 장착관리");
        Console.WriteLine("0. 나가기");
    }

    public void ShowPlayerEquipItem(List<Item> items)
    {
        Console.WriteLine("인벤토리 - 장착 관리");
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
        Console.WriteLine("[아이템 목록]");

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].IsPurchased)
            {
                if (items[i].IsEquipped)
                {
                    Console.WriteLine($"- {i + 1} [E]{items[i].Name} | {items[i].Type} | {items[i].Description}");

                }
                else
                {
                    Console.WriteLine($"- {i + 1} {items[i].Name} | {items[i].Type} | {items[i].Description}");
                }
            }
        }

        Console.WriteLine("\n0. 나가기");
    }

    //상점
    public void ShowShopMenu(Player player, List<Item> items)
    {
        Console.WriteLine("상점");
        Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");
        Console.WriteLine("[보유 골드]");
        Console.WriteLine($"{player.Gold} G\n");
        Console.WriteLine("[아이템 목록]");

        foreach (Item item in items)
        {
            if (item.IsPurchased)
            {
                Console.WriteLine($"- {item.Name} | {item.Type} +{item.Stat} | {item.Description} | 구매완료");

            }
            else
            {
                Console.WriteLine($"- {item.Name} | {item.Type} +{item.Stat} | {item.Description} | {item.Price} G");
            }
        }

        Console.WriteLine("\n1. 아이템 구매");
        Console.WriteLine("0. 나가기");
    }
    public void ShowBuyItemMenu(Player player, List<Item> items)
    {
        Console.WriteLine("상점 - 아이템구매");
        Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");
        Console.WriteLine("[보유 골드]");
        Console.WriteLine($"{player.Gold} G\n");
        Console.WriteLine("[아이템 목록]");

        for(int i=0; i<items.Count; i++)
        {
            if (items[i].IsPurchased)
            {
                Console.WriteLine($"- {i + 1} {items[i].Name} | {items[i].Type} +{items[i].Stat} | {items[i].Description} | 구매완료");
            }
            else
            {
                Console.WriteLine($"- {i + 1} {items[i].Name} | {items[i].Type} +{items[i].Stat} | {items[i].Description} | {items[i].Price} G");
            }
        }

        Console.WriteLine("\n0. 나가기");
    }

    public void ShowCurrentItemBuyState(BuyItemResult state)
    {
        switch (state)
        {
            case BuyItemResult.AlreadyBuy:
                Console.WriteLine("이미 구매한 아이템입니다.");
                break;
            case BuyItemResult.SuccessBuy:
                Console.WriteLine("구매를 완료했습니다.");
                break;
            case BuyItemResult.NotEnoughGold:
                Console.WriteLine("Gold가 부족합니다");
                break;
        }
    }
}