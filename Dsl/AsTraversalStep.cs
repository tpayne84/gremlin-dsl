using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class AsTraversalStep : LabeledTraversalStep
	{
		public AsTraversalStep(string label) : base(TraversalType.As, label)
		{
		}
	}
}
