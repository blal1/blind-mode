using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.DiceRally;

[Token(Token = "0x2000F95")]
public class DiceRallyPopIcon
{
	[Token(Token = "0x400A910")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly string LABEL_ICN;

	[Token(Token = "0x400A911")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly string LABEL_TXT;

	[Token(Token = "0x400A912")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string LABEL_REWARD;

	[Token(Token = "0x400A913")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string LABEL_IMAGE;

	[Token(Token = "0x400A914")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string LABEL_INFO;

	[Token(Token = "0x400A915")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_Pop;

	[Token(Token = "0x400A916")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_RatioSmall;

	[Token(Token = "0x400A917")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float m_RatioMedium;

	[Token(Token = "0x400A918")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float m_RatioLarge;

	[Token(Token = "0x400A919")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject m_Icon;

	[Token(Token = "0x400A91A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject m_RewardGroup;

	[Token(Token = "0x400A91B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject m_RewardImage;

	[Token(Token = "0x400A91C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400A91D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private RectTransform m_Rect;

	[Token(Token = "0x400A91E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ExtendedTextMeshProUGUI m_Text;

	[Token(Token = "0x400A91F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ExtendedTextMeshProUGUI m_InfoText;

	[Token(Token = "0x6005E97")]
	[Address(RVA = "0xA36310", Offset = "0xA35510", VA = "0x180A36310")]
	public DiceRallyPopIcon(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005E98")]
	[Address(RVA = "0xA36000", Offset = "0xA35200", VA = "0x180A36000")]
	public void Initialize(float angle)
	{
	}

	[Token(Token = "0x6005E99")]
	[Address(RVA = "0xA35660", Offset = "0xA34860", VA = "0x180A35660")]
	public void DispPopIcon(bool active, bool skipPop, Vector2 screenPos, RectTransform boardRect, DiceRallyUtil.ZoomType zoomType, DiceRallySpace selectedSpace, DiceRallyReward nextReward)
	{
	}

	[Token(Token = "0x6005E9A")]
	[Address(RVA = "0xA36210", Offset = "0xA35410", VA = "0x180A36210")]
	public void SetScale(DiceRallyUtil.ZoomType type)
	{
	}

	[Token(Token = "0x6005E9B")]
	[Address(RVA = "0xA361E0", Offset = "0xA353E0", VA = "0x180A361E0")]
	public void SetRatio(DiceRallyUtil.ZoomType type, float ratio)
	{
	}

	[Token(Token = "0x6005E9C")]
	[Address(RVA = "0xA361B0", Offset = "0xA353B0", VA = "0x180A361B0")]
	public void SetInfoText(string str)
	{
	}

	[Token(Token = "0x6005E9D")]
	[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
	public GameObject GetIcon()
	{
		return null;
	}

	[Token(Token = "0x6005E9E")]
	[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
	public ElementObjectManager GetEom()
	{
		return null;
	}

	[Token(Token = "0x6005E9F")]
	[Address(RVA = "0xA35E60", Offset = "0xA35060", VA = "0x180A35E60")]
	public Vector3 GetScale(DiceRallyUtil.ZoomType type)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005EA0")]
	[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
	public GameObject GetRewardGroup()
	{
		return null;
	}

	[Token(Token = "0x6005EA1")]
	[Address(RVA = "0xA35F30", Offset = "0xA35130", VA = "0x180A35F30")]
	public TweenScaleTo GetTween(string label)
	{
		return null;
	}

	[Token(Token = "0x6005EA2")]
	[Address(RVA = "0xA35AF0", Offset = "0xA34CF0", VA = "0x180A35AF0")]
	public string GetPopDesc(DiceRallySpace space, [Optional] DiceRallyReward reward)
	{
		return null;
	}

	[Token(Token = "0x6005EA3")]
	[Address(RVA = "0xA35620", Offset = "0xA34820", VA = "0x180A35620")]
	public void BindReward(DiceRallyReward reward)
	{
	}
}
