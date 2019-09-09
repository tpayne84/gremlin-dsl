using System.Runtime.Serialization;

namespace Gremlin.Dsl
{
	[DataContract]
	public class LabeledTraversalParams : TraversalParams
	{
		[DataMember]
		public string Label { get; }

		public LabeledTraversalParams(string label)
		{
			this.Label = label;
		}
	}
}
