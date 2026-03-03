using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI.InfinityScroll;

namespace YgomSystem.UI;

[Token(Token = "0x20004D5")]
[RequireComponent(typeof(InfinityScrollView))]
public class TransitionAlongDirectionScroll : MonoBehaviour
{
	[Token(Token = "0x40017D6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<TransitionAlongDirection> m_TransitionAlongDirections;

	[Token(Token = "0x600200D")]
	[Address(RVA = "0x6383C0", Offset = "0x6375C0", VA = "0x1806383C0")]
	private void Start()
	{
	}

	[Token(Token = "0x600200E")]
	[Address(RVA = "0x638230", Offset = "0x637430", VA = "0x180638230")]
	private bool OnEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x600200F")]
	[Address(RVA = "0x638470", Offset = "0x637670", VA = "0x180638470")]
	public TransitionAlongDirectionScroll()
	{
	}
}
