using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck;

[Token(Token = "0x20010FD")]
public class FilterToggle : MonoBehaviour
{
	[Token(Token = "0x400B38F")]
	[FieldOffset(Offset = "0x20")]
	private UnityAction m_OnClickAction;

	[Token(Token = "0x400B390")]
	[FieldOffset(Offset = "0x28")]
	private UnityAction m_OnSelectAction;

	[Token(Token = "0x400B391")]
	[FieldOffset(Offset = "0x30")]
	private UnityAction m_OnDeselectAction;

	[Token(Token = "0x400B392")]
	private const string LABEL_RT_IMAGEOFF = "ImageOff";

	[Token(Token = "0x400B393")]
	private const string LABEL_RT_IMAGEON = "ImageOn";

	[Token(Token = "0x400B394")]
	private const string LABEL_TXT = "Text";

	[Token(Token = "0x400B395")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400B396")]
	[FieldOffset(Offset = "0x40")]
	private RectTransform m_Off;

	[Token(Token = "0x400B397")]
	[FieldOffset(Offset = "0x48")]
	private RectTransform m_On;

	[Token(Token = "0x400B398")]
	[FieldOffset(Offset = "0x50")]
	private ExtendedTextMeshProUGUI m_TextTMP;

	[Token(Token = "0x400B399")]
	[FieldOffset(Offset = "0x58")]
	private bool isInitilaized;

	[Token(Token = "0x17001102")]
	public bool isOn
	{
		[Token(Token = "0x6006A9A")]
		[Address(RVA = "0x453D40", Offset = "0x452F40", VA = "0x180453D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006A9B")]
		[Address(RVA = "0x453DA0", Offset = "0x452FA0", VA = "0x180453DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001103")]
	public string m_Label
	{
		[Token(Token = "0x6006A9C")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A9D")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001104")]
	public SelectionButton m_Button
	{
		[Token(Token = "0x6006A9E")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A9F")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6006AA0")]
	[Address(RVA = "0xB17220", Offset = "0xB16420", VA = "0x180B17220")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x6006AA1")]
	[Address(RVA = "0xB17380", Offset = "0xB16580", VA = "0x180B17380")]
	public void Initialize(string label, string text, bool isOn)
	{
	}

	[Token(Token = "0x6006AA2")]
	[Address(RVA = "0xB17210", Offset = "0xB16410", VA = "0x180B17210")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006AA3")]
	[Address(RVA = "0xB174F0", Offset = "0xB166F0", VA = "0x180B174F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6006AA4")]
	[Address(RVA = "0xB17660", Offset = "0xB16860", VA = "0x180B17660")]
	private void Toggle()
	{
	}

	[Token(Token = "0x6006AA5")]
	[Address(RVA = "0xB17400", Offset = "0xB16600", VA = "0x180B17400")]
	public void SetOn(bool isOn)
	{
	}

	[Token(Token = "0x6006AA6")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void SetOnClickCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006AA7")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
	public void SetSelectCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006AA8")]
	[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
	public void SetDeSelectCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006AA9")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public FilterToggle()
	{
	}
}
