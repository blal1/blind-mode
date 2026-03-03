using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000273")]
public class KeyboardNavigationManipulator : Manipulator
{
	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x18")]
	private readonly Action<KeyboardNavigationOperation, EventBase> m_Action;

	[Token(Token = "0x600111C")]
	[Address(RVA = "0x6A1440", Offset = "0x6A0640", VA = "0x1806A1440")]
	public KeyboardNavigationManipulator(Action<KeyboardNavigationOperation, EventBase> action)
	{
	}

	[Token(Token = "0x600111D")]
	[Address(RVA = "0x2B33430", Offset = "0x2B32630", VA = "0x182B33430", Slot = "5")]
	protected override void RegisterCallbacksOnTarget()
	{
	}

	[Token(Token = "0x600111E")]
	[Address(RVA = "0x2B33710", Offset = "0x2B32910", VA = "0x182B33710", Slot = "6")]
	protected override void UnregisterCallbacksFromTarget()
	{
	}

	[Token(Token = "0x600111F")]
	[Address(RVA = "0x2B331F0", Offset = "0x2B323F0", VA = "0x182B331F0")]
	internal void OnKeyDown(KeyDownEvent evt)
	{
	}

	[Token(Token = "0x6001120")]
	[Address(RVA = "0x2B33300", Offset = "0x2B32500", VA = "0x182B33300")]
	private void OnNavigationCancel(NavigationCancelEvent evt)
	{
	}

	[Token(Token = "0x6001121")]
	[Address(RVA = "0x2B33400", Offset = "0x2B32600", VA = "0x182B33400")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt)
	{
	}

	[Token(Token = "0x6001122")]
	[Address(RVA = "0x2B33330", Offset = "0x2B32530", VA = "0x182B33330")]
	private void OnNavigationMove(NavigationMoveEvent evt)
	{
	}

	[Token(Token = "0x6001123")]
	[Address(RVA = "0x2AD45E0", Offset = "0x2AD37E0", VA = "0x182AD45E0")]
	private void Invoke(KeyboardNavigationOperation operation, EventBase evt)
	{
	}
}
