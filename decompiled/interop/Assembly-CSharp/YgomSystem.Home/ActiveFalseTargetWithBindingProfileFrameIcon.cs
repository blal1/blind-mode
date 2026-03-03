using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu.Common;

namespace YgomSystem.Home;

[Token(Token = "0x2000377")]
[RequireComponent(typeof(BindingProfileFrameIcon))]
public class ActiveFalseTargetWithBindingProfileFrameIcon : ActiveFalseTarget<BindingProfileFrameIcon>
{
	[Token(Token = "0x40011EB")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Tooltip("アイコンが表示されるときに非表示にしたいGameObject")]
	private GameObject[] onlyIcons;

	[Token(Token = "0x40011EC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Tooltip("フレームが表示されるときに非表示にしたいGameObject")]
	private GameObject[] onlyFrames;

	[Token(Token = "0x6001578")]
	[Address(RVA = "0x519A20", Offset = "0x518C20", VA = "0x180519A20", Slot = "4")]
	protected override bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6001579")]
	[Address(RVA = "0x519B70", Offset = "0x518D70", VA = "0x180519B70")]
	public ActiveFalseTargetWithBindingProfileFrameIcon()
	{
	}
}
