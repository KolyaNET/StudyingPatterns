using Classes;
using System;
using System.Collections.Generic;

namespace Observer
{
	/// <inheritdoc />
	/// <summary>
	/// Школьный журнал.
	/// </summary>
    public class SchoolJournal : IObservable
	{
		/// <summary>
		/// Информация из журнала.
		/// </summary>
		private readonly SchoolJournalInfo _journalInfo;

		/// <summary>
		/// Список подписчиков на журнал.
		/// </summary>
		private readonly List<IObserver> _observers;

		public SchoolJournal()
		{
			_observers = new List<IObserver>();
			_journalInfo = new SchoolJournalInfo(); 
		}

		public void RegisterObserver(IObserver o)
		{
			if (o == null)
			{
				throw new ArgumentNullException(nameof(o), "Не указан подписчик на школьный журнал.");
			}

			_observers.Add(o);
		}

		public void RemoveObserver(IObserver o)
		{
			if (o == null)
			{
				throw new ArgumentNullException(nameof(o), "Не указан подписчик на школьный журнал.");
			}

			_observers.Remove(o);
		}

		public void NotifyObservers()
		{
			foreach (var o in _observers)
			{
				o.Update(_journalInfo);
			}
		}

		/// <summary>
		/// Выставление оценки.
		/// </summary>
		public void Valuation()
		{
			var rnd = new RandomGenerator();
			_journalInfo.Assessment = rnd.Next(1, 5);
			_journalInfo.AssessmentDate = DateTime.Now.Date;
			_journalInfo.Child = SchoolInfo.Children[rnd.Next(0, 2)];
			_journalInfo.Lesson = SchoolInfo.Lessons[rnd.Next(0, 2)];

			// TODO: В проекте библиотеки не должен быть напрямую вывод в консоль.
			Console.WriteLine($"Выставлена оценка {_journalInfo.Assessment} ученику " +
			                  $"{_journalInfo.Child.FullName} по предмету {_journalInfo.Lesson}.");

			NotifyObservers();
		}
	}
}
