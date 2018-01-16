namespace Observer
{
	/// <summary>
	/// Издатель - Школьный журнал.
	/// </summary>
	public interface IObservable
	{
		/// <summary>
		/// Добавление подписчика.
		/// </summary>
		/// <param name="o">Подписчик.</param>
		void RegisterObserver(IObserver o);

		/// <summary>
		/// Удаление подписчика.
		/// </summary>
		/// <param name="o">Подписчик.</param>
		void RemoveObserver(IObserver o);

		/// <summary>
		/// Уведомление подписчика.
		/// </summary>
		void NotifyObservers();
	}
}