using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000479")]
public abstract class AbstractInputBlocker : MonoBehaviour
{
	[Token(Token = "0x40015E4")]
	[FieldOffset(Offset = "0x20")]
	protected bool blocking;

	[Token(Token = "0x170002D1")]
	protected abstract int blockPriority
	{
		[Token(Token = "0x6001CDA")]
		get;
	}

	[Token(Token = "0x6001CDB")]
	[Address(RVA = "0x5FA1A0", Offset = "0x5F93A0", VA = "0x1805FA1A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001CDC")]
	[Address(RVA = "0x5FA130", Offset = "0x5F9330", VA = "0x1805FA130")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001CDD")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	protected AbstractInputBlocker()
	{
	}
}
