using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Mission;

[Token(Token = "0x2000BFC")]
public class MissionRootContext
{
	[Token(Token = "0x400996B")]
	[FieldOffset(Offset = "0x10")]
	private readonly List<TabContext> m_Tabs;

	[Token(Token = "0x400996C")]
	[FieldOffset(Offset = "0x18")]
	private readonly List<int> m_TabTemplates;

	[Token(Token = "0x400996D")]
	[FieldOffset(Offset = "0x20")]
	private readonly List<TabContextImportable> m_ImportableTabs;

	[Token(Token = "0x400996E")]
	[FieldOffset(Offset = "0x28")]
	private readonly TabAllContext m_TabAll;

	[Token(Token = "0x400996F")]
	[FieldOffset(Offset = "0x30")]
	private readonly Dictionary<int, TabContextImportable> m_CampaignTabMap;

	[Token(Token = "0x4009970")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsInitialized;

	[Token(Token = "0x4009971")]
	[FieldOffset(Offset = "0x3C")]
	private int m_TabIdx;

	[Token(Token = "0x4009972")]
	[FieldOffset(Offset = "0x40")]
	public readonly BulkRecieveContext bulkRecieve;

	[Token(Token = "0x170009D3")]
	public List<TabContext> tabs
	{
		[Token(Token = "0x60048FA")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009D4")]
	public List<int> tabTemplates
	{
		[Token(Token = "0x60048FB")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009D5")]
	public int tabIdx
	{
		[Token(Token = "0x60048FC")]
		[Address(RVA = "0x5EA1B0", Offset = "0x5E93B0", VA = "0x1805EA1B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60048FD")]
		[Address(RVA = "0x9236C0", Offset = "0x9228C0", VA = "0x1809236C0")]
		set
		{
		}
	}

	[Token(Token = "0x170009D6")]
	public TabContext currentTab
	{
		[Token(Token = "0x60048FE")]
		[Address(RVA = "0x9233D0", Offset = "0x9225D0", VA = "0x1809233D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000060")]
	public event Action<int> onPrevChangeTabIdxEvent
	{
		[Token(Token = "0x60048FF")]
		[Address(RVA = "0x9231E0", Offset = "0x9223E0", VA = "0x1809231E0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004900")]
		[Address(RVA = "0x9234D0", Offset = "0x9226D0", VA = "0x1809234D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000061")]
	public event Action<int> onChangeTabIdxEvent
	{
		[Token(Token = "0x6004901")]
		[Address(RVA = "0x923130", Offset = "0x922330", VA = "0x180923130")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004902")]
		[Address(RVA = "0x923420", Offset = "0x922620", VA = "0x180923420")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000062")]
	public event Action onUpdatedAllEvent
	{
		[Token(Token = "0x6004903")]
		[Address(RVA = "0x923290", Offset = "0x922490", VA = "0x180923290")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004904")]
		[Address(RVA = "0x923580", Offset = "0x922780", VA = "0x180923580")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000063")]
	public event Action onUpdatedContainMissionsEvent
	{
		[Token(Token = "0x6004905")]
		[Address(RVA = "0x923330", Offset = "0x922530", VA = "0x180923330")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004906")]
		[Address(RVA = "0x923620", Offset = "0x922820", VA = "0x180923620")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6004907")]
	[Address(RVA = "0x922ED0", Offset = "0x9220D0", VA = "0x180922ED0")]
	public MissionRootContext()
	{
	}

	[Token(Token = "0x6004908")]
	[Address(RVA = "0x921EE0", Offset = "0x9210E0", VA = "0x180921EE0")]
	public void InitResidentTabs()
	{
	}

	[Token(Token = "0x6004909")]
	[Address(RVA = "0x922310", Offset = "0x921510", VA = "0x180922310")]
	public void SearchInOutMissions(Dictionary<string, object> datas, Dictionary<string, object> completeDatas, Dictionary<string, object> hideDatas, List<int> resEntries, List<int> resRemoves, List<int> resHides)
	{
	}

	[Token(Token = "0x600490A")]
	[Address(RVA = "0x921EC0", Offset = "0x9210C0", VA = "0x180921EC0")]
	public void ImportMissions(Dictionary<string, object> master, Dictionary<string, object> data, int initTabPoolId = 0, MissionTabType initTabType = MissionTabType.All, bool fromDuelMenu = false)
	{
	}

	[Token(Token = "0x600490B")]
	[Address(RVA = "0x920760", Offset = "0x91F960", VA = "0x180920760")]
	public void ImportContainMissionsUpdate(Func<int, int, Dictionary<string, object>> missionDataGetterFunc)
	{
	}

	[Token(Token = "0x600490C")]
	[Address(RVA = "0x920A30", Offset = "0x91FC30", VA = "0x180920A30")]
	public void ImportMissionsOverride(Dictionary<string, object> master, Dictionary<string, object> data, int initTabPoolId = 0, MissionTabType initTabType = MissionTabType.All, bool fromDuelMenu = false)
	{
	}

	[Token(Token = "0x600490D")]
	[Address(RVA = "0x922CF0", Offset = "0x921EF0", VA = "0x180922CF0")]
	public void TurnOffNew(int tabIdx)
	{
	}

	[Token(Token = "0x600490E")]
	[Address(RVA = "0x9222C0", Offset = "0x9214C0", VA = "0x1809222C0")]
	private void OnUpdatedContainMissions()
	{
	}
}
