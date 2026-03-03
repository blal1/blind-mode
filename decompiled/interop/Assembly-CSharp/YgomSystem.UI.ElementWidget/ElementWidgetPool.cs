using System;
using Il2CppDummyDll;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x200060F")]
public class ElementWidgetPool<T> : UIObjectPool<T> where T : ElementWidgetBase
{
	[Token(Token = "0x4001D20")]
	[FieldOffset(Offset = "0x0")]
	private readonly Func<T> m_Factory;

	[Token(Token = "0x60027BB")]
	public ElementWidgetPool(Func<T> factory)
	{
	}

	[Token(Token = "0x60027BC")]
	protected override T Create()
	{
		return null;
	}

	[Token(Token = "0x60027BD")]
	protected override void OnBeforeRent(T obj)
	{
	}

	[Token(Token = "0x60027BE")]
	protected override void OnBeforeReturn(T obj)
	{
	}
}
