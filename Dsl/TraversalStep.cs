using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public abstract class TraversalStep : ITraversalStep
	{
		/// <summary>
		/// Constructor overload.
		/// </summary>
		/// <param name="type">Traversal type.</param>
		/// <param name="args">Traversal step params.</param>
		public TraversalStep( TraversalType type, ITraversalStepParams args = null) : this(type.ToString(), args ) {}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="type">Traversal type.</param>
		/// <param name="args">Traversal step params.</param>
		public TraversalStep( string type, ITraversalStepParams args = null)
		{
			// Save the passed params.
			this.Type = type;
			this.Params = args;
			this.Template = Maps.LabelToQueryTemplate[ type ];
		}

		/// <summary>
		/// Query template.
		/// </summary>
		[DataMember]
		public string Template { get; }

		/// <summary>
		/// Traversal type.
		/// </summary>
		[DataMember]
		public string Type { get; }

		/// <summary>
		/// Typed params.
		/// </summary>
		[DataMember]
		public ITraversalStepParams Params { get; }

		/// <summary>
		/// To query string base implementation.
		/// </summary>
		/// <returns>Query string.</returns>
		public virtual string ToString() => string.Format( this.Template, this.Params.Values );
	}
}
