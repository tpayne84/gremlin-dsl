namespace TinkerPop3
{
	namespace StructureApi
	{
		/// <summary>
		/// Traversal types.
		/// - Note: Update the TraversalStep.TypeMap each time a new TraversalType value is added to the enum.
		/// </summary>
		public enum TraversalType
		{
			As,
			By,
			Has,
			In,
			Out,
			AddEdge,
			AddVertex,
			Property,
			AllVertices,
			GroupCount,
			Values,
			Where
		}
	}
}
