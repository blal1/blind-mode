using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200049B")]
[RequireComponent(typeof(SelectionItem))]
public class SelectionTransitionReciever : MonoBehaviour
{
	[Token(Token = "0x4001686")]
	[FieldOffset(Offset = "0x20")]
	public List<SelectionItem> m_ThrowTargets;

	[Token(Token = "0x4001687")]
	[FieldOffset(Offset = "0x28")]
	private SelectionItem m_RecieverCache;

	[Token(Token = "0x170002EC")]
	public SelectionItem recieverItem
	{
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x616670", Offset = "0x615870", VA = "0x180616670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001E2D")]
	[Address(RVA = "0x616280", Offset = "0x615480", VA = "0x180616280")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001E2E")]
	[Address(RVA = "0x616330", Offset = "0x615530", VA = "0x180616330")]
	public bool ThrowToNearTarget()
	{
		return default(bool);
	}

	[Token(Token = "0x6001E2F")]
	[Address(RVA = "0x616320", Offset = "0x615520", VA = "0x180616320")]
	private void OnSelected()
	{
	}

	[Token(Token = "0x6001E30")]
	[Address(RVA = "0x6165C0", Offset = "0x6157C0", VA = "0x1806165C0")]
	public SelectionTransitionReciever()
	{
	}
}
