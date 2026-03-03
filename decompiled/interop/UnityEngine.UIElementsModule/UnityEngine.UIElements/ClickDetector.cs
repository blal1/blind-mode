using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200004F")]
internal class ClickDetector
{
	[Token(Token = "0x2000050")]
	private class ButtonClickStatus
	{
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x10")]
		public VisualElement m_Target;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 m_PointerDownPosition;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x28")]
		public long m_LastPointerDownTime;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x30")]
		public int m_ClickCount;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x29A62C0", Offset = "0x29A54C0", VA = "0x1829A62C0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ButtonClickStatus()
		{
		}
	}

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x10")]
	private List<ButtonClickStatus> m_ClickStatus;

	[Token(Token = "0x1700004F")]
	internal static int s_DoubleClickTime
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x29A6D50", Offset = "0x29A5F50", VA = "0x1829A6D50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x29A6DA0", Offset = "0x29A5FA0", VA = "0x1829A6DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x29A6AD0", Offset = "0x29A5CD0", VA = "0x1829A6AD0")]
	public ClickDetector()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x29A68F0", Offset = "0x29A5AF0", VA = "0x1829A68F0")]
	private void StartClickTracking(EventBase evt)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x29A66D0", Offset = "0x29A58D0", VA = "0x1829A66D0")]
	private void SendClickEvent(EventBase evt)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x29A6330", Offset = "0x29A5530", VA = "0x1829A6330")]
	private void CancelClickTracking(EventBase evt)
	{
	}

	[Token(Token = "0x6000260")]
	public void ProcessEvent<TEvent>(PointerEventBase<TEvent> evt) where TEvent : PointerEventBase<TEvent>, new()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x29A6530", Offset = "0x29A5730", VA = "0x1829A6530")]
	private static bool ContainsPointer(VisualElement element, IPointerEvent pe)
	{
		return default(bool);
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x29A63D0", Offset = "0x29A55D0", VA = "0x1829A63D0")]
	internal void Cleanup(List<VisualElement> elements)
	{
	}
}
