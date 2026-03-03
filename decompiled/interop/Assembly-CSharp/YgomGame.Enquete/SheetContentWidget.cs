using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E24")]
public class SheetContentWidget : ElementWidgetBase, ISheetContentWidget
{
	[Token(Token = "0x400A246")]
	[FieldOffset(Offset = "0x20")]
	public string label;

	[Token(Token = "0x17000CC7")]
	private string YgomGame_002EEnquete_002EISheetContentWidget_002Elabel
	{
		[Token(Token = "0x600559F")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60055A0")]
	[Address(RVA = "0x975170", Offset = "0x974370", VA = "0x180975170")]
	public SheetContentWidget(ElementObjectManager eom, string label)
	{
	}

	[Token(Token = "0x60055A1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	public virtual void ImportInputValues(Dictionary<string, object> importValues)
	{
	}

	[Token(Token = "0x60055A2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
	public virtual void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap)
	{
	}

	[Token(Token = "0x60055A3")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "16")]
	public virtual void CollectInputValues(Dictionary<string, object> resultValues)
	{
	}
}
