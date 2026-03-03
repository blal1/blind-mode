using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;

namespace YgomGame.CardFile;

[Token(Token = "0x2001586")]
public class CardFileController : MonoBehaviour
{
	[Token(Token = "0x2001587")]
	private enum AnimationType
	{
		[Token(Token = "0x400CD9A")]
		In,
		[Token(Token = "0x400CD9B")]
		OutCover,
		[Token(Token = "0x400CD9C")]
		OutBackCover,
		[Token(Token = "0x400CD9D")]
		OutPage,
		[Token(Token = "0x400CD9E")]
		CoverToPage,
		[Token(Token = "0x400CD9F")]
		PageToCover,
		[Token(Token = "0x400CDA0")]
		PageToBackCover,
		[Token(Token = "0x400CDA1")]
		BackCoverToPage,
		[Token(Token = "0x400CDA2")]
		TurnOnePage,
		[Token(Token = "0x400CDA3")]
		BackOnePage,
		[Token(Token = "0x400CDA4")]
		KeepCover,
		[Token(Token = "0x400CDA5")]
		KeepPage,
		[Token(Token = "0x400CDA6")]
		KeepBackCover,
		[Token(Token = "0x400CDA7")]
		None
	}

	[Token(Token = "0x2001588")]
	private abstract class BaseOperation
	{
		[Token(Token = "0x1700148B")]
		public virtual bool blockInput
		{
			[Token(Token = "0x60085A1")]
			[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700148C")]
		public virtual bool isPlaying
		{
			[Token(Token = "0x60085A2")]
			[Address(RVA = "0x47A1F0", Offset = "0x4793F0", VA = "0x18047A1F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60085A3")]
		public abstract void Begin();

		[Token(Token = "0x60085A4")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "7")]
		public virtual bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x60085A5")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
		public virtual void Terminate()
		{
		}

		[Token(Token = "0x60085A6")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		protected BaseOperation()
		{
		}
	}

	[Token(Token = "0x2001589")]
	private class ActivationOperation : BaseOperation
	{
		[Token(Token = "0x400CDAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject cardFileObj;

		[Token(Token = "0x400CDAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool active;

		[Token(Token = "0x60085A7")]
		[Address(RVA = "0xCCCDA0", Offset = "0xCCBFA0", VA = "0x180CCCDA0")]
		public ActivationOperation(GameObject cardFileObj, bool active)
		{
		}

		[Token(Token = "0x60085A8")]
		[Address(RVA = "0xCCCD50", Offset = "0xCCBF50", VA = "0x180CCCD50", Slot = "6")]
		public override void Begin()
		{
		}

		[Token(Token = "0x60085A9")]
		[Address(RVA = "0xCCCD80", Offset = "0xCCBF80", VA = "0x180CCCD80", Slot = "8")]
		public override void Terminate()
		{
		}
	}

	[Token(Token = "0x200158A")]
	private class AnimationOperation : BaseOperation
	{
		[Token(Token = "0x400CDAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private LabeledPlayableController timeline;

		[Token(Token = "0x400CDAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimationType animationType;

		[Token(Token = "0x400CDAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string label;

		[Token(Token = "0x400CDAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string finishSignal;

		[Token(Token = "0x400CDB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string keepLabel;

		[Token(Token = "0x1700148D")]
		public override bool blockInput
		{
			[Token(Token = "0x60085AA")]
			[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60085AB")]
		[Address(RVA = "0xCCCF10", Offset = "0xCCC110", VA = "0x180CCCF10")]
		public AnimationOperation(LabeledPlayableController target, AnimationType type)
		{
		}

		[Token(Token = "0x60085AC")]
		[Address(RVA = "0xCCCE70", Offset = "0xCCC070", VA = "0x180CCCE70", Slot = "6")]
		public override void Begin()
		{
		}

		[Token(Token = "0x60085AD")]
		[Address(RVA = "0xCCCEA0", Offset = "0xCCC0A0", VA = "0x180CCCEA0", Slot = "7")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x60085AE")]
		[Address(RVA = "0xCCCD80", Offset = "0xCCBF80", VA = "0x180CCCD80", Slot = "8")]
		public override void Terminate()
		{
		}
	}

	[Token(Token = "0x200158B")]
	private class SetupCardOperation : BaseOperation
	{
		[Token(Token = "0x400CDB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ElementObjectManager eoMgr;

		[Token(Token = "0x400CDB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CardFileInfo cardFileInfo;

		[Token(Token = "0x400CDB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int beginPage;

		[Token(Token = "0x400CDB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int endPage;

		[Token(Token = "0x400CDB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string[] labelFormat;

		[Token(Token = "0x400CDB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[] pageLabelFormat;

		[Token(Token = "0x400CDB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string[] pageLabelFormatForTurnPage;

		[Token(Token = "0x60085AF")]
		[Address(RVA = "0xCE1920", Offset = "0xCE0B20", VA = "0x180CE1920")]
		public SetupCardOperation(ElementObjectManager eoMgr, CardFileInfo cardFileInfo, int beginPage, int endPage, bool forTurnPage)
		{
		}

		[Token(Token = "0x60085B0")]
		[Address(RVA = "0xCE1280", Offset = "0xCE0480", VA = "0x180CE1280", Slot = "6")]
		public override void Begin()
		{
		}

		[Token(Token = "0x60085B1")]
		[Address(RVA = "0xCE1730", Offset = "0xCE0930", VA = "0x180CE1730", Slot = "8")]
		public override void Terminate()
		{
		}
	}

	[Token(Token = "0x200158D")]
	private class FileInOperation : BaseOperation
	{
		[Token(Token = "0x200158E")]
		private class EffectInfo
		{
			[Token(Token = "0x400CDBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int cardID;

			[Token(Token = "0x400CDBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int style;

			[Token(Token = "0x400CDC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MeshRenderer targetMesh;

			[Token(Token = "0x400CDC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlayableDirector effect;

			[Token(Token = "0x400CDC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool finished;

			[Token(Token = "0x60085BB")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public EffectInfo()
			{
			}
		}

		[Token(Token = "0x200158F")]
		private class EffectUnit
		{
			[Token(Token = "0x400CDC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float playDelay;

			[Token(Token = "0x400CDC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<EffectInfo> effects;

			[Token(Token = "0x400CDC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool played;

			[Token(Token = "0x1700148F")]
			public bool finished
			{
				[Token(Token = "0x60085BC")]
				[Address(RVA = "0xCDA840", Offset = "0xCD9A40", VA = "0x180CDA840")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60085BD")]
			[Address(RVA = "0xCDA7C0", Offset = "0xCD99C0", VA = "0x180CDA7C0")]
			public EffectUnit()
			{
			}
		}

		[Token(Token = "0x400CDB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ElementObjectManager eoMgr;

		[Token(Token = "0x400CDBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PageInfo[] pageList;

		[Token(Token = "0x400CDBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject prefabFileInEffect;

		[Token(Token = "0x400CDBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<int[]> checkOrder;

		[Token(Token = "0x400CDBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<EffectUnit> effectUnitList;

		[Token(Token = "0x1700148E")]
		public override bool blockInput
		{
			[Token(Token = "0x60085B5")]
			[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60085B6")]
		[Address(RVA = "0xCDB700", Offset = "0xCDA900", VA = "0x180CDB700")]
		public FileInOperation(ElementObjectManager eoMgr, PageInfo pageInfoLeft, PageInfo pageInfoRight, GameObject prefabFileInEffect)
		{
		}

		[Token(Token = "0x60085B7")]
		[Address(RVA = "0xCDA960", Offset = "0xCD9B60", VA = "0x180CDA960", Slot = "6")]
		public override void Begin()
		{
		}

		[Token(Token = "0x60085B8")]
		[Address(RVA = "0xCDAC70", Offset = "0xCD9E70", VA = "0x180CDAC70")]
		private void CreateEffect(EffectInfo effectInfo)
		{
		}

		[Token(Token = "0x60085B9")]
		[Address(RVA = "0xCDB440", Offset = "0xCDA640", VA = "0x180CDB440", Slot = "7")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x60085BA")]
		[Address(RVA = "0xCDB140", Offset = "0xCDA340", VA = "0x180CDB140", Slot = "8")]
		public override void Terminate()
		{
		}
	}

	[Token(Token = "0x2001591")]
	private class CallbackOperation : BaseOperation
	{
		[Token(Token = "0x400CDCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Action callback;

		[Token(Token = "0x60085C3")]
		[Address(RVA = "0x6A1440", Offset = "0x6A0640", VA = "0x1806A1440")]
		public CallbackOperation(Action callback)
		{
		}

		[Token(Token = "0x60085C4")]
		[Address(RVA = "0xCCD080", Offset = "0xCCC280", VA = "0x180CCD080", Slot = "6")]
		public override void Begin()
		{
		}

		[Token(Token = "0x60085C5")]
		[Address(RVA = "0xCCCD80", Offset = "0xCCBF80", VA = "0x180CCCD80", Slot = "8")]
		public override void Terminate()
		{
		}
	}

	[Token(Token = "0x2001592")]
	private class CompleteEffectOperation : BaseOperation
	{
		[Token(Token = "0x400CDCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableDirector tlRoot;

		[Token(Token = "0x400CDCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SkinnedMeshRenderer cardFileRenderer;

		[Token(Token = "0x400CDCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SkinnedMeshRenderer cardFileRenderer2;

		[Token(Token = "0x400CDCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool finished;

		[Token(Token = "0x17001490")]
		public override bool blockInput
		{
			[Token(Token = "0x60085C6")]
			[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60085C7")]
		[Address(RVA = "0xCDA750", Offset = "0xCD9950", VA = "0x180CDA750")]
		public CompleteEffectOperation(PlayableDirector tlRoot, SkinnedMeshRenderer cardFileRenderer, SkinnedMeshRenderer cardFileRenderer2)
		{
		}

		[Token(Token = "0x60085C8")]
		[Address(RVA = "0xCDA570", Offset = "0xCD9770", VA = "0x180CDA570", Slot = "6")]
		public override void Begin()
		{
		}

		[Token(Token = "0x60085C9")]
		[Address(RVA = "0xCCCD80", Offset = "0xCCBF80", VA = "0x180CCCD80", Slot = "8")]
		public override void Terminate()
		{
		}

		[Token(Token = "0x60085CA")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0", Slot = "7")]
		public override bool Update()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001593")]
	private class SetCursorPositionOperation : BaseOperation
	{
		[Token(Token = "0x400CDCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int page;

		[Token(Token = "0x400CDD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int index;

		[Token(Token = "0x400CDD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ElementObjectManager eoMgr;

		[Token(Token = "0x400CDD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject cursorPrefab;

		[Token(Token = "0x400CDD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action<GameObject> onCreateCursor;

		[Token(Token = "0x60085CD")]
		[Address(RVA = "0xCE1200", Offset = "0xCE0400", VA = "0x180CE1200")]
		public SetCursorPositionOperation(int page, int index, ElementObjectManager eoMgr, GameObject cursorPrefab, Action<GameObject> onCreateCursor)
		{
		}

		[Token(Token = "0x60085CE")]
		[Address(RVA = "0xCE0FD0", Offset = "0xCE01D0", VA = "0x180CE0FD0", Slot = "6")]
		public override void Begin()
		{
		}

		[Token(Token = "0x60085CF")]
		[Address(RVA = "0xCE11B0", Offset = "0xCE03B0", VA = "0x180CE11B0", Slot = "8")]
		public override void Terminate()
		{
		}
	}

	[Token(Token = "0x2001594")]
	private class SetCursorActiveOperation : BaseOperation
	{
		[Token(Token = "0x400CDD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool active;

		[Token(Token = "0x400CDD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject cursor;

		[Token(Token = "0x60085D0")]
		[Address(RVA = "0xCE0F80", Offset = "0xCE0180", VA = "0x180CE0F80")]
		public SetCursorActiveOperation(bool active, GameObject cursor)
		{
		}

		[Token(Token = "0x60085D1")]
		[Address(RVA = "0xCE0F00", Offset = "0xCE0100", VA = "0x180CE0F00", Slot = "6")]
		public override void Begin()
		{
		}
	}

	[Token(Token = "0x200159B")]
	[CompilerGenerated]
	private sealed class _003CStayCallBack_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400CDE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400CDE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400CDE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardFileController _003C_003E4__this;

		[Token(Token = "0x400CDE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onFinished;

		[Token(Token = "0x17001491")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60085E4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001492")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60085E6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60085E1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStayCallBack_003Ed__52(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60085E2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60085E3")]
		[Address(RVA = "0xCFA650", Offset = "0xCF9850", VA = "0x180CFA650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60085E5")]
		[Address(RVA = "0xCFA7F0", Offset = "0xCF99F0", VA = "0x180CFA7F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400CD83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<AnimationType, string> labelList;

	[Token(Token = "0x400CD84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<AnimationType, string> watchSignal;

	[Token(Token = "0x400CD85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Dictionary<AnimationType, AnimationType> typeToKeepType;

	[Token(Token = "0x400CD86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<BaseOperation> operations;

	[Token(Token = "0x400CD87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private BaseOperation currentOperation;

	[Token(Token = "0x400CD88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject root;

	[Token(Token = "0x400CD89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LabeledPlayableController tlCardFile;

	[Token(Token = "0x400CD8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PlayableDirector tlRoot;

	[Token(Token = "0x400CD8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ElementObjectManager eoMgrCardFile;

	[Token(Token = "0x400CD8C")]
	private const string pathCardFileIn = "CardFile/Common/Ef_CardFileIn01";

	[Token(Token = "0x400CD8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject prefabCardFileIn;

	[Token(Token = "0x400CD8E")]
	private const string pathCardCursor = "CardFile/Common/Cursor/CardFile_CardCursor";

	[Token(Token = "0x400CD8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject prefabCardCursor;

	[Token(Token = "0x400CD90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject cardCursorObj;

	[Token(Token = "0x400CD91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Action<int> onPageChangedCallback;

	[Token(Token = "0x400CD92")]
	private const int COVER_PAGE_INDEX = 0;

	[Token(Token = "0x400CD93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private DefinitionSetting definitionSetting;

	[Token(Token = "0x400CD94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private CardFileManager cfManager;

	[Token(Token = "0x400CD95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private CardFileInfo cfi;

	[Token(Token = "0x400CD96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int loadCounter;

	[Token(Token = "0x400CD98")]
	private const float fileInEffectDelay = 1f / 6f;

	[Token(Token = "0x17001485")]
	public GameObject rootGameObject
	{
		[Token(Token = "0x6008571")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001486")]
	private int BackCoverPageIndex
	{
		[Token(Token = "0x6008572")]
		[Address(RVA = "0xCD3820", Offset = "0xCD2A20", VA = "0x180CD3820")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001487")]
	private CardFileInfo cardFileInfo
	{
		[Token(Token = "0x6008573")]
		[Address(RVA = "0xCD38A0", Offset = "0xCD2AA0", VA = "0x180CD38A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001488")]
	public bool isAnimation
	{
		[Token(Token = "0x6008574")]
		[Address(RVA = "0xCD3930", Offset = "0xCD2B30", VA = "0x180CD3930")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001489")]
	public bool loaded
	{
		[Token(Token = "0x6008575")]
		[Address(RVA = "0xCD3960", Offset = "0xCD2B60", VA = "0x180CD3960")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700148A")]
	public int requestingPageIndex
	{
		[Token(Token = "0x6008576")]
		[Address(RVA = "0xCD3970", Offset = "0xCD2B70", VA = "0x180CD3970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008577")]
		[Address(RVA = "0xCD3980", Offset = "0xCD2B80", VA = "0x180CD3980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6008578")]
	[Address(RVA = "0xCD2D60", Offset = "0xCD1F60", VA = "0x180CD2D60")]
	private void Start()
	{
	}

	[Token(Token = "0x6008579")]
	[Address(RVA = "0xCD1350", Offset = "0xCD0550", VA = "0x180CD1350")]
	public static CardFileController Create(DefinitionSetting setting, Transform parent, CardFileInfo cardFileInfo, Action<int> onPageChangedCallback, [Optional] Action onLoadFinishedCallback)
	{
		return null;
	}

	[Token(Token = "0x600857A")]
	[Address(RVA = "0xCD1180", Offset = "0xCD0380", VA = "0x180CD1180")]
	public static CardFileController CreateFromPreview(Transform parent, int cardFileId, int complete, Action<int> onPageChangedCallback, [Optional] Action onLoadFinishedCallback)
	{
		return null;
	}

	[Token(Token = "0x600857B")]
	[Address(RVA = "0xCD16B0", Offset = "0xCD08B0", VA = "0x180CD16B0")]
	public void Initialize(DefinitionSetting setting, CardFileInfo cardFileInfo, Action<int> onPageChangedCallback, [Optional] Action onLoadFinishedCallback)
	{
	}

	[Token(Token = "0x600857C")]
	[Address(RVA = "0xCD1650", Offset = "0xCD0850", VA = "0x180CD1650")]
	public void Initialize(DefinitionSetting setting, CardFileManager cardFileManager, Action<int> onPageChangedCallback, [Optional] Action onLoadFinishedCallback)
	{
	}

	[Token(Token = "0x600857D")]
	[Address(RVA = "0xCD1710", Offset = "0xCD0910", VA = "0x180CD1710")]
	public void Initialize(Action<int> onPageChangedCallback, [Optional] Action onLoadFinishedCallback)
	{
	}

	[Token(Token = "0x600857E")]
	[Address(RVA = "0xCD1470", Offset = "0xCD0670", VA = "0x180CD1470")]
	public void Initialize(DefinitionSetting setting, int cardFileId, int complete, Action<int> onPageChangedCallback, [Optional] Action onLoadFinishedCallback)
	{
	}

	[Token(Token = "0x600857F")]
	[Address(RVA = "0xCD2DC0", Offset = "0xCD1FC0", VA = "0x180CD2DC0")]
	[IteratorStateMachine(typeof(_003CStayCallBack_003Ed__52))]
	private IEnumerator StayCallBack(Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x6008580")]
	[Address(RVA = "0xCD1BD0", Offset = "0xCD0DD0", VA = "0x180CD1BD0")]
	private void OnLoadCardFile([Optional] Action onFinishedCallback)
	{
	}

	[Token(Token = "0x6008581")]
	[Address(RVA = "0xCD1D40", Offset = "0xCD0F40", VA = "0x180CD1D40")]
	private void OnLoadFinished(Action onLoadFinishedCallback)
	{
	}

	[Token(Token = "0x6008582")]
	[Address(RVA = "0xCD1930", Offset = "0xCD0B30", VA = "0x180CD1930")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6008583")]
	[Address(RVA = "0xCD30B0", Offset = "0xCD22B0", VA = "0x180CD30B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6008584")]
	[Address(RVA = "0xCD2CD0", Offset = "0xCD1ED0", VA = "0x180CD2CD0")]
	public void SetActive(bool active)
	{
	}

	[Token(Token = "0x6008585")]
	[Address(RVA = "0xCD1910", Offset = "0xCD0B10", VA = "0x180CD1910")]
	private void InvokeOnChangePage(int page)
	{
	}

	[Token(Token = "0x6008586")]
	[Address(RVA = "0xCD2F20", Offset = "0xCD2120", VA = "0x180CD2F20")]
	private void UpdateOperation()
	{
	}

	[Token(Token = "0x6008587")]
	[Address(RVA = "0xCD07C0", Offset = "0xCCF9C0", VA = "0x180CD07C0")]
	private void AddActivationOperation(bool active)
	{
	}

	[Token(Token = "0x6008588")]
	[Address(RVA = "0xCD0870", Offset = "0xCCFA70", VA = "0x180CD0870")]
	private void AddAnimationOperation(AnimationType animationType)
	{
	}

	[Token(Token = "0x6008589")]
	[Address(RVA = "0xCD0C10", Offset = "0xCCFE10", VA = "0x180CD0C10")]
	private void AddFileInOperation(PageInfo pageLeft, PageInfo pageRight)
	{
	}

	[Token(Token = "0x600858A")]
	[Address(RVA = "0xCD1020", Offset = "0xCD0220", VA = "0x180CD1020")]
	private void AddSetupCardOperation(int beginPageNum, bool forTurnPageAnim, int endPage = -1)
	{
	}

	[Token(Token = "0x600858B")]
	[Address(RVA = "0xCD0A30", Offset = "0xCCFC30", VA = "0x180CD0A30")]
	private void AddCallbackOperation(Action callback)
	{
	}

	[Token(Token = "0x600858C")]
	[Address(RVA = "0xCD0D90", Offset = "0xCCFF90", VA = "0x180CD0D90")]
	private void AddNotifyPageChangeOperation(int pageIndex)
	{
	}

	[Token(Token = "0x600858D")]
	[Address(RVA = "0xCD0CD0", Offset = "0xCCFED0", VA = "0x180CD0CD0")]
	private void AddFlushInfoFlagOperation(PageInfo page)
	{
	}

	[Token(Token = "0x600858E")]
	[Address(RVA = "0xCD0AD0", Offset = "0xCCFCD0", VA = "0x180CD0AD0")]
	private void AddCompleteEffectOperation()
	{
	}

	[Token(Token = "0x600858F")]
	[Address(RVA = "0xCD0F00", Offset = "0xCD0100", VA = "0x180CD0F00")]
	private void AddSetCursorPositionOperation(int page, int index)
	{
	}

	[Token(Token = "0x6008590")]
	[Address(RVA = "0xCD0E50", Offset = "0xCD0050", VA = "0x180CD0E50")]
	private void AddSetCursorActiveOperation(bool active)
	{
	}

	[Token(Token = "0x6008591")]
	[Address(RVA = "0xCD2490", Offset = "0xCD1690", VA = "0x180CD2490")]
	public void ReqDisp(Action onFinished)
	{
	}

	[Token(Token = "0x6008592")]
	[Address(RVA = "0xCD2820", Offset = "0xCD1A20", VA = "0x180CD2820")]
	public void ReqRefresh(Action onFinished)
	{
	}

	[Token(Token = "0x6008593")]
	[Address(RVA = "0xCD1D70", Offset = "0xCD0F70", VA = "0x180CD1D70")]
	public void ReqAppearance(Action onFinished)
	{
	}

	[Token(Token = "0x6008594")]
	[Address(RVA = "0xCD2560", Offset = "0xCD1760", VA = "0x180CD2560")]
	public void ReqNewCardIn(Action onFinished)
	{
	}

	[Token(Token = "0x6008595")]
	[Address(RVA = "0xCD22A0", Offset = "0xCD14A0", VA = "0x180CD22A0")]
	public void ReqCompleteEffect(Action onFinished)
	{
	}

	[Token(Token = "0x6008596")]
	[Address(RVA = "0xCD29B0", Offset = "0xCD1BB0", VA = "0x180CD29B0")]
	public void ReqTurnOnePage(Action onFinished)
	{
	}

	[Token(Token = "0x6008597")]
	[Address(RVA = "0xCD2020", Offset = "0xCD1220", VA = "0x180CD2020")]
	public void ReqBackOnePage(Action onFinished)
	{
	}

	[Token(Token = "0x6008598")]
	[Address(RVA = "0xCD2AF0", Offset = "0xCD1CF0", VA = "0x180CD2AF0")]
	public void ReqTurnPage(int pageIndex, Action onFinished)
	{
	}

	[Token(Token = "0x6008599")]
	[Address(RVA = "0xCD2150", Offset = "0xCD1350", VA = "0x180CD2150")]
	public void ReqBackPage(int pageIndex, Action onFinished)
	{
	}

	[Token(Token = "0x600859A")]
	[Address(RVA = "0xCD24D0", Offset = "0xCD16D0", VA = "0x180CD24D0")]
	public void ReqExit(Action onFinished)
	{
	}

	[Token(Token = "0x600859B")]
	[Address(RVA = "0xCD2880", Offset = "0xCD1A80", VA = "0x180CD2880")]
	public void ReqSetCursorPosition(int page, int index)
	{
	}

	[Token(Token = "0x600859C")]
	[Address(RVA = "0xCD2870", Offset = "0xCD1A70", VA = "0x180CD2870")]
	public void ReqSetCursorActive(bool active)
	{
	}

	[Token(Token = "0x600859D")]
	[Address(RVA = "0xCD37A0", Offset = "0xCD29A0", VA = "0x180CD37A0")]
	public CardFileController()
	{
	}
}
