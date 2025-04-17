class Item{
    public string Name { get; private set; }
    public string Type{ get; private set; }
    public string Stat { get; private set; }
    public string Description { get; private set; }
    public int Price { get; private set; }
    public bool IsEquipped { get; set; }
    public bool isPurchased { get; set; }

    public Item(string name, string type, string stat, string description, int price, bool isEquipped, bool isPurchased)
    {
        Name = name;
        Type = type;
        Stat = stat;
        Description = description;
        Price = price;
        IsEquipped = false;
        IsPurchased = false;
    }
    
}