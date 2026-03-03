using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002BE")]
internal class TimerEventScheduler : IScheduler
{
	[Token(Token = "0x4000B0A")]
	[FieldOffset(Offset = "0x10")]
	private readonly List<ScheduledItem> m_ScheduledItems;

	[Token(Token = "0x4000B0B")]
	[FieldOffset(Offset = "0x18")]
	private bool m_TransactionMode;

	[Token(Token = "0x4000B0C")]
	[FieldOffset(Offset = "0x20")]
	private readonly List<ScheduledItem> m_ScheduleTransactions;

	[Token(Token = "0x4000B0D")]
	[FieldOffset(Offset = "0x28")]
	private readonly HashSet<ScheduledItem> m_UnscheduleTransactions;

	[Token(Token = "0x4000B0E")]
	[FieldOffset(Offset = "0x30")]
	internal bool disableThrottling;

	[Token(Token = "0x4000B0F")]
	[FieldOffset(Offset = "0x34")]
	private int m_LastUpdatedIndex;

	[Token(Token = "0x4000B10")]
	[FieldOffset(Offset = "0x38")]
	private long frameCount;

	[Token(Token = "0x170003A2")]
	public long FrameCount
	{
		[Token(Token = "0x6001322")]
		[Address(RVA = "0x2844C00", Offset = "0x2843E00", VA = "0x182844C00", Slot = "7")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001323")]
		[Address(RVA = "0x4166C0", Offset = "0x4158C0", VA = "0x1804166C0")]
		set
		{
		}
	}

	[Token(Token = "0x600131E")]
	[Address(RVA = "0x2B6E080", Offset = "0x2B6D280", VA = "0x182B6E080", Slot = "5")]
	public void Schedule(ScheduledItem item)
	{
	}

	[Token(Token = "0x600131F")]
	[Address(RVA = "0x2B6E010", Offset = "0x2B6D210", VA = "0x182B6E010")]
	private bool RemovedScheduledItemAt(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6001320")]
	[Address(RVA = "0x2B6E260", Offset = "0x2B6D460", VA = "0x182B6E260", Slot = "4")]
	public void Unschedule(ScheduledItem item)
	{
	}

	[Token(Token = "0x6001321")]
	[Address(RVA = "0x2B6DF30", Offset = "0x2B6D130", VA = "0x182B6DF30")]
	private bool PrivateUnSchedule(ScheduledItem sItem)
	{
		return default(bool);
	}

	[Token(Token = "0x6001324")]
	[Address(RVA = "0x2B6E4D0", Offset = "0x2B6D6D0", VA = "0x182B6E4D0", Slot = "6")]
	public void UpdateScheduledEvents()
	{
	}

	[Token(Token = "0x6001325")]
	[Address(RVA = "0x2B6EB00", Offset = "0x2B6DD00", VA = "0x182B6EB00")]
	public TimerEventScheduler()
	{
	}
}
