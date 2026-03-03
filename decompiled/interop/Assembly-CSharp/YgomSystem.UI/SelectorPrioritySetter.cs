using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004C2")]
[RequireComponent(typeof(Selector))]
public class SelectorPrioritySetter : MonoBehaviour
{
	[Token(Token = "0x20004C3")]
	public enum SetMode
	{
		[Token(Token = "0x400179D")]
		FromSelector
	}

	[Token(Token = "0x400179A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SetMode m_SetMode;

	[Token(Token = "0x400179B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Selector m_FromSelector;

	[Token(Token = "0x6001FB2")]
	[Address(RVA = "0x6291F0", Offset = "0x6283F0", VA = "0x1806291F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001FB3")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SelectorPrioritySetter()
	{
	}
}
