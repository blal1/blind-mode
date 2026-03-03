using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002AD")]
public abstract class AbstractReferenceCache<T> where T : class
{
	[Token(Token = "0x4000F1C")]
	[FieldOffset(Offset = "0x0")]
	protected Dictionary<string, T> m_refCache;

	[Token(Token = "0x4000F1D")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<string, int> m_refCount;

	[Token(Token = "0x600104C")]
	protected abstract T LoadRequest(string key, params object[] param);

	[Token(Token = "0x600104D")]
	protected virtual void RemoveCacheAction(T value)
	{
	}

	[Token(Token = "0x600104E")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x600104F")]
	protected virtual void ClearKey(string key)
	{
	}

	[Token(Token = "0x6001050")]
	public bool Exist(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6001051")]
	public void AddReference(string key, T value)
	{
	}

	[Token(Token = "0x6001052")]
	public T GetReference(string key, params object[] param)
	{
		return null;
	}

	[Token(Token = "0x6001053")]
	public void RemoveReference(string key)
	{
	}

	[Token(Token = "0x6001054")]
	private void AddRefCount(string key)
	{
	}

	[Token(Token = "0x6001055")]
	private int DecRefCount(string key)
	{
		return default(int);
	}

	[Token(Token = "0x6001056")]
	protected AbstractReferenceCache()
	{
	}
}
