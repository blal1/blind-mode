using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x20019BD")]
public class CardRoot : MonoBehaviour, ICardStatusIconAnchor
{
	[Token(Token = "0x20019BE")]
	public enum State
	{
		[Token(Token = "0x400EE23")]
		Invalid,
		[Token(Token = "0x400EE24")]
		Suspend,
		[Token(Token = "0x400EE25")]
		Ready,
		[Token(Token = "0x400EE26")]
		Active
	}

	[Token(Token = "0x20019BF")]
	public enum ModelType
	{
		[Token(Token = "0x400EE28")]
		StoneMonster = 1,
		[Token(Token = "0x400EE29")]
		StoneMagic = 4,
		[Token(Token = "0x400EE2A")]
		OcgCard = 8,
		[Token(Token = "0x400EE2B")]
		Soul = 0x10,
		[Token(Token = "0x400EE2C")]
		SummonMaterial = 0x20
	}

	[Token(Token = "0x20019C0")]
	private enum Step
	{
		[Token(Token = "0x400EE2E")]
		Idle,
		[Token(Token = "0x400EE2F")]
		Move,
		[Token(Token = "0x400EE30")]
		Summon
	}

	[Token(Token = "0x400EDE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Step step;

	[Token(Token = "0x400EDE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ElementObjectManager eoManager;

	[Token(Token = "0x400EDE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Queue<CardEffectBase> effectQueue;

	[Token(Token = "0x400EDEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CardEffectBase currentEffect;

	[Token(Token = "0x400EDEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool attackReady;

	[Token(Token = "0x400EDEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool validVal;

	[Token(Token = "0x400EDF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject iconCommonCounter;

	[Token(Token = "0x400EDF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ExtendedTextMeshProUGUI textCommonCounter;

	[Token(Token = "0x400EDF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int position;

	[Token(Token = "0x400EE01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool m_AtkBuffFlag;

	[Token(Token = "0x400EE02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
	private bool m_AtkDebuffFlag;

	[Token(Token = "0x400EE03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
	private bool m_DefBuffFlag;

	[Token(Token = "0x400EE04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB3")]
	private bool m_DefDebuffFlag;

	[Token(Token = "0x400EE05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private int m_Atk;

	[Token(Token = "0x400EE06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int m_Def;

	[Token(Token = "0x400EE09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int m_Level;

	[Token(Token = "0x400EE0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private int m_Rank;

	[Token(Token = "0x400EE0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private int m_Scale;

	[Token(Token = "0x400EE0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private int m_CardAttr;

	[Token(Token = "0x400EE11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int m_CardElement;

	[Token(Token = "0x400EE14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public int m_CardType;

	[Token(Token = "0x400EE1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject _cardEffectRoot;

	[Token(Token = "0x400EE1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private DuelEffectHandle effectBuff;

	[Token(Token = "0x400EE20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private DuelEffectHandle effectDebuff;

	[Token(Token = "0x400EE21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private DuelEffectHandle effectChange;

	[Token(Token = "0x17001957")]
	public SharedDefinition.SummonMaterialType currentSummonMaterialType
	{
		[Token(Token = "0x600A582")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
		[CompilerGenerated]
		get
		{
			return default(SharedDefinition.SummonMaterialType);
		}
		[Token(Token = "0x600A583")]
		[Address(RVA = "0x409CD0", Offset = "0x408ED0", VA = "0x180409CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001958")]
	public SharedDefinition.SummonMaterialType preparedSummonMaterialEffectType
	{
		[Token(Token = "0x600A584")]
		[Address(RVA = "0x5FA7A0", Offset = "0x5F99A0", VA = "0x1805FA7A0")]
		[CompilerGenerated]
		get
		{
			return default(SharedDefinition.SummonMaterialType);
		}
		[Token(Token = "0x600A585")]
		[Address(RVA = "0x86B170", Offset = "0x86A370", VA = "0x18086B170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001959")]
	public Dictionary<string, SimpleEffect> holdEffects
	{
		[Token(Token = "0x600A586")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A587")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700195A")]
	public bool isTerminated
	{
		[Token(Token = "0x600A58D")]
		[Address(RVA = "0xF21B50", Offset = "0xF20D50", VA = "0x180F21B50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700195B")]
	public bool isInMonsterZone
	{
		[Token(Token = "0x600A58E")]
		[Address(RVA = "0xF21B00", Offset = "0xF20D00", VA = "0x180F21B00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700195C")]
	public bool isInMagicZoon
	{
		[Token(Token = "0x600A58F")]
		[Address(RVA = "0xF21AF0", Offset = "0xF20CF0", VA = "0x180F21AF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700195D")]
	public bool isLoaded
	{
		[Token(Token = "0x600A597")]
		[Address(RVA = "0xF21B10", Offset = "0xF20D10", VA = "0x180F21B10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700195E")]
	public CardInstancePool cardPool
	{
		[Token(Token = "0x600A598")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A599")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700195F")]
	public CardLocator cardLocator
	{
		[Token(Token = "0x600A59A")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A59B")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001960")]
	public CardPlane cardPlane
	{
		[Token(Token = "0x600A59C")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A59D")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001961")]
	public CardStatus cardStatus
	{
		[Token(Token = "0x600A59E")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A59F")]
		[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001962")]
	public State state
	{
		[Token(Token = "0x600A5A0")]
		[Address(RVA = "0x865350", Offset = "0x864550", VA = "0x180865350")]
		[CompilerGenerated]
		get
		{
			return default(State);
		}
		[Token(Token = "0x600A5A1")]
		[Address(RVA = "0x8653A0", Offset = "0x8645A0", VA = "0x1808653A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001963")]
	public Transform cardPostureTransform
	{
		[Token(Token = "0x600A5A2")]
		[Address(RVA = "0xF21A00", Offset = "0xF20C00", VA = "0x180F21A00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001964")]
	public bool manualUpdateSRT
	{
		[Token(Token = "0x600A5AA")]
		[Address(RVA = "0xF21C70", Offset = "0xF20E70", VA = "0x180F21C70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A5AB")]
		[Address(RVA = "0xF220D0", Offset = "0xF212D0", VA = "0x180F220D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001965")]
	public GameObject effectAnchor
	{
		[Token(Token = "0x600A5D0")]
		[Address(RVA = "0xF21AB0", Offset = "0xF20CB0", VA = "0x180F21AB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001966")]
	public Quaternion localRot
	{
		[Token(Token = "0x600A5D1")]
		[Address(RVA = "0xF21C20", Offset = "0xF20E20", VA = "0x180F21C20", Slot = "5")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x17001967")]
	public Vector3 centerOfs
	{
		[Token(Token = "0x600A5D2")]
		[Address(RVA = "0xF21A20", Offset = "0xF20C20", VA = "0x180F21A20", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17001968")]
	public Vector3 surfaceOffset
	{
		[Token(Token = "0x600A5D3")]
		[Address(RVA = "0xF21CA0", Offset = "0xF20EA0", VA = "0x180F21CA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17001969")]
	public Vector3 affectIconOffset
	{
		[Token(Token = "0x600A5D4")]
		[Address(RVA = "0xF217D0", Offset = "0xF209D0", VA = "0x180F217D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700196A")]
	public Vector3 atkDefOfs
	{
		[Token(Token = "0x600A5D5")]
		[Address(RVA = "0xF21850", Offset = "0xF20A50", VA = "0x180F21850", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700196B")]
	public Vector3 levelOfs
	{
		[Token(Token = "0x600A5D6")]
		[Address(RVA = "0xF21BA0", Offset = "0xF20DA0", VA = "0x180F21BA0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700196C")]
	public Vector3 attrOfs
	{
		[Token(Token = "0x600A5D7")]
		[Address(RVA = "0xF218C0", Offset = "0xF20AC0", VA = "0x180F218C0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700196D")]
	public Vector3 typeOfs
	{
		[Token(Token = "0x600A5D8")]
		[Address(RVA = "0xF21D90", Offset = "0xF20F90", VA = "0x180F21D90", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700196E")]
	public Vector3 counterOfs
	{
		[Token(Token = "0x600A5D9")]
		[Address(RVA = "0xF21A30", Offset = "0xF20C30", VA = "0x180F21A30", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700196F")]
	public Vector3 turnsOfs
	{
		[Token(Token = "0x600A5DA")]
		[Address(RVA = "0xF21D10", Offset = "0xF20F10", VA = "0x180F21D10", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17001970")]
	public int team
	{
		[Token(Token = "0x600A5E9")]
		[Address(RVA = "0x6ABCD0", Offset = "0x6AAED0", VA = "0x1806ABCD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A5EA")]
		[Address(RVA = "0x6AC1E0", Offset = "0x6AB3E0", VA = "0x1806AC1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001971")]
	public int index
	{
		[Token(Token = "0x600A5EB")]
		[Address(RVA = "0x3DDD20", Offset = "0x3DCF20", VA = "0x1803DDD20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A5EC")]
		[Address(RVA = "0x62DFF0", Offset = "0x62D1F0", VA = "0x18062DFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001972")]
	public int cardId
	{
		[Token(Token = "0x600A5EF")]
		[Address(RVA = "0x588970", Offset = "0x587B70", VA = "0x180588970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A5EE")]
		[Address(RVA = "0xE55710", Offset = "0xE54910", VA = "0x180E55710")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001973")]
	public int sleeveId
	{
		[Token(Token = "0x600A5F1")]
		[Address(RVA = "0x662060", Offset = "0x661260", VA = "0x180662060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A5F0")]
		[Address(RVA = "0xCBCFE0", Offset = "0xCBC1E0", VA = "0x180CBCFE0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001974")]
	public bool isFace
	{
		[Token(Token = "0x600A5F3")]
		[Address(RVA = "0x6621A0", Offset = "0x6613A0", VA = "0x1806621A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A5F2")]
		[Address(RVA = "0xF22050", Offset = "0xF21250", VA = "0x180F22050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001975")]
	public bool isAttack
	{
		[Token(Token = "0x600A5F5")]
		[Address(RVA = "0xF21AE0", Offset = "0xF20CE0", VA = "0x180F21AE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A5F4")]
		[Address(RVA = "0xF22040", Offset = "0xF21240", VA = "0x180F22040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001976")]
	public int uniqueId
	{
		[Token(Token = "0x600A5F6")]
		[Address(RVA = "0x42D5E0", Offset = "0x42C7E0", VA = "0x18042D5E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A5F7")]
		[Address(RVA = "0x42D690", Offset = "0x42C890", VA = "0x18042D690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001977")]
	public int styleId
	{
		[Token(Token = "0x600A5F8")]
		[Address(RVA = "0x42D5F0", Offset = "0x42C7F0", VA = "0x18042D5F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A5F9")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C8A0", VA = "0x18042D6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001978")]
	public int atk
	{
		[Token(Token = "0x600A5FA")]
		[Address(RVA = "0x42D600", Offset = "0x42C800", VA = "0x18042D600")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A5FB")]
		[Address(RVA = "0xF21E10", Offset = "0xF21010", VA = "0x180F21E10")]
		private set
		{
		}
	}

	[Token(Token = "0x17001979")]
	public int def
	{
		[Token(Token = "0x600A5FC")]
		[Address(RVA = "0x667EF0", Offset = "0x6670F0", VA = "0x180667EF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A5FD")]
		[Address(RVA = "0xF21F50", Offset = "0xF21150", VA = "0x180F21F50")]
		private set
		{
		}
	}

	[Token(Token = "0x1700197A")]
	public int orgAtk
	{
		[Token(Token = "0x600A5FE")]
		[Address(RVA = "0x667F00", Offset = "0x667100", VA = "0x180667F00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A5FF")]
		[Address(RVA = "0x668100", Offset = "0x667300", VA = "0x180668100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700197B")]
	public int orgDef
	{
		[Token(Token = "0x600A600")]
		[Address(RVA = "0xAA4ED0", Offset = "0xAA40D0", VA = "0x180AA4ED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A601")]
		[Address(RVA = "0xAA4930", Offset = "0xAA3B30", VA = "0x180AA4930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700197C")]
	public int level
	{
		[Token(Token = "0x600A602")]
		[Address(RVA = "0xF21C10", Offset = "0xF20E10", VA = "0x180F21C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A603")]
		[Address(RVA = "0xF22060", Offset = "0xF21260", VA = "0x180F22060")]
		private set
		{
		}
	}

	[Token(Token = "0x1700197D")]
	public int rank
	{
		[Token(Token = "0x600A604")]
		[Address(RVA = "0xF21C80", Offset = "0xF20E80", VA = "0x180F21C80")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A605")]
		[Address(RVA = "0xF220E0", Offset = "0xF212E0", VA = "0x180F220E0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700197E")]
	public int scale
	{
		[Token(Token = "0x600A606")]
		[Address(RVA = "0xF21C90", Offset = "0xF20E90", VA = "0x180F21C90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A607")]
		[Address(RVA = "0xF22150", Offset = "0xF21350", VA = "0x180F22150")]
		private set
		{
		}
	}

	[Token(Token = "0x1700197F")]
	public int orgScale
	{
		[Token(Token = "0x600A608")]
		[Address(RVA = "0x6D4620", Offset = "0x6D3820", VA = "0x1806D4620")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A609")]
		[Address(RVA = "0x6D7640", Offset = "0x6D6840", VA = "0x1806D7640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001980")]
	public int orgLevel
	{
		[Token(Token = "0x600A60A")]
		[Address(RVA = "0x6D4630", Offset = "0x6D3830", VA = "0x1806D4630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A60B")]
		[Address(RVA = "0x6D7650", Offset = "0x6D6850", VA = "0x1806D7650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001981")]
	public int orgRank
	{
		[Token(Token = "0x600A60C")]
		[Address(RVA = "0x4226F0", Offset = "0x4218F0", VA = "0x1804226F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A60D")]
		[Address(RVA = "0x422700", Offset = "0x421900", VA = "0x180422700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001982")]
	public int cardAttr
	{
		[Token(Token = "0x600A60E")]
		[Address(RVA = "0xA2A110", Offset = "0xA29310", VA = "0x180A2A110")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A60F")]
		[Address(RVA = "0xF21E80", Offset = "0xF21080", VA = "0x180F21E80")]
		private set
		{
		}
	}

	[Token(Token = "0x17001983")]
	public int orgAttr
	{
		[Token(Token = "0x600A610")]
		[Address(RVA = "0x746560", Offset = "0x745760", VA = "0x180746560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A611")]
		[Address(RVA = "0xA2A4F0", Offset = "0xA296F0", VA = "0x180A2A4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001984")]
	public int cardElement
	{
		[Token(Token = "0x600A612")]
		[Address(RVA = "0xA2A0E0", Offset = "0xA292E0", VA = "0x180A2A0E0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A613")]
		[Address(RVA = "0xA2A530", Offset = "0xA29730", VA = "0x180A2A530")]
		private set
		{
		}
	}

	[Token(Token = "0x17001985")]
	public List<int> attrList
	{
		[Token(Token = "0x600A614")]
		[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A615")]
		[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001986")]
	public bool cardAttrChanged
	{
		[Token(Token = "0x600A616")]
		[Address(RVA = "0xDCD750", Offset = "0xDCC950", VA = "0x180DCD750")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A617")]
		[Address(RVA = "0xEE1700", Offset = "0xEE0900", VA = "0x180EE1700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001987")]
	public int cardType
	{
		[Token(Token = "0x600A618")]
		[Address(RVA = "0xA2A0B0", Offset = "0xA292B0", VA = "0x180A2A0B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A619")]
		[Address(RVA = "0xF21EF0", Offset = "0xF210F0", VA = "0x180F21EF0")]
		private set
		{
		}
	}

	[Token(Token = "0x17001988")]
	public bool cardTypeChanged
	{
		[Token(Token = "0x600A61A")]
		[Address(RVA = "0x49B790", Offset = "0x49A990", VA = "0x18049B790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A61B")]
		[Address(RVA = "0x49C010", Offset = "0x49B210", VA = "0x18049C010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001989")]
	public int validCounter
	{
		[Token(Token = "0x600A61C")]
		[Address(RVA = "0xA2A080", Offset = "0xA29280", VA = "0x180A2A080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A61D")]
		[Address(RVA = "0xA2A4E0", Offset = "0xA296E0", VA = "0x180A2A4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700198A")]
	public int validCounterCount
	{
		[Token(Token = "0x600A61E")]
		[Address(RVA = "0x3F4B30", Offset = "0x3F3D30", VA = "0x1803F4B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A61F")]
		[Address(RVA = "0x3F4B40", Offset = "0x3F3D40", VA = "0x1803F4B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700198B")]
	public List<Engine.CounterType> validCounters
	{
		[Token(Token = "0x600A620")]
		[Address(RVA = "0x5FC5F0", Offset = "0x5FB7F0", VA = "0x1805FC5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A621")]
		[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700198C")]
	public List<int> validCountersCount
	{
		[Token(Token = "0x600A622")]
		[Address(RVA = "0x3DA790", Offset = "0x3D9990", VA = "0x1803DA790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A623")]
		[Address(RVA = "0x3DA7A0", Offset = "0x3D99A0", VA = "0x1803DA7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700198D")]
	public int elapsedTurns
	{
		[Token(Token = "0x600A624")]
		[Address(RVA = "0x49BF20", Offset = "0x49B120", VA = "0x18049BF20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A625")]
		[Address(RVA = "0x49C660", Offset = "0x49B860", VA = "0x18049C660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700198E")]
	public bool cardDisabled
	{
		[Token(Token = "0x600A626")]
		[Address(RVA = "0xF21940", Offset = "0xF20B40", VA = "0x180F21940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A627")]
		[Address(RVA = "0xF21EE0", Offset = "0xF210E0", VA = "0x180F21EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700198F")]
	public int linkNum
	{
		[Token(Token = "0x600A628")]
		[Address(RVA = "0x49B8A0", Offset = "0x49AAA0", VA = "0x18049B8A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A629")]
		[Address(RVA = "0x49C120", Offset = "0x49B320", VA = "0x18049C120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001990")]
	public int orgLinkNum
	{
		[Token(Token = "0x600A62A")]
		[Address(RVA = "0x49BE20", Offset = "0x49B020", VA = "0x18049BE20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A62B")]
		[Address(RVA = "0x49C530", Offset = "0x49B730", VA = "0x18049C530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001991")]
	private GameObject cardEffectRoot
	{
		[Token(Token = "0x600A62C")]
		[Address(RVA = "0xF21950", Offset = "0xF20B50", VA = "0x180F21950")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A588")]
	[Address(RVA = "0xF1CE90", Offset = "0xF1C090", VA = "0x180F1CE90")]
	public static CardRoot Create(CardInstancePool cardPool, GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600A589")]
	[Address(RVA = "0xF1D890", Offset = "0xF1CA90", VA = "0x180F1D890")]
	public static bool IsNeedToCallRegister(CardLocator from, CardLocator to)
	{
		return default(bool);
	}

	[Token(Token = "0x600A58A")]
	[Address(RVA = "0xF1CE00", Offset = "0xF1C000", VA = "0x180F1CE00")]
	public static ModelType CheckModeByPosition(int position)
	{
		return default(ModelType);
	}

	[Token(Token = "0x600A58B")]
	[Address(RVA = "0xF1D450", Offset = "0xF1C650", VA = "0x180F1D450")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600A58C")]
	[Address(RVA = "0xF20020", Offset = "0xF1F220", VA = "0x180F20020")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A590")]
	[Address(RVA = "0xF1FA80", Offset = "0xF1EC80", VA = "0x180F1FA80")]
	public void SetCard(int cardId, int sleeveId, int uniqueId, [Optional] Action onLoaded)
	{
	}

	[Token(Token = "0x600A591")]
	[Address(RVA = "0xF1FB20", Offset = "0xF1ED20", VA = "0x180F1FB20")]
	public void SetCard(int cardId, int sleeveId, int uniqueId, int styleId, [Optional] Action onLoaded)
	{
	}

	[Token(Token = "0x600A592")]
	[Address(RVA = "0xF1F960", Offset = "0xF1EB60", VA = "0x180F1F960")]
	public void SetCardNotUnique(int cardId, int styleId, int sleeveId, [Optional] Action onLoaded)
	{
	}

	[Token(Token = "0x600A593")]
	[Address(RVA = "0xF1E2B0", Offset = "0xF1D4B0", VA = "0x180F1E2B0")]
	public void ReloadTexture([Optional] Action onLoaded)
	{
	}

	[Token(Token = "0x600A594")]
	[Address(RVA = "0xF20300", Offset = "0xF1F500", VA = "0x180F20300")]
	private void UpdateBasicVal()
	{
	}

	[Token(Token = "0x600A595")]
	[Address(RVA = "0xF21360", Offset = "0xF20560", VA = "0x180F21360")]
	private void UpdateValidCounter()
	{
	}

	[Token(Token = "0x600A596")]
	[Address(RVA = "0xF21250", Offset = "0xF20450", VA = "0x180F21250")]
	private void UpdateStatusIcon()
	{
	}

	[Token(Token = "0x600A5A3")]
	[Address(RVA = "0xF200B0", Offset = "0xF1F2B0", VA = "0x180F200B0")]
	public void TransitionToActive(bool showModel)
	{
	}

	[Token(Token = "0x600A5A4")]
	[Address(RVA = "0xF20190", Offset = "0xF1F390", VA = "0x180F20190")]
	public void TransitionToReady()
	{
	}

	[Token(Token = "0x600A5A5")]
	[Address(RVA = "0xF201E0", Offset = "0xF1F3E0", VA = "0x180F201E0")]
	public void TransitionToSuspend()
	{
	}

	[Token(Token = "0x600A5A6")]
	[Address(RVA = "0xF1DFE0", Offset = "0xF1D1E0", VA = "0x180F1DFE0")]
	public void Placement(CardLocator cardLocator, bool isFace, bool isAttack, bool show)
	{
	}

	[Token(Token = "0x600A5A7")]
	[Address(RVA = "0xF1EF20", Offset = "0xF1E120", VA = "0x180F1EF20")]
	public void ReqMoveFlipTurnEffect(CardLocator from, CardLocator to, bool isFace, bool isAttack, bool immediate, CardRootTransition transition, Action onStarted, Action onFinished)
	{
	}

	[Token(Token = "0x600A5A8")]
	[Address(RVA = "0xF1EC50", Offset = "0xF1DE50", VA = "0x180F1EC50")]
	public void ReqFlipTurn(bool isFace, bool isAttack, bool immediate, Action onStarted, Action onFinished)
	{
	}

	[Token(Token = "0x600A5A9")]
	[Address(RVA = "0x8E6EE0", Offset = "0x8E60E0", VA = "0x1808E6EE0")]
	public void StartMove()
	{
	}

	[Token(Token = "0x600A5AC")]
	[Address(RVA = "0xF1EDF0", Offset = "0xF1DFF0", VA = "0x180F1EDF0")]
	public void ReqMoveEffect(CardPlane.MoveTrailType type)
	{
	}

	[Token(Token = "0x600A5AD")]
	[Address(RVA = "0xF1EE90", Offset = "0xF1E090", VA = "0x180F1EE90")]
	public void ReqMoveEffect(DuelEffectPool.Type eff_type, bool persitent_vision = false)
	{
	}

	[Token(Token = "0x600A5AE")]
	[Address(RVA = "0xF1F540", Offset = "0xF1E740", VA = "0x180F1F540")]
	public void ReqStopMoveEffect()
	{
	}

	[Token(Token = "0x600A5AF")]
	[Address(RVA = "0xF1F320", Offset = "0xF1E520", VA = "0x180F1F320")]
	public void ReqPlaySE(string label, bool is3D)
	{
	}

	[Token(Token = "0x600A5B0")]
	[Address(RVA = "0xF1F5D0", Offset = "0xF1E7D0", VA = "0x180F1F5D0")]
	public void ReqStopSE(string label)
	{
	}

	[Token(Token = "0x600A5B1")]
	[Address(RVA = "0xF1EBC0", Offset = "0xF1DDC0", VA = "0x180F1EBC0")]
	public void ReqDisplay(bool disp)
	{
	}

	[Token(Token = "0x600A5B2")]
	[Address(RVA = "0xF1EDD0", Offset = "0xF1DFD0", VA = "0x180F1EDD0")]
	public void ReqHighlight(bool enable, SharedDefinition.ActivateAura type, int order = 0)
	{
	}

	[Token(Token = "0x600A5B3")]
	[Address(RVA = "0xF1E8F0", Offset = "0xF1DAF0", VA = "0x180F1E8F0")]
	public void ReqChangeModelType(ModelType modelType)
	{
	}

	[Token(Token = "0x600A5B4")]
	[Address(RVA = "0xF1D9F0", Offset = "0xF1CBF0", VA = "0x180F1D9F0")]
	public void ModelChange(ModelType type)
	{
	}

	[Token(Token = "0x600A5B5")]
	[Address(RVA = "0xF1D720", Offset = "0xF1C920", VA = "0x180F1D720")]
	public bool IsModelShowing()
	{
		return default(bool);
	}

	[Token(Token = "0x600A5B6")]
	[Address(RVA = "0xF1E470", Offset = "0xF1D670", VA = "0x180F1E470")]
	public void ReqAppealEffect(Action on_finished)
	{
	}

	[Token(Token = "0x600A5B7")]
	[Address(RVA = "0xF1EAB0", Offset = "0xF1DCB0", VA = "0x180F1EAB0")]
	public void ReqCrackEffect(bool enable)
	{
	}

	[Token(Token = "0x600A5B8")]
	[Address(RVA = "0xF1E530", Offset = "0xF1D730", VA = "0x180F1E530")]
	public void ReqBrokenEffect(CardPlane.BrokenType brokenType, Quaternion rotation)
	{
	}

	[Token(Token = "0x600A5B9")]
	[Address(RVA = "0xF1E860", Offset = "0xF1DA60", VA = "0x180F1E860")]
	public void ReqCastShadow(bool isOn)
	{
	}

	[Token(Token = "0x600A5BA")]
	[Address(RVA = "0xF1F890", Offset = "0xF1EA90", VA = "0x180F1F890")]
	public void ReqZoneEffect(int position, bool getOut, bool isFace, ZoneCard zoneCard)
	{
	}

	[Token(Token = "0x600A5BB")]
	[Address(RVA = "0xF1FDB0", Offset = "0xF1EFB0", VA = "0x180F1FDB0")]
	public void StartSummonMaterialTargetEffect(SharedDefinition.SummonMaterialType material_type)
	{
	}

	[Token(Token = "0x600A5BC")]
	[Address(RVA = "0xF1D230", Offset = "0xF1C430", VA = "0x180F1D230")]
	public void EndSacrificeTargetEffect()
	{
	}

	[Token(Token = "0x600A5BD")]
	[Address(RVA = "0xF1E1E0", Offset = "0xF1D3E0", VA = "0x180F1E1E0")]
	public void PrepareSummonMaterialEffect(SharedDefinition.SummonMaterialType type)
	{
	}

	[Token(Token = "0x600A5BE")]
	[Address(RVA = "0xF1F3B0", Offset = "0xF1E5B0", VA = "0x180F1F3B0")]
	public void ReqPreparedSummonMaterialEffect()
	{
	}

	[Token(Token = "0x600A5BF")]
	[Address(RVA = "0xF1F660", Offset = "0xF1E860", VA = "0x180F1F660")]
	public void ReqSummonMaterialEffect(SharedDefinition.SummonMaterialType type)
	{
	}

	[Token(Token = "0x600A5C0")]
	[Address(RVA = "0xF1F1D0", Offset = "0xF1E3D0", VA = "0x180F1F1D0")]
	public void ReqOneShotEffect(DuelEffectPool.Type type, CardEffectOneShotEffect.Mode mode, bool waitEffect, Quaternion rotation)
	{
	}

	[Token(Token = "0x600A5C1")]
	[Address(RVA = "0xF1F280", Offset = "0xF1E480", VA = "0x180F1F280")]
	private void ReqPlayHoldEffect(string holdEffectLabel, DuelEffectPool.Type type, CardEffectHoldEffect.Mode mode)
	{
	}

	[Token(Token = "0x600A5C2")]
	[Address(RVA = "0xF1F4B0", Offset = "0xF1E6B0", VA = "0x180F1F4B0")]
	private void ReqStopHoldEffect(string holdEffectLabel, bool immediate)
	{
	}

	[Token(Token = "0x600A5C3")]
	[Address(RVA = "0xF1EB30", Offset = "0xF1DD30", VA = "0x180F1EB30")]
	public void ReqDisappear(Action onFinished)
	{
	}

	[Token(Token = "0x600A5C4")]
	[Address(RVA = "0xF1E7C0", Offset = "0xF1D9C0", VA = "0x180F1E7C0")]
	public void ReqCallback(Action callback, float delay = 0f)
	{
	}

	[Token(Token = "0x600A5C5")]
	[Address(RVA = "0xF1F7F0", Offset = "0xF1E9F0", VA = "0x180F1F7F0")]
	public void ReqWait(Func<bool> waitFunc)
	{
	}

	[Token(Token = "0x600A5C6")]
	[Address(RVA = "0xF1F750", Offset = "0xF1E950", VA = "0x180F1F750")]
	public void ReqWaitForSecond(float second)
	{
	}

	[Token(Token = "0x600A5C7")]
	[Address(RVA = "0xF1E490", Offset = "0xF1D690", VA = "0x180F1E490")]
	public void ReqAppearEffect(bool isToken, bool waitEffect, Action onFinished)
	{
	}

	[Token(Token = "0x600A5C8")]
	[Address(RVA = "0xF1EA10", Offset = "0xF1DC10", VA = "0x180F1EA10")]
	public void ReqCheatAppearEffect(bool waitEffect, bool isInsight, Action onFinished)
	{
	}

	[Token(Token = "0x600A5C9")]
	[Address(RVA = "0xF1E980", Offset = "0xF1DB80", VA = "0x180F1E980")]
	public void ReqCheatActiveEffect(bool waitEffect, Action onFinished)
	{
	}

	[Token(Token = "0x600A5CA")]
	[Address(RVA = "0xF1D0A0", Offset = "0xF1C2A0", VA = "0x180F1D0A0")]
	public void Disapper()
	{
	}

	[Token(Token = "0x600A5CB")]
	[Address(RVA = "0xF21220", Offset = "0xF20420", VA = "0x180F21220")]
	public void UpdateState()
	{
	}

	[Token(Token = "0x600A5CC")]
	[Address(RVA = "0xF1FCD0", Offset = "0xF1EED0", VA = "0x180F1FCD0")]
	public void ShowPlane()
	{
	}

	[Token(Token = "0x600A5CD")]
	[Address(RVA = "0xF1D3C0", Offset = "0xF1C5C0", VA = "0x180F1D3C0")]
	public void HidePlane()
	{
	}

	[Token(Token = "0x600A5CE")]
	[Address(RVA = "0xF1F930", Offset = "0xF1EB30", VA = "0x180F1F930")]
	public void ResetStatusValue()
	{
	}

	[Token(Token = "0x600A5CF")]
	[Address(RVA = "0xF1DA20", Offset = "0xF1CC20", VA = "0x180F1DA20")]
	public void OnReturnInstance()
	{
	}

	[Token(Token = "0x600A5DB")]
	[Address(RVA = "0xF214F0", Offset = "0xF206F0", VA = "0x180F214F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600A5DC")]
	[Address(RVA = "0xF1D9E0", Offset = "0xF1CBE0", VA = "0x180F1D9E0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600A5DD")]
	[Address(RVA = "0xF1D440", Offset = "0xF1C640", VA = "0x180F1D440")]
	private void IdleStep()
	{
	}

	[Token(Token = "0x600A5DE")]
	[Address(RVA = "0xF20ED0", Offset = "0xF200D0", VA = "0x180F20ED0")]
	private void UpdateCardPicture()
	{
	}

	[Token(Token = "0x600A5DF")]
	[Address(RVA = "0xF21080", Offset = "0xF20280", VA = "0x180F21080")]
	public void UpdateSRT(bool force = false)
	{
	}

	[Token(Token = "0x600A5E0")]
	[Address(RVA = "0xF21610", Offset = "0xF20810", VA = "0x180F21610")]
	private void ValidateFlipTurn()
	{
	}

	[Token(Token = "0x600A5E1")]
	public T GetElement<T>(string label) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600A5E2")]
	[Address(RVA = "0xF1CA50", Offset = "0xF1BC50", VA = "0x180F1CA50")]
	public void AddEffect(CardEffectBase effect)
	{
	}

	[Token(Token = "0x600A5E3")]
	[Address(RVA = "0xF1D6D0", Offset = "0xF1C8D0", VA = "0x180F1D6D0")]
	public bool IsEffectFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x600A5E4")]
	[Address(RVA = "0xF1D8C0", Offset = "0xF1CAC0", VA = "0x180F1D8C0")]
	public bool IsTargetEffectPlaying(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x600A5E5")]
	[Address(RVA = "0xF1D920", Offset = "0xF1CB20", VA = "0x180F1D920")]
	public bool IsZoneEffectPlaying(ZoneCard.Zone zone, ZoneCard.Mode mode)
	{
		return default(bool);
	}

	[Token(Token = "0x600A5E6")]
	[Address(RVA = "0xF1D740", Offset = "0xF1C940", VA = "0x180F1D740")]
	public bool IsMoveEffectRequested()
	{
		return default(bool);
	}

	[Token(Token = "0x600A5E7")]
	[Address(RVA = "0xF20F80", Offset = "0xF20180", VA = "0x180F20F80")]
	public void UpdateEffect()
	{
	}

	[Token(Token = "0x600A5E8")]
	[Address(RVA = "0xF1CE30", Offset = "0xF1C030", VA = "0x180F1CE30")]
	private void ClearAllEffect()
	{
	}

	[Token(Token = "0x600A5ED")]
	[Address(RVA = "0xF1FCB0", Offset = "0xF1EEB0", VA = "0x180F1FCB0")]
	public void SetPlace(int team, int position, int index)
	{
	}

	[Token(Token = "0x600A62D")]
	[Address(RVA = "0xF1CAE0", Offset = "0xF1BCE0", VA = "0x180F1CAE0")]
	private void BuffEffect()
	{
	}

	[Token(Token = "0x600A62E")]
	[Address(RVA = "0xF1CF10", Offset = "0xF1C110", VA = "0x180F1CF10")]
	private void DebuffEffect()
	{
	}

	[Token(Token = "0x600A62F")]
	[Address(RVA = "0xF1CC70", Offset = "0xF1BE70", VA = "0x180F1CC70")]
	private void ChangeEffect()
	{
	}

	[Token(Token = "0x600A630")]
	[Address(RVA = "0xF1D0D0", Offset = "0xF1C2D0", VA = "0x180F1D0D0")]
	public void EffectReset()
	{
	}

	[Token(Token = "0x600A631")]
	[Address(RVA = "0xF1FD50", Offset = "0xF1EF50", VA = "0x180F1FD50")]
	public void StartAttackReady()
	{
	}

	[Token(Token = "0x600A632")]
	[Address(RVA = "0xF1D350", Offset = "0xF1C550", VA = "0x180F1D350")]
	public void FinishAttackReady()
	{
	}

	[Token(Token = "0x600A633")]
	[Address(RVA = "0xF216B0", Offset = "0xF208B0", VA = "0x180F216B0")]
	public CardRoot()
	{
	}
}
