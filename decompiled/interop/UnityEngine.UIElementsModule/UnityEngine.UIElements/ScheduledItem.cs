using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002BC")]
internal abstract class ScheduledItem
{
	[Token(Token = "0x4000B02")]
	[FieldOffset(Offset = "0x10")]
	public Func<bool> timerUpdateStopCondition;

	[Token(Token = "0x4000B03")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Func<bool> OnceCondition;

	[Token(Token = "0x4000B04")]
	[FieldOffset(Offset = "0x8")]
	public static readonly Func<bool> ForeverCondition;

	[Token(Token = "0x1700039E")]
	public long startMs
	{
		[Token(Token = "0x600130D")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600130E")]
		[Address(RVA = "0x178F430", Offset = "0x178E630", VA = "0x18178F430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700039F")]
	public long delayMs
	{
		[Token(Token = "0x600130F")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001310")]
		[Address(RVA = "0x7320F0", Offset = "0x7312F0", VA = "0x1807320F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170003A0")]
	public long intervalMs
	{
		[Token(Token = "0x6001311")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001312")]
		[Address(RVA = "0x980A50", Offset = "0x97FC50", VA = "0x180980A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170003A1")]
	public long endTimeMs
	{
		[Token(Token = "0x6001313")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x6001314")]
	[Address(RVA = "0x2B6CBB0", Offset = "0x2B6BDB0", VA = "0x182B6CBB0")]
	public ScheduledItem()
	{
	}

	[Token(Token = "0x6001315")]
	[Address(RVA = "0x2B6C9F0", Offset = "0x2B6BBF0", VA = "0x182B6C9F0")]
	protected void ResetStartTime()
	{
	}

	[Token(Token = "0x6001316")]
	public abstract void PerformTimerUpdate(TimerState state);

	[Token(Token = "0x6001317")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	internal virtual void OnItemUnscheduled()
	{
	}

	[Token(Token = "0x6001318")]
	[Address(RVA = "0x2B6CA40", Offset = "0x2B6BC40", VA = "0x182B6CA40", Slot = "6")]
	public virtual bool ShouldUnschedule()
	{
		return default(bool);
	}
}
