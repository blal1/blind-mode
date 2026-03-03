using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem.UI;

namespace YgomGame;

[Token(Token = "0x20006C1")]
public class WCSProfile : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x40021E2")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string MATE_TRANSFORM_SETTING_PATH;

	[Token(Token = "0x40021E3")]
	public const string k_PREF_PATH = "DeckEdit/WCSProfile";

	[Token(Token = "0x40021E4")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string BTN_MENU_TMP_LABEL;

	[Token(Token = "0x40021E5")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string ROOT_MENU_LABEL;

	[Token(Token = "0x40021E6")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string BTN_LABEL;

	[Token(Token = "0x40021E7")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string TMP_LABEL;

	[Token(Token = "0x40021E8")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string OBJ_MATE_LABEL;

	[Token(Token = "0x40021E9")]
	[FieldOffset(Offset = "0x100")]
	private readonly string ROOT_OVERVIEW_LABEL;

	[Token(Token = "0x40021EA")]
	[FieldOffset(Offset = "0x108")]
	private MateTransformSetting m_ModelLocateSettings;

	[Token(Token = "0x40021EB")]
	[FieldOffset(Offset = "0x110")]
	private ProfileCard profileCard;

	[Token(Token = "0x40021EC")]
	[FieldOffset(Offset = "0x118")]
	private int charaId;

	[Token(Token = "0x40021ED")]
	[FieldOffset(Offset = "0x120")]
	private GameObject rootMenu;

	[Token(Token = "0x40021EE")]
	[FieldOffset(Offset = "0x128")]
	private Character2D chara;

	[Token(Token = "0x40021EF")]
	[FieldOffset(Offset = "0x130")]
	private DefinitionSetting matchingDefine;

	[Token(Token = "0x40021F0")]
	[FieldOffset(Offset = "0x138")]
	private GameObject rootOverview;

	[Token(Token = "0x40021F1")]
	[FieldOffset(Offset = "0x140")]
	private SelectionButton m_ButtonCaution;

	[Token(Token = "0x40021F2")]
	[FieldOffset(Offset = "0x148")]
	private bool isNeedCharaCreate;

	[Token(Token = "0x40021F3")]
	[FieldOffset(Offset = "0x0")]
	private static string k_ELabelButtonCaution;

	[Token(Token = "0x40021F4")]
	[FieldOffset(Offset = "0x8")]
	private static int memberIndex;

	[Token(Token = "0x40021F5")]
	[FieldOffset(Offset = "0xC")]
	private static bool isEdit;

	[Token(Token = "0x6002D03")]
	[Address(RVA = "0x717870", Offset = "0x716A70", VA = "0x180717870")]
	public static void Open(ViewControllerManager vcm, int index, bool edit)
	{
	}

	[Token(Token = "0x6002D04")]
	[Address(RVA = "0x7175B0", Offset = "0x7167B0", VA = "0x1807175B0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002D05")]
	[Address(RVA = "0x717650", Offset = "0x716850", VA = "0x180717650", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6002D06")]
	[Address(RVA = "0x717740", Offset = "0x716940", VA = "0x180717740", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002D07")]
	[Address(RVA = "0x7179C0", Offset = "0x716BC0", VA = "0x1807179C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002D08")]
	[Address(RVA = "0x717380", Offset = "0x716580", VA = "0x180717380")]
	private void InitProfileCard(Dictionary<string, object> profileDic)
	{
	}

	[Token(Token = "0x6002D09")]
	[Address(RVA = "0x7171D0", Offset = "0x7163D0", VA = "0x1807171D0")]
	private void InitMate(Dictionary<string, object> profileDic)
	{
	}

	[Token(Token = "0x6002D0A")]
	[Address(RVA = "0x716C40", Offset = "0x715E40", VA = "0x180716C40")]
	private void InitMateSettings(MateTransformSetting modelLocateSettings)
	{
	}

	[Token(Token = "0x6002D0B")]
	[Address(RVA = "0x717920", Offset = "0x716B20", VA = "0x180717920")]
	private void PlayMateMotion()
	{
	}

	[Token(Token = "0x6002D0C")]
	[Address(RVA = "0x7168E0", Offset = "0x715AE0", VA = "0x1807168E0")]
	private void InitButtons()
	{
	}

	[Token(Token = "0x6002D0D")]
	[Address(RVA = "0x717E90", Offset = "0x717090", VA = "0x180717E90")]
	private void UpdateProfile(Dictionary<string, object> profileDic)
	{
	}

	[Token(Token = "0x6002D0E")]
	[Address(RVA = "0x717820", Offset = "0x716A20", VA = "0x180717820")]
	private void OpenCaution()
	{
	}

	[Token(Token = "0x6002D0F")]
	[Address(RVA = "0x7167F0", Offset = "0x7159F0", VA = "0x1807167F0")]
	private Dictionary<string, object> GetMemberProfile(int index)
	{
		return null;
	}

	[Token(Token = "0x6002D10")]
	[Address(RVA = "0x716880", Offset = "0x715A80", VA = "0x180716880")]
	private int GetMyIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6002D11")]
	[Address(RVA = "0x7180D0", Offset = "0x7172D0", VA = "0x1807180D0")]
	public WCSProfile()
	{
	}
}
