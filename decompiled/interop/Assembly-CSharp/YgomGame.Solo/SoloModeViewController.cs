using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Menu;
using YgomSystem.Timeline;
using YgomSystem.UI;

namespace YgomGame.Solo;

[Token(Token = "0x20008AC")]
public class SoloModeViewController : BaseMenuViewController
{
	[Token(Token = "0x20008AE")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x400878E")]
		[FieldOffset(Offset = "0x10")]
		public bool isShowingTutorial;

		[Token(Token = "0x400878F")]
		[FieldOffset(Offset = "0x18")]
		public GameObject onlyTutorialRoot;

		[Token(Token = "0x600346C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x600346D")]
		[Address(RVA = "0x7B0520", Offset = "0x7AF720", VA = "0x1807B0520")]
		internal void _003CStart_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20008AF")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_1
	{
		[Token(Token = "0x4008790")]
		[FieldOffset(Offset = "0x10")]
		public bool isShowingHelp;

		[Token(Token = "0x600346E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass12_1()
		{
		}

		[Token(Token = "0x600346F")]
		[Address(RVA = "0x7B0580", Offset = "0x7AF780", VA = "0x1807B0580")]
		internal void _003CStart_003Eb__1()
		{
		}
	}

	[Token(Token = "0x20008B3")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x400879D")]
		[FieldOffset(Offset = "0x10")]
		public SoloModeViewController _003C_003E4__this;

		[Token(Token = "0x400879E")]
		[FieldOffset(Offset = "0x18")]
		public bool isSkip;

		[Token(Token = "0x400879F")]
		[FieldOffset(Offset = "0x20")]
		public EventPlayableAsset eventPlayableAsset;

		[Token(Token = "0x40087A0")]
		[FieldOffset(Offset = "0x28")]
		public bool isSwap;

		[Token(Token = "0x40087A1")]
		[FieldOffset(Offset = "0x2C")]
		public int gateId;

		[Token(Token = "0x40087A2")]
		[FieldOffset(Offset = "0x30")]
		public SoloModeUtil.EntranceType entranceType;

		[Token(Token = "0x40087A3")]
		[FieldOffset(Offset = "0x34")]
		public SoloModeUtil.PortalButton portalButton;

		[Token(Token = "0x40087A4")]
		[FieldOffset(Offset = "0x38")]
		public int listCategory;

		[Token(Token = "0x600347B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x600347C")]
		[Address(RVA = "0x7B2FB0", Offset = "0x7B21B0", VA = "0x1807B2FB0")]
		internal void _003CyTransitionCoverRoutine_003Eb__0()
		{
		}

		[Token(Token = "0x600347D")]
		[Address(RVA = "0x7B30D0", Offset = "0x7B22D0", VA = "0x1807B30D0")]
		internal void _003CyTransitionCoverRoutine_003Eb__3()
		{
		}

		[Token(Token = "0x600347E")]
		[Address(RVA = "0x7B2FE0", Offset = "0x7B21E0", VA = "0x1807B2FE0")]
		internal void _003CyTransitionCoverRoutine_003Eb__1()
		{
		}
	}

	[Token(Token = "0x20008B4")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_1
	{
		[Token(Token = "0x40087A5")]
		[FieldOffset(Offset = "0x10")]
		public bool isWaitPause;

		[Token(Token = "0x40087A6")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x600347F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass25_1()
		{
		}

		[Token(Token = "0x6003480")]
		[Address(RVA = "0x7B3170", Offset = "0x7B2370", VA = "0x1807B3170")]
		internal void _003CyTransitionCoverRoutine_003Eb__4()
		{
		}
	}

	[Token(Token = "0x20008B5")]
	[CompilerGenerated]
	private sealed class _003CExitView_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40087A7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40087A8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40087A9")]
		[FieldOffset(Offset = "0x20")]
		public SoloModeViewController _003C_003E4__this;

		[Token(Token = "0x17000675")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003484")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000676")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003486")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003481")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CExitView_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003482")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003483")]
		[Address(RVA = "0x7AE030", Offset = "0x7AD230", VA = "0x1807AE030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003485")]
		[Address(RVA = "0x7AE0D0", Offset = "0x7AD2D0", VA = "0x1807AE0D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20008B6")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40087AA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40087AB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40087AC")]
		[FieldOffset(Offset = "0x20")]
		public SoloModeViewController _003C_003E4__this;

		[Token(Token = "0x40087AD")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		[Token(Token = "0x40087AE")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass12_1 _003C_003E8__2;

		[Token(Token = "0x17000677")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600348A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000678")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600348C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003487")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003488")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003489")]
		[Address(RVA = "0x7AFC20", Offset = "0x7AEE20", VA = "0x1807AFC20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600348B")]
		[Address(RVA = "0x7B0030", Offset = "0x7AF230", VA = "0x1807B0030", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20008B7")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40087AF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40087B0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40087B1")]
		[FieldOffset(Offset = "0x20")]
		public SoloModeViewController _003C_003E4__this;

		[Token(Token = "0x40087B2")]
		[FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x17000679")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003490")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700067A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003492")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600348D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600348E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600348F")]
		[Address(RVA = "0x7B3EC0", Offset = "0x7B30C0", VA = "0x1807B3EC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003491")]
		[Address(RVA = "0x7B4330", Offset = "0x7B3530", VA = "0x1807B4330", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20008B8")]
	[CompilerGenerated]
	private sealed class _003CyTransitionCoverRoutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40087B3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40087B4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40087B5")]
		[FieldOffset(Offset = "0x20")]
		public SoloModeViewController _003C_003E4__this;

		[Token(Token = "0x40087B6")]
		[FieldOffset(Offset = "0x28")]
		public int gateId;

		[Token(Token = "0x40087B7")]
		[FieldOffset(Offset = "0x2C")]
		public SoloModeUtil.EntranceType entranceType;

		[Token(Token = "0x40087B8")]
		[FieldOffset(Offset = "0x30")]
		public SoloModeUtil.PortalButton portalButton;

		[Token(Token = "0x40087B9")]
		[FieldOffset(Offset = "0x34")]
		public int listCategory;

		[Token(Token = "0x40087BA")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass25_1 _003C_003E8__1;

		[Token(Token = "0x40087BB")]
		[FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass25_0 _003C_003E8__2;

		[Token(Token = "0x1700067B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003496")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700067C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003498")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003493")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyTransitionCoverRoutine_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003494")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003495")]
		[Address(RVA = "0x7B4370", Offset = "0x7B3570", VA = "0x1807B4370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003497")]
		[Address(RVA = "0x7B4C50", Offset = "0x7B3E50", VA = "0x1807B4C50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400877B")]
	[FieldOffset(Offset = "0xD0")]
	private PlayableDirector m_SoloTransition;

	[Token(Token = "0x400877C")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_IsWhileTutorial;

	[Token(Token = "0x400877D")]
	[FieldOffset(Offset = "0xD9")]
	private bool m_IsReady;

	[Token(Token = "0x400877E")]
	[FieldOffset(Offset = "0xE0")]
	private string m_LoadedBgmLabel;

	[Token(Token = "0x400877F")]
	[FieldOffset(Offset = "0xE8")]
	private SoloFlyingCardSettings m_SoloFlyingCardSettings;

	[Token(Token = "0x4008780")]
	private const string k_EButton = "Button";

	[Token(Token = "0x4008781")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_EOnlyTutorial;

	[Token(Token = "0x4008782")]
	public const string k_PrefPath = "Solo/SoloMode";

	[Token(Token = "0x4008783")]
	[FieldOffset(Offset = "0xF8")]
	private IEnumerator m_InitRoutine;

	[Token(Token = "0x4008784")]
	[FieldOffset(Offset = "0x100")]
	private IEnumerator m_ExitRoutine;

	[Token(Token = "0x17000674")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600344E")]
		[Address(RVA = "0x777B60", Offset = "0x776D60", VA = "0x180777B60", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600344F")]
	[Address(RVA = "0x777840", Offset = "0x776A40", VA = "0x180777840")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__12))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6003450")]
	[Address(RVA = "0x776FC0", Offset = "0x7761C0", VA = "0x180776FC0", Slot = "10")]
	public override void ProgressUpdate()
	{
	}

	[Token(Token = "0x6003451")]
	[Address(RVA = "0x776870", Offset = "0x775A70", VA = "0x180776870", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003452")]
	[Address(RVA = "0x776970", Offset = "0x775B70", VA = "0x180776970", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6003453")]
	[Address(RVA = "0x777CA0", Offset = "0x776EA0", VA = "0x180777CA0")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__16))]
	private IEnumerator yInitialize(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6003454")]
	[Address(RVA = "0x776490", Offset = "0x775690", VA = "0x180776490")]
	[IteratorStateMachine(typeof(_003CExitView_003Ed__17))]
	private IEnumerator ExitView()
	{
		return null;
	}

	[Token(Token = "0x6003455")]
	[Address(RVA = "0x777AA0", Offset = "0x776CA0", VA = "0x180777AA0", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6003456")]
	[Address(RVA = "0x776C80", Offset = "0x775E80", VA = "0x180776C80", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6003457")]
	[Address(RVA = "0x775C00", Offset = "0x774E00", VA = "0x180775C00")]
	private void ControllView()
	{
	}

	[Token(Token = "0x6003458")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830")]
	private bool CanPlayGate(int gateId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003459")]
	[Address(RVA = "0x777020", Offset = "0x776220", VA = "0x180777020")]
	private void StartTimeLine()
	{
	}

	[Token(Token = "0x600345A")]
	[Address(RVA = "0x776500", Offset = "0x775700", VA = "0x180776500")]
	private EventPlayableAsset GetEventPlayableAsset(PlayableDirector timeline)
	{
		return null;
	}

	[Token(Token = "0x600345B")]
	[Address(RVA = "0x7760B0", Offset = "0x7752B0", VA = "0x1807760B0")]
	private void EndTimeLine(int id, SoloModeUtil.EntranceType entranceType, SoloModeUtil.PortalButton portalButton, int listCategory = 0)
	{
	}

	[Token(Token = "0x600345C")]
	[Address(RVA = "0x777D30", Offset = "0x776F30", VA = "0x180777D30")]
	[IteratorStateMachine(typeof(_003CyTransitionCoverRoutine_003Ed__25))]
	private IEnumerator yTransitionCoverRoutine(int gateId, SoloModeUtil.EntranceType entranceType, SoloModeUtil.PortalButton portalButton, int listCategory)
	{
		return null;
	}

	[Token(Token = "0x600345D")]
	[Address(RVA = "0x7778B0", Offset = "0x776AB0", VA = "0x1807778B0")]
	private void SwapChapterMap(int gateId, SoloModeUtil.EntranceType entranceType, SoloModeUtil.PortalButton portalButton, int listCategory)
	{
	}

	[Token(Token = "0x600345E")]
	[Address(RVA = "0x776A60", Offset = "0x775C60", VA = "0x180776A60")]
	private void OnBackTimeLine()
	{
	}

	[Token(Token = "0x600345F")]
	[Address(RVA = "0x777AE0", Offset = "0x776CE0", VA = "0x180777AE0")]
	public SoloModeViewController()
	{
	}
}
