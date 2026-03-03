using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200004E")]
public class Clickable : PointerManipulator
{
	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x38")]
	private readonly long m_Delay;

	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x40")]
	private readonly long m_Interval;

	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x54")]
	private int m_ActivePointerId;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x58")]
	private bool m_AcceptClicksIfDisabled;

	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x60")]
	private IVisualElementScheduledItem m_Repeater;

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x68")]
	private IVisualElementScheduledItem m_PendingActivePseudoStateReset;

	[Token(Token = "0x1700004B")]
	protected bool active
	{
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x8C82C0", Offset = "0x8C74C0", VA = "0x1808C82C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public Vector2 lastMousePosition
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x29A8550", Offset = "0x29A7750", VA = "0x1829A8550")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x29A8730", Offset = "0x29A7930", VA = "0x1829A8730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	internal bool acceptClicksIfDisabled
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x29A86C0", Offset = "0x29A78C0", VA = "0x1829A86C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	private InvokePolicy invokePolicy
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x29A8540", Offset = "0x29A7740", VA = "0x1829A8540")]
		get
		{
			return default(InvokePolicy);
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<EventBase> clickedWithEventInfo
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x29A83F0", Offset = "0x29A75F0", VA = "0x1829A83F0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x29A8570", Offset = "0x29A7770", VA = "0x1829A8570")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action clicked
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x29A84A0", Offset = "0x29A76A0", VA = "0x1829A84A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x29A8620", Offset = "0x29A7820", VA = "0x1829A8620")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x29A8060", Offset = "0x29A7260", VA = "0x1829A8060")]
	public Clickable(Action handler, long delay, long interval)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x29A81A0", Offset = "0x29A73A0", VA = "0x1829A81A0")]
	public Clickable(Action<EventBase> handler)
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x29A82C0", Offset = "0x29A74C0", VA = "0x1829A82C0")]
	public Clickable(Action handler)
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x29A71B0", Offset = "0x29A63B0", VA = "0x1829A71B0")]
	private void OnTimer(TimerState timerState)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x29A6ED0", Offset = "0x29A60D0", VA = "0x1829A6ED0")]
	private bool IsRepeatable()
	{
		return default(bool);
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x29A78E0", Offset = "0x29A6AE0", VA = "0x1829A78E0", Slot = "5")]
	protected override void RegisterCallbacksOnTarget()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x29A7DA0", Offset = "0x29A6FA0", VA = "0x1829A7DA0", Slot = "6")]
	protected override void UnregisterCallbacksFromTarget()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x29A6FE0", Offset = "0x29A61E0", VA = "0x1829A6FE0")]
	protected void OnPointerDown(PointerDownEvent evt)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x29A7080", Offset = "0x29A6280", VA = "0x1829A7080")]
	protected void OnPointerMove(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x29A7100", Offset = "0x29A6300", VA = "0x1829A7100")]
	protected void OnPointerUp(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x29A6EF0", Offset = "0x29A60F0", VA = "0x1829A6EF0")]
	private void OnPointerCancel(PointerCancelEvent evt)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x29A6F70", Offset = "0x29A6170", VA = "0x1829A6F70")]
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x29A6E00", Offset = "0x29A6000", VA = "0x1829A6E00")]
	private bool ContainsPointer(int pointerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x29A6E80", Offset = "0x29A6080", VA = "0x1829A6E80")]
	protected void Invoke(EventBase evt)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x29A7C20", Offset = "0x29A6E20", VA = "0x1829A7C20")]
	internal void SimulateSingleClick(EventBase evt, int delayMs = 100)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x29A7BB0", Offset = "0x29A6DB0", VA = "0x1829A7BB0")]
	private void ResetActivePseudoState()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x29A73E0", Offset = "0x29A65E0", VA = "0x1829A73E0", Slot = "8")]
	protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x29A76C0", Offset = "0x29A68C0", VA = "0x1829A76C0", Slot = "9")]
	protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x29A7750", Offset = "0x29A6950", VA = "0x1829A7750", Slot = "10")]
	protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x29A72C0", Offset = "0x29A64C0", VA = "0x1829A72C0", Slot = "11")]
	protected virtual void ProcessCancelEvent(EventBase evt, int pointerId)
	{
	}
}
