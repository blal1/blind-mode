using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000021")]
internal readonly struct BindingTarget
{
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x0")]
	public readonly VisualElement element;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x8")]
	public readonly BindingId bindingId;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2975610", Offset = "0x2974810", VA = "0x182975610")]
	public BindingTarget(VisualElement element, in BindingId bindingId)
	{
	}
}
