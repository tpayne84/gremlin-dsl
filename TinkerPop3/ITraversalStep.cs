namespace TinkerPop3
{
	namespace StructureApi
	{
		public interface ITraversalStep
		{
			/// <summary>
			/// Typed Params.
			/// </summary>
			ITraversalStepParams Params { get; }

			string Type { get; }

			string ToString();
		}
	}
}
