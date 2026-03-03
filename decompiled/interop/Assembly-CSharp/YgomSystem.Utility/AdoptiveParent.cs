using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x200039A")]
public class AdoptiveParent : MonoBehaviour
{
	[Token(Token = "0x4001260")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> adoptedChildren;

	[Token(Token = "0x4001261")]
	[FieldOffset(Offset = "0x28")]
	public bool syncActive;

	[Token(Token = "0x4001262")]
	[FieldOffset(Offset = "0x29")]
	public bool syncDestroy;

	[Token(Token = "0x6001600")]
	[Address(RVA = "0x59F870", Offset = "0x59EA70", VA = "0x18059F870")]
	public void AddAdoptedChild(GameObject adoptedChild)
	{
	}

	[Token(Token = "0x6001601")]
	[Address(RVA = "0x59FC10", Offset = "0x59EE10", VA = "0x18059FC10")]
	public void RemoveAdoptedChild(GameObject adoptedChild)
	{
	}

	[Token(Token = "0x6001602")]
	[Address(RVA = "0x59FB20", Offset = "0x59ED20", VA = "0x18059FB20")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001603")]
	[Address(RVA = "0x59FA30", Offset = "0x59EC30", VA = "0x18059FA30")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001604")]
	[Address(RVA = "0x59F920", Offset = "0x59EB20", VA = "0x18059F920")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001605")]
	[Address(RVA = "0x59FC70", Offset = "0x59EE70", VA = "0x18059FC70")]
	public AdoptiveParent()
	{
	}
}
