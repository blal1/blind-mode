using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200049A")]
public class SelectionItemChangeListener : MonoBehaviour
{
	[Token(Token = "0x4001684")]
	[FieldOffset(Offset = "0x20")]
	private SelectionItem m_LastSelectItem;

	[Token(Token = "0x14000026")]
	public event Action<SelectionItem, SelectionItem> onChangedSelectionItemEvent
	{
		[Token(Token = "0x6001E27")]
		[Address(RVA = "0x616120", Offset = "0x615320", VA = "0x180616120")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001E28")]
		[Address(RVA = "0x6161D0", Offset = "0x6153D0", VA = "0x1806161D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6001E29")]
	[Address(RVA = "0x616010", Offset = "0x615210", VA = "0x180616010")]
	public static SelectionItemChangeListener Attach(GameObject owner)
	{
		return null;
	}

	[Token(Token = "0x6001E2A")]
	[Address(RVA = "0x616050", Offset = "0x615250", VA = "0x180616050")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001E2B")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SelectionItemChangeListener()
	{
	}
}
