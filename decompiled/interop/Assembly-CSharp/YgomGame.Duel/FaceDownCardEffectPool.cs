using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A37")]
public class FaceDownCardEffectPool : MonoBehaviour
{
	[Token(Token = "0x2001A38")]
	private enum Step
	{
		[Token(Token = "0x400F219")]
		WaitPrefabLoad,
		[Token(Token = "0x400F21A")]
		WaitInstantiate,
		[Token(Token = "0x400F21B")]
		Idle,
		[Token(Token = "0x400F21C")]
		Terminating
	}

	[Token(Token = "0x2001A39")]
	[CompilerGenerated]
	private sealed class _003CInstantiateProcess_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F21D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F21E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F21F")]
		[FieldOffset(Offset = "0x20")]
		public FaceDownCardEffectPool _003C_003E4__this;

		[Token(Token = "0x400F220")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x400F221")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Cj_003E5__3;

		[Token(Token = "0x17001A3C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600A9EC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001A3D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A9EE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A9E9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInstantiateProcess_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600A9EA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600A9EB")]
		[Address(RVA = "0xF743A0", Offset = "0xF735A0", VA = "0x180F743A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A9ED")]
		[Address(RVA = "0xF745B0", Offset = "0xF737B0", VA = "0x180F745B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400F210")]
	private const string PREFABPATH = "Duel/Effects/Buff/fxp_bff_disquiet/fxp_bff_disquiet_001";

	[Token(Token = "0x400F211")]
	[FieldOffset(Offset = "0x20")]
	private List<Dictionary<int, GameObject>> m_EffectList;

	[Token(Token = "0x400F212")]
	[FieldOffset(Offset = "0x28")]
	private List<Dictionary<int, bool>> m_EffectVisibleList;

	[Token(Token = "0x400F213")]
	[FieldOffset(Offset = "0x30")]
	private Step m_Step;

	[Token(Token = "0x400F214")]
	[FieldOffset(Offset = "0x34")]
	private bool isInstantiated;

	[Token(Token = "0x400F215")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_Prefab;

	[Token(Token = "0x17001A3A")]
	public bool isInitialized
	{
		[Token(Token = "0x600A9D4")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A9D5")]
		[Address(RVA = "0x3D77B0", Offset = "0x3D69B0", VA = "0x1803D77B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A3B")]
	public DuelGameObjectManager goManager
	{
		[Token(Token = "0x600A9D6")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A9D7")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A9D8")]
	[Address(RVA = "0xF655B0", Offset = "0xF647B0", VA = "0x180F655B0")]
	public static FaceDownCardEffectPool Create(DuelGameObjectManager goManager, GameObject root, string name)
	{
		return null;
	}

	[Token(Token = "0x600A9D9")]
	[Address(RVA = "0xF65750", Offset = "0xF64950", VA = "0x180F65750")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x600A9DA")]
	[Address(RVA = "0xF663D0", Offset = "0xF655D0", VA = "0x180F663D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600A9DB")]
	[Address(RVA = "0xF66580", Offset = "0xF65780", VA = "0x180F66580")]
	protected void WaitPrefabLoad()
	{
	}

	[Token(Token = "0x600A9DC")]
	[Address(RVA = "0xF65B00", Offset = "0xF64D00", VA = "0x180F65B00")]
	[IteratorStateMachine(typeof(_003CInstantiateProcess_003Ed__19))]
	private IEnumerator InstantiateProcess()
	{
		return null;
	}

	[Token(Token = "0x600A9DD")]
	[Address(RVA = "0xF66520", Offset = "0xF65720", VA = "0x180F66520")]
	protected void WaitInstantiateStep()
	{
	}

	[Token(Token = "0x600A9DE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	protected void IdleStep()
	{
	}

	[Token(Token = "0x600A9DF")]
	[Address(RVA = "0xF65EE0", Offset = "0xF650E0", VA = "0x180F65EE0")]
	protected void TerminateStep()
	{
	}

	[Token(Token = "0x600A9E0")]
	[Address(RVA = "0xF66320", Offset = "0xF65520", VA = "0x180F66320")]
	private void UpdateEffect(int player, int position)
	{
	}

	[Token(Token = "0x600A9E1")]
	[Address(RVA = "0xF661D0", Offset = "0xF653D0", VA = "0x180F661D0")]
	private void UpdateAllEffect(bool forcehide = false)
	{
	}

	[Token(Token = "0x600A9E2")]
	[Address(RVA = "0xF65C40", Offset = "0xF64E40", VA = "0x180F65C40")]
	private void SetEffectVisible(int player, int position, bool visible)
	{
	}

	[Token(Token = "0x600A9E3")]
	[Address(RVA = "0xF65B70", Offset = "0xF64D70", VA = "0x180F65B70")]
	public void RemoveFaceDownCardEffect(int player, int position, bool temporary = false)
	{
	}

	[Token(Token = "0x600A9E4")]
	[Address(RVA = "0xF663C0", Offset = "0xF655C0", VA = "0x180F663C0")]
	public void UpdateFaceDownCardEffect(int player, int position)
	{
	}

	[Token(Token = "0x600A9E5")]
	[Address(RVA = "0xF661D0", Offset = "0xF653D0", VA = "0x180F661D0")]
	public void UpdateFaceDownEffectTable(bool forcehide = false)
	{
	}

	[Token(Token = "0x600A9E6")]
	[Address(RVA = "0xF66140", Offset = "0xF65340", VA = "0x180F66140")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A9E7")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public FaceDownCardEffectPool()
	{
	}
}
