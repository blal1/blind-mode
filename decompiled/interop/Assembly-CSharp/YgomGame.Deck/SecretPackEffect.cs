using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Effect;

namespace YgomGame.Deck;

[Token(Token = "0x200111C")]
public class SecretPackEffect
{
	[Token(Token = "0x200111D")]
	private enum Step
	{
		[Token(Token = "0x400B4D2")]
		Loading,
		[Token(Token = "0x400B4D3")]
		GetEffect,
		[Token(Token = "0x400B4D4")]
		ActiveEffect,
		[Token(Token = "0x400B4D5")]
		Finished
	}

	[Token(Token = "0x200111F")]
	[CompilerGenerated]
	private sealed class _003CUpdateCreateEffect_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B4D9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B4DA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B4DB")]
		[FieldOffset(Offset = "0x20")]
		public SecretPackEffect _003C_003E4__this;

		[Token(Token = "0x400B4DC")]
		[FieldOffset(Offset = "0x28")]
		public Action onPlayGetEffect;

		[Token(Token = "0x1700111D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006B5D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700111E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006B5F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006B5A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CUpdateCreateEffect_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006B5B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006B5C")]
		[Address(RVA = "0xB3DBD0", Offset = "0xB3CDD0", VA = "0x180B3DBD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006B5E")]
		[Address(RVA = "0xB3DE10", Offset = "0xB3D010", VA = "0x180B3DE10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400B4CC")]
	private const string prefabPathGetSecret = "Prefabs/UI/DeckEdit/fxp_DeckEditUI/fxp_DeckEditUI_sctget_001";

	[Token(Token = "0x400B4CD")]
	private const string prefabPathActiveSecret = "Prefabs/UI/DeckEdit/fxp_DeckEditUI/fxp_DeckEditUI_sctactive_001";

	[Token(Token = "0x400B4CE")]
	[FieldOffset(Offset = "0x10")]
	private EffectHandler effectGetSecret;

	[Token(Token = "0x400B4CF")]
	[FieldOffset(Offset = "0x18")]
	private EffectHandler effectActiveSecret;

	[Token(Token = "0x400B4D0")]
	[FieldOffset(Offset = "0x20")]
	private Step step;

	[Token(Token = "0x6006B4F")]
	[Address(RVA = "0xB34080", Offset = "0xB33280", VA = "0x180B34080")]
	public static SecretPackEffect Create(RectTransform targetButton, bool isMobile)
	{
		return null;
	}

	[Token(Token = "0x6006B50")]
	[Address(RVA = "0xB342D0", Offset = "0xB334D0", VA = "0x180B342D0")]
	private void Initialize(RectTransform targetButton, bool isMobile)
	{
	}

	[Token(Token = "0x6006B51")]
	[Address(RVA = "0xB34440", Offset = "0xB33640", VA = "0x180B34440")]
	public void StartEffect(Action onPlayGetEffect)
	{
	}

	[Token(Token = "0x6006B52")]
	[Address(RVA = "0xB34620", Offset = "0xB33820", VA = "0x180B34620")]
	[IteratorStateMachine(typeof(_003CUpdateCreateEffect_003Ed__9))]
	private IEnumerator UpdateCreateEffect(Action onPlayGetEffect)
	{
		return null;
	}

	[Token(Token = "0x6006B53")]
	[Address(RVA = "0xB34230", Offset = "0xB33430", VA = "0x180B34230")]
	public void DestroyGetEffect()
	{
	}

	[Token(Token = "0x6006B54")]
	[Address(RVA = "0xB34510", Offset = "0xB33710", VA = "0x180B34510")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6006B55")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SecretPackEffect()
	{
	}
}
