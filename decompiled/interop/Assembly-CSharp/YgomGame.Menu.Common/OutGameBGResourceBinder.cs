using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200148C")]
public class OutGameBGResourceBinder : ResourceBinderBase
{
	[Token(Token = "0x400C6D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string m_FrontBGPath;

	[Token(Token = "0x400C6D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly string m_BackBGPath;

	[Token(Token = "0x6007F9E")]
	[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
	public OutGameBGResourceBinder(string frontBGPath, string backBGPath)
	{
	}

	[Token(Token = "0x6007F9F")]
	[Address(RVA = "0xC78210", Offset = "0xC77410", VA = "0x180C78210")]
	public BindingGameObjectEx BindWallpaper(GameObject target, int id, bool async = true, [Optional] UnityAction<GameObject> onCreated)
	{
		return null;
	}

	[Token(Token = "0x6007FA0")]
	[Address(RVA = "0xC782F0", Offset = "0xC774F0", VA = "0x180C782F0")]
	public string GetFrontBGPath(int id)
	{
		return null;
	}

	[Token(Token = "0x6007FA1")]
	[Address(RVA = "0xC78280", Offset = "0xC77480", VA = "0x180C78280")]
	public string GetBackBGPath(int id)
	{
		return null;
	}
}
