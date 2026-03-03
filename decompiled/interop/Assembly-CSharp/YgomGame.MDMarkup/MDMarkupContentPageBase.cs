using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C7B")]
public abstract class MDMarkupContentPageBase : MDMarkupContentBase, IMDMarkupPageContent, IMDMarkupContent, IMDMarkupSource, IMDMarkupId, IMDMarkupOwnedId
{
	[Token(Token = "0x17000A4E")]
	public sealed override int contentIndent
	{
		[Token(Token = "0x6004B8B")]
		[Address(RVA = "0x937160", Offset = "0x936360", VA = "0x180937160", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1400006D")]
	public event Action<bool> onFocusPageEvent
	{
		[Token(Token = "0x6004B8C")]
		[Address(RVA = "0x93B2A0", Offset = "0x93A4A0", VA = "0x18093B2A0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004B8D")]
		[Address(RVA = "0x93B350", Offset = "0x93A550", VA = "0x18093B350", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6004B8E")]
	[Address(RVA = "0x93B280", Offset = "0x93A480", VA = "0x18093B280", Slot = "26")]
	public void InvokeOnFocusPageEvent(bool isFirst)
	{
	}

	[Token(Token = "0x6004B8F")]
	[Address(RVA = "0x936FB0", Offset = "0x9361B0", VA = "0x180936FB0")]
	protected MDMarkupContentPageBase()
	{
	}
}
