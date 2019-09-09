using System.Collections.Generic;

namespace TinkerPop3
{
	namespace StructureApi
	{
		/// <summary>
		/// IQuery interface used to simply the generation of gremlin query strings.
		/// </summary>
		public interface IQuery
		{
			/// <summary>
			///  Ordered list of steps.
			/// </summary>
			ITraversalStepParams TraversalSteps { get; }

			/// <summary>
			/// Traditional 'g', used for the current graph traversal.
			/// </summary>
			ITraversalOperations G { get; }
		}
	}
}
