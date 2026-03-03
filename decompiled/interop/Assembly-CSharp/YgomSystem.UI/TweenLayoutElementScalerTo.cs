using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004E9")]
[AddComponentMenu("Ygom/UI/Tween/Tween TweenLayoutElementScaler To")]
public class TweenLayoutElementScalerTo : Tween
{
	[Token(Token = "0x4001842")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float m_ToWidthScale;

	[Token(Token = "0x4001843")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float m_ToHeightScale;

	[Token(Token = "0x4001844")]
	[FieldOffset(Offset = "0x78")]
	private float m_FromWidthScale;

	[Token(Token = "0x4001845")]
	[FieldOffset(Offset = "0x7C")]
	private float m_FromHeightScale;

	[Token(Token = "0x4001846")]
	[FieldOffset(Offset = "0x80")]
	private LayoutElementScaler m_LayoutElementScalerCache;

	[Token(Token = "0x17000353")]
	private LayoutElementScaler layoutElementScaler
	{
		[Token(Token = "0x6002086")]
		[Address(RVA = "0x63CC90", Offset = "0x63BE90", VA = "0x18063CC90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002087")]
	[Address(RVA = "0x63CB40", Offset = "0x63BD40", VA = "0x18063CB40", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x6002088")]
	[Address(RVA = "0x63CB80", Offset = "0x63BD80", VA = "0x18063CB80", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x6002089")]
	[Address(RVA = "0x63CC20", Offset = "0x63BE20", VA = "0x18063CC20")]
	public TweenLayoutElementScalerTo()
	{
	}
}
