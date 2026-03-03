using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004FA")]
[AddComponentMenu("Ygom/UI/Tween/Tween Shader Float UGUI")]
public class TweenShaderFloatUGUI : Tween
{
	[Token(Token = "0x4001889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	public float from;

	[Token(Token = "0x400188A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	public float to;

	[Token(Token = "0x400188B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	public string paramName;

	[Token(Token = "0x400188C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	public Material[] materials;

	[Token(Token = "0x400188D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Dictionary<int, Material> materialList;

	[Token(Token = "0x400188E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool isRecusive;

	[Token(Token = "0x400188F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool isShared;

	[Token(Token = "0x60020B4")]
	[Address(RVA = "0x63FEF0", Offset = "0x63F0F0", VA = "0x18063FEF0")]
	public void InitializeMaterials([Optional] Dictionary<int, Material> initMaterialList)
	{
	}

	[Token(Token = "0x60020B5")]
	[Address(RVA = "0x63FDC0", Offset = "0x63EFC0", VA = "0x18063FDC0")]
	protected void InitializeMaterialsForRawImage([Optional] Dictionary<int, Material> initMaterialList)
	{
	}

	[Token(Token = "0x60020B6")]
	[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
	public Dictionary<int, Material> GetMaterials()
	{
		return null;
	}

	[Token(Token = "0x60020B7")]
	[Address(RVA = "0x63FC10", Offset = "0x63EE10", VA = "0x18063FC10", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x60020B8")]
	[Address(RVA = "0x640090", Offset = "0x63F290", VA = "0x180640090", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x60020B9")]
	[Address(RVA = "0x640260", Offset = "0x63F460", VA = "0x180640260")]
	public TweenShaderFloatUGUI()
	{
	}
}
