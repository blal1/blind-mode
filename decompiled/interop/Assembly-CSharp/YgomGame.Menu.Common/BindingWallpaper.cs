using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001452")]
public class BindingWallpaper : BindingAsyncBase, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x2001453")]
	[CompilerGenerated]
	private sealed class _003CyBindingRoutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C665")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C666")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C667")]
		[FieldOffset(Offset = "0x20")]
		public BindingWallpaper _003C_003E4__this;

		[Token(Token = "0x400C668")]
		[FieldOffset(Offset = "0x28")]
		private string _003CtranSettingPath_003E5__2;

		[Token(Token = "0x17001389")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007EB6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700138A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007EB8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007EB3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingRoutine_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007EB4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007EB5")]
		[Address(RVA = "0xC80440", Offset = "0xC7F640", VA = "0x180C80440", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007EB7")]
		[Address(RVA = "0xC80F30", Offset = "0xC80130", VA = "0x180C80F30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C65D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private BindingWallpaperContext m_Context;

	[Token(Token = "0x400C65E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_PlayLoopTween;

	[Token(Token = "0x400C65F")]
	[FieldOffset(Offset = "0x40")]
	private IAsyncProgressContent m_AsyncProgress;

	[Token(Token = "0x400C660")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_Wallpaper;

	[Token(Token = "0x400C661")]
	[FieldOffset(Offset = "0x50")]
	private uint m_BodyCrc;

	[Token(Token = "0x400C662")]
	[FieldOffset(Offset = "0x58")]
	private string m_LoadedTranSettingPath;

	[Token(Token = "0x400C663")]
	[FieldOffset(Offset = "0x60")]
	private List<ParticleSystemRenderer> m_ParticleRenderers;

	[Token(Token = "0x17001386")]
	public GameObject wallpaper
	{
		[Token(Token = "0x6007EA7")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001387")]
	public BindingWallpaperContext context
	{
		[Token(Token = "0x6007EA8")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001388")]
	public int id
	{
		[Token(Token = "0x6007EAB")]
		[Address(RVA = "0xC705B0", Offset = "0xC6F7B0", VA = "0x180C705B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007EAC")]
		[Address(RVA = "0xC70680", Offset = "0xC6F880", VA = "0x180C70680")]
		set
		{
		}
	}

	[Token(Token = "0x140000A4")]
	public event Action<BindingWallpaper> onReadyEvent
	{
		[Token(Token = "0x6007EA9")]
		[Address(RVA = "0xC70500", Offset = "0xC6F700", VA = "0x180C70500")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007EAA")]
		[Address(RVA = "0xC705D0", Offset = "0xC6F7D0", VA = "0x180C705D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007EAD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Start()
	{
	}

	[Token(Token = "0x6007EAE")]
	[Address(RVA = "0xC706B0", Offset = "0xC6F8B0", VA = "0x180C706B0", Slot = "17")]
	[IteratorStateMachine(typeof(_003CyBindingRoutine_003Ed__18))]
	protected override IEnumerator yBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007EAF")]
	[Address(RVA = "0xC6FD60", Offset = "0xC6EF60", VA = "0x180C6FD60")]
	private void PlayLoopTween()
	{
	}

	[Token(Token = "0x6007EB0")]
	[Address(RVA = "0xC6FC80", Offset = "0xC6EE80", VA = "0x180C6FC80", Slot = "18")]
	protected override void OnReleaseResources()
	{
	}

	[Token(Token = "0x6007EB1")]
	[Address(RVA = "0xC70470", Offset = "0xC6F670", VA = "0x180C70470")]
	public BindingWallpaper()
	{
	}
}
