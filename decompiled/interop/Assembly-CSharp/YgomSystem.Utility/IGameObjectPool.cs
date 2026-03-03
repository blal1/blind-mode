using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x2000397")]
public interface IGameObjectPool
{
	[Token(Token = "0x1700023C")]
	string poolKey
	{
		[Token(Token = "0x60015F6")]
		get;
	}

	[Token(Token = "0x1700023D")]
	GameObject pooledTarget
	{
		[Token(Token = "0x60015F7")]
		get;
	}

	[Token(Token = "0x60015F1")]
	[Address(RVA = "0x5BF490", Offset = "0x5BE690", VA = "0x1805BF490")]
	static void Pool(IGameObjectPool gameObjectPool)
	{
	}

	[Token(Token = "0x60015F2")]
	static T Get<T>(string poolKey, Transform parent) where T : Object
	{
		return null;
	}

	[Token(Token = "0x60015F3")]
	[Address(RVA = "0x5BF420", Offset = "0x5BE620", VA = "0x1805BF420")]
	static bool IsPooled(string poolKey)
	{
		return default(bool);
	}

	[Token(Token = "0x60015F4")]
	[Address(RVA = "0x5BF4C0", Offset = "0x5BE6C0", VA = "0x1805BF4C0")]
	static void SetLayout(bool isMobile)
	{
	}

	[Token(Token = "0x60015F5")]
	[Address(RVA = "0x5BF3D0", Offset = "0x5BE5D0", VA = "0x1805BF3D0")]
	static bool IsMobile()
	{
		return default(bool);
	}

	[Token(Token = "0x60015F8")]
	void OnReturned();
}
