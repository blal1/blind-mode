using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200048F")]
public class UxmlAssetAttributeDescription<T> : TypedUxmlAttributeDescription<T> where T : Object
{
	[Token(Token = "0x600223A")]
	public UxmlAssetAttributeDescription()
	{
	}

	[Token(Token = "0x600223B")]
	public override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return null;
	}

	[Token(Token = "0x600223C")]
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, out T value)
	{
		return default(bool);
	}
}
