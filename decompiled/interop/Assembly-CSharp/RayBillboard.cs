using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000B1")]
public class RayBillboard : MonoBehaviour
{
	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0x20")]
	private Camera targetCam;

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x67E430", Offset = "0x67D630", VA = "0x18067E430")]
	private void Start()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x67E4E0", Offset = "0x67D6E0", VA = "0x18067E4E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x67E1D0", Offset = "0x67D3D0", VA = "0x18067E1D0")]
	private float AxisAngleOnAxisPlane(Vector3 vec0, Vector3 vec1, Vector3 axis)
	{
		return default(float);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x67E3D0", Offset = "0x67D5D0", VA = "0x18067E3D0")]
	private bool IsValidQuat(Quaternion quaternion)
	{
		return default(bool);
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public RayBillboard()
	{
	}
}
