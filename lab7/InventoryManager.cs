// Класс InventoryManager отвечает за управление вводом пользователя и взаимодействием с GameInventory.
class InventoryManager
{
    private GameInventory gameInventory;

    // Конструктор класса InventoryManager, принимает объект GameInventory для управления инвентарем.
    public InventoryManager(GameInventory inventory)
    {
        gameInventory = inventory;
    }

    // Метод для добавления предмета в инвентарь и вывода сообщения о добавлении.
    public void AddItemToInventory(string item)
    {
        gameInventory.AddItem(item);
        Console.WriteLine($"Предмет '{item}' добавлен в инвентарь.");
    }

    // Метод для удаления предмета из инвентаря и вывода соответствующего сообщения.
    public void RemoveItemFromInventory(string item)
    {
        if (gameInventory.RemoveItem(item))
        {
            Console.WriteLine($"Предмет '{item}' удален из инвентаря.");
        }
        else
        {
            Console.WriteLine($"Предмет '{item}' не найден в инвентаре.");
        }
    }

    // Метод для отображения содержимого инвентаря.
    public void DisplayInventory()
    {
        Console.WriteLine("Инвентарь игрока:");
        foreach (var item in gameInventory.GetInventoryItems())
        {
            Console.WriteLine(item);
        }
    }
}