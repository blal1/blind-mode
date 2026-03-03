using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002B6")]
internal struct TextureId
{
	[Token(Token = "0x4000AF2")]
	[FieldOffset(Offset = "0x0")]
	private readonly int m_Index;

	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0x0")]
	public static readonly TextureId invalid;

	[Token(Token = "0x17000399")]
	public int index
	{
		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x2B6CFA0", Offset = "0x2B6C1A0", VA = "0x182B6CFA0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60012E6")]
	[Address(RVA = "0x2B6CF90", Offset = "0x2B6C190", VA = "0x182B6CF90")]
	public TextureId(int index)
	{
	}

	[Token(Token = "0x60012E8")]
	[Address(RVA = "0x2B6CE60", Offset = "0x2B6C060", VA = "0x182B6CE60")]
	public float ConvertToGpu()
	{
		return default(float);
	}

	[Token(Token = "0x60012E9")]
	[Address(RVA = "0x2B6CEB0", Offset = "0x2B6C0B0", VA = "0x182B6CEB0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60012EA")]
	[Address(RVA = "0x27CBF20", Offset = "0x27CB120", VA = "0x1827CBF20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60012EB")]
	[Address(RVA = "0x27FEAA0", Offset = "0x27FDCA0", VA = "0x1827FEAA0")]
	public static bool operator ==(TextureId left, TextureId right)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60012EC")]
	[Address(RVA = "0x2B6CFB0", Offset = "0x2B6C1B0", VA = "0x182B6CFB0")]
	public static bool operator !=(TextureId left, TextureId right)
	{
		return default(bool);
	}
}
