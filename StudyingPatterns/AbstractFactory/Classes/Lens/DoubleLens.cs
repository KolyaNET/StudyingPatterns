namespace AbstractFactory.Classes.Lens
{
	/// <inheritdoc />
	/// <summary>
	/// Двойной объектив камеры.
	/// </summary>
	public sealed class DoubleLens : Interfaces.Lens
	{
		/// <inheritdoc />
		/// <summary>
		/// Сделать фотографию на двойной объектив камеры.
		/// </summary>
		/// <returns>Фотография.</returns>
		public override byte[] TakePhoto()
		{
			return new byte[200];
		}
	}
}