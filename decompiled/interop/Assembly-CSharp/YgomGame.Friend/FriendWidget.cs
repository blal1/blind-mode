using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Friend;

[Token(Token = "0x2000DDB")]
public class FriendWidget : ElementWidgetBehaviourBase<FriendWidget>
{
	[Token(Token = "0x400A0E9")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelPlatformPlayerNameGroup;

	[Token(Token = "0x400A0EA")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelPlatformPlayerIcon;

	[Token(Token = "0x400A0EB")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelProfileIcon;

	[Token(Token = "0x400A0EC")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelFollowStateIcon;

	[Token(Token = "0x400A0ED")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelDuelIcon;

	[Token(Token = "0x400A0EE")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelOnlineIcon;

	[Token(Token = "0x400A0EF")]
	[FieldOffset(Offset = "0x58")]
	private readonly string k_ELabelOfflineIcon;

	[Token(Token = "0x400A0F0")]
	[FieldOffset(Offset = "0x60")]
	private readonly string k_ELabelFriendPinLine;

	[Token(Token = "0x400A0F1")]
	[FieldOffset(Offset = "0x68")]
	private readonly string k_ELabelFriendPinLineOn;

	[Token(Token = "0x400A0F2")]
	[FieldOffset(Offset = "0x70")]
	private readonly string k_ELabelFriendPinLineOff;

	[Token(Token = "0x400A0F3")]
	[FieldOffset(Offset = "0x78")]
	private readonly string k_ELabelWallpaper;

	[Token(Token = "0x400A0F4")]
	[FieldOffset(Offset = "0x80")]
	private readonly string k_ELabelRoomBadge;

	[Token(Token = "0x400A0F5")]
	[FieldOffset(Offset = "0x88")]
	private readonly string k_TweenMutual;

	[Token(Token = "0x400A0F6")]
	[FieldOffset(Offset = "0x90")]
	private readonly string k_TweenFollow;

	[Token(Token = "0x400A0F7")]
	[FieldOffset(Offset = "0x98")]
	private readonly string k_TweenFollower;

	[Token(Token = "0x400A0F8")]
	[FieldOffset(Offset = "0xA0")]
	private readonly string k_TweenInvisible;

	[Token(Token = "0x400A0F9")]
	[FieldOffset(Offset = "0xA8")]
	private readonly string k_TweenDuelOn;

	[Token(Token = "0x400A0FA")]
	[FieldOffset(Offset = "0xB0")]
	private readonly string k_TweenDuelOff;

	[Token(Token = "0x17000C38")]
	public SelectionButton button
	{
		[Token(Token = "0x6005378")]
		[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005379")]
		[Address(RVA = "0x42FF70", Offset = "0x42F170", VA = "0x18042FF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C39")]
	public PlatformPlayerNameGroup platformPlayerNameGroup
	{
		[Token(Token = "0x600537A")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600537B")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C3A")]
	public PlatformPlayerIcon platformPlayerIcon
	{
		[Token(Token = "0x600537C")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600537D")]
		[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C3B")]
	public GameObject profileIconRoot
	{
		[Token(Token = "0x600537E")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600537F")]
		[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C3C")]
	public Image wallpaperImage
	{
		[Token(Token = "0x6005380")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005381")]
		[Address(RVA = "0x662500", Offset = "0x661700", VA = "0x180662500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C3D")]
	public GameObject followStateIcon
	{
		[Token(Token = "0x6005382")]
		[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005383")]
		[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C3E")]
	public GameObject roomBadge
	{
		[Token(Token = "0x6005384")]
		[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005385")]
		[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C3F")]
	public GameObject pinLineRoot
	{
		[Token(Token = "0x6005386")]
		[Address(RVA = "0x9A8700", Offset = "0x9A7900", VA = "0x1809A8700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C40")]
	public GameObject pinLineOn
	{
		[Token(Token = "0x6005387")]
		[Address(RVA = "0x9A86A0", Offset = "0x9A78A0", VA = "0x1809A86A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C41")]
	public GameObject pinLineOff
	{
		[Token(Token = "0x6005388")]
		[Address(RVA = "0x9A8640", Offset = "0x9A7840", VA = "0x1809A8640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C42")]
	public bool followStateVisible
	{
		[Token(Token = "0x6005389")]
		[Address(RVA = "0x9A88E0", Offset = "0x9A7AE0", VA = "0x1809A88E0")]
		set
		{
		}
	}

	[Token(Token = "0x1400007E")]
	public event Action<FriendWidget> onClickEvent
	{
		[Token(Token = "0x600538A")]
		[Address(RVA = "0x9A84C0", Offset = "0x9A76C0", VA = "0x1809A84C0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600538B")]
		[Address(RVA = "0x9A8760", Offset = "0x9A7960", VA = "0x1809A8760")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400007F")]
	public event Action<FriendWidget> onSelectedEvent
	{
		[Token(Token = "0x600538C")]
		[Address(RVA = "0x9A8580", Offset = "0x9A7780", VA = "0x1809A8580")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600538D")]
		[Address(RVA = "0x9A8820", Offset = "0x9A7A20", VA = "0x1809A8820")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600538E")]
	[Address(RVA = "0x9A7C40", Offset = "0x9A6E40", VA = "0x1809A7C40")]
	public static FriendWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x600538F")]
	[Address(RVA = "0x9A78E0", Offset = "0x9A6AE0", VA = "0x1809A78E0", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005390")]
	[Address(RVA = "0x9A7DB0", Offset = "0x9A6FB0", VA = "0x1809A7DB0")]
	public void SetProfileIcon(int iconId, int iconFrameId)
	{
	}

	[Token(Token = "0x6005391")]
	[Address(RVA = "0x9A80B0", Offset = "0x9A72B0", VA = "0x1809A80B0")]
	public void SetWallpaper(int wallpaperId)
	{
	}

	[Token(Token = "0x6005392")]
	[Address(RVA = "0x9A7EA0", Offset = "0x9A70A0", VA = "0x1809A7EA0")]
	public void SetStatusText(bool isEnableDuelWatch, bool isOnline)
	{
	}

	[Token(Token = "0x6005393")]
	[Address(RVA = "0x9A7D00", Offset = "0x9A6F00", VA = "0x1809A7D00")]
	public void SetFollowState(FollowState followState)
	{
	}

	[Token(Token = "0x6005394")]
	[Address(RVA = "0x9A7C80", Offset = "0x9A6E80", VA = "0x1809A7C80")]
	private string GetFollowStateTweenLabel(FollowState followState)
	{
		return null;
	}

	[Token(Token = "0x6005395")]
	[Address(RVA = "0x9A7E50", Offset = "0x9A7050", VA = "0x1809A7E50")]
	public void SetRoomBadge(FollowState followState, int inviteRoomId, int inviteTeamId)
	{
	}

	[Token(Token = "0x6005396")]
	[Address(RVA = "0x9A7CC0", Offset = "0x9A6EC0", VA = "0x1809A7CC0")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6005397")]
	[Address(RVA = "0x9A7CE0", Offset = "0x9A6EE0", VA = "0x1809A7CE0")]
	private void OnSelected()
	{
	}

	[Token(Token = "0x6005398")]
	[Address(RVA = "0x9A8190", Offset = "0x9A7390", VA = "0x1809A8190")]
	public FriendWidget()
	{
	}
}
