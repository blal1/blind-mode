using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Mission;

[Token(Token = "0x2000C02")]
public class TabContext : IComparable<TabContext>
{
	[Token(Token = "0x400997D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly MissionTabType tabType;

	[Token(Token = "0x400997E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public readonly int campaignPoolId;

	[Token(Token = "0x400997F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly long campaignBeginTs;

	[Token(Token = "0x4009980")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly string tabNameTextId;

	[Token(Token = "0x4009981")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly string tabShortNameTextId;

	[Token(Token = "0x4009982")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected readonly List<MissionContext> m_Missions;

	[Token(Token = "0x4009983")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected readonly Dictionary<int, MissionContext> m_MissionMap;

	[Token(Token = "0x170009D9")]
	public IReadOnlyList<MissionContext> missions
	{
		[Token(Token = "0x6004920")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009DA")]
	public IReadOnlyDictionary<int, MissionContext> missionMap
	{
		[Token(Token = "0x6004921")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009DB")]
	public string tabNameText
	{
		[Token(Token = "0x6004922")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004923")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009DC")]
	public string tabShortNameText
	{
		[Token(Token = "0x6004924")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004925")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009DD")]
	public bool inRewardUnlocked
	{
		[Token(Token = "0x6004926")]
		[Address(RVA = "0x925E90", Offset = "0x925090", VA = "0x180925E90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170009DE")]
	public bool completed
	{
		[Token(Token = "0x6004927")]
		[Address(RVA = "0x925D20", Offset = "0x924F20", VA = "0x180925D20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004928")]
	[Address(RVA = "0x9259E0", Offset = "0x924BE0", VA = "0x1809259E0")]
	public (bool, int) SearchBadgeInfos()
	{
		return default((bool, int));
	}

	[Token(Token = "0x6004929")]
	[Address(RVA = "0x925C00", Offset = "0x924E00", VA = "0x180925C00")]
	public TabContext(MissionTabType tabType, int campaignPoolId = 0, long campaignBeginTs = 0L, [Optional] string tabNameTextId, [Optional] string tabShortNameTextId)
	{
	}

	[Token(Token = "0x600492A")]
	[Address(RVA = "0x925320", Offset = "0x924520", VA = "0x180925320")]
	public void Clear()
	{
	}

	[Token(Token = "0x600492B")]
	[Address(RVA = "0x925BB0", Offset = "0x924DB0", VA = "0x180925BB0")]
	public void SortMissions()
	{
	}

	[Token(Token = "0x600492C")]
	[Address(RVA = "0x9255F0", Offset = "0x9247F0", VA = "0x1809255F0")]
	public void LoadTexts()
	{
	}

	[Token(Token = "0x600492D")]
	[Address(RVA = "0x9254C0", Offset = "0x9246C0", VA = "0x1809254C0")]
	public int Compare(TabContext a, TabContext b)
	{
		return default(int);
	}

	[Token(Token = "0x600492E")]
	[Address(RVA = "0x9253A0", Offset = "0x9245A0", VA = "0x1809253A0", Slot = "4")]
	public int CompareTo(TabContext other)
	{
		return default(int);
	}
}
