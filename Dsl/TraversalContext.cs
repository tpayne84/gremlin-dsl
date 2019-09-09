using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class TraversalContext : ITraversalOperations
	{
		/// <summary>
		/// Known types mapped by the label they map to.
		/// </summary>
		private Dictionary<string, Type> LabeledTypes { get; set; } = new Dictionary<string, Type>();

		/// <summary>
		/// The IQuery instance that own this traversal context.
		/// </summary>
		protected IQuery OwnerQuery { get; }

		/// <summary>
		/// Adds a traversal step to the IQuery.TraversalSteps Dictionary{int stepIndex, ITraversalStep step}.
		/// </summary>
		/// <param name="step">Step to add to the query.</param>
		/// <returns><see cref="ITraversalOperations"/> for chaining.</returns>
		protected ITraversalOperations AddTraversalStep(ITraversalStep step)
		{
			// Index the step.
			this.OwnerQuery.TraversalSteps[this.OwnerQuery.TraversalSteps.Count.ToString()] = step;

			// Return this ITraversalOperations for chaining.
			return this;
		}

		public TraversalContext(IQuery ownerQuery)
		{
			this.OwnerQuery = ownerQuery;
		}

		public ITraversalOperations AddEdge(IEdge edge) => AddTraversalStep(TraversalStepFactory.addE(edge.Label));

		public ITraversalOperations AddVertex(IVertex vertex) => AddTraversalStep(TraversalStepFactory.addV(vertex.Label));

		public ITraversalOperations AddVertex<T>(IVertex<T> vertex) => AddVertex(vertex as IVertex);

		public ITraversalOperations Property<T>(string name, T value) => AddTraversalStep(TraversalStepFactory.property(name, value));

		public ITraversalOperations V() => AddTraversalStep(TraversalStepFactory.V());

		public ITraversalOperations Has<T>(string name, T value) => AddTraversalStep(TraversalStepFactory.Has(name, value));

		public ITraversalOperations Out(string label) => AddTraversalStep(TraversalStepFactory.Out(label));
		
		public ITraversalOperations In(string label) => AddTraversalStep(TraversalStepFactory.In(label));

		public ITraversalOperations As(string label) => AddTraversalStep(TraversalStepFactory.As(label));
		
		public ITraversalOperations By(string label) => AddTraversalStep(TraversalStepFactory.By(label));

		public ITraversalOperations GroupCount() => AddTraversalStep(TraversalStepFactory.GroupCount());

		public ITraversalOperations Values(string label) => AddTraversalStep(TraversalStepFactory.Values(label));

		public ITraversalOperations Where(IQuery query) => AddTraversalStep(TraversalStepFactory.Where(query));
	}
}
