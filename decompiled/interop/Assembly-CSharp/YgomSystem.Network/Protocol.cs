using System.Collections;
using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000284")]
public abstract class Protocol
{
	[Token(Token = "0x6000F5D")]
	public abstract IEnumerator Exec(NetworkMain.RequestStructure data);

	[Token(Token = "0x6000F5E")]
	public abstract void ApplicationQuitAbort();

	[Token(Token = "0x6000F5F")]
	public abstract int GetJobCount();

	[Token(Token = "0x6000F60")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected Protocol()
	{
	}
}
