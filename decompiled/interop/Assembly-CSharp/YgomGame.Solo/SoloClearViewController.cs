using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Solo;

[Token(Token = "0x2000889")]
public class SoloClearViewController : BaseMenuViewController, IFadeSupported
{
	[Token(Token = "0x200088A")]
	public enum ClearType
	{
		[Token(Token = "0x40086B0")]
		RENTAL,
		[Token(Token = "0x40086B1")]
		MYDECK,
		[Token(Token = "0x40086B2")]
		COMPLETE,
		[Token(Token = "0x40086B3")]
		GOAL
	}

	[Token(Token = "0x400869B")]
	private const string k_ArgKeyCallback = "callback";

	[Token(Token = "0x400869C")]
	private const string k_ArgKeyType = "type";

	[Token(Token = "0x400869D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelBG3D;

	[Token(Token = "0x400869E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelBackShortcutButton;

	[Token(Token = "0x400869F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelButtonSkip;

	[Token(Token = "0x40086A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelRootChapter;

	[Token(Token = "0x40086A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelRootComplete;

	[Token(Token = "0x40086A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelRootGoal;

	[Token(Token = "0x40086A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelRoot;

	[Token(Token = "0x40086A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string IMG_CLEAR_RENTAL_LABEL;

	[Token(Token = "0x40086A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string IMG_BLANK_RENTAL_LABEL;

	[Token(Token = "0x40086A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string IMG_CLEAR_MYDECK_LABEL;

	[Token(Token = "0x40086A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string IMG_BLANK_MYDECK_LABEL;

	[Token(Token = "0x40086A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject m_View3D;

	[Token(Token = "0x40086A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private ElementObjectManager m_TargetEom;

	[Token(Token = "0x40086AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private bool b_IsFinish;

	[Token(Token = "0x40086AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
	private bool b_IsWhileTutorial;

	[Token(Token = "0x40086AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
	private bool b_IsSkip;

	[Token(Token = "0x40086AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private int m_LoadingEffectCount;

	[Token(Token = "0x40086AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private ClearType type;

	[Token(Token = "0x17000660")]
	private bool IsLoadingEffect
	{
		[Token(Token = "0x600339B")]
		[Address(RVA = "0x76B1B0", Offset = "0x76A3B0", VA = "0x18076B1B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000661")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600339C")]
		[Address(RVA = "0x76B1C0", Offset = "0x76A3C0", VA = "0x18076B1C0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600339D")]
	[Address(RVA = "0x76AA90", Offset = "0x769C90", VA = "0x18076AA90")]
	private void Start()
	{
	}

	[Token(Token = "0x600339E")]
	[Address(RVA = "0x76AEA0", Offset = "0x76A0A0", VA = "0x18076AEA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600339F")]
	[Address(RVA = "0x76A500", Offset = "0x769700", VA = "0x18076A500")]
	public static void Open(ClearType type, [Optional] Action callback)
	{
	}

	[Token(Token = "0x60033A0")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60033A1")]
	[Address(RVA = "0x76A2D0", Offset = "0x7694D0", VA = "0x18076A2D0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60033A2")]
	[Address(RVA = "0x76A110", Offset = "0x769310", VA = "0x18076A110", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60033A3")]
	[Address(RVA = "0x76A240", Offset = "0x769440", VA = "0x18076A240", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x60033A4")]
	[Address(RVA = "0x769F50", Offset = "0x769150", VA = "0x180769F50")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60033A5")]
	[Address(RVA = "0x76A760", Offset = "0x769960", VA = "0x18076A760")]
	private void Play()
	{
	}

	[Token(Token = "0x60033A6")]
	[Address(RVA = "0x76A640", Offset = "0x769840", VA = "0x18076A640")]
	private void PlayEffect(string effectPath)
	{
	}

	[Token(Token = "0x60033A7")]
	[Address(RVA = "0x3EF010", Offset = "0x3EE210", VA = "0x1803EF010", Slot = "28")]
	public Color FadeColor(TransitionType type)
	{
		return default(Color);
	}

	[Token(Token = "0x60033A8")]
	[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "29")]
	public SystemProgress.ProgressType FadeType(TransitionType type)
	{
		return default(SystemProgress.ProgressType);
	}

	[Token(Token = "0x60033A9")]
	[Address(RVA = "0x76AF90", Offset = "0x76A190", VA = "0x18076AF90")]
	public SoloClearViewController()
	{
	}
}
