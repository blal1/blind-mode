using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq;

[Token(Token = "0x2000008")]
public static class Enumerable
{
	[Token(Token = "0x2000009")]
	private abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x0")]
		private int threadId;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x0")]
		internal int state;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x0")]
		internal TSource current;

		[Token(Token = "0x1700000D")]
		public TSource Current
		{
			[Token(Token = "0x6000070")]
			get
			{
				return (TSource)null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000077")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006F")]
		public Iterator()
		{
		}

		[Token(Token = "0x6000071")]
		public abstract Iterator<TSource> Clone();

		[Token(Token = "0x6000072")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000073")]
		public IEnumerator<TSource> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		public abstract bool MoveNext();

		[Token(Token = "0x6000075")]
		public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);

		[Token(Token = "0x6000076")]
		public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);

		[Token(Token = "0x6000078")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200000A")]
	private class WhereEnumerableIterator<TSource> : Iterator<TSource>
	{
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<TSource> source;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, bool> predicate;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator<TSource> enumerator;

		[Token(Token = "0x600007A")]
		public WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
		}

		[Token(Token = "0x600007B")]
		public override Iterator<TSource> Clone()
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x600007D")]
		public override bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
		{
			return null;
		}
	}

	[Token(Token = "0x200000B")]
	private class WhereArrayIterator<TSource> : Iterator<TSource>
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x0")]
		private TSource[] source;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, bool> predicate;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		private int index;

		[Token(Token = "0x6000080")]
		public WhereArrayIterator(TSource[] source, Func<TSource, bool> predicate)
		{
		}

		[Token(Token = "0x6000081")]
		public override Iterator<TSource> Clone()
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		public override bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
		{
			return null;
		}
	}

	[Token(Token = "0x200000C")]
	private class WhereListIterator<TSource> : Iterator<TSource>
	{
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x0")]
		private List<TSource> source;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, bool> predicate;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x0")]
		private List<TSource>.Enumerator enumerator;

		[Token(Token = "0x6000085")]
		public WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
		{
		}

		[Token(Token = "0x6000086")]
		public override Iterator<TSource> Clone()
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		public override bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
		{
			return null;
		}
	}

	[Token(Token = "0x200000D")]
	private class WhereSelectEnumerableIterator<TSource, TResult> : Iterator<TResult>
	{
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<TSource> source;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, bool> predicate;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, TResult> selector;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator<TSource> enumerator;

		[Token(Token = "0x600008A")]
		public WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
		{
		}

		[Token(Token = "0x600008B")]
		public override Iterator<TResult> Clone()
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x600008D")]
		public override bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
		{
			return null;
		}
	}

	[Token(Token = "0x200000E")]
	private class WhereSelectArrayIterator<TSource, TResult> : Iterator<TResult>
	{
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x0")]
		private TSource[] source;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, bool> predicate;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, TResult> selector;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x0")]
		private int index;

		[Token(Token = "0x6000090")]
		public WhereSelectArrayIterator(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
		{
		}

		[Token(Token = "0x6000091")]
		public override Iterator<TResult> Clone()
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		public override bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
		{
			return null;
		}
	}

	[Token(Token = "0x200000F")]
	private class WhereSelectListIterator<TSource, TResult> : Iterator<TResult>
	{
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x0")]
		private List<TSource> source;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, bool> predicate;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, TResult> selector;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x0")]
		private List<TSource>.Enumerator enumerator;

		[Token(Token = "0x6000095")]
		public WhereSelectListIterator(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
		{
		}

		[Token(Token = "0x6000096")]
		public override Iterator<TResult> Clone()
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		public override bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
		{
			return null;
		}
	}

	[Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class _003CSelectIterator_003Ed__5<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x0")]
		private TResult _003C_003E2__current;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<TSource> source;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x0")]
		public IEnumerable<TSource> _003C_003E3__source;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, int, TResult> selector;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x0")]
		public Func<TSource, int, TResult> _003C_003E3__selector;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		private int _003Cindex_003E5__2;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator<TSource> _003C_003E7__wrap2;

		[Token(Token = "0x1700000F")]
		private TResult System_002ECollections_002EGeneric_002EIEnumerator_003CTResult_003E_002ECurrent
		{
			[Token(Token = "0x600009E")]
			[DebuggerHidden]
			get
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000A0")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009A")]
		[DebuggerHidden]
		public _003CSelectIterator_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600009B")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600009C")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x600009F")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60000A1")]
		[DebuggerHidden]
		private IEnumerator<TResult> System_002ECollections_002EGeneric_002EIEnumerable_003CTResult_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class _003CSelectManyIterator_003Ed__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x0")]
		private TResult _003C_003E2__current;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<TSource> source;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x0")]
		public IEnumerable<TSource> _003C_003E3__source;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, IEnumerable<TResult>> selector;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x0")]
		public Func<TSource, IEnumerable<TResult>> _003C_003E3__selector;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator<TSource> _003C_003E7__wrap1;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator<TResult> _003C_003E7__wrap2;

		[Token(Token = "0x17000011")]
		private TResult System_002ECollections_002EGeneric_002EIEnumerator_003CTResult_003E_002ECurrent
		{
			[Token(Token = "0x60000AC")]
			[DebuggerHidden]
			get
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x17000012")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000AE")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A7")]
		[DebuggerHidden]
		public _003CSelectManyIterator_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000A8")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000A9")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60000AB")]
		private void _003C_003Em__Finally2()
		{
		}

		[Token(Token = "0x60000AD")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60000AF")]
		[DebuggerHidden]
		private IEnumerator<TResult> System_002ECollections_002EGeneric_002EIEnumerable_003CTResult_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class _003CConcatIterator_003Ed__59<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x0")]
		private TSource _003C_003E2__current;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<TSource> first;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x0")]
		public IEnumerable<TSource> _003C_003E3__first;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<TSource> second;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x0")]
		public IEnumerable<TSource> _003C_003E3__second;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator<TSource> _003C_003E7__wrap1;

		[Token(Token = "0x17000013")]
		private TSource System_002ECollections_002EGeneric_002EIEnumerator_003CTSource_003E_002ECurrent
		{
			[Token(Token = "0x60000B6")]
			[DebuggerHidden]
			get
			{
				return (TSource)null;
			}
		}

		[Token(Token = "0x17000014")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000B8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B1")]
		[DebuggerHidden]
		public _003CConcatIterator_003Ed__59(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000B2")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000B3")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60000B5")]
		private void _003C_003Em__Finally2()
		{
		}

		[Token(Token = "0x60000B7")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60000B9")]
		[DebuggerHidden]
		private IEnumerator<TSource> System_002ECollections_002EGeneric_002EIEnumerable_003CTSource_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class _003CDistinctIterator_003Ed__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x0")]
		private TSource _003C_003E2__current;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TSource> comparer;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x0")]
		public IEqualityComparer<TSource> _003C_003E3__comparer;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<TSource> source;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x0")]
		public IEnumerable<TSource> _003C_003E3__source;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x0")]
		private Set<TSource> _003Cset_003E5__2;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator<TSource> _003C_003E7__wrap2;

		[Token(Token = "0x17000015")]
		private TSource System_002ECollections_002EGeneric_002EIEnumerator_003CTSource_003E_002ECurrent
		{
			[Token(Token = "0x60000BF")]
			[DebuggerHidden]
			get
			{
				return (TSource)null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000C1")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BB")]
		[DebuggerHidden]
		public _003CDistinctIterator_003Ed__68(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000BC")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000BD")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60000C0")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60000C2")]
		[DebuggerHidden]
		private IEnumerator<TSource> System_002ECollections_002EGeneric_002EIEnumerable_003CTSource_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class _003CExceptIterator_003Ed__77<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x0")]
		private TSource _003C_003E2__current;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TSource> comparer;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x0")]
		public IEqualityComparer<TSource> _003C_003E3__comparer;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<TSource> second;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x0")]
		public IEnumerable<TSource> _003C_003E3__second;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<TSource> first;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x0")]
		public IEnumerable<TSource> _003C_003E3__first;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x0")]
		private Set<TSource> _003Cset_003E5__2;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator<TSource> _003C_003E7__wrap2;

		[Token(Token = "0x17000017")]
		private TSource System_002ECollections_002EGeneric_002EIEnumerator_003CTSource_003E_002ECurrent
		{
			[Token(Token = "0x60000C8")]
			[DebuggerHidden]
			get
			{
				return (TSource)null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000CA")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C4")]
		[DebuggerHidden]
		public _003CExceptIterator_003Ed__77(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000C5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000C6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60000C9")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60000CB")]
		[DebuggerHidden]
		private IEnumerator<TSource> System_002ECollections_002EGeneric_002EIEnumerable_003CTSource_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class _003CReverseIterator_003Ed__79<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x0")]
		private TSource _003C_003E2__current;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<TSource> source;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x0")]
		public IEnumerable<TSource> _003C_003E3__source;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x0")]
		private Buffer<TSource> _003Cbuffer_003E5__2;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x0")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x17000019")]
		private TSource System_002ECollections_002EGeneric_002EIEnumerator_003CTSource_003E_002ECurrent
		{
			[Token(Token = "0x60000D0")]
			[DebuggerHidden]
			get
			{
				return (TSource)null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000D2")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CD")]
		[DebuggerHidden]
		public _003CReverseIterator_003Ed__79(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000CE")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000CF")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D1")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60000D3")]
		[DebuggerHidden]
		private IEnumerator<TSource> System_002ECollections_002EGeneric_002EIEnumerable_003CTSource_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class _003CCastIterator_003Ed__99<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x0")]
		private TResult _003C_003E2__current;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable source;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x0")]
		public IEnumerable _003C_003E3__source;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator _003C_003E7__wrap1;

		[Token(Token = "0x1700001B")]
		private TResult System_002ECollections_002EGeneric_002EIEnumerator_003CTResult_003E_002ECurrent
		{
			[Token(Token = "0x60000D9")]
			[DebuggerHidden]
			get
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000DB")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D5")]
		[DebuggerHidden]
		public _003CCastIterator_003Ed__99(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000D6")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000D7")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60000DA")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60000DC")]
		[DebuggerHidden]
		private IEnumerator<TResult> System_002ECollections_002EGeneric_002EIEnumerable_003CTResult_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class _003CRangeIterator_003Ed__115 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IDisposable, IEnumerator
	{
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x14")]
		private int _003C_003E2__current;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x18")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x1C")]
		private int start;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x20")]
		public int _003C_003E3__start;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x24")]
		private int count;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x28")]
		public int _003C_003E3__count;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x1700001D")]
		private int System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_003E_002ECurrent
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x778F30", Offset = "0x778130", VA = "0x180778F30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x778F60", Offset = "0x778160", VA = "0x180778F60")]
		[DebuggerHidden]
		public _003CRangeIterator_003Ed__115(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2061DC0", Offset = "0x2060FC0", VA = "0x182061DC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2061EA0", Offset = "0x20610A0", VA = "0x182061EA0", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2061E00", Offset = "0x2061000", VA = "0x182061E00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2061E00", Offset = "0x2061000", VA = "0x182061E00", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x6000036")]
	public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[IteratorStateMachine(typeof(_003CSelectIterator_003Ed__5<, >))]
	private static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[IteratorStateMachine(typeof(_003CSelectManyIterator_003Ed__17<, >))]
	private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[IteratorStateMachine(typeof(_003CConcatIterator_003Ed__59<>))]
	private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[IteratorStateMachine(typeof(_003CDistinctIterator_003Ed__68<>))]
	private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[IteratorStateMachine(typeof(_003CExceptIterator_003Ed__77<>))]
	private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[IteratorStateMachine(typeof(_003CReverseIterator_003Ed__79<>))]
	private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		return default(bool);
	}

	[Token(Token = "0x600004D")]
	public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[IteratorStateMachine(typeof(_003CCastIterator_003Ed__99<>))]
	private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	public static TSource First<TSource>(this IEnumerable<TSource> source)
	{
		return (TSource)null;
	}

	[Token(Token = "0x6000056")]
	public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return (TSource)null;
	}

	[Token(Token = "0x6000057")]
	public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
	{
		return (TSource)null;
	}

	[Token(Token = "0x6000058")]
	public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return (TSource)null;
	}

	[Token(Token = "0x6000059")]
	public static TSource Last<TSource>(this IEnumerable<TSource> source)
	{
		return (TSource)null;
	}

	[Token(Token = "0x600005A")]
	public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
	{
		return (TSource)null;
	}

	[Token(Token = "0x600005B")]
	public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return (TSource)null;
	}

	[Token(Token = "0x600005C")]
	public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
	{
		return (TSource)null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x205FA80", Offset = "0x205EC80", VA = "0x18205FA80")]
	public static IEnumerable<int> Range(int start, int count)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x205FA00", Offset = "0x205EC00", VA = "0x18205FA00")]
	[IteratorStateMachine(typeof(_003CRangeIterator_003Ed__115))]
	private static IEnumerable<int> RangeIterator(int start, int count)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	public static IEnumerable<TResult> Empty<TResult>()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	public static bool Any<TSource>(this IEnumerable<TSource> source)
	{
		return default(bool);
	}

	[Token(Token = "0x6000061")]
	public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return default(bool);
	}

	[Token(Token = "0x6000062")]
	public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return default(bool);
	}

	[Token(Token = "0x6000063")]
	public static int Count<TSource>(this IEnumerable<TSource> source)
	{
		return default(int);
	}

	[Token(Token = "0x6000064")]
	public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return default(int);
	}

	[Token(Token = "0x6000065")]
	public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000066")]
	public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x205FB40", Offset = "0x205ED40", VA = "0x18205FB40")]
	public static int Sum(this IEnumerable<int> source)
	{
		return default(int);
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x205FCF0", Offset = "0x205EEF0", VA = "0x18205FCF0")]
	public static long Sum(this IEnumerable<long> source)
	{
		return default(long);
	}

	[Token(Token = "0x6000069")]
	public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
	{
		return default(int);
	}

	[Token(Token = "0x600006A")]
	public static long Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
	{
		return default(long);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x205F7B0", Offset = "0x205E9B0", VA = "0x18205F7B0")]
	public static int Min(this IEnumerable<int> source)
	{
		return default(int);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x205F560", Offset = "0x205E760", VA = "0x18205F560")]
	public static int Max(this IEnumerable<int> source)
	{
		return default(int);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x205F2C0", Offset = "0x205E4C0", VA = "0x18205F2C0")]
	public static float Max(this IEnumerable<float> source)
	{
		return default(float);
	}

	[Token(Token = "0x600006E")]
	public static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
	{
		return default(int);
	}
}
