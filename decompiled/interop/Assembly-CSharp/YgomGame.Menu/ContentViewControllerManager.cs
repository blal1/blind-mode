using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200124F")]
public class ContentViewControllerManager : ViewControllerManager
{
	[Token(Token = "0x2001250")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[Token(Token = "0x400BB1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int abort_count;

		[Token(Token = "0x6007234")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6007235")]
		[Address(RVA = "0x9C74A0", Offset = "0x9C66A0", VA = "0x1809C74A0")]
		internal void _003CWaitAbortNetwork_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2001251")]
	[CompilerGenerated]
	private sealed class _003CWaitAbortNetwork_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BB1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BB1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BB20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		[Token(Token = "0x400BB21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ContentViewControllerManager _003C_003E4__this;

		[Token(Token = "0x400BB22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _003Ctime_003E5__2;

		[Token(Token = "0x17001203")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007239")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001204")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600723B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007236")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CWaitAbortNetwork_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007237")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007238")]
		[Address(RVA = "0xB9DCF0", Offset = "0xB9CEF0", VA = "0x180B9DCF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600723A")]
		[Address(RVA = "0xB9DFD0", Offset = "0xB9D1D0", VA = "0x180B9DFD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BB11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ContentViewControllerManager Instance;

	[Token(Token = "0x400BB12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private bool m_launchDefaultVC;

	[Token(Token = "0x400BB13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private string m_wakeupBoot;

	[Token(Token = "0x400BB16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool AbortNetwork;

	[Token(Token = "0x400BB17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private IEnumerator m_WaitAbortNetworkCoroutine;

	[Token(Token = "0x400BB18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float transitionTime;

	[Token(Token = "0x400BB19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Canvas cv;

	[Token(Token = "0x400BB1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Color fadeColor;

	[Token(Token = "0x400BB1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private SystemProgress.ProgressType fadeType;

	[Token(Token = "0x400BB1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private bool manageFade;

	[Token(Token = "0x17001200")]
	public bool ConfirmAppQuit
	{
		[Token(Token = "0x6007222")]
		[Address(RVA = "0x42D4D0", Offset = "0x42C6D0", VA = "0x18042D4D0")]
		[CompilerGenerated]
		private get
		{
			return default(bool);
		}
		[Token(Token = "0x6007221")]
		[Address(RVA = "0x42D620", Offset = "0x42C820", VA = "0x18042D620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001201")]
	public string AppQuitUrlScheme
	{
		[Token(Token = "0x6007224")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Token(Token = "0x6007223")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001202")]
	public Rect CanvasScreen
	{
		[Token(Token = "0x6007229")]
		[Address(RVA = "0xB744C0", Offset = "0xB736C0", VA = "0x180B744C0")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x6007217")]
	[Address(RVA = "0xB737D0", Offset = "0xB729D0", VA = "0x180B737D0")]
	public static ContentViewControllerManager GetManager()
	{
		return null;
	}

	[Token(Token = "0x6007218")]
	[Address(RVA = "0xB73190", Offset = "0xB72390", VA = "0x180B73190", Slot = "17")]
	public override void Awake()
	{
	}

	[Token(Token = "0x6007219")]
	[Address(RVA = "0xB73940", Offset = "0xB72B40", VA = "0x180B73940", Slot = "18")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600721A")]
	[Address(RVA = "0xB740D0", Offset = "0xB732D0", VA = "0x180B740D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600721B")]
	[Address(RVA = "0xB74330", Offset = "0xB73530", VA = "0x180B74330", Slot = "19")]
	public override void Update()
	{
	}

	[Token(Token = "0x600721C")]
	[Address(RVA = "0xB73D40", Offset = "0xB72F40", VA = "0x180B73D40")]
	public void PrepareReboot()
	{
	}

	[Token(Token = "0x600721D")]
	[Address(RVA = "0xB73330", Offset = "0xB72530", VA = "0x180B73330")]
	public void ExecuteReboot([Optional] string bootpath)
	{
	}

	[Token(Token = "0x600721E")]
	[Address(RVA = "0xB732A0", Offset = "0xB724A0", VA = "0x180B732A0")]
	public void Boot([Optional] string bootpath)
	{
	}

	[Token(Token = "0x600721F")]
	[Address(RVA = "0xB738E0", Offset = "0xB72AE0", VA = "0x180B738E0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6007220")]
	[Address(RVA = "0xB73A60", Offset = "0xB72C60", VA = "0x180B73A60")]
	public void OpenAppQuitDialog()
	{
	}

	[Token(Token = "0x6007225")]
	[Address(RVA = "0xB74610", Offset = "0xB73810", VA = "0x180B74610")]
	private bool wantsToQuit()
	{
		return default(bool);
	}

	[Token(Token = "0x6007226")]
	[Address(RVA = "0xB74400", Offset = "0xB73600", VA = "0x180B74400")]
	[IteratorStateMachine(typeof(_003CWaitAbortNetwork_003Ed__24))]
	private IEnumerator WaitAbortNetwork()
	{
		return null;
	}

	[Token(Token = "0x6007227")]
	[Address(RVA = "0xB74230", Offset = "0xB73430", VA = "0x180B74230", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6007228")]
	[Address(RVA = "0xB74260", Offset = "0xB73460", VA = "0x180B74260", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600722A")]
	[Address(RVA = "0xB740B0", Offset = "0xB732B0", VA = "0x180B740B0")]
	public void SetFadeType(SystemProgress.ProgressType tp, Color color)
	{
	}

	[Token(Token = "0x600722B")]
	[Address(RVA = "0xB73410", Offset = "0xB72610", VA = "0x180B73410", Slot = "20")]
	protected override void FadeIn(ViewController hideView, TransitionType hideTrans, ViewController dispView, TransitionType dispTrans)
	{
	}

	[Token(Token = "0x600722C")]
	[Address(RVA = "0xB73490", Offset = "0xB72690", VA = "0x180B73490", Slot = "21")]
	protected override void FadeOut(ViewController hideView, TransitionType hideTrans, ViewController dispView, TransitionType dispTrans)
	{
	}

	[Token(Token = "0x600722D")]
	[Address(RVA = "0xB73790", Offset = "0xB72990", VA = "0x180B73790", Slot = "22")]
	protected override FadeState GetFadeState()
	{
		return default(FadeState);
	}

	[Token(Token = "0x600722E")]
	[Address(RVA = "0xB73F40", Offset = "0xB73140", VA = "0x180B73F40")]
	private void SendStackActionAction(TransitionType type, ViewController vc, ViewController preVc)
	{
	}

	[Token(Token = "0x600722F")]
	[Address(RVA = "0xB74000", Offset = "0xB73200", VA = "0x180B74000")]
	public void SetBlurSetting(bool isBlur)
	{
	}

	[Token(Token = "0x6007230")]
	[Address(RVA = "0xB73740", Offset = "0xB72940", VA = "0x180B73740")]
	public Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x6007231")]
	[Address(RVA = "0xB74470", Offset = "0xB73670", VA = "0x180B74470")]
	public ContentViewControllerManager()
	{
	}
}
