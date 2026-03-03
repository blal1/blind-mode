using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000EB1")]
public class PreviewScreenController : IPreviewPlayerControllerRequireGob, IPreviewPlayerController
{
	[Token(Token = "0x2000EB2")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A42E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A42F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000DAE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60058EE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DAF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60058F0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60058EB")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60058EC")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60058ED")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60058EF")]
		[Address(RVA = "0x9FFF70", Offset = "0x9FF170", VA = "0x1809FFF70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A42D")]
	[FieldOffset(Offset = "0x10")]
	private PreviewScreenFiller m_ScreenFilter;

	[Token(Token = "0x17000DAD")]
	public ControllerType controllerType
	{
		[Token(Token = "0x60058DF")]
		[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "6")]
		get
		{
			return default(ControllerType);
		}
	}

	[Token(Token = "0x60058E0")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PreviewScreenController()
	{
	}

	[Token(Token = "0x60058E1")]
	[Address(RVA = "0x9FA0C0", Offset = "0x9F92C0", VA = "0x1809FA0C0", Slot = "4")]
	public void BindGob(params GameObject[] gobs)
	{
	}

	[Token(Token = "0x60058E2")]
	[Address(RVA = "0x9FA490", Offset = "0x9F9690", VA = "0x1809FA490", Slot = "5")]
	public void UnbindGob()
	{
	}

	[Token(Token = "0x60058E3")]
	[Address(RVA = "0x9FA4B0", Offset = "0x9F96B0", VA = "0x1809FA4B0", Slot = "7")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__6))]
	public IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x60058E4")]
	[Address(RVA = "0x9FA1F0", Offset = "0x9F93F0", VA = "0x1809FA1F0", Slot = "8")]
	public void Terminate()
	{
	}

	[Token(Token = "0x60058E5")]
	[Address(RVA = "0x9FA1F0", Offset = "0x9F93F0", VA = "0x1809FA1F0", Slot = "9")]
	public void Release()
	{
	}

	[Token(Token = "0x60058E6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void ActivateRender()
	{
	}

	[Token(Token = "0x60058E7")]
	[Address(RVA = "0x9FA1F0", Offset = "0x9F93F0", VA = "0x1809FA1F0")]
	public void DeactivateRenderer()
	{
	}

	[Token(Token = "0x60058E8")]
	[Address(RVA = "0x9FA290", Offset = "0x9F9490", VA = "0x1809FA290")]
	public void Setup(Camera renderCamera)
	{
	}

	[Token(Token = "0x60058E9")]
	[Address(RVA = "0x9FA420", Offset = "0x9F9620", VA = "0x1809FA420")]
	public void StartFillFade(Color color)
	{
	}

	[Token(Token = "0x60058EA")]
	[Address(RVA = "0x9FA3B0", Offset = "0x9F95B0", VA = "0x1809FA3B0")]
	public void StartFillFade(Color color, float fadeTime)
	{
	}
}
