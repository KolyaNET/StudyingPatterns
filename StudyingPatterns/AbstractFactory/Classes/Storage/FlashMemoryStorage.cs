namespace AbstractFactory.Classes.Storage
{
	/// <inheritdoc />
	/// <summary>
	/// Собственная память для хранения фотографий.
	/// </summary>
	public sealed class FlashMemoryStorage : Interfaces.Storage
	{
		/// <inheritdoc />
		/// <summary>
		/// Сохранить фотографию в собственную память камеры.
		/// </summary>
		/// <param name="photo">Фотография.</param>
		/// <returns>Результат сохранения.</returns>
		public override bool Save(byte[] photo)
		{
			return true;
		}
	}
}