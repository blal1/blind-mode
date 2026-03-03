using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Bg;

namespace YgomGame.Duel;

[Token(Token = "0x2001A2B")]
public class DuelGameObjectManager : MonoBehaviour
{
	[Token(Token = "0x2001A2C")]
	private enum Step
	{
		[Token(Token = "0x400F1DD")]
		PreLoading,
		[Token(Token = "0x400F1DE")]
		PreLoaded,
		[Token(Token = "0x400F1DF")]
		Preparing,
		[Token(Token = "0x400F1E0")]
		Idle,
		[Token(Token = "0x400F1E1")]
		Terminating
	}

	[Token(Token = "0x2001A2D")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x400F1E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool preloadFusionCard;

		[Token(Token = "0x400F1E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool preloadRitualCard;

		[Token(Token = "0x400F1E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool preloadSynchroCard;

		[Token(Token = "0x400F1E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool preloadXyzCard;

		[Token(Token = "0x400F1E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool preloadLinkCard;

		[Token(Token = "0x400F1E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool preloadSuperFusionCard;

		[Token(Token = "0x600A993")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x600A994")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CInitializeProcess_003Eb__0()
		{
		}

		[Token(Token = "0x600A995")]
		[Address(RVA = "0x4658A0", Offset = "0x464AA0", VA = "0x1804658A0")]
		internal void _003CInitializeProcess_003Eb__1()
		{
		}

		[Token(Token = "0x600A996")]
		[Address(RVA = "0xF74790", Offset = "0xF73990", VA = "0x180F74790")]
		internal void _003CInitializeProcess_003Eb__2()
		{
		}

		[Token(Token = "0x600A997")]
		[Address(RVA = "0xF747A0", Offset = "0xF739A0", VA = "0x180F747A0")]
		internal void _003CInitializeProcess_003Eb__3()
		{
		}

		[Token(Token = "0x600A998")]
		[Address(RVA = "0x4784A0", Offset = "0x4776A0", VA = "0x1804784A0")]
		internal void _003CInitializeProcess_003Eb__4()
		{
		}

		[Token(Token = "0x600A999")]
		[Address(RVA = "0xF747B0", Offset = "0xF739B0", VA = "0x180F747B0")]
		internal void _003CInitializeProcess_003Eb__5()
		{
		}
	}

	[Token(Token = "0x2001A2F")]
	[CompilerGenerated]
	private sealed class _003CInitializeProcess_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F1EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F1EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F1ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelGameObjectManager _003C_003E4__this;

		[Token(Token = "0x400F1EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		[Token(Token = "0x400F1EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject _003Croot_003E5__2;

		[Token(Token = "0x17001A2C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600A99F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001A2D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A9A1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A99C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitializeProcess_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600A99D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600A99E")]
		[Address(RVA = "0xF73770", Offset = "0xF72970", VA = "0x180F73770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A9A0")]
		[Address(RVA = "0xF74360", Offset = "0xF73560", VA = "0x180F74360", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001A30")]
	[CompilerGenerated]
	private sealed class _003CPrepareToDuelProcess_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F1F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F1F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F1F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelGameObjectManager _003C_003E4__this;

		[Token(Token = "0x17001A2E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600A9A5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001A2F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A9A7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A9A2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPrepareToDuelProcess_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600A9A3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600A9A4")]
		[Address(RVA = "0xF745F0", Offset = "0xF737F0", VA = "0x180F745F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A9A6")]
		[Address(RVA = "0xF74720", Offset = "0xF73920", VA = "0x180F74720", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400F1CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Step step;

	[Token(Token = "0x400F1CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<CardRoot> cardRoots;

	[Token(Token = "0x400F1CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool reqCardEffectFinishedCallback;

	[Token(Token = "0x400F1CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action onCardEffectFinished;

	[Token(Token = "0x17001A1C")]
	public bool isPreloading
	{
		[Token(Token = "0x600A956")]
		[Address(RVA = "0x5EA820", Offset = "0x5E9A20", VA = "0x1805EA820")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001A1D")]
	public bool isPreparing
	{
		[Token(Token = "0x600A957")]
		[Address(RVA = "0xF64630", Offset = "0xF63830", VA = "0x180F64630")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001A1E")]
	public RunEffectWorker effectWorker
	{
		[Token(Token = "0x600A95F")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A960")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001A1F")]
	public PopUpTextManager popUpTextManager
	{
		[Token(Token = "0x600A961")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A962")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001A20")]
	public bool isInitialized
	{
		[Token(Token = "0x600A963")]
		[Address(RVA = "0x3E1DE0", Offset = "0x3E0FE0", VA = "0x1803E1DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A964")]
		[Address(RVA = "0x3E1DF0", Offset = "0x3E0FF0", VA = "0x1803E1DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A21")]
	public bool isPreparedToDuel
	{
		[Token(Token = "0x600A968")]
		[Address(RVA = "0xF64620", Offset = "0xF63820", VA = "0x180F64620")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A969")]
		[Address(RVA = "0xF64670", Offset = "0xF63870", VA = "0x180F64670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A22")]
	private CardInstancePool cardInstancePool
	{
		[Token(Token = "0x600A96B")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A96A")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001A23")]
	public DuelEffectPool duelEffectPool
	{
		[Token(Token = "0x600A97C")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A97B")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001A24")]
	public DuelResourcePool duelResourcePool
	{
		[Token(Token = "0x600A97E")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A97D")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001A25")]
	public MainCameraOrganizer mainCamera
	{
		[Token(Token = "0x600A97F")]
		[Address(RVA = "0xF64660", Offset = "0xF63860", VA = "0x180F64660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A26")]
	public BgManager bg
	{
		[Token(Token = "0x600A981")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A980")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001A27")]
	public DuelFieldBase duelField
	{
		[Token(Token = "0x600A983")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A982")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001A28")]
	public FaceDownCardEffectPool faceDownCardEffectPool
	{
		[Token(Token = "0x600A985")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A984")]
		[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001A29")]
	public ActivePlayerFieldEffect activePlayerFieldEffect
	{
		[Token(Token = "0x600A987")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A986")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001A2A")]
	public DuelTimer3D duelTimer
	{
		[Token(Token = "0x600A989")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A988")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001A2B")]
	public bool isShownUp
	{
		[Token(Token = "0x600A98E")]
		[Address(RVA = "0xF64640", Offset = "0xF63840", VA = "0x180F64640")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A958")]
	[Address(RVA = "0xF62530", Offset = "0xF61730", VA = "0x180F62530")]
	public static DuelGameObjectManager Create()
	{
		return null;
	}

	[Token(Token = "0x600A959")]
	[Address(RVA = "0xF62B90", Offset = "0xF61D90", VA = "0x180F62B90")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600A95A")]
	[Address(RVA = "0xF62B20", Offset = "0xF61D20", VA = "0x180F62B20")]
	[IteratorStateMachine(typeof(_003CInitializeProcess_003Ed__11))]
	private IEnumerator InitializeProcess()
	{
		return null;
	}

	[Token(Token = "0x600A95B")]
	[Address(RVA = "0xF63500", Offset = "0xF62700", VA = "0x180F63500")]
	public void SetRunEffectWorker(RunEffectWorker worker)
	{
	}

	[Token(Token = "0x600A95C")]
	[Address(RVA = "0xF64510", Offset = "0xF63710", VA = "0x180F64510")]
	public static void WarningGameObjectExists(string path)
	{
	}

	[Token(Token = "0x600A95D")]
	[Address(RVA = "0xCED7C0", Offset = "0xCEC9C0", VA = "0x180CED7C0")]
	public static GameObject CreateGameObject(GameObject parent, string name, [Optional] Type[] components)
	{
		return null;
	}

	[Token(Token = "0x600A95E")]
	public static T CreateGameObject<T>(GameObject parent, string name, [Optional] Type[] components) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600A965")]
	[Address(RVA = "0xF63970", Offset = "0xF62B70", VA = "0x180F63970")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A966")]
	[Address(RVA = "0xF62F60", Offset = "0xF62160", VA = "0x180F62F60")]
	public void PrepareToDuel()
	{
	}

	[Token(Token = "0x600A967")]
	[Address(RVA = "0xF62EF0", Offset = "0xF620F0", VA = "0x180F62EF0")]
	[IteratorStateMachine(typeof(_003CPrepareToDuelProcess_003Ed__30))]
	private IEnumerator PrepareToDuelProcess()
	{
		return null;
	}

	[Token(Token = "0x600A96C")]
	[Address(RVA = "0xF63190", Offset = "0xF62390", VA = "0x180F63190")]
	public CardRoot RentCardInstance()
	{
		return null;
	}

	[Token(Token = "0x600A96D")]
	[Address(RVA = "0xF63450", Offset = "0xF62650", VA = "0x180F63450")]
	public void ReturnCardInstance(CardRoot cardRoot)
	{
	}

	[Token(Token = "0x600A96E")]
	[Address(RVA = "0xF626C0", Offset = "0xF618C0", VA = "0x180F626C0")]
	public CardRoot FindCardInstance(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x600A96F")]
	[Address(RVA = "0xF62790", Offset = "0xF61990", VA = "0x180F62790")]
	public CardRoot FindCardInstance(int player, int position, int index)
	{
		return null;
	}

	[Token(Token = "0x600A970")]
	[Address(RVA = "0xF62820", Offset = "0xF61A20", VA = "0x180F62820")]
	public CardRoot FindPlacedCardInstance(int player, int position, int index)
	{
		return null;
	}

	[Token(Token = "0x600A971")]
	[Address(RVA = "0xF62910", Offset = "0xF61B10", VA = "0x180F62910")]
	public List<CardRoot> FindPlacedCardsInstance(int player, int position, int excludeIndex = -1)
	{
		return null;
	}

	[Token(Token = "0x600A972")]
	[Address(RVA = "0xF632F0", Offset = "0xF624F0", VA = "0x180F632F0")]
	private void ReturnAllCards()
	{
	}

	[Token(Token = "0x600A973")]
	[Address(RVA = "0xF635C0", Offset = "0xF627C0", VA = "0x180F635C0")]
	private void SyncEngineCards()
	{
	}

	[Token(Token = "0x600A974")]
	[Address(RVA = "0xF63020", Offset = "0xF62220", VA = "0x180F63020")]
	public void RefreshFieldCard()
	{
	}

	[Token(Token = "0x600A975")]
	[Address(RVA = "0xF62C50", Offset = "0xF61E50", VA = "0x180F62C50")]
	public bool IsCardEffectPlaying([Optional] CardRoot excludeCard)
	{
		return default(bool);
	}

	[Token(Token = "0x600A976")]
	[Address(RVA = "0xF62CF0", Offset = "0xF61EF0", VA = "0x180F62CF0")]
	public bool IsCardEffectPlaying(Type type, [Optional] CardRoot excludeCard)
	{
		return default(bool);
	}

	[Token(Token = "0x600A977")]
	[Address(RVA = "0xF62E30", Offset = "0xF62030", VA = "0x180F62E30")]
	public bool IsZoneEffectPlaying(ZoneCard.Zone zone, ZoneCard.Mode mode, [Optional] CardRoot excludeCard)
	{
		return default(bool);
	}

	[Token(Token = "0x600A978")]
	[Address(RVA = "0xF62D90", Offset = "0xF61F90", VA = "0x180F62D90")]
	public bool IsMoveEffectRequested([Optional] CardRoot excludeCard)
	{
		return default(bool);
	}

	[Token(Token = "0x600A979")]
	[Address(RVA = "0xF62A60", Offset = "0xF61C60", VA = "0x180F62A60")]
	public CardRoot GetFieldCardAt(int index)
	{
		return null;
	}

	[Token(Token = "0x600A97A")]
	[Address(RVA = "0xF62AE0", Offset = "0xF61CE0", VA = "0x180F62AE0")]
	public int GetFieldCardNum()
	{
		return default(int);
	}

	[Token(Token = "0x600A98A")]
	[Address(RVA = "0x44E9B0", Offset = "0x44DBB0", VA = "0x18044E9B0")]
	public void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x600A98B")]
	[Address(RVA = "0xF635A0", Offset = "0xF627A0", VA = "0x180F635A0")]
	public void ShowDuelStartField(bool playEffect)
	{
	}

	[Token(Token = "0x600A98C")]
	[Address(RVA = "0xF62470", Offset = "0xF61670", VA = "0x180F62470")]
	private void CheckCardEffectPlaying()
	{
	}

	[Token(Token = "0x600A98D")]
	[Address(RVA = "0xF63240", Offset = "0xF62440", VA = "0x180F63240")]
	public void RequestActionOnPlayedCardEffect(Action action)
	{
	}

	[Token(Token = "0x600A98F")]
	[Address(RVA = "0xF64430", Offset = "0xF63630", VA = "0x180F64430")]
	private void Update()
	{
	}

	[Token(Token = "0x600A990")]
	[Address(RVA = "0xF62470", Offset = "0xF61670", VA = "0x180F62470")]
	private void IdleStep()
	{
	}

	[Token(Token = "0x600A991")]
	[Address(RVA = "0xF63F90", Offset = "0xF63190", VA = "0x180F63F90")]
	private void TerminatingStep()
	{
	}

	[Token(Token = "0x600A992")]
	[Address(RVA = "0xF645A0", Offset = "0xF637A0", VA = "0x180F645A0")]
	public DuelGameObjectManager()
	{
	}
}
