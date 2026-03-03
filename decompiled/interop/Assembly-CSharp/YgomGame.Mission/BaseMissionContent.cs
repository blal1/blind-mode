using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Mission;

[Token(Token = "0x2000C17")]
public abstract class BaseMissionContent : MonoBehaviour, IMissionContent
{
	[Token(Token = "0x2000C18")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009A25")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009A26")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009A27")]
		[FieldOffset(Offset = "0x20")]
		public BaseMissionContent _003C_003E4__this;

		[Token(Token = "0x4009A28")]
		[FieldOffset(Offset = "0x28")]
		public ElementObjectManager eom;

		[Token(Token = "0x4009A29")]
		[FieldOffset(Offset = "0x30")]
		public bool isOnlyMission;

		[Token(Token = "0x4009A2A")]
		[FieldOffset(Offset = "0x31")]
		public bool isSelectTab;

		[Token(Token = "0x4009A2B")]
		[FieldOffset(Offset = "0x38")]
		public Action onComplete;

		[Token(Token = "0x4009A2C")]
		[FieldOffset(Offset = "0x40")]
		private IEnumerator _003CinitRoutine_003E5__2;

		[Token(Token = "0x17000A03")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60049E3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A04")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60049E5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60049E0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60049E1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60049E2")]
		[Address(RVA = "0x94B420", Offset = "0x94A620", VA = "0x18094B420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60049E4")]
		[Address(RVA = "0x94B530", Offset = "0x94A730", VA = "0x18094B530", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009A18")]
	[FieldOffset(Offset = "0x20")]
	public readonly string k_ELabel_ContentArea;

	[Token(Token = "0x4009A19")]
	[FieldOffset(Offset = "0x28")]
	private bool m_Initialized;

	[Token(Token = "0x4009A1A")]
	[FieldOffset(Offset = "0x30")]
	protected Dictionary<string, object> m_Args;

	[Token(Token = "0x4009A1B")]
	[FieldOffset(Offset = "0x38")]
	protected TextGroupLoadHolder m_TextGroupLoadHolder;

	[Token(Token = "0x4009A1C")]
	[FieldOffset(Offset = "0x40")]
	public Func<int, int> onGetSelectorPriorityAdditional;

	[Token(Token = "0x4009A1D")]
	[FieldOffset(Offset = "0x48")]
	protected Selector m_Selector;

	[Token(Token = "0x4009A1E")]
	[FieldOffset(Offset = "0x50")]
	protected List<Selector> m_AllSelectors;

	[Token(Token = "0x4009A1F")]
	[FieldOffset(Offset = "0x58")]
	protected ElementObjectManager m_View;

	[Token(Token = "0x4009A20")]
	[FieldOffset(Offset = "0x60")]
	protected GameObject m_Container;

	[Token(Token = "0x170009FF")]
	public bool initialized
	{
		[Token(Token = "0x60049C0")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A00")]
	public Dictionary<string, object> Args
	{
		[Token(Token = "0x60049C1")]
		[Address(RVA = "0x931A70", Offset = "0x930C70", VA = "0x180931A70", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60049C2")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17000A01")]
	public TextGroupLoadHolder textGroupLoadHolder
	{
		[Token(Token = "0x60049C3")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x60049C4")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17000A02")]
	private Func<int, int> YgomGame_002EMission_002EIMissionContent_002EonGetSelectorPriorityAdditional
	{
		[Token(Token = "0x60049C5")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x60049C6")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x14000064")]
	public event Action onRequestedPopVC
	{
		[Token(Token = "0x60049CF")]
		[Address(RVA = "0x931890", Offset = "0x930A90", VA = "0x180931890", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60049D0")]
		[Address(RVA = "0x931BB0", Offset = "0x930DB0", VA = "0x180931BB0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000065")]
	public event Action onRequestedRefreshBadge
	{
		[Token(Token = "0x60049D1")]
		[Address(RVA = "0x931930", Offset = "0x930B30", VA = "0x180931930", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60049D2")]
		[Address(RVA = "0x931C50", Offset = "0x930E50", VA = "0x180931C50", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000066")]
	public event Action onRequestedTopPanelTransition
	{
		[Token(Token = "0x60049D3")]
		[Address(RVA = "0x9319D0", Offset = "0x930BD0", VA = "0x1809319D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60049D4")]
		[Address(RVA = "0x931CF0", Offset = "0x930EF0", VA = "0x180931CF0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000067")]
	public event Action<SelectionButton> onRequestedClickContent
	{
		[Token(Token = "0x60049D5")]
		[Address(RVA = "0x9317D0", Offset = "0x9309D0", VA = "0x1809317D0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60049D6")]
		[Address(RVA = "0x931AF0", Offset = "0x930CF0", VA = "0x180931AF0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60049C7")]
	protected abstract IEnumerator yInitializeInner(ElementObjectManager eom, bool isOnlyMission = false, bool isSelectTab = false);

	[Token(Token = "0x60049C8")]
	public abstract void NotificationStackEntry();

	[Token(Token = "0x60049C9")]
	public abstract void NotificationStackRemove();

	[Token(Token = "0x60049CA")]
	public abstract void TransitionStart(ViewController.TransitionType type);

	[Token(Token = "0x60049CB")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "31")]
	public virtual void SetActiveFooter(bool active)
	{
	}

	[Token(Token = "0x60049CC")]
	[Address(RVA = "0x9315C0", Offset = "0x9307C0", VA = "0x1809315C0", Slot = "32")]
	public virtual Selector GetSelector()
	{
		return null;
	}

	[Token(Token = "0x60049CD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "33")]
	protected virtual void OnCreatedView()
	{
	}

	[Token(Token = "0x60049CE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "34")]
	protected virtual void SetSurfaceActiveImpl(bool active)
	{
	}

	[Token(Token = "0x60049D7")]
	[Address(RVA = "0x886300", Offset = "0x885500", VA = "0x180886300")]
	public void RequestPopVC()
	{
	}

	[Token(Token = "0x60049D8")]
	[Address(RVA = "0x931650", Offset = "0x930850", VA = "0x180931650")]
	public void RequestRefreshBadge()
	{
	}

	[Token(Token = "0x60049D9")]
	[Address(RVA = "0x931670", Offset = "0x930870", VA = "0x180931670")]
	public void RequestTopPanelTransition()
	{
	}

	[Token(Token = "0x60049DA")]
	[Address(RVA = "0x931630", Offset = "0x930830", VA = "0x180931630")]
	public void RequestClickContent(SelectionButton sb)
	{
	}

	[Token(Token = "0x60049DB")]
	[Address(RVA = "0x931D90", Offset = "0x930F90", VA = "0x180931D90", Slot = "20")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__44))]
	public IEnumerator yInitialize(ElementObjectManager eom, Action onComplete, bool isOnlyMission = false, bool isSelectTab = false)
	{
		return null;
	}

	[Token(Token = "0x60049DC")]
	[Address(RVA = "0x931410", Offset = "0x930610", VA = "0x180931410")]
	public void CreateView(ElementObjectManager eom, GameObject container)
	{
	}

	[Token(Token = "0x60049DD")]
	[Address(RVA = "0x931690", Offset = "0x930890", VA = "0x180931690", Slot = "21")]
	public void SetSurfaceActive(bool active)
	{
	}

	[Token(Token = "0x60049DE")]
	[Address(RVA = "0x9315A0", Offset = "0x9307A0", VA = "0x1809315A0", Slot = "23")]
	public int GetSelectorPriorityAdditional(int addPos)
	{
		return default(int);
	}

	[Token(Token = "0x60049DF")]
	[Address(RVA = "0x931730", Offset = "0x930930", VA = "0x180931730")]
	protected BaseMissionContent()
	{
	}
}
