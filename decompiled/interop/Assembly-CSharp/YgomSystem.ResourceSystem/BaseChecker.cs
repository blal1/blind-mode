using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002CD")]
public abstract class BaseChecker : IResTypeChecker
{
	[Token(Token = "0x6001122")]
	public abstract ResTypeData GetResType(string path);

	[Token(Token = "0x6001123")]
	public abstract ResTypeData GetResTypeSimpleCheck(string path);

	[Token(Token = "0x6001124")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x6001125")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "12")]
	public virtual void Destroy()
	{
	}

	[Token(Token = "0x6001126")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	public virtual void ClearCache()
	{
	}

	[Token(Token = "0x6001127")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected BaseChecker()
	{
	}
}
