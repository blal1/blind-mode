using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000EAA")]
public class PreviewRenderTextureController : IPreviewPlayerController
{
	[Token(Token = "0x2000EAB")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A41D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A41E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000DA4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60058B9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DA5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60058BB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60058B6")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60058B7")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60058B8")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60058BA")]
		[Address(RVA = "0x9FFF30", Offset = "0x9FF130", VA = "0x1809FFF30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A41C")]
	[FieldOffset(Offset = "0x10")]
	private RenderTexture m_StrongSummonRenderTexture;

	[Token(Token = "0x17000DA3")]
	public ControllerType controllerType
	{
		[Token(Token = "0x60058B0")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "4")]
		get
		{
			return default(ControllerType);
		}
	}

	[Token(Token = "0x60058B1")]
	[Address(RVA = "0x9F9940", Offset = "0x9F8B40", VA = "0x1809F9940", Slot = "5")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__3))]
	public IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x60058B2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public void Terminate()
	{
	}

	[Token(Token = "0x60058B3")]
	[Address(RVA = "0x9F98A0", Offset = "0x9F8AA0", VA = "0x1809F98A0", Slot = "7")]
	public void Release()
	{
	}

	[Token(Token = "0x60058B4")]
	[Address(RVA = "0x9F9760", Offset = "0x9F8960", VA = "0x1809F9760")]
	public RenderTexture GetOrCreate(RawImage rawImage)
	{
		return null;
	}

	[Token(Token = "0x60058B5")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PreviewRenderTextureController()
	{
	}
}
