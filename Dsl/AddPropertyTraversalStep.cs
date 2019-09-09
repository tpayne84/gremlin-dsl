using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class AddPropertyTraversalStep<TValue> : KeyValuePairTraversalStep<TValue>
	{
		public AddPropertyTraversalStep(string propertyName, TValue filterValue ) : base(TraversalType.Property, propertyName, filterValue)
		{
		}
	}
}
