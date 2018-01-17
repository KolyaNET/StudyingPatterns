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
			Grade = grade;
		}
	}
}