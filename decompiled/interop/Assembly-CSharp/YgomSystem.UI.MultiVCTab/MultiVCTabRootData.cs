using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005D1")]
public class MultiVCTabRootData
{
	[Token(Token = "0x4001BFF")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string m_MasterTabDataPath;

	[Token(Token = "0x4001C00")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool m_IsDescendingChildOrder;

	[Token(Token = "0x1700048C")]
	public string masterTabDataPath
	{
		[Token(Token = "0x600262B")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700048D")]
	public bool isDescendingChildOrder
	{
		[Token(Token = "0x600262C")]
		[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600262D")]
	[Address(RVA = "0x696B90", Offset = "0x695D90", VA = "0x180696B90")]
	public MultiVCTabRootData()
	{
	}
}
