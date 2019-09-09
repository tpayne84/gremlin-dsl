namespace TinkerPop3
{
	namespace StructureApi
	{
		public interface ITraversalOperations : IVertexOperations, IEdgeOperations, IPropertyOperations
		{
			/// <summary>
			/// All vertices in the graph.
			/// </summary>
			ITraversalOperations V();
			ITraversalOperations Has<T>(string name, T value);
			ITraversalOperations Out(string label);
			ITraversalOperations In(string label);
			ITraversalOperations As(string label);
			ITraversalOperations By(string label);
			ITraversalOperations GroupCount();
			ITraversalOperations Values(string label);
			ITraversalOperations Where(IQuery query);

		}
	}
}
