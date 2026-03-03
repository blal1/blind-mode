using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200001D")]
public readonly struct BindingActivationContext
{
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x0")]
	private readonly VisualElement m_TargetElement;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x8")]
	private readonly BindingId m_BindingId;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2975610", Offset = "0x2974810", VA = "0x182975610")]
	internal BindingActivationContext(VisualElement element, in BindingId property)
	{
	}
}
