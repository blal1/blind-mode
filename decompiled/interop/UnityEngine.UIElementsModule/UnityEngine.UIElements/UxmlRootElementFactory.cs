using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000484")]
[Obsolete("UxmlRootElementFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits>
{
	[Token(Token = "0x1700090F")]
	public override string uxmlName
	{
		[Token(Token = "0x6002221")]
		[Address(RVA = "0x2A1EA90", Offset = "0x2A1DC90", VA = "0x182A1EA90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000910")]
	public override string uxmlQualifiedName
	{
		[Token(Token = "0x6002222")]
		[Address(RVA = "0x2A1EAC0", Offset = "0x2A1DCC0", VA = "0x182A1EAC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002223")]
	[Address(RVA = "0x13A7EC0", Offset = "0x13A70C0", VA = "0x1813A7EC0", Slot = "13")]
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc)
	{
		return null;
	}

	[Token(Token = "0x6002224")]
	[Address(RVA = "0x2A1EA50", Offset = "0x2A1DC50", VA = "0x182A1EA50")]
	public UxmlRootElementFactory()
	{
	}
}
