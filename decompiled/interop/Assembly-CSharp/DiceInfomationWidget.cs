using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.DiceRally;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

[Token(Token = "0x2000037")]
public class DiceInfomationWidget : MonoBehaviour
{
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x20")]
	private readonly string IMG_DICEGAUGE_LABEL;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x28")]
	private readonly string TXT_DICEGAUGEINFO_LABEL;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x30")]
	private readonly string IMG_REWARD_LABEL;

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x38")]
	private readonly string TXT_REWARD_LABEL;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x40")]
	private readonly string BTN_REWARDSHORTCUT_LABEL;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x48")]
	private int m_DicePoint;

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x4C")]
	private int m_DicePointMax;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x50")]
	private ElementObjectManager m_WidgetEOM;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x58")]
	private ElementObjectManager m_DiceGaugeEOM;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x60")]
	private ElementObjectManager m_NextRewardEOM;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x68")]
	private SelectionButton m_RewardShortcutButton;

	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x70")]
	private Image m_GaugeImage;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x78")]
	private GameObject m_NextReward;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x80")]
	private ExtendedTextMeshProUGUI m_NextText;

	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x88")]
	private ExtendedTextMeshProUGUI m_RewardText;

	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x90")]
	private ExtendedTextMeshProUGUI m_GaugeInfoText;

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x3DAFF0", Offset = "0x3DA1F0", VA = "0x1803DAFF0")]
	public void Initalize(int dicePoint = 0, int dicePointMax = 500)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x3DB2A0", Offset = "0x3DA4A0", VA = "0x1803DB2A0")]
	public void ResetReward()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x3DB460", Offset = "0x3DA660", VA = "0x1803DB460")]
	public void UpdateReward(int next, DiceRallyReward reward)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x3DB310", Offset = "0x3DA510", VA = "0x1803DB310")]
	public void SetDicePoint(int point)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x3DB430", Offset = "0x3DA630", VA = "0x1803DB430")]
	public void SetOnClickedCallback(UnityAction action)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x3DB620", Offset = "0x3DA820", VA = "0x1803DB620")]
	public DiceInfomationWidget()
	{
	}
}
