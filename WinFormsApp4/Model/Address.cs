using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

/// <summary>
/// Хранит адрес покупателя.
/// </summary>
public class Address
{
    /// <summary>
    /// Почтовый индекс.
    /// </summary>
    private int _index;

    /// <summary>
    /// Страна/регион.
    /// </summary>
    private string _country;

    /// <summary>
    /// Город(населенный пункт).
    /// </summary>
    private string _city;

    /// <summary>
    /// Улица.
    /// </summary>
    private string _street;

    /// <summary>
    /// Номер дома.
    /// </summary>
    private string _building;

    /// <summary>
    /// Номер квартиры/помещения.
    /// </summary>
    private string _apartment;

    /// <summary>
    /// Создание объекта класса ValueValidator.
    /// </summary>
    ValueValidator _validator = new ValueValidator();


    /// <summary>
    /// Свойство почтового индекса.
    /// </summary>
    public int Index
    {
        get
        {
            return _index;
        }
        set
        {
            _index = value;
        }
    }

    /// <summary>
    /// Свойство страны/региона.
    /// </summary>
    public string Country
    {
        get
        {
            return _country;
        }
        set
        {
            _validator.AssertStringOnLength(value, 50, nameof(Country));
            _country = value;
        }
    }

    /// <summary>
    /// Свойство города.
    /// </summary>
    public string City
    {
        get
        {
            return _city;
        }
        set
        {
            _validator.AssertStringOnLength(value, 50, nameof(City));
            _city = value;
        }
    }

    /// <summary>
    /// Свойство улицы.
    /// </summary>
    public string Street
    {
        get
        {
            return _street;
        }
        set
        {
            _validator.AssertStringOnLength(value, 100, nameof(Street));
            _street = value;
        }
    }

    /// <summary>
    /// Свойство номера дома.
    /// </summary>
    public string Building
    {
        get
        {
            return _building;
        }
        set
        {
            _validator.AssertStringOnLength(value, 10, nameof(Building));
            _building = value;
        }
    }

    /// <summary>
    /// Свойство номера квартиры/помещения.
    /// </summary>
    public string Apartment
    {
        get
        {
            return _apartment;
        }
        set
        {
            _validator.AssertStringOnLength(value, 10, nameof(Apartment));
            _apartment = value;
        }
    }

    /// <summary>
    /// Конструктор по умолчанию.
    /// </summary>
    public Address()
        {
        Index = 100000;
        Country = "";
        City = "";
        Street = "";
        Building = "";
        Apartment = "";
        }
    /// <summary>
    /// Присваивает полям _index, _country, _city, _street, _building, _apartment значения.
    /// </summary>
    /// <param name="index">Почтовый индекс.</param>
    /// <param name="country">Страна/регион.</param>
    /// <param name="city">Город.</param>
    /// <param name="street">Улица.</param>
    /// <param name="building">Номер дома.</param>
    /// <param name="apartment">Номер квартиры/помещения.</param>
    public Address(int index, string country, string city, string street, string building, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        Building = building;
        Apartment = apartment;
    }
}