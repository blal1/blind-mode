using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI;

[Token(Token = "0x200042F")]
public class ScreenSelector : Selector
{
	[Token(Token = "0x2000430")]
	public enum Type
	{
		[Token(Token = "0x4001480")]
		FullScreen,
		[Token(Token = "0x4001481")]
		Untouchable
	}

	[Token(Token = "0x400147E")]
	[FieldOffset(Offset = "0x138")]
	private List<SelectionButton> buttonList;

	[Token(Token = "0x6001ADF")]
	[Address(RVA = "0x5ECAF0", Offset = "0x5EBCF0", VA = "0x1805ECAF0")]
	public static ScreenSelector Create(Transform parent, string group_label, int group_priority)
	{
		return null;
	}

	[Token(Token = "0x6001AE0")]
	[Address(RVA = "0x5EC940", Offset = "0x5EBB40", VA = "0x1805EC940")]
	public SelectionButton AddShortCutKeyReceiver(SelectorManager.KeyType key_type, Type type, UnityAction click_event)
	{
		return null;
	}

	[Token(Token = "0x6001AE1")]
	[Address(RVA = "0x5ECBD0", Offset = "0x5EBDD0", VA = "0x1805ECBD0")]
	public void DeleteAllShortCutButton()
	{
	}

	[Token(Token = "0x6001AE2")]
	[Address(RVA = "0x5ECD20", Offset = "0x5EBF20", VA = "0x1805ECD20")]
	public ScreenSelector()
	{
	}
}
