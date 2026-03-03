using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200022A")]
[EventCategory(EventCategory.PointerMove)]
public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent>
{
	[Token(Token = "0x170002DB")]
	internal bool isHandledByDraggable
	{
		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x62D9D0", Offset = "0x62CBD0", VA = "0x18062D9D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x62DFC0", Offset = "0x62D1C0", VA = "0x18062DFC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170002DC")]
	internal bool isPointerDown
	{
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x2B22460", Offset = "0x2B21660", VA = "0x182B22460")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002DD")]
	internal bool isPointerUp
	{
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x2B224C0", Offset = "0x2B216C0", VA = "0x182B224C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x2B22300", Offset = "0x2B21500", VA = "0x182B22300")]
	static PointerMoveEvent()
	{
	}

	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x2B21F80", Offset = "0x2B21180", VA = "0x182B21F80", Slot = "13")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x2B22000", Offset = "0x2B21200", VA = "0x182B22000")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000F68")]
	[Address(RVA = "0x2B223E0", Offset = "0x2B215E0", VA = "0x182B223E0")]
	public PointerMoveEvent()
	{
	}

	[Token(Token = "0x6000F69")]
	[Address(RVA = "0x2B22100", Offset = "0x2B21300", VA = "0x182B22100", Slot = "7")]
	protected internal override void PreDispatch(IPanel panel)
	{
	}

	[Token(Token = "0x6000F6A")]
	[Address(RVA = "0x2B22060", Offset = "0x2B21260", VA = "0x182B22060", Slot = "9")]
	protected internal override void PostDispatch(IPanel panel)
	{
	}
}
