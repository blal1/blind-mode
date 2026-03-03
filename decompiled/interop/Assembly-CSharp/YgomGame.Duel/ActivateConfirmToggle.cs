using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Settings;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001836")]
public class ActivateConfirmToggle : MonoBehaviour
{
	[Token(Token = "0x400E2E5")]
	[FieldOffset(Offset = "0x20")]
	private DuelHUD duelHUD;

	[Token(Token = "0x400E2E6")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager ui;

	[Token(Token = "0x400E2E7")]
	[FieldOffset(Offset = "0x30")]
	private SelectionButton button;

	[Token(Token = "0x400E2E8")]
	[FieldOffset(Offset = "0x38")]
	private SelectionItem shortcut;

	[Token(Token = "0x400E2E9")]
	[FieldOffset(Offset = "0x40")]
	private GameObject autoIcon;

	[Token(Token = "0x400E2EA")]
	[FieldOffset(Offset = "0x48")]
	private GameObject onIcon;

	[Token(Token = "0x400E2EB")]
	[FieldOffset(Offset = "0x50")]
	private GameObject offIcon;

	[Token(Token = "0x400E2EC")]
	[FieldOffset(Offset = "0x58")]
	private GameObject shortcutIcon;

	[Token(Token = "0x400E2ED")]
	[FieldOffset(Offset = "0x60")]
	private Image autoIconImage;

	[Token(Token = "0x400E2EE")]
	[FieldOffset(Offset = "0x68")]
	private Image onIconImage;

	[Token(Token = "0x400E2EF")]
	[FieldOffset(Offset = "0x70")]
	private Image offIconImage;

	[Token(Token = "0x400E2F0")]
	[FieldOffset(Offset = "0x78")]
	private DuelClient.ActivateConfirmMode reqMode;

	[Token(Token = "0x400E2F1")]
	[FieldOffset(Offset = "0x7C")]
	private DuelClient.ActivateConfirmMode buttonMode;

	[Token(Token = "0x400E2F2")]
	[FieldOffset(Offset = "0x80")]
	private float setOnTimer;

	[Token(Token = "0x400E2F3")]
	[FieldOffset(Offset = "0x84")]
	private float setOffTimer;

	[Token(Token = "0x400E2F4")]
	private const float setDelayTime = 0.2f;

	[Token(Token = "0x400E2F5")]
	[FieldOffset(Offset = "0x88")]
	private bool reqDelaySet;

	[Token(Token = "0x400E2F6")]
	[FieldOffset(Offset = "0x89")]
	private bool callbackRegisted;

	[Token(Token = "0x400E2F7")]
	[FieldOffset(Offset = "0x90")]
	private List<uint> callbackIDs;

	[Token(Token = "0x17001747")]
	public bool forceCancelMode
	{
		[Token(Token = "0x60099D1")]
		[Address(RVA = "0xDB8210", Offset = "0xDB7410", VA = "0x180DB8210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60099D2")]
		[Address(RVA = "0xE348F0", Offset = "0xE33AF0", VA = "0x180E348F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60099D3")]
	[Address(RVA = "0xE33060", Offset = "0xE32260", VA = "0x180E33060")]
	public void Initialize(ElementObjectManager ui, DuelHUD duelHUD)
	{
	}

	[Token(Token = "0x60099D4")]
	[Address(RVA = "0xE33870", Offset = "0xE32A70", VA = "0x180E33870")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60099D5")]
	[Address(RVA = "0xE33770", Offset = "0xE32970", VA = "0x180E33770")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60099D6")]
	[Address(RVA = "0xE346E0", Offset = "0xE338E0", VA = "0x180E346E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60099D7")]
	[Address(RVA = "0xE33690", Offset = "0xE32890", VA = "0x180E33690")]
	public void OnClickToggle(bool playActionAnime, bool playSE = false)
	{
	}

	[Token(Token = "0x60099D8")]
	[Address(RVA = "0xE33D90", Offset = "0xE32F90", VA = "0x180E33D90")]
	private void SetMode(DuelClient.ActivateConfirmMode mode)
	{
	}

	[Token(Token = "0x60099D9")]
	[Address(RVA = "0x55E610", Offset = "0x55D810", VA = "0x18055E610")]
	public void SetButtonMode(DuelClient.ActivateConfirmMode mode)
	{
	}

	[Token(Token = "0x60099DA")]
	[Address(RVA = "0x732730", Offset = "0x731930", VA = "0x180732730")]
	public void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x60099DB")]
	[Address(RVA = "0xE33CB0", Offset = "0xE32EB0", VA = "0x180E33CB0")]
	public void SetManualType(SettingsUtil.DuelParam.MANUAL_TYPE type, bool customUseSwitch)
	{
	}

	[Token(Token = "0x60099DC")]
	[Address(RVA = "0xE33C40", Offset = "0xE32E40", VA = "0x180E33C40")]
	public void SetIcon(DuelClient.ActivateConfirmMode mode)
	{
	}

	[Token(Token = "0x60099DD")]
	[Address(RVA = "0xE34870", Offset = "0xE33A70", VA = "0x180E34870")]
	public ActivateConfirmToggle()
	{
	}
}
