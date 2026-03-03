using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.MDMarkup;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;

namespace YgomSystem.Home;

[Token(Token = "0x2000391")]
public class TopicsBannerWidget : IAsyncProgressContainer
{
	[Token(Token = "0x400124B")]
	[FieldOffset(Offset = "0x10")]
	private List<IAsyncProgressContent> m_AsyncProgressContents;

	[Token(Token = "0x400124C")]
	[FieldOffset(Offset = "0x18")]
	public ElementObjectManager rootEom;

	[Token(Token = "0x17000238")]
	public IReadOnlyList<IAsyncProgressContent> asyncProgressContents
	{
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60015D6")]
	[Address(RVA = "0x5C2FF0", Offset = "0x5C21F0", VA = "0x1805C2FF0")]
	public static TopicsBannerWidget Create(GameObject parent, MDMarkupBannerContext bannerContext, bool skipMerge = false, BindingGameObjectEx.FitMode fitMode = BindingGameObjectEx.FitMode.SCALE)
	{
		return null;
	}

	[Token(Token = "0x60015D7")]
	[Address(RVA = "0x5C3480", Offset = "0x5C2680", VA = "0x1805C3480")]
	private TopicsBannerWidget InnerBinding(GameObject parent, string prefPath, Dictionary<string, object> prefArgs, BindingGameObjectEx.FitMode fitMode)
	{
		return null;
	}

	[Token(Token = "0x60015D8")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
	private TopicsBannerWidget FailedInnerBinding(Dictionary<string, object> prefArgs)
	{
		return null;
	}

	[Token(Token = "0x60015D9")]
	[Address(RVA = "0x5C2F90", Offset = "0x5C2190", VA = "0x1805C2F90")]
	private void ClearProgressContent()
	{
	}

	[Token(Token = "0x60015DA")]
	[Address(RVA = "0x5C2E60", Offset = "0x5C2060", VA = "0x1805C2E60")]
	private void AssignProgressContent(IAsyncProgressContent progressContent)
	{
	}

	[Token(Token = "0x60015DB")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TopicsBannerWidget()
	{
	}
}
