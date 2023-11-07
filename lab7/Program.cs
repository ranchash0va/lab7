// Класс Program содержит точку входа в программу.
class Program
{
    static void Main()
    {
        // Создание объекта GameInventory для управления инвентарем игрока.
        GameInventory playerInventory = new GameInventory();
        // Создание объекта InventoryManager для управления пользовательским вводом и инвентарем.
        InventoryManager inventoryManager = new InventoryManager(playerInventory);

        // Цикл для ввода предметов пользователем до ввода 'exit'.
        while (true)
        {
            Console.WriteLine("Введите предмет для добавления в инвентарь (или 'exit' для выхода):");
            string input = Console.ReadLine();

            // Проверка на 'exit' для завершения ввода.
            if (input.ToLower() == "exit")
            {
                break;
            }

            // Вызов метода AddItemToInventory для добавления введенного предмета в инвентарь.
            inventoryManager.AddItemToInventory(input);
        }

        // Отображение содержимого инвентаря.
        inventoryManager.DisplayInventory();

        // Запрос пользователя на ввод предмета для удаления из инвентаря.
        Console.WriteLine("Введите предмет для удаления из инвентаря:");
        string itemToRemove = Console.ReadLine();

        // Вызов метода RemoveItemFromInventory для удаления введенного предмета из инвентаря.
        inventoryManager.RemoveItemFromInventory(itemToRemove);

        // Отображение обновленного содержимого инвентаря.
        inventoryManager.DisplayInventory();
    }
}