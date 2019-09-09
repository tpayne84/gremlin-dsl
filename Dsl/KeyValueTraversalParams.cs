using System.Collections.Generic;
using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class KeyValueTraversalParams<TValue> : Dictionary<string, object>, ITraversalStepParams
	{
		[DataMember]
		public string Key { get; }

		[DataMember]
		public TValue Value { get; }

		public KeyValueTraversalParams(string key, TValue value)
		{
			this.Key = key;
			this.Value = value;
		}
	}
}
