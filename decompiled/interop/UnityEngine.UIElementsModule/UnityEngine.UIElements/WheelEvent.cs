using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001FD")]
public class WheelEvent : MouseEventBase<WheelEvent>
{
	[Token(Token = "0x17000290")]
	public Vector3 delta
	{
		[Token(Token = "0x6000E50")]
		[Address(RVA = "0x2B26860", Offset = "0x2B25A60", VA = "0x182B26860")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x2B26880", Offset = "0x2B25A80", VA = "0x182B26880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0x2B26700", Offset = "0x2B25900", VA = "0x182B26700")]
	static WheelEvent()
	{
	}

	[Token(Token = "0x6000E52")]
	[Address(RVA = "0x2B26450", Offset = "0x2B25650", VA = "0x182B26450")]
	public new static WheelEvent GetPooled(Event systemEvent)
	{
		return null;
	}

	[Token(Token = "0x6000E53")]
	[Address(RVA = "0x2B26550", Offset = "0x2B25750", VA = "0x182B26550")]
	internal static WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition, EventModifiers modifiers = EventModifiers.None)
	{
		return null;
	}

	[Token(Token = "0x6000E54")]
	[Address(RVA = "0x2B264E0", Offset = "0x2B256E0", VA = "0x182B264E0")]
	internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent)
	{
		return null;
	}

	[Token(Token = "0x6000E55")]
	[Address(RVA = "0x2B26620", Offset = "0x2B25820", VA = "0x182B26620", Slot = "13")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000E56")]
	[Address(RVA = "0x2B266A0", Offset = "0x2B258A0", VA = "0x182B266A0")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000E57")]
	[Address(RVA = "0x2B267E0", Offset = "0x2B259E0", VA = "0x182B267E0")]
	public WheelEvent()
	{
	}

	[Token(Token = "0x6000E58")]
	[Address(RVA = "0x2B263B0", Offset = "0x2B255B0", VA = "0x182B263B0", Slot = "10")]
	internal override void Dispatch(BaseVisualElementPanel panel)
	{
	}
}
