using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x200018E")]
[RequireComponent(typeof(RectTransform))]
public class SafeAreaScreen : MonoBehaviour
{
	[Token(Token = "0x200018F")]
	public enum Mode
	{
		[Token(Token = "0x4000958")]
		None,
		[Token(Token = "0x4000959")]
		SafeArea,
		[Token(Token = "0x400095A")]
		MinOnly,
		[Token(Token = "0x400095B")]
		MaxOnly,
		[Token(Token = "0x400095C")]
		MinOutside,
		[Token(Token = "0x400095D")]
		MaxOutside
	}

	[Token(Token = "0x4000954")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Mode verticalMode;

	[Token(Token = "0x4000955")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Mode horizontalMode;

	[Token(Token = "0x4000956")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool fillRectTransformOnApplySafeArea;

	[Token(Token = "0x60009DA")]
	[Address(RVA = "0xB034E0", Offset = "0xB026E0", VA = "0x180B034E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60009DB")]
	[Address(RVA = "0xB03430", Offset = "0xB02630", VA = "0x180B03430")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60009DC")]
	[Address(RVA = "0xB035F0", Offset = "0xB027F0", VA = "0x180B035F0")]
	public void SetSafeArea()
	{
	}

	[Token(Token = "0x60009DD")]
	[Address(RVA = "0xB038E0", Offset = "0xB02AE0", VA = "0x180B038E0")]
	public SafeAreaScreen()
	{
	}
}
