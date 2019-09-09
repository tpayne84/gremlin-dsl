using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class OutTraversalStep : LabeledTraversalStep
	{
		public OutTraversalStep(string label) : base(TraversalType.Out, label)
		{
		}
	}
}
