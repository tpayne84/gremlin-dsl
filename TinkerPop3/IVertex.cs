using System.Collections.Generic;

namespace TinkerPop3
{
	namespace StructureApi
	{
		public interface IVertex<T> : IVertex
		{
			string Label { get; }
		}

		public interface IVertex : IElement
		{
			IDictionary<string,IEdge[]> EdgesIn { get; }
			IDictionary<string, IEdge[]> EdgesOut { get; }

		}
	}
}
