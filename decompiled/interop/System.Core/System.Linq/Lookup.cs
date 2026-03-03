using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq;

[Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Token(Token = "0x2000020")]
	internal class Grouping : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement>
	{
		[Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__7 : IEnumerator<TElement>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400007C")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x400007D")]
			[FieldOffset(Offset = "0x0")]
			private TElement _003C_003E2__current;

			[Token(Token = "0x400007E")]
			[FieldOffset(Offset = "0x0")]
			public Grouping _003C_003E4__this;

			[Token(Token = "0x400007F")]
			[FieldOffset(Offset = "0x0")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000023")]
			private TElement System_002ECollections_002EGeneric_002EIEnumerator_003CTElement_003E_002ECurrent
			{
				[Token(Token = "0x6000107")]
				[DebuggerHidden]
				get
				{
					return (TElement)null;
				}
			}

			[Token(Token = "0x17000024")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000109")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000104")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000105")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000106")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000108")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x0")]
		internal TKey key;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x0")]
		internal int hashCode;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x0")]
		internal TElement[] elements;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x0")]
		internal int count;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x0")]
		internal Grouping hashNext;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x0")]
		internal Grouping next;

		[Token(Token = "0x17000020")]
		private int System_002ECollections_002EGeneric_002EICollection_003CTElement_003E_002ECount
		{
			[Token(Token = "0x60000F7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000021")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CTElement_003E_002EIsReadOnly
		{
			[Token(Token = "0x60000F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		private TElement System_002ECollections_002EGeneric_002EIList_003CTElement_003E_002EItem
		{
			[Token(Token = "0x6000101")]
			get
			{
				return (TElement)null;
			}
			[Token(Token = "0x6000102")]
			set
			{
			}
		}

		[Token(Token = "0x60000F4")]
		internal void Add(TElement element)
		{
		}

		[Token(Token = "0x60000F5")]
		[IteratorStateMachine(typeof(Lookup<, >.Grouping._003CGetEnumerator_003Ed__7))]
		public IEnumerator<TElement> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		private void System_002ECollections_002EGeneric_002EICollection_003CTElement_003E_002EAdd(TElement item)
		{
		}

		[Token(Token = "0x60000FA")]
		private void System_002ECollections_002EGeneric_002EICollection_003CTElement_003E_002EClear()
		{
		}

		[Token(Token = "0x60000FB")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CTElement_003E_002EContains(TElement item)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FC")]
		private void System_002ECollections_002EGeneric_002EICollection_003CTElement_003E_002ECopyTo(TElement[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60000FD")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CTElement_003E_002ERemove(TElement item)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FE")]
		private int System_002ECollections_002EGeneric_002EIList_003CTElement_003E_002EIndexOf(TElement item)
		{
			return default(int);
		}

		[Token(Token = "0x60000FF")]
		private void System_002ECollections_002EGeneric_002EIList_003CTElement_003E_002EInsert(int index, TElement item)
		{
		}

		[Token(Token = "0x6000100")]
		private void System_002ECollections_002EGeneric_002EIList_003CTElement_003E_002ERemoveAt(int index)
		{
		}

		[Token(Token = "0x6000103")]
		public Grouping()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__12 : IEnumerator<IGrouping<TKey, TElement>>, IDisposable, IEnumerator
	{
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x0")]
		private IGrouping<TKey, TElement> _003C_003E2__current;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x0")]
		public Lookup<TKey, TElement> _003C_003E4__this;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x0")]
		private Grouping _003Cg_003E5__2;

		[Token(Token = "0x17000025")]
		private IGrouping<TKey, TElement> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ELinq_002EIGrouping_003CTKey_002CTElement_003E_003E_002ECurrent
		{
			[Token(Token = "0x600010D")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600010F")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010A")]
		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600010B")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600010C")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010E")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class _003CApplyResultSelector_003Ed__13<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x0")]
		private TResult _003C_003E2__current;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x0")]
		public Lookup<TKey, TElement> _003C_003E4__this;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x0")]
		private Func<TKey, IEnumerable<TElement>, TResult> resultSelector;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x0")]
		public Func<TKey, IEnumerable<TElement>, TResult> _003C_003E3__resultSelector;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x0")]
		private Grouping _003Cg_003E5__2;

		[Token(Token = "0x17000027")]
		private TResult System_002ECollections_002EGeneric_002EIEnumerator_003CTResult_003E_002ECurrent
		{
			[Token(Token = "0x6000113")]
			[DebuggerHidden]
			get
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000115")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000110")]
		[DebuggerHidden]
		public _003CApplyResultSelector_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000111")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000112")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000116")]
		[DebuggerHidden]
		private IEnumerator<TResult> System_002ECollections_002EGeneric_002EIEnumerable_003CTResult_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x0")]
	private IEqualityComparer<TKey> comparer;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x0")]
	private Grouping[] groupings;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x0")]
	private Grouping lastGrouping;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x0")]
	private int count;

	[Token(Token = "0x60000EC")]
	internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	private Lookup(IEqualityComparer<TKey> comparer)
	{
	}

	[Token(Token = "0x60000EE")]
	[IteratorStateMachine(typeof(Lookup<, >._003CGetEnumerator_003Ed__12))]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	[IteratorStateMachine(typeof(_003CApplyResultSelector_003Ed__13<>))]
	public IEnumerable<TResult> ApplyResultSelector<TResult>(Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000F1")]
	internal int InternalGetHashCode(TKey key)
	{
		return default(int);
	}

	[Token(Token = "0x60000F2")]
	internal Grouping GetGrouping(TKey key, bool create)
	{
		return null;
	}

	[Token(Token = "0x60000F3")]
	private void Resize()
	{
	}
}
