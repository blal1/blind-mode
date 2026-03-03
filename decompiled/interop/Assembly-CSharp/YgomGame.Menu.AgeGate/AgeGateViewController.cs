using System;
using Il2CppDummyDll;

namespace YgomGame.Menu.AgeGate;

[Token(Token = "0x20013F4")]
public class AgeGateViewController : CommonScreenViewController
{
	[Token(Token = "0x400C49E")]
	[FieldOffset(Offset = "0x118")]
	private Action<int, int, int> m_resultCallback;

	[Token(Token = "0x400C49F")]
	[FieldOffset(Offset = "0x120")]
	private DateTime m_today;

	[Token(Token = "0x400C4A0")]
	[FieldOffset(Offset = "0x128")]
	private YearNumber m_year;

	[Token(Token = "0x400C4A1")]
	[FieldOffset(Offset = "0x130")]
	private MonthNumber m_month;

	[Token(Token = "0x400C4A2")]
	[FieldOffset(Offset = "0x138")]
	private DayNumber m_day;

	[Token(Token = "0x6007C27")]
	[Address(RVA = "0xC548E0", Offset = "0xC53AE0", VA = "0x180C548E0")]
	private bool verifyDate()
	{
		return default(bool);
	}

	[Token(Token = "0x6007C28")]
	[Address(RVA = "0xC546C0", Offset = "0xC538C0", VA = "0x180C546C0")]
	private void updateStatus()
	{
	}

	[Token(Token = "0x6007C29")]
	[Address(RVA = "0xC537E0", Offset = "0xC529E0", VA = "0x180C537E0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007C2A")]
	[Address(RVA = "0xC53CD0", Offset = "0xC52ED0", VA = "0x180C53CD0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007C2B")]
	[Address(RVA = "0xB59690", Offset = "0xB58890", VA = "0x180B59690")]
	private void Start()
	{
	}

	[Token(Token = "0x6007C2C")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007C2D")]
	[Address(RVA = "0xB513D0", Offset = "0xB505D0", VA = "0x180B513D0")]
	public AgeGateViewController()
	{
	}
}
