using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000095")]
public class OnDestroyAction : MonoBehaviour
{
	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x20")]
	protected UnityAction onDestroy;

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void SetDestroyAction(UnityAction onDestroy)
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x3F2960", Offset = "0x3F1B60", VA = "0x1803F2960")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public OnDestroyAction()
	{
	}
}
