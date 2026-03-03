using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E1A")]
public class InputCheckBoxWidget : SheetContentWidget, ISheetContentCompleteCheckWidget
{
	[Token(Token = "0x2000E1B")]
	public class EntityWidget : SheetContentWidget
	{
		[Token(Token = "0x400A227")]
		[FieldOffset(Offset = "0x28")]
		public readonly int idx;

		[Token(Token = "0x400A228")]
		[FieldOffset(Offset = "0x30")]
		public readonly ToggleWidget toggle;

		[Token(Token = "0x17000CBE")]
		public TMP_Text text
		{
			[Token(Token = "0x6005577")]
			[Address(RVA = "0x9B9C80", Offset = "0x9B8E80", VA = "0x1809B9C80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000085")]
		public event Action<EntityWidget> onChangedValue
		{
			[Token(Token = "0x6005578")]
			[Address(RVA = "0x9B9BD0", Offset = "0x9B8DD0", VA = "0x1809B9BD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005579")]
			[Address(RVA = "0x9B9CE0", Offset = "0x9B8EE0", VA = "0x1809B9CE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600557A")]
		[Address(RVA = "0x9B9A70", Offset = "0x9B8C70", VA = "0x1809B9A70")]
		public EntityWidget(ElementObjectManager eom, string label, int idx)
		{
		}

		[Token(Token = "0x600557B")]
		[Address(RVA = "0x9B9A50", Offset = "0x9B8C50", VA = "0x1809B9A50")]
		private void OnChangeValue(bool isOn)
		{
		}

		[Token(Token = "0x600557C")]
		[Address(RVA = "0x9B9990", Offset = "0x9B8B90", VA = "0x1809B9990", Slot = "16")]
		public override void CollectInputValues(Dictionary<string, object> resultValues)
		{
		}
	}

	[Token(Token = "0x400A221")]
	[FieldOffset(Offset = "0x28")]
	public readonly EntityWidget[] entityWidgets;

	[Token(Token = "0x400A222")]
	[FieldOffset(Offset = "0x30")]
	public readonly int checkMin;

	[Token(Token = "0x400A223")]
	[FieldOffset(Offset = "0x34")]
	public readonly int checkMax;

	[Token(Token = "0x400A224")]
	[FieldOffset(Offset = "0x38")]
	public int m_LastSelectIdx;

	[Token(Token = "0x17000CBD")]
	public bool isInputComplete
	{
		[Token(Token = "0x600556F")]
		[Address(RVA = "0x994170", Offset = "0x993370", VA = "0x180994170", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005570")]
		[Address(RVA = "0x994190", Offset = "0x993390", VA = "0x180994190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000084")]
	public event Action onChangeComplete
	{
		[Token(Token = "0x6005571")]
		[Address(RVA = "0x9BC1C0", Offset = "0x9BB3C0", VA = "0x1809BC1C0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005572")]
		[Address(RVA = "0x9BC260", Offset = "0x9BB460", VA = "0x1809BC260", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6005573")]
	[Address(RVA = "0x9BBD40", Offset = "0x9BAF40", VA = "0x1809BBD40")]
	public InputCheckBoxWidget(ElementObjectManager eom, string label, int entityLength, int checkMin, int checkMax)
	{
	}

	[Token(Token = "0x6005574")]
	[Address(RVA = "0x9BBBB0", Offset = "0x9BADB0", VA = "0x1809BBBB0")]
	private void OnEntityChangeValue(EntityWidget entityWidget)
	{
	}

	[Token(Token = "0x6005575")]
	[Address(RVA = "0x9BBB20", Offset = "0x9BAD20", VA = "0x1809BBB20", Slot = "15")]
	public override void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap)
	{
	}

	[Token(Token = "0x6005576")]
	[Address(RVA = "0x9BBAA0", Offset = "0x9BACA0", VA = "0x1809BBAA0", Slot = "16")]
	public override void CollectInputValues(Dictionary<string, object> resultValues)
	{
	}
}
