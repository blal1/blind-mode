using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Download;

[Token(Token = "0x2000F7F")]
public class FileSize
{
	[Token(Token = "0x17000ECB")]
	public float bytes
	{
		[Token(Token = "0x6005DFB")]
		[Address(RVA = "0xA45E80", Offset = "0xA45080", VA = "0x180A45E80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6005DFC")]
		[Address(RVA = "0xA45EA0", Offset = "0xA450A0", VA = "0x180A45EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000ECC")]
	public float size
	{
		[Token(Token = "0x6005DFD")]
		[Address(RVA = "0xA45E90", Offset = "0xA45090", VA = "0x180A45E90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6005DFE")]
		[Address(RVA = "0xA45EB0", Offset = "0xA450B0", VA = "0x180A45EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000ECD")]
	public string unit
	{
		[Token(Token = "0x6005DFF")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005E00")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6005E01")]
	[Address(RVA = "0xA45E50", Offset = "0xA45050", VA = "0x180A45E50")]
	public FileSize(float _bytes)
	{
	}

	[Token(Token = "0x6005E02")]
	[Address(RVA = "0xA45DE0", Offset = "0xA44FE0", VA = "0x180A45DE0")]
	public string ToString(string format = "F2")
	{
		return null;
	}

	[Token(Token = "0x6005E03")]
	[Address(RVA = "0xA45B70", Offset = "0xA44D70", VA = "0x180A45B70")]
	private void SetFileSize(float _bytes)
	{
	}
}
