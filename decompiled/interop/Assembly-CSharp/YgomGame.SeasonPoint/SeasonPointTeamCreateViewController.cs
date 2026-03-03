using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.FreeScroll;

namespace YgomGame.SeasonPoint;

[Token(Token = "0x2000A38")]
public class SeasonPointTeamCreateViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000A39")]
	private class widgetData
	{
		[Token(Token = "0x40090BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InputFieldWidget inputFieldWidget;

		[Token(Token = "0x40090C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlayerWidget playerWidget;

		[Token(Token = "0x40090C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public long currentPcode;

		[Token(Token = "0x40090C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_Text resultMessage;

		[Token(Token = "0x40090C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TMP_Text inputFieldOverrideText;

		[Token(Token = "0x6003EB4")]
		[Address(RVA = "0x87C340", Offset = "0x87B540", VA = "0x18087C340")]
		public widgetData(InputFieldWidget widget, PlayerWidget playerWidget, long currentPcode, TMP_Text resultMessage, TMP_Text inputFieldOverrideText)
		{
		}
	}

	[Token(Token = "0x40090A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private string L_TemplateRegion;

	[Token(Token = "0x40090A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private string L_TemplateMember1;

	[Token(Token = "0x40090A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private string L_TemplateMember2;

	[Token(Token = "0x40090A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string L_Button;

	[Token(Token = "0x40090AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private string L_TextSetting;

	[Token(Token = "0x40090AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private string L_ButtonSearch;

	[Token(Token = "0x40090AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private string L_PlayerBoard;

	[Token(Token = "0x40090AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private string L_InputField;

	[Token(Token = "0x40090AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private string L_ResultMessage;

	[Token(Token = "0x40090AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private string L_ButtonOK;

	[Token(Token = "0x40090B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private string L_TextHeader;

	[Token(Token = "0x40090B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private string L_ButtonDetail;

	[Token(Token = "0x40090B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private string L_TextRegion;

	[Token(Token = "0x40090B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string L_TextNotice;

	[Token(Token = "0x40090B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private int regionIndex;

	[Token(Token = "0x40090B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private List<(int id, string text)> regionList;

	[Token(Token = "0x40090B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private SelectionButton okButton;

	[Token(Token = "0x40090B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private FreeScrollView m_FreeScrollView;

	[Token(Token = "0x40090B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x40090B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private int pcodeLength;

	[Token(Token = "0x40090BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Dictionary<int, widgetData> widgetDatas;

	[Token(Token = "0x40090BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Dictionary<int, TeamMemberData> teamMemberDatas;

	[Token(Token = "0x40090BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private StringBuilder m_Sb;

	[Token(Token = "0x40090BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private bool m_InputGuard;

	[Token(Token = "0x17000857")]
	public long currentPcode
	{
		[Token(Token = "0x6003EA0")]
		[Address(RVA = "0x49BCE0", Offset = "0x49AEE0", VA = "0x18049BCE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003EA1")]
		[Address(RVA = "0x86F530", Offset = "0x86E730", VA = "0x18086F530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000858")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6003EA2")]
		[Address(RVA = "0x86F390", Offset = "0x86E590", VA = "0x18086F390", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EA3")]
	[Address(RVA = "0x86E470", Offset = "0x86D670", VA = "0x18086E470")]
	public static void Open([Optional] Action callback)
	{
	}

	[Token(Token = "0x6003EA4")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003EA5")]
	[Address(RVA = "0x86DCC0", Offset = "0x86CEC0", VA = "0x18086DCC0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003EA6")]
	[Address(RVA = "0x86CBA0", Offset = "0x86BDA0", VA = "0x18086CBA0")]
	private void InitElemnts()
	{
	}

	[Token(Token = "0x6003EA7")]
	[Address(RVA = "0x86ED70", Offset = "0x86DF70", VA = "0x18086ED70")]
	private void Start()
	{
	}

	[Token(Token = "0x6003EA8")]
	[Address(RVA = "0x86DB50", Offset = "0x86CD50", VA = "0x18086DB50")]
	private void OnClickOK()
	{
	}

	[Token(Token = "0x6003EA9")]
	[Address(RVA = "0x86E760", Offset = "0x86D960", VA = "0x18086E760")]
	private void SetSearchObjects(ElementObjectManager eom, int index)
	{
	}

	[Token(Token = "0x6003EAA")]
	[Address(RVA = "0x86DF30", Offset = "0x86D130", VA = "0x18086DF30")]
	private void OnValueChanged(string input, int index)
	{
	}

	[Token(Token = "0x6003EAB")]
	[Address(RVA = "0x86DDF0", Offset = "0x86CFF0", VA = "0x18086DDF0")]
	private void OnSubmitInputField(string input, int index)
	{
	}

	[Token(Token = "0x6003EAC")]
	[Address(RVA = "0x86E590", Offset = "0x86D790", VA = "0x18086E590")]
	private void RequestSearchIdExecute(long searchPcode, int index)
	{
	}

	[Token(Token = "0x6003EAD")]
	[Address(RVA = "0x86C120", Offset = "0x86B320", VA = "0x18086C120")]
	public void ApplySearchResult(long searchPcode, Dictionary<string, object> hitPlayerData, int index)
	{
	}

	[Token(Token = "0x6003EAE")]
	[Address(RVA = "0x86E5A0", Offset = "0x86D7A0", VA = "0x18086E5A0")]
	private void SetActiveOkButton()
	{
	}

	[Token(Token = "0x6003EAF")]
	[Address(RVA = "0x86CA90", Offset = "0x86BC90", VA = "0x18086CA90")]
	private void CallAPITeamCreate()
	{
	}

	[Token(Token = "0x6003EB0")]
	[Address(RVA = "0x86C730", Offset = "0x86B930", VA = "0x18086C730")]
	private void CallAPIMemberSearch(long searchPcode, int index)
	{
	}

	[Token(Token = "0x6003EB1")]
	[Address(RVA = "0x86EFF0", Offset = "0x86E1F0", VA = "0x18086EFF0")]
	public SeasonPointTeamCreateViewController()
	{
	}
}
