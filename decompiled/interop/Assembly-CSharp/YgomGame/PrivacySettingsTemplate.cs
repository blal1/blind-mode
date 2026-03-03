using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame;

[Token(Token = "0x2000712")]
public class PrivacySettingsTemplate : MonoBehaviour
{
	[Token(Token = "0x4002349")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager m_EOM;

	[Token(Token = "0x400234A")]
	[FieldOffset(Offset = "0x28")]
	private SelectionButton m_LeftButton;

	[Token(Token = "0x400234B")]
	[FieldOffset(Offset = "0x30")]
	private SelectionButton m_RightButton;

	[Token(Token = "0x400234C")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_LeftImageOn;

	[Token(Token = "0x400234D")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_LeftImageOff;

	[Token(Token = "0x400234E")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_RightImageOn;

	[Token(Token = "0x400234F")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_RightImageOff;

	[Token(Token = "0x4002350")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_templateObj;

	[Token(Token = "0x4002351")]
	[FieldOffset(Offset = "0x60")]
	public bool isLeftButton;

	[Token(Token = "0x4002352")]
	[FieldOffset(Offset = "0x61")]
	public bool isRightButton;

	[Token(Token = "0x4002353")]
	[FieldOffset(Offset = "0x68")]
	private readonly string LABEL_LEFT_BUTTON;

	[Token(Token = "0x4002354")]
	[FieldOffset(Offset = "0x70")]
	private readonly string LABEL_RIGHT_BUTTON;

	[Token(Token = "0x6002EB4")]
	[Address(RVA = "0x720BE0", Offset = "0x71FDE0", VA = "0x180720BE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002EB5")]
	[Address(RVA = "0x721050", Offset = "0x720250", VA = "0x180721050")]
	public void SetParams(int id, string informText, bool leftSelected, bool rightSelected, bool selected)
	{
	}

	[Token(Token = "0x6002EB6")]
	[Address(RVA = "0x720F90", Offset = "0x720190", VA = "0x180720F90")]
	public void SetOnClickLeftCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x6002EB7")]
	[Address(RVA = "0x720FF0", Offset = "0x7201F0", VA = "0x180720FF0")]
	public void SetOnClickRightCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x6002EB8")]
	[Address(RVA = "0x720DD0", Offset = "0x71FFD0", VA = "0x180720DD0")]
	public bool OnClickLeft()
	{
		return default(bool);
	}

	[Token(Token = "0x6002EB9")]
	[Address(RVA = "0x720EB0", Offset = "0x7200B0", VA = "0x180720EB0")]
	public bool OnClickRight()
	{
		return default(bool);
	}

	[Token(Token = "0x6002EBA")]
	[Address(RVA = "0x7211C0", Offset = "0x7203C0", VA = "0x1807211C0")]
	public PrivacySettingsTemplate()
	{
	}
}
