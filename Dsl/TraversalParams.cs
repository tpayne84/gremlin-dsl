using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TinkerPop3.StructureApi;

namespace Gremlin.Dsl
{
	[DataContract]
	public class TraversalParams : ITraversalStepParams
	{
		private ITraversalStepParams traversalStepParams;

		public TraversalParams()
		{
			this.traversalStepParams = ( ITraversalStepParams )new Dictionary<string, object>();
		}

		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return this.traversalStepParams.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ( ( IEnumerable )this.traversalStepParams ).GetEnumerator();
		}

		public void Add( KeyValuePair<string, object> item )
		{
			this.traversalStepParams.Add( item );
		}

		public void Clear()
		{
			this.traversalStepParams.Clear();
		}

		public bool Contains( KeyValuePair<string, object> item )
		{
			return this.traversalStepParams.Contains( item );
		}

		public void CopyTo( KeyValuePair<string, object>[] array, int arrayIndex )
		{
			this.traversalStepParams.CopyTo( array, arrayIndex );
		}

		public bool Remove( KeyValuePair<string, object> item )
		{
			return this.traversalStepParams.Remove( item );
		}

		public int Count => this.traversalStepParams.Count;

		public bool IsReadOnly => this.traversalStepParams.IsReadOnly;

		public bool ContainsKey( string key )
		{
			return this.traversalStepParams.ContainsKey( key );
		}

		public void Add( string key, object value )
		{
			this.traversalStepParams.Add( key, value );
		}

		public bool Remove( string key )
		{
			return this.traversalStepParams.Remove( key );
		}

		public bool TryGetValue( string key, out object value )
		{
			return this.traversalStepParams.TryGetValue( key, out value );
		}

		public object this[ string key ]
		{
			get => this.traversalStepParams[ key ];
			set => this.traversalStepParams[ key ] = value;
		}

		public ICollection<string> Keys => this.traversalStepParams.Keys;

		public ICollection<object> Values => this.traversalStepParams.Values;
	}
}
