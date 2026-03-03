using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200028B")]
internal class RepaintData
{
	[Token(Token = "0x17000336")]
	public Matrix4x4 currentOffset
	{
		[Token(Token = "0x600115F")]
		[Address(RVA = "0x199DD40", Offset = "0x199CF40", VA = "0x18199DD40")]
		[CompilerGenerated]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Token(Token = "0x17000337")]
	public Rect currentWorldClip
	{
		[Token(Token = "0x6001160")]
		[Address(RVA = "0x595FC0", Offset = "0x5951C0", VA = "0x180595FC0")]
		[CompilerGenerated]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x17000338")]
	public Event repaintEvent
	{
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6001163")]
	[Address(RVA = "0x2B3A560", Offset = "0x2B39760", VA = "0x182B3A560")]
	public RepaintData()
	{
	}
}
