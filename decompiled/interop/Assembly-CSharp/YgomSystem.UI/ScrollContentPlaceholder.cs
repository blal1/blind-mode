using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000468")]
public abstract class ScrollContentPlaceholder<Content> where Content : class
{
	[Token(Token = "0x4001588")]
	[FieldOffset(Offset = "0x0")]
	protected RectTransform m_RectTransform;

	[Token(Token = "0x4001589")]
	[FieldOffset(Offset = "0x0")]
	private Content m_Content;

	[Token(Token = "0x6001C6C")]
	protected ScrollContentPlaceholder(Transform parent, RectTransform viewport)
	{
	}

	[Token(Token = "0x6001C6D")]
	private void OnChangeContainViewport(bool isContain)
	{
	}

	[Token(Token = "0x6001C6E")]
	protected abstract Content CreateContent();

	[Token(Token = "0x6001C6F")]
	protected abstract void UpdateContent(Content content);

	[Token(Token = "0x6001C70")]
	protected virtual void OnReleaseContent(Content content)
	{
	}
}
