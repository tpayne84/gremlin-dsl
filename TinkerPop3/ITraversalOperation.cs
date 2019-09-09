namespace TinkerPop3
{
	namespace StructureApi
	{
		public interface ITraversalOperation
		{
			string Id { get; }
			
			string Template { get; }

			string ToQuery(string template, ITraversalStepParams args);
		}
	}
}
