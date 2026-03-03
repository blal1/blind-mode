using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Help;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;

namespace YgomGame.Mission;

[Token(Token = "0x2000BD3")]
public class ResidentMissionContent : BaseMissionContent
{
	[Token(Token = "0x2000BD4")]
	public class InOutPlayer
	{
		[Token(Token = "0x2000BD5")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass36_0
		{
			[Token(Token = "0x40098AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float focusScrollSpeed;

			[Token(Token = "0x40098AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InOutPlayer _003C_003E4__this;

			[Token(Token = "0x40098B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float pageSnapSpeed;

			[Token(Token = "0x40098B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float tmSpeed;

			[Token(Token = "0x40098B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalRecieveBetweenWaitSpeed;

			[Token(Token = "0x40098B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float goalRecievedSpeed;

			[Token(Token = "0x40098B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string goalCheckSELabel;

			[Token(Token = "0x40098B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MissionPanelWidget panelWidget;

			[Token(Token = "0x40098B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isSkipped;

			[Token(Token = "0x40098B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action onSkipCallback;

			[Token(Token = "0x6004844")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6004845")]
			[Address(RVA = "0x926A50", Offset = "0x925C50", VA = "0x180926A50")]
			internal void _003CyPlayRecieved_003Eb__0()
			{
			}

			[Token(Token = "0x6004846")]
			[Address(RVA = "0x926FF0", Offset = "0x9261F0", VA = "0x180926FF0")]
			internal void _003CyPlayRecieved_003Eb__1()
			{
			}
		}

		[Token(Token = "0x2000BD6")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass37_0
		{
			[Token(Token = "0x40098B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool closedDialog;

			[Token(Token = "0x40098B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InOutPlayer _003C_003E4__this;

			[Token(Token = "0x40098BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MissionPanelWidget panelWidget;

			[Token(Token = "0x6004847")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6004848")]
			[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
			internal void _003CyPlayRecievedResult_003Eb__0()
			{
			}

			[Token(Token = "0x6004849")]
			[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
			internal void _003CyPlayRecievedResult_003Eb__1()
			{
			}

			[Token(Token = "0x600484A")]
			[Address(RVA = "0x927040", Offset = "0x926240", VA = "0x180927040")]
			internal void _003CyPlayRecievedResult_003Eb__2()
			{
			}
		}

		[Token(Token = "0x2000BD7")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass41_0
		{
			[Token(Token = "0x40098BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x40098BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string label;

			[Token(Token = "0x600484B")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass41_0()
			{
			}

			[Token(Token = "0x600484C")]
			[Address(RVA = "0x927390", Offset = "0x926590", VA = "0x180927390")]
			internal void _003CyPlayTweenTarget_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000BD8")]
		[CompilerGenerated]
		private sealed class _003CyPlay_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40098BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40098BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40098BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InOutPlayer _003C_003E4__this;

			[Token(Token = "0x40098C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isResult;

			[Token(Token = "0x40098C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool isBulk;

			[Token(Token = "0x40098C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action onComplete;

			[Token(Token = "0x40098C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private ScrollRect.MovementType _003CoriginalMovementType_003E5__2;

			[Token(Token = "0x40098C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<int> _003CremovedMissions_003E5__3;

			[Token(Token = "0x40098C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<int> _003ChidedMissions_003E5__4;

			[Token(Token = "0x170009B5")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004850")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170009B6")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004852")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600484D")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CyPlay_003Ed__35(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600484E")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600484F")]
			[Address(RVA = "0x92EEE0", Offset = "0x92E0E0", VA = "0x18092EEE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004851")]
			[Address(RVA = "0x92F520", Offset = "0x92E720", VA = "0x18092F520", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000BD9")]
		[CompilerGenerated]
		private sealed class _003CyPlayEntry_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40098C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40098C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40098C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool isRemovedMission;

			[Token(Token = "0x40098C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public InOutPlayer _003C_003E4__this;

			[Token(Token = "0x40098CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<int> entryMissions;

			[Token(Token = "0x40098CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Dictionary<GameObject, MissionPanelWidget>.ValueCollection.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x40098CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private MissionPanelWidget _003CpanelWidget_003E5__3;

			[Token(Token = "0x170009B7")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004857")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170009B8")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004859")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004853")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CyPlayEntry_003Ed__38(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004854")]
			[Address(RVA = "0x92AFD0", Offset = "0x92A1D0", VA = "0x18092AFD0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004855")]
			[Address(RVA = "0x92A4E0", Offset = "0x9296E0", VA = "0x18092A4E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004856")]
			[Address(RVA = "0x92B060", Offset = "0x92A260", VA = "0x18092B060")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6004858")]
			[Address(RVA = "0x92AF90", Offset = "0x92A190", VA = "0x18092AF90", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000BDA")]
		[CompilerGenerated]
		private sealed class _003CyPlayRecieved_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40098CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40098CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40098CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InOutPlayer _003C_003E4__this;

			[Token(Token = "0x40098D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isFocus;

			[Token(Token = "0x40098D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<int> recievedMissions;

			[Token(Token = "0x40098D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<int> recievedGoalPoss;

			[Token(Token = "0x40098D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private _003C_003Ec__DisplayClass36_0 _003C_003E8__1;

			[Token(Token = "0x40098D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<int> removedMissions;

			[Token(Token = "0x40098D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private InfinityScrollView _003CscrollView_003E5__2;

			[Token(Token = "0x40098D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private IReadOnlyList<MissionContext> _003Cmissions_003E5__3;

			[Token(Token = "0x40098D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private List<int> _003CplayGoalPoss_003E5__4;

			[Token(Token = "0x40098D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int _003CmissionIdx_003E5__5;

			[Token(Token = "0x40098D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private MissionContext _003CmissionCtx_003E5__6;

			[Token(Token = "0x40098DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private int _003CplayGoalCnt_003E5__7;

			[Token(Token = "0x40098DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private IEnumerator _003CplayFocusPanelRoutine_003E5__8;

			[Token(Token = "0x40098DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private int _003CgoalPageIdx_003E5__9;

			[Token(Token = "0x40098DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private List<GoalContext> _003CgoalsCtx_003E5__10;

			[Token(Token = "0x40098DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private int _003CgoalIdx_003E5__11;

			[Token(Token = "0x40098DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private List<MissionGoalHolderWidget>.Enumerator _003C_003E7__wrap11;

			[Token(Token = "0x40098E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private MissionGoalHolderWidget _003CgoalHolder_003E5__13;

			[Token(Token = "0x40098E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private List<MissionGoalsWidget>.Enumerator _003C_003E7__wrap13;

			[Token(Token = "0x170009B9")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004861")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170009BA")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004863")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600485A")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CyPlayRecieved_003Ed__36(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600485B")]
			[Address(RVA = "0x92E8F0", Offset = "0x92DAF0", VA = "0x18092E8F0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600485C")]
			[Address(RVA = "0x92C810", Offset = "0x92BA10", VA = "0x18092C810", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600485D")]
			[Address(RVA = "0x92EB60", Offset = "0x92DD60", VA = "0x18092EB60")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x600485E")]
			[Address(RVA = "0x92EBB0", Offset = "0x92DDB0", VA = "0x18092EBB0")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x600485F")]
			[Address(RVA = "0x92EC00", Offset = "0x92DE00", VA = "0x18092EC00")]
			private void _003C_003Em__Finally3()
			{
			}

			[Token(Token = "0x6004860")]
			[Address(RVA = "0x92EC50", Offset = "0x92DE50", VA = "0x18092EC50")]
			private void _003C_003Em__Finally4()
			{
			}

			[Token(Token = "0x6004862")]
			[Address(RVA = "0x92E8B0", Offset = "0x92DAB0", VA = "0x18092E8B0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000BDB")]
		[CompilerGenerated]
		private sealed class _003CyPlayRecievedResult_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40098E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40098E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40098E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InOutPlayer _003C_003E4__this;

			[Token(Token = "0x40098E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isBulk;

			[Token(Token = "0x40098E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

			[Token(Token = "0x40098E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<int> removedMissions;

			[Token(Token = "0x40098E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private IEnumerator<GameObject> _003C_003E7__wrap1;

			[Token(Token = "0x170009BB")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004868")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170009BC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600486A")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004864")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CyPlayRecievedResult_003Ed__37(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004865")]
			[Address(RVA = "0x92C560", Offset = "0x92B760", VA = "0x18092C560", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004866")]
			[Address(RVA = "0x92BA10", Offset = "0x92AC10", VA = "0x18092BA10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004867")]
			[Address(RVA = "0x92C5F0", Offset = "0x92B7F0", VA = "0x18092C5F0")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6004869")]
			[Address(RVA = "0x92C520", Offset = "0x92B720", VA = "0x18092C520", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000BDC")]
		[CompilerGenerated]
		private sealed class _003CyPlayTweenTarget_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40098E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40098EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40098EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject target;

			[Token(Token = "0x40098EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string label;

			[Token(Token = "0x40098ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InOutPlayer _003C_003E4__this;

			[Token(Token = "0x40098EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

			[Token(Token = "0x170009BD")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600486E")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170009BE")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004870")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600486B")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CyPlayTweenTarget_003Ed__41(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600486C")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600486D")]
			[Address(RVA = "0x92ECA0", Offset = "0x92DEA0", VA = "0x18092ECA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600486F")]
			[Address(RVA = "0x92EEA0", Offset = "0x92E0A0", VA = "0x18092EEA0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400989C")]
		private const string k_PLabelSkipSpeed_RecieveFocusScroll = "SkipSpeed_RecieveFocusScroll";

		[Token(Token = "0x400989D")]
		private const string k_PLabelSkipSpeed_PageSnap = "SkipSpeed_PageSnap";

		[Token(Token = "0x400989E")]
		private const string k_PLabelSkipSpeed_TM = "SkipSpeed_TM";

		[Token(Token = "0x400989F")]
		private const string k_PLabelSkipSpeed_GoalRecieveBetweenWait = "SkipSpeed_GoalRecieveBetweenWait";

		[Token(Token = "0x40098A0")]
		private const string k_PLabelSkipSpeed_GoalRecieved = "SkipSpeed_GoalRecieved";

		[Token(Token = "0x40098A1")]
		private const string k_PLabelBuilRecieveSE_Check = "BuilRecieveSE_Check";

		[Token(Token = "0x40098A2")]
		private const string k_PLabelBuilRecieveSE_CheckSkip = "BuilRecieveSE_CheckSkip";

		[Token(Token = "0x40098A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<int> m_EntryMissions;

		[Token(Token = "0x40098A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<int> m_HidedMissions;

		[Token(Token = "0x40098A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<int> m_RemovedMissions;

		[Token(Token = "0x40098A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<int> m_RecievedMissions;

		[Token(Token = "0x40098A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<int> m_RecievedGoalPoss;

		[Token(Token = "0x40098A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ResidentMissionContent m_VC;

		[Token(Token = "0x40098A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Selector m_CoverSelector;

		[Token(Token = "0x40098AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SelectionButton m_SkipButton;

		[Token(Token = "0x40098AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_PageSnapOriginalDuration;

		[Token(Token = "0x40098AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine m_SequenceRoutine;

		[Token(Token = "0x40098AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action m_OnSkipCallback;

		[Token(Token = "0x170009B2")]
		public bool isPlaying
		{
			[Token(Token = "0x600482A")]
			[Address(RVA = "0x91A840", Offset = "0x919A40", VA = "0x18091A840")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009B3")]
		public Selector coverSelector
		{
			[Token(Token = "0x600482B")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B4")]
		public SelectionButton skipButton
		{
			[Token(Token = "0x600482C")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600482D")]
		[Address(RVA = "0x919950", Offset = "0x918B50", VA = "0x180919950")]
		public void Init(ResidentMissionContent vc, Selector coverSelector, SelectionButton skipButton)
		{
		}

		[Token(Token = "0x600482E")]
		[Address(RVA = "0x919800", Offset = "0x918A00", VA = "0x180919800")]
		public void ClearEntryMissions()
		{
		}

		[Token(Token = "0x600482F")]
		[Address(RVA = "0x919900", Offset = "0x918B00", VA = "0x180919900")]
		public void ClearRemoveMissions()
		{
		}

		[Token(Token = "0x6004830")]
		[Address(RVA = "0x9198A0", Offset = "0x918AA0", VA = "0x1809198A0")]
		public void ClearRecievedMissions()
		{
		}

		[Token(Token = "0x6004831")]
		[Address(RVA = "0x919850", Offset = "0x918A50", VA = "0x180919850")]
		public void ClearHidedMissions()
		{
		}

		[Token(Token = "0x6004832")]
		[Address(RVA = "0x919210", Offset = "0x918410", VA = "0x180919210")]
		public void AddEntryMission(int missionId)
		{
		}

		[Token(Token = "0x6004833")]
		[Address(RVA = "0x919430", Offset = "0x918630", VA = "0x180919430")]
		public void AddRemoveMission(int missionId)
		{
		}

		[Token(Token = "0x6004834")]
		[Address(RVA = "0x9193B0", Offset = "0x9185B0", VA = "0x1809193B0")]
		public void AddRecievedMissions(List<int> missionIds, List<int> goalposs)
		{
		}

		[Token(Token = "0x6004835")]
		[Address(RVA = "0x9192E0", Offset = "0x9184E0", VA = "0x1809192E0")]
		public void AddHidedMission(int missionId)
		{
		}

		[Token(Token = "0x6004836")]
		[Address(RVA = "0x91A4E0", Offset = "0x9196E0", VA = "0x18091A4E0")]
		public void Terminate()
		{
		}

		[Token(Token = "0x6004837")]
		[Address(RVA = "0x919A90", Offset = "0x918C90", VA = "0x180919A90")]
		public void Play(bool isResult = false, bool isBulk = false, [Optional] Action onComplete)
		{
		}

		[Token(Token = "0x6004838")]
		[Address(RVA = "0x91AB10", Offset = "0x919D10", VA = "0x18091AB10")]
		[IteratorStateMachine(typeof(_003CyPlay_003Ed__35))]
		private IEnumerator yPlay(bool isResult = false, bool isBulk = false, [Optional] Action onComplete)
		{
			return null;
		}

		[Token(Token = "0x6004839")]
		[Address(RVA = "0x91A990", Offset = "0x919B90", VA = "0x18091A990")]
		[IteratorStateMachine(typeof(_003CyPlayRecieved_003Ed__36))]
		private IEnumerator yPlayRecieved(List<int> recievedMissions, List<int> recievedGoalPoss, List<int> removedMissions, bool isFocus)
		{
			return null;
		}

		[Token(Token = "0x600483A")]
		[Address(RVA = "0x91A8F0", Offset = "0x919AF0", VA = "0x18091A8F0")]
		[IteratorStateMachine(typeof(_003CyPlayRecievedResult_003Ed__37))]
		private IEnumerator yPlayRecievedResult(List<int> removedMissions, List<int> hidedMissions, bool isBulk = false)
		{
			return null;
		}

		[Token(Token = "0x600483B")]
		[Address(RVA = "0x91A850", Offset = "0x919A50", VA = "0x18091A850")]
		[IteratorStateMachine(typeof(_003CyPlayEntry_003Ed__38))]
		private IEnumerator yPlayEntry(List<int> entryMissions, bool isRemovedMission)
		{
			return null;
		}

		[Token(Token = "0x600483C")]
		[Address(RVA = "0x919500", Offset = "0x918700", VA = "0x180919500")]
		private void CleanupRecieveCtxState()
		{
		}

		[Token(Token = "0x600483D")]
		[Address(RVA = "0x9196D0", Offset = "0x9188D0", VA = "0x1809196D0")]
		private void CleanupRecieveWidgetState()
		{
		}

		[Token(Token = "0x600483E")]
		[Address(RVA = "0x91AA60", Offset = "0x919C60", VA = "0x18091AA60")]
		[IteratorStateMachine(typeof(_003CyPlayTweenTarget_003Ed__41))]
		private IEnumerator yPlayTweenTarget(GameObject target, string label)
		{
			return null;
		}

		[Token(Token = "0x600483F")]
		[Address(RVA = "0x919C30", Offset = "0x918E30", VA = "0x180919C30")]
		private List<int> PopReservedMissionIds(List<int> source)
		{
			return null;
		}

		[Token(Token = "0x6004840")]
		[Address(RVA = "0x91A030", Offset = "0x919230", VA = "0x18091A030")]
		private (List<int>, List<int>) PopReservedMissionPairIds(List<int> source, List<int> pairSource)
		{
			return default((List<int>, List<int>));
		}

		[Token(Token = "0x6004841")]
		[Address(RVA = "0x919A70", Offset = "0x918C70", VA = "0x180919A70")]
		private void OnClickSkip()
		{
		}

		[Token(Token = "0x6004842")]
		[Address(RVA = "0x91A700", Offset = "0x919900", VA = "0x18091A700")]
		public InOutPlayer()
		{
		}
	}

	[Token(Token = "0x2000BDD")]
	private class WidgetFactory
	{
		[Token(Token = "0x2000BDF")]
		[CompilerGenerated]
		private sealed class _003CyInitialReserve_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40098F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40098F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40098F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WidgetFactory _003C_003E4__this;

			[Token(Token = "0x40098FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int pageReq;

			[Token(Token = "0x40098FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Dictionary<MissionGoalWidget.GoalType, int> goalReq;

			[Token(Token = "0x40098FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003CwaitCnt_003E5__2;

			[Token(Token = "0x40098FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Dictionary<MissionGoalWidget.GoalType, int>.Enumerator _003C_003E7__wrap2;

			[Token(Token = "0x40098FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private KeyValuePair<MissionGoalWidget.GoalType, int> _003CreservePair_003E5__4;

			[Token(Token = "0x40098FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int _003Ci_003E5__5;

			[Token(Token = "0x170009BF")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004880")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170009C0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004882")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600487C")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CyInitialReserve_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600487D")]
			[Address(RVA = "0x928530", Offset = "0x927730", VA = "0x180928530", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600487E")]
			[Address(RVA = "0x928160", Offset = "0x927360", VA = "0x180928160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600487F")]
			[Address(RVA = "0x9285C0", Offset = "0x9277C0", VA = "0x1809285C0")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6004881")]
			[Address(RVA = "0x9284F0", Offset = "0x9276F0", VA = "0x1809284F0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40098EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly PrefabObjectPool m_PrefabObjectPool;

		[Token(Token = "0x40098F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly GameObject m_PagePref;

		[Token(Token = "0x40098F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IReadOnlyDictionary<MissionGoalWidget.GoalType, GameObject> m_GoalPrefMap;

		[Token(Token = "0x40098F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<GameObject, MissionPanelWidget> m_PanelWidgetMap;

		[Token(Token = "0x40098F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<GameObject, MissionGoalWidget> m_GoalWidgetMap;

		[Token(Token = "0x40098F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<GameObject> onCreatedPageCallback;

		[Token(Token = "0x6004871")]
		[Address(RVA = "0x92FF00", Offset = "0x92F100", VA = "0x18092FF00")]
		public WidgetFactory(Transform root, GameObject pagePref, GameObject goalInProgressPref, GameObject goalRecievablePref, GameObject goalCompletedPref)
		{
		}

		[Token(Token = "0x6004872")]
		[Address(RVA = "0x9303F0", Offset = "0x92F5F0", VA = "0x1809303F0")]
		[IteratorStateMachine(typeof(_003CyInitialReserve_003Ed__7))]
		public IEnumerator yInitialReserve(int pageReq, Dictionary<MissionGoalWidget.GoalType, int> goalReq)
		{
			return null;
		}

		[Token(Token = "0x6004873")]
		[Address(RVA = "0x92F9D0", Offset = "0x92EBD0", VA = "0x18092F9D0")]
		public MissionPanelWidget[] GetCreatedPanelWidgets()
		{
			return null;
		}

		[Token(Token = "0x6004874")]
		[Address(RVA = "0x92FDD0", Offset = "0x92EFD0", VA = "0x18092FDD0")]
		public void ReservePage(int count = 1)
		{
		}

		[Token(Token = "0x6004875")]
		[Address(RVA = "0x92FD10", Offset = "0x92EF10", VA = "0x18092FD10")]
		public GameObject RentPage(GameObject owner)
		{
			return null;
		}

		[Token(Token = "0x6004876")]
		[Address(RVA = "0x92FD40", Offset = "0x92EF40", VA = "0x18092FD40")]
		public void ReserveGoal(MissionGoalWidget.GoalType goalType, int count = 1)
		{
		}

		[Token(Token = "0x6004877")]
		[Address(RVA = "0x92FC60", Offset = "0x92EE60", VA = "0x18092FC60")]
		public MissionGoalWidget RentGoal(MissionGoalWidget.GoalType goalType, GameObject owner)
		{
			return null;
		}

		[Token(Token = "0x6004878")]
		[Address(RVA = "0x92FE00", Offset = "0x92F000", VA = "0x18092FE00")]
		public void ReturnGoal(MissionGoalWidget goalWidget)
		{
		}

		[Token(Token = "0x6004879")]
		[Address(RVA = "0x92FA30", Offset = "0x92EC30", VA = "0x18092FA30")]
		private void OnCreatedGoalPref(GameObject obj, MissionGoalWidget.GoalType goalType)
		{
		}
	}

	[Token(Token = "0x2000BE0")]
	private class LaunchException : Exception
	{
		[Token(Token = "0x6004883")]
		[Address(RVA = "0x91ABC0", Offset = "0x919DC0", VA = "0x18091ABC0")]
		public LaunchException(string message)
		{
		}
	}

	[Token(Token = "0x2000BE3")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass103_0
	{
		[Token(Token = "0x4009906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ResidentMissionContent _003C_003E4__this;

		[Token(Token = "0x4009907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> bulkMissionIds;

		[Token(Token = "0x4009908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<int> bulkGoalPoss;

		[Token(Token = "0x600488B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass103_0()
		{
		}

		[Token(Token = "0x600488C")]
		[Address(RVA = "0x926680", Offset = "0x925880", VA = "0x180926680")]
		internal void _003CyBulkRecieveRoutine_003Eb__0(Handle h)
		{
		}
	}

	[Token(Token = "0x2000BEA")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass81_0
	{
		[Token(Token = "0x400991A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject prefab;

		[Token(Token = "0x400991B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ResidentMissionContent _003C_003E4__this;

		[Token(Token = "0x400991C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool doneGetMissionListApi;

		[Token(Token = "0x600489B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass81_0()
		{
		}

		[Token(Token = "0x600489C")]
		[Address(RVA = "0x927750", Offset = "0x926950", VA = "0x180927750")]
		internal void _003CyInitializeInner_003Eb__0(string path)
		{
		}

		[Token(Token = "0x600489D")]
		[Address(RVA = "0x927820", Offset = "0x926A20", VA = "0x180927820")]
		internal void _003CyInitializeInner_003Eb__1(HelpMappingData helpMappingData)
		{
		}

		[Token(Token = "0x600489E")]
		[Address(RVA = "0x69EDD0", Offset = "0x69DFD0", VA = "0x18069EDD0")]
		internal void _003CyInitializeInner_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000BEB")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass81_1
	{
		[Token(Token = "0x400991D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool readyMissionList;

		[Token(Token = "0x600489F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass81_1()
		{
		}

		[Token(Token = "0x60048A0")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CyInitializeInner_003Eb__3()
		{
		}
	}

	[Token(Token = "0x2000BEC")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass83_0
	{
		[Token(Token = "0x400991E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool readyMissionTemplates;

		[Token(Token = "0x60048A1")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass83_0()
		{
		}

		[Token(Token = "0x60048A2")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CyPreReserveRoutine_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000BF1")]
	[CompilerGenerated]
	private sealed class _003CyBulkRecieveRoutine_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ResidentMissionContent _003C_003E4__this;

		[Token(Token = "0x4009929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass103_0 _003C_003E8__1;

		[Token(Token = "0x170009C1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60048AE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60048B0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60048AB")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBulkRecieveRoutine_003Ed__103(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60048AC")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60048AD")]
		[Address(RVA = "0x927CD0", Offset = "0x926ED0", VA = "0x180927CD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60048AF")]
		[Address(RVA = "0x928120", Offset = "0x927320", VA = "0x180928120", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000BF2")]
	[CompilerGenerated]
	private sealed class _003CyInitializeInner_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400992A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400992B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400992C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ResidentMissionContent _003C_003E4__this;

		[Token(Token = "0x400992D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ElementObjectManager eom;

		[Token(Token = "0x400992E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass81_0 _003C_003E8__1;

		[Token(Token = "0x400992F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isOnlyMission;

		[Token(Token = "0x4009930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass81_1 _003C_003E8__2;

		[Token(Token = "0x4009931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool isSelectTab;

		[Token(Token = "0x4009932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _003CopenPoolId_003E5__2;

		[Token(Token = "0x4009933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MissionTabType _003CopenTabType_003E5__3;

		[Token(Token = "0x4009934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool _003CfromDuelMenu_003E5__4;

		[Token(Token = "0x4009935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IEnumerator _003CpreReserveRoutine_003E5__5;

		[Token(Token = "0x4009936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<GameObject, MissionPanelWidget>.ValueCollection.Enumerator _003C_003E7__wrap5;

		[Token(Token = "0x4009937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private MissionPanelWidget _003CpanelWidget_003E5__7;

		[Token(Token = "0x170009C3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60048B5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60048B7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60048B1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitializeInner_003Ed__81(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60048B2")]
		[Address(RVA = "0x92A400", Offset = "0x929600", VA = "0x18092A400", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60048B3")]
		[Address(RVA = "0x928610", Offset = "0x927810", VA = "0x180928610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60048B4")]
		[Address(RVA = "0x92A490", Offset = "0x929690", VA = "0x18092A490")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60048B6")]
		[Address(RVA = "0x92A3C0", Offset = "0x9295C0", VA = "0x18092A3C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000BF3")]
	[CompilerGenerated]
	private sealed class _003CyPreReserveRoutine_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400993A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ResidentMissionContent _003C_003E4__this;

		[Token(Token = "0x400993B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass83_0 _003C_003E8__1;

		[Token(Token = "0x400993C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IEnumerator _003CinitialReserveRoutine_003E5__2;

		[Token(Token = "0x170009C5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60048BB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60048BD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60048B8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPreReserveRoutine_003Ed__83(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60048B9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60048BA")]
		[Address(RVA = "0x92F560", Offset = "0x92E760", VA = "0x18092F560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60048BC")]
		[Address(RVA = "0x92F990", Offset = "0x92EB90", VA = "0x18092F990", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009876")]
	private const string k_RLabelTMPanelCompleteMission = "TMPanelCompleteMission";

	[Token(Token = "0x4009877")]
	private const string k_RLabelTMPanelHideMission = "TMPanelHideMission";

	[Token(Token = "0x4009878")]
	private const string k_RLabelTMPanelNewMission = "TMPanelNewMission";

	[Token(Token = "0x4009879")]
	private const string k_RLabelTMPanelFocusMission = "TMPanelFocusMission";

	[Token(Token = "0x400987A")]
	private const string k_ArgKeyTabId = "tabId";

	[Token(Token = "0x400987B")]
	private const string k_ArgKeyPoolId = "poolId";

	[Token(Token = "0x400987C")]
	private const string k_ArgKeyFromDuelMenu = "fromDuelMenu";

	[Token(Token = "0x400987D")]
	private const string k_ArgKeyDoneOpenRequest = "doneOpenRequest";

	[Token(Token = "0x400987E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly string k_PrefabPath_ResidentMission;

	[Token(Token = "0x400987F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly string k_ELabelFooterOverSelector;

	[Token(Token = "0x4009880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly string k_ELabelTabList;

	[Token(Token = "0x4009881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly string k_ELabelMissionList;

	[Token(Token = "0x4009882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly string k_ELabelEmptyGroup;

	[Token(Token = "0x4009883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly string k_ELabelEmptyText;

	[Token(Token = "0x4009884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly string k_ELabelAnalogDirectionItem;

	[Token(Token = "0x4009885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly string k_ELabelCautionButton;

	[Token(Token = "0x4009886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly string k_ELabelBulkRecieveButton;

	[Token(Token = "0x4009887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelInEffectCover;

	[Token(Token = "0x4009888")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelInEffectSkipButton;

	[Token(Token = "0x4009889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_RLabelRecieveDialogListPref;

	[Token(Token = "0x400988A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private string m_CautionHelpPath;

	[Token(Token = "0x400988B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool m_IsHighEnd;

	[Token(Token = "0x400988C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private int m_RegistedGoThroughPriority;

	[Token(Token = "0x400988D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private AssetReferer m_AssetReferer;

	[Token(Token = "0x400988E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private PropertyContainer m_PropertyContainer;

	[Token(Token = "0x400988F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private WidgetFactory m_WidgetFactory;

	[Token(Token = "0x4009890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly MissionRootContext m_RootContext;

	[Token(Token = "0x4009891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private InOutPlayer m_InOutPlayer;

	[Token(Token = "0x4009892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private MissionTabListWidget m_TabListWidget;

	[Token(Token = "0x4009893")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private MissionListWidget m_MissionListWidget;

	[Token(Token = "0x4009894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly Dictionary<GameObject, MissionTabWidget> m_TabWidgetsMap;

	[Token(Token = "0x4009895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly Dictionary<GameObject, MissionPanelWidget> m_PanelWidgetsMap;

	[Token(Token = "0x4009896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly Dictionary<GameObject, MissionGoalsWidget> m_GoalsWidgetsMap;

	[Token(Token = "0x4009897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private MissionBulkRecieveButtonWidget m_BulkRecieveButtonWidget;

	[Token(Token = "0x4009898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly MissionSelectorHistory m_SelectorHistory;

	[Token(Token = "0x4009899")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private MissionSelectorHistoryHandler m_MissionSelectorHistoryHandler;

	[Token(Token = "0x400989A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private HelpMappingData m_HelpMappingData;

	[Token(Token = "0x400989B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private List<int> m_DeletedBadgeIds;

	[Token(Token = "0x60047E2")]
	[Address(RVA = "0x90A4B0", Offset = "0x9096B0", VA = "0x18090A4B0")]
	private void OnUpdatedAll()
	{
	}

	[Token(Token = "0x60047E3")]
	[Address(RVA = "0x90A540", Offset = "0x909740", VA = "0x18090A540")]
	private void OnUpdatedContainMissions()
	{
	}

	[Token(Token = "0x60047E4")]
	[Address(RVA = "0x9080A0", Offset = "0x9072A0", VA = "0x1809080A0")]
	private void OnPrevChangeTabIndex(int oldIdx)
	{
	}

	[Token(Token = "0x60047E5")]
	[Address(RVA = "0x904440", Offset = "0x903640", VA = "0x180904440")]
	private void OnChangeTabIndex(int newIdx)
	{
	}

	[Token(Token = "0x60047E6")]
	[Address(RVA = "0x90A570", Offset = "0x909770", VA = "0x18090A570")]
	private void OnUpdatedTabNewEvent(int tabIdx)
	{
	}

	[Token(Token = "0x60047E7")]
	[Address(RVA = "0x904C60", Offset = "0x903E60", VA = "0x180904C60")]
	private void OnCreatedGoalHolder(MissionGoalHolderWidget goalHolderWidget)
	{
	}

	[Token(Token = "0x60047E8")]
	[Address(RVA = "0x908C80", Offset = "0x907E80", VA = "0x180908C80")]
	private void OnUpdateGoalHolder(MissionGoalHolderWidget goalHolderWidget, int idx)
	{
	}

	[Token(Token = "0x60047E9")]
	[Address(RVA = "0x9086B0", Offset = "0x9078B0", VA = "0x1809086B0")]
	private void OnSelectedGoalHolder(MissionGoalHolderWidget goalHolder)
	{
	}

	[Token(Token = "0x60047EA")]
	[Address(RVA = "0x906A80", Offset = "0x905C80", VA = "0x180906A80")]
	private void OnDeselectedGoalHolder(MissionGoalHolderWidget goalHolder)
	{
	}

	[Token(Token = "0x60047EB")]
	[Address(RVA = "0x904620", Offset = "0x903820", VA = "0x180904620")]
	private void OnClickGoalHolder(MissionGoalHolderWidget goalHolder)
	{
	}

	[Token(Token = "0x60047EC")]
	[Address(RVA = "0x904D70", Offset = "0x903F70", VA = "0x180904D70")]
	private void OnCreatedGoalPage(GameObject goalPageEntity, MissionPanelWidget ownerPanel)
	{
	}

	[Token(Token = "0x60047ED")]
	[Address(RVA = "0x906D40", Offset = "0x905F40", VA = "0x180906D40")]
	private void OnFocusGoalPage(GameObject goalPageEntity, int dataidx, bool isselect, bool initialize)
	{
	}

	[Token(Token = "0x60047EE")]
	[Address(RVA = "0x906F00", Offset = "0x906100", VA = "0x180906F00")]
	private IReadOnlyList<(SelectionItem, int, int)> OnGoalCollectSelectionItems(GameObject goalPageEntity)
	{
		return null;
	}

	[Token(Token = "0x60047EF")]
	[Address(RVA = "0x909170", Offset = "0x908370", VA = "0x180909170")]
	private void OnUpdateGoalPage(GameObject goalPageEntity, int idx)
	{
	}

	[Token(Token = "0x60047F0")]
	[Address(RVA = "0x9068A0", Offset = "0x905AA0", VA = "0x1809068A0")]
	private void OnDeactivateGoalPage(GameObject goalPageEntity)
	{
	}

	[Token(Token = "0x60047F1")]
	[Address(RVA = "0x907070", Offset = "0x906270", VA = "0x180907070")]
	private bool OnGoalEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x60047F2")]
	[Address(RVA = "0x9051B0", Offset = "0x9043B0", VA = "0x1809051B0")]
	private void OnCreatedPanel(GameObject panelEntity)
	{
	}

	[Token(Token = "0x60047F3")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
	private IReadOnlyList<(SelectionItem, int, int)> OnPanelCollectSelectionItems(GameObject panelEntity)
	{
		return null;
	}

	[Token(Token = "0x60047F4")]
	[Address(RVA = "0x904380", Offset = "0x903580", VA = "0x180904380")]
	private void OnActivatePanel(GameObject panelEntity)
	{
	}

	[Token(Token = "0x60047F5")]
	[Address(RVA = "0x906910", Offset = "0x905B10", VA = "0x180906910")]
	private void OnDeactivatePanel(GameObject panelEntity)
	{
	}

	[Token(Token = "0x60047F6")]
	[Address(RVA = "0x909AA0", Offset = "0x908CA0", VA = "0x180909AA0")]
	private void OnUpdatePanel(GameObject panelEntity, int missionIdx)
	{
	}

	[Token(Token = "0x60047F7")]
	[Address(RVA = "0x9080D0", Offset = "0x9072D0", VA = "0x1809080D0")]
	private void OnReadyUpdateGoalsPager(MissionGoalsPagerWidget goalsPager, int pageCount, int pageIdx)
	{
	}

	[Token(Token = "0x60047F8")]
	[Address(RVA = "0x909A60", Offset = "0x908C60", VA = "0x180909A60")]
	private void OnUpdateLimitTextCallback(TMP_Text text, long remainSec)
	{
	}

	[Token(Token = "0x60047F9")]
	[Address(RVA = "0x90A230", Offset = "0x909430", VA = "0x18090A230")]
	private void OnUpdateRecieveLimitTextCallback(TMP_Text text, long remainSec)
	{
	}

	[Token(Token = "0x60047FA")]
	[Address(RVA = "0x908970", Offset = "0x907B70", VA = "0x180908970")]
	private bool OnSelectorSelectedPanel(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60047FB")]
	[Address(RVA = "0x906DE0", Offset = "0x905FE0", VA = "0x180906DE0")]
	private void OnFocusPanel(GameObject entity, int idx, bool isSelect, bool isInitializeSelect)
	{
	}

	[Token(Token = "0x60047FC")]
	[Address(RVA = "0x907B30", Offset = "0x906D30", VA = "0x180907B30")]
	private void OnPageChanged(MissionGoalsPagerWidget changedPager)
	{
	}

	[Token(Token = "0x60047FD")]
	[Address(RVA = "0x908010", Offset = "0x907210", VA = "0x180908010")]
	private void OnPlayGoalPagingBegin()
	{
	}

	[Token(Token = "0x60047FE")]
	[Address(RVA = "0x66C4D0", Offset = "0x66B6D0", VA = "0x18066C4D0")]
	private void OnPlayGoalPagingEnd()
	{
	}

	[Token(Token = "0x60047FF")]
	[Address(RVA = "0x90B0F0", Offset = "0x90A2F0", VA = "0x18090B0F0")]
	private void OpenRecieveResultSingleDialog(Action callback)
	{
	}

	[Token(Token = "0x6004800")]
	[Address(RVA = "0x90A6B0", Offset = "0x9098B0", VA = "0x18090A6B0")]
	private void OpenRecieveResultBulkDialog(Action callback)
	{
	}

	[Token(Token = "0x6004801")]
	[Address(RVA = "0x903ED0", Offset = "0x9030D0", VA = "0x180903ED0")]
	private void InsertBulkRecievedMissionContext(MissionBulkRecieveDialogWidget widget, TabContext tabCtx)
	{
	}

	[Token(Token = "0x6004802")]
	[Address(RVA = "0x903BD0", Offset = "0x902DD0", VA = "0x180903BD0")]
	private void InitSelectorHistoryHandlers()
	{
	}

	[Token(Token = "0x6004803")]
	[Address(RVA = "0x903970", Offset = "0x902B70", VA = "0x180903970")]
	private MissionSelectorHistoryHandler CreateTabSelectorHistoryHandler()
	{
		return null;
	}

	[Token(Token = "0x6004804")]
	[Address(RVA = "0x903840", Offset = "0x902A40", VA = "0x180903840")]
	private MissionSelectorHistoryHandler CreateMissionSelectorHistoryHandler()
	{
		return null;
	}

	[Token(Token = "0x6004805")]
	[Address(RVA = "0x905A00", Offset = "0x904C00", VA = "0x180905A00")]
	private void OnCreatedTab(GameObject entity)
	{
	}

	[Token(Token = "0x6004806")]
	[Address(RVA = "0x9048B0", Offset = "0x903AB0", VA = "0x1809048B0")]
	private void OnClickTab(MissionTabWidget tabWidget)
	{
	}

	[Token(Token = "0x6004807")]
	[Address(RVA = "0x90A2F0", Offset = "0x9094F0", VA = "0x18090A2F0")]
	private void OnUpdateTab(GameObject entity, int idx)
	{
	}

	[Token(Token = "0x6004808")]
	[Address(RVA = "0x906EC0", Offset = "0x9060C0", VA = "0x180906EC0")]
	private void OnFocusTab(GameObject entity, int idx, bool isselect, bool isinitialselect)
	{
	}

	[Token(Token = "0x6004809")]
	[Address(RVA = "0x90A5E0", Offset = "0x9097E0", VA = "0x18090A5E0")]
	public static void OpenOnHome(int tabId = 0, int poolId = 0)
	{
	}

	[Token(Token = "0x600480A")]
	[Address(RVA = "0x903720", Offset = "0x902920", VA = "0x180903720")]
	public static void CheckLaunch(int tabId = 0, int poolId = 0, [Optional] Action onSuccess, [Optional] Action onFailed, bool skipFailedDialog = false)
	{
	}

	[Token(Token = "0x600480B")]
	[Address(RVA = "0x904290", Offset = "0x903490", VA = "0x180904290", Slot = "28")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600480C")]
	[Address(RVA = "0x90D4C0", Offset = "0x90C6C0", VA = "0x18090D4C0", Slot = "27")]
	[IteratorStateMachine(typeof(_003CyInitializeInner_003Ed__81))]
	protected override IEnumerator yInitializeInner(ElementObjectManager eom, bool isOnlyMission = false, bool isSelectTab = false)
	{
		return null;
	}

	[Token(Token = "0x600480D")]
	[Address(RVA = "0x90BD10", Offset = "0x90AF10", VA = "0x18090BD10")]
	public void SelectDefaultCursor()
	{
	}

	[Token(Token = "0x600480E")]
	[Address(RVA = "0x90D580", Offset = "0x90C780", VA = "0x18090D580")]
	[IteratorStateMachine(typeof(_003CyPreReserveRoutine_003Ed__83))]
	private IEnumerator yPreReserveRoutine()
	{
		return null;
	}

	[Token(Token = "0x600480F")]
	[Address(RVA = "0x905B90", Offset = "0x904D90", VA = "0x180905B90", Slot = "33")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6004810")]
	[Address(RVA = "0x903B30", Offset = "0x902D30", VA = "0x180903B30", Slot = "32")]
	public override Selector GetSelector()
	{
		return null;
	}

	[Token(Token = "0x6004811")]
	[Address(RVA = "0x90C030", Offset = "0x90B230", VA = "0x18090C030", Slot = "34")]
	protected override void SetSurfaceActiveImpl(bool active)
	{
	}

	[Token(Token = "0x6004812")]
	[Address(RVA = "0x90C0B0", Offset = "0x90B2B0", VA = "0x18090C0B0", Slot = "30")]
	public override void TransitionStart(ViewController.TransitionType type)
	{
	}

	[Token(Token = "0x6004813")]
	[Address(RVA = "0x9042F0", Offset = "0x9034F0", VA = "0x1809042F0", Slot = "29")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6004814")]
	[Address(RVA = "0x90B820", Offset = "0x90AA20", VA = "0x18090B820")]
	private void RefreshTabList(bool changedCount)
	{
	}

	[Token(Token = "0x6004815")]
	[Address(RVA = "0x90B400", Offset = "0x90A600", VA = "0x18090B400")]
	private void RefreshMissionLabel()
	{
	}

	[Token(Token = "0x6004816")]
	[Address(RVA = "0x90B5F0", Offset = "0x90A7F0", VA = "0x18090B5F0")]
	private void RefreshMissionList(bool changedCount)
	{
	}

	[Token(Token = "0x6004817")]
	[Address(RVA = "0x90B460", Offset = "0x90A660", VA = "0x18090B460")]
	private void RefreshMissionListMessage()
	{
	}

	[Token(Token = "0x6004818")]
	[Address(RVA = "0x90B2E0", Offset = "0x90A4E0", VA = "0x18090B2E0")]
	private void RefreshBulkRecieveButton()
	{
	}

	[Token(Token = "0x6004819")]
	[Address(RVA = "0x90BF60", Offset = "0x90B160", VA = "0x18090BF60", Slot = "31")]
	public override void SetActiveFooter(bool active)
	{
	}

	[Token(Token = "0x600481A")]
	[Address(RVA = "0x90B8F0", Offset = "0x90AAF0", VA = "0x18090B8F0")]
	private void RequestBadgeDelete([Optional] Action onComplete)
	{
	}

	[Token(Token = "0x600481B")]
	[Address(RVA = "0x90BC40", Offset = "0x90AE40", VA = "0x18090BC40")]
	private void RequestGetMissionListApi([Optional] Action omComplete)
	{
	}

	[Token(Token = "0x600481C")]
	[Address(RVA = "0x904A20", Offset = "0x903C20", VA = "0x180904A20")]
	private void OnCompleteRecieveReward(Handle h, bool isBulk)
	{
	}

	[Token(Token = "0x600481D")]
	[Address(RVA = "0x908260", Offset = "0x907460", VA = "0x180908260")]
	private void OnRecieveResult(bool isBulk)
	{
	}

	[Token(Token = "0x600481E")]
	[Address(RVA = "0x907630", Offset = "0x906830", VA = "0x180907630")]
	private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x600481F")]
	[Address(RVA = "0x9045A0", Offset = "0x9037A0", VA = "0x1809045A0")]
	private void OnClickBulkRecieveButton()
	{
	}

	[Token(Token = "0x6004820")]
	[Address(RVA = "0x90D450", Offset = "0x90C650", VA = "0x18090D450")]
	[IteratorStateMachine(typeof(_003CyBulkRecieveRoutine_003Ed__103))]
	private IEnumerator yBulkRecieveRoutine()
	{
		return null;
	}

	[Token(Token = "0x6004821")]
	[Address(RVA = "0x90CFE0", Offset = "0x90C1E0", VA = "0x18090CFE0")]
	public ResidentMissionContent()
	{
	}
}
