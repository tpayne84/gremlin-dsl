using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public abstract class LabeledTraversalStep : TraversalStep
	{
		protected static ITraversalStepParams CreateParams(string label) => new LabeledTraversalParams(label);

		public LabeledTraversalStep(string type, string label) : base(type, CreateParams(label))
		{
		}

		public LabeledTraversalStep(TraversalType type, string label) : base(type, CreateParams(label))
		{
		}

	}
}
