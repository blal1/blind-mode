using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200048A")]
[Obsolete("UxmlAttributeOverridesFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits>
{
	[Token(Token = "0x17000915")]
	public override string uxmlName
	{
		[Token(Token = "0x6002230")]
		[Address(RVA = "0x2A1C560", Offset = "0x2A1B760", VA = "0x182A1C560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000916")]
	public override string uxmlQualifiedName
	{
		[Token(Token = "0x6002231")]
		[Address(RVA = "0x2A1C590", Offset = "0x2A1B790", VA = "0x182A1C590", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002232")]
	[Address(RVA = "0x13A7EC0", Offset = "0x13A70C0", VA = "0x1813A7EC0", Slot = "13")]
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc)
	{
		return null;
	}

	[Token(Token = "0x6002233")]
	[Address(RVA = "0x2A1C520", Offset = "0x2A1B720", VA = "0x182A1C520")]
	public UxmlAttributeOverridesFactory()
	{
	}
}
