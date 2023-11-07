// Класс GameInventory отвечает за управление инвентарем игрока.
class GameInventory
{
    private HashSet<string> inventory;

    // Конструктор класса GameInventory, инициализирует инвентарь как HashSet<string>.
    public GameInventory()
    {
        inventory = new HashSet<string>();
    }

    // Метод для добавления предмета в инвентарь.
    public void AddItem(string item)
    {
        inventory.Add(item);
    }

    // Метод для удаления предмета из инвентаря.
    public bool RemoveItem(string item)
    {
        return inventory.Remove(item);
    }

    // Метод для проверки наличия предмета в инвентаре.
    public bool ContainsItem(string item)
    {
        return inventory.Contains(item);
    }

    // Метод для получения всех предметов в инвентаре.
    public IEnumerable<string> GetInventoryItems()
    {
        return inventory;
    }
}