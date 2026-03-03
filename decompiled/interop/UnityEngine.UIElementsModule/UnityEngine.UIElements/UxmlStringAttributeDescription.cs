using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000493")]
public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<string>
{
	[Token(Token = "0x6002250")]
	[Address(RVA = "0x2A1EF80", Offset = "0x2A1E180", VA = "0x182A1EF80")]
	public UxmlStringAttributeDescription()
	{
	}

	[Token(Token = "0x6002251")]
	[Address(RVA = "0x2A1EC70", Offset = "0x2A1DE70", VA = "0x182A1EC70", Slot = "4")]
	public override string GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return null;
	}

	[Token(Token = "0x6002252")]
	[Address(RVA = "0x2A1EDF0", Offset = "0x2A1DFF0", VA = "0x182A1EDF0")]
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value)
	{
		return default(bool);
	}
}
