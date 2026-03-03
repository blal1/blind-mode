using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Dialog.CommonDialog;
using YgomGame.Help;
using YgomGame.Menu;
using YgomGame.Mission;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.PanelMission;

[Token(Token = "0x2000C1F")]
public class PanelMissionContent : BaseMissionContent
{
	[Token(Token = "0x2000C20")]
	private class LaunchException : Exception
	{
		[Token(Token = "0x6004A17")]
		[Address(RVA = "0x934730", Offset = "0x933930", VA = "0x180934730")]
		public LaunchException(string message)
		{
		}
	}

	[Token(Token = "0x2000C22")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x4009A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject mapPref;

		[Token(Token = "0x4009A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HelpMappingData helpMappingData;

		[Token(Token = "0x6004A1A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6004A1B")]
		[Address(RVA = "0x949AE0", Offset = "0x948CE0", VA = "0x180949AE0")]
		internal void _003CyInitializeInner_003Eb__0(string path)
		{
		}

		[Token(Token = "0x6004A1C")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		internal void _003CyInitializeInner_003Eb__1(HelpMappingData loadedHelpMappingData)
		{
		}
	}

	[Token(Token = "0x2000C26")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x4009A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool doneRefreshCW;

		[Token(Token = "0x4009A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PanelMissionContent _003C_003E4__this;

		[Token(Token = "0x4009A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool doneResultDialog;

		[Token(Token = "0x6004A26")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6004A27")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CyPlayReceiveRewardResult_003Eb__0()
		{
		}

		[Token(Token = "0x6004A28")]
		[Address(RVA = "0x94A6B0", Offset = "0x9498B0", VA = "0x18094A6B0")]
		internal void _003CyPlayReceiveRewardResult_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000C27")]
	[CompilerGenerated]
	private sealed class _003CyInitializeInner_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PanelMissionContent _003C_003E4__this;

		[Token(Token = "0x4009A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ElementObjectManager eom;

		[Token(Token = "0x4009A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;

		[Token(Token = "0x17000A09")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004A2C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A0A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004A2E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004A29")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitializeInner_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004A2A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004A2B")]
		[Address(RVA = "0x94ABB0", Offset = "0x949DB0", VA = "0x18094ABB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004A2D")]
		[Address(RVA = "0x94B3E0", Offset = "0x94A5E0", VA = "0x18094B3E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000C28")]
	[CompilerGenerated]
	private sealed class _003CyPlayReceiveRewardResult_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PanelMissionContent _003C_003E4__this;

		[Token(Token = "0x4009A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PanelWidget panel;

		[Token(Token = "0x4009A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

		[Token(Token = "0x4009A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private EntryItemListData _003CreceiveItems_003E5__2;

		[Token(Token = "0x4009A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _003CreceiveIsPresentSend_003E5__3;

		[Token(Token = "0x17000A0B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004A32")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A0C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004A34")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004A2F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayReceiveRewardResult_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004A30")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004A31")]
		[Address(RVA = "0x94C860", Offset = "0x94BA60", VA = "0x18094C860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004A33")]
		[Address(RVA = "0x94D250", Offset = "0x94C450", VA = "0x18094D250", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009A39")]
	private const string k_MapPathFormat = "Prefabs/Mission/Contents/PanelMission/Maps/{0}";

	[Token(Token = "0x4009A3A")]
	private const string k_MapPathDefault = "Common/PMMap_Common";

	[Token(Token = "0x4009A3B")]
	internal const string k_ForceLaunchSe = "SE_MISSION_NEW";

	[Token(Token = "0x4009A3C")]
	private const string k_ArgKey_PoolId = "poolId";

	[Token(Token = "0x4009A3D")]
	private const string k_ArgKey_OnClosed = "onClosed";

	[Token(Token = "0x4009A3E")]
	internal const string k_ArgKey_IsForceLaunch = "isForceLaunch";

	[Token(Token = "0x4009A3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool isForceLaunch;

	[Token(Token = "0x4009A40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int m_PoolId;

	[Token(Token = "0x4009A41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private HelpMappingData m_HelpMappingData;

	[Token(Token = "0x4009A42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private MapWidget m_MapWidget;

	[Token(Token = "0x4009A43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private long m_EndTs;

	[Token(Token = "0x4009A44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private long m_ResultEndTs;

	[Token(Token = "0x4009A45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int m_CompleteMissionId;

	[Token(Token = "0x4009A46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly List<int> m_PanelMissionIds;

	[Token(Token = "0x6004A04")]
	[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x6004A05")]
	[Address(RVA = "0x941880", Offset = "0x940A80", VA = "0x180941880")]
	public static void CheckLaunch(int poolId, [Optional] Action onSuccess, [Optional] Action onFailed, bool disableErrorNotify = false)
	{
	}

	[Token(Token = "0x6004A06")]
	[Address(RVA = "0x941990", Offset = "0x940B90", VA = "0x180941990", Slot = "28")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6004A07")]
	[Address(RVA = "0x941A10", Offset = "0x940C10", VA = "0x180941A10", Slot = "29")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6004A08")]
	[Address(RVA = "0x944380", Offset = "0x943580", VA = "0x180944380", Slot = "27")]
	[IteratorStateMachine(typeof(_003CyInitializeInner_003Ed__19))]
	protected override IEnumerator yInitializeInner(ElementObjectManager eom, bool isOnlyMission = false, bool isSelectTab = false)
	{
		return null;
	}

	[Token(Token = "0x6004A09")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "30")]
	public override void TransitionStart(ViewController.TransitionType type)
	{
	}

	[Token(Token = "0x6004A0A")]
	[Address(RVA = "0x941C60", Offset = "0x940E60", VA = "0x180941C60")]
	private bool OnSelectorSelected(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A0B")]
	[Address(RVA = "0x9440B0", Offset = "0x9432B0", VA = "0x1809440B0")]
	private void SetupView()
	{
	}

	[Token(Token = "0x6004A0C")]
	[Address(RVA = "0x942F70", Offset = "0x942170", VA = "0x180942F70")]
	private void SetupView_Map(Dictionary<string, object> allMasterWork, Dictionary<string, object> allDataWork)
	{
	}

	[Token(Token = "0x6004A0D")]
	[Address(RVA = "0x943660", Offset = "0x942860", VA = "0x180943660")]
	private void SetupView_Panel(PanelWidget panel, Dictionary<string, object> panelMasterWork, Dictionary<string, object> panelDataWork)
	{
	}

	[Token(Token = "0x6004A0E")]
	[Address(RVA = "0x942850", Offset = "0x941A50", VA = "0x180942850")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6004A0F")]
	[Address(RVA = "0x941EB0", Offset = "0x9410B0", VA = "0x180941EB0")]
	private void RefreshView_Panel(PanelWidget panel, Dictionary<string, object> panelMasterWork, Dictionary<string, object> panelDataWork, MissionState missionState)
	{
	}

	[Token(Token = "0x6004A10")]
	[Address(RVA = "0x941D50", Offset = "0x940F50", VA = "0x180941D50")]
	private void ReceiveReward(PanelWidget panel, Dictionary<string, object> panelMasterWork, Dictionary<string, object> panelDataWork)
	{
	}

	[Token(Token = "0x6004A11")]
	[Address(RVA = "0x944410", Offset = "0x943610", VA = "0x180944410")]
	[IteratorStateMachine(typeof(_003CyPlayReceiveRewardResult_003Ed__28))]
	private IEnumerator yPlayReceiveRewardResult(PanelWidget panel)
	{
		return null;
	}

	[Token(Token = "0x6004A12")]
	[Address(RVA = "0x909A60", Offset = "0x908C60", VA = "0x180909A60")]
	private void OnUpdateLimitTextCallback(TMP_Text text, long remainSec)
	{
	}

	[Token(Token = "0x6004A13")]
	[Address(RVA = "0x941C90", Offset = "0x940E90", VA = "0x180941C90")]
	private void OnUpdateRecieveLimitTextCallback(TMP_Text text, long remainSec)
	{
	}

	[Token(Token = "0x6004A14")]
	[Address(RVA = "0x941B90", Offset = "0x940D90", VA = "0x180941B90")]
	private void OnSelectedPanel(PanelWidget selectedPanelWidget)
	{
	}

	[Token(Token = "0x6004A15")]
	[Address(RVA = "0x941AC0", Offset = "0x940CC0", VA = "0x180941AC0")]
	private void OnDeselectedPanel(PanelWidget deselectedPanelWidget)
	{
	}

	[Token(Token = "0x6004A16")]
	[Address(RVA = "0x944280", Offset = "0x943480", VA = "0x180944280")]
	public PanelMissionContent()
	{
	}
}
