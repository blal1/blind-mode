using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Home;

[Token(Token = "0x2000D3C")]
public class ActiveChangeByOwnActive : MonoBehaviour
{
	[Token(Token = "0x4009E3E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Tooltip("非表示にしたいGameObject")]
	private GameObject targetGameObject;

	[Token(Token = "0x4009E3F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Tooltip("2つ以上ある場合はこちら")]
	private GameObject[] additionalTargets;

	[Token(Token = "0x4009E40")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Tooltip("逆の状態にしたいものはこちら")]
	private GameObject[] reverseTargets;

	[Token(Token = "0x600501D")]
	[Address(RVA = "0x964FD0", Offset = "0x9641D0", VA = "0x180964FD0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600501E")]
	[Address(RVA = "0x965170", Offset = "0x964370", VA = "0x180965170")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600501F")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ActiveChangeByOwnActive()
	{
	}
}
