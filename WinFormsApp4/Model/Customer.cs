

/// <summary>
/// Хранит данные покупателя, его идентификатор, полное имя и адрес.
/// </summary>
class Customer
{
    /// <summary>
    /// Уникальный идентификатор покупателя.
    /// </summary>
    private readonly int _id;

    /// <summary>
    /// Полное имя покупателя.
    /// </summary>
    private string _fullname;

    /// <summary>
    /// Адрес покупателя.
    /// </summary>
    private string _address;

    /// <summary>
    ///Создание объекта класса ValueValidator.
    /// </summary>
    private ValueValidator _validator = new ValueValidator();

    /// <summary>
    /// Присваивает полю _id индивидуальный идентификатор.
    /// </summary>
    public Customer()
    {
        _id = IdGenerator.GetNextId();
    }

    /// <summary>
    /// Присваивает полям _fullname и _address значения.
    /// Проверяет длину строковых полей.
    /// </summary>
    /// <param name="fullname">Полное имя покупателя.</param>
    /// <param name="address">Адрес покупателя.</param>
    public Customer(string fullname, string address)
    {
        _fullname = fullname;

        _address = address;

        _validator.AssertStringOnLength(fullname, 200, nameof(fullname));

        _validator.AssertStringOnLength(address, 500, nameof(address));
    }
}

