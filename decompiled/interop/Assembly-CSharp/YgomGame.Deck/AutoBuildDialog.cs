using System;
using Il2CppDummyDll;
using TMPro;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x2001051")]
public class AutoBuildDialog : SelectDialogViewControllerBase<DeckEditViewController2.AutoBuildSetting, int, int, DeckEditViewController2.AutoBuildSetting>, IBokeSupported
{
	[Token(Token = "0x400ADE1")]
	private const string PREFAB_PATH_AUTOBUILDDIALOG = "DeckEdit/AutoBuildDialog";

	[Token(Token = "0x400ADE2")]
	private const string LABEL_TXT_BUILD_TYPE = "TextBuildType";

	[Token(Token = "0x400ADE3")]
	private const string LABEL_TXT_OWNED_RARITY = "TextOwnedRaritySetting";

	[Token(Token = "0x400ADE4")]
	private const string LABEL_TXT_DECK_NUM = "TextDeckNumSetting";

	[Token(Token = "0x400ADE5")]
	private const string LABEL_BTN_CANCEL = "ButtonCancel";

	[Token(Token = "0x400ADE6")]
	private const string LABEL_BTN_BUILD_DECK = "ButtonBuild";

	[Token(Token = "0x400ADE7")]
	private const string LABEL_BTN_BUILD_TYPE = "ButtonBuildType";

	[Token(Token = "0x400ADE8")]
	private const string LABEL_BTN_OWNED_RARITY = "ButtonOwnedRaritySetting";

	[Token(Token = "0x400ADE9")]
	private const string LABEL_BTN_DECK_NUM = "ButtonDeckNumSetting";

	[Token(Token = "0x400ADEA")]
	private const string LABEL_BTN_BUILD = "ButtonBuild";

	[Token(Token = "0x400ADEB")]
	[FieldOffset(Offset = "0xE0")]
	private TMP_Text m_BuildTypeSetting;

	[Token(Token = "0x400ADEC")]
	[FieldOffset(Offset = "0xE8")]
	private TMP_Text m_OwnedRaritySetting;

	[Token(Token = "0x400ADED")]
	[FieldOffset(Offset = "0xF0")]
	private TMP_Text m_DeckNumSetting;

	[Token(Token = "0x400ADEE")]
	[FieldOffset(Offset = "0xF8")]
	private SelectionButton m_BuildTypeButton;

	[Token(Token = "0x400ADEF")]
	[FieldOffset(Offset = "0x100")]
	private SelectionButton m_OwnedRarityButton;

	[Token(Token = "0x400ADF0")]
	[FieldOffset(Offset = "0x108")]
	private SelectionButton m_DeckNumButton;

	[Token(Token = "0x400ADF1")]
	[FieldOffset(Offset = "0x110")]
	private DeckEditViewController2.AutoBuildSetting m_Settings;

	[Token(Token = "0x400ADF2")]
	[FieldOffset(Offset = "0x11C")]
	private int m_MainDeckNum;

	[Token(Token = "0x400ADF3")]
	[FieldOffset(Offset = "0x0")]
	private static string[] m_BuildTypeText;

	[Token(Token = "0x400ADF4")]
	[FieldOffset(Offset = "0x8")]
	private static string[] m_OwnedRaritySettingText;

	[Token(Token = "0x60062CB")]
	[Address(RVA = "0xA84D80", Offset = "0xA83F80", VA = "0x180A84D80")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x60062CC")]
	[Address(RVA = "0xA85C90", Offset = "0xA84E90", VA = "0x180A85C90")]
	public static void Open(DeckEditViewController2.AutoBuildSetting setting, int mainDeckNum, int extraDeckNum, Action<DeckEditViewController2.AutoBuildSetting> buildCallback)
	{
	}

	[Token(Token = "0x60062CD")]
	[Address(RVA = "0xA85270", Offset = "0xA84470", VA = "0x180A85270", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60062CE")]
	[Address(RVA = "0xA85880", Offset = "0xA84A80", VA = "0x180A85880", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60062CF")]
	[Address(RVA = "0xA860C0", Offset = "0xA852C0", VA = "0x180A860C0")]
	private void UpdateButtonValue()
	{
	}

	[Token(Token = "0x60062D0")]
	[Address(RVA = "0xA852F0", Offset = "0xA844F0", VA = "0x180A852F0")]
	private void OnClickBuildTypeSettingButton()
	{
	}

	[Token(Token = "0x60062D1")]
	[Address(RVA = "0xA85700", Offset = "0xA84900", VA = "0x180A85700")]
	private void OnClickOwnedRaritySettingButton()
	{
	}

	[Token(Token = "0x60062D2")]
	[Address(RVA = "0xA854D0", Offset = "0xA846D0", VA = "0x180A854D0")]
	private void OnClickDeckNumSettingButton()
	{
	}

	[Token(Token = "0x60062D3")]
	[Address(RVA = "0xA86310", Offset = "0xA85510", VA = "0x180A86310")]
	public AutoBuildDialog()
	{
	}
}
