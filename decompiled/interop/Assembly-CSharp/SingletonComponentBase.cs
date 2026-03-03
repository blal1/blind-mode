using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20000A5")]
public abstract class SingletonComponentBase<T> : MonoBehaviour where T : SingletonComponentBase<T>
{
	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T _Instance;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool IsReady;

	[Token(Token = "0x1700004C")]
	protected static T m_Instance
	{
		[Token(Token = "0x6000325")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000326")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	protected static bool m_IsAlive
	{
		[Token(Token = "0x6000327")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000328")]
	protected static void CreateInstance()
	{
	}

	[Token(Token = "0x6000329")]
	protected static void CreateInstanceAsync(string path, [Optional] UnityAction onFinish, [Optional] Transform parent)
	{
	}

	[Token(Token = "0x600032A")]
	public static void Release()
	{
	}

	[Token(Token = "0x600032B")]
	protected abstract void Initialize();

	[Token(Token = "0x600032C")]
	protected abstract void Terminate();

	[Token(Token = "0x600032D")]
	protected SingletonComponentBase()
	{
	}
}
