using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000261")]
internal class UIDocumentList
{
	[Token(Token = "0x4000960")]
	[FieldOffset(Offset = "0x10")]
	internal List<UIDocument> m_AttachedUIDocuments;

	[Token(Token = "0x60010A9")]
	[Address(RVA = "0x2B3D0F0", Offset = "0x2B3C2F0", VA = "0x182B3D0F0")]
	internal void RemoveFromListAndFromVisualTree(UIDocument uiDocument)
	{
	}

	[Token(Token = "0x60010AA")]
	[Address(RVA = "0x2B3CD80", Offset = "0x2B3BF80", VA = "0x182B3CD80")]
	internal void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, int firstInsertIndex = 0)
	{
	}

	[Token(Token = "0x60010AB")]
	[Address(RVA = "0x2B3D160", Offset = "0x2B3C360", VA = "0x182B3D160")]
	public UIDocumentList()
	{
	}
}
