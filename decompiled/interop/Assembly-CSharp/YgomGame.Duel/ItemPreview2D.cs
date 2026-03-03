using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001B91")]
public class ItemPreview2D : MonoBehaviour
{
	[Token(Token = "0x400F9FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public RawImage rawImg;

	[Token(Token = "0x400F9FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int id;

	[Token(Token = "0x400F9FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject itemObject;

	[Token(Token = "0x400F9FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Camera renderCam;

	[Token(Token = "0x600B36E")]
	[Address(RVA = "0x4AD3A0", Offset = "0x4AC5A0", VA = "0x1804AD3A0")]
	public static void Create(Transform parent, [Optional] Action<ItemPreview2D> onFinish)
	{
	}

	[Token(Token = "0x600B36F")]
	[Address(RVA = "0x4AD220", Offset = "0x4AC420", VA = "0x1804AD220")]
	public static void Create(GameObject gameObject, Transform parent, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, float imgW = -1f, float imgH = -1f, [Optional] Action<ItemPreview2D> onFinish, bool enablePostEffect = false)
	{
	}

	[Token(Token = "0x600B370")]
	[Address(RVA = "0x4AD080", Offset = "0x4AC280", VA = "0x1804AD080")]
	public static void Create(GameObject gameObject, Transform parent, Vector3 createPos, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, float imgW = -1f, float imgH = -1f, [Optional] Action<ItemPreview2D> onFinish, bool enablePostEffect = false)
	{
	}

	[Token(Token = "0x600B371")]
	[Address(RVA = "0x4AD830", Offset = "0x4ACA30", VA = "0x1804AD830")]
	private void Initialize(GameObject gameObject, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, float imgW = -1f, float imgH = -1f, [Optional] Action onFinish, bool enablePostEffect = false)
	{
	}

	[Token(Token = "0x600B372")]
	[Address(RVA = "0x4AD4C0", Offset = "0x4AC6C0", VA = "0x1804AD4C0")]
	private void Initialize(GameObject gameObject, Vector3 createPos, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, float imgW = -1f, float imgH = -1f, [Optional] Action onFinish, bool enablePostEffect = false)
	{
	}

	[Token(Token = "0x600B373")]
	[Address(RVA = "0x4ADB60", Offset = "0x4ACD60", VA = "0x1804ADB60")]
	public void LookAtItemObject()
	{
	}

	[Token(Token = "0x600B374")]
	[Address(RVA = "0x4ADBC0", Offset = "0x4ACDC0", VA = "0x1804ADBC0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600B375")]
	[Address(RVA = "0x4ADBD0", Offset = "0x4ACDD0", VA = "0x1804ADBD0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600B376")]
	[Address(RVA = "0x4ADC50", Offset = "0x4ACE50", VA = "0x1804ADC50")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600B377")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ItemPreview2D()
	{
	}
}
