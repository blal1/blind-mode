using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x2000973")]
public class SubTabSingleWidget : ElementWidgetBase, ISubTabWidget
{
	[Token(Token = "0x4008BB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly SubTabGroupWidget m_ParentGroupWidget;

	[Token(Token = "0x4008BB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly ShopTabWidget m_TabWidget;

	[Token(Token = "0x1700078E")]
	public ShopTabWidget tabWidget
	{
		[Token(Token = "0x60039A4")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700078F")]
	public SubTabGroupWidget parentGroup
	{
		[Token(Token = "0x60039A5")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60039A6")]
	[Address(RVA = "0x8078D0", Offset = "0x806AD0", VA = "0x1808078D0")]
	public SubTabSingleWidget(ElementObjectManager eom, [Optional] SubTabGroupWidget parentGroupWidget)
	{
	}
}
