using System;
using Decorator.Grades;

namespace Decorator.LessonsInDepth
{
	/// <inheritdoc />
	/// <summary>
	/// Класс в школе с углубленным изучением предмета.
	/// </summary>
	public abstract class LessonInDepth : Grade
	{
		/// <summary>
		/// Класс в школе.
		/// </summary>
		protected Grade Grade;

		/// <inheritdoc />
		/// <summary>
		/// Конструктор класса в школе с углубленным изучением предмета.
		/// </summary>
		/// <param name="fullName">Полное название класса в школе.</param>
		/// <param name="grade">Класс в школе.</param>
		protected LessonInDepth(string fullName, Grade grade) 
			: base(fullName)
		{
			if (string.IsNullOrEmpty(fullName))
			{
				throw new ArgumentNullException(nameof(fullName), "Не указано полное название класса в школе.");
			}

			Grade = grade ?? throw new ArgumentNullException(nameof(grade), "Не указан класс в школе.");
		}
	}
}