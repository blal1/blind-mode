using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001A1D")]
public abstract class DuelFieldBase : MonoBehaviour, IFieldPlacementInfo
{
	[Token(Token = "0x2001A1E")]
	private enum Step
	{
		[Token(Token = "0x400F18C")]
		WaitLoadPlayMat,
		[Token(Token = "0x400F18D")]
		Initializing,
		[Token(Token = "0x400F18E")]
		WaitPrepareToDuel,
		[Token(Token = "0x400F18F")]
		WaitPrepared,
		[Token(Token = "0x400F190")]
		FinishPrepare,
		[Token(Token = "0x400F191")]
		WaitShowUp,
		[Token(Token = "0x400F192")]
		ExecDuel,
		[Token(Token = "0x400F193")]
		Terminating,
		[Token(Token = "0x400F194")]
		Finish
	}

	[Token(Token = "0x2001A1F")]
	public class HalfField
	{
		[Token(Token = "0x400F195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterCardPlace[] monsterPlaces;

		[Token(Token = "0x400F196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MagicCardPlace[] magicPlaces;

		[Token(Token = "0x400F197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MagicCardPlace pendulumLPlace;

		[Token(Token = "0x400F198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MagicCardPlace pendulumRPlace;

		[Token(Token = "0x400F199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MagicCardPlace fieldPlace;

		[Token(Token = "0x400F19A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DeckCardPlace deckPlace;

		[Token(Token = "0x400F19B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DeckCardPlace extraPlace;

		[Token(Token = "0x400F19C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GraveCardPlace gravePlace;

		[Token(Token = "0x400F19D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GraveCardPlace excludePlace;

		[Token(Token = "0x600A91C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public HalfField()
		{
		}
	}

	[Token(Token = "0x2001A20")]
	public class SelectionItemContainer
	{
		[Token(Token = "0x400F19E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SharedDefinition.Location location;

		[Token(Token = "0x400F19F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int position;

		[Token(Token = "0x400F1A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<SelectionButton> item;

		[Token(Token = "0x600A91D")]
		[Address(RVA = "0xF5E840", Offset = "0xF5DA40", VA = "0x180F5E840")]
		public SelectionItemContainer()
		{
		}
	}

	[Token(Token = "0x2001A26")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass88_0
	{
		[Token(Token = "0x400F1B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int showUpNum;

		[Token(Token = "0x400F1B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action _003C_003E9__0;

		[Token(Token = "0x600A938")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass88_0()
		{
		}

		[Token(Token = "0x600A939")]
		[Address(RVA = "0x9C74A0", Offset = "0x9C66A0", VA = "0x1809C74A0")]
		internal void _003CShowUpCoroutine_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2001A27")]
	[CompilerGenerated]
	private sealed class _003CInitAllPlacesProcess_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F1B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F1B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F1B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelFieldBase _003C_003E4__this;

		[Token(Token = "0x400F1B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _003Cmyself_003E5__2;

		[Token(Token = "0x400F1B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _003Crival_003E5__3;

		[Token(Token = "0x400F1B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject _003Cground_003E5__4;

		[Token(Token = "0x400F1B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _003Ci_003E5__5;

		[Token(Token = "0x400F1B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private SharedDefinition.Location _003Cloc_003E5__6;

		[Token(Token = "0x400F1BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _003Cteam_003E5__7;

		[Token(Token = "0x400F1BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HalfField _003ChalfField_003E5__8;

		[Token(Token = "0x400F1BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _003Cj_003E5__9;

		[Token(Token = "0x17001A0F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600A93D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001A10")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A93F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A93A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitAllPlacesProcess_003Ed__101(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600A93B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600A93C")]
		[Address(RVA = "0xF5ECB0", Offset = "0xF5DEB0", VA = "0x180F5ECB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A93E")]
		[Address(RVA = "0xF5FEE0", Offset = "0xF5F0E0", VA = "0x180F5FEE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001A28")]
	[CompilerGenerated]
	private sealed class _003CShowUpCoroutine_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F1BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F1BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F1BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelFieldBase _003C_003E4__this;

		[Token(Token = "0x400F1C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool playEffect;

		[Token(Token = "0x400F1C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass88_0 _003C_003E8__1;

		[Token(Token = "0x17001A11")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600A943")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001A12")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A945")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A940")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CShowUpCoroutine_003Ed__88(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600A941")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600A942")]
		[Address(RVA = "0xF60270", Offset = "0xF5F470", VA = "0x180F60270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A944")]
		[Address(RVA = "0xF60990", Offset = "0xF5FB90", VA = "0x180F60990", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400F174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Step step;

	[Token(Token = "0x400F175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool initCardPlaces;

	[Token(Token = "0x400F176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<TargetingLine> affectLinkLines;

	[Token(Token = "0x400F177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<CardPlace> affectCardPlaces;

	[Token(Token = "0x400F178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject nearMdl;

	[Token(Token = "0x400F179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject farMdl;

	[Token(Token = "0x400F17A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool highlightAvailable;

	[Token(Token = "0x400F17B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Dictionary<int, HalfField> halfFields;

	[Token(Token = "0x400F17C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected NearHandCardPlace nearHandPlace;

	[Token(Token = "0x400F17D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected FarHandCardPlace farHandPlace;

	[Token(Token = "0x400F17E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<SelectionItemContainer> selectionItemList;

	[Token(Token = "0x400F17F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Selector selector;

	[Token(Token = "0x400F180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Coroutine initAllPlaceCoroutine;

	[Token(Token = "0x400F181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Coroutine showUpCoroutine;

	[Token(Token = "0x400F184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool loadNearMat;

	[Token(Token = "0x400F185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	private bool loadFarMat;

	[Token(Token = "0x400F18A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
	private bool dragging;

	[Token(Token = "0x17001A00")]
	protected abstract string nearMatResourcePath
	{
		[Token(Token = "0x600A8C9")]
		get;
	}

	[Token(Token = "0x17001A01")]
	protected abstract string farMatResourcePath
	{
		[Token(Token = "0x600A8CA")]
		get;
	}

	[Token(Token = "0x17001A02")]
	protected abstract Vector3 matSize
	{
		[Token(Token = "0x600A8D0")]
		get;
	}

	[Token(Token = "0x17001A03")]
	public abstract int numMonsterPlaces
	{
		[Token(Token = "0x600A8D5")]
		get;
	}

	[Token(Token = "0x17001A04")]
	public abstract int numMagicPlaces
	{
		[Token(Token = "0x600A8D6")]
		get;
	}

	[Token(Token = "0x17001A05")]
	public abstract int monsterStartIdx
	{
		[Token(Token = "0x600A8D7")]
		get;
	}

	[Token(Token = "0x17001A06")]
	public abstract int monsterEndIdx
	{
		[Token(Token = "0x600A8D8")]
		get;
	}

	[Token(Token = "0x17001A07")]
	public abstract int magicStartIdx
	{
		[Token(Token = "0x600A8D9")]
		get;
	}

	[Token(Token = "0x17001A08")]
	public abstract int magicEndIdx
	{
		[Token(Token = "0x600A8DA")]
		get;
	}

	[Token(Token = "0x17001A09")]
	public DuelGameObjectManager goManager
	{
		[Token(Token = "0x600A8DC")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A8DD")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A0A")]
	public List<CardPlace> cardPlaces
	{
		[Token(Token = "0x600A8DE")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A8DF")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001A0B")]
	public bool isInitialized
	{
		[Token(Token = "0x600A8E1")]
		[Address(RVA = "0xF5D300", Offset = "0xF5C500", VA = "0x180F5D300")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A8E2")]
		[Address(RVA = "0xF5D320", Offset = "0xF5C520", VA = "0x180F5D320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A0C")]
	public bool isTerminated
	{
		[Token(Token = "0x600A8E4")]
		[Address(RVA = "0xF5D310", Offset = "0xF5C510", VA = "0x180F5D310")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A8E5")]
		[Address(RVA = "0xF5D330", Offset = "0xF5C530", VA = "0x180F5D330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A0D")]
	public bool isPrepared
	{
		[Token(Token = "0x600A8E7")]
		[Address(RVA = "0x4ACC50", Offset = "0x4ABE50", VA = "0x1804ACC50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A8E8")]
		[Address(RVA = "0x95B260", Offset = "0x95A460", VA = "0x18095B260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A0E")]
	public bool isShownUp
	{
		[Token(Token = "0x600A8FC")]
		[Address(RVA = "0x95B250", Offset = "0x95A450", VA = "0x18095B250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A8FD")]
		[Address(RVA = "0x95B270", Offset = "0x95A470", VA = "0x18095B270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A8CB")]
	protected abstract void AssignAll(SharedDefinition.Location loc, GameObject parent);

	[Token(Token = "0x600A8CC")]
	protected abstract GameObject GetFrame(SharedDefinition.Location loc, int position);

	[Token(Token = "0x600A8CD")]
	protected abstract List<GameObject> GetFrames(SharedDefinition.Location loc);

	[Token(Token = "0x600A8CE")]
	protected abstract GameObject GetPlayMat(SharedDefinition.Location loc);

	[Token(Token = "0x600A8CF")]
	protected abstract MeshRenderer GetPlayMatRenderer(SharedDefinition.Location loc);

	[Token(Token = "0x600A8D1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "18")]
	public virtual void OnUpdate()
	{
	}

	[Token(Token = "0x600A8D2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "19")]
	public virtual void OnTerminate()
	{
	}

	[Token(Token = "0x600A8D3")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "20")]
	public virtual bool UpdateInitialize()
	{
		return default(bool);
	}

	[Token(Token = "0x600A8D4")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "21")]
	public virtual bool UpdateTerminate()
	{
		return default(bool);
	}

	[Token(Token = "0x600A8DB")]
	public static T Create<T>(DuelGameObjectManager goManager, GameObject root, string name) where T : DuelFieldBase
	{
		return null;
	}

	[Token(Token = "0x600A8E0")]
	[Address(RVA = "0xF5AD00", Offset = "0xF59F00", VA = "0x180F5AD00")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x600A8E3")]
	[Address(RVA = "0xF5C0C0", Offset = "0xF5B2C0", VA = "0x180F5C0C0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A8E6")]
	[Address(RVA = "0xF5B220", Offset = "0xF5A420", VA = "0x180F5B220")]
	public void PrepareToDuel()
	{
	}

	[Token(Token = "0x600A8E9")]
	[Address(RVA = "0xF5AAB0", Offset = "0xF59CB0", VA = "0x180F5AAB0")]
	public void Inactivate()
	{
	}

	[Token(Token = "0x600A8EA")]
	[Address(RVA = "0xF592B0", Offset = "0xF584B0", VA = "0x180F592B0")]
	public CardPlace GetCardPlace(int team, int position)
	{
		return null;
	}

	[Token(Token = "0x600A8EB")]
	[Address(RVA = "0xF59260", Offset = "0xF58460", VA = "0x180F59260")]
	public CardLocator GetCardLocator(int team, int position, int index)
	{
		return null;
	}

	[Token(Token = "0x600A8EC")]
	[Address(RVA = "0xF5A080", Offset = "0xF59280", VA = "0x180F5A080")]
	public bool GetPosture(int team, int position, int index, out Vector3 pos, out Quaternion rot)
	{
		return default(bool);
	}

	[Token(Token = "0x600A8ED")]
	[Address(RVA = "0xF59D10", Offset = "0xF58F10", VA = "0x180F59D10")]
	public MonsterCardPlace[] GetMonsterPlaces(int team)
	{
		return null;
	}

	[Token(Token = "0x600A8EE")]
	[Address(RVA = "0xF59CB0", Offset = "0xF58EB0", VA = "0x180F59CB0")]
	public MagicCardPlace[] GetMagicPlaces(int team)
	{
		return null;
	}

	[Token(Token = "0x600A8EF")]
	[Address(RVA = "0xF59880", Offset = "0xF58A80", VA = "0x180F59880")]
	private DeckCardPlace[] GetDeckPlaces(int team)
	{
		return null;
	}

	[Token(Token = "0x600A8F0")]
	[Address(RVA = "0xF59A10", Offset = "0xF58C10", VA = "0x180F59A10")]
	private GraveCardPlace[] GetGravePlaces(int team)
	{
		return null;
	}

	[Token(Token = "0x600A8F1")]
	[Address(RVA = "0xF5A690", Offset = "0xF59890", VA = "0x180F5A690")]
	public CardPlace[] GetSwitchablePlaces(int team)
	{
		return null;
	}

	[Token(Token = "0x600A8F2")]
	[Address(RVA = "0xF59BA0", Offset = "0xF58DA0", VA = "0x180F59BA0")]
	public Vector3 GetHandCardPosition(int index, int numCards, SharedDefinition.Location location)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A8F3")]
	[Address(RVA = "0xF59C20", Offset = "0xF58E20", VA = "0x180F59C20")]
	public Quaternion GetHandCardRotation(SharedDefinition.Location location)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600A8F4")]
	[Address(RVA = "0xF5A880", Offset = "0xF59A80", VA = "0x180F5A880")]
	public void HighlightIfAvailable(bool available, uint cmdBit, Action onFinished)
	{
	}

	[Token(Token = "0x600A8F5")]
	[Address(RVA = "0xF5C920", Offset = "0xF5BB20", VA = "0x180F5C920")]
	public void UpdateHighlightEffect()
	{
	}

	[Token(Token = "0x600A8F6")]
	[Address(RVA = "0xF5C950", Offset = "0xF5BB50", VA = "0x180F5C950")]
	public void UpdateState(Action onFinished)
	{
	}

	[Token(Token = "0x600A8F7")]
	[Address(RVA = "0xF5B490", Offset = "0xF5A690", VA = "0x180F5B490")]
	public void ReqAffectEffect(int team, int position)
	{
	}

	[Token(Token = "0x600A8F8")]
	[Address(RVA = "0xF58210", Offset = "0xF57410", VA = "0x180F58210")]
	public void ClearAffectEffect()
	{
	}

	[Token(Token = "0x600A8F9")]
	[Address(RVA = "0xF5B0E0", Offset = "0xF5A2E0", VA = "0x180F5B0E0")]
	public bool IsAffectCardPlace(int player, int position)
	{
		return default(bool);
	}

	[Token(Token = "0x600A8FA")]
	[Address(RVA = "0xF5C020", Offset = "0xF5B220", VA = "0x180F5C020")]
	public void ShowUpOnStartDuel(bool playEffect)
	{
	}

	[Token(Token = "0x600A8FB")]
	[Address(RVA = "0xF5BFA0", Offset = "0xF5B1A0", VA = "0x180F5BFA0")]
	[IteratorStateMachine(typeof(_003CShowUpCoroutine_003Ed__88))]
	private IEnumerator ShowUpCoroutine(bool playEffect)
	{
		return null;
	}

	[Token(Token = "0x600A8FE")]
	[Address(RVA = "0xF5CB60", Offset = "0xF5BD60", VA = "0x180F5CB60")]
	private void Update()
	{
	}

	[Token(Token = "0x600A8FF")]
	[Address(RVA = "0xF5CBF0", Offset = "0xF5BDF0", VA = "0x180F5CBF0")]
	private void WaitLoadPlayMatStep()
	{
	}

	[Token(Token = "0x600A900")]
	[Address(RVA = "0xF5AF40", Offset = "0xF5A140", VA = "0x180F5AF40")]
	private void InitializingStep()
	{
	}

	[Token(Token = "0x600A901")]
	[Address(RVA = "0xF5D030", Offset = "0xF5C230", VA = "0x180F5D030")]
	private void WaitPreparedStep()
	{
	}

	[Token(Token = "0x600A902")]
	[Address(RVA = "0xF59010", Offset = "0xF58210", VA = "0x180F59010")]
	private void ExecDuelStep()
	{
	}

	[Token(Token = "0x600A903")]
	[Address(RVA = "0xF5C5C0", Offset = "0xF5B7C0", VA = "0x180F5C5C0")]
	private void TerminatingStep()
	{
	}

	[Token(Token = "0x600A904")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void FinishStep()
	{
	}

	[Token(Token = "0x600A905")]
	[Address(RVA = "0xF5AC70", Offset = "0xF59E70", VA = "0x180F5AC70")]
	private void InitAllPlaces()
	{
	}

	[Token(Token = "0x600A906")]
	[Address(RVA = "0xF5AC00", Offset = "0xF59E00", VA = "0x180F5AC00")]
	[IteratorStateMachine(typeof(_003CInitAllPlacesProcess_003Ed__101))]
	private IEnumerator InitAllPlacesProcess()
	{
		return null;
	}

	[Token(Token = "0x600A907")]
	[Address(RVA = "0xF57C90", Offset = "0xF56E90", VA = "0x180F57C90")]
	public bool AnchorNameToPosition(string name, out int player, out int position)
	{
		return default(bool);
	}

	[Token(Token = "0x600A908")]
	[Address(RVA = "0xF584A0", Offset = "0xF576A0", VA = "0x180F584A0")]
	private GameObject CreateAnchor(SharedDefinition.Location loc, int position)
	{
		return null;
	}

	[Token(Token = "0x600A909")]
	[Address(RVA = "0xF57BB0", Offset = "0xF56DB0", VA = "0x180F57BB0")]
	public void AddSelectionItem(SharedDefinition.Location location, int position, SelectionButton item)
	{
	}

	[Token(Token = "0x600A90A")]
	[Address(RVA = "0xF5B340", Offset = "0xF5A540", VA = "0x180F5B340")]
	public void RemoveSelectionItem(SharedDefinition.Location location, int position, SelectionButton item)
	{
	}

	[Token(Token = "0x600A90B")]
	[Address(RVA = "0xF5B3F0", Offset = "0xF5A5F0", VA = "0x180F5B3F0")]
	public void RemoveSelectionItem(SharedDefinition.Location location, int position, int index)
	{
	}

	[Token(Token = "0x600A90C")]
	[Address(RVA = "0xF5A520", Offset = "0xF59720", VA = "0x180F5A520")]
	public SelectionButton GetSelectionItem(SharedDefinition.Location location, int position, int index)
	{
		return null;
	}

	[Token(Token = "0x600A90D")]
	[Address(RVA = "0xF5A5C0", Offset = "0xF597C0", VA = "0x180F5A5C0")]
	public SelectionButton GetSelectionItem(int player, int position, int index)
	{
		return null;
	}

	[Token(Token = "0x600A90E")]
	[Address(RVA = "0xF5A410", Offset = "0xF59610", VA = "0x180F5A410")]
	public SelectionButton GetSelectionItem(Vector2 screenPoint)
	{
		return null;
	}

	[Token(Token = "0x600A90F")]
	[Address(RVA = "0xF594E0", Offset = "0xF586E0", VA = "0x180F594E0")]
	public SelectionButton GetClosestSelectionButton(Vector2 position, Vector2 normalized_direction, float angleDot, [Optional] SelectionItem ignore_item)
	{
		return null;
	}

	[Token(Token = "0x600A910")]
	[Address(RVA = "0xF5A240", Offset = "0xF59440", VA = "0x180F5A240")]
	public SelectionItemContainer GetSelectionItemContainer(SharedDefinition.Location location, int position)
	{
		return null;
	}

	[Token(Token = "0x600A911")]
	[Address(RVA = "0xF59D70", Offset = "0xF58F70", VA = "0x180F59D70")]
	public (SharedDefinition.Location, int, int) GetPosition(SelectionItem item)
	{
		return default((SharedDefinition.Location, int, int));
	}

	[Token(Token = "0x600A912")]
	[Address(RVA = "0xF59FB0", Offset = "0xF591B0", VA = "0x180F59FB0")]
	public (SharedDefinition.Location, int, int) GetPosition(Vector2 screen_point)
	{
		return default((SharedDefinition.Location, int, int));
	}

	[Token(Token = "0x600A913")]
	[Address(RVA = "0xF5BB10", Offset = "0xF5AD10", VA = "0x180F5BB10")]
	private void SetupSelectionItemTransition()
	{
	}

	[Token(Token = "0x600A914")]
	[Address(RVA = "0xF5BCF0", Offset = "0xF5AEF0", VA = "0x180F5BCF0")]
	private void SetupSelectionItemTransition(SelectionButton item, PadInputDirection direction, SharedDefinition.Location transitionLocation, int transitionPosition)
	{
	}

	[Token(Token = "0x600A915")]
	[Address(RVA = "0xF5B990", Offset = "0xF5AB90", VA = "0x180F5B990")]
	public bool SelectItem(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600A916")]
	[Address(RVA = "0xF5D240", Offset = "0xF5C440", VA = "0x180F5D240")]
	protected DuelFieldBase()
	{
	}
}
