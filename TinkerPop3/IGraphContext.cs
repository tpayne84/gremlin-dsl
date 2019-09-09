namespace TinkerPop3
{
	namespace StructureApi
	{
		/// <summary>
		/// Graph maintains a set of vertices and edges, and access to database functions such as transactions.
		/// </summary>
		public interface IGraphContext
		{
			/// <summary>
			/// Creates an IQuery object.
			/// </summary>
			/// <returns></returns>
			IQuery CreateQuery();
		}
	}
}
