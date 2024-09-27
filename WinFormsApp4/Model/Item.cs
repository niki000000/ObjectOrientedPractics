/// <summary>
/// Хранит данные о товаре, его идентификатор, название, описание и стоимость.
/// </summary>
class Item
{
    /// <summary>
    /// Уникальный идентификатор товара.
    /// </summary>
    private readonly int _id;

    /// <summary>
    /// Название товара.
    /// </summary>
    private string _name;

    /// <summary>
    /// Описание товара.
    /// </summary>
    private string _info;

    /// <summary>
    /// Стоимость товара. 
    /// От 0 до 100 000.
    /// </summary>
    private double _cost;

    /// <summary>
	/// Создание объекта класса ValueValidator.
	/// </summary>
	private ValueValidator _validator = new ValueValidator();

    public string name
    {
        get
        {
            return _name;
        }
        set
        {
            _validator.AssertStringOnLength(name, 200, nameof(name));
            _name = value;
        }
    }

    public int Id
    {
        get
        {
            return _id;
        }
    }
    public string info
    {
        get
        {
            return _info;
        }
        set
        {
            _validator.AssertStringOnLength(info, 1000, nameof(info));
            _info = value;
       
        }
    }

    public double cost
    {
        get
        {
            return _cost;
        }
        set
        {
            _cost = value;
        }
    }

    public string Display
    {
        get
        {
            return $"ID: {_id}, Name: {_name}, Cost {_cost}";
        }
    }


    /// <summary>
    /// Присваивает полю _id индивидуальный идентификатор.
    /// </summary>
    public Item()
    {
        _id = IdGenerator.GetNextId();
    }

    /// <summary>
    /// Присваивает полям _name, _info, _cost значения.
    /// Проверяет длину строковых полей.
    /// </summary>
    /// <param name="name">Название товара.</param>
    /// <param name="info">Описание товара.</param>
    /// <param name="cost">Стоимость товара.</param>
    public Item(string name, string info, double cost)
    {
        _id = IdGenerator.GetNextId(); 
        
        _name = name;

        _info = info;

        _cost = cost;
    }
}