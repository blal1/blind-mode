using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FBC")]
public class EntryItemListData : EntryDataBase
{
	[Token(Token = "0x2000FBD")]
	public class Context
	{
		[Token(Token = "0x400AA8C")]
		[FieldOffset(Offset = "0x10")]
		public bool isPeriod;

		[Token(Token = "0x400AA8D")]
		[FieldOffset(Offset = "0x14")]
		public int itemCategory;

		[Token(Token = "0x400AA8E")]
		[FieldOffset(Offset = "0x18")]
		public int itemId;

		[Token(Token = "0x400AA8F")]
		[FieldOffset(Offset = "0x1C")]
		public int num;

		[Token(Token = "0x6005F6F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Context()
		{
		}

		[Token(Token = "0x6005F70")]
		[Address(RVA = "0xA58540", Offset = "0xA57740", VA = "0x180A58540")]
		public Context(bool isPeriod, int itemCategory, int itemId, int num)
		{
		}

		[Token(Token = "0x6005F71")]
		[Address(RVA = "0xA58590", Offset = "0xA57790", VA = "0x180A58590")]
		public Context(object data)
		{
		}

		[Token(Token = "0x6005F72")]
		[Address(RVA = "0xA58460", Offset = "0xA57660", VA = "0x180A58460")]
		public void Import(object data)
		{
		}

		[Token(Token = "0x6005F73")]
		[Address(RVA = "0xA583A0", Offset = "0xA575A0", VA = "0x180A583A0")]
		public void Import(Dictionary<string, object> data)
		{
		}

		[Token(Token = "0x6005F74")]
		[Address(RVA = "0xA58330", Offset = "0xA57530", VA = "0x180A58330")]
		public static Context CreateFromData(object data)
		{
			return null;
		}
	}

	[Token(Token = "0x400AA8B")]
	[FieldOffset(Offset = "0x18")]
	public List<Context> contexts;

	[Token(Token = "0x17000F05")]
	public override CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F66")]
		[Address(RVA = "0x443230", Offset = "0x442430", VA = "0x180443230", Slot = "7")]
		get
		{
			return default(CommonDialogDef.ContentType);
		}
	}

	[Token(Token = "0x17000F06")]
	public int Count
	{
		[Token(Token = "0x6005F67")]
		[Address(RVA = "0xA6B4E0", Offset = "0xA6A6E0", VA = "0x180A6B4E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6005F68")]
	[Address(RVA = "0xA6B460", Offset = "0xA6A660", VA = "0x180A6B460")]
	public EntryItemListData()
	{
	}

	[Token(Token = "0x6005F69")]
	[Address(RVA = "0x6A1440", Offset = "0x6A0640", VA = "0x1806A1440")]
	public EntryItemListData(List<Context> contexts)
	{
	}

	[Token(Token = "0x6005F6A")]
	[Address(RVA = "0xA6B310", Offset = "0xA6A510", VA = "0x180A6B310")]
	public EntryItemListData(IReadOnlyList<Context> contexts)
	{
	}

	[Token(Token = "0x6005F6B")]
	[Address(RVA = "0xA6B200", Offset = "0xA6A400", VA = "0x180A6B200")]
	public EntryItemListData(Context context)
	{
	}

	[Token(Token = "0x6005F6C")]
	[Address(RVA = "0xA6B3C0", Offset = "0xA6A5C0", VA = "0x180A6B3C0")]
	public EntryItemListData(IReadOnlyList<object> list)
	{
	}

	[Token(Token = "0x6005F6D")]
	[Address(RVA = "0xA6AF00", Offset = "0xA6A100", VA = "0x180A6AF00")]
	public void Import(IReadOnlyList<object> list)
	{
	}

	[Token(Token = "0x6005F6E")]
	[Address(RVA = "0xA6AEA0", Offset = "0xA6A0A0", VA = "0x180A6AEA0")]
	public void AddContext(Context context)
	{
	}
}
