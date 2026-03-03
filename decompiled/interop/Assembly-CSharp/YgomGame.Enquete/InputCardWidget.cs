using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using YgomGame.CardSelect;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E19")]
public class InputCardWidget : SheetContentWidget, ISheetContentCompleteCheckWidget, ISheetAsyncInitializeContentWidget, ISheetInputDirectionWidget
{
	[Token(Token = "0x400A21C")]
	[FieldOffset(Offset = "0x28")]
	public readonly CardSelectHolderWidget cardSelectHolderWidget;

	[Token(Token = "0x400A21D")]
	[FieldOffset(Offset = "0x30")]
	public readonly TMP_Text descText;

	[Token(Token = "0x17000CBB")]
	public bool isInputComplete
	{
		[Token(Token = "0x6005562")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005563")]
		[Address(RVA = "0x406E80", Offset = "0x406080", VA = "0x180406E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000CBC")]
	public Func<SelectionItem, PadInputDirection, bool> onInputDirectionFunc
	{
		[Token(Token = "0x6005564")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005565")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x14000083")]
	public event Action onChangeComplete
	{
		[Token(Token = "0x6005566")]
		[Address(RVA = "0x9BB960", Offset = "0x9BAB60", VA = "0x1809BB960", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005567")]
		[Address(RVA = "0x9BBA00", Offset = "0x9BAC00", VA = "0x1809BBA00", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6005568")]
	[Address(RVA = "0x9BB7F0", Offset = "0x9BA9F0", VA = "0x1809BB7F0")]
	public InputCardWidget(ElementObjectManager eom, string label)
	{
	}

	[Token(Token = "0x6005569")]
	[Address(RVA = "0x9BB4D0", Offset = "0x9BA6D0", VA = "0x1809BB4D0", Slot = "20")]
	public void InitializeAsync(Action onComplete)
	{
	}

	[Token(Token = "0x600556A")]
	[Address(RVA = "0x9BB4A0", Offset = "0x9BA6A0", VA = "0x1809BB4A0", Slot = "15")]
	public override void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap)
	{
	}

	[Token(Token = "0x600556B")]
	[Address(RVA = "0x9BB400", Offset = "0x9BA600", VA = "0x1809BB400", Slot = "16")]
	public override void CollectInputValues(Dictionary<string, object> resultValues)
	{
	}

	[Token(Token = "0x600556C")]
	[Address(RVA = "0x9BB6E0", Offset = "0x9BA8E0", VA = "0x1809BB6E0")]
	private bool OnCustomEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x600556D")]
	[Address(RVA = "0x9BB5D0", Offset = "0x9BA7D0", VA = "0x1809BB5D0")]
	private void OnClickButton()
	{
	}
}
