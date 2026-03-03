using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.Analyze;

[Token(Token = "0x2000351")]
public class AnalyzeHistorySender
{
	[Token(Token = "0x40011CC")]
	[FieldOffset(Offset = "0x10")]
	private readonly int k_SendLimit;

	[Token(Token = "0x40011CD")]
	[FieldOffset(Offset = "0x0")]
	private static AnalyzeHistorySender s_Instance;

	[Token(Token = "0x40011CE")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<HistoryIDs, Dictionary<int, int>> m_HistoryMap;

	[Token(Token = "0x17000225")]
	private static AnalyzeHistorySender instance
	{
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x51BA50", Offset = "0x51AC50", VA = "0x18051BA50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60014B4")]
	[Address(RVA = "0x51B490", Offset = "0x51A690", VA = "0x18051B490")]
	public static void AddCount(HistoryIDs historyId, int recordId = 0, int count = 1)
	{
	}

	[Token(Token = "0x60014B5")]
	[Address(RVA = "0x51B5F0", Offset = "0x51A7F0", VA = "0x18051B5F0")]
	public static Dictionary<string, object> Pop()
	{
		return null;
	}

	[Token(Token = "0x60014B6")]
	[Address(RVA = "0x51B9D0", Offset = "0x51ABD0", VA = "0x18051B9D0")]
	public AnalyzeHistorySender()
	{
	}
}
