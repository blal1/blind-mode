using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using YgomGame.Bg;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001442")]
[DisallowMultipleComponent]
public class BindingMate3D : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x2001443")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		[Token(Token = "0x400C5F9")]
		[FieldOffset(Offset = "0x10")]
		public BindingMate3D _003C_003E4__this;

		[Token(Token = "0x400C5FA")]
		[FieldOffset(Offset = "0x18")]
		public bool mateApplyDone;

		[Token(Token = "0x6007E1D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6007E1E")]
		[Address(RVA = "0xC7F680", Offset = "0xC7E880", VA = "0x180C7F680")]
		internal void _003CyOnBindingRoutine_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2001444")]
	[CompilerGenerated]
	private sealed class _003CyOnBindingRoutine_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C5FB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C5FC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C5FD")]
		[FieldOffset(Offset = "0x20")]
		public BindingMate3D _003C_003E4__this;

		[Token(Token = "0x400C5FE")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		[Token(Token = "0x400C5FF")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _003Cpos_003E5__2;

		[Token(Token = "0x400C600")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _003Crot_003E5__3;

		[Token(Token = "0x400C601")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 _003Cscale_003E5__4;

		[Token(Token = "0x17001361")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007E22")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001362")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007E24")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007E1F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyOnBindingRoutine_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007E20")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007E21")]
		[Address(RVA = "0xC82D00", Offset = "0xC81F00", VA = "0x180C82D00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007E23")]
		[Address(RVA = "0xC835C0", Offset = "0xC827C0", VA = "0x180C835C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C5E9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_MateId;

	[Token(Token = "0x400C5EA")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 m_Position;

	[Token(Token = "0x400C5EB")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[FormerlySerializedAs("m_EulerAngles")]
	private Vector3 m_Rotation;

	[Token(Token = "0x400C5EC")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Vector3 m_Scale;

	[Token(Token = "0x400C5ED")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[AssetPath(typeof(MateTransformSetting))]
	private string m_MateTransformSettingPath;

	[Token(Token = "0x400C5EE")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool m_UseTransformSetting;

	[Token(Token = "0x400C5EF")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject m_Locater;

	[Token(Token = "0x400C5F0")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool m_ReadyAndPlayMotion;

	[Token(Token = "0x400C5F1")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private AvatarMotionSetting.MotionID m_BeginMotion;

	[Token(Token = "0x400C5F2")]
	[FieldOffset(Offset = "0x68")]
	private uint m_CharacterPrefCrc;

	[Token(Token = "0x400C5F3")]
	[FieldOffset(Offset = "0x70")]
	private Character m_Character;

	[Token(Token = "0x400C5F4")]
	[FieldOffset(Offset = "0x78")]
	private uint m_SettingCrc;

	[Token(Token = "0x400C5F5")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_Visible;

	[Token(Token = "0x400C5F6")]
	[FieldOffset(Offset = "0x80")]
	private IEnumerator m_OnBindingRoutine;

	[Token(Token = "0x400C5F8")]
	[FieldOffset(Offset = "0x90")]
	private int m_Layer;

	[Token(Token = "0x1700135C")]
	public string mateTransformSettingPath
	{
		[Token(Token = "0x6007E0A")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700135D")]
	public int mateId
	{
		[Token(Token = "0x6007E0B")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007E0C")]
		[Address(RVA = "0xC6B600", Offset = "0xC6A800", VA = "0x180C6B600")]
		set
		{
		}
	}

	[Token(Token = "0x1700135E")]
	public bool validMateId
	{
		[Token(Token = "0x6007E0D")]
		[Address(RVA = "0x61B860", Offset = "0x61AA60", VA = "0x18061B860")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700135F")]
	public Character character
	{
		[Token(Token = "0x6007E0E")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001360")]
	public bool visible
	{
		[Token(Token = "0x6007E0F")]
		[Address(RVA = "0x42D530", Offset = "0x42C730", VA = "0x18042D530", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007E10")]
		[Address(RVA = "0xC6B610", Offset = "0xC6A810", VA = "0x180C6B610")]
		set
		{
		}
	}

	[Token(Token = "0x1400009F")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6007E11")]
		[Address(RVA = "0xC6B4A0", Offset = "0xC6A6A0", VA = "0x180C6B4A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007E12")]
		[Address(RVA = "0xC6B550", Offset = "0xC6A750", VA = "0x180C6B550", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007E13")]
	[Address(RVA = "0xC6AD30", Offset = "0xC69F30", VA = "0x180C6AD30", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007E14")]
	[Address(RVA = "0xC6ACA0", Offset = "0xC69EA0", VA = "0x180C6ACA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007E15")]
	[Address(RVA = "0xC6B2A0", Offset = "0xC6A4A0", VA = "0x180C6B2A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6007E16")]
	[Address(RVA = "0xC6B2B0", Offset = "0xC6A4B0", VA = "0x180C6B2B0")]
	private void VisibleRefresh()
	{
	}

	[Token(Token = "0x6007E17")]
	[Address(RVA = "0xC6B0C0", Offset = "0xC6A2C0", VA = "0x180C6B0C0")]
	public void SourceChanged()
	{
	}

	[Token(Token = "0x6007E18")]
	[Address(RVA = "0xC6AEB0", Offset = "0xC6A0B0", VA = "0x180C6AEB0")]
	public void OnRebind()
	{
	}

	[Token(Token = "0x6007E19")]
	[Address(RVA = "0xC6AFA0", Offset = "0xC6A1A0", VA = "0x180C6AFA0", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007E1A")]
	[Address(RVA = "0xC6B620", Offset = "0xC6A820", VA = "0x180C6B620")]
	[IteratorStateMachine(typeof(_003CyOnBindingRoutine_003Ed__37))]
	private IEnumerator yOnBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007E1B")]
	[Address(RVA = "0xC6ADA0", Offset = "0xC69FA0", VA = "0x180C6ADA0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007E1C")]
	[Address(RVA = "0xC6B3B0", Offset = "0xC6A5B0", VA = "0x180C6B3B0")]
	public BindingMate3D()
	{
	}
}
