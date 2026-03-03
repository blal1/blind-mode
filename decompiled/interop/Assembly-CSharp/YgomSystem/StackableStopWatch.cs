using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x20001D4")]
public class StackableStopWatch
{
	[Token(Token = "0x17000126")]
	public bool isMeasuring
	{
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000127")]
	public string currentLabel
	{
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0xC15EE0", Offset = "0xC150E0", VA = "0x180C15EE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000AE2")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public StackableStopWatch()
	{
	}

	[Token(Token = "0x6000AE3")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("NEVER_DEFINED_SYMBOL")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000AE4")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("NEVER_DEFINED_SYMBOL")]
	public void Start(string label)
	{
	}

	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("NEVER_DEFINED_SYMBOL")]
	public void End()
	{
	}

	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("NEVER_DEFINED_SYMBOL")]
	public void EndAll()
	{
	}

	[Token(Token = "0x6000AE9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("NEVER_DEFINED_SYMBOL")]
	public void Print(bool header = true, bool detail = false)
	{
	}

	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("NEVER_DEFINED_SYMBOL")]
	public void OutputResult(StringBuilder sb, bool header, bool detail)
	{
	}

	[Token(Token = "0x6000AEB")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("NEVER_DEFINED_SYMBOL")]
	public void OutputLogger(bool header = true, bool detail = false)
	{
	}

	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0xC15EB0", Offset = "0xC150B0", VA = "0x180C15EB0")]
	public string ToString(bool header, bool detail)
	{
		return null;
	}

	[Token(Token = "0x6000AED")]
	[Address(RVA = "0xC15EB0", Offset = "0xC150B0", VA = "0x180C15EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
