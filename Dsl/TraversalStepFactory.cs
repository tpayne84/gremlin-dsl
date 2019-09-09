using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	/// <summary>
	/// Traversal step creation factor class.
	/// </summary>
	public static class TraversalStepFactory
	{
		/// <summary>
		/// Adds a new vertex traversal step with the passed label.
		/// </summary>
		/// <param name="label">Vertex label.</param>
		/// <returns><see cref="AddVertexTraversalStep"/></returns>
		public static AddVertexTraversalStep addV(string label) => new AddVertexTraversalStep(label);

		/// <summary>
		/// Adds a new edge traversal step with the passed label.
		/// </summary>
		/// <param name="label">Edge label.</param>
		/// <returns><see cref="AddEdgeTraversalStep"/></returns>
		public static AddEdgeTraversalStep addE(string label) => new AddEdgeTraversalStep(label);

		/// <summary>
		/// Adds a new edge traversal step with the passed label.
		/// </summary>
		/// <param name="propertyName">Property label.</param>
		/// <param name="filterValue">Property value to filter on.</param>
		/// <returns><see cref="AddPropertyTraversalStep{TValue}"/></returns>
		public static AddPropertyTraversalStep<TValue> property<TValue>(string propertyName, TValue filterValue) => new AddPropertyTraversalStep<TValue>(propertyName, filterValue);

		/// <summary>
		/// Creates an all vertices traversal step.
		/// </summary>
		/// <returns><see cref="AllVerticesTraversalStep"/></returns>
		public static AllVerticesTraversalStep V() => new AllVerticesTraversalStep();

		/// <summary>
		/// Has property traversal step.
		/// </summary>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="name">Property to check.</param>
		/// <param name="value">Required filter value.</param>
		/// <returns><see cref="HasTraversalStep{TValue}"/></returns>
		public static HasTraversalStep<TValue> Has<TValue>(string name, TValue value) => new HasTraversalStep<TValue>(name, value);

		/// <summary>
		/// Creates a out() pipe traversal step.
		/// </summary>
		/// <param name="label">Label to pipe out.</param>
		/// <returns><see cref="OutTraversalStep"/></returns>
		public static OutTraversalStep Out(string label) => new OutTraversalStep(label);

		/// <summary>
		/// Creates a in() pipe traversal step.
		/// </summary>
		/// <param name="label">Label to pipe into.</param>
		/// <returns><see cref="InTraversalStep"/></returns>
		public static InTraversalStep In(string label) => new InTraversalStep(label);

		/// <summary>
		/// Created a cast as traversal step.
		/// </summary>
		/// <param name="label">Label to cast as.</param>
		/// <returns><see cref="AsTraversalStep"/></returns>
		public static AsTraversalStep As(string label) => new AsTraversalStep(label);
		
		/// <summary>
		/// Creates an order by traversal step.
		/// </summary>
		/// <param name="label">Label to order by.</param>
		/// <returns></returns>
		public static ByTraversalStep By(string label) => new ByTraversalStep(label);

		/// <summary>
		/// Creates a group count traversal step.
		/// </summary>
		/// <returns><see cref="GroupCountTraversalStep"/></returns>
		public static GroupCountTraversalStep GroupCount() => new GroupCountTraversalStep();

		/// <summary>
		/// Creates a values traversal step.
		/// </summary>
		/// <param name="label">Label to get the values from.</param>
		/// <returns><see cref="ValuesTraversalStep"/></returns>
		public static ValuesTraversalStep Values(string label) => new ValuesTraversalStep(label);

		/// <summary>
		/// Creates a where filter traversal step.
		/// </summary>
		/// <param name="query">Sub-query to use as the filter.</param>
		/// <returns><see cref="WhereTraversalStep"/></returns>
		public static WhereTraversalStep Where(IQuery query) => new WhereTraversalStep(query);
	}
}
