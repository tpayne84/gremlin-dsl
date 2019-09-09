using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class ByTraversalStep : LabeledTraversalStep
	{
		public ByTraversalStep(string label) : base(TraversalType.By, label)
		{
		}
	}
}
