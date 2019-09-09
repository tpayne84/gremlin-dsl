using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	/// <summary>
	/// Graph context object used to perform graph queries.
	/// </summary>
	public class GraphContext : IGraphContext
	{
		/// <summary>
		/// Allows for creation of a IQuery object.
		/// </summary>
		/// <returns>GremlinQuery as IQuery.</returns>
		public IQuery CreateQuery() => new GremlinQuery();

		/// <summary>
		/// Creates a new gremlin query object.
		/// </summary>
		/// <returns></returns>
		public static GremlinQuery GremlinQuery() => new GremlinQuery();

	}
}
