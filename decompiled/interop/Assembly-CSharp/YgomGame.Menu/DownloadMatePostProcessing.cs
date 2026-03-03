using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200125E")]
public class DownloadMatePostProcessing : MonoBehaviour
{
	[Token(Token = "0x400BB34")]
	[FieldOffset(Offset = "0x0")]
	private static DownloadMatePostProcessing k_Instance;

	[Token(Token = "0x400BB35")]
	[FieldOffset(Offset = "0x20")]
	private List<ViewController> m_Owners;

	[Token(Token = "0x400BB36")]
	[FieldOffset(Offset = "0x28")]
	private List<ViewController> m_RemoveSearchList;

	[Token(Token = "0x6007267")]
	[Address(RVA = "0xB8A7B0", Offset = "0xB899B0", VA = "0x180B8A7B0")]
	public static void Activate(ViewController owner)
	{
	}

	[Token(Token = "0x6007268")]
	[Address(RVA = "0xB8AA50", Offset = "0xB89C50", VA = "0x180B8AA50")]
	public static void Deactivate(ViewController owner)
	{
	}

	[Token(Token = "0x6007269")]
	[Address(RVA = "0xB8AEB0", Offset = "0xB8A0B0", VA = "0x180B8AEB0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600726A")]
	[Address(RVA = "0xB8AF10", Offset = "0xB8A110", VA = "0x180B8AF10")]
	private static void SetMainCameraPostEffect(bool isOn)
	{
	}

	[Token(Token = "0x600726B")]
	[Address(RVA = "0xB8B050", Offset = "0xB8A250", VA = "0x180B8B050")]
	public DownloadMatePostProcessing()
	{
	}
}
