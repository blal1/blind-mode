using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.WCS;

[Token(Token = "0x2000736")]
public class WinPredictionTogglePageViewController : DialogViewControllerBase, IBokeSupported
{
	[Token(Token = "0x2000737")]
	public class TeamData
	{
		[Token(Token = "0x4002429")]
		[FieldOffset(Offset = "0x10")]
		public string teamName;

		[Token(Token = "0x400242A")]
		[FieldOffset(Offset = "0x18")]
		public bool isActive;

		[Token(Token = "0x400242B")]
		[FieldOffset(Offset = "0x1C")]
		public int idx;

		[Token(Token = "0x400242C")]
		[FieldOffset(Offset = "0x20")]
		public int Id;

		[Token(Token = "0x6002F69")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TeamData()
		{
		}
	}

	[Token(Token = "0x2000738")]
	public class ToggleButton
	{
		[Token(Token = "0x400242D")]
		[FieldOffset(Offset = "0x10")]
		public ElementObjectManager eom;

		[Token(Token = "0x400242E")]
		[FieldOffset(Offset = "0x18")]
		public GameObject onImage;

		[Token(Token = "0x400242F")]
		[FieldOffset(Offset = "0x20")]
		public GameObject offImage;

		[Token(Token = "0x4002430")]
		[FieldOffset(Offset = "0x28")]
		public SelectionButton button;

		[Token(Token = "0x6002F6A")]
		[Address(RVA = "0x732D20", Offset = "0x731F20", VA = "0x180732D20")]
		public void SetActive(bool active)
		{
		}

		[Token(Token = "0x6002F6B")]
		[Address(RVA = "0x732DC0", Offset = "0x731FC0", VA = "0x180732DC0")]
		public ToggleButton(ElementObjectManager elementObjectManager)
		{
		}
	}

	[Token(Token = "0x2000739")]
	public enum WinPredictionVoteCode
	{
		[Token(Token = "0x4002432")]
		NONE = 0,
		[Token(Token = "0x4002433")]
		ERR_OUT_OF_TERM = 4301,
		[Token(Token = "0x4002434")]
		ERROR_ID_CONFIG = 4313,
		[Token(Token = "0x4002435")]
		ERR_OUT_OF_VOTE_TERM = 4314,
		[Token(Token = "0x4002436")]
		ERR_FINAL_SUPPORT_ABSENT = 4315
	}

	[Token(Token = "0x4002419")]
	private const string ON_BTN_LABEL = "On";

	[Token(Token = "0x400241A")]
	private const string OFF_BTN_LABEL = "Off";

	[Token(Token = "0x400241B")]
	private const string ARGS_INDEX_LABEL = "onToggeleIndex";

	[Token(Token = "0x400241C")]
	[FieldOffset(Offset = "0xE0")]
	private string TEXT_TEAM_GROUP_ON_LABEL;

	[Token(Token = "0x400241D")]
	[FieldOffset(Offset = "0xE8")]
	private string TEXT_TEAM_GROUP_OFF_LABEL;

	[Token(Token = "0x400241E")]
	[FieldOffset(Offset = "0xF0")]
	private string TEXT_TEAM_NAME_ON_LABEL;

	[Token(Token = "0x400241F")]
	[FieldOffset(Offset = "0xF8")]
	private string TEXT_TEAM_NAME_OFF_LABEL;

	[Token(Token = "0x4002420")]
	[FieldOffset(Offset = "0x100")]
	private string FOOTER_BTN_LABEL;

	[Token(Token = "0x4002421")]
	[FieldOffset(Offset = "0x108")]
	private string TOGGLE_TEMPLATE_LABEL;

	[Token(Token = "0x4002422")]
	[FieldOffset(Offset = "0x110")]
	private string CW_TEAM_NAME;

	[Token(Token = "0x4002423")]
	[FieldOffset(Offset = "0x118")]
	private string CW_TEAM_ORDER;

	[Token(Token = "0x4002424")]
	[FieldOffset(Offset = "0x120")]
	private SelectionButton m_FooterButton;

	[Token(Token = "0x4002425")]
	[FieldOffset(Offset = "0x128")]
	private int selectedButtonIndex;

	[Token(Token = "0x4002426")]
	[FieldOffset(Offset = "0x130")]
	private List<TeamData> teamDatas;

	[Token(Token = "0x4002427")]
	[FieldOffset(Offset = "0x138")]
	private Dictionary<int, ToggleButton> toggleButtons;

	[Token(Token = "0x4002428")]
	[FieldOffset(Offset = "0x140")]
	private Dictionary<string, object> m_TeamDataDic;

	[Token(Token = "0x6002F5E")]
	[Address(RVA = "0x731490", Offset = "0x730690", VA = "0x180731490")]
	public static void Open(int index)
	{
	}

	[Token(Token = "0x6002F5F")]
	[Address(RVA = "0x7311A0", Offset = "0x7303A0", VA = "0x1807311A0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002F60")]
	[Address(RVA = "0x731240", Offset = "0x730440", VA = "0x180731240", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6002F61")]
	[Address(RVA = "0x731280", Offset = "0x730480", VA = "0x180731280", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002F62")]
	[Address(RVA = "0x731260", Offset = "0x730460", VA = "0x180731260")]
	private void OnClickFooterButton()
	{
	}

	[Token(Token = "0x6002F63")]
	[Address(RVA = "0x730C10", Offset = "0x72FE10", VA = "0x180730C10")]
	private void Import()
	{
	}

	[Token(Token = "0x6002F64")]
	[Address(RVA = "0x731590", Offset = "0x730790", VA = "0x180731590")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x6002F65")]
	[Address(RVA = "0x730AC0", Offset = "0x72FCC0", VA = "0x180730AC0")]
	private void ClickButton(int idx)
	{
	}

	[Token(Token = "0x6002F66")]
	[Address(RVA = "0x7313B0", Offset = "0x7305B0", VA = "0x1807313B0")]
	private void OpenErrDialog(string title, string text, bool isBack = false)
	{
	}

	[Token(Token = "0x6002F67")]
	[Address(RVA = "0x731BE0", Offset = "0x730DE0", VA = "0x180731BE0")]
	public WinPredictionTogglePageViewController()
	{
	}
}
