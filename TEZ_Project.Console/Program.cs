using System;

namespace TEZ_Project.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("=== TEZ Project Console Test ===");
            System.Console.WriteLine("Тестування логіки декомпільованого проекту...");
            
            try
            {
                // Тут можна тестувати логіку з Common проекту
                System.Console.WriteLine("✅ Проект успішно запущений!");
                System.Console.WriteLine("Доступні для тестування:");
                System.Console.WriteLine("- Моделі даних");
                System.Console.WriteLine("- Логіка обчислень");
                System.Console.WriteLine("- Допоміжні класи");
                
                System.Console.WriteLine("\nНатисніть Enter для виходу...");
                System.Console.ReadLine();
            }
            catch (InvalidOperationException ex)
            {
                System.Console.WriteLine($"❌ Помилка операції: {ex.Message}");
                System.Console.WriteLine($"Стек: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"❌ Загальна помилка: {ex.Message}");
                System.Console.WriteLine($"Стек: {ex.StackTrace}");
                throw; // Перекидаємо exception для подальшої обробки
            }
        }
    }
}
