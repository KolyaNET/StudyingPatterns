using System;

namespace Decorator.Grades
{
	/// <inheritdoc />
	/// <summary>
	/// Пятый класс в школе.
	/// </summary>
    public sealed class FifthGrade : Grade
	{
		/// <inheritdoc />
		/// <summary>
		/// Конструктор пятого класса в школе.
		/// </summary>
		/// <param name="prefix">Префикс класса.</param>
		/// <param name="numberPupils">Количество учеников в классе.</param>
		public FifthGrade(string prefix, int numberPupils) : base("Пятый")
		{
			NumberPupils = numberPupils;
			Prefix = prefix;
		}

		/// <inheritdoc />
		/// <summary>
		/// Получить сложность обучения в пятом классе.
		/// </summary>
		/// <returns>Сложность обучения</returns>
		public override int GetComplexityLearning()
		{
			return 50;
		}
	}
}