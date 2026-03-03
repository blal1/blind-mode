using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.CardPack.OpenResult;

[Token(Token = "0x2001546")]
public class ObtainedCardsWidget : ElementWidgetBase
{
	[Token(Token = "0x2001547")]
	private class AutoSelectHelper
	{
		[Token(Token = "0x400CBFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<SelectionItem> m_SortTargetSelections;

		[Token(Token = "0x400CBFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<SelectionItem, float> m_SortAmounts;

		[Token(Token = "0x6008384")]
		[Address(RVA = "0xCB23A0", Offset = "0xCB15A0", VA = "0x180CB23A0")]
		public bool TrySelect(SelectionItem fromItem, Vector2 dir, [Optional] Selector[] ignoreSelectors)
		{
			return default(bool);
		}

		[Token(Token = "0x6008385")]
		[Address(RVA = "0xCB2E10", Offset = "0xCB2010", VA = "0x180CB2E10")]
		public AutoSelectHelper()
		{
		}
	}

	[Token(Token = "0x400CBE4")]
	private const string k_ELabelScrollView = "ScrollView";

	[Token(Token = "0x400CBE5")]
	private const string k_ELabel_Entity_PulldownRoot = "ScrollView/SecretPulldownRoot";

	[Token(Token = "0x400CBE6")]
	private const string k_ELabel_Entity_PackCardTemplate = "ScrollView/PackCardGroupTemplate/PackCardTemplate";

	[Token(Token = "0x400CBE7")]
	private const string k_OLabel_Template_Default = "Default";

	[Token(Token = "0x400CBE8")]
	private const string k_OLabel_Template_Expand = "Expand";

	[Token(Token = "0x400CBE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly ToggleWidget m_ShowOwnedNumToggle;

	[Token(Token = "0x400CBEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InfinityScrollView m_ScrollView;

	[Token(Token = "0x400CBEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Dictionary<GameObject, CardWidget[]> m_CardWidgetGroupMap;

	[Token(Token = "0x400CBEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<int> m_SecretShopIdsCache;

	[Token(Token = "0x400CBED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<object> m_ListDatas;

	[Token(Token = "0x400CBEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<object> m_DrawListDatas;

	[Token(Token = "0x400CBEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<int> m_TemplateIdxs;

	[Token(Token = "0x400CBF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<object> workDrawDatas;

	[Token(Token = "0x400CBF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<object> workExtraGroupDatas;

	[Token(Token = "0x400CBF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool workIsSendGift;

	[Token(Token = "0x400CBF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool isExpand;

	[Token(Token = "0x400CBF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	public bool pulldownSecretsEnable;

	[Token(Token = "0x400CBF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject m_PulldownRoot;

	[Token(Token = "0x400CBF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ElementObjectManager m_PackCardTemplatePref;

	[Token(Token = "0x400CBF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private CardWidget m_SelectedPulldownOwner;

	[Token(Token = "0x400CBF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AutoSelectHelper m_AutoSelectHelper;

	[Token(Token = "0x400CBF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Selector[] m_AutoSelectIgnoreSelectors;

	[Token(Token = "0x400CBFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<object> m_CardDetailMrksCache;

	[Token(Token = "0x400CBFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private List<object> m_CardDetailPremiumsCache;

	[Token(Token = "0x1700140A")]
	public InfinityScrollView scrollView
	{
		[Token(Token = "0x600836B")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600836C")]
	[Address(RVA = "0xCC5960", Offset = "0xCC4B60", VA = "0x180CC5960")]
	public ObtainedCardsWidget(ElementObjectManager eom, ElementObjectManager showOwnedNumEom)
	{
	}

	[Token(Token = "0x600836D")]
	[Address(RVA = "0xCC1D50", Offset = "0xCC0F50", VA = "0x180CC1D50")]
	public void ActivateScroll(Action onComplete)
	{
	}

	[Token(Token = "0x600836E")]
	[Address(RVA = "0xCC3430", Offset = "0xCC2630", VA = "0x180CC3430")]
	private void InitLayout(List<string> headerLabels, bool dispSendGift)
	{
	}

	[Token(Token = "0x600836F")]
	[Address(RVA = "0xCC4350", Offset = "0xCC3550", VA = "0x180CC4350")]
	private void OnCreatedEntity(GameObject gob)
	{
	}

	[Token(Token = "0x6008370")]
	[Address(RVA = "0xCC3B80", Offset = "0xCC2D80", VA = "0x180CC3B80")]
	private void OnActivateEntity(GameObject gob)
	{
	}

	[Token(Token = "0x6008371")]
	[Address(RVA = "0xCC4D50", Offset = "0xCC3F50", VA = "0x180CC4D50")]
	private void OnDeactivateEntity(GameObject gob)
	{
	}

	[Token(Token = "0x6008372")]
	[Address(RVA = "0xCC4180", Offset = "0xCC3380", VA = "0x180CC4180")]
	private IReadOnlyList<(SelectionItem, int, int)> OnCollectEntitySelectionItems(GameObject entity)
	{
		return null;
	}

	[Token(Token = "0x6008373")]
	[Address(RVA = "0xCC4EA0", Offset = "0xCC40A0", VA = "0x180CC4EA0")]
	private void OnUpdateEntity(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6008374")]
	[Address(RVA = "0xCC36A0", Offset = "0xCC28A0", VA = "0x180CC36A0")]
	private bool IsSelectableDataIndex(int dataIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6008375")]
	[Address(RVA = "0xCC4910", Offset = "0xCC3B10", VA = "0x180CC4910")]
	private bool OnCustomDirectionTransition(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6008376")]
	[Address(RVA = "0xCC4570", Offset = "0xCC3770", VA = "0x180CC4570")]
	private void OnCreatedObtainWidget(CardWidget cardWidget)
	{
	}

	[Token(Token = "0x6008377")]
	[Address(RVA = "0xCC5260", Offset = "0xCC4460", VA = "0x180CC5260")]
	private void SetObtainCardWidget(CardWidget cardWidget, int dataindex, bool isDefaultItem)
	{
	}

	[Token(Token = "0x6008378")]
	[Address(RVA = "0xCC5780", Offset = "0xCC4980", VA = "0x180CC5780")]
	private void SetPulldownOwner(CardWidget pulldownOwner)
	{
	}

	[Token(Token = "0x6008379")]
	[Address(RVA = "0xCC3340", Offset = "0xCC2540", VA = "0x180CC3340")]
	private void CloseSelectedPulldown()
	{
	}

	[Token(Token = "0x600837A")]
	[Address(RVA = "0xCC5220", Offset = "0xCC4420", VA = "0x180CC5220")]
	private void OpenSelectedPulldown()
	{
	}

	[Token(Token = "0x600837B")]
	[Address(RVA = "0xCC3CE0", Offset = "0xCC2EE0", VA = "0x180CC3CE0")]
	private void OnClickCard(CardWidget cardWidget)
	{
	}

	[Token(Token = "0x600837C")]
	[Address(RVA = "0xCC4100", Offset = "0xCC3300", VA = "0x180CC4100")]
	private void OnClickPulldown(CardWidget cardWidget)
	{
	}

	[Token(Token = "0x600837D")]
	[Address(RVA = "0xCC4E50", Offset = "0xCC4050", VA = "0x180CC4E50")]
	private void OnSelectedCard(CardWidget cardWidget)
	{
	}

	[Token(Token = "0x600837E")]
	[Address(RVA = "0xCC3710", Offset = "0xCC2910", VA = "0x180CC3710")]
	public void JumpToDirection(PadInputDirection direction)
	{
	}
}
