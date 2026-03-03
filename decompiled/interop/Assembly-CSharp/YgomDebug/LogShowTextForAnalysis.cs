using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomDebug;

[Token(Token = "0x2000138")]
public class LogShowTextForAnalysis : LogItemBaseForAnalysis
{
	[Token(Token = "0x400077B")]
	[FieldOffset(Offset = "0x0")]
	public static List<string> m_TextTable;

	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0x20")]
	protected string LABEL_EO_CONTENT;

	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0x28")]
	protected string LABEL_EO_COLORBARTEAM0;

	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0x30")]
	protected string LABEL_EO_COLORBARTEAM1;

	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0x38")]
	protected string LABEL_EO_TEXT;

	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170000DA")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x9DA360", Offset = "0x9D9560", VA = "0x1809DA360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x9DA0C0", Offset = "0x9D92C0", VA = "0x1809DA0C0")]
	public void SetData(ShowTextDataForAnalysis data)
	{
	}

	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x9DA290", Offset = "0x9D9490", VA = "0x1809DA290")]
	public LogShowTextForAnalysis()
	{
	}
}
