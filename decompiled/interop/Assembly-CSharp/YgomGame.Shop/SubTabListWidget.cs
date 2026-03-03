using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x200096C")]
public class SubTabListWidget : ElementWidgetBase
{
	[Token(Token = "0x200096D")]
	public class TabContext
	{
		[Token(Token = "0x4008BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IShopProductGruopData groupData;

		[Token(Token = "0x4008BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x4008BA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool badge;

		[Token(Token = "0x4008BA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<TabContext> children;

		[Token(Token = "0x1700078B")]
		public bool hasChildren
		{
			[Token(Token = "0x6003993")]
			[Address(RVA = "0x807B40", Offset = "0x806D40", VA = "0x180807B40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6003994")]
		[Address(RVA = "0x807970", Offset = "0x806B70", VA = "0x180807970")]
		public TabContext(IShopProductGruopData groupData, string label)
		{
		}

		[Token(Token = "0x6003995")]
		[Address(RVA = "0x807A30", Offset = "0x806C30", VA = "0x180807A30")]
		public TabContext(IShopProductGruopData setting, string label, List<TabContext> children)
		{
		}
	}

	[Token(Token = "0x4008B95")]
	internal const int k_TemplateId_Single = 0;

	[Token(Token = "0x4008B96")]
	internal const int k_TemplateId_Group = 1;

	[Token(Token = "0x4008B97")]
	private const string k_ELabelTabsList = "TabsList";

	[Token(Token = "0x4008B98")]
	private const string k_TLabel_ShowNext = "ShowNext";

	[Token(Token = "0x4008B99")]
	private const string k_TLabel_ShowBack = "ShowBack";

	[Token(Token = "0x4008B9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly ElementEntityFactory m_EntityFactory;

	[Token(Token = "0x4008B9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly SnapScrollView m_ScrollView;

	[Token(Token = "0x4008B9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<GameObject, ISubTabWidget> m_TabWidgetMap;

	[Token(Token = "0x4008B9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<int, Dictionary<int, bool>> m_AcordionValueMap;

	[Token(Token = "0x4008B9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<int, Dictionary<int, bool>> m_AcordionManualMap;

	[Token(Token = "0x4008B9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ISubTabListWidgetHandler m_Handler;

	[Token(Token = "0x4008BA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ISubTabListWidgetListener m_Listener;

	[Token(Token = "0x4008BA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> m_TemplateIds;

	[Token(Token = "0x4008BA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public readonly Selector selector;

	[Token(Token = "0x1700078A")]
	public int dataCount
	{
		[Token(Token = "0x6003974")]
		[Address(RVA = "0x8078B0", Offset = "0x806AB0", VA = "0x1808078B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6003975")]
	[Address(RVA = "0x805400", Offset = "0x804600", VA = "0x180805400")]
	public bool GetAcordionValue(int categoryId, int subCategoryId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003976")]
	[Address(RVA = "0x807360", Offset = "0x806560", VA = "0x180807360")]
	public void SetAcordionValue(int categoryId, int subCategoryId, bool value)
	{
	}

	[Token(Token = "0x6003977")]
	[Address(RVA = "0x805300", Offset = "0x804500", VA = "0x180805300")]
	public bool GetAcordionManualFlag(int categoryId, int subCategoryId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003978")]
	[Address(RVA = "0x807100", Offset = "0x806300", VA = "0x180807100")]
	public void SetAcordionManualFlag(int categoryId, int subCategoryId, bool value)
	{
	}

	[Token(Token = "0x6003979")]
	[Address(RVA = "0x805660", Offset = "0x804860", VA = "0x180805660")]
	public ISubTabWidget GetSubTabWidget(int dataIdx)
	{
		return null;
	}

	[Token(Token = "0x600397A")]
	[Address(RVA = "0x805500", Offset = "0x804700", VA = "0x180805500")]
	public SubTabGroupWidget GetGroupWidgetByDataIdx(int dataIdx)
	{
		return null;
	}

	[Token(Token = "0x600397B")]
	[Address(RVA = "0x805590", Offset = "0x804790", VA = "0x180805590")]
	public SubTabSingleWidget GetSectionWidget(SubTabGroupWidget groupWidget, int sectionIdx)
	{
		return null;
	}

	[Token(Token = "0x600397C")]
	[Address(RVA = "0x807680", Offset = "0x806880", VA = "0x180807680")]
	public SubTabListWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600397D")]
	[Address(RVA = "0x805720", Offset = "0x804920", VA = "0x180805720")]
	public void Init(ISubTabListWidgetHandler handler, ISubTabListWidgetListener listener)
	{
	}

	[Token(Token = "0x600397E")]
	[Address(RVA = "0x8074F0", Offset = "0x8066F0", VA = "0x1808074F0")]
	public void StopMovement()
	{
	}

	[Token(Token = "0x600397F")]
	[Address(RVA = "0x806DE0", Offset = "0x805FE0", VA = "0x180806DE0")]
	public void ResetPos()
	{
	}

	[Token(Token = "0x6003980")]
	[Address(RVA = "0x807530", Offset = "0x806730", VA = "0x180807530")]
	public void UpdateDataCount()
	{
	}

	[Token(Token = "0x6003981")]
	[Address(RVA = "0x807660", Offset = "0x806860", VA = "0x180807660")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x6003982")]
	[Address(RVA = "0x806C80", Offset = "0x805E80", VA = "0x180806C80")]
	public void PlayShow(bool isNext)
	{
	}

	[Token(Token = "0x6003983")]
	[Address(RVA = "0x806E00", Offset = "0x806000", VA = "0x180806E00")]
	public bool SelectCurrentIdx(bool isInitializeSelect = false, bool selectSection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003984")]
	[Address(RVA = "0x804FF0", Offset = "0x8041F0", VA = "0x180804FF0")]
	public bool FocusCurrentIdx(bool containSection = false, bool selectItem = false, bool initializeSelection = false, bool immediate = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003985")]
	[Address(RVA = "0x804CE0", Offset = "0x803EE0", VA = "0x180804CE0")]
	public bool CheckRecoverSelectItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6003986")]
	[Address(RVA = "0x805BC0", Offset = "0x804DC0", VA = "0x180805BC0")]
	private void OnCreatedEntity(GameObject entity, int templateIdx, [Optional] SubTabGroupWidget parentGroup)
	{
	}

	[Token(Token = "0x6003987")]
	[Address(RVA = "0x8058F0", Offset = "0x804AF0", VA = "0x1808058F0")]
	private void OnActivateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x6003988")]
	[Address(RVA = "0x805E50", Offset = "0x805050", VA = "0x180805E50")]
	private void OnDeactivateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x6003989")]
	[Address(RVA = "0x805AC0", Offset = "0x804CC0", VA = "0x180805AC0")]
	private SubTabSingleWidget OnCreatedEntitySingle(GameObject entity, [Optional] SubTabGroupWidget parentGroup)
	{
		return null;
	}

	[Token(Token = "0x600398A")]
	[Address(RVA = "0x805960", Offset = "0x804B60", VA = "0x180805960")]
	private SubTabGroupWidget OnCreatedEntityGroup(GameObject entity)
	{
		return null;
	}

	[Token(Token = "0x600398B")]
	[Address(RVA = "0x806B20", Offset = "0x805D20", VA = "0x180806B20")]
	private void OnUpdateEntity(GameObject entity, int dataIdx)
	{
	}

	[Token(Token = "0x600398C")]
	[Address(RVA = "0x806940", Offset = "0x805B40", VA = "0x180806940")]
	private void OnUpdateEntitySignle(SubTabSingleWidget widget, int dataIdx)
	{
	}

	[Token(Token = "0x600398D")]
	[Address(RVA = "0x806300", Offset = "0x805500", VA = "0x180806300")]
	private void OnUpdateEntityGroup(SubTabGroupWidget widget, int dataIdx)
	{
	}

	[Token(Token = "0x600398E")]
	[Address(RVA = "0x805940", Offset = "0x804B40", VA = "0x180805940")]
	private void OnCreatedEntityGroupSection(GameObject sectionEntity, [Optional] SubTabGroupWidget parentGroup)
	{
	}

	[Token(Token = "0x600398F")]
	[Address(RVA = "0x805F60", Offset = "0x805160", VA = "0x180805F60")]
	private void OnUpdateEntityGroupSection(GameObject sectionEntity, int dataIdx, int sectionDataIdx)
	{
	}

	[Token(Token = "0x6003990")]
	[Address(RVA = "0x805EA0", Offset = "0x8050A0", VA = "0x180805EA0")]
	private bool OnInputDirection(PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6003991")]
	[Address(RVA = "0x805F50", Offset = "0x805150", VA = "0x180805F50")]
	private bool OnSelectorSelected(bool initializeSelection = false)
	{
		return default(bool);
	}
}
