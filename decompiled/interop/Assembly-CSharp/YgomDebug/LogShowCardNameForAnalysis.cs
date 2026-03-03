using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomDebug;

[Token(Token = "0x200012F")]
public class LogShowCardNameForAnalysis : LogItemBaseForAnalysis
{
	[Token(Token = "0x400075D")]
	[FieldOffset(Offset = "0x20")]
	protected string LABEL_EO_CONTENT;

	[Token(Token = "0x400075E")]
	[FieldOffset(Offset = "0x28")]
	protected string LABEL_EO_COLORBARTEAM0;

	[Token(Token = "0x400075F")]
	[FieldOffset(Offset = "0x30")]
	protected string LABEL_EO_COLORBARTEAM1;

	[Token(Token = "0x4000760")]
	[FieldOffset(Offset = "0x38")]
	protected string LABEL_EO_CARDNAME;

	[Token(Token = "0x4000761")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170000D6")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x9D9450", Offset = "0x9D8650", VA = "0x1809D9450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x9D9140", Offset = "0x9D8340", VA = "0x1809D9140")]
	public void SetData(ShowCardNameDataForAnalysis data)
	{
	}

	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x9D9380", Offset = "0x9D8580", VA = "0x1809D9380")]
	public LogShowCardNameForAnalysis()
	{
	}
}
