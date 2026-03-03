using System;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Serializable]
[Token(Token = "0x2000EF0")]
public class DuelLiveCategoryShowcaseData : DuelLiveProductGroupTreeData<DuelLiveCategoryData>
{
	[Token(Token = "0x6005AA3")]
	[Address(RVA = "0xA08F10", Offset = "0xA08110", VA = "0x180A08F10")]
	public DuelLiveCategoryShowcaseData()
	{
	}
}
