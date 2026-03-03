using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005D9")]
[CreateAssetMenu(fileName = "MultiVCTabCategorySetting", menuName = "Scriptable Object/MultiVCTabCategorySetting")]
public class MultiVCTabCategorySetting : ScriptableObject
{
	[Token(Token = "0x4001C0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MultiVCTabCategoryShowcaseData m_ShowcaseData;

	[Token(Token = "0x1700048E")]
	public MultiVCTabCategoryShowcaseData showcase
	{
		[Token(Token = "0x6002638")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002639")]
	[Address(RVA = "0x68FC70", Offset = "0x68EE70", VA = "0x18068FC70")]
	public void InitMultiVCTabCategorySetting()
	{
	}

	[Token(Token = "0x600263A")]
	[Address(RVA = "0x68ECC0", Offset = "0x68DEC0", VA = "0x18068ECC0")]
	public void ClientWorkInfoSet(string CWpath, [Optional] Action onComplated)
	{
	}

	[Token(Token = "0x600263B")]
	[Address(RVA = "0x690890", Offset = "0x68FA90", VA = "0x180690890")]
	private void SetActiveAll()
	{
	}

	[Token(Token = "0x600263C")]
	[Address(RVA = "0x68FC10", Offset = "0x68EE10", VA = "0x18068FC10")]
	public MultiVCTabCategoryData GetCategoryData(int categoryId)
	{
		return null;
	}

	[Token(Token = "0x600263D")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public MultiVCTabCategorySetting()
	{
	}
}
