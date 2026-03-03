using System;
using System.Collections;
using Il2CppDummyDll;
using Unity.Hierarchy;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000052")]
internal class ReadOnlyHierarchyViewModelList : IList, ICollection, IEnumerable
{
	[Token(Token = "0x2000053")]
	private struct Enumerator : IEnumerator
	{
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x0")]
		private readonly HierarchyViewModel m_HierarchyViewModel;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x8")]
		private HierarchyViewModel.Enumerator m_Enumerator;

		[Token(Token = "0x17000056")]
		public object Current
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x29AA460", Offset = "0x29A9660", VA = "0x1829AA460", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x29AA3F0", Offset = "0x29A95F0", VA = "0x1829AA3F0")]
		public Enumerator(HierarchyViewModel hierarchyViewModel)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x29AA390", Offset = "0x29A9590", VA = "0x1829AA390", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x29AA3A0", Offset = "0x29A95A0", VA = "0x1829AA3A0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x10")]
	private readonly HierarchyViewModel m_HierarchyViewModel;

	[Token(Token = "0x17000051")]
	public bool IsFixedSize
	{
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000052")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000053")]
	public int Count
	{
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x29ABDB0", Offset = "0x29AAFB0", VA = "0x1829ABDB0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000054")]
	public object this[int index]
	{
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x29ABDD0", Offset = "0x29AAFD0", VA = "0x1829ABDD0", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x29ABE80", Offset = "0x29AB080", VA = "0x1829ABE80", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public object SyncRoot
	{
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x29ABE40", Offset = "0x29AB040", VA = "0x1829ABE40", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x29AB920", Offset = "0x29AAB20", VA = "0x1829AB920", Slot = "7")]
	public bool Contains(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x29ABC10", Offset = "0x29AAE10", VA = "0x1829ABC10", Slot = "11")]
	public int IndexOf(object value)
	{
		return default(int);
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public ReadOnlyHierarchyViewModelList(HierarchyViewModel viewModel)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x29AB9C0", Offset = "0x29AABC0", VA = "0x1829AB9C0", Slot = "15")]
	public void CopyTo(Array array, int index)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x29ABB30", Offset = "0x29AAD30", VA = "0x1829ABB30", Slot = "18")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x29AB8A0", Offset = "0x29AAAA0", VA = "0x1829AB8A0", Slot = "6")]
	public int Add(object value)
	{
		return default(int);
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x29AB8E0", Offset = "0x29AAAE0", VA = "0x1829AB8E0", Slot = "8")]
	public void Clear()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x29ABCF0", Offset = "0x29AAEF0", VA = "0x1829ABCF0", Slot = "12")]
	public void Insert(int index, object value)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x29ABD70", Offset = "0x29AAF70", VA = "0x1829ABD70", Slot = "13")]
	public void Remove(object value)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x29ABD30", Offset = "0x29AAF30", VA = "0x1829ABD30", Slot = "14")]
	public void RemoveAt(int index)
	{
	}
}
