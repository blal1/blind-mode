using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CA9")]
public interface IMDMarkupModifier
{
	[Token(Token = "0x17000AE4")]
	MDMarkupDef.ModifierType modifierType
	{
		[Token(Token = "0x6004CDA")]
		get;
	}

	[Token(Token = "0x6004CDB")]
	void ImportJsonObj(object jsonObj);

	[Token(Token = "0x6004CDC")]
	object ExportJsonObj();

	[Token(Token = "0x6004CDD")]
	bool MatchTargetId(IMDMarkupId idContent);
}
