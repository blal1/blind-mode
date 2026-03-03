using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading;

[Token(Token = "0x2000043")]
public class ReaderWriterLockSlim : IDisposable
{
	[Token(Token = "0x2000044")]
	private struct TimeoutTracker
	{
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x0")]
		private int m_total;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x4")]
		private int m_start;

		[Token(Token = "0x1700003E")]
		public int RemainingMilliseconds
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x2061D80", Offset = "0x2060F80", VA = "0x182061D80")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		public bool IsExpired
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x2061D30", Offset = "0x2060F30", VA = "0x182061D30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2061CB0", Offset = "0x2060EB0", VA = "0x182061CB0")]
		public TimeoutTracker(int millisecondsTimeout)
		{
		}
	}

	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x10")]
	private bool fIsReentrant;

	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x14")]
	private int myLock;

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x18")]
	private uint numWriteWaiters;

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x1C")]
	private uint numReadWaiters;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x20")]
	private uint numWriteUpgradeWaiters;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x24")]
	private uint numUpgradeWaiters;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x28")]
	private bool fNoWaiters;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x2C")]
	private int upgradeLockOwnerId;

	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x30")]
	private int writeLockOwnerId;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x38")]
	private EventWaitHandle writeEvent;

	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x40")]
	private EventWaitHandle readEvent;

	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x48")]
	private EventWaitHandle upgradeEvent;

	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x50")]
	private EventWaitHandle waitUpgradeEvent;

	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x0")]
	private static long s_nextLockID;

	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x58")]
	private long lockID;

	[Token(Token = "0x4000138")]
	[ThreadStatic]
	private static ReaderWriterCount t_rwc;

	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x60")]
	private bool fUpgradeThreadHoldingRead;

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x64")]
	private uint owners;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x68")]
	private bool fDisposed;

	[Token(Token = "0x17000035")]
	public bool IsReadLockHeld
	{
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2061800", Offset = "0x2060A00", VA = "0x182061800")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000036")]
	public bool IsUpgradeableReadLockHeld
	{
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2061880", Offset = "0x2060A80", VA = "0x182061880")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000037")]
	public bool IsWriteLockHeld
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2061920", Offset = "0x2060B20", VA = "0x182061920")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000038")]
	public int RecursiveReadCount
	{
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x20619C0", Offset = "0x2060BC0", VA = "0x1820619C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000039")]
	public int RecursiveUpgradeCount
	{
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2061A30", Offset = "0x2060C30", VA = "0x182061A30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003A")]
	public int RecursiveWriteCount
	{
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2061AF0", Offset = "0x2060CF0", VA = "0x182061AF0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003B")]
	public int WaitingReadCount
	{
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x62E220", Offset = "0x62D420", VA = "0x18062E220")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003C")]
	public int WaitingUpgradeCount
	{
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003D")]
	public int WaitingWriteCount
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x2060E80", Offset = "0x2060080", VA = "0x182060E80")]
	private void InitializeThreadCounts()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x20617A0", Offset = "0x20609A0", VA = "0x1820617A0")]
	public ReaderWriterLockSlim()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x2061730", Offset = "0x2060930", VA = "0x182061730")]
	public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000171")]
	[Address(RVA = "0x2060E90", Offset = "0x2060090", VA = "0x182060E90")]
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc)
	{
		return default(bool);
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x2060ED0", Offset = "0x20600D0", VA = "0x182060ED0")]
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x2060D40", Offset = "0x205FF40", VA = "0x182060D40")]
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate)
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x2060940", Offset = "0x205FB40", VA = "0x182060940")]
	public void EnterReadLock()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x2061560", Offset = "0x2060760", VA = "0x182061560")]
	public bool TryEnterReadLock(int millisecondsTimeout)
	{
		return default(bool);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x20615F0", Offset = "0x20607F0", VA = "0x1820615F0")]
	private bool TryEnterReadLock(TimeoutTracker timeout)
	{
		return default(bool);
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x20610A0", Offset = "0x20602A0", VA = "0x1820610A0")]
	private bool TryEnterReadLockCore(TimeoutTracker timeout)
	{
		return default(bool);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x2060B50", Offset = "0x205FD50", VA = "0x182060B50")]
	public void ExitReadLock()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x2060EF0", Offset = "0x20600F0", VA = "0x182060EF0")]
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x2061600", Offset = "0x2060800", VA = "0x182061600")]
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, TimeoutTracker timeout, bool isWriteWaiter)
	{
		return default(bool);
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x2060A90", Offset = "0x205FC90", VA = "0x182060A90")]
	private void ExitAndWakeUpAppropriateWaiters()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x2060A00", Offset = "0x205FC00", VA = "0x182060A00")]
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x2060960", Offset = "0x205FB60", VA = "0x182060960")]
	private void ExitAndWakeUpAppropriateReadWaiters()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x2061010", Offset = "0x2060210", VA = "0x182061010")]
	private void SetWritersWaiting()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x20604F0", Offset = "0x205F6F0", VA = "0x1820604F0")]
	private void ClearWritersWaiting()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x2061000", Offset = "0x2060200", VA = "0x182061000")]
	private void SetUpgraderWaiting()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x20604E0", Offset = "0x205F6E0", VA = "0x1820604E0")]
	private void ClearUpgraderWaiting()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x2060D30", Offset = "0x205FF30", VA = "0x182060D30")]
	private uint GetNumReaders()
	{
		return default(uint);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x2060900", Offset = "0x205FB00", VA = "0x182060900")]
	private void EnterMyLock()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x2060840", Offset = "0x205FA40", VA = "0x182060840")]
	private void EnterMyLockSpin()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x2060B30", Offset = "0x205FD30", VA = "0x182060B30")]
	private void ExitMyLock()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x2061020", Offset = "0x2060220", VA = "0x182061020")]
	private static void SpinWait(int SpinCount)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x2060830", Offset = "0x205FA30", VA = "0x182060830", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x2060500", Offset = "0x205F700", VA = "0x182060500")]
	private void Dispose(bool disposing)
	{
	}
}
