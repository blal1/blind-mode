using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x20018F9")]
public class LogItemBase : MonoBehaviour
{
	[Token(Token = "0x400E993")]
	[FieldOffset(Offset = "0x20")]
	protected DuelClient m_Host;

	[Token(Token = "0x1700187D")]
	public SelectionItem selectionItemL
	{
		[Token(Token = "0x600A0DA")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600A0DB")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700187E")]
	public SelectionItem selectionItemR
	{
		[Token(Token = "0x600A0DC")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
		[Token(Token = "0x600A0DD")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700187F")]
	public SelectionItem selectionItem0
	{
		[Token(Token = "0x600A0DE")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A0DF")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001880")]
	public SelectionItem selectionItem1
	{
		[Token(Token = "0x600A0E0")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A0E1")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001881")]
	public SelectionItem selectionItem2
	{
		[Token(Token = "0x600A0E2")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A0E3")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001882")]
	public SelectionItem selectionItem3
	{
		[Token(Token = "0x600A0E4")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A0E5")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001883")]
	public SelectionItem selectionItem4
	{
		[Token(Token = "0x600A0E6")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A0E7")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x600A0E8")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380", Slot = "4")]
	public virtual void OnCreated(DuelClient host)
	{
	}

	[Token(Token = "0x600A0E9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public virtual void OnAdded()
	{
	}

	[Token(Token = "0x600A0EA")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public virtual void OnRemoved()
	{
	}

	[Token(Token = "0x600A0EB")]
	[Address(RVA = "0xEE1B20", Offset = "0xEE0D20", VA = "0x180EE1B20")]
	public void SetItemEnable(bool isEnable)
	{
	}

	[Token(Token = "0x600A0EC")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public LogItemBase()
	{
	}
}
