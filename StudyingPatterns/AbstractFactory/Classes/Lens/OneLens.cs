namespace AbstractFactory.Classes.Lens
{
	/// <inheritdoc />
	/// <summary>
	/// Один объектив камеры.
	/// </summary>
	public sealed class OneLens : Interfaces.Lens
	{
		/// <inheritdoc />
		/// <summary>
		/// Сделать фотографию на один объектив камеры.
		/// </summary>
		/// <returns>Фотография.</returns>
		public override byte[] TakePhoto()
		{
			return new byte[100];
		}
	}
}