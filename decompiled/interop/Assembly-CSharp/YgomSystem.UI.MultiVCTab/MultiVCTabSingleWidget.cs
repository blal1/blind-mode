using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005F2")]
public class MultiVCTabSingleWidget : ElementWidgetBase, ISubTabWidget
{
	[Token(Token = "0x4001C89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly MultiVCTabGroupWidget m_ParentGroupWidget;

	[Token(Token = "0x4001C8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly MultiVCTabWidget m_TabWidget;

	[Token(Token = "0x170004B3")]
	public MultiVCTabWidget tabWidget
	{
		[Token(Token = "0x60026FD")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004B4")]
	public MultiVCTabGroupWidget parentGroup
	{
		[Token(Token = "0x60026FE")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60026FF")]
	[Address(RVA = "0x698B50", Offset = "0x697D50", VA = "0x180698B50")]
	public MultiVCTabSingleWidget(ElementObjectManager eom, [Optional] MultiVCTabGroupWidget parentGroupWidget)
	{
	}
}
