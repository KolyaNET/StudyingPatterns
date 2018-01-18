namespace AbstractFactory.Interfaces
{
	/// <summary>
	/// Объектив камеры.
	/// </summary>
    public abstract class Lens
	{
		/// <summary>
		/// Сделать фотографию.
		/// </summary>
		/// <returns>Фотография.</returns>
		public abstract byte[] TakePhoto();
	}
}