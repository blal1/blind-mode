using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000488")]
[Obsolete("UxmlTemplateFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits>
{
	[Token(Token = "0x17000913")]
	public override string uxmlName
	{
		[Token(Token = "0x600222B")]
		[Address(RVA = "0x2A1F2A0", Offset = "0x2A1E4A0", VA = "0x182A1F2A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000914")]
	public override string uxmlQualifiedName
	{
		[Token(Token = "0x600222C")]
		[Address(RVA = "0x2A1F2D0", Offset = "0x2A1E4D0", VA = "0x182A1F2D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600222D")]
	[Address(RVA = "0x13A7EC0", Offset = "0x13A70C0", VA = "0x1813A7EC0", Slot = "13")]
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc)
	{
		return null;
	}

	[Token(Token = "0x600222E")]
	[Address(RVA = "0x2A1F260", Offset = "0x2A1E460", VA = "0x182A1F260")]
	public UxmlTemplateFactory()
	{
	}
}
