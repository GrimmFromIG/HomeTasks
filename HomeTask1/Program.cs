class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть пункт за допомогою цифри - \n" +
                          "1. Додати студента \n" +
                          "2. Змінити дані про студента \n" +
                          "3. Переглянути список студентів \n" +
                          "4. Вийти з програми");

        StudentTable table = new StudentTable();
        bool running = true;

        while (running)
        {
            Console.Write("Ваш вибір: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введіть ім'я: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Введіть прізвище: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Введіть по батькові: ");
                    string middleName = Console.ReadLine();

                    table.AddStudent(new Student(firstName, lastName, middleName));
                    Console.WriteLine($"Студента додано! Його індекс: {table.StudentCount - 1}\n");
                    break;

                case "2":
                    Console.Write("Введіть індекс студента для редагування: ");
                    if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < table.StudentCount)
                    {
                        Console.Write("Введіть нове ім'я: ");
                        string newFirstName = Console.ReadLine();
                        Console.Write("Введіть нове прізвище: ");
                        string newLastName = Console.ReadLine();
                        Console.Write("Введіть нове по батькові: ");
                        string newMiddleName = Console.ReadLine();

                        table.UpdateStudent(index, newFirstName, newLastName, newMiddleName);
                        Console.WriteLine("Дані студента оновлено!\n");
                    }
                    else
                    {
                        Console.WriteLine("Помилка: Неправильний індекс!\n");
                    }
                    break;
                
                case "3":
                    Console.WriteLine("Список студентів:");
                    for (int i = 0; i < table.StudentCount; i++)
                    {
                        Console.WriteLine($"{i}: {table[i]}");
                    }
        
                    Console.WriteLine($"Кількість студентів: {table.StudentCount}");
                    break;
                    
                case "4":
                    running = false;
                    Console.WriteLine("Вихід з програми...");
                    break;

                default:
                    Console.WriteLine("Неправильний вибір. Спробуйте ще раз.\n");
                    break;
            }
        }
    }
}