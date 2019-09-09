namespace TinkerPop3
{
	namespace StructureApi
	{
		public interface IVertexOperations
		{
			ITraversalOperations AddVertex(IVertex vertex);
			ITraversalOperations AddVertex<T>(IVertex<T> vertex);
		}
	}
}
