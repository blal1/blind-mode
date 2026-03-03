using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000545")]
public class PlatformPlayerViewIcon : MonoBehaviour
{
	[Token(Token = "0x2000546")]
	public enum DispType
	{
		[Token(Token = "0x400199F")]
		Graphic,
		[Token(Token = "0x40019A0")]
		GameObject
	}

	[Token(Token = "0x400199C")]
	[FieldOffset(Offset = "0x20")]
	public DispType dispTarget;

	[Token(Token = "0x400199D")]
	[FieldOffset(Offset = "0x24")]
	public bool isReverse;

	[Token(Token = "0x600224A")]
	[Address(RVA = "0x64CBC0", Offset = "0x64BDC0", VA = "0x18064CBC0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600224B")]
	[Address(RVA = "0x64CCE0", Offset = "0x64BEE0", VA = "0x18064CCE0")]
	public void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x600224C")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public PlatformPlayerViewIcon()
	{
	}
}
