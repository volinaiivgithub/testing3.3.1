using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    public class Class1
    {
        public int IsPass(string password)
        {
            int count = 0;
            // Проверка наличия цифр
            if (password.Any(char.IsDigit))
            {
                count++;
                // Проверка наличия строчных букв
                if (password.Any(char.IsLower))
                {
                    count++;
                    // Проверка наличия заглавных букв
                    if (password.Any(char.IsUpper))
                    {
                        count++;
                        // Проверка наличия спец. символов
                        if (Regex.IsMatch(password, @"[!@#$%^&*()_+{}\[\]:;<>,.?~\\-]"))
                        {
                            count++;
                            // Проверка длины пароля (более 7 символов)
                            if (password.Length > 8)
                            {
                                count++;
                            }
                        }
                    }
                }
            }


            return count;
        }
    }
}
