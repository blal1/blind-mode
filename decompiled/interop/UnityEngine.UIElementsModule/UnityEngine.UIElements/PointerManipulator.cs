using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200029C")]
public abstract class PointerManipulator : MouseManipulator
{
	[Token(Token = "0x4000A7A")]
	[FieldOffset(Offset = "0x20")]
	private int m_CurrentPointerId;

	[Token(Token = "0x6001234")]
	[Address(RVA = "0x2B6BC60", Offset = "0x2B6AE60", VA = "0x182B6BC60")]
	protected bool CanStartManipulation(IPointerEvent e)
	{
		return default(bool);
	}

	[Token(Token = "0x6001235")]
	[Address(RVA = "0x2B6BDE0", Offset = "0x2B6AFE0", VA = "0x182B6BDE0")]
	protected bool CanStopManipulation(IPointerEvent e)
	{
		return default(bool);
	}

	[Token(Token = "0x6001236")]
	[Address(RVA = "0x2B6BE40", Offset = "0x2B6B040", VA = "0x182B6BE40")]
	protected PointerManipulator()
	{
	}
}
