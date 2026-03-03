using Il2CppDummyDll;
using UnityEngine;
using YgomSystem;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x2001235")]
public class UnityLogoViewController : TweenViewController
{
	[Token(Token = "0x2001236")]
	private enum Step
	{
		[Token(Token = "0x400BA90")]
		Init,
		[Token(Token = "0x400BA91")]
		StartFade,
		[Token(Token = "0x400BA92")]
		LogoIn,
		[Token(Token = "0x400BA93")]
		LogoStay,
		[Token(Token = "0x400BA94")]
		LogoOut,
		[Token(Token = "0x400BA95")]
		EndFade,
		[Token(Token = "0x400BA96")]
		Finish
	}

	[Token(Token = "0x2001237")]
	private enum ConnectionStatus
	{
		[Token(Token = "0x400BA98")]
		None,
		[Token(Token = "0x400BA99")]
		Connecting,
		[Token(Token = "0x400BA9A")]
		Success,
		[Token(Token = "0x400BA9B")]
		Failed
	}

	[Token(Token = "0x400BA88")]
	[FieldOffset(Offset = "0x0")]
	private static bool s_enableUnityLogoSkip;

	[Token(Token = "0x400BA89")]
	private const float UnityLogoDelayTime = 2f;

	[Token(Token = "0x400BA8A")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private ElementObjectManager prefabUI;

	[Token(Token = "0x400BA8B")]
	[FieldOffset(Offset = "0x88")]
	private ElementObjectManager m_ui;

	[Token(Token = "0x400BA8C")]
	[FieldOffset(Offset = "0x90")]
	private StepSequencer m_sequencer;

	[Token(Token = "0x400BA8D")]
	[FieldOffset(Offset = "0x98")]
	private float m_UnityLogoDispTime;

	[Token(Token = "0x400BA8E")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_UnityLogoSkip;

	[Token(Token = "0x6007163")]
	[Address(RVA = "0xB86820", Offset = "0xB85A20", VA = "0x180B86820")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007164")]
	[Address(RVA = "0xB86990", Offset = "0xB85B90", VA = "0x180B86990", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007165")]
	[Address(RVA = "0xB86A90", Offset = "0xB85C90", VA = "0x180B86A90", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007166")]
	[Address(RVA = "0xB86CA0", Offset = "0xB85EA0", VA = "0x180B86CA0")]
	private void Update()
	{
	}

	[Token(Token = "0x6007167")]
	[Address(RVA = "0xB86D80", Offset = "0xB85F80", VA = "0x180B86D80")]
	private void stepInit(StepSequencer seq)
	{
	}

	[Token(Token = "0x6007168")]
	[Address(RVA = "0xB87140", Offset = "0xB86340", VA = "0x180B87140")]
	private void stepTweenPlay(StepSequencer seq, string tweenLabel, Step nextStep)
	{
	}

	[Token(Token = "0x6007169")]
	[Address(RVA = "0xB87080", Offset = "0xB86280", VA = "0x180B87080")]
	private void stepLogoStay(StepSequencer seq)
	{
	}

	[Token(Token = "0x600716A")]
	[Address(RVA = "0xB86CE0", Offset = "0xB85EE0", VA = "0x180B86CE0")]
	private void stepFinish(StepSequencer seq)
	{
	}

	[Token(Token = "0x600716B")]
	[Address(RVA = "0xB86CD0", Offset = "0xB85ED0", VA = "0x180B86CD0")]
	public UnityLogoViewController()
	{
	}
}
