using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200029B")]
internal class PointerDispatchState
{
	[Token(Token = "0x4000A77")]
	[FieldOffset(Offset = "0x10")]
	private IEventHandler[] m_PendingPointerCapture;

	[Token(Token = "0x4000A78")]
	[FieldOffset(Offset = "0x18")]
	private IEventHandler[] m_PointerCapture;

	[Token(Token = "0x4000A79")]
	[FieldOffset(Offset = "0x20")]
	private bool[] m_ShouldSendCompatibilityMouseEvents;

	[Token(Token = "0x6001229")]
	[Address(RVA = "0x2B6BAA0", Offset = "0x2B6ACA0", VA = "0x182B6BAA0")]
	public PointerDispatchState()
	{
	}

	[Token(Token = "0x600122A")]
	[Address(RVA = "0x2B6B8B0", Offset = "0x2B6AAB0", VA = "0x182B6B8B0")]
	internal void Reset()
	{
	}

	[Token(Token = "0x600122B")]
	[Address(RVA = "0x4179D0", Offset = "0x416BD0", VA = "0x1804179D0")]
	public IEventHandler GetCapturingElement(int pointerId)
	{
		return null;
	}

	[Token(Token = "0x600122C")]
	[Address(RVA = "0x2B6B290", Offset = "0x2B6A490", VA = "0x182B6B290")]
	public bool HasPointerCapture(IEventHandler handler, int pointerId)
	{
		return default(bool);
	}

	[Token(Token = "0x600122D")]
	[Address(RVA = "0x2B6B160", Offset = "0x2B6A360", VA = "0x182B6B160")]
	public void CapturePointer(IEventHandler handler, int pointerId)
	{
	}

	[Token(Token = "0x600122E")]
	[Address(RVA = "0x2B6B810", Offset = "0x2B6AA10", VA = "0x182B6B810")]
	public void ReleasePointer(int pointerId)
	{
	}

	[Token(Token = "0x600122F")]
	[Address(RVA = "0x2B6B860", Offset = "0x2B6AA60", VA = "0x182B6B860")]
	public void ReleasePointer(IEventHandler handler, int pointerId)
	{
	}

	[Token(Token = "0x6001230")]
	[Address(RVA = "0x2B6B2F0", Offset = "0x2B6A4F0", VA = "0x182B6B2F0")]
	public void ProcessPointerCapture(int pointerId)
	{
	}

	[Token(Token = "0x6001231")]
	[Address(RVA = "0x2B6B130", Offset = "0x2B6A330", VA = "0x182B6B130")]
	public void ActivateCompatibilityMouseEvents(int pointerId)
	{
	}

	[Token(Token = "0x6001232")]
	[Address(RVA = "0x2B6B2C0", Offset = "0x2B6A4C0", VA = "0x182B6B2C0")]
	public void PreventCompatibilityMouseEvents(int pointerId)
	{
	}

	[Token(Token = "0x6001233")]
	[Address(RVA = "0x2B6B9A0", Offset = "0x2B6ABA0", VA = "0x182B6B9A0")]
	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt)
	{
		return default(bool);
	}
}
