using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000EAC")]
public class PreviewResourceController : IPreviewPlayerControllerRequireGob, IPreviewPlayerController
{
	[Token(Token = "0x2000EAD")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x400A423")]
		[FieldOffset(Offset = "0x10")]
		public bool ready;

		[Token(Token = "0x60058CB")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60058CC")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CySetupLoadCardTex_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000EAE")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A424")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A425")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000DA7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60058D0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DA8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60058D2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60058CD")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60058CE")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60058CF")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60058D1")]
		[Address(RVA = "0x9FFAF0", Offset = "0x9FECF0", VA = "0x1809FFAF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000EAF")]
	[CompilerGenerated]
	private sealed class _003CyLoadWaitResource_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A426")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A427")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A428")]
		[FieldOffset(Offset = "0x20")]
		public string path;

		[Token(Token = "0x17000DA9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60058D6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DAA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60058D8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60058D3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyLoadWaitResource_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60058D4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60058D5")]
		[Address(RVA = "0xA00030", Offset = "0x9FF230", VA = "0x180A00030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60058D7")]
		[Address(RVA = "0xA00090", Offset = "0x9FF290", VA = "0x180A00090", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000EB0")]
	[CompilerGenerated]
	private sealed class _003CySetupLoadCardTex_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A429")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A42A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A42B")]
		[FieldOffset(Offset = "0x20")]
		public PreviewResourceController _003C_003E4__this;

		[Token(Token = "0x400A42C")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		[Token(Token = "0x17000DAB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60058DC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DAC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60058DE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60058D9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetupLoadCardTex_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60058DA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60058DB")]
		[Address(RVA = "0xA000D0", Offset = "0x9FF2D0", VA = "0x180A000D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60058DD")]
		[Address(RVA = "0xA002A0", Offset = "0x9FF4A0", VA = "0x180A002A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A41F")]
	[FieldOffset(Offset = "0x10")]
	private List<string> m_CachedPaths;

	[Token(Token = "0x400A420")]
	[FieldOffset(Offset = "0x18")]
	private List<string> m_HoldingPaths;

	[Token(Token = "0x400A421")]
	[FieldOffset(Offset = "0x20")]
	private List<int> m_SetupMrks;

	[Token(Token = "0x400A422")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_ResourceHolder;

	[Token(Token = "0x17000DA6")]
	public ControllerType controllerType
	{
		[Token(Token = "0x60058BC")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "6")]
		get
		{
			return default(ControllerType);
		}
	}

	[Token(Token = "0x60058BD")]
	[Address(RVA = "0x9F9B70", Offset = "0x9F8D70", VA = "0x1809F9B70")]
	private bool IsAssignedPath(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60058BE")]
	[Address(RVA = "0x9F9AB0", Offset = "0x9F8CB0", VA = "0x1809F9AB0")]
	private void AssignePath(string path, bool isHold)
	{
	}

	[Token(Token = "0x60058BF")]
	[Address(RVA = "0x9F83C0", Offset = "0x9F75C0", VA = "0x1809F83C0", Slot = "4")]
	public void BindGob(params GameObject[] gobs)
	{
	}

	[Token(Token = "0x60058C0")]
	[Address(RVA = "0x9F9620", Offset = "0x9F8820", VA = "0x1809F9620", Slot = "5")]
	public void UnbindGob()
	{
	}

	[Token(Token = "0x60058C1")]
	[Address(RVA = "0x9F9F90", Offset = "0x9F9190", VA = "0x1809F9F90", Slot = "7")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__10))]
	public IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x60058C2")]
	[Address(RVA = "0x9F9D50", Offset = "0x9F8F50", VA = "0x1809F9D50", Slot = "8")]
	public void Terminate()
	{
	}

	[Token(Token = "0x60058C3")]
	[Address(RVA = "0x9F9990", Offset = "0x9F8B90", VA = "0x1809F9990")]
	public void AssignSetupCardTex(int mrk)
	{
	}

	[Token(Token = "0x60058C4")]
	[Address(RVA = "0x9FA050", Offset = "0x9F9250", VA = "0x1809FA050")]
	[IteratorStateMachine(typeof(_003CySetupLoadCardTex_003Ed__13))]
	public IEnumerator ySetupLoadCardTex()
	{
		return null;
	}

	[Token(Token = "0x60058C5")]
	[Address(RVA = "0x9F9D90", Offset = "0x9F8F90", VA = "0x1809F9D90")]
	public void UnloadCaches()
	{
	}

	[Token(Token = "0x60058C6")]
	[Address(RVA = "0x9F9C00", Offset = "0x9F8E00", VA = "0x1809F9C00", Slot = "9")]
	public void Release()
	{
	}

	[Token(Token = "0x60058C7")]
	public bool LoadCheckResource<T>(string path, bool isHold = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60058C8")]
	[Address(RVA = "0x9F9FE0", Offset = "0x9F91E0", VA = "0x1809F9FE0")]
	[IteratorStateMachine(typeof(_003CyLoadWaitResource_003Ed__17))]
	public IEnumerator yLoadWaitResource(string path)
	{
		return null;
	}

	[Token(Token = "0x60058C9")]
	public T GetAsset<T>(string path) where T : class
	{
		return null;
	}

	[Token(Token = "0x60058CA")]
	[Address(RVA = "0x9F9EE0", Offset = "0x9F90E0", VA = "0x1809F9EE0")]
	public PreviewResourceController()
	{
	}
}
