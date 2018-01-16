using System.Collections.Generic;

namespace Observer
{
	/// <summary>
	/// Школа. Содержит информацию о школе.
	/// </summary>
	public static class SchoolInfo
	{
		/// <summary>
		/// Список детей в школе.
		/// TODO: Желательно заменить на получение значений из файла.
		/// </summary>
		public static List<Child> Children = new List<Child>
		{
			new Child
			{
				Name = "Иван",
				Surname = "Коляда"
			},
			new Child
			{
				Name = "Петр",
				Surname = "Лабода"
			},
			new Child
			{
				Name = "Сергей",
				Surname = "Нема"
			}
		};

		/// <summary>
		/// Список предметов.
		/// TODO: Желательно заменить на получение значений из файла.
		/// </summary>
		public static List<string> Lessons = new List<string>
		{
			"Английский", "Литература", "Труды" // Бедные дети, иметь такие фамилии и учиться в такой школе.
		};
	}
}