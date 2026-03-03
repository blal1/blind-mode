using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003A3")]
[CreateAssetMenu(menuName = "Scriptable Object/AssetLinkContainerVariant")]
public class AssetLinkContainerVariant : AssetLinkContainer
{
	[Token(Token = "0x4001278")]
	[FieldOffset(Offset = "0x20")]
	public AssetLinkContainer baseContainer;

	[Token(Token = "0x6001618")]
	[Address(RVA = "0x5A0090", Offset = "0x59F290", VA = "0x1805A0090", Slot = "4")]
	public override Container GetContainer(string label)
	{
		return null;
	}

	[Token(Token = "0x6001619")]
	[Address(RVA = "0x5A0150", Offset = "0x59F350", VA = "0x1805A0150")]
	public AssetLinkContainerVariant()
	{
	}
}
