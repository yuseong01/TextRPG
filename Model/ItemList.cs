public class ItemList{
    public List<Item> ItemLists {get; set;}

    public ItemList(){
        ItemLists = new List<Item>();
        ItemLists.Add(new Item("수련자 갑옷", "방어력", 5, "수련에 도움을 주는 갑옷입니다.", 1000));
        ItemLists.Add(new Item("무쇠갑옷", "방어력", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 1000));
        ItemLists.Add(new Item("스파르타의 갑옷", "방어력", 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500));
        ItemLists.Add(new Item("낡은 검","공격력", 2, "쉽게 볼 수 있는 낡은 검 입니다.", 600));
        ItemLists.Add(new Item("청동 도끼","공격력",5,"어디선가 사용됐던거 같은 도끼입니다.", 1500));
        ItemLists.Add(new Item("스파르타의 창", "공격력", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 2000));
    }
}