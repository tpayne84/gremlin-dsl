namespace TinkerPop3
{
	namespace StructureApi
	{
		public interface IPropertyOperations
		{
			ITraversalOperations Property<T>(string name, T value);
		}
	}
}
