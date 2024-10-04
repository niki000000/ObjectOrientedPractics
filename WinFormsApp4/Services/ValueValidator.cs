/// <summary>
/// Реализует валидацию строковых полей.
/// </summary>
class ValueValidator
{
    /// <summary>
    /// Проверяет длину строки.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    /// <param name="maxLenght">Максимальная длина строки.</param>
    /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
    /// <exception cref="ArgumentException">Выбрасывает исключение в случае превышении максимальной длины строки.</exception>
    public void AssertStringOnLength(string value, int maxLenght, string propertyName)
    {
        if (value.Length > maxLenght)
        {
            throw new ArgumentException($"{propertyName} должен бать меньше {maxLenght} символов.");
        }
    }

    
}