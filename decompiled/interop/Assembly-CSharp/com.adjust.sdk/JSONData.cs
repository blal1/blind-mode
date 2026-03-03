using System.IO;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DD3")]
public class JSONData : JSONNode
{
	[Token(Token = "0x401056D")]
	[FieldOffset(Offset = "0x10")]
	private string m_Data;

	[Token(Token = "0x17001C54")]
	public override string Value
	{
		[Token(Token = "0x600BED9")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x600BEDA")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x600BEDB")]
	[Address(RVA = "0x59D480", Offset = "0x59C680", VA = "0x18059D480")]
	public JSONData(string aData)
	{
	}

	[Token(Token = "0x600BEDC")]
	[Address(RVA = "0x59D3C0", Offset = "0x59C5C0", VA = "0x18059D3C0")]
	public JSONData(float aData)
	{
	}

	[Token(Token = "0x600BEDD")]
	[Address(RVA = "0x59D400", Offset = "0x59C600", VA = "0x18059D400")]
	public JSONData(double aData)
	{
	}

	[Token(Token = "0x600BEDE")]
	[Address(RVA = "0x59D380", Offset = "0x59C580", VA = "0x18059D380")]
	public JSONData(bool aData)
	{
	}

	[Token(Token = "0x600BEDF")]
	[Address(RVA = "0x59D440", Offset = "0x59C640", VA = "0x18059D440")]
	public JSONData(int aData)
	{
	}

	[Token(Token = "0x600BEE0")]
	[Address(RVA = "0x59D2E0", Offset = "0x59C4E0", VA = "0x18059D2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600BEE1")]
	[Address(RVA = "0x59D330", Offset = "0x59C530", VA = "0x18059D330", Slot = "17")]
	public override string ToString(string aPrefix)
	{
		return null;
	}

	[Token(Token = "0x600BEE2")]
	[Address(RVA = "0x59CFC0", Offset = "0x59C1C0", VA = "0x18059CFC0", Slot = "28")]
	public override void Serialize(BinaryWriter aWriter)
	{
	}
}
