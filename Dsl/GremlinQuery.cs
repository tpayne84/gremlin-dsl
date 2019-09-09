using System.Linq;
using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	/// <summary>
	/// Gremlin query creator object.
	/// </summary>
	[DataContract]
	public class GremlinQuery : IQuery
	{
		/// <summary>
		/// Collection of traversal steps.
		/// </summary>
		[DataMember]
		public ITraversalStepParams TraversalSteps { get; }

		/// <summary>
		/// Global traversal operations interface.
		/// </summary>
		[DataMember]
		public ITraversalOperations G { get; }

		/// <summary>
		/// Self initializing constructor.
		/// </summary>
		public GremlinQuery()
		{
			// Initialize the instance properties.
			this.TraversalSteps = new TraversalParams();
			this.G = new TraversalContext(this);
		}

		/// <summary>
		/// Converts the IQuery to a gremlin query string.
		/// </summary>
		/// <returns>Gremlin query string.</returns>
		public override string ToString() => string.Join( ".", this.TraversalSteps.Values.Select( ts => ts.ToString() ) );
	}
}
