using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Bg;
using YgomGame.DuelPreview;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop.ProductViewer;

[Token(Token = "0x20009F0")]
public class ProductViewerWidget : ElementWidgetBase, ILoadingIconHandler
{
	[Token(Token = "0x20009F1")]
	[CompilerGenerated]
	private sealed class _003CyPlayCardThumbRoll_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008E77")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008E78")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008E79")]
		[FieldOffset(Offset = "0x20")]
		public ProductViewerWidget _003C_003E4__this;

		[Token(Token = "0x4008E7A")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator _003CplayRoutine_003E5__2;

		[Token(Token = "0x1700080C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003CA8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700080D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003CAA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003CA5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayCardThumbRoll_003Ed__54(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003CA6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003CA7")]
		[Address(RVA = "0x8443D0", Offset = "0x8435D0", VA = "0x1808443D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003CA9")]
		[Address(RVA = "0x844780", Offset = "0x843980", VA = "0x180844780", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4008E5C")]
	private const string k_TLabel_FadeIn = "FadeIn";

	[Token(Token = "0x4008E5D")]
	private const string k_TLabel_FadeOut = "FadeOut";

	[Token(Token = "0x4008E5E")]
	[FieldOffset(Offset = "0x20")]
	public readonly ThumbWidget thumbMain;

	[Token(Token = "0x4008E5F")]
	[FieldOffset(Offset = "0x28")]
	public readonly ThumbWidget thumbSub;

	[Token(Token = "0x4008E60")]
	[FieldOffset(Offset = "0x30")]
	public readonly RawImage summonRawImage;

	[Token(Token = "0x4008E61")]
	[FieldOffset(Offset = "0x38")]
	public readonly SelectionButton mateButton;

	[Token(Token = "0x4008E62")]
	[FieldOffset(Offset = "0x40")]
	public readonly GameObject infoRoot;

	[Token(Token = "0x4008E63")]
	[FieldOffset(Offset = "0x48")]
	public readonly GameObject limitGroup;

	[Token(Token = "0x4008E64")]
	[FieldOffset(Offset = "0x50")]
	public readonly TMP_Text limitText;

	[Token(Token = "0x4008E65")]
	[FieldOffset(Offset = "0x58")]
	public readonly GameObject limitDateGroup;

	[Token(Token = "0x4008E66")]
	[FieldOffset(Offset = "0x60")]
	public readonly TMP_Text limitDateText;

	[Token(Token = "0x4008E67")]
	[FieldOffset(Offset = "0x68")]
	public readonly GameObject numGroup;

	[Token(Token = "0x4008E68")]
	[FieldOffset(Offset = "0x70")]
	public readonly TMP_Text numText;

	[Token(Token = "0x4008E69")]
	[FieldOffset(Offset = "0x78")]
	public readonly GameObject packPickupMessageGroup;

	[Token(Token = "0x4008E6A")]
	[FieldOffset(Offset = "0x80")]
	public readonly TMP_Text packPickupMessage;

	[Token(Token = "0x4008E6B")]
	[FieldOffset(Offset = "0x88")]
	public readonly GameObject loadingCoverRoot;

	[Token(Token = "0x4008E6C")]
	[FieldOffset(Offset = "0x90")]
	private Coroutine m_ThumbRollRoutine;

	[Token(Token = "0x4008E6D")]
	[FieldOffset(Offset = "0x98")]
	private int m_CurrentIdx;

	[Token(Token = "0x4008E6E")]
	[FieldOffset(Offset = "0x9C")]
	private int m_DstIdx;

	[Token(Token = "0x4008E6F")]
	[FieldOffset(Offset = "0xA0")]
	public int loopStartIdx;

	[Token(Token = "0x4008E70")]
	[FieldOffset(Offset = "0xA4")]
	public int loopBreakIdx;

	[Token(Token = "0x4008E71")]
	[FieldOffset(Offset = "0xA8")]
	private IReadOnlyList<IThumbPlayer> m_ThumbPlayers;

	[Token(Token = "0x4008E74")]
	[FieldOffset(Offset = "0xC0")]
	public YgomGame.DuelPreview.DuelPreviewPlayer previewPlayer;

	[Token(Token = "0x4008E75")]
	[FieldOffset(Offset = "0xC8")]
	public bool reverseFrag;

	[Token(Token = "0x4008E76")]
	[FieldOffset(Offset = "0xD0")]
	private ProductContext m_ProductCtx;

	[Token(Token = "0x17000806")]
	public GameObject duelLiveButtonRoot
	{
		[Token(Token = "0x6003C86")]
		[Address(RVA = "0x824BE0", Offset = "0x823DE0", VA = "0x180824BE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000807")]
	public SelectionButton duelLiveButton
	{
		[Token(Token = "0x6003C87")]
		[Address(RVA = "0x824C30", Offset = "0x823E30", VA = "0x180824C30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000808")]
	public IReadOnlyList<IThumbPlayer> thumbPlayers
	{
		[Token(Token = "0x6003C88")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000809")]
	public bool enabledThumbAspectRatio
	{
		[Token(Token = "0x6003C8D")]
		[Address(RVA = "0x824C90", Offset = "0x823E90", VA = "0x180824C90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003C8E")]
		[Address(RVA = "0x824E60", Offset = "0x824060", VA = "0x180824E60")]
		set
		{
		}
	}

	[Token(Token = "0x1700080A")]
	public int currentIdx
	{
		[Token(Token = "0x6003C8F")]
		[Address(RVA = "0x3DDD20", Offset = "0x3DCF20", VA = "0x1803DDD20")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003C90")]
		[Address(RVA = "0x824E30", Offset = "0x824030", VA = "0x180824E30")]
		set
		{
		}
	}

	[Token(Token = "0x1700080B")]
	public bool isPlayingThumbRoll
	{
		[Token(Token = "0x6003C92")]
		[Address(RVA = "0x824CC0", Offset = "0x823EC0", VA = "0x180824CC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400004C")]
	public event Action onChangeIdxEvent
	{
		[Token(Token = "0x6003C89")]
		[Address(RVA = "0x824A80", Offset = "0x823C80", VA = "0x180824A80")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003C8A")]
		[Address(RVA = "0x824CD0", Offset = "0x823ED0", VA = "0x180824CD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400004D")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6003C8B")]
		[Address(RVA = "0x824B30", Offset = "0x823D30", VA = "0x180824B30", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003C8C")]
		[Address(RVA = "0x824D80", Offset = "0x823F80", VA = "0x180824D80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003C91")]
	[Address(RVA = "0x822D90", Offset = "0x821F90", VA = "0x180822D90")]
	public int GetNextIdx(int baseIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6003C93")]
	[Address(RVA = "0x823160", Offset = "0x822360", VA = "0x180823160")]
	public int IndexOfContext(HighlightContext context)
	{
		return default(int);
	}

	[Token(Token = "0x6003C94")]
	[Address(RVA = "0x823300", Offset = "0x822500", VA = "0x180823300")]
	public int IndexOfPlayContext(HighlightContext context)
	{
		return default(int);
	}

	[Token(Token = "0x6003C95")]
	[Address(RVA = "0x823A90", Offset = "0x822C90", VA = "0x180823A90")]
	public bool MatchContextAt(int index, HighlightContext other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C96")]
	[Address(RVA = "0x8239C0", Offset = "0x822BC0", VA = "0x1808239C0", Slot = "11")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6003C97")]
	[Address(RVA = "0x8244A0", Offset = "0x8236A0", VA = "0x1808244A0")]
	public ProductViewerWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003C98")]
	[Address(RVA = "0x8234B0", Offset = "0x8226B0", VA = "0x1808234B0")]
	public void Initialize(IReadOnlyList<IThumbPlayer> thumbPlayers, int previewMateId, ProductContext productCtx)
	{
	}

	[Token(Token = "0x6003C99")]
	[Address(RVA = "0x823F90", Offset = "0x823190", VA = "0x180823F90")]
	public void PlayThumbRoll(int startIdx)
	{
	}

	[Token(Token = "0x6003C9A")]
	[Address(RVA = "0x823E30", Offset = "0x823030", VA = "0x180823E30")]
	public void PlayThumbOnce(int startIdx, int dstIdx = -1)
	{
	}

	[Token(Token = "0x6003C9B")]
	[Address(RVA = "0x824EC0", Offset = "0x8240C0", VA = "0x180824EC0")]
	[IteratorStateMachine(typeof(_003CyPlayCardThumbRoll_003Ed__54))]
	private IEnumerator yPlayCardThumbRoll()
	{
		return null;
	}

	[Token(Token = "0x6003C9C")]
	[Address(RVA = "0x824350", Offset = "0x823550", VA = "0x180824350")]
	public void StopThumbRoll()
	{
	}

	[Token(Token = "0x6003C9D")]
	[Address(RVA = "0x824120", Offset = "0x823320", VA = "0x180824120")]
	public void SetThumb(int idx)
	{
	}

	[Token(Token = "0x6003C9E")]
	[Address(RVA = "0x823D60", Offset = "0x822F60", VA = "0x180823D60")]
	public void PlayMateMotion(AvatarMotionSetting.MotionID motionId)
	{
	}

	[Token(Token = "0x6003C9F")]
	[Address(RVA = "0x823C00", Offset = "0x822E00", VA = "0x180823C00")]
	private void OnRequestedFadeInInfo(bool immediate)
	{
	}

	[Token(Token = "0x6003CA0")]
	[Address(RVA = "0x822F90", Offset = "0x822190", VA = "0x180822F90")]
	private void OnRequestedFadeOutInfo(bool immediate)
	{
	}

	[Token(Token = "0x6003CA1")]
	[Address(RVA = "0x823C00", Offset = "0x822E00", VA = "0x180823C00")]
	public void ShowInfoArea(bool immediate = true)
	{
	}

	[Token(Token = "0x6003CA2")]
	[Address(RVA = "0x822F90", Offset = "0x822190", VA = "0x180822F90")]
	public void HideInfoArea(bool immediate = true)
	{
	}

	[Token(Token = "0x6003CA3")]
	[Address(RVA = "0x8243B0", Offset = "0x8235B0", VA = "0x1808243B0")]
	private void UpdateLoadingCoverVisible(HighlightContext context)
	{
	}

	[Token(Token = "0x6003CA4")]
	[Address(RVA = "0x8240E0", Offset = "0x8232E0", VA = "0x1808240E0")]
	public void ReleaseResources()
	{
	}
}
