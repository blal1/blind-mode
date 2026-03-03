using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x2000516")]
[RequireComponent(typeof(Text))]
[AddComponentMenu("Ygom/UI/Binding/Binding Font")]
public class BindingFont : MonoBehaviour
{
	[Token(Token = "0x40018E9")]
	[FieldOffset(Offset = "0x0")]
	public static Font font;

	[Token(Token = "0x40018EA")]
	[FieldOffset(Offset = "0x20")]
	public Text text;

	[Token(Token = "0x60020F8")]
	[Address(RVA = "0x6313F0", Offset = "0x6305F0", VA = "0x1806313F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60020F9")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public BindingFont()
	{
	}
}
