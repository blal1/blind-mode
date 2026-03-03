using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Mission;

[Token(Token = "0x2000BFA")]
public class MissionContext : IComparable<MissionContext>
{
	[Token(Token = "0x4009951")]
	[FieldOffset(Offset = "0x10")]
	public readonly int idx;

	[Token(Token = "0x4009952")]
	[FieldOffset(Offset = "0x14")]
	public readonly int poolId;

	[Token(Token = "0x4009953")]
	[FieldOffset(Offset = "0x18")]
	public readonly int missionId;

	[Token(Token = "0x4009954")]
	[FieldOffset(Offset = "0x1C")]
	public readonly MissionCategory category;

	[Token(Token = "0x4009955")]
	[FieldOffset(Offset = "0x20")]
	private string m_MissionNameCache;

	[Token(Token = "0x4009956")]
	[FieldOffset(Offset = "0x28")]
	private readonly int m_LogicNo;

	[Token(Token = "0x4009957")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<object> m_NameParams;

	[Token(Token = "0x4009958")]
	[FieldOffset(Offset = "0x38")]
	public readonly long endTimeStamp;

	[Token(Token = "0x4009959")]
	[FieldOffset(Offset = "0x40")]
	public readonly long resultEndTimeStamp;

	[Token(Token = "0x400995A")]
	[FieldOffset(Offset = "0x48")]
	public readonly string hintSfx;

	[Token(Token = "0x400995B")]
	[FieldOffset(Offset = "0x50")]
	public readonly int progress;

	[Token(Token = "0x400995C")]
	[FieldOffset(Offset = "0x54")]
	public readonly bool isExistsProgressData;

	[Token(Token = "0x400995D")]
	[FieldOffset(Offset = "0x58")]
	public readonly List<List<GoalContext>> goalPages;

	[Token(Token = "0x4009964")]
	[FieldOffset(Offset = "0x80")]
	public bool focusEffectVisible;

	[Token(Token = "0x4009965")]
	[FieldOffset(Offset = "0x81")]
	public bool completeEffectVisible;

	[Token(Token = "0x4009966")]
	[FieldOffset(Offset = "0x84")]
	public int goalPageIdx;

	[Token(Token = "0x4009967")]
	[FieldOffset(Offset = "0x88")]
	public int goalProgressPageIdx;

	[Token(Token = "0x4009968")]
	[FieldOffset(Offset = "0x8C")]
	public int goalCursorIdx;

	[Token(Token = "0x170009CB")]
	public bool isNew
	{
		[Token(Token = "0x60048DC")]
		[Address(RVA = "0x91E9C0", Offset = "0x91DBC0", VA = "0x18091E9C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60048DD")]
		[Address(RVA = "0x91E9F0", Offset = "0x91DBF0", VA = "0x18091E9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009CC")]
	public int progressGoalPage
	{
		[Token(Token = "0x60048DE")]
		[Address(RVA = "0x80A510", Offset = "0x809710", VA = "0x18080A510")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60048DF")]
		[Address(RVA = "0x91EA10", Offset = "0x91DC10", VA = "0x18091EA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009CD")]
	public bool isExpire
	{
		[Token(Token = "0x60048E0")]
		[Address(RVA = "0x91E9B0", Offset = "0x91DBB0", VA = "0x18091E9B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60048E1")]
		[Address(RVA = "0x91E9E0", Offset = "0x91DBE0", VA = "0x18091E9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009CE")]
	public int hideGoalIdx
	{
		[Token(Token = "0x60048E2")]
		[Address(RVA = "0x803CD0", Offset = "0x802ED0", VA = "0x180803CD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60048E3")]
		[Address(RVA = "0x91E9D0", Offset = "0x91DBD0", VA = "0x18091E9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009CF")]
	public long orderTs
	{
		[Token(Token = "0x60048E4")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60048E5")]
		[Address(RVA = "0x91EA00", Offset = "0x91DC00", VA = "0x18091EA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009D0")]
	public GoalContext[] goals
	{
		[Token(Token = "0x60048E6")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60048E7")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009D1")]
	public string hintPath
	{
		[Token(Token = "0x60048E8")]
		[Address(RVA = "0x91E880", Offset = "0x91DA80", VA = "0x18091E880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009D2")]
	public bool isExistsRewardUnlocked
	{
		[Token(Token = "0x60048E9")]
		[Address(RVA = "0x91E890", Offset = "0x91DA90", VA = "0x18091E890")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60048EA")]
	[Address(RVA = "0x91DD60", Offset = "0x91CF60", VA = "0x18091DD60")]
	public int GetLastGoalRequire()
	{
		return default(int);
	}

	[Token(Token = "0x60048EB")]
	[Address(RVA = "0x91E180", Offset = "0x91D380", VA = "0x18091E180")]
	public bool IsProgressCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60048EC")]
	[Address(RVA = "0x91E100", Offset = "0x91D300", VA = "0x18091E100")]
	public bool IsCompleteAndReceived()
	{
		return default(bool);
	}

	[Token(Token = "0x60048ED")]
	[Address(RVA = "0x91E200", Offset = "0x91D400", VA = "0x18091E200")]
	public string MakeMissionName(TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x60048EE")]
	[Address(RVA = "0x91E260", Offset = "0x91D460", VA = "0x18091E260")]
	public MissionContext(int idx, Dictionary<string, object> data, Dictionary<string, object> master)
	{
	}

	[Token(Token = "0x60048EF")]
	[Address(RVA = "0x91DDB0", Offset = "0x91CFB0", VA = "0x18091DDB0")]
	public void ImportOverride(Dictionary<string, object> data)
	{
	}

	[Token(Token = "0x60048F0")]
	[Address(RVA = "0x91E250", Offset = "0x91D450", VA = "0x18091E250")]
	public void TurnOffNew()
	{
	}

	[Token(Token = "0x60048F1")]
	[Address(RVA = "0x91D7B0", Offset = "0x91C9B0", VA = "0x18091D7B0")]
	private void ClampCursorIdx(int setCursorIdx)
	{
	}

	[Token(Token = "0x60048F2")]
	[Address(RVA = "0x91DC60", Offset = "0x91CE60", VA = "0x18091DC60")]
	public int GetCursorLimit()
	{
		return default(int);
	}

	[Token(Token = "0x60048F3")]
	[Address(RVA = "0x91DC10", Offset = "0x91CE10", VA = "0x18091DC10")]
	public IReadOnlyList<GoalContext> GetCurrentGoals()
	{
		return null;
	}

	[Token(Token = "0x60048F4")]
	[Address(RVA = "0x91DBA0", Offset = "0x91CDA0", VA = "0x18091DBA0")]
	private static int GetCategoryOrder(MissionCategory category)
	{
		return default(int);
	}

	[Token(Token = "0x60048F5")]
	[Address(RVA = "0x91D9F0", Offset = "0x91CBF0", VA = "0x18091D9F0")]
	public int Compare(MissionContext a, MissionContext b)
	{
		return default(int);
	}

	[Token(Token = "0x60048F6")]
	[Address(RVA = "0x91D9E0", Offset = "0x91CBE0", VA = "0x18091D9E0", Slot = "4")]
	public int CompareTo(MissionContext other)
	{
		return default(int);
	}
}
