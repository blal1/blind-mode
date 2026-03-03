using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;

namespace YgomGame.Team;

[Token(Token = "0x2001663")]
public class TeamMemberMatchedViewController : BaseMenuViewController, IBokeSupported
{
	[Token(Token = "0x400D624")]
	private const string k_ArgKeyCallback = "callback";

	[Token(Token = "0x400D625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string E_BG3D;

	[Token(Token = "0x400D626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string E_BackShortcutButton;

	[Token(Token = "0x400D627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string E_ButtonSkip;

	[Token(Token = "0x400D628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string E_RootMatched;

	[Token(Token = "0x400D629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string E_Root;

	[Token(Token = "0x400D62A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string E_Text;

	[Token(Token = "0x400D62B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject m_View3D;

	[Token(Token = "0x400D62C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private ElementObjectManager m_TargetEom;

	[Token(Token = "0x400D62D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private bool b_IsFinish;

	[Token(Token = "0x400D62E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
	private bool b_IsSkip;

	[Token(Token = "0x400D62F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private int m_LoadingEffectCount;

	[Token(Token = "0x17001542")]
	private bool IsLoadingEffect
	{
		[Token(Token = "0x6008B3B")]
		[Address(RVA = "0xD684D0", Offset = "0xD676D0", VA = "0x180D684D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008B3C")]
	[Address(RVA = "0xD67E40", Offset = "0xD67040", VA = "0x180D67E40")]
	private void Start()
	{
	}

	[Token(Token = "0x6008B3D")]
	[Address(RVA = "0xD682A0", Offset = "0xD674A0", VA = "0x180D682A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6008B3E")]
	[Address(RVA = "0xD67C30", Offset = "0xD66E30", VA = "0x180D67C30")]
	public static void Open([Optional] Action callback)
	{
	}

	[Token(Token = "0x6008B3F")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008B40")]
	[Address(RVA = "0xD67970", Offset = "0xD66B70", VA = "0x180D67970", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008B41")]
	[Address(RVA = "0xD677B0", Offset = "0xD669B0", VA = "0x180D677B0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6008B42")]
	[Address(RVA = "0xD678E0", Offset = "0xD66AE0", VA = "0x180D678E0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6008B43")]
	[Address(RVA = "0xD67620", Offset = "0xD66820", VA = "0x180D67620")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6008B44")]
	[Address(RVA = "0xD67E40", Offset = "0xD67040", VA = "0x180D67E40")]
	private void Play()
	{
	}

	[Token(Token = "0x6008B45")]
	[Address(RVA = "0xD67D20", Offset = "0xD66F20", VA = "0x180D67D20")]
	private void PlayEffect(string effectPath)
	{
	}

	[Token(Token = "0x6008B46")]
	[Address(RVA = "0xD68390", Offset = "0xD67590", VA = "0x180D68390")]
	public TeamMemberMatchedViewController()
	{
	}
}
