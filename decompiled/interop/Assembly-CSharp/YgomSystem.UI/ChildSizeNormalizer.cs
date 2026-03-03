using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200052C")]
[ExecuteInEditMode]
public class ChildSizeNormalizer : MonoBehaviour
{
	[Token(Token = "0x4001938")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform.Axis _mode;

	[Token(Token = "0x4001939")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _spacing;

	[Token(Token = "0x400193A")]
	[FieldOffset(Offset = "0x28")]
	private int childCount;

	[Token(Token = "0x400193B")]
	[FieldOffset(Offset = "0x2C")]
	private float spacing;

	[Token(Token = "0x400193C")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform _rectTransform;

	[Token(Token = "0x400193D")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform.Axis mode;

	[Token(Token = "0x400193E")]
	[FieldOffset(Offset = "0x3C")]
	private Rect rect;

	[Token(Token = "0x1700036C")]
	private RectTransform rectTransform
	{
		[Token(Token = "0x600218E")]
		[Address(RVA = "0x6480D0", Offset = "0x6472D0", VA = "0x1806480D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600218F")]
	[Address(RVA = "0x648000", Offset = "0x647200", VA = "0x180648000")]
	private void Update()
	{
	}

	[Token(Token = "0x6002190")]
	[Address(RVA = "0x647FF0", Offset = "0x6471F0", VA = "0x180647FF0")]
	private void Reset()
	{
	}

	[Token(Token = "0x6002191")]
	[Address(RVA = "0x647CF0", Offset = "0x646EF0", VA = "0x180647CF0")]
	public void NormalizeChildSize()
	{
	}

	[Token(Token = "0x6002192")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ChildSizeNormalizer()
	{
	}
}
