using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x20010FC")]
public class FilterLinkMark : MonoBehaviour
{
	[Token(Token = "0x400B384")]
	[FieldOffset(Offset = "0x20")]
	private UnityAction m_OnClickAction;

	[Token(Token = "0x400B385")]
	[FieldOffset(Offset = "0x28")]
	private UnityAction m_OnSelectAction;

	[Token(Token = "0x400B386")]
	[FieldOffset(Offset = "0x30")]
	private UnityAction m_OnDeselectAction;

	[Token(Token = "0x400B387")]
	private const string LABEL_RT_IMAGEOFF = "ImageOff";

	[Token(Token = "0x400B388")]
	private const string LABEL_RT_IMAGEON = "ImageOn";

	[Token(Token = "0x400B389")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400B38A")]
	[FieldOffset(Offset = "0x40")]
	private RectTransform m_Off;

	[Token(Token = "0x400B38B")]
	[FieldOffset(Offset = "0x48")]
	private RectTransform m_On;

	[Token(Token = "0x170010FF")]
	public bool isOn
	{
		[Token(Token = "0x6006A87")]
		[Address(RVA = "0x3E1DE0", Offset = "0x3E0FE0", VA = "0x1803E1DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006A88")]
		[Address(RVA = "0x3E1DF0", Offset = "0x3E0FF0", VA = "0x1803E1DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001100")]
	public string m_Label
	{
		[Token(Token = "0x6006A89")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A8A")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001101")]
	public SelectionButton m_Button
	{
		[Token(Token = "0x6006A8B")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A8C")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6006A8D")]
	[Address(RVA = "0xB16C90", Offset = "0xB15E90", VA = "0x180B16C90")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x6006A8E")]
	[Address(RVA = "0xB16D90", Offset = "0xB15F90", VA = "0x180B16D90")]
	public void Initialize(string label, bool isOn)
	{
	}

	[Token(Token = "0x6006A8F")]
	[Address(RVA = "0xB16C80", Offset = "0xB15E80", VA = "0x180B16C80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006A90")]
	[Address(RVA = "0xB16E90", Offset = "0xB16090", VA = "0x180B16E90")]
	private void Start()
	{
	}

	[Token(Token = "0x6006A91")]
	[Address(RVA = "0xB17000", Offset = "0xB16200", VA = "0x180B17000")]
	private void Toggle()
	{
	}

	[Token(Token = "0x6006A92")]
	[Address(RVA = "0xB16E20", Offset = "0xB16020", VA = "0x180B16E20")]
	public void SetOn(bool isOn)
	{
	}

	[Token(Token = "0x6006A93")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void SetOnClickCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006A94")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
	public void SetSelectCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006A95")]
	[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
	public void SetDeSelectCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006A96")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public FilterLinkMark()
	{
	}
}
