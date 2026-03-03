using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.MDMarkup;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomSystem.Home;

[Token(Token = "0x200037F")]
public class BindingTopicsBanner : MonoBehaviour, IAsyncProgressContainer, ILoadingIconHandler
{
	[Token(Token = "0x40011F5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MDMarkupBannerContext m_BannerContext;

	[Token(Token = "0x40011F6")]
	[FieldOffset(Offset = "0x28")]
	private TopicsBannerWidget m_TopicsBanner;

	[Token(Token = "0x40011F7")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Visible;

	[Token(Token = "0x1700022E")]
	public MDMarkupBannerContext bannerContext
	{
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022F")]
	public TopicsBannerWidget topicsBanner
	{
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000230")]
	public bool visible
	{
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x51FF50", Offset = "0x51F150", VA = "0x18051FF50")]
		set
		{
		}
	}

	[Token(Token = "0x17000231")]
	public IReadOnlyList<IAsyncProgressContent> asyncProgressContents
	{
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x51FE60", Offset = "0x51F060", VA = "0x18051FE60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000014")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x51FDC0", Offset = "0x51EFC0", VA = "0x18051FDC0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x51FEB0", Offset = "0x51F0B0", VA = "0x18051FEB0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6001592")]
	[Address(RVA = "0x51FD10", Offset = "0x51EF10", VA = "0x18051FD10")]
	private void Update()
	{
	}

	[Token(Token = "0x6001593")]
	[Address(RVA = "0x51FA60", Offset = "0x51EC60", VA = "0x18051FA60")]
	public void ApplyContext(BindingGameObjectEx.FitMode fitMode = BindingGameObjectEx.FitMode.SCALE)
	{
	}

	[Token(Token = "0x6001594")]
	[Address(RVA = "0x51FAE0", Offset = "0x51ECE0", VA = "0x18051FAE0", Slot = "6")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6001595")]
	[Address(RVA = "0x51FC70", Offset = "0x51EE70", VA = "0x18051FC70")]
	private void RefreshVisible()
	{
	}

	[Token(Token = "0x6001596")]
	[Address(RVA = "0x51FD50", Offset = "0x51EF50", VA = "0x18051FD50")]
	public BindingTopicsBanner()
	{
	}
}
