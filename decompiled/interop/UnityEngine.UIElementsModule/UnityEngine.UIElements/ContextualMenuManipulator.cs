using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200006F")]
public class ContextualMenuManipulator : PointerManipulator
{
	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x28")]
	private Action<ContextualMenuPopulateEvent> m_MenuBuilder;

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x29A9EF0", Offset = "0x29A90F0", VA = "0x1829A9EF0")]
	public ContextualMenuManipulator(Action<ContextualMenuPopulateEvent> menuBuilder)
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x29A9870", Offset = "0x29A8A70", VA = "0x1829A9870", Slot = "5")]
	protected override void RegisterCallbacksOnTarget()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x29A9BB0", Offset = "0x29A8DB0", VA = "0x1829A9BB0", Slot = "6")]
	protected override void UnregisterCallbacksFromTarget()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x29A9300", Offset = "0x29A8500", VA = "0x1829A9300")]
	protected bool IsOSXContextualMenuPlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x29A97D0", Offset = "0x29A89D0", VA = "0x1829A97D0")]
	private void OnPointerUpEvent(IPointerEvent evt)
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x29A93A0", Offset = "0x29A85A0", VA = "0x1829A93A0")]
	private void OnPointerDownEventOSX(IPointerEvent evt)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x29A96D0", Offset = "0x29A88D0", VA = "0x1829A96D0")]
	private void OnPointerUpEventOSX(IPointerEvent evt)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x29A9620", Offset = "0x29A8820", VA = "0x1829A9620")]
	private void OnPointerMoveEvent(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x29A94A0", Offset = "0x29A86A0", VA = "0x1829A94A0")]
	private void OnPointerMoveEventOSX(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x29A97D0", Offset = "0x29A89D0", VA = "0x1829A97D0")]
	private void ProcessPointerEvent(IPointerEvent evt)
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x29A9340", Offset = "0x29A8540", VA = "0x1829A9340")]
	private void OnKeyUpEvent(KeyUpEvent evt)
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x29A9200", Offset = "0x29A8400", VA = "0x1829A9200")]
	private void DoDisplayMenu(EventBase evt)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x93B280", Offset = "0x93A480", VA = "0x18093B280")]
	private void OnContextualMenuEvent(ContextualMenuPopulateEvent evt)
	{
	}
}
