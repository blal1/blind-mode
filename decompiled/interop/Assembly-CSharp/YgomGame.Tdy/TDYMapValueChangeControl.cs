using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Tdy;

[Token(Token = "0x200085B")]
public class TDYMapValueChangeControl
{
	[Token(Token = "0x200085C")]
	private class AreaCountChanger
	{
		[Token(Token = "0x200085D")]
		internal delegate void ChangingHandler(int areaId, long prevAreaCnt, long currAreaCnt, long prevTotalCntServer, long currTotalCntServer);

		[Token(Token = "0x200085E")]
		internal delegate bool CountingUpHander(int areaId);

		[Token(Token = "0x200085F")]
		internal delegate void CircleEffectChangedHandler(int areaId, int circleLevel, long totalDuelCount);

		[Token(Token = "0x2000860")]
		internal enum Step
		{
			[Token(Token = "0x4008614")]
			IDLE,
			[Token(Token = "0x4008615")]
			WAIT_CHANGE,
			[Token(Token = "0x4008616")]
			CHANGING
		}

		[Token(Token = "0x2000861")]
		private struct ChangeParam
		{
			[Token(Token = "0x4008617")]
			[FieldOffset(Offset = "0x0")]
			internal long _prev;

			[Token(Token = "0x4008618")]
			[FieldOffset(Offset = "0x8")]
			internal long _next;

			[Token(Token = "0x4008619")]
			[FieldOffset(Offset = "0x10")]
			internal float _delay;
		}

		[Token(Token = "0x400860B")]
		[FieldOffset(Offset = "0x18")]
		private long _prevTotalCnt;

		[Token(Token = "0x400860C")]
		[FieldOffset(Offset = "0x20")]
		private long _currTotalCnt;

		[Token(Token = "0x400860D")]
		[FieldOffset(Offset = "0x28")]
		private int _circleLevel;

		[Token(Token = "0x400860E")]
		[FieldOffset(Offset = "0x2C")]
		private float _elapsedTime;

		[Token(Token = "0x400860F")]
		[FieldOffset(Offset = "0x30")]
		private List<ChangeParam> _changeParams;

		[Token(Token = "0x17000654")]
		internal Step step
		{
			[Token(Token = "0x60032CC")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			[CompilerGenerated]
			get
			{
				return default(Step);
			}
			[Token(Token = "0x60032CB")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000655")]
		internal int areaId
		{
			[Token(Token = "0x60032CE")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60032CD")]
			[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000656")]
		internal ChangingHandler areaCountChangedHander
		{
			[Token(Token = "0x60032D0")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60032CF")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000657")]
		internal CountingUpHander countingUpHandler
		{
			[Token(Token = "0x60032D2")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60032D1")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000658")]
		internal CircleEffectChangedHandler circleEffectChangedHandler
		{
			[Token(Token = "0x60032D4")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60032D3")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60032D5")]
		[Address(RVA = "0x74D070", Offset = "0x74C270", VA = "0x18074D070")]
		internal AreaCountChanger(int areaId)
		{
		}

		[Token(Token = "0x60032D6")]
		[Address(RVA = "0x74CBF0", Offset = "0x74BDF0", VA = "0x18074CBF0")]
		internal void Reset()
		{
		}

		[Token(Token = "0x60032D7")]
		[Address(RVA = "0x74CC40", Offset = "0x74BE40", VA = "0x18074CC40")]
		internal bool Set(long prevCount, long currCount, long prevTotalCnt, long currTotalCnt, int circleLevel, float nextPollingDelay)
		{
			return default(bool);
		}

		[Token(Token = "0x60032D8")]
		[Address(RVA = "0x74CEC0", Offset = "0x74C0C0", VA = "0x18074CEC0")]
		internal void Update(float deltaTime)
		{
		}
	}

	[Token(Token = "0x2000862")]
	private class TotalCountChanger
	{
		[Token(Token = "0x2000863")]
		internal enum Step
		{
			[Token(Token = "0x4008620")]
			IDLE,
			[Token(Token = "0x4008621")]
			WAIT_CHANGE,
			[Token(Token = "0x4008622")]
			CHANGING
		}

		[Token(Token = "0x400861A")]
		private const double COUNTUP_DURATION = 0.2;

		[Token(Token = "0x400861C")]
		[FieldOffset(Offset = "0x18")]
		private Queue<(long, float, bool)> _changeQueue;

		[Token(Token = "0x400861D")]
		[FieldOffset(Offset = "0x20")]
		private float _remainTime;

		[Token(Token = "0x400861E")]
		[FieldOffset(Offset = "0x28")]
		private TDYMapWidget _widget;

		[Token(Token = "0x17000659")]
		internal Step step
		{
			[Token(Token = "0x60032E6")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			[CompilerGenerated]
			get
			{
				return default(Step);
			}
			[Token(Token = "0x60032E5")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60032E7")]
		[Address(RVA = "0x7564D0", Offset = "0x7556D0", VA = "0x1807564D0")]
		internal TotalCountChanger(TDYMapWidget widget)
		{
		}

		[Token(Token = "0x60032E8")]
		[Address(RVA = "0x7561C0", Offset = "0x7553C0", VA = "0x1807561C0")]
		internal void Push(long nextValue, float delay, bool fix = false)
		{
		}

		[Token(Token = "0x60032E9")]
		[Address(RVA = "0x756100", Offset = "0x755300", VA = "0x180756100")]
		internal void Flush()
		{
		}

		[Token(Token = "0x60032EA")]
		[Address(RVA = "0x7562A0", Offset = "0x7554A0", VA = "0x1807562A0")]
		internal void Update(float deltaTime)
		{
		}

		[Token(Token = "0x60032EB")]
		[Address(RVA = "0x756280", Offset = "0x755480", VA = "0x180756280")]
		private void StartEffect(long nextValue, double duration, bool fix)
		{
		}
	}

	[Token(Token = "0x4008603")]
	[FieldOffset(Offset = "0x10")]
	private long _totalDuelCnt;

	[Token(Token = "0x4008604")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, long> _duelCntsInArea;

	[Token(Token = "0x4008605")]
	[FieldOffset(Offset = "0x20")]
	private long _tmpAreaCntSumDelta;

	[Token(Token = "0x4008606")]
	[FieldOffset(Offset = "0x28")]
	private TotalCountChanger _totalCntChanger;

	[Token(Token = "0x4008607")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, AreaCountChanger> _areaCntChangers;

	[Token(Token = "0x4008608")]
	[FieldOffset(Offset = "0x38")]
	private TDYMapWidget _mapWidget;

	[Token(Token = "0x60032C2")]
	[Address(RVA = "0x750B30", Offset = "0x74FD30", VA = "0x180750B30")]
	public TDYMapValueChangeControl(TDYMapWidget widget, object prevMap, object map, float nextPollDelay, (int, int) decDeltaRange)
	{
	}

	[Token(Token = "0x60032C3")]
	[Address(RVA = "0x750130", Offset = "0x74F330", VA = "0x180750130")]
	public void Reset()
	{
	}

	[Token(Token = "0x60032C4")]
	[Address(RVA = "0x74FCF0", Offset = "0x74EEF0", VA = "0x18074FCF0")]
	public long GetCount(int areaID)
	{
		return default(long);
	}

	[Token(Token = "0x60032C5")]
	[Address(RVA = "0x74FC90", Offset = "0x74EE90", VA = "0x18074FC90")]
	public bool ContainAreaID(int areaId)
	{
		return default(bool);
	}

	[Token(Token = "0x60032C6")]
	[Address(RVA = "0x74FD70", Offset = "0x74EF70", VA = "0x18074FD70")]
	public bool IsReady()
	{
		return default(bool);
	}

	[Token(Token = "0x60032C7")]
	[Address(RVA = "0x750340", Offset = "0x74F540", VA = "0x180750340")]
	public void SetChange(object map, float nextPollDelay)
	{
	}

	[Token(Token = "0x60032C8")]
	[Address(RVA = "0x7509E0", Offset = "0x74FBE0", VA = "0x1807509E0")]
	public void Update(float deltaTime)
	{
	}

	[Token(Token = "0x60032C9")]
	[Address(RVA = "0x74FEC0", Offset = "0x74F0C0", VA = "0x18074FEC0")]
	private void OnAreaCountChanged(int areaId, long prevCount, long currCount, long prevTotalCntServer, long currTotalCntServer)
	{
	}

	[Token(Token = "0x60032CA")]
	[Address(RVA = "0x74FFB0", Offset = "0x74F1B0", VA = "0x18074FFB0")]
	private void OnCircleEffectChanged(int areaId, int level, long totalDuelCountServer)
	{
	}
}
