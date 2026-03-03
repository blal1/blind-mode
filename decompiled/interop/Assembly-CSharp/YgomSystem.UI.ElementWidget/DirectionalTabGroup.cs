using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x2000604")]
[RequireComponent(typeof(Selector))]
public class DirectionalTabGroup : ElementWidgetBehaviourBase<DirectionalTabGroup>
{
	[Token(Token = "0x2000605")]
	public enum Direction
	{
		[Token(Token = "0x4001CFA")]
		None,
		[Token(Token = "0x4001CFB")]
		Next,
		[Token(Token = "0x4001CFC")]
		Back
	}

	[Serializable]
	[Token(Token = "0x2000606")]
	private class ShortcutSetting
	{
		[Token(Token = "0x4001CFD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SelectorManager.KeyType m_KeyType;

		[Token(Token = "0x4001CFE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GamePadIconUtil.Variation m_IconVariation;

		[Token(Token = "0x4001CFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SelectionButton m_ShortcutButton;

		[Token(Token = "0x4001D00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image m_IconImage;

		[Token(Token = "0x170004CE")]
		public SelectorManager.KeyType keyType
		{
			[Token(Token = "0x6002787")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			get
			{
				return default(SelectorManager.KeyType);
			}
		}

		[Token(Token = "0x170004CF")]
		public GamePadIconUtil.Variation iconVariation
		{
			[Token(Token = "0x6002788")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
			get
			{
				return default(GamePadIconUtil.Variation);
			}
		}

		[Token(Token = "0x170004D0")]
		public SelectionButton shortcutButton
		{
			[Token(Token = "0x6002789")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D1")]
		public Image iconImage
		{
			[Token(Token = "0x600278A")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D2")]
		public bool validShortcutKey
		{
			[Token(Token = "0x600278B")]
			[Address(RVA = "0x6ADDB0", Offset = "0x6ACFB0", VA = "0x1806ADDB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600278C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ShortcutSetting()
		{
		}
	}

	[Token(Token = "0x4001CE9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int m_Index;

	[Token(Token = "0x4001CEA")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool m_Horizontal;

	[Token(Token = "0x4001CEB")]
	[FieldOffset(Offset = "0x2D")]
	[SerializeField]
	[Tooltip("確定時に子SelectorのSelectを試みるか")]
	private bool m_TrySelectChildOnDecided;

	[Token(Token = "0x4001CEC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ShortcutSetting m_BackShortcutSetting;

	[Token(Token = "0x4001CED")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ShortcutSetting m_NextShortcutSetting;

	[Token(Token = "0x4001CEE")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[DirectionLinePropertyDraw]
	private SelectionDirectionalTransitionSetting m_EdgeTransition;

	[Token(Token = "0x4001CEF")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<ElementObjectManager> m_TabEoms;

	[Token(Token = "0x4001CF0")]
	[FieldOffset(Offset = "0x50")]
	private SelectionItem m_BlankSelectionItem;

	[Token(Token = "0x4001CF1")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<ElementObjectManager, ToggleWidget> m_TabWidgetMap;

	[Token(Token = "0x4001CF2")]
	[FieldOffset(Offset = "0x60")]
	private Selector m_SelectorCache;

	[Token(Token = "0x4001CF3")]
	[FieldOffset(Offset = "0x68")]
	private bool m_OnChangeIsOnBlocker;

	[Token(Token = "0x4001CF4")]
	[FieldOffset(Offset = "0x69")]
	private bool m_OnSelectedTabBlocker;

	[Token(Token = "0x4001CF5")]
	[FieldOffset(Offset = "0x70")]
	public Action<int, int> onChangedIndex;

	[Token(Token = "0x4001CF6")]
	[FieldOffset(Offset = "0x78")]
	public Action customShortcutMoveSelectCallback;

	[Token(Token = "0x4001CF8")]
	[FieldOffset(Offset = "0x88")]
	private Func<bool> m_RequestedSelectOnBlockedFunc;

	[Token(Token = "0x170004C8")]
	public Selector selector
	{
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x6A7850", Offset = "0x6A6A50", VA = "0x1806A7850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004C9")]
	public int index
	{
		[Token(Token = "0x6002768")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002769")]
		[Address(RVA = "0x6A78E0", Offset = "0x6A6AE0", VA = "0x1806A78E0")]
		set
		{
		}
	}

	[Token(Token = "0x170004CA")]
	public List<ElementObjectManager> tabEoms
	{
		[Token(Token = "0x600276A")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004CB")]
	public ToggleWidget currentTab
	{
		[Token(Token = "0x600276B")]
		[Address(RVA = "0x6A7840", Offset = "0x6A6A40", VA = "0x1806A7840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004CC")]
	public SelectionDirectionalTransitionSetting edgeTransition
	{
		[Token(Token = "0x600276C")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004CD")]
	public bool restoreSelectOnInputBlockedEnabled
	{
		[Token(Token = "0x6002783")]
		[Address(RVA = "0x449800", Offset = "0x448A00", VA = "0x180449800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002784")]
		[Address(RVA = "0x449850", Offset = "0x448A50", VA = "0x180449850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600276D")]
	[Address(RVA = "0x6A6280", Offset = "0x6A5480", VA = "0x1806A6280")]
	private ShortcutSetting GetShortcutSettingByDir(Direction direction)
	{
		return null;
	}

	[Token(Token = "0x600276E")]
	[Address(RVA = "0x6A62A0", Offset = "0x6A54A0", VA = "0x1806A62A0")]
	public ToggleWidget GetTabWidgetAt(int atIdx)
	{
		return null;
	}

	[Token(Token = "0x600276F")]
	[Address(RVA = "0x6A71A0", Offset = "0x6A63A0", VA = "0x1806A71A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002770")]
	[Address(RVA = "0x6A69E0", Offset = "0x6A5BE0", VA = "0x1806A69E0")]
	public bool SelectCurrentTab(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002771")]
	[Address(RVA = "0x6A6200", Offset = "0x6A5400", VA = "0x1806A6200")]
	public bool EnableMoveToDirection(Direction direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6002772")]
	[Address(RVA = "0x6A64E0", Offset = "0x6A56E0", VA = "0x1806A64E0")]
	public bool MoveIdxToDir(Direction direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6002773")]
	[Address(RVA = "0x6A64D0", Offset = "0x6A56D0", VA = "0x1806A64D0")]
	public bool MoveIdxNext()
	{
		return default(bool);
	}

	[Token(Token = "0x6002774")]
	[Address(RVA = "0x6A64C0", Offset = "0x6A56C0", VA = "0x1806A64C0")]
	public bool MoveIdxBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6002775")]
	[Address(RVA = "0x6A6510", Offset = "0x6A5710", VA = "0x1806A6510")]
	public bool MoveIdx(int destIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x6002776")]
	[Address(RVA = "0x6A5E60", Offset = "0x6A5060", VA = "0x1806A5E60")]
	public void ApplyIndex()
	{
	}

	[Token(Token = "0x6002777")]
	[Address(RVA = "0x6A71E0", Offset = "0x6A63E0", VA = "0x1806A71E0")]
	public bool TryRestoreSelectOnInputBlocked()
	{
		return default(bool);
	}

	[Token(Token = "0x6002778")]
	[Address(RVA = "0x6A6C50", Offset = "0x6A5E50", VA = "0x1806A6C50")]
	private void SetupDirectionShortcut(ShortcutSetting shortcutSetting, Direction direction)
	{
	}

	[Token(Token = "0x6002779")]
	[Address(RVA = "0x6A5C80", Offset = "0x6A4E80", VA = "0x1806A5C80")]
	private void ApplyIndexShortcutKey(Direction direction)
	{
	}

	[Token(Token = "0x600277A")]
	[Address(RVA = "0x6A7050", Offset = "0x6A6250", VA = "0x1806A7050")]
	private void SetupTabWidgets()
	{
	}

	[Token(Token = "0x600277B")]
	[Address(RVA = "0x6A6020", Offset = "0x6A5220", VA = "0x1806A6020")]
	private ToggleWidget CreateTabWidget(ElementObjectManager tabEom, int idx)
	{
		return null;
	}

	[Token(Token = "0x600277C")]
	[Address(RVA = "0x6A5D60", Offset = "0x6A4F60", VA = "0x1806A5D60")]
	private void ApplyIndexTabWidgets()
	{
	}

	[Token(Token = "0x600277D")]
	[Address(RVA = "0x6A6A10", Offset = "0x6A5C10", VA = "0x1806A6A10")]
	private void SetupDirectionInput(ToggleWidget tabWidget, PadInputDirection direction)
	{
	}

	[Token(Token = "0x600277E")]
	[Address(RVA = "0x6A6900", Offset = "0x6A5B00", VA = "0x1806A6900")]
	private void OnSelectedTab(ToggleWidget tabWidget)
	{
	}

	[Token(Token = "0x600277F")]
	[Address(RVA = "0x6A66A0", Offset = "0x6A58A0", VA = "0x1806A66A0")]
	private void OnInputDirectionMove(Direction direction)
	{
	}

	[Token(Token = "0x6002780")]
	[Address(RVA = "0x6A6730", Offset = "0x6A5930", VA = "0x1806A6730")]
	private void OnInputEdgeDirection(ToggleWidget tabWidget, PadInputDirection padInputDirection)
	{
	}

	[Token(Token = "0x6002781")]
	[Address(RVA = "0x6A6800", Offset = "0x6A5A00", VA = "0x1806A6800")]
	private void OnInputShortcutMove(Direction direction)
	{
	}

	[Token(Token = "0x6002782")]
	[Address(RVA = "0x6A65C0", Offset = "0x6A57C0", VA = "0x1806A65C0")]
	private void OnChangeTabValue(bool isOn, int idx)
	{
	}

	[Token(Token = "0x6002785")]
	[Address(RVA = "0x6A7240", Offset = "0x6A6440", VA = "0x1806A7240")]
	private bool TrySelectChildSelector(bool initializeSelection)
	{
		return default(bool);
	}

	[Token(Token = "0x6002786")]
	[Address(RVA = "0x6A76D0", Offset = "0x6A68D0", VA = "0x1806A76D0")]
	public DirectionalTabGroup()
	{
	}
}
