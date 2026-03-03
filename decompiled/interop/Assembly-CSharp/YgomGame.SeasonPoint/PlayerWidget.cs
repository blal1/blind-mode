using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.SeasonPoint;

[Token(Token = "0x2000A2B")]
public class PlayerWidget : ElementWidgetBehaviourBase<PlayerWidget>
{
	[Token(Token = "0x400902F")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelPlatformPlayerNameGroup;

	[Token(Token = "0x4009030")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelPlatformPlayerIcon;

	[Token(Token = "0x4009031")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelProfileIcon;

	[Token(Token = "0x4009032")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelrootWidget;

	[Token(Token = "0x17000852")]
	public SelectionButton button
	{
		[Token(Token = "0x6003E5C")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6003E5D")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000853")]
	public PlatformPlayerNameGroup platformPlayerNameGroup
	{
		[Token(Token = "0x6003E5E")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6003E5F")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000854")]
	public PlatformPlayerIcon platformPlayerIcon
	{
		[Token(Token = "0x6003E60")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6003E61")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000855")]
	public GameObject profileIconRoot
	{
		[Token(Token = "0x6003E62")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6003E63")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000856")]
	public GameObject rootWidget
	{
		[Token(Token = "0x6003E64")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6003E65")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1400004E")]
	public event Action<PlayerWidget> onClickEvent
	{
		[Token(Token = "0x6003E66")]
		[Address(RVA = "0x8486C0", Offset = "0x8478C0", VA = "0x1808486C0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003E67")]
		[Address(RVA = "0x8488A0", Offset = "0x847AA0", VA = "0x1808488A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400004F")]
	public event Action<PlayerWidget> onSelectedEvent
	{
		[Token(Token = "0x6003E68")]
		[Address(RVA = "0x848770", Offset = "0x847970", VA = "0x180848770")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003E69")]
		[Address(RVA = "0x848950", Offset = "0x847B50", VA = "0x180848950")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003E6A")]
	[Address(RVA = "0x848450", Offset = "0x847650", VA = "0x180848450")]
	public static PlayerWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6003E6B")]
	[Address(RVA = "0x8481E0", Offset = "0x8473E0", VA = "0x1808481E0", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6003E6C")]
	[Address(RVA = "0x848540", Offset = "0x847740", VA = "0x180848540")]
	public void SetProfileIcon(int iconId, int iconFrameId)
	{
	}

	[Token(Token = "0x6003E6D")]
	[Address(RVA = "0x848490", Offset = "0x847690", VA = "0x180848490")]
	public void SetActiveBoard(bool frag)
	{
	}

	[Token(Token = "0x6003E6E")]
	[Address(RVA = "0x848820", Offset = "0x847A20", VA = "0x180848820")]
	public bool isActiveBoard()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E6F")]
	[Address(RVA = "0x81B640", Offset = "0x81A840", VA = "0x18081B640")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6003E70")]
	[Address(RVA = "0x81B620", Offset = "0x81A820", VA = "0x18081B620")]
	private void OnSelected()
	{
	}

	[Token(Token = "0x6003E71")]
	[Address(RVA = "0x8485E0", Offset = "0x8477E0", VA = "0x1808485E0")]
	public PlayerWidget()
	{
	}
}
