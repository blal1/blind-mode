using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.DuelPreview.Data;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000E9B")]
public class PreviewCardRunEffectController : IPreviewPlayerControllerRequireGob, IPreviewPlayerController
{
	[Token(Token = "0x2000E9C")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A3D7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A3D8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000D8C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600584A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D8D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600584C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005847")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005848")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005849")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600584B")]
		[Address(RVA = "0x9C7E10", Offset = "0x9C7010", VA = "0x1809C7E10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E9D")]
	[CompilerGenerated]
	private sealed class _003CyPlay_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A3D9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A3DA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A3DB")]
		[FieldOffset(Offset = "0x20")]
		public PreviewCardRunEffectController _003C_003E4__this;

		[Token(Token = "0x400A3DC")]
		[FieldOffset(Offset = "0x28")]
		public bool useFinishSecond;

		[Token(Token = "0x400A3DD")]
		[FieldOffset(Offset = "0x30")]
		public DuelPreviewAsset duelPreviewAsset;

		[Token(Token = "0x400A3DE")]
		[FieldOffset(Offset = "0x38")]
		public bool useSubCamera;

		[Token(Token = "0x400A3DF")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 pos;

		[Token(Token = "0x400A3E0")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 rot;

		[Token(Token = "0x400A3E1")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 scale;

		[Token(Token = "0x400A3E2")]
		[FieldOffset(Offset = "0x60")]
		private IEnumerator _003CplayRoutine_003E5__2;

		[Token(Token = "0x400A3E3")]
		[FieldOffset(Offset = "0x68")]
		private IEnumerator _003CcameraShakeRoutine_003E5__3;

		[Token(Token = "0x400A3E4")]
		[FieldOffset(Offset = "0x70")]
		private bool _003CeffectInitialized_003E5__4;

		[Token(Token = "0x400A3E5")]
		[FieldOffset(Offset = "0x71")]
		private bool _003CinProgress_003E5__5;

		[Token(Token = "0x17000D8E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005850")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D8F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005852")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600584D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlay_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600584E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600584F")]
		[Address(RVA = "0x9C9FD0", Offset = "0x9C91D0", VA = "0x1809C9FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005851")]
		[Address(RVA = "0x9CB0B0", Offset = "0x9CA2B0", VA = "0x1809CB0B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E9E")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A3E6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A3E7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A3E8")]
		[FieldOffset(Offset = "0x20")]
		public PreviewCardRunEffectController _003C_003E4__this;

		[Token(Token = "0x400A3E9")]
		[FieldOffset(Offset = "0x28")]
		public int mrk;

		[Token(Token = "0x400A3EA")]
		[FieldOffset(Offset = "0x2C")]
		public CardRunEffectSetting.Player player;

		[Token(Token = "0x400A3EB")]
		[FieldOffset(Offset = "0x30")]
		public bool useCenterEffect;

		[Token(Token = "0x400A3EC")]
		[FieldOffset(Offset = "0x38")]
		public DuelPreviewAsset duelPreviewAsset;

		[Token(Token = "0x400A3ED")]
		[FieldOffset(Offset = "0x40")]
		private IEnumerator _003CcameraShakeSetupRoutine_003E5__2;

		[Token(Token = "0x400A3EE")]
		[FieldOffset(Offset = "0x48")]
		private IEnumerator _003CsetupRoutine_003E5__3;

		[Token(Token = "0x400A3EF")]
		[FieldOffset(Offset = "0x50")]
		private bool _003CinProgress_003E5__4;

		[Token(Token = "0x17000D90")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005856")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D91")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005858")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005853")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005854")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005855")]
		[Address(RVA = "0xA00630", Offset = "0x9FF830", VA = "0x180A00630", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005857")]
		[Address(RVA = "0xA00C80", Offset = "0x9FFE80", VA = "0x180A00C80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A3C4")]
	private const string k_EffectLabel = "CardRunEffect";

	[Token(Token = "0x400A3C5")]
	[FieldOffset(Offset = "0x10")]
	private DuelPreviewSetting m_ProductViewerSetting;

	[Token(Token = "0x400A3C6")]
	[FieldOffset(Offset = "0x18")]
	private CardRunEffectSetting.CardRunEffectInfo m_CardRunSetting;

	[Token(Token = "0x400A3C7")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_PlayingEffect;

	[Token(Token = "0x400A3C8")]
	[FieldOffset(Offset = "0x0")]
	private static string k_PlayerSettingPath;

	[Token(Token = "0x400A3C9")]
	[FieldOffset(Offset = "0x8")]
	private static string k_CardRunEffectSettingPath;

	[Token(Token = "0x400A3CA")]
	[FieldOffset(Offset = "0x28")]
	private readonly DuelPreviewPlayer.Option m_Option;

	[Token(Token = "0x400A3CB")]
	[FieldOffset(Offset = "0x30")]
	private readonly PreviewResourceController m_ResourceController;

	[Token(Token = "0x400A3CC")]
	[FieldOffset(Offset = "0x38")]
	private readonly PreviewSimpleEffectController m_PreviewSimpleEffectController;

	[Token(Token = "0x400A3CD")]
	[FieldOffset(Offset = "0x40")]
	private readonly PreviewTimeline3DController m_PreviewTimeline3DController;

	[Token(Token = "0x400A3CE")]
	[FieldOffset(Offset = "0x48")]
	private readonly PreviewCameraController m_PreviewCameraController;

	[Token(Token = "0x400A3CF")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_SpawnRoot;

	[Token(Token = "0x400A3D0")]
	[FieldOffset(Offset = "0x58")]
	private bool m_UseCenterEffect;

	[Token(Token = "0x400A3D1")]
	[FieldOffset(Offset = "0x5C")]
	private CardRunEffectSetting.PlayType m_PlayType;

	[Token(Token = "0x400A3D2")]
	[FieldOffset(Offset = "0x60")]
	private DuelEffectPool.Type m_EffectType;

	[Token(Token = "0x400A3D3")]
	[FieldOffset(Offset = "0x68")]
	private string m_EffectPath;

	[Token(Token = "0x400A3D4")]
	[FieldOffset(Offset = "0x70")]
	private CardRunEffectSetting.RotationType m_RotationType;

	[Token(Token = "0x400A3D5")]
	[FieldOffset(Offset = "0x74")]
	private CardRunEffectSetting.ExtraSetting m_ExtraSetting;

	[Token(Token = "0x400A3D6")]
	[FieldOffset(Offset = "0x78")]
	private IEnumerator m_PlayingRoutine;

	[Token(Token = "0x17000D8B")]
	public ControllerType controllerType
	{
		[Token(Token = "0x600583A")]
		[Address(RVA = "0x3FC090", Offset = "0x3FB290", VA = "0x1803FC090", Slot = "6")]
		get
		{
			return default(ControllerType);
		}
	}

	[Token(Token = "0x600583B")]
	[Address(RVA = "0x9BFF20", Offset = "0x9BF120", VA = "0x1809BFF20")]
	public PreviewCardRunEffectController(DuelPreviewPlayer.Option option, PreviewResourceController resourceController, PreviewSimpleEffectController previewSimpleEffectController, PreviewTimeline3DController previewTimeline3DController, PreviewCameraController previewCameraController)
	{
	}

	[Token(Token = "0x600583C")]
	[Address(RVA = "0x9BFBA0", Offset = "0x9BEDA0", VA = "0x1809BFBA0", Slot = "4")]
	public void BindGob(params GameObject[] gobs)
	{
	}

	[Token(Token = "0x600583D")]
	[Address(RVA = "0x8F22C0", Offset = "0x8F14C0", VA = "0x1808F22C0", Slot = "5")]
	public void UnbindGob()
	{
	}

	[Token(Token = "0x600583E")]
	[Address(RVA = "0x9BFFC0", Offset = "0x9BF1C0", VA = "0x1809BFFC0", Slot = "7")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__24))]
	public IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x600583F")]
	[Address(RVA = "0x9BFDC0", Offset = "0x9BEFC0", VA = "0x1809BFDC0", Slot = "8")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6005840")]
	[Address(RVA = "0x9BFDC0", Offset = "0x9BEFC0", VA = "0x1809BFDC0", Slot = "9")]
	public void Release()
	{
	}

	[Token(Token = "0x6005841")]
	[Address(RVA = "0x9C0100", Offset = "0x9BF300", VA = "0x1809C0100")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__27))]
	public IEnumerator ySetup(int mrk, CardRunEffectSetting.Player player, bool useCenterEffect, DuelPreviewAsset duelPreviewAsset)
	{
		return null;
	}

	[Token(Token = "0x6005842")]
	[Address(RVA = "0x9BFCD0", Offset = "0x9BEED0", VA = "0x1809BFCD0")]
	public void Play(DuelPreviewAsset duelPreviewAsset, Vector3 pos, Vector3 rot, Vector3 scale, bool useFinishSecond = false, bool useSubCamera = false)
	{
	}

	[Token(Token = "0x6005843")]
	[Address(RVA = "0x9C0010", Offset = "0x9BF210", VA = "0x1809C0010")]
	[IteratorStateMachine(typeof(_003CyPlay_003Ed__29))]
	private IEnumerator yPlay(DuelPreviewAsset duelPreviewAsset, Vector3 pos, Vector3 rot, Vector3 scale, bool useFinishSecond = false, bool useSubCamera = false)
	{
		return null;
	}

	[Token(Token = "0x6005844")]
	[Address(RVA = "0x9BFC40", Offset = "0x9BEE40", VA = "0x1809BFC40")]
	private void PlaySE(string seLabel, bool is3D, Vector3 position)
	{
	}

	[Token(Token = "0x6005845")]
	[Address(RVA = "0x9BFBD0", Offset = "0x9BEDD0", VA = "0x1809BFBD0")]
	public bool CheckProgress()
	{
		return default(bool);
	}
}
