using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class GroupCountTraversalStep : TraversalStep
	{
		public GroupCountTraversalStep() : base(TraversalType.GroupCount)
		{
		}
	}
}
