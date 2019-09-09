using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class AddEdgeTraversalStep : LabeledTraversalStep
	{
		public AddEdgeTraversalStep(string label) : base(TraversalType.AddEdge, label)
		{
		}
	}
}
