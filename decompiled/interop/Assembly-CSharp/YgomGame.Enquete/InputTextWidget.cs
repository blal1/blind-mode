using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E1C")]
public class InputTextWidget : SheetContentWidget, ISheetContentCompleteCheckWidget
{
	[Token(Token = "0x400A22A")]
	[FieldOffset(Offset = "0x28")]
	public readonly InputFieldWidget inputField;

	[Token(Token = "0x400A22B")]
	[FieldOffset(Offset = "0x30")]
	private readonly Text m_ValidatedText;

	[Token(Token = "0x17000CBF")]
	public bool isInputComplete
	{
		[Token(Token = "0x600557D")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600557E")]
		[Address(RVA = "0x406E80", Offset = "0x406080", VA = "0x180406E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000086")]
	public event Action onChangeComplete
	{
		[Token(Token = "0x600557F")]
		[Address(RVA = "0x9BC8F0", Offset = "0x9BBAF0", VA = "0x1809BC8F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005580")]
		[Address(RVA = "0x9BC990", Offset = "0x9BBB90", VA = "0x1809BC990", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6005581")]
	[Address(RVA = "0x9BC710", Offset = "0x9BB910", VA = "0x1809BC710")]
	public InputTextWidget(ElementObjectManager eom, string label, int limit)
	{
	}

	[Token(Token = "0x6005582")]
	[Address(RVA = "0x9BC400", Offset = "0x9BB600", VA = "0x1809BC400", Slot = "14")]
	public override void ImportInputValues(Dictionary<string, object> importValues)
	{
	}

	[Token(Token = "0x6005583")]
	[Address(RVA = "0x9BC300", Offset = "0x9BB500", VA = "0x1809BC300", Slot = "16")]
	public override void CollectInputValues(Dictionary<string, object> resultValues)
	{
	}

	[Token(Token = "0x6005584")]
	[Address(RVA = "0x9BC3C0", Offset = "0x9BB5C0", VA = "0x1809BC3C0", Slot = "15")]
	public override void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap)
	{
	}

	[Token(Token = "0x6005585")]
	[Address(RVA = "0x9BC640", Offset = "0x9BB840", VA = "0x1809BC640")]
	public void ToValidatedText()
	{
	}

	[Token(Token = "0x6005586")]
	[Address(RVA = "0x9BC5F0", Offset = "0x9BB7F0", VA = "0x1809BC5F0")]
	private void OnValueChanged(string value)
	{
	}
}
