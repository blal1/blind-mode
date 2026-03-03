using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.CardFile;

[Token(Token = "0x20015AA")]
public class CardFileTableViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x20015AB")]
	private class TitleArea : MonoBehaviour
	{
		[Token(Token = "0x400CE58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400CE59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isInitialized;

		[Token(Token = "0x400CE5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExtendedTextMeshProUGUI m_CautionBtnText;

		[Token(Token = "0x400CE5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionButton m_CautionButton;

		[Token(Token = "0x170014A5")]
		public Action onClickCautionButtonCallback
		{
			[Token(Token = "0x6008658")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008659")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600865A")]
		[Address(RVA = "0xCFA2F0", Offset = "0xCF94F0", VA = "0x180CFA2F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600865B")]
		[Address(RVA = "0xCFA340", Offset = "0xCF9540", VA = "0x180CFA340")]
		public void InitializeElements()
		{
		}

		[Token(Token = "0x600865C")]
		[Address(RVA = "0xCFA500", Offset = "0xCF9700", VA = "0x180CFA500")]
		public void SetCautionButtonText(string label)
		{
		}

		[Token(Token = "0x600865D")]
		[Address(RVA = "0xCFA300", Offset = "0xCF9500", VA = "0x180CFA300")]
		public void DispCautionButton(bool disp)
		{
		}

		[Token(Token = "0x600865E")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public TitleArea()
		{
		}
	}

	[Token(Token = "0x20015AC")]
	private class TableData
	{
		[Token(Token = "0x400CE5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int index;

		[Token(Token = "0x400CE5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int activeNum;

		[Token(Token = "0x400CE5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal List<Data> dataList;

		[Token(Token = "0x6008660")]
		[Address(RVA = "0xBE8F80", Offset = "0xBE8180", VA = "0x180BE8F80")]
		public TableData(int index, int activeNum, List<Data> dataList)
		{
		}
	}

	[Token(Token = "0x20015AD")]
	private class Data
	{
		[Token(Token = "0x400CE60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal bool badge;

		[Token(Token = "0x400CE61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int itemId;

		[Token(Token = "0x400CE62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int completeStatus;

		[Token(Token = "0x400CE63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int collectNum;

		[Token(Token = "0x400CE64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int maxNum;

		[Token(Token = "0x400CE65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int sort;

		[Token(Token = "0x6008661")]
		[Address(RVA = "0xCF9C20", Offset = "0xCF8E20", VA = "0x180CF9C20")]
		public Data(bool badge, int itemId, int completeStatus, int collectNum, int maxNum, int sort)
		{
		}
	}

	[Token(Token = "0x20015B1")]
	[CompilerGenerated]
	private sealed class _003CDelaySelect_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400CE6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400CE70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400CE71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action action;

		[Token(Token = "0x170014A6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600866F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014A7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008671")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600866C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelaySelect_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600866D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600866E")]
		[Address(RVA = "0xBCCD00", Offset = "0xBCBF00", VA = "0x180BCCD00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008670")]
		[Address(RVA = "0xCFA550", Offset = "0xCF9750", VA = "0x180CFA550", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400CE40")]
	private const string k_PREF_PATH = "CardFile/CardFileTable";

	[Token(Token = "0x400CE41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelTitleArea;

	[Token(Token = "0x400CE42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelCardFileTable;

	[Token(Token = "0x400CE43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelTextEmptyMessage;

	[Token(Token = "0x400CE44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelTextName;

	[Token(Token = "0x400CE45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelTextNum;

	[Token(Token = "0x400CE46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ElabelFileTemplate;

	[Token(Token = "0x400CE47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ElabelEntityObject;

	[Token(Token = "0x400CE48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string k_ElabelNewBadge;

	[Token(Token = "0x400CE49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string k_ElabelButton;

	[Token(Token = "0x400CE4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string k_ElabelImage;

	[Token(Token = "0x400CE4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string k_ElabelCardNum;

	[Token(Token = "0x400CE4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string k_ElabelCardNumComplete;

	[Token(Token = "0x400CE4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string k_ElabelButtonPrev;

	[Token(Token = "0x400CE4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string k_ElabelButtonNext;

	[Token(Token = "0x400CE4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private long m_Pcode;

	[Token(Token = "0x400CE50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int m_ItemId;

	[Token(Token = "0x400CE51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private ElementObject m_EmptyMessage;

	[Token(Token = "0x400CE52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private ElementObjectManager m_ScrollEom;

	[Token(Token = "0x400CE53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private InfinityScrollView m_InfinityScroll;

	[Token(Token = "0x400CE54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private SlidePagerWidget m_SlidePagerWidget;

	[Token(Token = "0x400CE55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private TitleArea m_TitleArea;

	[Token(Token = "0x400CE56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private CardFileDefinition.OpenType m_OpenType;

	[Token(Token = "0x400CE57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private List<TableData> m_TableDataList;

	[Token(Token = "0x170014A4")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6008640")]
		[Address(RVA = "0xCF2560", Offset = "0xCF1760", VA = "0x180CF2560", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008641")]
	[Address(RVA = "0xCF12E0", Offset = "0xCF04E0", VA = "0x180CF12E0")]
	public static void Open(ViewControllerManager vcm, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6008642")]
	[Address(RVA = "0xCF1180", Offset = "0xCF0380", VA = "0x180CF1180")]
	public static void OpenFromShop(int itemId)
	{
	}

	[Token(Token = "0x6008643")]
	[Address(RVA = "0xCF0060", Offset = "0xCEF260", VA = "0x180CF0060", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6008644")]
	[Address(RVA = "0xCEFF90", Offset = "0xCEF190", VA = "0x180CEFF90", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008645")]
	[Address(RVA = "0xCF0E50", Offset = "0xCF0050", VA = "0x180CF0E50", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x6008646")]
	[Address(RVA = "0xCF0130", Offset = "0xCEF330", VA = "0x180CF0130", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008647")]
	[Address(RVA = "0xCEF850", Offset = "0xCEEA50", VA = "0x180CEF850", Slot = "28")]
	protected virtual void CallApi([Optional] Action onSuccess)
	{
	}

	[Token(Token = "0x6008648")]
	[Address(RVA = "0xCF1F10", Offset = "0xCF1110", VA = "0x180CF1F10")]
	private void SetElement()
	{
	}

	[Token(Token = "0x6008649")]
	[Address(RVA = "0xCF1340", Offset = "0xCF0540", VA = "0x180CF1340")]
	private void SetData()
	{
	}

	[Token(Token = "0x600864A")]
	[Address(RVA = "0xCF0FF0", Offset = "0xCF01F0", VA = "0x180CF0FF0", Slot = "29")]
	protected virtual void OpenCardFile(int itemId)
	{
	}

	[Token(Token = "0x600864B")]
	[Address(RVA = "0xCEFEA0", Offset = "0xCEF0A0", VA = "0x180CEFEA0")]
	private void MovePageCurrentCardFile()
	{
	}

	[Token(Token = "0x600864C")]
	[Address(RVA = "0xCEF950", Offset = "0xCEEB50", VA = "0x180CEF950")]
	[IteratorStateMachine(typeof(_003CDelaySelect_003Ed__40))]
	private IEnumerator DelaySelect(Action action)
	{
		return null;
	}

	[Token(Token = "0x600864D")]
	[Address(RVA = "0xCEF9C0", Offset = "0xCEEBC0", VA = "0x180CEF9C0")]
	private void InitializeScroll()
	{
	}

	[Token(Token = "0x600864E")]
	[Address(RVA = "0xCF21B0", Offset = "0xCF13B0", VA = "0x180CF21B0")]
	private void UpdateScroll()
	{
	}

	[Token(Token = "0x600864F")]
	[Address(RVA = "0xCF0750", Offset = "0xCEF950", VA = "0x180CF0750")]
	private void OnEntityUpdate(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6008650")]
	[Address(RVA = "0xCF0340", Offset = "0xCEF540", VA = "0x180CF0340")]
	private IReadOnlyList<(SelectionItem, int, int)> OnCustomCollectionSelectionItems(GameObject entity)
	{
		return null;
	}

	[Token(Token = "0x6008651")]
	[Address(RVA = "0xCF04E0", Offset = "0xCEF6E0", VA = "0x180CF04E0")]
	private bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6008652")]
	[Address(RVA = "0xCF2250", Offset = "0xCF1450", VA = "0x180CF2250")]
	public CardFileTableViewController()
	{
	}
}
