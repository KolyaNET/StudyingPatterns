using System;

namespace Observer
{
	/// <summary>
	/// Информация из школьного журнала.
	/// </summary>
    public sealed class SchoolJournalInfo
	{
		/// <summary>
		/// Оценка в журнале.
		/// </summary>
		public int Assessment { get; set; }

		/// <summary>
		/// Название предмета.
		/// </summary>
		public string Lesson { get; set; }

		/// <summary>
		/// Дата проставления оценки.
		/// </summary>
		public DateTime AssessmentDate { get; set; }

		/// <summary>
		/// Ребенок получивший оценку.
		/// </summary>
		public Child Child { get; set; }
	}
}
