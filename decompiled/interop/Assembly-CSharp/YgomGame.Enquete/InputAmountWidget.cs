using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E16")]
public class InputAmountWidget : SheetContentWidget, ISheetContentCompleteCheckWidget
{
	[Token(Token = "0x2000E17")]
	public class ToggleWidget : SheetContentWidget
	{
		[Token(Token = "0x400A217")]
		[FieldOffset(Offset = "0x28")]
		public readonly YgomSystem.UI.ElementWidget.ToggleWidget toggle;

		[Token(Token = "0x400A218")]
		[FieldOffset(Offset = "0x30")]
		public readonly int idx;

		[Token(Token = "0x14000082")]
		public event Action<ToggleWidget> onChangedValue
		{
			[Token(Token = "0x600555B")]
			[Address(RVA = "0x9C36F0", Offset = "0x9C28F0", VA = "0x1809C36F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600555C")]
			[Address(RVA = "0x9C37A0", Offset = "0x9C29A0", VA = "0x1809C37A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600555D")]
		[Address(RVA = "0x9C35F0", Offset = "0x9C27F0", VA = "0x1809C35F0")]
		public ToggleWidget(ElementObjectManager eom, int idx)
		{
		}

		[Token(Token = "0x600555E")]
		[Address(RVA = "0x9B9A50", Offset = "0x9B8C50", VA = "0x1809B9A50")]
		private void OnChangeValue(bool isOn)
		{
		}
	}

	[Token(Token = "0x400A214")]
	[FieldOffset(Offset = "0x28")]
	public readonly ToggleWidget[] toggleWidgets;

	[Token(Token = "0x17000CB7")]
	public int currentAmount
	{
		[Token(Token = "0x6005552")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005553")]
		[Address(RVA = "0x4A69B0", Offset = "0x4A5BB0", VA = "0x1804A69B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000CB8")]
	public TMP_Text minText
	{
		[Token(Token = "0x6005554")]
		[Address(RVA = "0x9BB300", Offset = "0x9BA500", VA = "0x1809BB300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CB9")]
	public TMP_Text maxText
	{
		[Token(Token = "0x6005555")]
		[Address(RVA = "0x9BB2A0", Offset = "0x9BA4A0", VA = "0x1809BB2A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CBA")]
	public bool isInputComplete
	{
		[Token(Token = "0x6005556")]
		[Address(RVA = "0x9BB290", Offset = "0x9BA490", VA = "0x1809BB290", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000081")]
	public event Action onChangeComplete
	{
		[Token(Token = "0x6005550")]
		[Address(RVA = "0x9BB1F0", Offset = "0x9BA3F0", VA = "0x1809BB1F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005551")]
		[Address(RVA = "0x9BB360", Offset = "0x9BA560", VA = "0x1809BB360", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6005557")]
	[Address(RVA = "0x9BADC0", Offset = "0x9B9FC0", VA = "0x1809BADC0")]
	public InputAmountWidget(ElementObjectManager eom, string label, int amountLength)
	{
	}

	[Token(Token = "0x6005558")]
	[Address(RVA = "0x9BACA0", Offset = "0x9B9EA0", VA = "0x1809BACA0")]
	private void OnToggleChangeValue(ToggleWidget toggle)
	{
	}

	[Token(Token = "0x6005559")]
	[Address(RVA = "0x9BAA20", Offset = "0x9B9C20", VA = "0x1809BAA20", Slot = "16")]
	public override void CollectInputValues(Dictionary<string, object> resultValues)
	{
	}

	[Token(Token = "0x600555A")]
	[Address(RVA = "0x9BAAD0", Offset = "0x9B9CD0", VA = "0x1809BAAD0", Slot = "15")]
	public override void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap)
	{
	}
}
