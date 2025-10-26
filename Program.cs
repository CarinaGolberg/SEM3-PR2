using PR1_SEM3_LOGIC;
using System;


namespace PR1_SEM3_CORE.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new PPLibraryLogic();
         
            //Инициализация строкового массива пунктов меню
            string[] menuItems = {"\n=== Ядовитый сад 'Alnwick' ===",
                                  "1. Добавить растение:",
                                  "2. Показать все растения:",
                                  "3. Найти растение по Id:",
                                  "4. Редактировать характеристики растения:",
                                  "5. Удалить растение:",
                                  "6. Группировка растений по уровню токсичности:",
                                  "7. Поиск растения по ядовитой части:",
                                  "8. Выход." };

            //Переменные выбора пункта меню
            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;


            while (true)
            {
                DrawMenu(menuItems, row, col, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        if (index < menuItems.Length - 1) index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0) index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (index)
                        {
                            case 8:
                                return;
                            default:
                                Console.WriteLine();
                                switch (index)
                                {
                                    case 1:
                                        foreach (var p in logic.GetAllPlants())
                                        {
                                            Console.WriteLine(p);
                                        }

                                        int id = ReadUniqueId(logic);

                                        Console.Write("Название: ");
                                        string name = Console.ReadLine();

                                        Console.Write("Латинское название: ");
                                        string latinName = Console.ReadLine();

                                        Console.Write("Семейство: ");
                                        string nativeRegion = Console.ReadLine();

                                        Console.Write("Основная ядовитая часть: ");
                                        string toxin = Console.ReadLine();

                                        Console.Write("Уровень опасности: ");
                                        string dangerLevel = Console.ReadLine();

                                        Console.Write("Симптомы отравления: ");
                                        string symptoms = Console.ReadLine();

                                        logic.AddPlant(id, name, latinName, nativeRegion, toxin, dangerLevel, symptoms);
                                        Console.Write($"Растение '{name}' с ID '{id}' добавлено!");
                                        break;

                                    case 2:
                                        foreach (var p in logic.GetAllPlants())
                                        {
                                            Console.WriteLine(p);
                                        }
                                        break;

                                    case 3:
                                        Console.Write("Введите Id: ");
                                        int searchId = int.Parse(Console.ReadLine());
                                        var found = logic.GetPlantById(searchId);
                                        Console.WriteLine(found != null ? found.ToString() : "Растение не найдено.");
                                        break;

                                    case 4:
                                        Console.Write("Введите Id растения, характеристики которого Вы хотите изменить:\n");
                                        foreach (var b in logic.GetAllPlants())
                                            Console.WriteLine(b);

                                        if (!int.TryParse(Console.ReadLine(), out int updateId))
                                        {
                                            Console.WriteLine("Ошибка: Id должно быть числом!");
                                            break;
                                        }

                                        var plantToUpdate = logic.GetPlantById(updateId);
                                        if (plantToUpdate == null)
                                        {
                                            Console.WriteLine("Растение не найдено.");
                                            break;
                                        }

                                        Console.WriteLine($"Редактируем характеристики растения: {plantToUpdate}");

                                        bool editing = true;
                                        while (editing)
                                        {
                                            Console.WriteLine("\nЧто вы хотите изменить?");
                                            Console.WriteLine("1. Название");
                                            Console.WriteLine("2. Латинское название");
                                            Console.WriteLine("3. Семейство");
                                            Console.WriteLine("4. Наиболее ядовитая часть");
                                            Console.WriteLine("5. Уровень токсичности");
                                            Console.WriteLine("6. Симптомы отравления");
                                            Console.WriteLine("7. Сохранить изменения и выйти");
                                            Console.Write("Ваш выбор: ");

                                            string editChoice = Console.ReadLine();
                                            switch (editChoice)
                                            {
                                                case "1":
                                                    Console.Write("Введите новое название: ");
                                                    plantToUpdate.Name = Console.ReadLine();
                                                    Console.Clear();
                                                    break;

                                                case "2":
                                                    Console.Write("Введите латинское название: ");
                                                    plantToUpdate.LatinName = Console.ReadLine();
                                                    Console.Clear();
                                                    break;

                                                case "3":
                                                    Console.Write("Семейство: ");
                                                    plantToUpdate.NativeRegion = Console.ReadLine();
                                                    Console.Clear();
                                                    break;

                                                case "4":
                                                    Console.Write("Основная ядовитая часть: ");
                                                    string Updatetoxin = Console.ReadLine();
                                                    Console.Clear();
                                                    break;

                                                case "5":
                                                    Console.Write("Введите уровень токсичности: ");
                                                    string UpDangerLevel = Console.ReadLine();
                                                    plantToUpdate.DangerLevel = UpDangerLevel;
                                                    Console.Clear();
                                                    break;

                                                case "6":
                                                    Console.Write("Симптомы отравления: ");
                                                    plantToUpdate.Symptoms = Console.ReadLine();
                                                    Console.Clear();
                                                    break;

                                                case "7":
                                                    logic.UpdatePlant(plantToUpdate.Id, plantToUpdate.Name, plantToUpdate.LatinName, plantToUpdate.NativeRegion, plantToUpdate.Toxin, 
                                                        plantToUpdate.DangerLevel, plantToUpdate.Symptoms);
                                                    Console.WriteLine("Изменения сохранены!");
                                                    editing = false; // выходим из цикла
                                                    Console.Clear();
                                                    break;

                                                default:
                                                    Console.WriteLine("Неверный выбор!");
                                                    Console.Clear();
                                                    break;
                                            }
                                        }
                                        break;

                                    case 5:
                                        Console.Write("Введите Id растения, которое хотите удалить:\n");
                                        foreach (var b in logic.GetAllPlants())
                                            Console.WriteLine(b);

                                        int deletedId = Convert.ToInt32(Console.ReadLine());

                                        bool deleted = logic.DeletePlant(deletedId);
                                        Console.WriteLine(deleted ? "Растение удалено" : "Растение не найдено");
                                        break;

                                    case 6:
                                        var groups = logic.GroupByDangerLevel();
                                        foreach (var g in groups)
                                        {
                                            Console.WriteLine($"\nУровень токсичности: {g.Key}");
                                            foreach (var b in g.Value)
                                            {
                                                Console.WriteLine($" {b}");
                                            }
                                        }
                                        break;

                                    case 7:
                                        string Searchtoxin = Console.ReadLine();
                                        //string[] Searchtoxins = { "Корень", "Стебель", "Листья", "Цветок", "Плод", "Семена" };
                                        //string Searchtoxin = logic.ChooseFromList("Выберите основную ядовитую часть (номер):", Searchtoxins);
                                        var result = logic.FindByToxin(Searchtoxin);
                                        if (result.Count == 0)
                                            Console.WriteLine("Таких растений не найдено.");
                                        else
                                            result.ForEach(Console.WriteLine);
                                        break;
                                }
                                break;
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;

                }
            }


        }

        //Проверка Id на уникальность.
        static int ReadUniqueId(PPLibraryLogic logic)
        {
            while(true)
            {
                Console.WriteLine("Введите уникальный ID: ");
                if (int.TryParse(Console.ReadLine(),out int id))
                {
                    if (id > 0)
                        if (!logic.ExistsId(id))
                        {
                            return id;
                        }
                        else
                        {
                            Console.WriteLine("Такой ID уже существует! Введите другой.");
                        }
                    else
                        Console.WriteLine("Введите положительное число.");
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Введите число.");
                }
            }
        }

        //Переходы по меню
        static void DrawMenu(string[] menuItems, int row, int col, int index)
        {
            Console.SetCursorPosition(col, row);

            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.WriteLine(menuItems[i]); //Вывод позиций меню
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine("=================================");

        }
    }
}
