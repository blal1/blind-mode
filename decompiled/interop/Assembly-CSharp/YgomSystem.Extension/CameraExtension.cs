using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Extension;

[Token(Token = "0x2000355")]
public static class CameraExtension
{
	[Token(Token = "0x60014CE")]
	[Address(RVA = "0x5212E0", Offset = "0x5204E0", VA = "0x1805212E0")]
	public static bool GetRenderPostProcessing(this Camera camera)
	{
		return default(bool);
	}

	[Token(Token = "0x60014CF")]
	[Address(RVA = "0x521340", Offset = "0x520540", VA = "0x180521340")]
	public static void SetRenderPostProcessing(this Camera camera, bool value)
	{
	}
}
