

using System.Diagnostics.Tracing;

/// <summary>
/// Хранит данные покупателя, его идентификатор, полное имя и адрес.
/// </summary>
public class Customer
{
    /// <summary>
    /// Уникальный идентификатор покупателя.
    /// </summary>
    readonly int _id;

    /// <summary>
    /// Полное имя покупателя.
    /// </summary>
    string _fullname;

    Address _address;

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


    public Address Address
    {
        get
        {
            return _address;
        }
        set
        {

            _address = value;

        }
    }

    /// <summary>
    /// Создает начальный экземпляр класса.
    /// </summary>
    public Customer()
    {
        FullName = "None";
        Address = new Address();
        _id = IdGenerator.GetNextId();
    }

    /// <summary>
    /// Присваивает полям значения.
    /// Проверяет длину строковых полей.
    /// </summary>
    /// <param name="fullname">Полное имя покупателя.</param>
    public Customer(string fullname)
    {
        _id = IdGenerator.GetNextId();

        FullName = fullname;

        Address = new Address();
    }
}

