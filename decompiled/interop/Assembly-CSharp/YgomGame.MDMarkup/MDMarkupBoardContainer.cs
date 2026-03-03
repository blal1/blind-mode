using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;
using YgomSystem.UI;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C68")]
public class MDMarkupBoardContainer : MDMarkupContainerBase
{
	[Serializable]
	[Token(Token = "0x2000C69")]
	public class FooterContent : IMDMarkupOwnedId
	{
		[Token(Token = "0x2000C6A")]
		public enum ContentType
		{
			[Token(Token = "0x4009B10")]
			Text,
			[Token(Token = "0x4009B11")]
			Button
		}

		[Serializable]
		[Token(Token = "0x2000C6B")]
		public class Content : IMDMarkupId, IMDMarkupSupportedStrFormatByArgsModifier
		{
			[Token(Token = "0x4009B12")]
			[FieldOffset(Offset = "0x10")]
			public ContentType tp;

			[Token(Token = "0x4009B13")]
			[FieldOffset(Offset = "0x18")]
			public string id;

			[Token(Token = "0x4009B14")]
			[FieldOffset(Offset = "0x20")]
			public GlobalTextData text;

			[Token(Token = "0x4009B15")]
			[FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x4009B16")]
			[FieldOffset(Offset = "0x30")]
			public SelectorManager.KeyType shortcut;

			[Token(Token = "0x4009B17")]
			[FieldOffset(Offset = "0x34")]
			public bool consoleOnly;

			[Token(Token = "0x4009B18")]
			[FieldOffset(Offset = "0x35")]
			public bool interactable;

			[Token(Token = "0x4009B19")]
			[FieldOffset(Offset = "0x36")]
			public bool expand;

			[Token(Token = "0x4009B1A")]
			[FieldOffset(Offset = "0x37")]
			public bool muteClick;

			[Token(Token = "0x17000A36")]
			private string YgomGame_002EMDMarkup_002EIMDMarkupId_002Eid
			{
				[Token(Token = "0x6004B42")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004B43")]
			[Address(RVA = "0x931E50", Offset = "0x931050", VA = "0x180931E50")]
			public object ExportJsonObj()
			{
				return null;
			}

			[Token(Token = "0x6004B44")]
			[Address(RVA = "0x9321A0", Offset = "0x9313A0", VA = "0x1809321A0")]
			public void ImportJsonObj(object jsonObj)
			{
			}

			[Token(Token = "0x6004B45")]
			[Address(RVA = "0x932450", Offset = "0x931650", VA = "0x180932450", Slot = "5")]
			public void OnFormatByArgsModifier(object[] formatParams)
			{
			}

			[Token(Token = "0x6004B46")]
			[Address(RVA = "0x9324B0", Offset = "0x9316B0", VA = "0x1809324B0")]
			public Content()
			{
			}
		}

		[Token(Token = "0x4009B0E")]
		[FieldOffset(Offset = "0x10")]
		public List<Content> contents;

		[Token(Token = "0x6004B3D")]
		[Address(RVA = "0x932540", Offset = "0x931740", VA = "0x180932540")]
		public void Clear()
		{
		}

		[Token(Token = "0x6004B3E")]
		[Address(RVA = "0x9326F0", Offset = "0x9318F0", VA = "0x1809326F0")]
		public object ExportJsonObj()
		{
			return null;
		}

		[Token(Token = "0x6004B3F")]
		[Address(RVA = "0x932940", Offset = "0x931B40", VA = "0x180932940")]
		public void ImportJsonObj(object jsonObj)
		{
		}

		[Token(Token = "0x6004B40")]
		[Address(RVA = "0x9325A0", Offset = "0x9317A0", VA = "0x1809325A0", Slot = "4")]
		public void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
		{
		}

		[Token(Token = "0x6004B41")]
		[Address(RVA = "0x932C10", Offset = "0x931E10", VA = "0x180932C10")]
		public FooterContent()
		{
		}
	}

	[Token(Token = "0x4009B0C")]
	[FieldOffset(Offset = "0x28")]
	public FooterContent headerContent;

	[Token(Token = "0x4009B0D")]
	[FieldOffset(Offset = "0x30")]
	public FooterContent footerContent;

	[Token(Token = "0x17000A35")]
	public override MDMarkupDef.ContainerType containerType
	{
		[Token(Token = "0x6004B36")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "15")]
		get
		{
			return default(MDMarkupDef.ContainerType);
		}
	}

	[Token(Token = "0x6004B37")]
	[Address(RVA = "0x935B30", Offset = "0x934D30", VA = "0x180935B30", Slot = "16")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6004B38")]
	[Address(RVA = "0x935C00", Offset = "0x934E00", VA = "0x180935C00", Slot = "19")]
	public override void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004B39")]
	[Address(RVA = "0x935C60", Offset = "0x934E60", VA = "0x180935C60", Slot = "17")]
	public override object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004B3A")]
	[Address(RVA = "0x935D30", Offset = "0x934F30", VA = "0x180935D30", Slot = "18")]
	public override void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004B3B")]
	[Address(RVA = "0x935E10", Offset = "0x935010", VA = "0x180935E10", Slot = "20")]
	protected override void InnerSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004B3C")]
	[Address(RVA = "0x936030", Offset = "0x935230", VA = "0x180936030")]
	public MDMarkupBoardContainer()
	{
	}
}
