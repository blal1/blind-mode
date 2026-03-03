using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x2000405")]
public class SingleFrameBoolean : MonoBehaviour
{
	[Token(Token = "0x40013FB")]
	[FieldOffset(Offset = "0x20")]
	private bool m_DefaultVal;

	[Token(Token = "0x40013FC")]
	[FieldOffset(Offset = "0x21")]
	private bool m_CurrentVal;

	[Token(Token = "0x17000268")]
	public bool frameValue
	{
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x5D7890", Offset = "0x5D6A90", VA = "0x1805D7890")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x5D78A0", Offset = "0x5D6AA0", VA = "0x1805D78A0")]
		set
		{
		}
	}

	[Token(Token = "0x60019B2")]
	[Address(RVA = "0x5D77D0", Offset = "0x5D69D0", VA = "0x1805D77D0")]
	public static SingleFrameBoolean Create(GameObject owner, bool defaultVal = false)
	{
		return null;
	}

	[Token(Token = "0x60019B3")]
	[Address(RVA = "0x5D7850", Offset = "0x5D6A50", VA = "0x1805D7850")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60019B4")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SingleFrameBoolean()
	{
	}
}
