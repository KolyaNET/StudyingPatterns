namespace AbstractFactory.Interfaces
{
	/// <summary>
	/// Класс абстрактной фабрики камеры.
	/// </summary>
	public abstract class CameraFactory
	{
		public abstract Lens CreateLens();
		public abstract AlgorithmProcessing CreateAlgorithmProcessing();
		public abstract Storage CreateStorage();
	}
}