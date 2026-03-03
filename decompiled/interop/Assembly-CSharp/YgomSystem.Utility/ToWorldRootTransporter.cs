using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x2000419")]
public class ToWorldRootTransporter : MonoBehaviour
{
	[Token(Token = "0x4001434")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_Target;

	[Token(Token = "0x1700026A")]
	public Transform target
	{
		[Token(Token = "0x6001A78")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A79")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		set
		{
		}
	}

	[Token(Token = "0x6001A7A")]
	[Address(RVA = "0x5F0A10", Offset = "0x5EFC10", VA = "0x1805F0A10")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001A7B")]
	[Address(RVA = "0x5F0A90", Offset = "0x5EFC90", VA = "0x1805F0A90")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001A7C")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ToWorldRootTransporter()
	{
	}
}
