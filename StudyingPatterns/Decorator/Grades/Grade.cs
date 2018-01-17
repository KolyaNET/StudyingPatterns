using System;

namespace Decorator.Grades
{
	/// <summary>
	/// Класс в школе.
	/// </summary>
    public abstract class Grade
    {
		/// <summary>
		/// Название класса.
		/// </summary>
	    public string Name { get; protected set; }

	    /// <summary>
	    /// Префикс класса.
	    /// </summary>
	    private string _prefix;

	    /// <summary>
	    /// Префикс класса.
	    /// </summary>
	    public string Prefix
	    {
		    get => _prefix;
		    protected set
		    {
			    if (string.IsNullOrEmpty(value))
			    {
				    throw new ArgumentNullException(nameof(Prefix), "Не указан префикс класса в школе.");
			    }

			    _prefix = value;
		    }
	    }

		/// <summary>
		/// Полное название класса.
		/// </summary>
		public string FullName => Name + " " + Prefix;

	    /// <summary>
	    /// Количество учеников в классе.
	    /// </summary>
		private int _numberPupils;
		/// <summary>
		/// Количество учеников в классе.
		/// </summary>
		public int NumberPupils
		{
			get => _numberPupils;
			protected set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException(nameof(NumberPupils),
						"Количество учеников в классе не может быть ниже или равным 0.");
				}

				_numberPupils = value;
			}
		}

		/// <summary>
		/// Получить сложность обучения.
		/// </summary>
		/// <returns>Сложность обучения.</returns>
		public abstract int GetComplexityLearning();

		/// <summary>
		/// Конструктор класса в школе.
		/// </summary>
		/// <param name="name">Название класса.</param>
	    protected Grade(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException(nameof(name), "Не указано имя класса в школе.");
			}

			Name = name;
		}
	}
}
