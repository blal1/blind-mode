using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000505")]
public class TweenInvokerOnVisible : TweenInvokerBase
{
	[Token(Token = "0x40018BE")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CanvasRenderer m_VisibleCheckRenderer;

	[Token(Token = "0x60020DD")]
	[Address(RVA = "0x63BDC0", Offset = "0x63AFC0", VA = "0x18063BDC0", Slot = "4")]
	protected override bool IsInvokable()
	{
		return default(bool);
	}

	[Token(Token = "0x60020DE")]
	[Address(RVA = "0x633000", Offset = "0x632200", VA = "0x180633000")]
	public TweenInvokerOnVisible()
	{
	}
}
