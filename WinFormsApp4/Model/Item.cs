/// <summary>
/// Хранит данные о товаре, его идентификатор, название, описание и стоимость.
/// </summary>
public class Item
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
  
    /// <summary>
    /// Свойство наименования товара.
    /// </summary>
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _validator.AssertStringOnLength(Name, 200, nameof(Name));
            _name = value;
        }
    }

    public Category Category { get; set; }

    /// <summary>
    /// Свойство идентификатора.
    /// </summary>
    public int Id
    {
        get
        {
            return _id;
        }
    }

    /// <summary>
    /// Свойство описания.
    /// </summary>
    public string Info
    {
        get
        {
            return _info;
        }
        set
        {
            _validator.AssertStringOnLength(Info, 1000, nameof(Info));
            _info = value;
       
        }
    }

    /// <summary>
    /// Свойство стоимости.
    /// </summary>
    public double Cost
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

    /// <summary>5
    /// Присваивает полям _name, _info, _cost значения.
    /// </summary>
    /// <param name="category">Категория товара.</param>
    /// <param name="name">Название товара.</param>
    /// <param name="info">Описание товара.</param>
    /// <param name="cost">Стоимость товара.</param>
    public Item(string name, string info, double cost, Category category)
    {
        _id = IdGenerator.GetNextId();
        
        Category = category;

        _name = name;

        _info = info;

        _cost = cost;
    }
}