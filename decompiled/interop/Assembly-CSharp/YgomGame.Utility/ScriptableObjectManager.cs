using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Utility;

[Token(Token = "0x200090F")]
public class ScriptableObjectManager<T> where T : ScriptableObject
{
	[Token(Token = "0x4008977")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, UnityEvent<T>> loadFinishedCallbackList;

	[Token(Token = "0x600365F")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6003660")]
	public static T Load(string path)
	{
		return null;
	}

	[Token(Token = "0x6003661")]
	public static void LoadAsync(string path, Action<T> on_finished)
	{
	}

	[Token(Token = "0x6003662")]
	public static void UnloadAll()
	{
	}

	[Token(Token = "0x6003663")]
	public ScriptableObjectManager()
	{
	}
}
