using System;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x2000610")]
public class ElementWidgetTemplatePool<T> : UIObjectPool<T> where T : ElementWidgetBase
{
	[Token(Token = "0x4001D21")]
	[FieldOffset(Offset = "0x0")]
	private Func<ElementObjectManager, T> m_Factory;

	[Token(Token = "0x4001D22")]
	[FieldOffset(Offset = "0x0")]
	private readonly Transform m_Parent;

	[Token(Token = "0x4001D23")]
	[FieldOffset(Offset = "0x0")]
	private readonly ElementObjectManager m_Template;

	[Token(Token = "0x60027BF")]
	public ElementWidgetTemplatePool(Transform parent, ElementObjectManager template, Func<ElementObjectManager, T> factory)
	{
	}

	[Token(Token = "0x60027C0")]
	protected override T Create()
	{
		return null;
	}

	[Token(Token = "0x60027C1")]
	protected override void OnAfterCreate(T obj)
	{
	}
}
