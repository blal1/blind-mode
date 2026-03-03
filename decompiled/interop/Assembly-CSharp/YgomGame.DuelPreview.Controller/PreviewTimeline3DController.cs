using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.DuelPreview.Data;
using YgomSystem.Effect;
using YgomSystem.Timeline;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000EB9")]
public class PreviewTimeline3DController : IPreviewPlayerController
{
	[Token(Token = "0x2000EBA")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x400A464")]
		[FieldOffset(Offset = "0x10")]
		public int playingInstanceId;

		[Token(Token = "0x400A465")]
		[FieldOffset(Offset = "0x18")]
		public PreviewTimeline3DController _003C_003E4__this;

		[Token(Token = "0x400A466")]
		[FieldOffset(Offset = "0x20")]
		public string label;

		[Token(Token = "0x600592B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x600592C")]
		[Address(RVA = "0x9FEDE0", Offset = "0x9FDFE0", VA = "0x1809FEDE0")]
		internal void _003CPlay_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000EBB")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A467")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A468")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A469")]
		[FieldOffset(Offset = "0x20")]
		public PreviewTimeline3DController _003C_003E4__this;

		[Token(Token = "0x400A46A")]
		[FieldOffset(Offset = "0x28")]
		public string label;

		[Token(Token = "0x400A46B")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		[Token(Token = "0x400A46C")]
		[FieldOffset(Offset = "0x38")]
		public bool hasShakeCamera;

		[Token(Token = "0x400A46D")]
		[FieldOffset(Offset = "0x39")]
		public bool useSubCamera;

		[Token(Token = "0x400A46E")]
		[FieldOffset(Offset = "0x40")]
		public DuelPreviewAsset duelPreviewAsset;

		[Token(Token = "0x400A46F")]
		[FieldOffset(Offset = "0x48")]
		public float overrideDuration;

		[Token(Token = "0x400A470")]
		[FieldOffset(Offset = "0x50")]
		private DuelPreviewAsset.DurationOverride _003CpreviewDurationOverride_003E5__2;

		[Token(Token = "0x400A471")]
		[FieldOffset(Offset = "0x58")]
		private float _003CpastTime_003E5__3;

		[Token(Token = "0x17000DBD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005930")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DBE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005932")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600592D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600592E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600592F")]
		[Address(RVA = "0x9FD400", Offset = "0x9FC600", VA = "0x1809FD400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005931")]
		[Address(RVA = "0x9FDAD0", Offset = "0x9FCCD0", VA = "0x1809FDAD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000EBC")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A472")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A473")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000DBF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005936")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DC0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005938")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005933")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005934")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005935")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005937")]
		[Address(RVA = "0x9FFB70", Offset = "0x9FED70", VA = "0x1809FFB70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000EBD")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A474")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A475")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A476")]
		[FieldOffset(Offset = "0x20")]
		public PreviewTimeline3DController _003C_003E4__this;

		[Token(Token = "0x400A477")]
		[FieldOffset(Offset = "0x28")]
		public string path;

		[Token(Token = "0x17000DC1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600593C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DC2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600593E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005939")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600593A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600593B")]
		[Address(RVA = "0xA00520", Offset = "0x9FF720", VA = "0x180A00520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600593D")]
		[Address(RVA = "0xA005F0", Offset = "0x9FF7F0", VA = "0x180A005F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A45B")]
	[FieldOffset(Offset = "0x10")]
	private readonly PreviewResourceController m_ResourceController;

	[Token(Token = "0x400A45C")]
	[FieldOffset(Offset = "0x18")]
	private readonly PreviewPrefabController m_PrefabController;

	[Token(Token = "0x400A45D")]
	[FieldOffset(Offset = "0x20")]
	private readonly PreviewCameraController m_CameraController;

	[Token(Token = "0x400A45E")]
	[FieldOffset(Offset = "0x28")]
	private string m_Path;

	[Token(Token = "0x400A45F")]
	[FieldOffset(Offset = "0x30")]
	private TimelineObject m_PlayingTmObj;

	[Token(Token = "0x400A460")]
	[FieldOffset(Offset = "0x38")]
	private Camera m_PreviewCamera;

	[Token(Token = "0x400A461")]
	[FieldOffset(Offset = "0x40")]
	private ScreenEffect m_ScreenEffect;

	[Token(Token = "0x400A462")]
	[FieldOffset(Offset = "0x48")]
	private List<SpriteScaler> m_SpriteScalers;

	[Token(Token = "0x400A463")]
	[FieldOffset(Offset = "0x50")]
	private List<int> m_PlayingInstanceIDs;

	[Token(Token = "0x17000DBA")]
	public TimelineObject playingTmObj
	{
		[Token(Token = "0x6005921")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DBB")]
	public bool isPlaying
	{
		[Token(Token = "0x6005922")]
		[Address(RVA = "0x9FC700", Offset = "0x9FB900", VA = "0x1809FC700")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000DBC")]
	public ControllerType controllerType
	{
		[Token(Token = "0x6005923")]
		[Address(RVA = "0x573650", Offset = "0x572850", VA = "0x180573650", Slot = "4")]
		get
		{
			return default(ControllerType);
		}
	}

	[Token(Token = "0x6005924")]
	[Address(RVA = "0x9FC630", Offset = "0x9FB830", VA = "0x1809FC630")]
	public PreviewTimeline3DController(PreviewResourceController resourceController, PreviewPrefabController prefabController, PreviewCameraController cameraController)
	{
	}

	[Token(Token = "0x6005925")]
	[Address(RVA = "0x9FC750", Offset = "0x9FB950", VA = "0x1809FC750", Slot = "5")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__16))]
	public IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x6005926")]
	[Address(RVA = "0x9FC620", Offset = "0x9FB820", VA = "0x1809FC620", Slot = "6")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6005927")]
	[Address(RVA = "0x9FC500", Offset = "0x9FB700", VA = "0x1809FC500", Slot = "7")]
	public void Release()
	{
	}

	[Token(Token = "0x6005928")]
	[Address(RVA = "0x9FC7A0", Offset = "0x9FB9A0", VA = "0x1809FC7A0")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__19))]
	public IEnumerator ySetup(string path)
	{
		return null;
	}

	[Token(Token = "0x6005929")]
	[Address(RVA = "0x9FC430", Offset = "0x9FB630", VA = "0x1809FC430")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__20))]
	public IEnumerator Play(string label, DuelPreviewAsset duelPreviewAsset, bool hasShakeCamera, bool useSubCamera = false, float overrideDuration = 0f)
	{
		return null;
	}

	[Token(Token = "0x600592A")]
	[Address(RVA = "0x9FC220", Offset = "0x9FB420", VA = "0x1809FC220")]
	public void ApplyScpriteScaler()
	{
	}
}
