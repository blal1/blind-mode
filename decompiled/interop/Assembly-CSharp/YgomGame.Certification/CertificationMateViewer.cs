using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomGame.Certification;

[Token(Token = "0x20014C6")]
public class CertificationMateViewer : MonoBehaviour
{
	[Token(Token = "0x20014C9")]
	[CompilerGenerated]
	private sealed class _003CySetMate_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C85A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CertificationMateViewer _003C_003E4__this;

		[Token(Token = "0x400C85B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int charaId;

		[Token(Token = "0x400C85C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool forceRebuild;

		[Token(Token = "0x400C85D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x170013C2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60080DF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170013C3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60080E1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60080DC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetMate_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60080DD")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60080DE")]
		[Address(RVA = "0xC9BA20", Offset = "0xC9AC20", VA = "0x180C9BA20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60080E0")]
		[Address(RVA = "0xC9BBE0", Offset = "0xC9ADE0", VA = "0x180C9BBE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20014CA")]
	[CompilerGenerated]
	private sealed class _003CySetupBGMatToOpaque_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C85E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C85F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CertificationMateViewer _003C_003E4__this;

		[Token(Token = "0x170013C4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60080E5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170013C5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60080E7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60080E2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetupBGMatToOpaque_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60080E3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60080E4")]
		[Address(RVA = "0xC9BC20", Offset = "0xC9AE20", VA = "0x180C9BC20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60080E6")]
		[Address(RVA = "0xC9BEE0", Offset = "0xC9B0E0", VA = "0x180C9BEE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C846")]
	private const string k_Path = "Prefabs/Certification/CertificationMateViewer";

	[Token(Token = "0x400C847")]
	private const string k_ELabel_Scaler = "Scaler";

	[Token(Token = "0x400C848")]
	private const string k_ELabel_BindingMate3D = "BindingMate3D";

	[Token(Token = "0x400C849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CertificationMateViewer s_Instance;

	[Token(Token = "0x400C84A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<ViewController> m_Owners;

	[Token(Token = "0x400C84B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string m_BackBgPath;

	[Token(Token = "0x400C84C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private BindingMate3D m_BindingMate3D;

	[Token(Token = "0x400C84D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material m_OriginBGMat;

	[Token(Token = "0x400C84E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_OpaqueBGMat;

	[Token(Token = "0x400C84F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private SpriteRenderer m_OriginRenderer;

	[Token(Token = "0x400C850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Coroutine m_SetupBGRoutine;

	[Token(Token = "0x400C851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool m_Mute;

	[Token(Token = "0x170013BF")]
	public BindingMate3D bindingMate3D
	{
		[Token(Token = "0x60080C8")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013C0")]
	public IReadOnlyList<ViewController> owners
	{
		[Token(Token = "0x60080C9")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013C1")]
	public bool mute
	{
		[Token(Token = "0x60080CA")]
		[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60080CB")]
		[Address(RVA = "0xC8F380", Offset = "0xC8E580", VA = "0x180C8F380")]
		set
		{
		}
	}

	[Token(Token = "0x60080CC")]
	[Address(RVA = "0xC8E730", Offset = "0xC8D930", VA = "0x180C8E730")]
	public static void Create(ViewController ownerVC, int bgId, Action<CertificationMateViewer> onComplete)
	{
	}

	[Token(Token = "0x60080CD")]
	[Address(RVA = "0xC8E8F0", Offset = "0xC8DAF0", VA = "0x180C8E8F0")]
	public static void Create(ViewController ownerVC, int bgId, string path, Action<CertificationMateViewer> onComplete)
	{
	}

	[Token(Token = "0x60080CE")]
	[Address(RVA = "0xC8EDE0", Offset = "0xC8DFE0", VA = "0x180C8EDE0")]
	public void OnTransition(ViewController.TransitionType type)
	{
	}

	[Token(Token = "0x60080CF")]
	[Address(RVA = "0xC8EC80", Offset = "0xC8DE80", VA = "0x180C8EC80")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60080D0")]
	[Address(RVA = "0xC8F180", Offset = "0xC8E380", VA = "0x180C8F180")]
	public void SetupBGMatToOpaque()
	{
	}

	[Token(Token = "0x60080D1")]
	[Address(RVA = "0xC8F4E0", Offset = "0xC8E6E0", VA = "0x180C8F4E0")]
	[IteratorStateMachine(typeof(_003CySetupBGMatToOpaque_003Ed__24))]
	private IEnumerator ySetupBGMatToOpaque()
	{
		return null;
	}

	[Token(Token = "0x60080D2")]
	[Address(RVA = "0xC8F230", Offset = "0xC8E430", VA = "0x180C8F230")]
	public void SetupBGMatToOrigin()
	{
	}

	[Token(Token = "0x60080D3")]
	[Address(RVA = "0xC8EAA0", Offset = "0xC8DCA0", VA = "0x180C8EAA0")]
	private void Initialize(ViewController ownerVC, int bgId)
	{
	}

	[Token(Token = "0x60080D4")]
	[Address(RVA = "0xC8F0C0", Offset = "0xC8E2C0", VA = "0x180C8F0C0")]
	public void SetMate(int charaId, [Optional] Action onComplete, bool forceRebuild = false)
	{
	}

	[Token(Token = "0x60080D5")]
	[Address(RVA = "0xC8F430", Offset = "0xC8E630", VA = "0x180C8F430")]
	[IteratorStateMachine(typeof(_003CySetMate_003Ed__28))]
	private IEnumerator ySetMate(int charaId, [Optional] Action onComplete, bool forceRebuild = false)
	{
		return null;
	}

	[Token(Token = "0x60080D6")]
	[Address(RVA = "0xC8EE60", Offset = "0xC8E060", VA = "0x180C8EE60")]
	public void Release(ViewController ownerVC)
	{
	}

	[Token(Token = "0x60080D7")]
	[Address(RVA = "0xC8F300", Offset = "0xC8E500", VA = "0x180C8F300")]
	public CertificationMateViewer()
	{
	}
}
