using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x2000400")]
[RequireComponent(typeof(MeshRenderer))]
public class RuntimeRimParamController : MonoBehaviour
{
	[Token(Token = "0x40013EC")]
	[FieldOffset(Offset = "0x20")]
	private int shaderID_SpecParams;

	[Token(Token = "0x40013ED")]
	[FieldOffset(Offset = "0x24")]
	private int shaderID_BackLightDirIntensity;

	[Token(Token = "0x40013EE")]
	[FieldOffset(Offset = "0x28")]
	private int shaderID_BackLightColor;

	[Token(Token = "0x40013EF")]
	[FieldOffset(Offset = "0x2C")]
	private int shaderID_CubeTex;

	[Token(Token = "0x40013F0")]
	[FieldOffset(Offset = "0x30")]
	private bool initialized;

	[Token(Token = "0x40013F1")]
	[FieldOffset(Offset = "0x31")]
	private bool initializedMaterials;

	[Token(Token = "0x40013F2")]
	[FieldOffset(Offset = "0x38")]
	private HashSet<Material> mtrls;

	[Token(Token = "0x40013F3")]
	[FieldOffset(Offset = "0x40")]
	private Vector4 prevSrcSpecParams;

	[Token(Token = "0x40013F4")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 prevF;

	[Token(Token = "0x40013F5")]
	[FieldOffset(Offset = "0x5C")]
	private float prevIntensity;

	[Token(Token = "0x40013F6")]
	[FieldOffset(Offset = "0x60")]
	private Color prevColor;

	[Token(Token = "0x40013F7")]
	[FieldOffset(Offset = "0x70")]
	private Texture prevCubeTex;

	[Token(Token = "0x40013F8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 forward;

	[Token(Token = "0x600199B")]
	[Address(RVA = "0x5D5860", Offset = "0x5D4A60", VA = "0x1805D5860")]
	private void Awake()
	{
	}

	[Token(Token = "0x600199C")]
	[Address(RVA = "0x5D5EC0", Offset = "0x5D50C0", VA = "0x1805D5EC0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600199D")]
	[Address(RVA = "0x5D5BE0", Offset = "0x5D4DE0", VA = "0x1805D5BE0")]
	private void InitializeMaterials()
	{
	}

	[Token(Token = "0x600199E")]
	[Address(RVA = "0x5D5EF0", Offset = "0x5D50F0", VA = "0x1805D5EF0")]
	private void UpdateMaterialParams()
	{
	}

	[Token(Token = "0x600199F")]
	[Address(RVA = "0x5D5900", Offset = "0x5D4B00", VA = "0x1805D5900")]
	private bool GetMaterialParams(out Vector4 specParams, out float intensity, out Color color, out Texture cubeTex)
	{
		return default(bool);
	}

	[Token(Token = "0x60019A0")]
	[Address(RVA = "0x5D6540", Offset = "0x5D5740", VA = "0x1805D6540")]
	public RuntimeRimParamController()
	{
	}
}
