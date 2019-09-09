using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class ValuesTraversalStep : LabeledTraversalStep
	{
		public ValuesTraversalStep(string label) : base(TraversalType.Values, label)
		{
		}
	}
}