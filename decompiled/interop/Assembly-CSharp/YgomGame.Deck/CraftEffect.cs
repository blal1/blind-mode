using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Effect;

namespace YgomGame.Deck;

[Token(Token = "0x200109D")]
public class CraftEffect
{
	[Token(Token = "0x200109E")]
	public enum Mode
	{
		[Token(Token = "0x400B0D2")]
		Create,
		[Token(Token = "0x400B0D3")]
		Dismantle
	}

	[Token(Token = "0x200109F")]
	private enum Step
	{
		[Token(Token = "0x400B0D5")]
		Loading,
		[Token(Token = "0x400B0D6")]
		CardEffect,
		[Token(Token = "0x400B0D7")]
		TrailEffect,
		[Token(Token = "0x400B0D8")]
		PointEffect,
		[Token(Token = "0x400B0D9")]
		Finished
	}

	[Token(Token = "0x20010A1")]
	[CompilerGenerated]
	private sealed class _003CUpdateCreateEffect_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B0DF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B0E0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B0E1")]
		[FieldOffset(Offset = "0x20")]
		public CraftEffect _003C_003E4__this;

		[Token(Token = "0x400B0E2")]
		[FieldOffset(Offset = "0x28")]
		public Action onPlayPointEffect;

		[Token(Token = "0x17001097")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60066ED")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001098")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60066EF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60066EA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CUpdateCreateEffect_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60066EB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60066EC")]
		[Address(RVA = "0xAD3DC0", Offset = "0xAD2FC0", VA = "0x180AD3DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60066EE")]
		[Address(RVA = "0xAD4120", Offset = "0xAD3320", VA = "0x180AD4120", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20010A2")]
	[CompilerGenerated]
	private sealed class _003CUpdateDismantleEffect_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B0E3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B0E4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B0E5")]
		[FieldOffset(Offset = "0x20")]
		public CraftEffect _003C_003E4__this;

		[Token(Token = "0x400B0E6")]
		[FieldOffset(Offset = "0x28")]
		public Action onPlayPointEffect;

		[Token(Token = "0x17001099")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60066F3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700109A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60066F5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60066F0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CUpdateDismantleEffect_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60066F1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60066F2")]
		[Address(RVA = "0xAD4160", Offset = "0xAD3360", VA = "0x180AD4160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60066F4")]
		[Address(RVA = "0xAD4460", Offset = "0xAD3660", VA = "0x180AD4460", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400B0C5")]
	[FieldOffset(Offset = "0x10")]
	private Mode mode;

	[Token(Token = "0x400B0C6")]
	private const string prefabPathCraftEffectCreateCard = "Prefabs/UI/DeckEdit/fxp_DeckEditUI/fxp_DeckEditUI_generate_001";

	[Token(Token = "0x400B0C7")]
	private const string prefabPathCraftEffectDismantleCard = "Prefabs/UI/DeckEdit/fxp_DeckEditUI/fxp_DeckEditUI_dismantle_001";

	[Token(Token = "0x400B0C8")]
	private const string prefabPathCraftEffectTrail = "Prefabs/UI/DeckEdit/fxp_DeckEditUI/fxp_DeckEditUI_trail_001";

	[Token(Token = "0x400B0C9")]
	private const string prefabPathCraftEffectPoint = "Prefabs/UI/DeckEdit/fxp_DeckEditUI/fxp_DeckEditUI_point_001";

	[Token(Token = "0x400B0CA")]
	[FieldOffset(Offset = "0x18")]
	private EffectHandler effectCard;

	[Token(Token = "0x400B0CB")]
	[FieldOffset(Offset = "0x20")]
	private EffectHandler effectTrail;

	[Token(Token = "0x400B0CC")]
	[FieldOffset(Offset = "0x28")]
	private EffectHandler effectPoint;

	[Token(Token = "0x400B0CD")]
	[FieldOffset(Offset = "0x30")]
	private ChainedBezierMotion motion;

	[Token(Token = "0x400B0CE")]
	[FieldOffset(Offset = "0x38")]
	private float time;

	[Token(Token = "0x400B0CF")]
	[FieldOffset(Offset = "0x3C")]
	private Step step;

	[Token(Token = "0x400B0D0")]
	[FieldOffset(Offset = "0x40")]
	private Action onFinished;

	[Token(Token = "0x60066DC")]
	[Address(RVA = "0xABC630", Offset = "0xABB830", VA = "0x180ABC630")]
	public static CraftEffect Create(Mode mode, Transform parent, RectTransform targetCard, RectTransform targetPoint, List<BezierMotionSetting> motionList, bool actionMenu)
	{
		return null;
	}

	[Token(Token = "0x60066DD")]
	[Address(RVA = "0xABC880", Offset = "0xABBA80", VA = "0x180ABC880")]
	private void Initialize(Mode mode, Transform parent, RectTransform targetCard, RectTransform targetPoint, List<BezierMotionSetting> motionList, bool actionMenu)
	{
	}

	[Token(Token = "0x60066DE")]
	[Address(RVA = "0xABCCE0", Offset = "0xABBEE0", VA = "0x180ABCCE0")]
	public void StartEffect(Action onPlayPointEffect, Action onFinished)
	{
	}

	[Token(Token = "0x60066DF")]
	[Address(RVA = "0xABCE20", Offset = "0xABC020", VA = "0x180ABCE20")]
	[IteratorStateMachine(typeof(_003CUpdateCreateEffect_003Ed__17))]
	private IEnumerator UpdateCreateEffect(Action onPlayPointEffect)
	{
		return null;
	}

	[Token(Token = "0x60066E0")]
	[Address(RVA = "0xABCEB0", Offset = "0xABC0B0", VA = "0x180ABCEB0")]
	[IteratorStateMachine(typeof(_003CUpdateDismantleEffect_003Ed__18))]
	private IEnumerator UpdateDismantleEffect(Action onPlayPointEffect)
	{
		return null;
	}

	[Token(Token = "0x60066E1")]
	[Address(RVA = "0xABC6F0", Offset = "0xABB8F0", VA = "0x180ABC6F0")]
	public void Finish()
	{
	}

	[Token(Token = "0x60066E2")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CraftEffect()
	{
	}
}
