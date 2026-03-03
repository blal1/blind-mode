using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Effect;

namespace YgomSystem.UI;

[Token(Token = "0x20004AE")]
[RequireComponent(typeof(Selector))]
public class SelectorCameraSetter : MonoBehaviour
{
	[Token(Token = "0x20004AF")]
	public enum FindType
	{
		[Token(Token = "0x40016DD")]
		ByParentCanvas,
		[Token(Token = "0x40016DE")]
		ByScreenEffect
	}

	[Token(Token = "0x40016DA")]
	[FieldOffset(Offset = "0x20")]
	public FindType findType;

	[Token(Token = "0x40016DB")]
	[FieldOffset(Offset = "0x28")]
	[Header("各FindType用設定")]
	public ScreenEffect targetScreenEffect;

	[Token(Token = "0x6001ED3")]
	[Address(RVA = "0x619960", Offset = "0x618B60", VA = "0x180619960")]
	private void Start()
	{
	}

	[Token(Token = "0x6001ED4")]
	[Address(RVA = "0x619890", Offset = "0x618A90", VA = "0x180619890")]
	private Camera FindCamera()
	{
		return null;
	}

	[Token(Token = "0x6001ED5")]
	[Address(RVA = "0x6197D0", Offset = "0x6189D0", VA = "0x1806197D0")]
	public static Camera FindCameraByParentCanvas(GameObject target)
	{
		return null;
	}

	[Token(Token = "0x6001ED6")]
	[Address(RVA = "0x619830", Offset = "0x618A30", VA = "0x180619830")]
	public static Camera FindCameraByScreenEffect(GameObject target, ScreenEffect screenEffect)
	{
		return null;
	}

	[Token(Token = "0x6001ED7")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SelectorCameraSetter()
	{
	}
}
