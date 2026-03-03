using System;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C7F")]
public class MDMarkupContentEmpty : MDMarkupContentBase, IMDMarkupContent, IMDMarkupSource, IMDMarkupId, IMDMarkupOwnedId
{
	[Token(Token = "0x17000A59")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004BAF")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A5A")]
	public override int contentIndent
	{
		[Token(Token = "0x6004BB0")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004BB1")]
	[Address(RVA = "0x52F690", Offset = "0x52E890", VA = "0x18052F690", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004BB2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004BB3")]
	[Address(RVA = "0x936FB0", Offset = "0x9361B0", VA = "0x180936FB0")]
	public MDMarkupContentEmpty()
	{
	}
}
