using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Bg;

[Token(Token = "0x2000047")]
public class Character : MonoBehaviour
{
	[Token(Token = "0x2000048")]
	public enum TapPhase
	{
		[Token(Token = "0x4000153")]
		TapPhaseNone,
		[Token(Token = "0x4000154")]
		TapPhaseWait,
		[Token(Token = "0x4000155")]
		TapPhaseWaitToPhase1,
		[Token(Token = "0x4000156")]
		TapPhase1,
		[Token(Token = "0x4000157")]
		TapPhasePhase1ToWait,
		[Token(Token = "0x4000158")]
		TapPhaseWaitToPhase2,
		[Token(Token = "0x4000159")]
		TapPhase2,
		[Token(Token = "0x400015A")]
		TapPhasePhase2ToWait,
		[Token(Token = "0x400015B")]
		TapPhaseWaitToPhase3,
		[Token(Token = "0x400015C")]
		TapPhase3,
		[Token(Token = "0x400015D")]
		TapPhasePhase3ToWait
	}

	[Token(Token = "0x2000049")]
	public enum WaitType
	{
		[Token(Token = "0x400015F")]
		WAIT2,
		[Token(Token = "0x4000160")]
		WAIT3,
		[Token(Token = "0x4000161")]
		WAIT_TYPE_MAX
	}

	[Token(Token = "0x200004A")]
	public enum SubAvatarChange
	{
		[Token(Token = "0x4000163")]
		None = 0,
		[Token(Token = "0x4000164")]
		ResultLaundry = 1,
		[Token(Token = "0x4000165")]
		SummonExDeck = 2,
		[Token(Token = "0x4000166")]
		DamageBorder = 3,
		[Token(Token = "0x4000167")]
		OutgameOnly = 4,
		[Token(Token = "0x4000168")]
		MatchingOnly = 5,
		[Token(Token = "0x4000169")]
		DirectAttack = 6,
		[Token(Token = "0x400016A")]
		ChangeBattlePhaseOneSide = 7,
		[Token(Token = "0x400016B")]
		DuelResultSubAvatar = 8,
		[Token(Token = "0x400016C")]
		ChangeBattlePhase = 9,
		[Token(Token = "0x400016D")]
		UseEquipSpell = 10,
		[Token(Token = "0x400016E")]
		TurnEnd = 11,
		[Token(Token = "0x400016F")]
		SubAvatarChangeDebug = 999
	}

	[Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Character _003C_003E4__this;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string loadedPath;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isLoadingModel;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject preloadModel;

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass26_0()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x3EAE90", Offset = "0x3EA090", VA = "0x1803EAE90")]
		internal void _003CyInitializeAsync_003Eb__0(string completedPath)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct _003CPreHideAsync_003Ed__47 : IAsyncStateMachine
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Character _003C_003E4__this;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CancellationTokenSource _003Ccts_003E5__2;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x3E9740", Offset = "0x3E8940", VA = "0x1803E9740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x3E9D40", Offset = "0x3E8F40", VA = "0x1803E9D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class _003CyInitializeAsync_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Character _003C_003E4__this;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int avatarId;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public SubAvatarChange condition;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool enableSE;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool is2D;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool enbleWait;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _003CmodelId_003E5__2;

		[Token(Token = "0x17000018")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitializeAsync_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x3EB5C0", Offset = "0x3EA7C0", VA = "0x1803EB5C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x3EB880", Offset = "0x3EAA80", VA = "0x1803EB880", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject avatarModel;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MotionModel motion;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CharacterObjectControl characterObjectControl;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AvatarMotionSetting motionSetting;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool enableWaitInterval;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] waitInterval;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float[] waitTarget;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float tapInterval;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<Material> matList;

	[Token(Token = "0x4000149")]
	private const float wait2RandMin = 20f;

	[Token(Token = "0x400014A")]
	private const float wait2RandMax = 70f;

	[Token(Token = "0x400014B")]
	private const float wait3Interval = 90f;

	[Token(Token = "0x400014C")]
	private const float tapIntervalVal = 2f;

	[Token(Token = "0x400014D")]
	private const double preHideAsyncInterval = 100.0;

	[Token(Token = "0x400014E")]
	private const double preHideAsyncLimit = 10.0;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Coroutine m_InitializeRoutine;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Action tapCallback;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string CharacterPrefabPath;

	[Token(Token = "0x17000016")]
	public AvatarModelSetting ModelSetting
	{
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x3D7C10", Offset = "0x3D6E10", VA = "0x1803D7C10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000017")]
	public AvatarMotionSetting MotionSetting
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x3D7C20", Offset = "0x3D6E20", VA = "0x1803D7C20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x3D61E0", Offset = "0x3D53E0", VA = "0x1803D61E0")]
	public void InitializeAsync(int avatarId, bool enableSE = true, bool is2D = false, bool enbleWait = false, [Optional] Action onComplete, SubAvatarChange condition = SubAvatarChange.None)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x3D7CA0", Offset = "0x3D6EA0", VA = "0x1803D7CA0")]
	[IteratorStateMachine(typeof(_003CyInitializeAsync_003Ed__26))]
	private IEnumerator yInitializeAsync(int avatarId, bool enableSE = true, bool is2D = false, bool enbleWait = false, [Optional] Action onComplete, SubAvatarChange condition = SubAvatarChange.None)
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x3D6370", Offset = "0x3D5570", VA = "0x1803D6370")]
	public void Initialize(int modelId, bool enableSE = true, bool is2D = false, bool enbleWait = false, [Optional] GameObject preloadModel, SubAvatarChange condition = SubAvatarChange.None)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x3D62D0", Offset = "0x3D54D0", VA = "0x1803D62D0")]
	public void InitializeSelector()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x3D78D0", Offset = "0x3D6AD0", VA = "0x1803D78D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x3D7010", Offset = "0x3D6210", VA = "0x1803D7010")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x3D7AA0", Offset = "0x3D6CA0", VA = "0x1803D7AA0")]
	public void Wait3Reset()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x3D6090", Offset = "0x3D5290", VA = "0x1803D6090")]
	private string GetModelPath(int modelId)
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x3D60C0", Offset = "0x3D52C0", VA = "0x1803D60C0")]
	private string GetSubAvatarPath(int modelId)
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x3D6F60", Offset = "0x3D6160", VA = "0x1803D6F60")]
	private void ModelDestroy()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x3D77C0", Offset = "0x3D69C0", VA = "0x1803D77C0")]
	public void SetMotionSePan(float pan)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x3D77F0", Offset = "0x3D69F0", VA = "0x1803D77F0")]
	public void StopMotionSe(float fade = -1f)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x3D7730", Offset = "0x3D6930", VA = "0x1803D7730")]
	public void SetEnableSe(bool flg)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x3D71D0", Offset = "0x3D63D0", VA = "0x1803D71D0")]
	public void PlayMotion(AvatarMotionSetting.MotionID motionId)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x3D5FF0", Offset = "0x3D51F0", VA = "0x1803D5FF0")]
	public void ChangeSyncLayerWeight(float val)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x3D76B0", Offset = "0x3D68B0", VA = "0x1803D76B0")]
	public void SetDisableStateControlWeightChange(bool flg)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x3D60F0", Offset = "0x3D52F0", VA = "0x1803D60F0")]
	public bool HasMotion(AvatarMotionSetting.MotionID motionId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x3D7400", Offset = "0x3D6600", VA = "0x1803D7400")]
	public void PlayTapMotion()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x3D6E60", Offset = "0x3D6060", VA = "0x1803D6E60")]
	public bool IsTransitionCompleteLoopState()
	{
		return default(bool);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
	public void SetTapCallback(Action callback)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x3D7630", Offset = "0x3D6830", VA = "0x1803D7630")]
	public void ResetMotionPlaying()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x3D77B0", Offset = "0x3D69B0", VA = "0x1803D77B0")]
	public void SetEnableWaitInterval(bool flg)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x3D7560", Offset = "0x3D6760", VA = "0x1803D7560")]
	[AsyncStateMachine(typeof(_003CPreHideAsync_003Ed__47))]
	public Task PreHideAsync()
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x3D7B40", Offset = "0x3D6D40", VA = "0x1803D7B40")]
	public Character()
	{
	}
}
