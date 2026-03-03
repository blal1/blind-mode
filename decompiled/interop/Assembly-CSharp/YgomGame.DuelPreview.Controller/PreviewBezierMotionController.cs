using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000E91")]
public class PreviewBezierMotionController : IPreviewPlayerController
{
	[Token(Token = "0x2000E92")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A39A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000D78")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60057F1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D79")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60057F3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60057EE")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60057EF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60057F0")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60057F2")]
		[Address(RVA = "0x9C7D50", Offset = "0x9C6F50", VA = "0x1809C7D50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E93")]
	[CompilerGenerated]
	private sealed class _003CyPlay_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A39B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A39C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A39D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PreviewBezierMotionController _003C_003E4__this;

		[Token(Token = "0x400A39E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string bezierMotionPath;

		[Token(Token = "0x400A39F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject target;

		[Token(Token = "0x400A3A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 destPosition;

		[Token(Token = "0x400A3A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 destRotation;

		[Token(Token = "0x400A3A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 destScale;

		[Token(Token = "0x400A3A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float overrideDuration;

		[Token(Token = "0x400A3A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Action onComplete;

		[Token(Token = "0x400A3A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BezierMotionSetting _003Csetting_003E5__2;

		[Token(Token = "0x400A3A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _003Ctime_003E5__3;

		[Token(Token = "0x400A3A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _003Cduration_003E5__4;

		[Token(Token = "0x17000D7A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60057F7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D7B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60057F9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60057F4")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlay_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60057F5")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60057F6")]
		[Address(RVA = "0x9C9CE0", Offset = "0x9C8EE0", VA = "0x1809C9CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60057F8")]
		[Address(RVA = "0x9C9F90", Offset = "0x9C9190", VA = "0x1809C9F90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly PreviewResourceController m_ResourceController;

	[Token(Token = "0x400A393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 m_StartPosition;

	[Token(Token = "0x400A394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Quaternion m_StartRotation;

	[Token(Token = "0x400A395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 m_StartScale;

	[Token(Token = "0x400A396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 m_DestPosition;

	[Token(Token = "0x400A397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector3 m_DestRotation;

	[Token(Token = "0x400A398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 m_DestScale;

	[Token(Token = "0x17000D77")]
	public ControllerType controllerType
	{
		[Token(Token = "0x60057E6")]
		[Address(RVA = "0x577DA0", Offset = "0x576FA0", VA = "0x180577DA0", Slot = "4")]
		get
		{
			return default(ControllerType);
		}
	}

	[Token(Token = "0x60057E7")]
	[Address(RVA = "0x9BDC60", Offset = "0x9BCE60", VA = "0x1809BDC60")]
	public PreviewBezierMotionController(PreviewResourceController resourceController)
	{
	}

	[Token(Token = "0x60057E8")]
	[Address(RVA = "0x9BDDF0", Offset = "0x9BCFF0", VA = "0x1809BDDF0", Slot = "5")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__10))]
	public IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x60057E9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public void Terminate()
	{
	}

	[Token(Token = "0x60057EA")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
	public void Release()
	{
	}

	[Token(Token = "0x60057EB")]
	[Address(RVA = "0x9BDC00", Offset = "0x9BCE00", VA = "0x1809BDC00")]
	public bool LoadCheckResource(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60057EC")]
	[Address(RVA = "0x9BDE40", Offset = "0x9BD040", VA = "0x1809BDE40")]
	[IteratorStateMachine(typeof(_003CyPlay_003Ed__14))]
	public IEnumerator yPlay(GameObject target, string bezierMotionPath, Vector3 destPosition, Vector3 destRotation, Vector3 destScale, float overrideDuration = 0f, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60057ED")]
	[Address(RVA = "0x9BD970", Offset = "0x9BCB70", VA = "0x1809BD970")]
	private void ApplyMotion(float time, BezierMotionSetting setting, GameObject target)
	{
	}
}
