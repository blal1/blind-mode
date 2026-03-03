using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.TextIDs;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Tutorial;

[Token(Token = "0x20007AB")]
public class TutorialNavigator : MonoBehaviour
{
	[Token(Token = "0x20007AE")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x400266D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool decided;

		[Token(Token = "0x400266E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> _003C_003E9__1;

		[Token(Token = "0x600321D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600321E")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CShowCenterMessageInternal_003Eb__0()
		{
		}

		[Token(Token = "0x600321F")]
		[Address(RVA = "0x75C9E0", Offset = "0x75BBE0", VA = "0x18075C9E0")]
		internal bool _003CShowCenterMessageInternal_003Eb__1()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20007AF")]
	[CompilerGenerated]
	private sealed class _003CShowCenterMessageInternal_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400266F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TutorialNavigator _003C_003E4__this;

		[Token(Token = "0x4002672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAction onMsgEnd;

		[Token(Token = "0x4002673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float delay;

		[Token(Token = "0x4002674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

		[Token(Token = "0x4002675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _003Cobj_003E5__2;

		[Token(Token = "0x4002676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityAction _003CanyInput_003E5__3;

		[Token(Token = "0x4002677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string _003Clabel_003E5__4;

		[Token(Token = "0x4002678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _003Cdisplayed_003E5__5;

		[Token(Token = "0x4002679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject _003CtxtObj_003E5__6;

		[Token(Token = "0x400267A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _003Ci_003E5__7;

		[Token(Token = "0x400267B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _003Cn_003E5__8;

		[Token(Token = "0x17000634")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003223")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000635")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003225")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003220")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CShowCenterMessageInternal_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003221")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003222")]
		[Address(RVA = "0x759EA0", Offset = "0x7590A0", VA = "0x180759EA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003224")]
		[Address(RVA = "0x75A720", Offset = "0x759920", VA = "0x18075A720", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20007B0")]
	[CompilerGenerated]
	private sealed class _003CShowTopMessageInternal_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400267C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400267D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400267E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TutorialNavigator _003C_003E4__this;

		[Token(Token = "0x400267F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x17000636")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003229")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000637")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600322B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003226")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CShowTopMessageInternal_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003227")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003228")]
		[Address(RVA = "0x75AD30", Offset = "0x759F30", VA = "0x18075AD30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600322A")]
		[Address(RVA = "0x75AF30", Offset = "0x75A130", VA = "0x18075AF30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002658")]
	private const string VC_PREFAB_PATH = "Tutorial/TutorialNavigator";

	[Token(Token = "0x4002659")]
	private const string TOP_MESSAGE_LABEL = "TopMessage";

	[Token(Token = "0x400265A")]
	private const string CENTER_MESSAGE_LABEL = "CenterMessage";

	[Token(Token = "0x400265B")]
	private const string TOP_MSG_TEXT_LABEL = "TopMsgText";

	[Token(Token = "0x400265C")]
	private const string CENTER_MSG_TEXT_LABEL = "CenterMsgText";

	[Token(Token = "0x400265D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly int DEFAULT_SELECTOR_PRIORITY;

	[Token(Token = "0x400265E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static TutorialNavigator _instance;

	[Token(Token = "0x400265F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ElementObjectManager _prefabUI;

	[Token(Token = "0x4002660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ElementObjectManager _ui;

	[Token(Token = "0x4002661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ElementObject _topUI;

	[Token(Token = "0x4002662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ElementObject _centerUI;

	[Token(Token = "0x4002663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ExtendedTextMeshProUGUI _topText;

	[Token(Token = "0x4002664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ExtendedTextMeshProUGUI _centerText;

	[Token(Token = "0x4002665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private IEnumerator _coroutineTopMsgShowing;

	[Token(Token = "0x4002666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private IEnumerator _coroutineCenterMsgShowing;

	[Token(Token = "0x4002667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string _tmpTopMsg;

	[Token(Token = "0x4002668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<string> _tmpCenterMsgList;

	[Token(Token = "0x4002669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private UnityAction _onEndOfCenterMsg;

	[Token(Token = "0x400266A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int _setupCount;

	[Token(Token = "0x17000632")]
	public static bool topMsgShowing
	{
		[Token(Token = "0x6003203")]
		[Address(RVA = "0x758D50", Offset = "0x757F50", VA = "0x180758D50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000633")]
	public static bool centerMsgShowing
	{
		[Token(Token = "0x6003204")]
		[Address(RVA = "0x758C80", Offset = "0x757E80", VA = "0x180758C80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003205")]
	[Address(RVA = "0x7578C0", Offset = "0x756AC0", VA = "0x1807578C0")]
	public static void Open([Optional] Transform topMsgUIParent, [Optional] Transform centerMsgUIParent)
	{
	}

	[Token(Token = "0x6003206")]
	[Address(RVA = "0x7575C0", Offset = "0x7567C0", VA = "0x1807575C0")]
	public static void Close()
	{
	}

	[Token(Token = "0x6003207")]
	[Address(RVA = "0x758110", Offset = "0x757310", VA = "0x180758110")]
	public static void PlayTopMsg(IDS_TUTORIAL id, float delay = 0f)
	{
	}

	[Token(Token = "0x6003208")]
	[Address(RVA = "0x757E30", Offset = "0x757030", VA = "0x180757E30")]
	public static void PlayTopMsg(string message, float delay = 0f)
	{
	}

	[Token(Token = "0x6003209")]
	[Address(RVA = "0x758A10", Offset = "0x757C10", VA = "0x180758A10")]
	public static void StopTopMsg()
	{
	}

	[Token(Token = "0x600320A")]
	[Address(RVA = "0x757AD0", Offset = "0x756CD0", VA = "0x180757AD0")]
	public static void PlayCenterMsg(IList<IDS_TUTORIAL> msgIDs, UnityAction onMsgEnd, float delay = 0f)
	{
	}

	[Token(Token = "0x600320B")]
	[Address(RVA = "0x757C80", Offset = "0x756E80", VA = "0x180757C80")]
	public static void PlayCenterMsg(IList<string> messages, UnityAction onMsgEnd, float delay = 0f)
	{
	}

	[Token(Token = "0x600320C")]
	[Address(RVA = "0x758930", Offset = "0x757B30", VA = "0x180758930")]
	public static void StopCenterMsg()
	{
	}

	[Token(Token = "0x600320D")]
	[Address(RVA = "0x758230", Offset = "0x757430", VA = "0x180758230")]
	public static void Setup(int selectorPriority)
	{
	}

	[Token(Token = "0x600320E")]
	[Address(RVA = "0x758340", Offset = "0x757540", VA = "0x180758340")]
	public void Setup(Transform topMsgUIParent, Transform centerMsgUIParent)
	{
	}

	[Token(Token = "0x600320F")]
	[Address(RVA = "0x7581C0", Offset = "0x7573C0", VA = "0x1807581C0")]
	public void SetSelectorPriority(int priority)
	{
	}

	[Token(Token = "0x6003210")]
	[Address(RVA = "0x757620", Offset = "0x756820", VA = "0x180757620")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6003211")]
	[Address(RVA = "0x757440", Offset = "0x756640", VA = "0x180757440")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003212")]
	[Address(RVA = "0x7577E0", Offset = "0x7569E0", VA = "0x1807577E0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003213")]
	[Address(RVA = "0x758810", Offset = "0x757A10", VA = "0x180758810")]
	[IteratorStateMachine(typeof(_003CShowTopMessageInternal_003Ed__37))]
	private IEnumerator ShowTopMessageInternal(float delay)
	{
		return null;
	}

	[Token(Token = "0x6003214")]
	[Address(RVA = "0x758890", Offset = "0x757A90", VA = "0x180758890")]
	private void StopCenterMsgCore(bool disableActive = true)
	{
	}

	[Token(Token = "0x6003215")]
	[Address(RVA = "0x7579A0", Offset = "0x756BA0", VA = "0x1807579A0")]
	private void PlayCenterMsgCore(UnityAction onMsgEnd, float delay, UnityAction onPreProcess)
	{
	}

	[Token(Token = "0x6003216")]
	[Address(RVA = "0x758770", Offset = "0x757970", VA = "0x180758770")]
	[IteratorStateMachine(typeof(_003CShowCenterMessageInternal_003Ed__40))]
	private IEnumerator ShowCenterMessageInternal(UnityAction onMsgEnd, float delay)
	{
		return null;
	}

	[Token(Token = "0x6003217")]
	[Address(RVA = "0x758C00", Offset = "0x757E00", VA = "0x180758C00")]
	public TutorialNavigator()
	{
	}
}
