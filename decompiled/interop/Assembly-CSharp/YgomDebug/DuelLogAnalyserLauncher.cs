using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomDebug;

[Token(Token = "0x2000121")]
public class DuelLogAnalyserLauncher : ViewController
{
	[Token(Token = "0x40006CB")]
	private const string PREFAB_NAME = "Debug/DuelLogAnalyserView";

	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x48")]
	private bool m_Boot;

	[Token(Token = "0x600071F")]
	[Address(RVA = "0x9CD400", Offset = "0x9CC600", VA = "0x1809CD400")]
	private void Start()
	{
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0x9CD4D0", Offset = "0x9CC6D0", VA = "0x1809CD4D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x9CD5C0", Offset = "0x9CC7C0", VA = "0x1809CD5C0")]
	public DuelLogAnalyserLauncher()
	{
	}
}
