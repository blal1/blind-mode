using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x20004F9")]
[AddComponentMenu("Ygom/UI/Tween/Tween Shader Float")]
public class TweenShaderFloat : Tween, IMaterialModifier
{
	[Token(Token = "0x4001882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	public float from;

	[Token(Token = "0x4001883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	public float to;

	[Token(Token = "0x4001884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	public string paramName;

	[Token(Token = "0x4001885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	public Material[] materials;

	[Token(Token = "0x4001886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Dictionary<int, Material> materialList;

	[Token(Token = "0x4001887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool isRecusive;

	[Token(Token = "0x4001888")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool isShared;

	[Token(Token = "0x60020AE")]
	[Address(RVA = "0x640390", Offset = "0x63F590", VA = "0x180640390")]
	public void InitializeMaterials([Optional] Dictionary<int, Material> initMaterialList)
	{
	}

	[Token(Token = "0x60020AF")]
	[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
	public Dictionary<int, Material> GetMaterials()
	{
		return null;
	}

	[Token(Token = "0x60020B0")]
	[Address(RVA = "0x6402E0", Offset = "0x63F4E0", VA = "0x1806402E0", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x60020B1")]
	[Address(RVA = "0x640840", Offset = "0x63FA40", VA = "0x180640840", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x60020B2")]
	[Address(RVA = "0x640300", Offset = "0x63F500", VA = "0x180640300", Slot = "7")]
	public Material GetModifiedMaterial(Material baseMaterial)
	{
		return null;
	}

	[Token(Token = "0x60020B3")]
	[Address(RVA = "0x640A10", Offset = "0x63FC10", VA = "0x180640A10")]
	public TweenShaderFloat()
	{
	}
}
