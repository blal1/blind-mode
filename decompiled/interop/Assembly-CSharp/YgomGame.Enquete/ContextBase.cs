using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DE0")]
public abstract class ContextBase : IContext
{
	[Token(Token = "0x17000C44")]
	public string label
	{
		[Token(Token = "0x60053A4")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60053A5")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60053A6")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ContextBase()
	{
	}

	[Token(Token = "0x60053A7")]
	[Address(RVA = "0x99DE40", Offset = "0x99D040", VA = "0x18099DE40")]
	public ContextBase(object jsonData)
	{
	}

	[Token(Token = "0x60053A8")]
	[Address(RVA = "0x99DDB0", Offset = "0x99CFB0", VA = "0x18099DDB0", Slot = "7")]
	public virtual void Import(object jsonData)
	{
	}

	[Token(Token = "0x60053A9")]
	[Address(RVA = "0x99DD80", Offset = "0x99CF80", VA = "0x18099DD80", Slot = "8")]
	public virtual void CopyTo(ContextBase target)
	{
	}

	[Token(Token = "0x60053AA")]
	public abstract void SearchDependencieTextGroups(List<string> resultList);
}
