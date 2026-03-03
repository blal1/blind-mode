using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000499")]
public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<int>
{
	[Token(Token = "0x6002263")]
	[Address(RVA = "0x2A1D9B0", Offset = "0x2A1CBB0", VA = "0x182A1D9B0")]
	public UxmlIntAttributeDescription()
	{
	}

	[Token(Token = "0x6002264")]
	[Address(RVA = "0x2A1D6A0", Offset = "0x2A1C8A0", VA = "0x182A1D6A0", Slot = "4")]
	public override int GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return default(int);
	}

	[Token(Token = "0x6002265")]
	[Address(RVA = "0x2A1D820", Offset = "0x2A1CA20", VA = "0x182A1D820")]
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value)
	{
		return default(bool);
	}

	[Token(Token = "0x6002266")]
	[Address(RVA = "0x2A1D660", Offset = "0x2A1C860", VA = "0x182A1D660")]
	private static int ConvertValueToInt(string v, int defaultValue)
	{
		return default(int);
	}
}
