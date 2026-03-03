using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x20004F2")]
[AddComponentMenu("Ygom/UI/Tween/Tween Scroll")]
public class TweenScroll : Tween
{
	[Token(Token = "0x20004F3")]
	public enum SCROLL_TYPE
	{
		[Token(Token = "0x4001869")]
		HORIZONTAL,
		[Token(Token = "0x400186A")]
		VERTICAL
	}

	[Token(Token = "0x4001863")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public float from;

	[Token(Token = "0x4001864")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	public float to;

	[Token(Token = "0x4001865")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public SCROLL_TYPE scrollType;

	[Token(Token = "0x4001866")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public bool normalize;

	[Token(Token = "0x4001867")]
	[FieldOffset(Offset = "0x80")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x17000354")]
	private ScrollRect scrollRect
	{
		[Token(Token = "0x60020A1")]
		[Address(RVA = "0x63ED60", Offset = "0x63DF60", VA = "0x18063ED60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x63EA90", Offset = "0x63DC90", VA = "0x18063EA90", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x60020A3")]
	[Address(RVA = "0x63EBD0", Offset = "0x63DDD0", VA = "0x18063EBD0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x60020A4")]
	[Address(RVA = "0x63ED00", Offset = "0x63DF00", VA = "0x18063ED00")]
	public TweenScroll()
	{
	}
}
