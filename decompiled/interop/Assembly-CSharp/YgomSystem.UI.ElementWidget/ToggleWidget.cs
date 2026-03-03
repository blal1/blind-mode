using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x2000624")]
public class ToggleWidget : ElementWidgetBase
{
	[Token(Token = "0x4001DB4")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelButton;

	[Token(Token = "0x4001DB5")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelOn;

	[Token(Token = "0x4001DB6")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelOff;

	[Token(Token = "0x4001DB7")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelBadge;

	[Token(Token = "0x4001DB8")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_PLabelSoundClickOn;

	[Token(Token = "0x4001DB9")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_PLabelSoundClickOff;

	[Token(Token = "0x4001DBA")]
	[FieldOffset(Offset = "0x50")]
	public readonly SelectionButton button;

	[Token(Token = "0x4001DBB")]
	[FieldOffset(Offset = "0x58")]
	public readonly GameObject onImage;

	[Token(Token = "0x4001DBC")]
	[FieldOffset(Offset = "0x60")]
	public readonly GameObject offImage;

	[Token(Token = "0x4001DBD")]
	[FieldOffset(Offset = "0x68")]
	public readonly PropertyContainer propertyContainer;

	[Token(Token = "0x4001DBE")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsOn;

	[Token(Token = "0x17000511")]
	public bool isOn
	{
		[Token(Token = "0x6002882")]
		[Address(RVA = "0x49BE90", Offset = "0x49B090", VA = "0x18049BE90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002883")]
		[Address(RVA = "0x6B28E0", Offset = "0x6B1AE0", VA = "0x1806B28E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000512")]
	public GameObject badge
	{
		[Token(Token = "0x6002884")]
		[Address(RVA = "0x6B2800", Offset = "0x6B1A00", VA = "0x1806B2800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000038")]
	public event Action<bool> onChangeValue
	{
		[Token(Token = "0x6002885")]
		[Address(RVA = "0x6B2750", Offset = "0x6B1950", VA = "0x1806B2750")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6002886")]
		[Address(RVA = "0x6B2830", Offset = "0x6B1A30", VA = "0x1806B2830")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6002887")]
	[Address(RVA = "0x6B2470", Offset = "0x6B1670", VA = "0x1806B2470")]
	public ToggleWidget(ElementObjectManager eom, bool isOn = false)
	{
	}

	[Token(Token = "0x6002888")]
	[Address(RVA = "0x6B2370", Offset = "0x6B1570", VA = "0x1806B2370")]
	public void ResetIsOn(bool isOn)
	{
	}

	[Token(Token = "0x6002889")]
	[Address(RVA = "0x6B2380", Offset = "0x6B1580", VA = "0x1806B2380")]
	public void UpdateView()
	{
	}

	[Token(Token = "0x600288A")]
	[Address(RVA = "0x6B2320", Offset = "0x6B1520", VA = "0x1806B2320")]
	private void OnClick()
	{
	}
}
