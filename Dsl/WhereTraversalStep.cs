using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class WhereTraversalStep : TraversalStep
	{
		public WhereTraversalStep(IQuery query) : base(TraversalType.Where, query.TraversalSteps)
		{
		}
	}
}
