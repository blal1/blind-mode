using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000195")]
public abstract class DragAndDropData
{
	[Token(Token = "0x17000220")]
	public abstract object source
	{
		[Token(Token = "0x6000C12")]
		get;
	}

	[Token(Token = "0x17000221")]
	public virtual string[] paths
	{
		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000C11")]
	public abstract object GetGenericData(string key);

	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected DragAndDropData()
	{
	}
}
