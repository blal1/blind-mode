using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DE5")]
public abstract class SheetContentContextBase : ContextBase, ISheetContentContext, IContext
{
	[Token(Token = "0x400A117")]
	[FieldOffset(Offset = "0x18")]
	public readonly RootContext m_RootContext;

	[Token(Token = "0x17000C4A")]
	public abstract SheetContentType sheetContentType
	{
		[Token(Token = "0x60053B8")]
		get;
	}

	[Token(Token = "0x17000C4B")]
	public RootContext rootContext
	{
		[Token(Token = "0x60053B9")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C4C")]
	public SheetContentGroupContext groupContext
	{
		[Token(Token = "0x60053BA")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60053BB")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000C4D")]
	public virtual bool isInput
	{
		[Token(Token = "0x60053BC")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60053BD")]
	[Address(RVA = "0x6A1440", Offset = "0x6A0640", VA = "0x1806A1440")]
	public SheetContentContextBase(RootContext rootContext)
	{
	}

	[Token(Token = "0x60053BE")]
	[Address(RVA = "0x9A9AB0", Offset = "0x9A8CB0", VA = "0x1809A9AB0")]
	public SheetContentContextBase(object jsonData, RootContext rootContext)
	{
	}

	[Token(Token = "0x60053BF")]
	[Address(RVA = "0x9A9650", Offset = "0x9A8850", VA = "0x1809A9650")]
	public static ISheetContentContext CreateByJsonData(object jsonData, RootContext rootContext)
	{
		return null;
	}
}
