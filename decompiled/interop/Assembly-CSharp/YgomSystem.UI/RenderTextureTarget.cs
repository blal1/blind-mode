using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI;

[Token(Token = "0x200045C")]
public class RenderTextureTarget : MonoBehaviour
{
	[Token(Token = "0x400154C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RenderTextureBuilder renderTexBuilder;

	[Token(Token = "0x400154D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform rootTransform;

	[Token(Token = "0x400154E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Camera cam;

	[Token(Token = "0x400154F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Action<int, RenderTexture, Texture2D> onFinish;

	[Token(Token = "0x4001550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int oldCullingMask;

	[Token(Token = "0x4001551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private int renderDelay;

	[Token(Token = "0x4001552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int renderTargetId;

	[Token(Token = "0x4001553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject targetObject;

	[Token(Token = "0x170002B7")]
	public Camera Cam
	{
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001C34")]
	[Address(RVA = "0x604270", Offset = "0x603470", VA = "0x180604270")]
	public static int Create(GameObject obj, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, [Optional] Action<int, RenderTexture, Texture2D> onFinish, bool enablePostEffect = false, int depth = 24, bool useSubLayer = false)
	{
		return default(int);
	}

	[Token(Token = "0x6001C35")]
	[Address(RVA = "0x6043B0", Offset = "0x6035B0", VA = "0x1806043B0")]
	public static int Create(GameObject obj, Vector3 createPos, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, [Optional] Action<int, RenderTexture, Texture2D> onFinish, bool enablePostEffect = false, int depth = 24, bool useSubLayer = true)
	{
		return default(int);
	}

	[Token(Token = "0x6001C36")]
	[Address(RVA = "0x604830", Offset = "0x603A30", VA = "0x180604830")]
	private static void SetupTarget(RenderTextureTarget rtTarget, GameObject obj, Vector3 camPos, Vector3 camRot, bool useSubLayer, bool enablePostEffect, int renderTexW, int renderTexH, Action<int, RenderTexture, Texture2D> onFinish, int depth)
	{
	}

	[Token(Token = "0x6001C37")]
	[Address(RVA = "0x604540", Offset = "0x603740", VA = "0x180604540")]
	public static void Destory(int id)
	{
	}

	[Token(Token = "0x6001C38")]
	[Address(RVA = "0x604550", Offset = "0x603750", VA = "0x180604550")]
	public void DestroyRenderTexture()
	{
	}

	[Token(Token = "0x6001C39")]
	[Address(RVA = "0x604810", Offset = "0x603A10", VA = "0x180604810")]
	public void ResetOnFinish()
	{
	}

	[Token(Token = "0x6001C3A")]
	[Address(RVA = "0x604230", Offset = "0x603430", VA = "0x180604230")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001C3B")]
	[Address(RVA = "0x6047B0", Offset = "0x6039B0", VA = "0x1806047B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001C3C")]
	[Address(RVA = "0x6046A0", Offset = "0x6038A0", VA = "0x1806046A0")]
	private void Initialize(int renderTexW, int renderTexH, Action<int, RenderTexture, Texture2D> onFinish, int depth = 24, bool enablePostEffect = false)
	{
	}

	[Token(Token = "0x6001C3D")]
	[Address(RVA = "0x6047C0", Offset = "0x6039C0", VA = "0x1806047C0")]
	private void OnFinishRender(RenderTextureBuilder renderTexBuilder)
	{
	}

	[Token(Token = "0x6001C3E")]
	[Address(RVA = "0x6045C0", Offset = "0x6037C0", VA = "0x1806045C0")]
	private void InitBuilder()
	{
	}

	[Token(Token = "0x6001C3F")]
	[Address(RVA = "0x604BC0", Offset = "0x603DC0", VA = "0x180604BC0")]
	public RenderTextureTarget()
	{
	}
}
