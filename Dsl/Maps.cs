using System.Collections.Generic;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	public static class Maps
	{
		/// <summary>
		/// Holds a map from the labeled TraversalType to the query template string.
		/// </summary>
		internal static Dictionary<string, string> LabelToQueryTemplate = new Dictionary<string, string>
		{
			{ TraversalType.As.ToString(), "as('{0}')" },
			{ TraversalType.Has.ToString(), "has('{0}')" },
			{ TraversalType.In.ToString(), "in('{0}')" },
			{ TraversalType.Out.ToString(), "out('{0}')" },
			{ TraversalType.AllVertices.ToString(), "V()" },
			{ TraversalType.Property.ToString(), "property('{0}', {1})" },
			{ TraversalType.AddVertex.ToString(), "addV('{0}')" },
			{ TraversalType.AddEdge.ToString(), "addE('{0}')" },
			{ TraversalType.Values.ToString(), "values('{0}')" },
			{ TraversalType.Where.ToString(), "where('{0}')" },
			{ TraversalType.GroupCount.ToString(), "groupCount('{0}')" },
		};
	}
}
