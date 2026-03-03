using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005DA")]
public class MultiVCTabSettings : ScriptableObject
{
	[Token(Token = "0x4001C0B")]
	internal const string k_Path = "Definition/SeasonPoint/MultiVCTabSettings";

	[Token(Token = "0x4001C0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MultiVCTabCategorySetting m_CategorySetting;

	[Token(Token = "0x1700048F")]
	public MultiVCTabCategoryShowcaseData showcase
	{
		[Token(Token = "0x600263E")]
		[Address(RVA = "0x698330", Offset = "0x697530", VA = "0x180698330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600263F")]
	[Address(RVA = "0x698180", Offset = "0x697380", VA = "0x180698180")]
	public void InitMultiVCTabSetting(string prefabPath, [Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x6002640")]
	[Address(RVA = "0x698290", Offset = "0x697490", VA = "0x180698290")]
	public void UpdateCWInfo(Action onCompleted)
	{
	}

	[Token(Token = "0x6002641")]
	[Address(RVA = "0x698090", Offset = "0x697290", VA = "0x180698090")]
	public MultiVCTabCategoryData GetCategoryData(int categoryId)
	{
		return null;
	}

	[Token(Token = "0x6002642")]
	[Address(RVA = "0x6980F0", Offset = "0x6972F0", VA = "0x1806980F0")]
	public string GetCategoryLabel(int categoryId)
	{
		return null;
	}

	[Token(Token = "0x6002643")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public MultiVCTabSettings()
	{
	}
}
