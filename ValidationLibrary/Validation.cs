namespace ValidationLibrary
{
    public class Validation
    {
        const string SYMBOLS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public static bool ValidatePassword(string? password) {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            // проверка на число
            bool isDigit = false;
            foreach (var s in password)
            {
                if (char.IsDigit(s))
                {
                    isDigit = true;
                    break;
                }
            }

            // проверка на букву
            bool isLatin = false;
            foreach (var s in password)
            {
                if (SYMBOLS.Contains(s))
                {
                    isLatin = true;
                    break;
                }
            }

            return isDigit && isLatin;
        }
    }
}
