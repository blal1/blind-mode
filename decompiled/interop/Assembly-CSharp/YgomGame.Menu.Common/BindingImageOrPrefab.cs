using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001438")]
public class BindingImageOrPrefab : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x2001439")]
	[CompilerGenerated]
	private sealed class _003CySequence_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C5BF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C5C0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C5C1")]
		[FieldOffset(Offset = "0x20")]
		public BindingImageOrPrefab _003C_003E4__this;

		[Token(Token = "0x400C5C2")]
		[FieldOffset(Offset = "0x28")]
		private string _003CbasePath_003E5__2;

		[Token(Token = "0x400C5C3")]
		[FieldOffset(Offset = "0x30")]
		private IAsyncProgressContent _003CasyncContent_003E5__3;

		[Token(Token = "0x1700134C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007DDA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700134D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007DDC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007DD7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySequence_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007DD8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007DD9")]
		[Address(RVA = "0xC69890", Offset = "0xC68A90", VA = "0x180C69890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007DDB")]
		[Address(RVA = "0xC69DD0", Offset = "0xC68FD0", VA = "0x180C69DD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C5B8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_Path;

	[Token(Token = "0x400C5B9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AspectRatioFitter.AspectMode m_ImageAspectMode;

	[Token(Token = "0x400C5BA")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private BindingGameObjectEx.FitMode m_PrefabFitMode;

	[Token(Token = "0x400C5BB")]
	[FieldOffset(Offset = "0x30")]
	private uint m_Crc;

	[Token(Token = "0x400C5BC")]
	[FieldOffset(Offset = "0x38")]
	private IEnumerator m_SequenceRoutine;

	[Token(Token = "0x400C5BD")]
	[FieldOffset(Offset = "0x40")]
	private Action<BindingImageOrPrefab> m_HandleOnFailedCallback;

	[Token(Token = "0x17001346")]
	public string path
	{
		[Token(Token = "0x6007DC4")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007DC5")]
		[Address(RVA = "0xC5EB40", Offset = "0xC5DD40", VA = "0x180C5EB40")]
		set
		{
		}
	}

	[Token(Token = "0x17001347")]
	public AspectRatioFitter.AspectMode imageAspectMode
	{
		[Token(Token = "0x6007DC6")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		get
		{
			return default(AspectRatioFitter.AspectMode);
		}
		[Token(Token = "0x6007DC7")]
		[Address(RVA = "0xC5EB30", Offset = "0xC5DD30", VA = "0x180C5EB30")]
		set
		{
		}
	}

	[Token(Token = "0x17001348")]
	public BindingGameObjectEx.FitMode prefabFitMode
	{
		[Token(Token = "0x6007DC8")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0")]
		get
		{
			return default(BindingGameObjectEx.FitMode);
		}
		[Token(Token = "0x6007DC9")]
		[Address(RVA = "0xC5EB90", Offset = "0xC5DD90", VA = "0x180C5EB90")]
		set
		{
		}
	}

	[Token(Token = "0x17001349")]
	public bool visible
	{
		[Token(Token = "0x6007DCA")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700134A")]
	public bool handleOnFailed
	{
		[Token(Token = "0x6007DCB")]
		[Address(RVA = "0xC5EA80", Offset = "0xC5DC80", VA = "0x180C5EA80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700134B")]
	public Action<BindingImageOrPrefab> handleOnFailedCallback
	{
		[Token(Token = "0x6007DCC")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		set
		{
		}
	}

	[Token(Token = "0x1400009D")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6007DCD")]
		[Address(RVA = "0xC5E9E0", Offset = "0xC5DBE0", VA = "0x180C5E9E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007DCE")]
		[Address(RVA = "0xC5EA90", Offset = "0xC5DC90", VA = "0x180C5EA90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007DCF")]
	[Address(RVA = "0xC5E380", Offset = "0xC5D580", VA = "0x180C5E380", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007DD0")]
	[Address(RVA = "0xC5E9C0", Offset = "0xC5DBC0", VA = "0x180C5E9C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6007DD1")]
	[Address(RVA = "0xC5E3D0", Offset = "0xC5D5D0", VA = "0x180C5E3D0", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007DD2")]
	[Address(RVA = "0xC5EBA0", Offset = "0xC5DDA0", VA = "0x180C5EBA0")]
	[IteratorStateMachine(typeof(_003CySequence_003Ed__27))]
	private IEnumerator ySequence()
	{
		return null;
	}

	[Token(Token = "0x6007DD3")]
	[Address(RVA = "0xC5E3A0", Offset = "0xC5D5A0", VA = "0x180C5E3A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007DD4")]
	[Address(RVA = "0xC5E5F0", Offset = "0xC5D7F0", VA = "0x180C5E5F0")]
	private void SwitchTargetActivate(bool isPref)
	{
	}

	[Token(Token = "0x6007DD5")]
	[Address(RVA = "0xC5E4C0", Offset = "0xC5D6C0", VA = "0x180C5E4C0")]
	private void SourceChange()
	{
	}

	[Token(Token = "0x6007DD6")]
	[Address(RVA = "0xC5E9D0", Offset = "0xC5DBD0", VA = "0x180C5E9D0")]
	public BindingImageOrPrefab()
	{
	}
}
