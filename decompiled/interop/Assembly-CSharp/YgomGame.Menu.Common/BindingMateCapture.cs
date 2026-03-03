using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001445")]
public class BindingMateCapture : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x2001446")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		[Token(Token = "0x400C60D")]
		[FieldOffset(Offset = "0x10")]
		public BindingMateCapture _003C_003E4__this;

		[Token(Token = "0x400C60E")]
		[FieldOffset(Offset = "0x18")]
		public bool mateCaptureDone;

		[Token(Token = "0x6007E38")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass32_0()
		{
		}

		[Token(Token = "0x6007E39")]
		[Address(RVA = "0xC7F5A0", Offset = "0xC7E7A0", VA = "0x180C7F5A0")]
		internal void _003CyOnBindingRoutine_003Eb__0(RenderTexture renderTex)
		{
		}
	}

	[Token(Token = "0x2001447")]
	[CompilerGenerated]
	private sealed class _003CyOnBindingRoutine_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C60F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C610")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C611")]
		[FieldOffset(Offset = "0x20")]
		public BindingMateCapture _003C_003E4__this;

		[Token(Token = "0x400C612")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass32_0 _003C_003E8__1;

		[Token(Token = "0x17001368")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007E3D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001369")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007E3F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007E3A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyOnBindingRoutine_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007E3B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007E3C")]
		[Address(RVA = "0xC828D0", Offset = "0xC81AD0", VA = "0x180C828D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007E3E")]
		[Address(RVA = "0xC82CC0", Offset = "0xC81EC0", VA = "0x180C82CC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C602")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_MateId;

	[Token(Token = "0x400C603")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 m_Position;

	[Token(Token = "0x400C604")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[FormerlySerializedAs("m_EulerAngles")]
	private Vector3 m_Rotation;

	[Token(Token = "0x400C605")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Vector3 m_Scale;

	[Token(Token = "0x400C606")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[AssetPath(typeof(MateTransformSetting))]
	private string m_MateTransformSettingPath;

	[Token(Token = "0x400C607")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool m_UseTransformSetting;

	[Token(Token = "0x400C608")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject m_Locater;

	[Token(Token = "0x400C609")]
	[FieldOffset(Offset = "0x60")]
	private RawImage m_RawImageCache;

	[Token(Token = "0x400C60A")]
	[FieldOffset(Offset = "0x68")]
	private bool m_Visible;

	[Token(Token = "0x400C60B")]
	[FieldOffset(Offset = "0x70")]
	private IEnumerator m_OnBindingRoutine;

	[Token(Token = "0x17001363")]
	public string mateTransformSettingPath
	{
		[Token(Token = "0x6007E25")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001364")]
	public int mateId
	{
		[Token(Token = "0x6007E26")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007E27")]
		[Address(RVA = "0xC6BDF0", Offset = "0xC6AFF0", VA = "0x180C6BDF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001365")]
	public bool validSource
	{
		[Token(Token = "0x6007E28")]
		[Address(RVA = "0x61B860", Offset = "0x61AA60", VA = "0x18061B860")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001366")]
	public RawImage rawImage
	{
		[Token(Token = "0x6007E29")]
		[Address(RVA = "0xC6BCC0", Offset = "0xC6AEC0", VA = "0x180C6BCC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001367")]
	public bool visible
	{
		[Token(Token = "0x6007E2A")]
		[Address(RVA = "0x91E9B0", Offset = "0x91DBB0", VA = "0x18091E9B0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007E2B")]
		[Address(RVA = "0xC6BF70", Offset = "0xC6B170", VA = "0x180C6BF70")]
		set
		{
		}
	}

	[Token(Token = "0x140000A0")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6007E2C")]
		[Address(RVA = "0xC6BC20", Offset = "0xC6AE20", VA = "0x180C6BC20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007E2D")]
		[Address(RVA = "0xC6BD50", Offset = "0xC6AF50", VA = "0x180C6BD50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007E2E")]
	[Address(RVA = "0xC6B720", Offset = "0xC6A920", VA = "0x180C6B720", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007E2F")]
	[Address(RVA = "0xC6B690", Offset = "0xC6A890", VA = "0x180C6B690")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007E30")]
	[Address(RVA = "0xC6BA90", Offset = "0xC6AC90", VA = "0x180C6BA90")]
	private void Update()
	{
	}

	[Token(Token = "0x6007E31")]
	[Address(RVA = "0xC6BAA0", Offset = "0xC6ACA0", VA = "0x180C6BAA0")]
	private void VisibleRefresh()
	{
	}

	[Token(Token = "0x6007E32")]
	[Address(RVA = "0xC6B920", Offset = "0xC6AB20", VA = "0x180C6B920")]
	public void SourceChanged()
	{
	}

	[Token(Token = "0x6007E33")]
	[Address(RVA = "0xC6B7A0", Offset = "0xC6A9A0", VA = "0x180C6B7A0")]
	public void OnRebind()
	{
	}

	[Token(Token = "0x6007E34")]
	[Address(RVA = "0xC6B810", Offset = "0xC6AA10", VA = "0x180C6B810", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007E35")]
	[Address(RVA = "0xC6BF80", Offset = "0xC6B180", VA = "0x180C6BF80")]
	[IteratorStateMachine(typeof(_003CyOnBindingRoutine_003Ed__32))]
	private IEnumerator yOnBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007E36")]
	[Address(RVA = "0xC6B750", Offset = "0xC6A950", VA = "0x180C6B750")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007E37")]
	[Address(RVA = "0xC6BB50", Offset = "0xC6AD50", VA = "0x180C6BB50")]
	public BindingMateCapture()
	{
	}
}
