using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F62")]
public class ProductWCSRoomHeaderWidget : ElementWidgetBase
{
	[Token(Token = "0x2000F63")]
	public class TeamView
	{
		[Token(Token = "0x400A7B8")]
		[FieldOffset(Offset = "0x10")]
		public TMP_Text teamName;

		[Token(Token = "0x400A7B9")]
		[FieldOffset(Offset = "0x18")]
		public TMP_Text areaName;

		[Token(Token = "0x400A7BA")]
		[FieldOffset(Offset = "0x20")]
		public Image teamIcon;

		[Token(Token = "0x6005D60")]
		[Address(RVA = "0xA4AE60", Offset = "0xA4A060", VA = "0x180A4AE60")]
		public TeamView(ElementObjectManager eom)
		{
		}
	}

	[Token(Token = "0x400A7B2")]
	private const string k_ELabelTeam1 = "Team1";

	[Token(Token = "0x400A7B3")]
	private const string k_ELabelTeam2 = "Team2";

	[Token(Token = "0x400A7B4")]
	private const string k_ELabelTeamNameText = "text";

	[Token(Token = "0x400A7B5")]
	private const string k_ELabelTeamAreaText = "textGroup";

	[Token(Token = "0x400A7B6")]
	private const string k_ELabelTeamIcon = "icon";

	[Token(Token = "0x400A7B7")]
	[FieldOffset(Offset = "0x20")]
	private TeamView[] m_teamViews;

	[Token(Token = "0x17000EB4")]
	public TeamView team1
	{
		[Token(Token = "0x6005D5C")]
		[Address(RVA = "0xA2B340", Offset = "0xA2A540", VA = "0x180A2B340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EB5")]
	public TeamView team2
	{
		[Token(Token = "0x6005D5D")]
		[Address(RVA = "0xA2B370", Offset = "0xA2A570", VA = "0x180A2B370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005D5E")]
	[Address(RVA = "0xA2B170", Offset = "0xA2A370", VA = "0x180A2B170")]
	public ProductWCSRoomHeaderWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005D5F")]
	[Address(RVA = "0xA2AF70", Offset = "0xA2A170", VA = "0x180A2AF70")]
	public void SetView(DuelLiveWCSRoomData roomData)
	{
	}
}
