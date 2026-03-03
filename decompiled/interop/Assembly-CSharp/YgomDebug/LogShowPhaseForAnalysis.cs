using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomDebug;

[Token(Token = "0x2000134")]
public class LogShowPhaseForAnalysis : LogItemBaseForAnalysis
{
	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0x20")]
	protected string LABEL_EO_PHASETEXT;

	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x28")]
	protected string LABEL_EO_CARDNAME;

	[Token(Token = "0x4000773")]
	[FieldOffset(Offset = "0x30")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170000D8")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x9D9CE0", Offset = "0x9D8EE0", VA = "0x1809D9CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x9D99A0", Offset = "0x9D8BA0", VA = "0x1809D99A0")]
	public void SetData(ShowPhaseDataForAnalysis data)
	{
	}

	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x9D9C60", Offset = "0x9D8E60", VA = "0x1809D9C60")]
	public LogShowPhaseForAnalysis()
	{
	}
}
