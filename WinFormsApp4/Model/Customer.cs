

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
    private Address _address = new Address();

    /// <summary>
    ///Создание объекта класса ValueValidator.
    /// </summary>
    private ValueValidator _validator = new ValueValidator();

    public int Id
    {
        get
        {
            return _id;
        }
    }
    public string FullName
    {
        get
        {
            return _fullname;
        }
        set
        {
            _validator.AssertStringOnLength(value, 200, nameof(_fullname));
            _fullname = value;
        }
    }
    public string Display
    {
        get
        {
            return $"ID: {_id}, Name: {_fullname}";
        }
    }


    public Address Address
    {
        get
        {
            return _address;
        }
        set
        {

            _address = value ?? new Address();

        }
    }

    /// <summary>
    /// Присваивает полям _fullname и _address значения.
    /// Проверяет длину строковых полей.
    /// </summary>
    /// <param name="fullname">Полное имя покупателя.</param>
    /// <param name="address">Адрес покупателя.</param>
    public Customer(string fullname, Address address)
    {
        _id = IdGenerator.GetNextId();

        _fullname = fullname;

        Address = address ?? new Address();
    }
}

