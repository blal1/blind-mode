using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000177")]
internal struct CountingBloomFilter
{
	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x0")]
	private unsafe fixed byte m_Counters[16384];

	[Token(Token = "0x6000B32")]
	[Address(RVA = "0x2AF4050", Offset = "0x2AF3250", VA = "0x182AF4050")]
	private void AdjustSlot(uint index, bool increment)
	{
	}

	[Token(Token = "0x6000B33")]
	[Address(RVA = "0x2AF40B0", Offset = "0x2AF32B0", VA = "0x182AF40B0")]
	private uint Hash1(uint hash)
	{
		return default(uint);
	}

	[Token(Token = "0x6000B34")]
	[Address(RVA = "0x2AF40C0", Offset = "0x2AF32C0", VA = "0x182AF40C0")]
	private uint Hash2(uint hash)
	{
		return default(uint);
	}

	[Token(Token = "0x6000B35")]
	[Address(RVA = "0x2AF4100", Offset = "0x2AF3300", VA = "0x182AF4100")]
	private bool IsSlotEmpty(uint index)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B36")]
	[Address(RVA = "0x2AF40D0", Offset = "0x2AF32D0", VA = "0x182AF40D0")]
	public void InsertHash(uint hash)
	{
	}

	[Token(Token = "0x6000B37")]
	[Address(RVA = "0x2AF4110", Offset = "0x2AF3310", VA = "0x182AF4110")]
	public void RemoveHash(uint hash)
	{
	}

	[Token(Token = "0x6000B38")]
	[Address(RVA = "0x2AF4080", Offset = "0x2AF3280", VA = "0x182AF4080")]
	public bool ContainsHash(uint hash)
	{
		return default(bool);
	}
}
