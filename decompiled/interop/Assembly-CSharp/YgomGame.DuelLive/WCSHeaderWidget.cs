using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F67")]
public class WCSHeaderWidget : ElementWidgetBase
{
	[Token(Token = "0x400A7FA")]
	private const string k_ELabelWCSHeader = "WCSHeader";

	[Token(Token = "0x400A7FB")]
	private const string k_ELabelWCSTitleText = "TextWCSTitle";

	[Token(Token = "0x400A7FC")]
	private const string k_ELabelFilterOpenButton = "ButtonFilter";

	[Token(Token = "0x400A7FD")]
	private const string k_ELabelFilterResetButton = "ButtonTrash";

	[Token(Token = "0x400A7FE")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_root;

	[Token(Token = "0x400A7FF")]
	[FieldOffset(Offset = "0x28")]
	private ExtendedTextMeshProUGUI m_titleText;

	[Token(Token = "0x400A800")]
	[FieldOffset(Offset = "0x30")]
	private SelectionButton m_filterOpenButton;

	[Token(Token = "0x400A801")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_filterOnObj;

	[Token(Token = "0x400A802")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_filterIconOnObj;

	[Token(Token = "0x400A803")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_filterOffObj;

	[Token(Token = "0x400A804")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_filterIconOffObj;

	[Token(Token = "0x400A805")]
	[FieldOffset(Offset = "0x58")]
	private SelectionButton m_filterResetButton;

	[Token(Token = "0x6005D7F")]
	[Address(RVA = "0xA4F040", Offset = "0xA4E240", VA = "0x180A4F040")]
	public WCSHeaderWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005D80")]
	[Address(RVA = "0xA4EFE0", Offset = "0xA4E1E0", VA = "0x180A4EFE0")]
	public void Show(bool visible)
	{
	}

	[Token(Token = "0x6005D81")]
	[Address(RVA = "0x747B50", Offset = "0x746D50", VA = "0x180747B50")]
	public void SetText(string text)
	{
	}

	[Token(Token = "0x6005D82")]
	[Address(RVA = "0xA4EF40", Offset = "0xA4E140", VA = "0x180A4EF40")]
	public void SetFilterButtonLamp(bool onoff)
	{
	}

	[Token(Token = "0x6005D83")]
	[Address(RVA = "0xA4EE30", Offset = "0xA4E030", VA = "0x180A4EE30")]
	public void EnableFilterButtons(bool enable)
	{
	}

	[Token(Token = "0x6005D84")]
	[Address(RVA = "0xA4EE90", Offset = "0xA4E090", VA = "0x180A4EE90")]
	public void SetActiveButtons(bool enable)
	{
	}
}
