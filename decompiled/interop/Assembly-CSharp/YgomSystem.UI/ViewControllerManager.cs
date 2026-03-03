using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000573")]
[AddComponentMenu("Ygom/UI/View Controller/View Controller Manager")]
public class ViewControllerManager : ViewController
{
	[Token(Token = "0x2000574")]
	public enum FadeState
	{
		[Token(Token = "0x4001A9F")]
		None,
		[Token(Token = "0x4001AA0")]
		FadeOuting,
		[Token(Token = "0x4001AA1")]
		FadeOutRequired,
		[Token(Token = "0x4001AA2")]
		FadeOut,
		[Token(Token = "0x4001AA3")]
		FadeInning
	}

	[Token(Token = "0x2000575")]
	private struct TransCache
	{
		[Token(Token = "0x2000576")]
		public enum Type
		{
			[Token(Token = "0x4001AA9")]
			Pop,
			[Token(Token = "0x4001AAA")]
			Push,
			[Token(Token = "0x4001AAB")]
			Swap,
			[Token(Token = "0x4001AAC")]
			Insert
		}

		[Token(Token = "0x4001AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Type type;

		[Token(Token = "0x4001AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GameObject prefab;

		[Token(Token = "0x4001AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ViewController target;

		[Token(Token = "0x4001AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, object> args;
	}

	[Token(Token = "0x2000577")]
	private struct TransInsert
	{
		[Token(Token = "0x4001AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject prefab;

		[Token(Token = "0x4001AAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Dictionary<string, object> args;

		[Token(Token = "0x600239E")]
		[Address(RVA = "0x5BF700", Offset = "0x5BE900", VA = "0x1805BF700")]
		public TransInsert(GameObject p, Dictionary<string, object> a)
		{
		}
	}

	[Token(Token = "0x200057A")]
	[CompilerGenerated]
	private sealed class _003CyAbortdViewController_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ViewControllerManager _003C_003E4__this;

		[Token(Token = "0x170003D2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60023A8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60023AA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60023A5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyAbortdViewController_003Ed__50(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60023A6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60023A7")]
		[Address(RVA = "0x66AE50", Offset = "0x66A050", VA = "0x18066AE50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60023A9")]
		[Address(RVA = "0x66B060", Offset = "0x66A260", VA = "0x18066B060", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001A8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static Dictionary<string, ViewControllerManager> namedManager;

	[Token(Token = "0x4001A8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected List<ViewController> viewStack;

	[Token(Token = "0x4001A8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Action<TransitionType, ViewController, ViewController> transitionAction;

	[Token(Token = "0x4001A8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TransitionType transDispType;

	[Token(Token = "0x4001A8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private TransitionType transHideType;

	[Token(Token = "0x4001A90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ViewController transDispView;

	[Token(Token = "0x4001A91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ViewController transHideView;

	[Token(Token = "0x4001A92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool transDispStart;

	[Token(Token = "0x4001A93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool transHideStart;

	[Token(Token = "0x4001A94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
	private bool transDispEnd;

	[Token(Token = "0x4001A95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
	private bool transHideEnd;

	[Token(Token = "0x4001A96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int firstSiblingIndex;

	[Token(Token = "0x4001A97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<Action> endTransActions;

	[Token(Token = "0x4001A98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private string managerName;

	[Token(Token = "0x4001A99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<TransCache> transCache;

	[Token(Token = "0x4001A9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<TransInsert> transInsert;

	[Token(Token = "0x4001A9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private FadeState dummyFadeState;

	[Token(Token = "0x4001A9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string DefaultPrefabPath;

	[Token(Token = "0x4001A9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Coroutine m_AbordViewControllerRoutine;

	[Token(Token = "0x170003D0")]
	public string ManagerName
	{
		[Token(Token = "0x6002353")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002352")]
		[Address(RVA = "0x670970", Offset = "0x66FB70", VA = "0x180670970")]
		set
		{
		}
	}

	[Token(Token = "0x170003D1")]
	public virtual int selectorRootPriority
	{
		[Token(Token = "0x6002355")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002354")]
	[Address(RVA = "0x670850", Offset = "0x66FA50", VA = "0x180670850")]
	public bool isReservedTransPush()
	{
		return default(bool);
	}

	[Token(Token = "0x6002356")]
	[Address(RVA = "0x66F0E0", Offset = "0x66E2E0", VA = "0x18066F0E0")]
	public static void StartTrans()
	{
	}

	[Token(Token = "0x6002357")]
	[Address(RVA = "0x66C4D0", Offset = "0x66B6D0", VA = "0x18066C4D0")]
	public static void EndTrans()
	{
	}

	[Token(Token = "0x6002358")]
	[Address(RVA = "0x66C360", Offset = "0x66B560", VA = "0x18066C360")]
	private void EndTransAction()
	{
	}

	[Token(Token = "0x6002359")]
	[Address(RVA = "0x66EFA0", Offset = "0x66E1A0", VA = "0x18066EFA0")]
	public void SetEndTransAction(Action action)
	{
	}

	[Token(Token = "0x600235A")]
	[Address(RVA = "0x66F0A0", Offset = "0x66E2A0", VA = "0x18066F0A0")]
	[Obsolete("This function is obsoleted. please use instead SystemBlocker.SetBlockEnabled")]
	public static void SetEventSystemEnabled(bool enabled)
	{
	}

	[Token(Token = "0x600235B")]
	[Address(RVA = "0x66E820", Offset = "0x66DA20", VA = "0x18066E820")]
	private void PushTransCache(TransCache.Type type, GameObject prefab, ViewController target, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600235C")]
	[Address(RVA = "0x66BE60", Offset = "0x66B060", VA = "0x18066BE60", Slot = "17")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x600235D")]
	[Address(RVA = "0x66D900", Offset = "0x66CB00", VA = "0x18066D900", Slot = "18")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x600235E")]
	[Address(RVA = "0x66F840", Offset = "0x66EA40", VA = "0x18066F840", Slot = "19")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600235F")]
	[Address(RVA = "0x66C500", Offset = "0x66B700", VA = "0x18066C500", Slot = "20")]
	protected virtual void FadeIn(ViewController hideView, TransitionType hideTrans, ViewController dispView, TransitionType dispTrans)
	{
	}

	[Token(Token = "0x6002360")]
	[Address(RVA = "0x66C510", Offset = "0x66B710", VA = "0x18066C510", Slot = "21")]
	protected virtual void FadeOut(ViewController hideView, TransitionType hideTrans, ViewController dispView, TransitionType dispTrans)
	{
	}

	[Token(Token = "0x6002361")]
	[Address(RVA = "0x3DDD20", Offset = "0x3DCF20", VA = "0x1803DDD20", Slot = "22")]
	protected virtual FadeState GetFadeState()
	{
		return default(FadeState);
	}

	[Token(Token = "0x6002362")]
	[Address(RVA = "0x66D830", Offset = "0x66CA30", VA = "0x18066D830", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6002363")]
	[Address(RVA = "0x66EC20", Offset = "0x66DE20", VA = "0x18066EC20")]
	private void SendNotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6002364")]
	[Address(RVA = "0x66D200", Offset = "0x66C400", VA = "0x18066D200")]
	private bool InsertViewStack(ViewController vc)
	{
		return default(bool);
	}

	[Token(Token = "0x6002365")]
	[Address(RVA = "0x66BFE0", Offset = "0x66B1E0", VA = "0x18066BFE0")]
	private void CleanupViewController(ViewController vc)
	{
	}

	[Token(Token = "0x6002366")]
	[Address(RVA = "0x66BB90", Offset = "0x66AD90", VA = "0x18066BB90")]
	private void AbordStack(int index, int count)
	{
	}

	[Token(Token = "0x6002367")]
	[Address(RVA = "0x66C640", Offset = "0x66B840", VA = "0x18066C640")]
	public void ForceClearViewControllerStack()
	{
	}

	[Token(Token = "0x6002368")]
	[Address(RVA = "0x66D070", Offset = "0x66C270", VA = "0x18066D070", Slot = "23")]
	protected virtual bool InsertTransform(GameObject vcgo)
	{
		return default(bool);
	}

	[Token(Token = "0x6002369")]
	[Address(RVA = "0x66D5C0", Offset = "0x66C7C0", VA = "0x18066D5C0")]
	public bool IsReadyTransition()
	{
		return default(bool);
	}

	[Token(Token = "0x600236A")]
	[Address(RVA = "0x66D730", Offset = "0x66C930", VA = "0x18066D730")]
	private GameObject LoadViewControllerPrefab(string prefabpath)
	{
		return null;
	}

	[Token(Token = "0x600236B")]
	[Address(RVA = "0x66BC50", Offset = "0x66AE50", VA = "0x18066BC50")]
	public void AbortChildViewController(ViewControllerAbortRequest abortRequest)
	{
	}

	[Token(Token = "0x600236C")]
	[Address(RVA = "0x670AD0", Offset = "0x66FCD0", VA = "0x180670AD0")]
	[IteratorStateMachine(typeof(_003CyAbortdViewController_003Ed__50))]
	private IEnumerator yAbortdViewController()
	{
		return null;
	}

	[Token(Token = "0x600236D")]
	[Address(RVA = "0x66DBA0", Offset = "0x66CDA0", VA = "0x18066DBA0")]
	public void PopChildViewController()
	{
	}

	[Token(Token = "0x600236E")]
	[Address(RVA = "0x66DC20", Offset = "0x66CE20", VA = "0x18066DC20")]
	public void PopChildViewController(ViewController popTatget)
	{
	}

	[Token(Token = "0x600236F")]
	[Address(RVA = "0x66E1B0", Offset = "0x66D3B0", VA = "0x18066E1B0")]
	public void PushChildViewController(string prefabpath)
	{
	}

	[Token(Token = "0x6002370")]
	[Address(RVA = "0x66E220", Offset = "0x66D420", VA = "0x18066E220")]
	public void PushChildViewController(GameObject prefab)
	{
	}

	[Token(Token = "0x6002371")]
	public void PushChildViewControllerParam<T>(string prefabpath, T parameter) where T : class
	{
	}

	[Token(Token = "0x6002372")]
	public void PushChildViewControllerParam<T>(GameObject prefab, T parameter) where T : class
	{
	}

	[Token(Token = "0x6002373")]
	[Address(RVA = "0x66E1E0", Offset = "0x66D3E0", VA = "0x18066E1E0")]
	public void PushChildViewController(string prefabpath, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002374")]
	[Address(RVA = "0x66E230", Offset = "0x66D430", VA = "0x18066E230")]
	public void PushChildViewController(GameObject prefab, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002375")]
	[Address(RVA = "0x66C110", Offset = "0x66B310", VA = "0x18066C110")]
	private ViewController CreateViewController(GameObject prefab, Dictionary<string, object> args)
	{
		return null;
	}

	[Token(Token = "0x6002376")]
	[Address(RVA = "0x66F650", Offset = "0x66E850", VA = "0x18066F650")]
	public void SwapTopChildViewController(string prefabpath)
	{
	}

	[Token(Token = "0x6002377")]
	[Address(RVA = "0x66F700", Offset = "0x66E900", VA = "0x18066F700")]
	public void SwapTopChildViewController(GameObject prefab)
	{
	}

	[Token(Token = "0x6002378")]
	public void SwapTopChildViewControllerParam<T>(string prefabpath, T parameter) where T : class
	{
	}

	[Token(Token = "0x6002379")]
	public void SwapTopChildViewControllerParam<T>(GameObject prefab, T parameter) where T : class
	{
	}

	[Token(Token = "0x600237A")]
	[Address(RVA = "0x66F4F0", Offset = "0x66E6F0", VA = "0x18066F4F0")]
	public void SwapTopChildViewController(string prefabpath, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600237B")]
	[Address(RVA = "0x66F5B0", Offset = "0x66E7B0", VA = "0x18066F5B0")]
	public void SwapTopChildViewController(GameObject prefab, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600237C")]
	[Address(RVA = "0x66F110", Offset = "0x66E310", VA = "0x18066F110")]
	public void SwapBottomChildViewController(string prefabpath)
	{
	}

	[Token(Token = "0x600237D")]
	[Address(RVA = "0x66F1C0", Offset = "0x66E3C0", VA = "0x18066F1C0")]
	public void SwapBottomChildViewController(GameObject prefab)
	{
	}

	[Token(Token = "0x600237E")]
	public void SwapBottomChildViewControllerParam<T>(string prefabpath, T parameter) where T : class
	{
	}

	[Token(Token = "0x600237F")]
	public void SwapBottomChildViewControllerParam<T>(GameObject prefab, T parameter) where T : class
	{
	}

	[Token(Token = "0x6002380")]
	[Address(RVA = "0x66F250", Offset = "0x66E450", VA = "0x18066F250")]
	public void SwapBottomChildViewController(string prefabpath, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002381")]
	[Address(RVA = "0x66F300", Offset = "0x66E500", VA = "0x18066F300")]
	public void SwapBottomChildViewController(GameObject prefab, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002382")]
	public void SwapChildViewControllerParam<T>(ViewController swapTatget, string prefabpath, T parameter) where T : class
	{
	}

	[Token(Token = "0x6002383")]
	[Address(RVA = "0x66F4A0", Offset = "0x66E6A0", VA = "0x18066F4A0")]
	public void SwapChildViewController(ViewController swapTatget, string prefabpath, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002384")]
	[Address(RVA = "0x66F3A0", Offset = "0x66E5A0", VA = "0x18066F3A0")]
	public void SwapChildViewController(ViewController swapTatget, GameObject prefab, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002385")]
	[Address(RVA = "0x6703F0", Offset = "0x66F5F0", VA = "0x1806703F0")]
	private void doSwapChildViewController(TransitionType disptrans, TransitionType hidetrans, ViewController swapTatget, GameObject prefab, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002386")]
	[Address(RVA = "0x66D030", Offset = "0x66C230", VA = "0x18066D030")]
	public void InsertChildViewController(string prefabpath, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002387")]
	[Address(RVA = "0x66CEE0", Offset = "0x66C0E0", VA = "0x18066CEE0")]
	public void InsertChildViewController(GameObject prefab, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002388")]
	[Address(RVA = "0x66EA50", Offset = "0x66DC50", VA = "0x18066EA50")]
	public ViewController SendChildResult(ViewController child, ViewController from, object value)
	{
		return null;
	}

	[Token(Token = "0x6002389")]
	[Address(RVA = "0x66DA90", Offset = "0x66CC90", VA = "0x18066DA90", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x600238A")]
	[Address(RVA = "0x66D840", Offset = "0x66CA40", VA = "0x18066D840", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600238B")]
	[Address(RVA = "0x66C520", Offset = "0x66B720", VA = "0x18066C520")]
	public ViewController FindViewController(string name, bool activeOnly = false)
	{
		return null;
	}

	[Token(Token = "0x600238C")]
	[Address(RVA = "0x66D650", Offset = "0x66C850", VA = "0x18066D650")]
	public bool IsViewController(ViewController vc)
	{
		return default(bool);
	}

	[Token(Token = "0x600238D")]
	[Address(RVA = "0x66CAD0", Offset = "0x66BCD0", VA = "0x18066CAD0")]
	public ViewController GetStackTopViewController()
	{
		return null;
	}

	[Token(Token = "0x600238E")]
	[Address(RVA = "0x66C990", Offset = "0x66BB90", VA = "0x18066C990")]
	public ViewController GetStackBottomViewController()
	{
		return null;
	}

	[Token(Token = "0x600238F")]
	[Address(RVA = "0x66CB40", Offset = "0x66BD40", VA = "0x18066CB40")]
	public ViewController GetStackViewController(int index)
	{
		return null;
	}

	[Token(Token = "0x6002390")]
	[Address(RVA = "0x66CBC0", Offset = "0x66BDC0", VA = "0x18066CBC0")]
	public ViewController GetStackViewController(string name)
	{
		return null;
	}

	[Token(Token = "0x6002391")]
	public T GetViewController<T>() where T : ViewController
	{
		return null;
	}

	[Token(Token = "0x6002392")]
	public T GetViewControllerAtFirst<T>() where T : ViewController
	{
		return null;
	}

	[Token(Token = "0x6002393")]
	[Address(RVA = "0x66CA00", Offset = "0x66BC00", VA = "0x18066CA00")]
	public int GetStackCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002394")]
	[Address(RVA = "0x66CA40", Offset = "0x66BC40", VA = "0x18066CA40")]
	public int GetStackIndex(ViewController vc)
	{
		return default(int);
	}

	[Token(Token = "0x6002395")]
	[Address(RVA = "0x66C7B0", Offset = "0x66B9B0", VA = "0x18066C7B0")]
	public ViewController GetFocusViewController(bool includeInactive = false)
	{
		return null;
	}

	[Token(Token = "0x6002396")]
	[Address(RVA = "0x66CD40", Offset = "0x66BF40", VA = "0x18066CD40")]
	public ViewController GetStyleViewController(ViewStyle style, int depth)
	{
		return null;
	}

	[Token(Token = "0x6002397")]
	[Address(RVA = "0x66D390", Offset = "0x66C590", VA = "0x18066D390")]
	public void InstantiateSetup()
	{
	}

	[Token(Token = "0x6002398")]
	[Address(RVA = "0x66E9A0", Offset = "0x66DBA0", VA = "0x18066E9A0")]
	public void RegisterTransitionAction(Action<TransitionType, ViewController, ViewController> act)
	{
	}

	[Token(Token = "0x6002399")]
	[Address(RVA = "0x66F790", Offset = "0x66E990", VA = "0x18066F790")]
	public void UnregisterTransitionAction(Action<TransitionType, ViewController, ViewController> act)
	{
	}

	[Token(Token = "0x600239A")]
	[Address(RVA = "0x66CE00", Offset = "0x66C000", VA = "0x18066CE00")]
	public static ViewControllerManager GetViewControllerManagerWithName(string name)
	{
		return null;
	}

	[Token(Token = "0x600239B")]
	[Address(RVA = "0x66ED00", Offset = "0x66DF00", VA = "0x18066ED00")]
	protected void SendStackAction(Dictionary<string, object> dic)
	{
	}

	[Token(Token = "0x600239C")]
	[Address(RVA = "0x6702C0", Offset = "0x66F4C0", VA = "0x1806702C0")]
	public ViewControllerManager()
	{
	}
}
