using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000167")]
public readonly struct TreeViewItemData<T>
{
	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x0")]
	[CreateProperty]
	private readonly T m_Data;

	[Token(Token = "0x400070F")]
	[FieldOffset(Offset = "0x0")]
	private readonly IList<TreeViewItemData<T>> m_Children;

	[Token(Token = "0x170001D9")]
	public int id
	{
		[Token(Token = "0x6000AD8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170001DA")]
	public T data
	{
		[Token(Token = "0x6000AD9")]
		get
		{
			return (T)null;
		}
	}

	[Token(Token = "0x170001DB")]
	public IEnumerable<TreeViewItemData<T>> children
	{
		[Token(Token = "0x6000ADA")]
		get
		{
			return null;
		}
	}
}
