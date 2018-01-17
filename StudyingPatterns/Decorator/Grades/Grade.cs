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
	    public string Prefix { get; protected set; }

	    /// <summary>
	    /// Полное название класса.
	    /// </summary>
	    public string FullName => Name + " " + Prefix;

		/// <summary>
		/// Количество учеников в классе.
		/// </summary>
		public int NumberPupils { get; protected set; }

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
			Name = name;
		}
	}
}
