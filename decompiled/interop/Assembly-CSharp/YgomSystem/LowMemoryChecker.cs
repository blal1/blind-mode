using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x20001D8")]
public class LowMemoryChecker : MonoBehaviour
{
	[Token(Token = "0x6000B01")]
	[Address(RVA = "0xC0E460", Offset = "0xC0D660", VA = "0x180C0E460")]
	private void Start()
	{
	}

	[Token(Token = "0x6000B02")]
	[Address(RVA = "0xC0E3C0", Offset = "0xC0D5C0", VA = "0x180C0E3C0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000B03")]
	[Address(RVA = "0xC0E450", Offset = "0xC0D650", VA = "0x180C0E450")]
	private void OnLowMemory()
	{
	}

	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public LowMemoryChecker()
	{
	}
}
