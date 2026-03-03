using System;
using System.Diagnostics;
using Il2CppDummyDll;
using YgomGame.Menu.BirthdateSelectInternal;

namespace YgomGame.Menu;

[Token(Token = "0x20011AB")]
public class BirthdateSelectViewController : CommonScreenViewController
{
	[Token(Token = "0x400B87A")]
	[FieldOffset(Offset = "0x118")]
	private Action<int, int, int> m_resultCallback;

	[Token(Token = "0x400B87B")]
	[FieldOffset(Offset = "0x120")]
	private DateTime m_today;

	[Token(Token = "0x400B87C")]
	[FieldOffset(Offset = "0x128")]
	private YearNumber m_year;

	[Token(Token = "0x400B87D")]
	[FieldOffset(Offset = "0x130")]
	private MonthNumber m_month;

	[Token(Token = "0x400B87E")]
	[FieldOffset(Offset = "0x138")]
	private DayNumber m_day;

	[Token(Token = "0x400B87F")]
	[FieldOffset(Offset = "0x140")]
	private int m_yearOfsNear;

	[Token(Token = "0x400B880")]
	[FieldOffset(Offset = "0x144")]
	private int m_yearOfsFar;

	[Token(Token = "0x6006EDC")]
	[Address(RVA = "0xB5A4C0", Offset = "0xB596C0", VA = "0x180B5A4C0")]
	private bool verifyDate()
	{
		return default(bool);
	}

	[Token(Token = "0x6006EDD")]
	[Address(RVA = "0xB5A350", Offset = "0xB59550", VA = "0x180B5A350")]
	private void updateStatus()
	{
	}

	[Token(Token = "0x6006EDE")]
	[Address(RVA = "0xB59700", Offset = "0xB58900", VA = "0x180B59700", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006EDF")]
	[Address(RVA = "0xB59A00", Offset = "0xB58C00", VA = "0x180B59A00", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006EE0")]
	[Address(RVA = "0xB59690", Offset = "0xB58890", VA = "0x180B59690")]
	private void Start()
	{
	}

	[Token(Token = "0x6006EE1")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6006EE2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("ENABLE_DEBUGLOG")]
	private static void debugLog(string str)
	{
	}

	[Token(Token = "0x6006EE3")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public BirthdateSelectViewController()
	{
	}
}
