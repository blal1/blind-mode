using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000041")]
public readonly struct DataSourceContextChanged
{
	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x0")]
	private readonly VisualElement m_TargetElement;

	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x8")]
	private readonly BindingId m_BindingId;

	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0xA0")]
	private readonly DataSourceContext m_PreviousContext;

	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x138")]
	private readonly DataSourceContext m_NewContext;

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x29AA0B0", Offset = "0x29A92B0", VA = "0x1829AA0B0")]
	internal DataSourceContextChanged(VisualElement element, in BindingId bindingId, in DataSourceContext previousContext, in DataSourceContext newContext)
	{
	}
}
