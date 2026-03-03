using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x20010FF")]
public class OptionToggle : MonoBehaviour
{
	[Token(Token = "0x400B3AF")]
	[FieldOffset(Offset = "0x20")]
	private string m_ButtonLabel;

	[Token(Token = "0x400B3B0")]
	[FieldOffset(Offset = "0x28")]
	private UnityAction m_OnClickAction;

	[Token(Token = "0x400B3B1")]
	private const string LABEL_SBN_BODY = "Body";

	[Token(Token = "0x400B3B2")]
	private const string LABEL_RT_IMAGEOFF = "ImageOff";

	[Token(Token = "0x400B3B3")]
	private const string LABEL_TXT_ITEMTEXT = "TextItem";

	[Token(Token = "0x400B3B4")]
	private const string LABEL_RT_IMAGEON = "ImageOn";

	[Token(Token = "0x400B3B5")]
	private const string LABEL_TXT_DESCTEXT = "TextDescription";

	[Token(Token = "0x400B3B6")]
	[FieldOffset(Offset = "0x30")]
	private bool isOn;

	[Token(Token = "0x17001111")]
	private ElementObjectManager m_eom
	{
		[Token(Token = "0x6006ACB")]
		[Address(RVA = "0xB2E2B0", Offset = "0xB2D4B0", VA = "0x180B2E2B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001112")]
	private RectTransform m_Off
	{
		[Token(Token = "0x6006ACC")]
		[Address(RVA = "0xB2E190", Offset = "0xB2D390", VA = "0x180B2E190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001113")]
	private RectTransform m_On
	{
		[Token(Token = "0x6006ACD")]
		[Address(RVA = "0xB2E220", Offset = "0xB2D420", VA = "0x180B2E220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001114")]
	private Text m_DescText
	{
		[Token(Token = "0x6006ACE")]
		[Address(RVA = "0xB2E070", Offset = "0xB2D270", VA = "0x180B2E070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001115")]
	private Text m_ItemText
	{
		[Token(Token = "0x6006ACF")]
		[Address(RVA = "0xB2E100", Offset = "0xB2D300", VA = "0x180B2E100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006AD0")]
	[Address(RVA = "0xB2E2F0", Offset = "0xB2D4F0", VA = "0x180B2E2F0")]
	private void toggle()
	{
	}

	[Token(Token = "0x6006AD1")]
	[Address(RVA = "0xB2DDD0", Offset = "0xB2CFD0", VA = "0x180B2DDD0")]
	public void Initialize(string title, string desc, bool b)
	{
	}

	[Token(Token = "0x6006AD2")]
	[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
	public string GetButtonLabel()
	{
		return null;
	}

	[Token(Token = "0x6006AD3")]
	[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
	public bool GetEnabledState()
	{
		return default(bool);
	}

	[Token(Token = "0x6006AD4")]
	[Address(RVA = "0xB2DF60", Offset = "0xB2D160", VA = "0x180B2DF60")]
	private void Start()
	{
	}

	[Token(Token = "0x6006AD5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Update()
	{
	}

	[Token(Token = "0x6006AD6")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
	public void SetOnClickCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006AD7")]
	[Address(RVA = "0xB2DD40", Offset = "0xB2CF40", VA = "0x180B2DD40")]
	public SelectionButton GetButton()
	{
		return null;
	}

	[Token(Token = "0x6006AD8")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public OptionToggle()
	{
	}
}
