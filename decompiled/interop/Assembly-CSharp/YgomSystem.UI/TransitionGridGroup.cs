using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004D7")]
public class TransitionGridGroup : MonoBehaviour
{
	[Token(Token = "0x40017DB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<TransitionGridElement> m_GridElements;

	[Token(Token = "0x40017DC")]
	[FieldOffset(Offset = "0x28")]
	private List<TransitionGridElement> m_SetupElements;

	[Token(Token = "0x40017DD")]
	[FieldOffset(Offset = "0x30")]
	private List<TransitionGridElement> m_PrevLine;

	[Token(Token = "0x40017DE")]
	[FieldOffset(Offset = "0x38")]
	private List<TransitionGridElement> m_CurrentLine;

	[Token(Token = "0x600201A")]
	[Address(RVA = "0x6387B0", Offset = "0x6379B0", VA = "0x1806387B0")]
	public void ClearElements()
	{
	}

	[Token(Token = "0x600201B")]
	[Address(RVA = "0x6386A0", Offset = "0x6378A0", VA = "0x1806386A0")]
	public void AddElement(TransitionGridElement gridElement)
	{
	}

	[Token(Token = "0x600201C")]
	[Address(RVA = "0x638750", Offset = "0x637950", VA = "0x180638750")]
	public void AddElements(IEnumerable<TransitionGridElement> gridElements)
	{
	}

	[Token(Token = "0x600201D")]
	[Address(RVA = "0x638ED0", Offset = "0x6380D0", VA = "0x180638ED0")]
	private void Start()
	{
	}

	[Token(Token = "0x600201E")]
	[Address(RVA = "0x638810", Offset = "0x637A10", VA = "0x180638810")]
	[ContextMenu("SetupSelectionItems")]
	public void SetupSelectionItems()
	{
	}

	[Token(Token = "0x600201F")]
	[Address(RVA = "0x638EE0", Offset = "0x6380E0", VA = "0x180638EE0")]
	public TransitionGridGroup()
	{
	}
}
