using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class InTraversalStep : LabeledTraversalStep
	{
		public InTraversalStep(string label) : base(TraversalType.In, label)
		{
		}
	}
}
