using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class HasTraversalStep<TValue> : KeyValuePairTraversalStep<TValue>
	{
		public HasTraversalStep(string propertyName, TValue value) : base(TraversalType.AddVertex, propertyName, value )
		{
		}

	}
}
