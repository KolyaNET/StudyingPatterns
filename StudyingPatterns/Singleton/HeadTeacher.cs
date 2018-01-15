namespace Singleton
{
	/// <summary>
	/// Класс описывает директора школы
	/// </summary>
    public class HeadTeacher
	{
		private static HeadTeacher _instance;

		private static readonly object SyncRoot = new object();

		/// <summary>
		/// Имя директора школы
		/// </summary>
		public string Name { get; }

		protected HeadTeacher(string name)
		{
			Name = name;
		}

		public static HeadTeacher GetInstance(string name)
		{
			if (_instance == null)
			{
				lock (SyncRoot)
				{
					// На всякий случай, ещё раз проверим не был
					// ли объект создан другим потоком, пока
					// текущий ждал освобождения блокировки.
					if (_instance == null)
						_instance = new HeadTeacher(name);
				}
			}

			return _instance;
		}
	}
}
