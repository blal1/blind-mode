using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000135")]
public class RepeatButton : TextElement
{
	[Token(Token = "0x2000136")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<RepeatButton, UxmlTraits>
	{
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x2AEF6F0", Offset = "0x2AEE8F0", VA = "0x182AEF6F0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000137")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : TextElement.UxmlTraits
	{
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0xD0")]
		private UxmlLongAttributeDescription m_Delay;

		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0xD8")]
		private UxmlLongAttributeDescription m_Interval;

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x2AEFC70", Offset = "0x2AEEE70", VA = "0x182AEFC70", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x2AF3340", Offset = "0x2AF2540", VA = "0x182AF3340")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40005EF")]
	[FieldOffset(Offset = "0x5A8")]
	private Clickable m_Clickable;

	[Token(Token = "0x40005F0")]
	[FieldOffset(Offset = "0x5B0")]
	private bool m_AcceptClicksIfDisabled;

	[Token(Token = "0x40005F1")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x17000195")]
	internal bool acceptClicksIfDisabled
	{
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x2ADF9D0", Offset = "0x2ADEBD0", VA = "0x182ADF9D0")]
		set
		{
		}
	}

	[Token(Token = "0x6000973")]
	[Address(RVA = "0x2ADF940", Offset = "0x2ADEB40", VA = "0x182ADF940")]
	public RepeatButton()
	{
	}

	[Token(Token = "0x6000974")]
	[Address(RVA = "0x2ADF870", Offset = "0x2ADEA70", VA = "0x182ADF870")]
	public RepeatButton(Action clickEvent, long delay, long interval)
	{
	}

	[Token(Token = "0x6000975")]
	[Address(RVA = "0x2ADF740", Offset = "0x2ADE940", VA = "0x182ADF740")]
	public void SetAction(Action clickEvent, long delay, long interval)
	{
	}

	[Token(Token = "0x6000976")]
	[Address(RVA = "0x2ADF710", Offset = "0x2ADE910", VA = "0x182ADF710")]
	internal void AddAction(Action clickEvent)
	{
	}
}
