namespace AbstractFactory.Classes.Storage
{
	/// <inheritdoc />
	/// <summary>
	/// Карта памяти для хранения фотографий.
	/// </summary>
	public sealed class CardMemoryStorage : Interfaces.Storage
	{
		/// <inheritdoc />
		/// <summary>
		/// Сохранить фотографию в собственную карту памяти камеры.
		/// </summary>
		/// <param name="photo">Фотография</param>
		/// <returns>Результат сохранения.</returns>
		public override bool Save(byte[] photo)
		{
			return true;
		}
	}
}