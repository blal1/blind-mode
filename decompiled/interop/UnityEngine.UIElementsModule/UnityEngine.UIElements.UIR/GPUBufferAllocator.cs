using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000529")]
internal class GPUBufferAllocator
{
	[Token(Token = "0x4001132")]
	[FieldOffset(Offset = "0x10")]
	private BestFitAllocator m_Low;

	[Token(Token = "0x4001133")]
	[FieldOffset(Offset = "0x18")]
	private BestFitAllocator m_High;

	[Token(Token = "0x17000982")]
	public bool isEmpty
	{
		[Token(Token = "0x60024E5")]
		[Address(RVA = "0x2A4B400", Offset = "0x2A4A600", VA = "0x182A4B400")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60024E2")]
	[Address(RVA = "0x2A4B350", Offset = "0x2A4A550", VA = "0x182A4B350")]
	public GPUBufferAllocator(uint maxSize)
	{
	}

	[Token(Token = "0x60024E3")]
	[Address(RVA = "0x2A4B090", Offset = "0x2A4A290", VA = "0x182A4B090")]
	public Alloc Allocate(uint size, bool shortLived)
	{
		return default(Alloc);
	}

	[Token(Token = "0x60024E4")]
	[Address(RVA = "0x2A4B2A0", Offset = "0x2A4A4A0", VA = "0x182A4B2A0")]
	public void Free(Alloc alloc)
	{
	}

	[Token(Token = "0x60024E6")]
	[Address(RVA = "0x2A4B320", Offset = "0x2A4A520", VA = "0x182A4B320")]
	private bool HighLowCollide()
	{
		return default(bool);
	}
}
