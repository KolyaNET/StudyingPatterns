using System;

namespace Observer
{
	/// <inheritdoc />
	/// <summary>
	/// Класс описывает бабушку которая хочет получать уведомления об оценках своего внука/внучки.
	/// </summary>
	public sealed class Grandmother : IObserver
	{
		/// <summary>
		/// Имя бабушки.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Внук/внучка бабушки.
		/// </summary>
		public Child Grandchildren { get; set; }

		public Grandmother(string name, Child grandchildren, IObservable obs)
		{
			Name = name ?? throw new ArgumentNullException(nameof(name), "Не указано имя бабушки.");
			Grandchildren = grandchildren ?? throw new ArgumentNullException(nameof(grandchildren), "Не указан внук/внучка бабушки.");
			var schoolJournal = obs ?? throw new ArgumentNullException(nameof(obs), "Не указан Издатель - Школьный журнал.");
			schoolJournal.RegisterObserver(this);
		}

		public void Update(object ob)
		{
			if (ob == null)
			{
				throw new ArgumentNullException(nameof(ob), "Сообщение от журнала не содержит данных.");
			}

			var journalInfo = (SchoolJournalInfo)ob;

			if (journalInfo.Child.FullName != Grandchildren.FullName)
			{
				// Не наш ребенок, ничего не делаем.
				return;
			}

			switch (journalInfo.Assessment)
			{
				// TODO: В проекте библиотеки не должен быть напрямую вывод в консоль.
				case 5:
					Console.WriteLine($"Бабушка {Name} печет пироги {journalInfo.Child.FullName}.");
					break;
				case 4:
				case 3:
					Console.WriteLine($"Бабушка {Name} поможет исправить оценку {journalInfo.Child.FullName}.");
					break;
				default:
					Console.WriteLine($"Бабушка {Name} поддержит {journalInfo.Child.FullName} и попросит исправить оценку.");
					break;
			}
		}
	}
}