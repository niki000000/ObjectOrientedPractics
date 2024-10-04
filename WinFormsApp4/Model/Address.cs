using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

/// <summary>
/// Хранит адрес покупателя.
/// </summary>
class Address
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
            _validator.AssertStringOnLength(Index.ToString(), 200, nameof(Index));
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
            _validator.AssertStringOnLength(Country, 200, nameof(Country));
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
            _validator.AssertStringOnLength(City, 200, nameof(City));
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
            _validator.AssertStringOnLength(Street, 200, nameof(Street));
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
            _validator.AssertStringOnLength(Building, 200, nameof(Building));
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
            _validator.AssertStringOnLength(Apartment, 200, nameof(Apartment));
            _apartment = value;
        }
    }

    /// <summary>
    /// Конструктор по умолчанию.
    /// </summary>
    public Address()
        {

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
        _index = index;
        _country = country;
        _city = city;
        _street = street;
        _building = building;
        _apartment = apartment;
    }
}