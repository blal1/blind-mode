using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D0B")]
public class MDMarkupTableWidget : MDMarkupWidgetBase, IMDMarkupTableCell, IMDMarkupCardContainWidget, IMDMarkupItemContainWidget, IMDMarkupLinkContainWidget, IMDMarkupLayoutWidget, IMDMarkupTMPWidget, IMDMarkupButtonContainWidget
{
	[Token(Token = "0x4009D5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly MDMarkupTableFactory m_TableFactory;

	[Token(Token = "0x4009D60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly MDMarkupTableRowFactory m_RowFactory;

	[Token(Token = "0x4009D61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly MDMarkupTableCellFactory m_CellFactory;

	[Token(Token = "0x4009D62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly List<IMDMarkupTMPWidget> m_TMPWidgets;

	[Token(Token = "0x4009D63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly List<IMDMarkupAsyncWidget> m_AsyncWidgets;

	[Token(Token = "0x4009D64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly List<IMDMarkupLayoutWidget> m_LayoutWidgets;

	[Token(Token = "0x4009D65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private IMDMarkupFreeScrollHandler m_FreeScrollHandler;

	[Token(Token = "0x4009D66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float[] m_ColSizes;

	[Token(Token = "0x4009D67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<IMDMarkupCardWidget> m_CardWidgets;

	[Token(Token = "0x4009D68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<IMDMarkupItemWidget> m_ItemWidgets;

	[Token(Token = "0x4009D69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<IMDMarkupLinkWidget> m_LinkWidgets;

	[Token(Token = "0x17000B39")]
	public float[] colSizes
	{
		[Token(Token = "0x6004EDA")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B3A")]
	public override bool isReady
	{
		[Token(Token = "0x6004EDB")]
		[Address(RVA = "0x9738B0", Offset = "0x972AB0", VA = "0x1809738B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000B3B")]
	private ElementObjectManager YgomGame_002EMDMarkup_002EIMDMarkupTableCell_002Eeom
	{
		[Token(Token = "0x6004EDC")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B3C")]
	public IReadOnlyList<IMDMarkupCardWidget> cardWidgets
	{
		[Token(Token = "0x6004EDD")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B3D")]
	public IReadOnlyList<IMDMarkupItemWidget> itemWidgets
	{
		[Token(Token = "0x6004EDE")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B3E")]
	public IReadOnlyList<IMDMarkupLinkWidget> linkWidgets
	{
		[Token(Token = "0x6004EDF")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B3F")]
	public bool borderVisible
	{
		[Token(Token = "0x6004EE0")]
		[Address(RVA = "0x973850", Offset = "0x972A50", VA = "0x180973850", Slot = "21")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004EE1")]
		[Address(RVA = "0x9739E0", Offset = "0x972BE0", VA = "0x1809739E0", Slot = "22")]
		set
		{
		}
	}

	[Token(Token = "0x6004EE2")]
	[Address(RVA = "0x973600", Offset = "0x972800", VA = "0x180973600")]
	public MDMarkupTableWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget, MDMarkupTableFactory tableFactory, MDMarkupTableRowFactory rowFactory, MDMarkupTableCellFactory cellFactory)
	{
	}

	[Token(Token = "0x6004EE3")]
	[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60", Slot = "30")]
	public void OnSetupSelectionItem(IMDMarkupFreeScrollHandler freeScrollHandler)
	{
	}

	[Token(Token = "0x6004EE4")]
	[Address(RVA = "0x9714E0", Offset = "0x9706E0", VA = "0x1809714E0", Slot = "17")]
	public override void BindContentData(IMDMarkupContent mdMarkupContent)
	{
	}

	[Token(Token = "0x6004EE5")]
	[Address(RVA = "0x973150", Offset = "0x972350", VA = "0x180973150", Slot = "18")]
	public override void OnReady()
	{
	}

	[Token(Token = "0x6004EE6")]
	[Address(RVA = "0x972FC0", Offset = "0x9721C0", VA = "0x180972FC0", Slot = "28")]
	public void OnConcreatedLayout()
	{
	}

	[Token(Token = "0x6004EE7")]
	[Address(RVA = "0x971330", Offset = "0x970530", VA = "0x180971330", Slot = "29")]
	public void AssignTMPGlyphCreateBuffer(ITextMeshProGlyphCreateBuffer tmpGlyphCreateBuffer)
	{
	}

	[Token(Token = "0x6004EE8")]
	[Address(RVA = "0x9732F0", Offset = "0x9724F0", VA = "0x1809732F0", Slot = "23")]
	public void SetAlignment(TextAlignmentOptions alignment)
	{
	}

	[Token(Token = "0x6004EE9")]
	[Address(RVA = "0x9733F0", Offset = "0x9725F0", VA = "0x1809733F0", Slot = "24")]
	public void SetSizeRate(float sizeRate, [Optional] RectTransform sourceRect)
	{
	}
}
