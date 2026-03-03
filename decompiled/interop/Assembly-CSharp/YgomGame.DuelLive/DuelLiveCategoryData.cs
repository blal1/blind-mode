using System;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Serializable]
[Token(Token = "0x2000EEF")]
public class DuelLiveCategoryData : DuelLiveProductGroupTreeData<DuelLiveSubCategoryData>
{
	[Token(Token = "0x6005AA1")]
	[Address(RVA = "0xA01B80", Offset = "0xA00D80", VA = "0x180A01B80", Slot = "10")]
	public override bool IsMatchProduct(IProductContext product)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AA2")]
	[Address(RVA = "0xA01BE0", Offset = "0xA00DE0", VA = "0x180A01BE0")]
	public DuelLiveCategoryData()
	{
	}
}
