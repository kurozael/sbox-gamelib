using System;
using System.Collections.Generic;

namespace Gamelib.Data
{
	public class HashSetList<T> : HashSet<T>
	{
		public IReadOnlyCollection<T> ReadOnlyList { get; private set; }

		private List<T> InternalList;

		public HashSetList()
		{
			InternalList = new();
			ReadOnlyList = InternalList.AsReadOnly();
		}

		public new bool Remove( T item )
		{
			if ( base.Remove( item ) )
			{
				InternalList.Remove( item );
				return true;
			}

			return false;
		}

		public new void Clear()
		{
			InternalList.Clear();
			base.Clear();
		}

		public new bool Add( T item )
		{
			if ( base.Add( item ) )
			{
				InternalList.Add( item );
				return true;
			}

			return false;
		}

		public void Sort( Comparison<T> comparer )
		{
			InternalList.Sort( comparer );
		}

		public new int Count
		{
			get { return InternalList.Count; }
		}

		public T this[int index]
		{
			get { return InternalList[index]; }
		}

		public new IEnumerator<T> GetEnumerator()
		{
			for ( int i = 0; i < InternalList.Count; i++ )
			{
				yield return InternalList[i];
			}
		}
	}
}
