using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Mission;

[Token(Token = "0x2000C06")]
public class MissionBulkRecieveDialogWidget : ContentWidgetBase<MissionBulkRecieveDialogWidget, EntryInsertWidgetData>, IContentWidgetAsyncLoader, IContentPostAllInsertedHandler, IContentWidgetDirectionalInputListener, IContentLifecycleHandler
{
	[Token(Token = "0x2000C07")]
	public class ClearTabContext
	{
		[Token(Token = "0x400999B")]
		[FieldOffset(Offset = "0x10")]
		public string tabLabel;

		[Token(Token = "0x400999C")]
		[FieldOffset(Offset = "0x18")]
		public List<ClearInfoContext> clearInfos;

		[Token(Token = "0x6004958")]
		[Address(RVA = "0x918F90", Offset = "0x918190", VA = "0x180918F90")]
		public ClearTabContext(string tabLabel)
		{
		}
	}

	[Token(Token = "0x2000C08")]
	public class ClearInfoContext
	{
		[Token(Token = "0x400999D")]
		[FieldOffset(Offset = "0x10")]
		public string missionName;

		[Token(Token = "0x400999E")]
		[FieldOffset(Offset = "0x18")]
		public EntryItemListData.Context item;

		[Token(Token = "0x400999F")]
		[FieldOffset(Offset = "0x20")]
		public int goalCnt;

		[Token(Token = "0x40099A0")]
		[FieldOffset(Offset = "0x24")]
		public int goalMax;

		[Token(Token = "0x6004959")]
		[Address(RVA = "0x918F20", Offset = "0x918120", VA = "0x180918F20")]
		public ClearInfoContext(string missionName, EntryItemListData.Context item, int goalCnt, int goalMax)
		{
		}
	}

	[Token(Token = "0x400998C")]
	[FieldOffset(Offset = "0x30")]
	private readonly int k_TemplateItemIdx;

	[Token(Token = "0x400998D")]
	[FieldOffset(Offset = "0x34")]
	private readonly int k_TemplateGroupNameIdx;

	[Token(Token = "0x400998E")]
	[FieldOffset(Offset = "0x38")]
	private readonly int k_TemplateGroupBorderIdx;

	[Token(Token = "0x400998F")]
	[FieldOffset(Offset = "0x3C")]
	private readonly int k_TemplateMissionIdx;

	[Token(Token = "0x4009990")]
	[FieldOffset(Offset = "0x40")]
	private readonly int k_TemplateItemBorderIdx;

	[Token(Token = "0x4009991")]
	[FieldOffset(Offset = "0x48")]
	public List<EntryItemListData.Context> totalItems;

	[Token(Token = "0x4009992")]
	[FieldOffset(Offset = "0x50")]
	public List<ClearTabContext> clearTabInfos;

	[Token(Token = "0x4009993")]
	[FieldOffset(Offset = "0x58")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x4009994")]
	[FieldOffset(Offset = "0x60")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x4009995")]
	[FieldOffset(Offset = "0x68")]
	private Selector m_Selector;

	[Token(Token = "0x4009996")]
	[FieldOffset(Offset = "0x70")]
	private List<object> m_ScrollDataList;

	[Token(Token = "0x4009997")]
	[FieldOffset(Offset = "0x78")]
	private List<int> m_ScrollTemplateIdxList;

	[Token(Token = "0x4009998")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<GameObject, CommonDialogItemListWidget.ItemLineWidget> m_ItemWidgetMap;

	[Token(Token = "0x4009999")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<SelectionItem, GameObject> m_ItemButtonEntityMap;

	[Token(Token = "0x400999A")]
	[FieldOffset(Offset = "0x90")]
	private Action m_OnCompleteCallback;

	[Token(Token = "0x170009DF")]
	public bool rebuildLayoutOnPostAllInserted
	{
		[Token(Token = "0x6004938")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004939")]
	[Address(RVA = "0x91B0A0", Offset = "0x91A2A0", VA = "0x18091B0A0")]
	public static MissionBulkRecieveDialogWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x600493A")]
	[Address(RVA = "0x91AFB0", Offset = "0x91A1B0", VA = "0x18091AFB0", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x600493B")]
	[Address(RVA = "0x91AD10", Offset = "0x919F10", VA = "0x18091AD10", Slot = "25")]
	public void AsyncBinding(IEntryData entryData, Action onComplete)
	{
	}

	[Token(Token = "0x600493C")]
	[Address(RVA = "0x91B100", Offset = "0x91A300", VA = "0x18091B100", Slot = "24")]
	protected override void InnerBinding(EntryInsertWidgetData entryData)
	{
	}

	[Token(Token = "0x600493D")]
	[Address(RVA = "0x91BF50", Offset = "0x91B150", VA = "0x18091BF50", Slot = "27")]
	public void OnPostAllInserted()
	{
	}

	[Token(Token = "0x600493E")]
	[Address(RVA = "0x91C380", Offset = "0x91B580", VA = "0x18091C380")]
	private void OnScrollInitialized()
	{
	}

	[Token(Token = "0x600493F")]
	[Address(RVA = "0x91C650", Offset = "0x91B850", VA = "0x18091C650")]
	private void OnUpdatedEntityCallback(GameObject entity, int idx)
	{
	}

	[Token(Token = "0x6004940")]
	[Address(RVA = "0x91BAF0", Offset = "0x91ACF0", VA = "0x18091BAF0")]
	private bool OnCustomEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6004941")]
	[Address(RVA = "0x91BBA0", Offset = "0x91ADA0", VA = "0x18091BBA0")]
	private bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6004942")]
	[Address(RVA = "0x91BE50", Offset = "0x91B050", VA = "0x18091BE50")]
	private bool OnFocusSelectEntity(GameObject entity, int dataIndex, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6004943")]
	[Address(RVA = "0x91B630", Offset = "0x91A830", VA = "0x18091B630")]
	private void InsertGroupName(string name)
	{
	}

	[Token(Token = "0x6004944")]
	[Address(RVA = "0x91B520", Offset = "0x91A720", VA = "0x18091B520")]
	private void InsertGroupBorder()
	{
	}

	[Token(Token = "0x6004945")]
	[Address(RVA = "0x91B740", Offset = "0x91A940", VA = "0x18091B740")]
	private void InsertItemEntity(EntryItemListData.Context itemContext)
	{
	}

	[Token(Token = "0x6004946")]
	[Address(RVA = "0x91B850", Offset = "0x91AA50", VA = "0x18091B850")]
	private void InsertMissionEntity(ClearInfoContext clearInfo)
	{
	}

	[Token(Token = "0x6004947")]
	[Address(RVA = "0x91B410", Offset = "0x91A610", VA = "0x18091B410")]
	private void InsertEntityBorder()
	{
	}

	[Token(Token = "0x6004948")]
	[Address(RVA = "0x91CCE0", Offset = "0x91BEE0", VA = "0x18091CCE0")]
	private void UpdateGroupName(GameObject entity, object data)
	{
	}

	[Token(Token = "0x6004949")]
	[Address(RVA = "0x91CDB0", Offset = "0x91BFB0", VA = "0x18091CDB0")]
	private void UpdateItemEntity(GameObject entity, object data)
	{
	}

	[Token(Token = "0x600494A")]
	[Address(RVA = "0x91D1F0", Offset = "0x91C3F0", VA = "0x18091D1F0")]
	private void UpdateMissionEntity(GameObject entity, object data)
	{
	}

	[Token(Token = "0x600494B")]
	[Address(RVA = "0x91C8E0", Offset = "0x91BAE0", VA = "0x18091C8E0")]
	private bool TrySelectHeadItem(bool focus = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600494C")]
	[Address(RVA = "0x91C800", Offset = "0x91BA00", VA = "0x18091C800")]
	private void TrySelectBottomItem(bool focus = false)
	{
	}

	[Token(Token = "0x600494D")]
	[Address(RVA = "0x91C9D0", Offset = "0x91BBD0", VA = "0x18091C9D0")]
	private bool TrySelectItem(int entityIdx, SelectionItem currentItem, bool focus = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600494E")]
	[Address(RVA = "0x91CB80", Offset = "0x91BD80", VA = "0x18091CB80")]
	private bool TrySelectItem(GameObject activeEntity, SelectionItem currentItem, bool focus = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600494F")]
	[Address(RVA = "0x91ADC0", Offset = "0x919FC0", VA = "0x18091ADC0")]
	private void CheckSelectOnAnalogInput(Vector2 dir)
	{
	}

	[Token(Token = "0x6004950")]
	[Address(RVA = "0x91BF10", Offset = "0x91B110", VA = "0x18091BF10", Slot = "28")]
	public void OnMainAnalogInput(Vector2 dir)
	{
	}

	[Token(Token = "0x6004951")]
	[Address(RVA = "0x91BF10", Offset = "0x91B110", VA = "0x18091BF10", Slot = "29")]
	public void OnSubAnalogInput(Vector2 dir)
	{
	}

	[Token(Token = "0x6004952")]
	[Address(RVA = "0x91BF00", Offset = "0x91B100", VA = "0x18091BF00", Slot = "30")]
	public void OnLeftInput()
	{
	}

	[Token(Token = "0x6004953")]
	[Address(RVA = "0x91C370", Offset = "0x91B570", VA = "0x18091C370", Slot = "31")]
	public void OnRightInput()
	{
	}

	[Token(Token = "0x6004954")]
	[Address(RVA = "0x91C400", Offset = "0x91B600", VA = "0x18091C400", Slot = "32")]
	public void OnUpInput()
	{
	}

	[Token(Token = "0x6004955")]
	[Address(RVA = "0x91BE40", Offset = "0x91B040", VA = "0x18091BE40", Slot = "33")]
	public void OnDownInput()
	{
	}

	[Token(Token = "0x6004956")]
	[Address(RVA = "0x91B960", Offset = "0x91AB60", VA = "0x18091B960", Slot = "34")]
	public bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6004957")]
	[Address(RVA = "0x91D590", Offset = "0x91C790", VA = "0x18091D590")]
	public MissionBulkRecieveDialogWidget()
	{
	}
}
