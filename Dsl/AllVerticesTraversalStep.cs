using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class AllVerticesTraversalStep : TraversalStep
	{
		public AllVerticesTraversalStep() : base(TraversalType.AllVertices)
		{
		}
	}
}
