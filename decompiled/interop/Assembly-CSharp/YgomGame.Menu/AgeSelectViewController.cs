using System;
using System.Diagnostics;
using Il2CppDummyDll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu;

[Token(Token = "0x20011A8")]
public class AgeSelectViewController : CommonScreenViewController
{
	[Token(Token = "0x400B86B")]
	[FieldOffset(Offset = "0x118")]
	private Action<int> m_resultCallback;

	[Token(Token = "0x400B86C")]
	[FieldOffset(Offset = "0x120")]
	private int m_ageMin;

	[Token(Token = "0x400B86D")]
	[FieldOffset(Offset = "0x124")]
	private int m_ageMax;

	[Token(Token = "0x400B86E")]
	[FieldOffset(Offset = "0x128")]
	private int m_ageAvailable;

	[Token(Token = "0x400B86F")]
	[FieldOffset(Offset = "0x12C")]
	private int m_ageCurrent;

	[Token(Token = "0x400B870")]
	[FieldOffset(Offset = "0x130")]
	private ExtendedTextMeshProUGUI m_ageText;

	[Token(Token = "0x6006ED0")]
	[Address(RVA = "0xB596C0", Offset = "0xB588C0", VA = "0x180B596C0")]
	private static int mapValue(float srcMin, float srcMax, float srcVal, float dstMin, float dstMax)
	{
		return default(int);
	}

	[Token(Token = "0x6006ED1")]
	[Address(RVA = "0xB59100", Offset = "0xB58300", VA = "0x180B59100", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006ED2")]
	[Address(RVA = "0xB59220", Offset = "0xB58420", VA = "0x180B59220", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006ED3")]
	[Address(RVA = "0xB59690", Offset = "0xB58890", VA = "0x180B59690")]
	private void Start()
	{
	}

	[Token(Token = "0x6006ED4")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6006ED5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("ENABLE_DEBUGLOG")]
	private static void debugLog(string str)
	{
	}

	[Token(Token = "0x6006ED6")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public AgeSelectViewController()
	{
	}
}
