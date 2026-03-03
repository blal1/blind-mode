using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Utility;

[Token(Token = "0x200090B")]
public class OnEnabledAction : MonoBehaviour
{
	[Token(Token = "0x4008962")]
	[FieldOffset(Offset = "0x20")]
	public UnityAction onEnabled;

	[Token(Token = "0x600363F")]
	[Address(RVA = "0x3F2960", Offset = "0x3F1B60", VA = "0x1803F2960")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003640")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public OnEnabledAction()
	{
	}
}
