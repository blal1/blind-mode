using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000486")]
[Obsolete("UxmlStyleFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
public class UxmlStyleFactory : UxmlFactory<VisualElement, UxmlStyleTraits>
{
	[Token(Token = "0x17000911")]
	public override string uxmlName
	{
		[Token(Token = "0x6002226")]
		[Address(RVA = "0x2A1F070", Offset = "0x2A1E270", VA = "0x182A1F070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000912")]
	public override string uxmlQualifiedName
	{
		[Token(Token = "0x6002227")]
		[Address(RVA = "0x2A1F0A0", Offset = "0x2A1E2A0", VA = "0x182A1F0A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002228")]
	[Address(RVA = "0x13A7EC0", Offset = "0x13A70C0", VA = "0x1813A7EC0", Slot = "13")]
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc)
	{
		return null;
	}

	[Token(Token = "0x6002229")]
	[Address(RVA = "0x2A1F030", Offset = "0x2A1E230", VA = "0x182A1F030")]
	public UxmlStyleFactory()
	{
	}
}
