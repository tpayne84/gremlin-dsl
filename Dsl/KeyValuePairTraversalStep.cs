using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public abstract class KeyValuePairTraversalStep<TValue> : TraversalStep
	{
		protected static ITraversalStepParams CreateParams(string key, TValue value) => new KeyValueTraversalParams<TValue>(key, value);

		public KeyValuePairTraversalStep(TraversalType type, string propertyName, TValue filterValue) : base(type, CreateParams(propertyName, filterValue))
		{
			// Known traversal types.
		}

		public KeyValuePairTraversalStep(string type, string propertyName, TValue filterValue) : base(type, CreateParams(propertyName, filterValue))
		{
			// Unknown traversal types.
		}
	}
}
