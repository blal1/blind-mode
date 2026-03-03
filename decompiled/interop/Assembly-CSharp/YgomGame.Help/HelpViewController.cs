using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Help;

[Token(Token = "0x2000D94")]
public class HelpViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000D95")]
	private class SectionContext
	{
		[Token(Token = "0x4009F59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x4009F5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string groupLabel;

		[Token(Token = "0x4009F5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sectionLabel;

		[Token(Token = "0x60051AA")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public SectionContext()
		{
		}
	}

	[Token(Token = "0x2000D96")]
	private class SectionWidget : ElementWidgetBase
	{
		[Token(Token = "0x4009F5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string k_ELabelText;

		[Token(Token = "0x4009F5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string k_ELabelButton;

		[Token(Token = "0x4009F5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string k_ELabelOn;

		[Token(Token = "0x4009F5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string k_ELabelOff;

		[Token(Token = "0x4009F60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly TextMeshProUGUI text;

		[Token(Token = "0x4009F61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly SelectionButton button;

		[Token(Token = "0x4009F62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly string k_ELabelOffText;

		[Token(Token = "0x4009F63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly TextMeshProUGUI textOff;

		[Token(Token = "0x14000074")]
		public event Action<SectionWidget> onClickEvent
		{
			[Token(Token = "0x60051AB")]
			[Address(RVA = "0x9964F0", Offset = "0x9956F0", VA = "0x1809964F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051AC")]
			[Address(RVA = "0x9967B0", Offset = "0x9959B0", VA = "0x1809967B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000075")]
		public event Action<SectionWidget> onSelectedEvent
		{
			[Token(Token = "0x60051AD")]
			[Address(RVA = "0x996700", Offset = "0x995900", VA = "0x180996700")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051AE")]
			[Address(RVA = "0x9969C0", Offset = "0x995BC0", VA = "0x1809969C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000076")]
		public event Action<SectionWidget> onRightEvent
		{
			[Token(Token = "0x60051AF")]
			[Address(RVA = "0x996650", Offset = "0x995850", VA = "0x180996650")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051B0")]
			[Address(RVA = "0x996910", Offset = "0x995B10", VA = "0x180996910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000077")]
		public event Action<SectionWidget> onLeftEvent
		{
			[Token(Token = "0x60051B1")]
			[Address(RVA = "0x9965A0", Offset = "0x9957A0", VA = "0x1809965A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051B2")]
			[Address(RVA = "0x996860", Offset = "0x995A60", VA = "0x180996860")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60051B3")]
		[Address(RVA = "0x9961C0", Offset = "0x9953C0", VA = "0x1809961C0")]
		public SectionWidget(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x60051B4")]
		[Address(RVA = "0x996110", Offset = "0x995310", VA = "0x180996110")]
		public void SetIsOn(bool isOn)
		{
		}

		[Token(Token = "0x60051B5")]
		[Address(RVA = "0x91EA40", Offset = "0x91DC40", VA = "0x18091EA40")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60051B6")]
		[Address(RVA = "0x91F830", Offset = "0x91EA30", VA = "0x18091F830")]
		private void OnSelected()
		{
		}

		[Token(Token = "0x60051B7")]
		[Address(RVA = "0x81B640", Offset = "0x81A840", VA = "0x18081B640")]
		private void OnRight()
		{
		}

		[Token(Token = "0x60051B8")]
		[Address(RVA = "0x81B620", Offset = "0x81A820", VA = "0x18081B620")]
		private void OnLeft()
		{
		}
	}

	[Token(Token = "0x2000D97")]
	private class RecordContext
	{
		[Token(Token = "0x4009F68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x4009F69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string path;

		[Token(Token = "0x60051B9")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public RecordContext()
		{
		}
	}

	[Token(Token = "0x2000D98")]
	private class RecordWidget : SectionWidget
	{
		[Token(Token = "0x60051BA")]
		[Address(RVA = "0x995EC0", Offset = "0x9950C0", VA = "0x180995EC0")]
		public RecordWidget(ElementObjectManager eom)
		{
		}
	}

	[Token(Token = "0x4009F47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelSectionList;

	[Token(Token = "0x4009F48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelRecordList;

	[Token(Token = "0x4009F49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ElabelBackShortCutbutton;

	[Token(Token = "0x4009F4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool m_nowRecordSelected;

	[Token(Token = "0x4009F4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private readonly int k_SectionGroupTNo;

	[Token(Token = "0x4009F4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly int k_SectionButtonTNo;

	[Token(Token = "0x4009F4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private readonly int k_SectionSpacerTNo;

	[Token(Token = "0x4009F4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private HelpMappingData m_HelpMapping;

	[Token(Token = "0x4009F4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private InfinityScrollView m_SectionScrollView;

	[Token(Token = "0x4009F50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Selector m_SectionSelector;

	[Token(Token = "0x4009F51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private List<SectionContext> m_SectionContexts;

	[Token(Token = "0x4009F52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private List<int> m_SectionTemplates;

	[Token(Token = "0x4009F53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Dictionary<GameObject, SectionWidget> m_SectionEntityMap;

	[Token(Token = "0x4009F54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private InfinityScrollView m_RecordScrollView;

	[Token(Token = "0x4009F55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private List<RecordContext> m_RecordContexts;

	[Token(Token = "0x4009F56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Dictionary<GameObject, RecordWidget> m_RecordEntityMap;

	[Token(Token = "0x4009F57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private List<string> m_LoadedTextGroups;

	[Token(Token = "0x4009F58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int m_CurrentSectionIdx;

	[Token(Token = "0x17000BDA")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6005193")]
		[Address(RVA = "0x992E00", Offset = "0x992000", VA = "0x180992E00", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005194")]
	[Address(RVA = "0x992170", Offset = "0x991370", VA = "0x180992170")]
	public static void Open()
	{
	}

	[Token(Token = "0x6005195")]
	[Address(RVA = "0x991E20", Offset = "0x991020", VA = "0x180991E20")]
	public static void OpenHelp(string labelPath, [Optional] Action callback, bool isOverlay = true, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6005196")]
	[Address(RVA = "0x992000", Offset = "0x991200", VA = "0x180992000")]
	public static void OpenHelp(string groupLabel, string sectionLabel, string recordLabel, [Optional] Action callback, bool isOverlay = true, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6005197")]
	[Address(RVA = "0x990D50", Offset = "0x98FF50", VA = "0x180990D50", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6005198")]
	[Address(RVA = "0x9915A0", Offset = "0x9907A0", VA = "0x1809915A0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6005199")]
	[Address(RVA = "0x990F10", Offset = "0x990110", VA = "0x180990F10", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600519A")]
	[Address(RVA = "0x992530", Offset = "0x991730", VA = "0x180992530")]
	private void Start()
	{
	}

	[Token(Token = "0x600519B")]
	[Address(RVA = "0x990DE0", Offset = "0x98FFE0", VA = "0x180990DE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600519C")]
	[Address(RVA = "0x9921D0", Offset = "0x9913D0", VA = "0x1809921D0")]
	private void SelectSection(int sectionIdx)
	{
	}

	[Token(Token = "0x600519D")]
	[Address(RVA = "0x990B60", Offset = "0x98FD60", VA = "0x180990B60")]
	private string GetTextData(string sourceTextId)
	{
		return null;
	}

	[Token(Token = "0x600519E")]
	[Address(RVA = "0x991320", Offset = "0x990520", VA = "0x180991320")]
	private void OnCreatedSectionEntity(GameObject entity)
	{
	}

	[Token(Token = "0x600519F")]
	[Address(RVA = "0x990CF0", Offset = "0x98FEF0", VA = "0x180990CF0")]
	private bool IsSelectableDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x60051A0")]
	[Address(RVA = "0x991C10", Offset = "0x990E10", VA = "0x180991C10")]
	private void OnUpdateSectionEntity(GameObject entity, int idx)
	{
	}

	[Token(Token = "0x60051A1")]
	[Address(RVA = "0x991030", Offset = "0x990230", VA = "0x180991030")]
	private void OnClickSectionEntity(SectionWidget sectionWidget)
	{
	}

	[Token(Token = "0x60051A2")]
	[Address(RVA = "0x9919E0", Offset = "0x990BE0", VA = "0x1809919E0")]
	private void OnSelectedSectionEntity(SectionWidget sectionWidget)
	{
	}

	[Token(Token = "0x60051A3")]
	[Address(RVA = "0x991140", Offset = "0x990340", VA = "0x180991140")]
	private void OnCreatedRecordEntity(GameObject entity)
	{
	}

	[Token(Token = "0x60051A4")]
	[Address(RVA = "0x991AC0", Offset = "0x990CC0", VA = "0x180991AC0")]
	private void OnUpdateRecordEntity(GameObject entity, int idx)
	{
	}

	[Token(Token = "0x60051A5")]
	[Address(RVA = "0x990F70", Offset = "0x990170", VA = "0x180990F70")]
	private void OnClickRecordEntity(SectionWidget recordWidget)
	{
	}

	[Token(Token = "0x60051A6")]
	[Address(RVA = "0x991990", Offset = "0x990B90", VA = "0x180991990")]
	private void OnLeftRecordEntity(SectionWidget sectionWidget)
	{
	}

	[Token(Token = "0x60051A7")]
	[Address(RVA = "0x992B60", Offset = "0x991D60", VA = "0x180992B60")]
	public HelpViewController()
	{
	}
}
