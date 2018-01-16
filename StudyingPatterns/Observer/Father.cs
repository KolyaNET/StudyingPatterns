using System;

namespace Observer
{
	/// <inheritdoc />
	/// <summary>
	/// Класс описывает отца который хотел бы получать уведомления об оценках своего ребенка.
	/// </summary>
	public class Father : IObserver
	{
		/// <summary>
		/// Имя отца.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Ребенок отца. В школе запрещено иметь несколько детей =)
		/// </summary>
		public Child Child { get; set; }

		/// <summary>
		///	Школьный журнал.
		/// </summary>
		private IObservable _schoolJournal;

		public Father(string name, Child child, IObservable obs)
		{
			Name = name ?? throw new ArgumentNullException(nameof(name), "Не указано имя отца.");
			Child = child ?? throw new ArgumentNullException(nameof(child), "Не указан ребенок отца.");
			_schoolJournal = obs ?? throw new ArgumentNullException(nameof(obs), "Не указан Издатель - Школьный журнал.");
			_schoolJournal.RegisterObserver(this);
		}

		public void Update(object ob)
		{
			if (ob == null)
			{
				throw new ArgumentNullException(nameof(ob), "Сообщение от журнала не содержит данных.");
			}

			var journalInfo = (SchoolJournalInfo)ob;

			if (journalInfo.Child.FullName != Child.FullName)
			{
				// Не наш ребенок, ничего не делаем.
				return;
			}

			switch (journalInfo.Assessment)
			{
				// TODO: В проекте библиотеки не должен быть напрямую вывод в консоль.
				case 5:
					Console.WriteLine($"Отец {Name} покупает подарок за пятерку {journalInfo.Child.FullName}.");
					break;
				case 4:
				case 3:
					Console.WriteLine($"Отец {Name} не ругает {journalInfo.Child.FullName}.");
					break;
				default:
					Console.WriteLine($"Отец {Name} наказывает {journalInfo.Child.FullName} домашним арестом.");
					break;
			}
		}

		/// <summary>
		/// Отец может так расстроится от плохих оценок что отпишется от уведомлений.
		/// </summary>
		public void StopNotificate()
		{
			_schoolJournal.RemoveObserver(this);
			_schoolJournal = null;
		}
	}
}