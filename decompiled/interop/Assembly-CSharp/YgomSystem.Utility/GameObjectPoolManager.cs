using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x2000396")]
public class GameObjectPoolManager : MonoBehaviour
{
	[Token(Token = "0x400125C")]
	[FieldOffset(Offset = "0x0")]
	private static GameObjectPoolManager s_Instance;

	[Token(Token = "0x400125D")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, IGameObjectPool> m_IPool;

	[Token(Token = "0x400125E")]
	[FieldOffset(Offset = "0x10")]
	private static bool isMobileLayout;

	[Token(Token = "0x1700023A")]
	public static bool uiPoolEnabled
	{
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x5BF330", Offset = "0x5BE530", VA = "0x1805BF330")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700023B")]
	public static GameObjectPoolManager instance
	{
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x5BF110", Offset = "0x5BE310", VA = "0x1805BF110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60015E8")]
	[Address(RVA = "0x5BEAE0", Offset = "0x5BDCE0", VA = "0x1805BEAE0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60015E9")]
	[Address(RVA = "0x5BEDA0", Offset = "0x5BDFA0", VA = "0x1805BEDA0")]
	public void Return(IGameObjectPool poolObject)
	{
	}

	[Token(Token = "0x60015EA")]
	public T Get<T>(string poolKey, Transform parent) where T : Object
	{
		return null;
	}

	[Token(Token = "0x60015EB")]
	[Address(RVA = "0x5BEC20", Offset = "0x5BDE20", VA = "0x1805BEC20")]
	public bool IsPooled(string poolKey)
	{
		return default(bool);
	}

	[Token(Token = "0x60015EC")]
	[Address(RVA = "0x5BE890", Offset = "0x5BDA90", VA = "0x1805BE890")]
	public void DestroyAll()
	{
	}

	[Token(Token = "0x60015ED")]
	[Address(RVA = "0x5BF0D0", Offset = "0x5BE2D0", VA = "0x1805BF0D0")]
	public void SetLayout(bool isMobile)
	{
	}

	[Token(Token = "0x60015EE")]
	[Address(RVA = "0x5BEBE0", Offset = "0x5BDDE0", VA = "0x1805BEBE0")]
	public bool IsMobile()
	{
		return default(bool);
	}

	[Token(Token = "0x60015EF")]
	[Address(RVA = "0x5BEC90", Offset = "0x5BDE90", VA = "0x1805BEC90")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60015F0")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public GameObjectPoolManager()
	{
	}
}
