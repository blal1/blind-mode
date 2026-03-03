using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000121")]
[UxmlObject]
[DefaultMember("Item")]
public class SortColumnDescriptions : ICollection<SortColumnDescription>, IEnumerable<SortColumnDescription>, IEnumerable
{
	[Token(Token = "0x2000122")]
	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> where T : SortColumnDescriptions, new()
	{
		[Token(Token = "0x600091A")]
		public UxmlObjectFactory()
		{
		}
	}

	[Token(Token = "0x2000123")]
	[Obsolete("UxmlObjectFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	internal class UxmlObjectFactory : UxmlObjectFactory<SortColumnDescriptions>
	{
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x2AEF870", Offset = "0x2AEEA70", VA = "0x182AEF870")]
		public UxmlObjectFactory()
		{
		}
	}

	[Token(Token = "0x2000124")]
	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	internal class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : SortColumnDescriptions
	{
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x0")]
		private readonly UxmlObjectListAttributeDescription<SortColumnDescription> m_SortColumnDescriptions;

		[Token(Token = "0x600091C")]
		public override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x600091D")]
		public UxmlObjectTraits()
		{
		}
	}

	[Token(Token = "0x40005B0")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private readonly IList<SortColumnDescription> m_Descriptions;

	[Token(Token = "0x17000186")]
	public int Count
	{
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x2AEC620", Offset = "0x2AEB820", VA = "0x182AEC620", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000187")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x2AEC670", Offset = "0x2AEB870", VA = "0x182AEC670", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000023")]
	internal event Action changed
	{
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x2AEC580", Offset = "0x2AEB780", VA = "0x182AEC580")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x2AEC6C0", Offset = "0x2AEB8C0", VA = "0x182AEC6C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600090E")]
	[Address(RVA = "0x2AEC020", Offset = "0x2AEB220", VA = "0x182AEC020", Slot = "11")]
	public IEnumerator<SortColumnDescription> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600090F")]
	[Address(RVA = "0x2AEC020", Offset = "0x2AEB220", VA = "0x182AEC020", Slot = "12")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000910")]
	[Address(RVA = "0x2AEBCF0", Offset = "0x2AEAEF0", VA = "0x182AEBCF0", Slot = "6")]
	public void Add(SortColumnDescription item)
	{
	}

	[Token(Token = "0x6000911")]
	[Address(RVA = "0x2AEBD60", Offset = "0x2AEAF60", VA = "0x182AEBD60", Slot = "7")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000912")]
	[Address(RVA = "0x2AEBEF0", Offset = "0x2AEB0F0", VA = "0x182AEBEF0", Slot = "8")]
	public bool Contains(SortColumnDescription item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000913")]
	[Address(RVA = "0x2AEBF50", Offset = "0x2AEB150", VA = "0x182AEBF50", Slot = "9")]
	public void CopyTo(SortColumnDescription[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x6000914")]
	[Address(RVA = "0x2AEC330", Offset = "0x2AEB530", VA = "0x182AEC330", Slot = "10")]
	public bool Remove(SortColumnDescription desc)
	{
		return default(bool);
	}

	[Token(Token = "0x6000915")]
	[Address(RVA = "0x3FC740", Offset = "0x3FB940", VA = "0x1803FC740")]
	private void OnDescriptionChanged(SortColumnDescription desc)
	{
	}

	[Token(Token = "0x6000918")]
	[Address(RVA = "0x2AEC070", Offset = "0x2AEB270", VA = "0x182AEC070")]
	public void Insert(int index, SortColumnDescription desc)
	{
	}

	[Token(Token = "0x6000919")]
	[Address(RVA = "0x2AEC500", Offset = "0x2AEB700", VA = "0x182AEC500")]
	public SortColumnDescriptions()
	{
	}
}
