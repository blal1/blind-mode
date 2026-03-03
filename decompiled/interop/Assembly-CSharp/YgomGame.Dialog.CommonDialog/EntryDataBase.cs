using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FC4")]
public abstract class EntryDataBase : IEntryData
{
	[Token(Token = "0x17000F0E")]
	public abstract CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F82")]
		get;
	}

	[Token(Token = "0x17000F0F")]
	public string entryLabel
	{
		[Token(Token = "0x6005F83")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005F84")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6005F85")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected EntryDataBase()
	{
	}
}
