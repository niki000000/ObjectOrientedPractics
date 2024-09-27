/// <summary>
/// Ревлизует создание индивидуального идентификатора.
/// </summary>
public class IdGenerator()
{
    /// <summary>
    /// Первоначальное значание идентификатора.
    /// </summary>
    public static int _nextId = 1;

    /// <summary>
    /// Создает индивидуальный идентификатор.
    /// </summary>
    /// <returns>Возвращает значение индивидуального идентификатора.</returns>
    public static int GetNextId()
    {
        return _nextId++;
    }
}
