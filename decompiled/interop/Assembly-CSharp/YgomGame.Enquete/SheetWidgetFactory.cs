using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E27")]
public class SheetWidgetFactory
{
	[Token(Token = "0x400A252")]
	[FieldOffset(Offset = "0x10")]
	private readonly Transform m_Owner;

	[Token(Token = "0x400A253")]
	[FieldOffset(Offset = "0x18")]
	private readonly Dictionary<SheetContentType, ElementObjectManager> m_WidgetTemplates;

	[Token(Token = "0x60055BE")]
	[Address(RVA = "0x9C2540", Offset = "0x9C1740", VA = "0x1809C2540")]
	public SheetWidgetFactory(Transform owner)
	{
	}

	[Token(Token = "0x60055BF")]
	[Address(RVA = "0x9C0F60", Offset = "0x9C0160", VA = "0x1809C0F60")]
	public void AssignTemplate(SheetContentType sheetContentType, ElementObjectManager template)
	{
	}

	[Token(Token = "0x60055C0")]
	[Address(RVA = "0x9C1010", Offset = "0x9C0210", VA = "0x1809C1010")]
	public ISheetContentWidget Create(ISheetContentContext sheetContentContext, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60055C1")]
	[Address(RVA = "0x9C1B50", Offset = "0x9C0D50", VA = "0x1809C1B50")]
	private ISheetContentWidget SetGroupWidget(ElementObjectManager eom, SheetContentSpacerContext context)
	{
		return null;
	}

	[Token(Token = "0x60055C2")]
	[Address(RVA = "0x9C19F0", Offset = "0x9C0BF0", VA = "0x1809C19F0")]
	private ISheetContentWidget SetGroupWidget(ElementObjectManager eom, SheetContentGroupContext context)
	{
		return null;
	}

	[Token(Token = "0x60055C3")]
	[Address(RVA = "0x9C18F0", Offset = "0x9C0AF0", VA = "0x1809C18F0")]
	private ISheetContentWidget SetCaptionWidget(ElementObjectManager eom, SheetContentCaptionContext context)
	{
		return null;
	}

	[Token(Token = "0x60055C4")]
	[Address(RVA = "0x9C2330", Offset = "0x9C1530", VA = "0x1809C2330")]
	private ISheetContentWidget SetTextWidget(ElementObjectManager eom, SheetContentTextContext context)
	{
		return null;
	}

	[Token(Token = "0x60055C5")]
	[Address(RVA = "0x9C1BD0", Offset = "0x9C0DD0", VA = "0x1809C1BD0")]
	private ISheetContentWidget SetInputAmountWidget(ElementObjectManager eom, SheetContentInputAmountContext context)
	{
		return null;
	}

	[Token(Token = "0x60055C6")]
	[Address(RVA = "0x9C1F80", Offset = "0x9C1180", VA = "0x1809C1F80")]
	private ISheetContentWidget SetInputCheckBoxWidget(ElementObjectManager eom, SheetContentInputCheckBoxContext context)
	{
		return null;
	}

	[Token(Token = "0x60055C7")]
	[Address(RVA = "0x9C22A0", Offset = "0x9C14A0", VA = "0x1809C22A0")]
	private ISheetContentWidget SetInputTextWidget(ElementObjectManager eom, SheetContentInputTextContext context)
	{
		return null;
	}

	[Token(Token = "0x60055C8")]
	[Address(RVA = "0x9C21B0", Offset = "0x9C13B0", VA = "0x1809C21B0")]
	private ISheetContentWidget SetInputTextConfirmWidget(ElementObjectManager eom, SheetContentInputTextConfirmContext context)
	{
		return null;
	}

	[Token(Token = "0x60055C9")]
	[Address(RVA = "0x9C1D70", Offset = "0x9C0F70", VA = "0x1809C1D70")]
	private ISheetContentWidget SetInputCardWidget(ElementObjectManager eom, SheetContentInputCardContext context)
	{
		return null;
	}
}
