namespace TinkerPop3
{
	namespace StructureApi
	{
		public interface IEdge : IElement
		{
			IVertex VertexIn { get; }
			IVertex VertexOut { get; }

		}
	}
}
