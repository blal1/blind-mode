using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F39")]
public class MainTabWidget : ElementWidgetBase
{
	[Token(Token = "0x2000F3A")]
	public class TabContext
	{
		[Token(Token = "0x400A6C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IDuelLiveProductGruopData groupData;

		[Token(Token = "0x400A6C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x400A6CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool badge;

		[Token(Token = "0x400A6CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isActive;

		[Token(Token = "0x400A6CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isHighlight;

		[Token(Token = "0x400A6CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public DuelLiveDef.MainTabButtonType mainTabButtonType;

		[Token(Token = "0x400A6CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int bgPathId;

		[Token(Token = "0x6005C58")]
		[Address(RVA = "0xA2B3A0", Offset = "0xA2A5A0", VA = "0x180A2B3A0")]
		public TabContext(IDuelLiveProductGruopData groupData, string label, bool isHighlight, int bgPathId)
		{
		}
	}

	[Token(Token = "0x400A6C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DuelLiveRootWidget m_Owner;

	[Token(Token = "0x400A6C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly Selector selector;

	[Token(Token = "0x400A6C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int defaultIdx;

	[Token(Token = "0x400A6C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private DirectionalTabGroup m_DirectionalTab;

	[Token(Token = "0x400A6C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<ToggleWidget, List<Tween>> tweenMap;

	[Token(Token = "0x400A6C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Dictionary<ToggleWidget, bool> tweenDirtyMap;

	[Token(Token = "0x400A6C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<int> disactiveIndexList;

	[Token(Token = "0x17000E7B")]
	public DirectionalTabGroup directionalTab
	{
		[Token(Token = "0x6005C50")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E7C")]
	public bool isActiveMainTab
	{
		[Token(Token = "0x6005C51")]
		[Address(RVA = "0xA1F440", Offset = "0xA1E640", VA = "0x180A1F440")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000E7D")]
	public int currentTabIndex
	{
		[Token(Token = "0x6005C52")]
		[Address(RVA = "0xA1F2D0", Offset = "0xA1E4D0", VA = "0x180A1F2D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6005C53")]
	[Address(RVA = "0xA1F210", Offset = "0xA1E410", VA = "0x180A1F210")]
	public MainTabWidget(ElementObjectManager eom, DuelLiveRootWidget owner)
	{
	}

	[Token(Token = "0x6005C54")]
	[Address(RVA = "0xA1EDF0", Offset = "0xA1DFF0", VA = "0x180A1EDF0")]
	public void Init()
	{
	}

	[Token(Token = "0x6005C55")]
	[Address(RVA = "0xA1E1D0", Offset = "0xA1D3D0", VA = "0x180A1E1D0")]
	private void CreateTab()
	{
	}

	[Token(Token = "0x6005C56")]
	[Address(RVA = "0xA1EE00", Offset = "0xA1E000", VA = "0x180A1EE00")]
	public void SetIsOn()
	{
	}

	[Token(Token = "0x6005C57")]
	[Address(RVA = "0xA1EF50", Offset = "0xA1E150", VA = "0x180A1EF50")]
	public void UpdateBadge(List<TabContext> contexts, [Optional] Dictionary<int, bool> isAllItemVisit)
	{
	}
}
