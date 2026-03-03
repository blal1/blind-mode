using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace KonamiCommonIAB;

[Token(Token = "0x2000119")]
public class SimpleTuple<T1, T2>
{
	[Token(Token = "0x17000090")]
	public T1 First
	{
		[Token(Token = "0x60006FB")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Token(Token = "0x60006FC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000091")]
	public T2 Second
	{
		[Token(Token = "0x60006FD")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Token(Token = "0x60006FE")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60006FF")]
	public SimpleTuple(T1 first, T2 second)
	{
	}
}
