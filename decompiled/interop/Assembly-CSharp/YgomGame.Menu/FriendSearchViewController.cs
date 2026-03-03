using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Friend;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu;

[Token(Token = "0x200118B")]
public class FriendSearchViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x200118C")]
	private interface ISearchForm
	{
		[Token(Token = "0x17001157")]
		GameObject gameObject
		{
			[Token(Token = "0x6006E20")]
			get;
		}

		[Token(Token = "0x17001158")]
		long currentPcode
		{
			[Token(Token = "0x6006E21")]
			get;
		}

		[Token(Token = "0x6006E22")]
		void Clear();

		[Token(Token = "0x6006E23")]
		bool TrySelectChild(bool initializeSelection = false);

		[Token(Token = "0x6006E24")]
		bool OnPadBack();
	}

	[Token(Token = "0x200118D")]
	private class PlayerListView
	{
		[Token(Token = "0x400B7D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string EMPTY_ROOT_LABEL;

		[Token(Token = "0x400B7D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string LIST_ROOT_LABEL;

		[Token(Token = "0x400B7D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string LIST_TITLE_LABEL;

		[Token(Token = "0x400B7D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string LIST_SCROLL_VIEW_LABEL;

		[Token(Token = "0x400B7DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400B7DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject m_EmptyRoot;

		[Token(Token = "0x400B7DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject m_ListRoot;

		[Token(Token = "0x400B7DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TMP_Text m_ListTitleText;

		[Token(Token = "0x400B7DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InfinityScrollView m_ListScrollView;

		[Token(Token = "0x400B7DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, object> m_PlayerDataMap;

		[Token(Token = "0x400B7E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<GameObject, FriendWidget> m_FriendWidgetMap;

		[Token(Token = "0x400B7E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<string> m_PlayerList;

		[Token(Token = "0x17001159")]
		public GameObject gameObject
		{
			[Token(Token = "0x6006E25")]
			[Address(RVA = "0xB615B0", Offset = "0xB607B0", VA = "0x180B615B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700115A")]
		public IReadOnlyList<string> playerList
		{
			[Token(Token = "0x6006E26")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700115B")]
		public long currentPcode
		{
			[Token(Token = "0x6006E27")]
			[Address(RVA = "0xB61440", Offset = "0xB60640", VA = "0x180B61440")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x14000091")]
		public event Action<long> onClickPlayerEvent
		{
			[Token(Token = "0x6006E28")]
			[Address(RVA = "0xB61390", Offset = "0xB60590", VA = "0x180B61390")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E29")]
			[Address(RVA = "0xB615D0", Offset = "0xB607D0", VA = "0x180B615D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6006E2A")]
		[Address(RVA = "0xB60F50", Offset = "0xB60150", VA = "0x180B60F50")]
		public PlayerListView(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6006E2B")]
		[Address(RVA = "0xB60760", Offset = "0xB5F960", VA = "0x180B60760")]
		public void Initialize([Optional] Action onComplete)
		{
		}

		[Token(Token = "0x6006E2C")]
		[Address(RVA = "0xB608E0", Offset = "0xB5FAE0", VA = "0x180B608E0")]
		private void OnCreatedEntity(GameObject gob)
		{
		}

		[Token(Token = "0x6006E2D")]
		[Address(RVA = "0xB609D0", Offset = "0xB5FBD0", VA = "0x180B609D0")]
		private void OnUpdateEntity(GameObject gob, int dataindex)
		{
		}

		[Token(Token = "0x6006E2E")]
		[Address(RVA = "0xB60330", Offset = "0xB5F530", VA = "0x180B60330")]
		public void ApplyResult(List<object> hitPlayerList, bool isExcess, bool resetPosition = true)
		{
		}

		[Token(Token = "0x6006E2F")]
		[Address(RVA = "0xB60DD0", Offset = "0xB5FFD0", VA = "0x180B60DD0")]
		public bool TrySelectIdx(int idx)
		{
			return default(bool);
		}

		[Token(Token = "0x6006E30")]
		[Address(RVA = "0xB60840", Offset = "0xB5FA40", VA = "0x180B60840")]
		public bool IsContainSelectedItem()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200118F")]
	private class SearchFormId : ISearchForm
	{
		[Token(Token = "0x400B7E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string k_ELabelResultMessage;

		[Token(Token = "0x400B7E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string ID_INPUT_LABEL;

		[Token(Token = "0x400B7E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string ID_INPUTOVERRIDE_TEXT_LABEL;

		[Token(Token = "0x400B7E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string PLAYER_BOARD_LABEL;

		[Token(Token = "0x400B7E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400B7EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly InputFieldWidget m_InputFieldWidget;

		[Token(Token = "0x400B7EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly TMP_Text m_InputFieldOverrideText;

		[Token(Token = "0x400B7EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly TMP_Text m_ResultMessage;

		[Token(Token = "0x400B7ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly FriendWidget m_FriendWidget;

		[Token(Token = "0x400B7EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_LastCaretPos;

		[Token(Token = "0x400B7F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int pcodeLength;

		[Token(Token = "0x400B7F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private StringBuilder m_Sb;

		[Token(Token = "0x400B7F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_InputGuard;

		[Token(Token = "0x1700115C")]
		public GameObject gameObject
		{
			[Token(Token = "0x6006E34")]
			[Address(RVA = "0xB615B0", Offset = "0xB607B0", VA = "0x180B615B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700115D")]
		public long currentPcode
		{
			[Token(Token = "0x6006E35")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6006E36")]
			[Address(RVA = "0xA4A870", Offset = "0xA49A70", VA = "0x180A4A870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000092")]
		public event Action<long> onDecideEvent
		{
			[Token(Token = "0x6006E37")]
			[Address(RVA = "0xB62E70", Offset = "0xB62070", VA = "0x180B62E70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E38")]
			[Address(RVA = "0xB62FD0", Offset = "0xB621D0", VA = "0x180B62FD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000093")]
		public event Action<long> onClickPlayerEvent
		{
			[Token(Token = "0x6006E39")]
			[Address(RVA = "0xB62DC0", Offset = "0xB61FC0", VA = "0x180B62DC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E3A")]
			[Address(RVA = "0xB62F20", Offset = "0xB62120", VA = "0x180B62F20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6006E3B")]
		[Address(RVA = "0xB629B0", Offset = "0xB61BB0", VA = "0x180B629B0")]
		public SearchFormId(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6006E3C")]
		[Address(RVA = "0xB61EA0", Offset = "0xB610A0", VA = "0x180B61EA0")]
		public void Initialize(int pcodeLength)
		{
		}

		[Token(Token = "0x6006E3D")]
		[Address(RVA = "0xB61E10", Offset = "0xB61010", VA = "0x180B61E10", Slot = "6")]
		public void Clear()
		{
		}

		[Token(Token = "0x6006E3E")]
		[Address(RVA = "0xB61BD0", Offset = "0xB60DD0", VA = "0x180B61BD0")]
		public void CheckCaretPosition()
		{
		}

		[Token(Token = "0x6006E3F")]
		[Address(RVA = "0xB623F0", Offset = "0xB615F0", VA = "0x180B623F0")]
		private void OnValueChanged(string input)
		{
		}

		[Token(Token = "0x6006E40")]
		[Address(RVA = "0xB62220", Offset = "0xB61420", VA = "0x180B62220")]
		private void OnSubmitInputField(string input)
		{
		}

		[Token(Token = "0x6006E41")]
		[Address(RVA = "0xB61680", Offset = "0xB60880", VA = "0x180B61680")]
		public void ApplySearchResult(long searchPcode, List<object> hitPlayerList, [Optional] string failedMessage)
		{
		}

		[Token(Token = "0x6006E42")]
		[Address(RVA = "0xB62920", Offset = "0xB61B20", VA = "0x180B62920", Slot = "7")]
		public bool TrySelectChild(bool initializeSelection = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6006E43")]
		[Address(RVA = "0xB62110", Offset = "0xB61310", VA = "0x180B62110", Slot = "8")]
		public bool OnPadBack()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001190")]
	private class SearchFormTag : ISearchForm
	{
		[Token(Token = "0x400B7F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string TAG_FORM_LABEL;

		[Token(Token = "0x400B7F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string TAG_RESULT_FORM_LABEL;

		[Token(Token = "0x400B7F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string TAG_SELECT_FORM_LABEL;

		[Token(Token = "0x400B7F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400B7F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly TagSelector m_TagForm;

		[Token(Token = "0x400B7FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly TagListView m_TagListView;

		[Token(Token = "0x400B7FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly PlayerListView m_ResultPlayerList;

		[Token(Token = "0x400B7FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsSelectMode;

		[Token(Token = "0x400B7FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action m_OnComplete;

		[Token(Token = "0x400B7FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_LoadincCnt;

		[Token(Token = "0x400B800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool m_IsEntryMode;

		[Token(Token = "0x1700115E")]
		public GameObject gameObject
		{
			[Token(Token = "0x6006E45")]
			[Address(RVA = "0xB64AB0", Offset = "0xB63CB0", VA = "0x180B64AB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700115F")]
		public TagSelector tagForm
		{
			[Token(Token = "0x6006E46")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001160")]
		public TagListView tagListView
		{
			[Token(Token = "0x6006E47")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001161")]
		public IReadOnlyList<int> searchTagIdList
		{
			[Token(Token = "0x6006E48")]
			[Address(RVA = "0xB64AD0", Offset = "0xB63CD0", VA = "0x180B64AD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001162")]
		public long currentPcode
		{
			[Token(Token = "0x6006E49")]
			[Address(RVA = "0xB64930", Offset = "0xB63B30", VA = "0x180B64930", Slot = "5")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x14000094")]
		public event Action onSearchDecideEvent
		{
			[Token(Token = "0x6006E4A")]
			[Address(RVA = "0xB64890", Offset = "0xB63A90", VA = "0x180B64890")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E4B")]
			[Address(RVA = "0xB64BC0", Offset = "0xB63DC0", VA = "0x180B64BC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000095")]
		public event Action<long> onClickPlayerEvent
		{
			[Token(Token = "0x6006E4C")]
			[Address(RVA = "0xB647C0", Offset = "0xB639C0", VA = "0x180B647C0")]
			add
			{
			}
			[Token(Token = "0x6006E4D")]
			[Address(RVA = "0xB64AF0", Offset = "0xB63CF0", VA = "0x180B64AF0")]
			remove
			{
			}
		}

		[Token(Token = "0x6006E4E")]
		[Address(RVA = "0xB64300", Offset = "0xB63500", VA = "0x180B64300")]
		public SearchFormTag(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6006E4F")]
		[Address(RVA = "0xB63280", Offset = "0xB62480", VA = "0x180B63280")]
		public void Initialize([Optional] Action onComplete)
		{
		}

		[Token(Token = "0x6006E50")]
		[Address(RVA = "0xB63090", Offset = "0xB62290", VA = "0x180B63090")]
		private void CheckInitializeCallback()
		{
		}

		[Token(Token = "0x6006E51")]
		[Address(RVA = "0xB63080", Offset = "0xB62280", VA = "0x180B63080")]
		public void ApplySearchResult(List<object> hitPlayerList, bool isExcess, bool resetPosition = true)
		{
		}

		[Token(Token = "0x6006E52")]
		[Address(RVA = "0xB630C0", Offset = "0xB622C0", VA = "0x180B630C0", Slot = "6")]
		public void Clear()
		{
		}

		[Token(Token = "0x6006E53")]
		[Address(RVA = "0xB63760", Offset = "0xB62960", VA = "0x180B63760")]
		private void ToEntrySelectForm()
		{
		}

		[Token(Token = "0x6006E54")]
		[Address(RVA = "0xB639C0", Offset = "0xB62BC0", VA = "0x180B639C0")]
		private void ToSelectForm()
		{
		}

		[Token(Token = "0x6006E55")]
		[Address(RVA = "0xB63850", Offset = "0xB62A50", VA = "0x180B63850")]
		private void ToResultForm(List<object> hitPlayerList, bool isExcess, bool resetPosition = true)
		{
		}

		[Token(Token = "0x6006E56")]
		[Address(RVA = "0xB63B00", Offset = "0xB62D00", VA = "0x180B63B00")]
		public bool TrySelectDefault(bool initializeSelection = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6006E57")]
		[Address(RVA = "0xB63AF0", Offset = "0xB62CF0", VA = "0x180B63AF0", Slot = "7")]
		public bool TrySelectChild(bool initializeSelection = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6006E58")]
		[Address(RVA = "0xB634C0", Offset = "0xB626C0", VA = "0x180B634C0", Slot = "8")]
		public bool OnPadBack()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001191")]
	private class TagListView
	{
		[Token(Token = "0x400B801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string SCROLL_VIEW_LABEL;

		[Token(Token = "0x400B802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string ITEM_ON;

		[Token(Token = "0x400B803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string ITEM_OFF;

		[Token(Token = "0x400B804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string ITEM_TAG_LABEL_ON;

		[Token(Token = "0x400B805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string ITEM_TAG_LABEL_OFF;

		[Token(Token = "0x400B806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400B807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly InfinityScrollView m_ScrollView;

		[Token(Token = "0x400B808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly SelectionItem m_UpperSelectTarget;

		[Token(Token = "0x400B809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly List<int> searchTagIds;

		[Token(Token = "0x400B80A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly IReadOnlyList<int> selectedList;

		[Token(Token = "0x400B80B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool removeInteractable;

		[Token(Token = "0x17001163")]
		public GameObject gameObject
		{
			[Token(Token = "0x6006E5C")]
			[Address(RVA = "0xB68D80", Offset = "0xB67F80", VA = "0x180B68D80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001164")]
		public InfinityScrollView scrollView
		{
			[Token(Token = "0x6006E5D")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000096")]
		public event Func<int, bool> onClickTagEvent
		{
			[Token(Token = "0x6006E5E")]
			[Address(RVA = "0xB68CD0", Offset = "0xB67ED0", VA = "0x180B68CD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E5F")]
			[Address(RVA = "0xB68DA0", Offset = "0xB67FA0", VA = "0x180B68DA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6006E60")]
		[Address(RVA = "0xB689F0", Offset = "0xB67BF0", VA = "0x180B689F0")]
		public TagListView(ElementObjectManager eom, IReadOnlyList<object> searchTagIds, IReadOnlyList<int> selectedList, [Optional] SelectionItem upperSelectTarget)
		{
		}

		[Token(Token = "0x6006E61")]
		[Address(RVA = "0xB689A0", Offset = "0xB67BA0", VA = "0x180B689A0")]
		public void SetupDefaultSelectIdx()
		{
		}

		[Token(Token = "0x6006E62")]
		[Address(RVA = "0xB68540", Offset = "0xB67740", VA = "0x180B68540")]
		public void Initialize([Optional] Action complete)
		{
		}

		[Token(Token = "0x6006E63")]
		[Address(RVA = "0xB686B0", Offset = "0xB678B0", VA = "0x180B686B0")]
		private void OnUpdateEntity(GameObject gob, int dataindex)
		{
		}

		[Token(Token = "0x6006E64")]
		[Address(RVA = "0xB68970", Offset = "0xB67B70", VA = "0x180B68970")]
		public bool SelectItemByIdx(int idx)
		{
			return default(bool);
		}

		[Token(Token = "0x6006E65")]
		[Address(RVA = "0xB684D0", Offset = "0xB676D0", VA = "0x180B684D0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6006E66")]
		[Address(RVA = "0xB68620", Offset = "0xB67820", VA = "0x180B68620")]
		public bool IsContainSelectedItem()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001194")]
	private class TagSelector
	{
		[Token(Token = "0x400B811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int k_TagMax;

		[Token(Token = "0x400B812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string TAG_ITEM_ROOT_LABEL;

		[Token(Token = "0x400B813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string TAG_ITEM_LABEL_OFF_LABEL;

		[Token(Token = "0x400B814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string TAG_ITEM_LABEL_ON_LABEL;

		[Token(Token = "0x400B815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string TAG_ITEM_ADD_LABEL;

		[Token(Token = "0x400B816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string SEARCH_BUTTON_LABEL;

		[Token(Token = "0x400B817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400B818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly ToggleGroupWidget m_ToggleGroupWidget;

		[Token(Token = "0x400B819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly SelectionButton searchButton;

		[Token(Token = "0x400B81A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly List<int> m_TagList;

		[Token(Token = "0x17001165")]
		private int k_AddIdx
		{
			[Token(Token = "0x6006E6B")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17001166")]
		public GameObject gameObject
		{
			[Token(Token = "0x6006E6C")]
			[Address(RVA = "0xB6A890", Offset = "0xB69A90", VA = "0x180B6A890")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001167")]
		public IReadOnlyList<int> tagList
		{
			[Token(Token = "0x6006E6D")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001168")]
		public int currentIdx
		{
			[Token(Token = "0x6006E6E")]
			[Address(RVA = "0xB6A7F0", Offset = "0xB699F0", VA = "0x180B6A7F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17001169")]
		public int focusTagId
		{
			[Token(Token = "0x6006E6F")]
			[Address(RVA = "0xB6A810", Offset = "0xB69A10", VA = "0x180B6A810")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000097")]
		public event Action<int> onClickTagEvent
		{
			[Token(Token = "0x6006E70")]
			[Address(RVA = "0xB6A740", Offset = "0xB69940", VA = "0x180B6A740")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E71")]
			[Address(RVA = "0xB6A950", Offset = "0xB69B50", VA = "0x180B6A950")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000098")]
		public event Action onClickSearchEvent
		{
			[Token(Token = "0x6006E72")]
			[Address(RVA = "0xB6A6A0", Offset = "0xB698A0", VA = "0x180B6A6A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E73")]
			[Address(RVA = "0xB6A8B0", Offset = "0xB69AB0", VA = "0x180B6A8B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6006E74")]
		[Address(RVA = "0xB6A1B0", Offset = "0xB693B0", VA = "0x180B6A1B0")]
		public TagSelector(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6006E75")]
		[Address(RVA = "0xB69040", Offset = "0xB68240", VA = "0x180B69040")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6006E76")]
		[Address(RVA = "0xB68F20", Offset = "0xB68120", VA = "0x180B68F20")]
		public void Clear()
		{
		}

		[Token(Token = "0x6006E77")]
		[Address(RVA = "0xB6A190", Offset = "0xB69390", VA = "0x180B6A190")]
		public void ToAllOff()
		{
		}

		[Token(Token = "0x6006E78")]
		[Address(RVA = "0xB69BC0", Offset = "0xB68DC0", VA = "0x180B69BC0")]
		public bool SelectDefaultCursor(bool initializeSelection = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6006E79")]
		[Address(RVA = "0xB69D50", Offset = "0xB68F50", VA = "0x180B69D50")]
		public bool SelectTailToggle(bool initializeSelection = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6006E7A")]
		[Address(RVA = "0xB69B90", Offset = "0xB68D90", VA = "0x180B69B90")]
		public bool SelectCurrentToggle(bool initializeSelection = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6006E7B")]
		[Address(RVA = "0xB69E00", Offset = "0xB69000", VA = "0x180B69E00")]
		public bool SelectToggleAt(int toggleIdx, bool initializeSelection = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6006E7C")]
		[Address(RVA = "0xB69400", Offset = "0xB68600", VA = "0x180B69400")]
		public bool IsContainSelectedItem(Selector selector)
		{
			return default(bool);
		}

		[Token(Token = "0x6006E7D")]
		[Address(RVA = "0xB695D0", Offset = "0xB687D0", VA = "0x180B695D0")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6006E7E")]
		[Address(RVA = "0xB69ED0", Offset = "0xB690D0", VA = "0x180B69ED0")]
		public void SetTag(int tagId, bool isInvokeChangeEvent = true)
		{
		}

		[Token(Token = "0x6006E7F")]
		[Address(RVA = "0xB69C60", Offset = "0xB68E60", VA = "0x180B69C60")]
		public void SelectTag(int tagId, bool isInvokeChangeEvent = true)
		{
		}

		[Token(Token = "0x6006E80")]
		[Address(RVA = "0xB69AC0", Offset = "0xB68CC0", VA = "0x180B69AC0")]
		public void SelectAtLast(bool isInvokeChangeEvent = true)
		{
		}

		[Token(Token = "0x6006E81")]
		[Address(RVA = "0xB69B50", Offset = "0xB68D50", VA = "0x180B69B50")]
		public void SelectAt(int idx, bool isInvokeChangeEvent = true)
		{
		}

		[Token(Token = "0x6006E82")]
		[Address(RVA = "0xB68FF0", Offset = "0xB681F0", VA = "0x180B68FF0")]
		public bool EnabledAdd()
		{
			return default(bool);
		}

		[Token(Token = "0x6006E83")]
		[Address(RVA = "0xB68F90", Offset = "0xB68190", VA = "0x180B68F90")]
		public bool ContainTag(int tagId)
		{
			return default(bool);
		}

		[Token(Token = "0x6006E84")]
		[Address(RVA = "0xB68E50", Offset = "0xB68050", VA = "0x180B68E50")]
		public void AddTag(int tagId)
		{
		}

		[Token(Token = "0x6006E85")]
		[Address(RVA = "0xB69970", Offset = "0xB68B70", VA = "0x180B69970")]
		public void RemoveTag(int tagId)
		{
		}

		[Token(Token = "0x6006E86")]
		[Address(RVA = "0xB69A00", Offset = "0xB68C00", VA = "0x180B69A00")]
		public void ReplaceTag(int fromTagId, int toTagId)
		{
		}
	}

	[Token(Token = "0x400B7C7")]
	public const string PREFAB_NAME = "Friend/FriendSearch";

	[Token(Token = "0x400B7C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string BTN_BACK_PAD_BUTTON_LABEL;

	[Token(Token = "0x400B7C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelTitleBg_Result;

	[Token(Token = "0x400B7CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelGuideMessage_Default;

	[Token(Token = "0x400B7CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelGuideMessage_Result;

	[Token(Token = "0x400B7CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string MAIN_TAB_LABEL;

	[Token(Token = "0x400B7CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string SEARCHFORM_ID_LABEL;

	[Token(Token = "0x400B7CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string SEARCHFORM_TAG_LABEL;

	[Token(Token = "0x400B7CF")]
	private const int k_ID_SEARCH_FORM = 0;

	[Token(Token = "0x400B7D0")]
	private const int k_TAG_SEARCH_FORM = 1;

	[Token(Token = "0x400B7D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private long m_ReserveSearchPcode;

	[Token(Token = "0x400B7D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private FriendDefinitionSetting m_FriendDefinitionSetting;

	[Token(Token = "0x400B7D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private DirectionalTabGroup m_MainTab;

	[Token(Token = "0x400B7D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private ISearchForm[] m_SearchForms;

	[Token(Token = "0x400B7D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool m_IsReady;

	[Token(Token = "0x17001156")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6006E0C")]
		[Address(RVA = "0xB5C4C0", Offset = "0xB5B6C0", VA = "0x180B5C4C0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006E0D")]
	[Address(RVA = "0xB5B2B0", Offset = "0xB5A4B0", VA = "0x180B5B2B0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006E0E")]
	[Address(RVA = "0xB5B3F0", Offset = "0xB5A5F0", VA = "0x180B5B3F0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006E0F")]
	[Address(RVA = "0xB5C060", Offset = "0xB5B260", VA = "0x180B5C060")]
	private void Start()
	{
	}

	[Token(Token = "0x6006E10")]
	[Address(RVA = "0xB5BAC0", Offset = "0xB5ACC0", VA = "0x180B5BAC0", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x6006E11")]
	[Address(RVA = "0xB5B1E0", Offset = "0xB5A3E0", VA = "0x180B5B1E0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6006E12")]
	[Address(RVA = "0xB5BB90", Offset = "0xB5AD90", VA = "0x180B5BB90")]
	private void OnPadBack()
	{
	}

	[Token(Token = "0x6006E13")]
	[Address(RVA = "0xB5C140", Offset = "0xB5B340", VA = "0x180B5C140")]
	private bool TrySelectParentSelector(Selector targetSelector, bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6006E14")]
	[Address(RVA = "0xB5B380", Offset = "0xB5A580", VA = "0x180B5B380", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6006E15")]
	[Address(RVA = "0xB5AF10", Offset = "0xB5A110", VA = "0x180B5AF10")]
	private void ApplyMainTab()
	{
	}

	[Token(Token = "0x6006E16")]
	[Address(RVA = "0xB5BCD0", Offset = "0xB5AED0", VA = "0x180B5BCD0")]
	private void OpenPlayerProfile(long pcode)
	{
	}

	[Token(Token = "0x6006E17")]
	[Address(RVA = "0xB5BDE0", Offset = "0xB5AFE0", VA = "0x180B5BDE0")]
	private void RequestSearchId()
	{
	}

	[Token(Token = "0x6006E18")]
	[Address(RVA = "0xB5BD10", Offset = "0xB5AF10", VA = "0x180B5BD10")]
	private void RequestSearchIdExecute(long searchPcode)
	{
	}

	[Token(Token = "0x6006E19")]
	[Address(RVA = "0xB5BE70", Offset = "0xB5B070", VA = "0x180B5BE70")]
	private void RequestSearchTag(bool resetPosition = true)
	{
	}

	[Token(Token = "0x6006E1A")]
	[Address(RVA = "0xB5BE80", Offset = "0xB5B080", VA = "0x180B5BE80")]
	private void RequestSearchTag(Action callback, bool resetPosition = true)
	{
	}

	[Token(Token = "0x6006E1B")]
	[Address(RVA = "0xB5C350", Offset = "0xB5B550", VA = "0x180B5C350")]
	public FriendSearchViewController()
	{
	}
}
