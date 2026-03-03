using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu.Common;

namespace YgomGame.Menu;

[Token(Token = "0x20013E7")]
public class OutGameBGManager : MonoBehaviour
{
	[Token(Token = "0x20013E8")]
	internal class BgLayer
	{
		[Token(Token = "0x400C46E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_CurrentPathName;

		[Token(Token = "0x400C46F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_RequestPathName;

		[Token(Token = "0x400C470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, BGInfo> m_BgInfoDic;

		[Token(Token = "0x400C471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject m_Root;

		[Token(Token = "0x6007BF9")]
		[Address(RVA = "0xC55680", Offset = "0xC54880", VA = "0x180C55680")]
		public BgLayer(GameObject root)
		{
		}
	}

	[Token(Token = "0x20013E9")]
	public class BGInfo
	{
		[Token(Token = "0x400C472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal GameObject target;

		[Token(Token = "0x400C473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isLoadedBg;

		[Token(Token = "0x6007BFA")]
		[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
		public BGInfo(GameObject target)
		{
		}

		[Token(Token = "0x6007BFB")]
		[Address(RVA = "0xC55450", Offset = "0xC54650", VA = "0x180C55450")]
		public void Disp(bool isDisp)
		{
		}

		[Token(Token = "0x6007BFC")]
		[Address(RVA = "0xC554C0", Offset = "0xC546C0", VA = "0x180C554C0")]
		public void EndTween()
		{
		}

		[Token(Token = "0x6007BFD")]
		[Address(RVA = "0xC55610", Offset = "0xC54810", VA = "0x180C55610")]
		public void Remove()
		{
		}

		[Token(Token = "0x6007BFE")]
		[Address(RVA = "0xC555C0", Offset = "0xC547C0", VA = "0x180C555C0")]
		public BindingGameObjectEx GetBGOEX()
		{
			return null;
		}

		[Token(Token = "0x6007BFF")]
		[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950")]
		public void SetIsLoaded()
		{
		}

		[Token(Token = "0x6007C00")]
		[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
		public bool IsLoaded()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20013ED")]
	[CompilerGenerated]
	private sealed class _003CCheckBGExistenceRoutine_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C47C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C47D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C47E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OutGameBGManager _003C_003E4__this;

		[Token(Token = "0x400C47F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17001308")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007C0A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001309")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007C0C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007C07")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckBGExistenceRoutine_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007C08")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007C09")]
		[Address(RVA = "0xC65CE0", Offset = "0xC64EE0", VA = "0x180C65CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007C0B")]
		[Address(RVA = "0xC65E00", Offset = "0xC65000", VA = "0x180C65E00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject m_Root;

	[Token(Token = "0x400C469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal BgLayer m_BackLayer;

	[Token(Token = "0x400C46A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject m_FrontLayerRoot;

	[Token(Token = "0x400C46B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OutGameBGManager instance;

	[Token(Token = "0x17001305")]
	public static OutGameBGManager Instance
	{
		[Token(Token = "0x6007BDE")]
		[Address(RVA = "0xC42710", Offset = "0xC41910", VA = "0x180C42710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001306")]
	public bool BGExist
	{
		[Token(Token = "0x6007BF3")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007BF2")]
		[Address(RVA = "0x406E80", Offset = "0x406080", VA = "0x180406E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001307")]
	public bool IsCheckingBGExistance
	{
		[Token(Token = "0x6007BF5")]
		[Address(RVA = "0x689960", Offset = "0x688B60", VA = "0x180689960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007BF4")]
		[Address(RVA = "0x74E7C0", Offset = "0x74D9C0", VA = "0x18074E7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6007BDF")]
	[Address(RVA = "0xC40E20", Offset = "0xC40020", VA = "0x180C40E20")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6007BE0")]
	[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
	public GameObject GetFrontRoot()
	{
		return null;
	}

	[Token(Token = "0x6007BE1")]
	[Address(RVA = "0xC41D10", Offset = "0xC40F10", VA = "0x180C41D10")]
	public BindingGameObjectEx PushBackBG(int backID, bool async = true, float duration = 0.5f, [Optional] Action<GameObject> onFinish)
	{
		return null;
	}

	[Token(Token = "0x6007BE2")]
	[Address(RVA = "0xC41600", Offset = "0xC40800", VA = "0x180C41600")]
	public BindingGameObjectEx PushBackBG(string pathName, bool async = true, float duration = 0.5f, [Optional] Action<GameObject> onFinish)
	{
		return null;
	}

	[Token(Token = "0x6007BE3")]
	[Address(RVA = "0xC41260", Offset = "0xC40460", VA = "0x180C41260")]
	private void PlayTweenInitBeforeBg(bool isChanged, string beforePathName = "")
	{
	}

	[Token(Token = "0x6007BE4")]
	[Address(RVA = "0xC40AA0", Offset = "0xC3FCA0", VA = "0x180C40AA0")]
	private void AddTweenInOut(string label, GameObject target, Color from, Color to, [Optional] UnityAction onFinished, float duration = 0.5f)
	{
	}

	[Token(Token = "0x6007BE5")]
	[Address(RVA = "0xC41090", Offset = "0xC40290", VA = "0x180C41090")]
	private void PlayTweenInOut(GameObject target, string label, float duration, bool wakeup = false)
	{
	}

	[Token(Token = "0x6007BE6")]
	[Address(RVA = "0xC409B0", Offset = "0xC3FBB0", VA = "0x180C409B0")]
	private void AddParticleTween(string label, GameObject target, float from, float to, float duration = 0.5f)
	{
	}

	[Token(Token = "0x6007BE7")]
	[Address(RVA = "0xC42600", Offset = "0xC41800", VA = "0x180C42600")]
	private static void SetSortingOrder(GameObject target, int sortingBase)
	{
	}

	[Token(Token = "0x6007BE8")]
	[Address(RVA = "0xC41DC0", Offset = "0xC40FC0", VA = "0x180C41DC0")]
	public void RemoveAllBack(bool onlyCache)
	{
	}

	[Token(Token = "0x6007BE9")]
	[Address(RVA = "0xC42300", Offset = "0xC41500", VA = "0x180C42300")]
	public void RemoveAllFront()
	{
	}

	[Token(Token = "0x6007BEA")]
	[Address(RVA = "0xC425D0", Offset = "0xC417D0", VA = "0x180C425D0")]
	public void RemoveAll()
	{
	}

	[Token(Token = "0x6007BEB")]
	[Address(RVA = "0xC40D00", Offset = "0xC3FF00", VA = "0x180C40D00")]
	public void DispRoot(bool activeSelf)
	{
	}

	[Token(Token = "0x6007BEC")]
	[Address(RVA = "0xC40DA0", Offset = "0xC3FFA0", VA = "0x180C40DA0")]
	public GameObject GetTopBackBG()
	{
		return null;
	}

	[Token(Token = "0x6007BED")]
	[Address(RVA = "0xC40D80", Offset = "0xC3FF80", VA = "0x180C40D80")]
	public string GetTopBackBGPath()
	{
		return null;
	}

	[Token(Token = "0x6007BEE")]
	[Address(RVA = "0xC41470", Offset = "0xC40670", VA = "0x180C41470")]
	public static void PlayTweenShow(GameObject target, bool immediate = false)
	{
	}

	[Token(Token = "0x6007BEF")]
	[Address(RVA = "0xC41040", Offset = "0xC40240", VA = "0x180C41040")]
	public static void PlayTweenHide(GameObject target, bool immediate = false)
	{
	}

	[Token(Token = "0x6007BF0")]
	[Address(RVA = "0xC41510", Offset = "0xC40710", VA = "0x180C41510")]
	private static void PlayTween(GameObject target, string playLabel, bool immediate = false)
	{
	}

	[Token(Token = "0x6007BF1")]
	[Address(RVA = "0xC40F80", Offset = "0xC40180", VA = "0x180C40F80")]
	public static bool IsPlayingShowHideTween(GameObject target)
	{
		return default(bool);
	}

	[Token(Token = "0x6007BF6")]
	[Address(RVA = "0xC40C80", Offset = "0xC3FE80", VA = "0x180C40C80")]
	public void CheckBGExistence()
	{
	}

	[Token(Token = "0x6007BF7")]
	[Address(RVA = "0xC40C10", Offset = "0xC3FE10", VA = "0x180C40C10")]
	[IteratorStateMachine(typeof(_003CCheckBGExistenceRoutine_003Ed__36))]
	private IEnumerator CheckBGExistenceRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007BF8")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public OutGameBGManager()
	{
	}
}
