using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.DuelPreview;
using YgomSystem.ElementSystem;

namespace YgomGame.CardBrowser;

[Token(Token = "0x20015C3")]
public class CardBrowserDuelPreviewPlayer : MonoBehaviour
{
	[Token(Token = "0x20015C4")]
	private class DuelPreviewWidget
	{
		[Token(Token = "0x400CEE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ElementObjectManager eom;

		[Token(Token = "0x400CEE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly RawImage rawImage;

		[Token(Token = "0x170014B3")]
		public GameObject gameObject
		{
			[Token(Token = "0x6008713")]
			[Address(RVA = "0x977BA0", Offset = "0x976DA0", VA = "0x180977BA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014B4")]
		public Transform transform
		{
			[Token(Token = "0x6008714")]
			[Address(RVA = "0xCF9D70", Offset = "0xCF8F70", VA = "0x180CF9D70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014B5")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6008715")]
			[Address(RVA = "0xCF9D10", Offset = "0xCF8F10", VA = "0x180CF9D10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008716")]
		[Address(RVA = "0xCF9C80", Offset = "0xCF8E80", VA = "0x180CF9C80")]
		public DuelPreviewWidget(ElementObjectManager eom)
		{
		}
	}

	[Token(Token = "0x20015C5")]
	private class PlayingInfo
	{
		[Token(Token = "0x400CEE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform statusRect;

		[Token(Token = "0x400CEE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform playerRect;

		[Token(Token = "0x400CEE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Coroutine playRoutine;

		[Token(Token = "0x170014B6")]
		public bool ExistsTweenTarget
		{
			[Token(Token = "0x6008717")]
			[Address(RVA = "0xCFA260", Offset = "0xCF9460", VA = "0x180CFA260")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6008718")]
		[Address(RVA = "0xCFA210", Offset = "0xCF9410", VA = "0x180CFA210")]
		public void Clear()
		{
		}

		[Token(Token = "0x6008719")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public PlayingInfo()
		{
		}
	}

	[Token(Token = "0x20015C6")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x400CEE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CardBrowserDuelPreviewPlayer _003C_003E4__this;

		[Token(Token = "0x400CEE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RawImage targetImage;

		[Token(Token = "0x400CEEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool donePlay;

		[Token(Token = "0x600871A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Token(Token = "0x600871B")]
		[Address(RVA = "0xCFACC0", Offset = "0xCF9EC0", VA = "0x180CFACC0")]
		internal void _003CyPlay_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20015C7")]
	[CompilerGenerated]
	private sealed class _003CyPlay_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400CEEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400CEEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400CEED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardBrowserDuelPreviewPlayer _003C_003E4__this;

		[Token(Token = "0x400CEEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		[Token(Token = "0x400CEEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int mrk;

		[Token(Token = "0x400CEF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onComplete;

		[Token(Token = "0x170014B7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600871F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014B8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008721")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600871C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlay_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600871D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600871E")]
		[Address(RVA = "0xCFBBE0", Offset = "0xCFADE0", VA = "0x180CFBBE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008720")]
		[Address(RVA = "0xCFC140", Offset = "0xCFB340", VA = "0x180CFC140", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400CED9")]
	private const string k_WidgetPrefPath = "DuelPreview/DuelPreviewWidget";

	[Token(Token = "0x400CEDA")]
	private const string k_TLabelFadeIn = "DuelPreviewFadeIn";

	[Token(Token = "0x400CEDB")]
	private const string k_TLabelFadeOut = "DuelPreviewFadeOut";

	[Token(Token = "0x400CEDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DuelPreviewPlayer m_Player;

	[Token(Token = "0x400CEDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_Ready;

	[Token(Token = "0x400CEDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ElementObjectManager m_DuelPreviewWidgetPref;

	[Token(Token = "0x400CEDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<RectTransform, DuelPreviewWidget> m_TargetWidgetMap;

	[Token(Token = "0x400CEE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PlayingInfo m_PlayingInfo;

	[Token(Token = "0x170014B1")]
	public bool ready
	{
		[Token(Token = "0x60086FF")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170014B2")]
	public bool isPlaying
	{
		[Token(Token = "0x6008700")]
		[Address(RVA = "0xCE4C10", Offset = "0xCE3E10", VA = "0x180CE4C10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x140000B7")]
	public event Action onPlayPreviewStart
	{
		[Token(Token = "0x6008701")]
		[Address(RVA = "0xCE4B70", Offset = "0xCE3D70", VA = "0x180CE4B70")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6008702")]
		[Address(RVA = "0xCE4CD0", Offset = "0xCE3ED0", VA = "0x180CE4CD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000B8")]
	public event Action onPlayPreviewEnd
	{
		[Token(Token = "0x6008703")]
		[Address(RVA = "0xCE4AD0", Offset = "0xCE3CD0", VA = "0x180CE4AD0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6008704")]
		[Address(RVA = "0xCE4C30", Offset = "0xCE3E30", VA = "0x180CE4C30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6008705")]
	[Address(RVA = "0xCE48A0", Offset = "0xCE3AA0", VA = "0x180CE48A0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6008706")]
	[Address(RVA = "0xCE4010", Offset = "0xCE3210", VA = "0x180CE4010")]
	public void Play(RectTransform statusRect, RectTransform playerRect, int mrk, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6008707")]
	[Address(RVA = "0xCE4D70", Offset = "0xCE3F70", VA = "0x180CE4D70")]
	[IteratorStateMachine(typeof(_003CyPlay_003Ed__22))]
	private IEnumerator yPlay(int mrk, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6008708")]
	[Address(RVA = "0xCE43B0", Offset = "0xCE35B0", VA = "0x180CE43B0")]
	private void SetFieldSprite(RawImage targetImage, bool applyAspect)
	{
	}

	[Token(Token = "0x6008709")]
	[Address(RVA = "0xCE38A0", Offset = "0xCE2AA0", VA = "0x180CE38A0")]
	private RawImage GetOrCreateRawImage(RectTransform targetRect)
	{
		return null;
	}

	[Token(Token = "0x600870A")]
	[Address(RVA = "0xCE4170", Offset = "0xCE3370", VA = "0x180CE4170")]
	public void Release()
	{
	}

	[Token(Token = "0x600870B")]
	[Address(RVA = "0xCE3CE0", Offset = "0xCE2EE0", VA = "0x180CE3CE0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600870C")]
	[Address(RVA = "0x766D80", Offset = "0x765F80", VA = "0x180766D80")]
	private void OnPlayPreviewStart()
	{
	}

	[Token(Token = "0x600870D")]
	[Address(RVA = "0xB2E7E0", Offset = "0xB2D9E0", VA = "0x180B2E7E0")]
	private void OnPlayPreviewEnd()
	{
	}

	[Token(Token = "0x600870E")]
	[Address(RVA = "0xCE3CF0", Offset = "0xCE2EF0", VA = "0x180CE3CF0")]
	private void PlayTween(string label, bool immediate = false)
	{
	}

	[Token(Token = "0x600870F")]
	[Address(RVA = "0xCE4710", Offset = "0xCE3910", VA = "0x180CE4710")]
	private void StopTween()
	{
	}

	[Token(Token = "0x6008710")]
	[Address(RVA = "0xCE4980", Offset = "0xCE3B80", VA = "0x180CE4980")]
	private void TweenApplyImmediate(string label, bool immediate = false)
	{
	}

	[Token(Token = "0x6008711")]
	[Address(RVA = "0xCE4580", Offset = "0xCE3780", VA = "0x180CE4580")]
	private void SetupTweenTargetAlpha()
	{
	}

	[Token(Token = "0x6008712")]
	[Address(RVA = "0xCE4A50", Offset = "0xCE3C50", VA = "0x180CE4A50")]
	public CardBrowserDuelPreviewPlayer()
	{
	}
}
