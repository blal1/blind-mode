using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x2001386")]
public class StructureDeckSelectViewController : BaseMenuViewController
{
	[Serializable]
	[Token(Token = "0x2001387")]
	public class DeckCaseImageData
	{
		[Token(Token = "0x400C255")]
		[FieldOffset(Offset = "0x10")]
		public int _caseIconNumber;

		[Token(Token = "0x400C256")]
		[FieldOffset(Offset = "0x18")]
		public Sprite _deckSprite;

		[Token(Token = "0x400C257")]
		[FieldOffset(Offset = "0x20")]
		public Sprite _openedDeckSprite;

		[Token(Token = "0x400C258")]
		[FieldOffset(Offset = "0x28")]
		public Sprite[] _monsterSprites;

		[Token(Token = "0x600793F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DeckCaseImageData()
		{
		}
	}

	[Token(Token = "0x200138B")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		[Token(Token = "0x400C260")]
		[FieldOffset(Offset = "0x10")]
		public int structureDeckId;

		[Token(Token = "0x400C261")]
		[FieldOffset(Offset = "0x18")]
		public StructureDeckSelectViewController _003C_003E4__this;

		[Token(Token = "0x400C262")]
		[FieldOffset(Offset = "0x20")]
		public Action _003C_003E9__2;

		[Token(Token = "0x6007949")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		[Token(Token = "0x600794A")]
		[Address(RVA = "0xC34C00", Offset = "0xC33E00", VA = "0x180C34C00")]
		internal void _003COpenStructureDeckBrowser_003Eb__0()
		{
		}

		[Token(Token = "0x600794B")]
		[Address(RVA = "0xC34CE0", Offset = "0xC33EE0", VA = "0x180C34CE0")]
		internal void _003COpenStructureDeckBrowser_003Eb__2()
		{
		}
	}

	[Token(Token = "0x200138C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_1
	{
		[Token(Token = "0x400C263")]
		[FieldOffset(Offset = "0x10")]
		public GameObject target;

		[Token(Token = "0x600794C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass29_1()
		{
		}

		[Token(Token = "0x600794D")]
		[Address(RVA = "0xC34F50", Offset = "0xC34150", VA = "0x180C34F50")]
		internal bool _003COpenStructureDeckBrowser_003Eb__1()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200138D")]
	[CompilerGenerated]
	private sealed class _003COpenStructureDeckBrowser_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C264")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C265")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C266")]
		[FieldOffset(Offset = "0x20")]
		public int structureDeckId;

		[Token(Token = "0x400C267")]
		[FieldOffset(Offset = "0x28")]
		public StructureDeckSelectViewController _003C_003E4__this;

		[Token(Token = "0x400C268")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass29_1 _003C_003E8__1;

		[Token(Token = "0x400C269")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass29_0 _003C_003E8__2;

		[Token(Token = "0x170012BA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007951")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012BB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007953")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600794E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COpenStructureDeckBrowser_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600794F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007950")]
		[Address(RVA = "0xC27F70", Offset = "0xC27170", VA = "0x180C27F70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007952")]
		[Address(RVA = "0xC28350", Offset = "0xC27550", VA = "0x180C28350", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C244")]
	protected const string k_ArgKeyStructureDeckIds = "sdid";

	[Token(Token = "0x400C245")]
	private const string k_ArgKeyBeforeNextViewEvent = "BeforeNextViewEvent";

	[Token(Token = "0x400C246")]
	[FieldOffset(Offset = "0xD0")]
	protected readonly string k_ELabelTitleText;

	[Token(Token = "0x400C247")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelDeckTemplate;

	[Token(Token = "0x400C248")]
	private const string TWEEN_SELECT_LABEL = "select";

	[Token(Token = "0x400C249")]
	private const string TWEEN_DESELECT_LABEL = "deselect";

	[Token(Token = "0x400C24A")]
	private const string ANDROID_BACK_KEY_LABEL = "AndroidBackKey";

	[Token(Token = "0x400C24B")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private ElementObjectManager m_PrefabUI;

	[Token(Token = "0x400C24C")]
	[FieldOffset(Offset = "0xE8")]
	protected ElementObjectManager m_UI;

	[Token(Token = "0x400C24D")]
	[FieldOffset(Offset = "0xF0")]
	private ElementObjectManager m_DeckTemplate;

	[Token(Token = "0x400C24E")]
	[FieldOffset(Offset = "0xF8")]
	private int[] m_StructureDeckIds;

	[Token(Token = "0x400C24F")]
	[FieldOffset(Offset = "0x100")]
	private SelectionItem[] m_StructureDeckItems;

	[Token(Token = "0x400C250")]
	[FieldOffset(Offset = "0x108")]
	private int m_DefaultSelectIdx;

	[Token(Token = "0x400C251")]
	[FieldOffset(Offset = "0x110")]
	private Action _callback;

	[Token(Token = "0x400C252")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private List<DeckCaseImageData> _deckCaseSpriteDataList;

	[Token(Token = "0x400C253")]
	[FieldOffset(Offset = "0x120")]
	private Dictionary<int, int> _cacheStructureIdToIconNimberMap;

	[Token(Token = "0x400C254")]
	[FieldOffset(Offset = "0x128")]
	private bool _isDeckSelectDisabled;

	[Token(Token = "0x170012B8")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6007934")]
		[Address(RVA = "0xC25CC0", Offset = "0xC24EC0", VA = "0x180C25CC0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B9")]
	private bool isMobile
	{
		[Token(Token = "0x6007935")]
		[Address(RVA = "0xC25C70", Offset = "0xC24E70", VA = "0x180C25C70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007936")]
	[Address(RVA = "0xC25060", Offset = "0xC24260", VA = "0x180C25060")]
	public static void GotoFirstStructDeckSelection(bool restore = false)
	{
	}

	[Token(Token = "0x6007937")]
	[Address(RVA = "0xC24E80", Offset = "0xC24080", VA = "0x180C24E80")]
	private DeckCaseImageData GetDeckCaseSpriteData(int structureId)
	{
		return null;
	}

	[Token(Token = "0x6007938")]
	[Address(RVA = "0xC24D70", Offset = "0xC23F70", VA = "0x180C24D70")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007939")]
	[Address(RVA = "0xC25A70", Offset = "0xC24C70", VA = "0x180C25A70")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600793A")]
	[Address(RVA = "0xC25280", Offset = "0xC24480", VA = "0x180C25280", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600793B")]
	[Address(RVA = "0xC25A10", Offset = "0xC24C10", VA = "0x180C25A10")]
	private void OnClickDeck(int clickedIdx)
	{
	}

	[Token(Token = "0x600793C")]
	[Address(RVA = "0xC25BC0", Offset = "0xC24DC0", VA = "0x180C25BC0", Slot = "28")]
	protected virtual void OnSelectedDeck(int structureDeckId)
	{
	}

	[Token(Token = "0x600793D")]
	[Address(RVA = "0xC25BF0", Offset = "0xC24DF0", VA = "0x180C25BF0")]
	[IteratorStateMachine(typeof(_003COpenStructureDeckBrowser_003Ed__29))]
	protected IEnumerator OpenStructureDeckBrowser(int structureDeckId)
	{
		return null;
	}

	[Token(Token = "0x600793E")]
	[Address(RVA = "0xC24C80", Offset = "0xC23E80", VA = "0x180C24C80")]
	public StructureDeckSelectViewController()
	{
	}
}
