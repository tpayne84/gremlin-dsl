using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class AddVertexTraversalStep : LabeledTraversalStep
	{
		public AddVertexTraversalStep(string label) : base(TraversalType.AddVertex, label)
		{
		}

	}
}
