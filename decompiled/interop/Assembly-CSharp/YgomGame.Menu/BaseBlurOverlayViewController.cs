using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x20013E6")]
public class BaseBlurOverlayViewController : BaseMenuViewController
{
	[Token(Token = "0x400C466")]
	public const string k_ArgKeyBlurOverlay = "blurOverlay";

	[Token(Token = "0x400C467")]
	[FieldOffset(Offset = "0xD0")]
	protected bool m_IsBlurOverlay;

	[Token(Token = "0x17001302")]
	protected virtual bool defaultBlurOverlay
	{
		[Token(Token = "0x6007BD2")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001303")]
	protected virtual bool supportedVCStacking
	{
		[Token(Token = "0x6007BD3")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001304")]
	protected override GameObject m_TweenTarget
	{
		[Token(Token = "0x6007BD4")]
		[Address(RVA = "0xC3E060", Offset = "0xC3D260", VA = "0x180C3E060", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007BD5")]
	[Address(RVA = "0xC3D8D0", Offset = "0xC3CAD0", VA = "0x180C3D8D0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007BD6")]
	[Address(RVA = "0xC3DF60", Offset = "0xC3D160", VA = "0x180C3DF60")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007BD7")]
	[Address(RVA = "0xC3DE70", Offset = "0xC3D070", VA = "0x180C3DE70")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007BD8")]
	[Address(RVA = "0xC3DCF0", Offset = "0xC3CEF0", VA = "0x180C3DCF0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007BD9")]
	[Address(RVA = "0xC3DA50", Offset = "0xC3CC50", VA = "0x180C3DA50", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6007BDA")]
	[Address(RVA = "0xC3D980", Offset = "0xC3CB80", VA = "0x180C3D980", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007BDB")]
	[Address(RVA = "0xC3DDC0", Offset = "0xC3CFC0", VA = "0x180C3DDC0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007BDC")]
	[Address(RVA = "0x49B9D0", Offset = "0x49ABD0", VA = "0x18049B9D0")]
	public bool IsBlurOverlay()
	{
		return default(bool);
	}

	[Token(Token = "0x6007BDD")]
	[Address(RVA = "0xC3E050", Offset = "0xC3D250", VA = "0x180C3E050")]
	public BaseBlurOverlayViewController()
	{
	}
}
