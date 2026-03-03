using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;

[Token(Token = "0x2000092")]
public class DuelStartOverlayViewController_Team : BaseMenuViewController
{
	[Token(Token = "0x2000093")]
	private class TeamInfo
	{
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x10")]
		public readonly object info;

		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x18")]
		public readonly int teamNameMrk;

		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x1C")]
		public readonly int userNum;

		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x20")]
		public readonly Dictionary<string, object> membersInfo;

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x3FBAD0", Offset = "0x3FACD0", VA = "0x1803FBAD0")]
		public TeamInfo(object info, int teamNameMrk, int userNum, Dictionary<string, object> membersInfo)
		{
		}
	}

	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string PREFAB_PATH;

	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0xD0")]
	private bool isFinish;

	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string E_TweenFinish;

	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string E_RootPlayer;

	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string E_RootRival;

	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string E_TextTeamName;

	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string E_RootProfile;

	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x100")]
	private readonly string E_ImageIcon;

	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x108")]
	private readonly string E_PlatformPlayerIcon;

	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x110")]
	private readonly string E_PlatformPlayerNameGroup;

	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x118")]
	private ElementObjectManager playerEom;

	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x120")]
	private ElementObjectManager rivalEom;

	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x128")]
	private GameObject tweenFinish;

	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private int MAX_MEMBERS;

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x3ECEF0", Offset = "0x3EC0F0", VA = "0x1803ECEF0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x3ECBA0", Offset = "0x3EBDA0", VA = "0x1803ECBA0")]
	private void DispTeam(int myid, ElementObjectManager teamEom, bool isPlayerTeam)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x3ECDC0", Offset = "0x3EBFC0", VA = "0x1803ECDC0")]
	private void InitTeam()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x3ED160", Offset = "0x3EC360", VA = "0x1803ED160")]
	private TeamInfo SetTeamInfo(object teamInfo)
	{
		return null;
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x3ED290", Offset = "0x3EC490", VA = "0x1803ED290")]
	private void SetTeam(ElementObjectManager eom, TeamInfo teamInfo, bool isPlayerTeam)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x3ECD90", Offset = "0x3EBF90", VA = "0x1803ECD90")]
	public GameObject GetHideObject()
	{
		return null;
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x3ED9D0", Offset = "0x3ECBD0", VA = "0x1803ED9D0")]
	public void Start()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x3EDA80", Offset = "0x3ECC80", VA = "0x1803EDA80")]
	public void Update()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x3EDBB0", Offset = "0x3ECDB0", VA = "0x1803EDBB0")]
	public DuelStartOverlayViewController_Team()
	{
	}
}
