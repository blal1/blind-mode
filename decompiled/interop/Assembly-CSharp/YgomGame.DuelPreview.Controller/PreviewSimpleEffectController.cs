using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.DuelPreview.Data;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000EB4")]
public class PreviewSimpleEffectController : IPreviewPlayerController
{
	[Token(Token = "0x2000EB5")]
	public class PreviewSimpleEffect
	{
		[Token(Token = "0x400A43C")]
		[FieldOffset(Offset = "0x10")]
		public readonly string label;

		[Token(Token = "0x400A43D")]
		[FieldOffset(Offset = "0x18")]
		private GameObject pref;

		[Token(Token = "0x400A43E")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_GameObject;

		[Token(Token = "0x400A43F")]
		[FieldOffset(Offset = "0x28")]
		private GameObject target;

		[Token(Token = "0x400A440")]
		[FieldOffset(Offset = "0x30")]
		private List<ParticleSystem> pss;

		[Token(Token = "0x400A441")]
		[FieldOffset(Offset = "0x38")]
		private List<TrailRenderer> trs;

		[Token(Token = "0x400A442")]
		[FieldOffset(Offset = "0x40")]
		private List<Animator> animators;

		[Token(Token = "0x400A443")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, float[]> trailW;

		[Token(Token = "0x400A444")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<ParticleSystem, float> defaultStartDelay;

		[Token(Token = "0x400A445")]
		[FieldOffset(Offset = "0x58")]
		private float duration;

		[Token(Token = "0x400A446")]
		[FieldOffset(Offset = "0x5C")]
		private float time;

		[Token(Token = "0x400A447")]
		[FieldOffset(Offset = "0x60")]
		private bool looping;

		[Token(Token = "0x17000DB1")]
		public bool readyPref
		{
			[Token(Token = "0x6005906")]
			[Address(RVA = "0x9FC1D0", Offset = "0x9FB3D0", VA = "0x1809FC1D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000DB2")]
		public GameObject gameObject
		{
			[Token(Token = "0x6005907")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DB3")]
		public bool isPlaying
		{
			[Token(Token = "0x6005909")]
			[Address(RVA = "0x9FBE50", Offset = "0x9FB050", VA = "0x1809FBE50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6005908")]
		[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
		public PreviewSimpleEffect(string label)
		{
		}

		[Token(Token = "0x600590A")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		public void OnReadyPref(GameObject pref)
		{
		}

		[Token(Token = "0x600590B")]
		[Address(RVA = "0x9FAE80", Offset = "0x9FA080", VA = "0x1809FAE80")]
		public void Instantiate(GameObject target)
		{
		}

		[Token(Token = "0x600590C")]
		[Address(RVA = "0x9FBB10", Offset = "0x9FAD10", VA = "0x1809FBB10")]
		public void Terminate()
		{
		}

		[Token(Token = "0x600590D")]
		[Address(RVA = "0x9FB9F0", Offset = "0x9FABF0", VA = "0x1809FB9F0")]
		public void Play()
		{
		}

		[Token(Token = "0x600590E")]
		[Address(RVA = "0x9FB730", Offset = "0x9FA930", VA = "0x1809FB730")]
		public void OnUpdate()
		{
		}
	}

	[Token(Token = "0x2000EB6")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A448")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A449")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A44A")]
		[FieldOffset(Offset = "0x20")]
		public PreviewSimpleEffectController _003C_003E4__this;

		[Token(Token = "0x400A44B")]
		[FieldOffset(Offset = "0x28")]
		public string label;

		[Token(Token = "0x400A44C")]
		[FieldOffset(Offset = "0x30")]
		public GameObject target;

		[Token(Token = "0x400A44D")]
		[FieldOffset(Offset = "0x38")]
		public bool hasShakeCamera;

		[Token(Token = "0x400A44E")]
		[FieldOffset(Offset = "0x39")]
		public bool useSubCamera;

		[Token(Token = "0x400A44F")]
		[FieldOffset(Offset = "0x40")]
		public DuelPreviewAsset duelPreviewAsset;

		[Token(Token = "0x400A450")]
		[FieldOffset(Offset = "0x48")]
		public float overrideDuration;

		[Token(Token = "0x400A451")]
		[FieldOffset(Offset = "0x50")]
		private PreviewSimpleEffect _003CsimpleEffect_003E5__2;

		[Token(Token = "0x400A452")]
		[FieldOffset(Offset = "0x58")]
		private DuelPreviewAsset.DurationOverride _003CpreviewDurationOverride_003E5__3;

		[Token(Token = "0x400A453")]
		[FieldOffset(Offset = "0x60")]
		private float _003CpastTime_003E5__4;

		[Token(Token = "0x17000DB4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005912")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DB5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005914")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600590F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005910")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005911")]
		[Address(RVA = "0x9FCE70", Offset = "0x9FC070", VA = "0x1809FCE70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005913")]
		[Address(RVA = "0x9FD3C0", Offset = "0x9FC5C0", VA = "0x1809FD3C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000EB7")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A454")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A455")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000DB6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005918")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DB7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600591A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005915")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005916")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005917")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005919")]
		[Address(RVA = "0x9FFFF0", Offset = "0x9FF1F0", VA = "0x1809FFFF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000EB8")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A456")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A457")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A458")]
		[FieldOffset(Offset = "0x20")]
		public PreviewSimpleEffectController _003C_003E4__this;

		[Token(Token = "0x400A459")]
		[FieldOffset(Offset = "0x28")]
		public string label;

		[Token(Token = "0x400A45A")]
		[FieldOffset(Offset = "0x30")]
		public string path;

		[Token(Token = "0x17000DB8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600591E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DB9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005920")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600591B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600591C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600591D")]
		[Address(RVA = "0xA002E0", Offset = "0x9FF4E0", VA = "0x180A002E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600591F")]
		[Address(RVA = "0xA004E0", Offset = "0x9FF6E0", VA = "0x180A004E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A438")]
	[FieldOffset(Offset = "0x10")]
	private readonly PreviewResourceController m_ResourceController;

	[Token(Token = "0x400A439")]
	[FieldOffset(Offset = "0x18")]
	private readonly PreviewPrefabController m_PrefabController;

	[Token(Token = "0x400A43A")]
	[FieldOffset(Offset = "0x20")]
	private readonly PreviewCameraController m_CameraController;

	[Token(Token = "0x400A43B")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, PreviewSimpleEffect> m_PlayingEffectMap;

	[Token(Token = "0x17000DB0")]
	public ControllerType controllerType
	{
		[Token(Token = "0x60058FE")]
		[Address(RVA = "0x9FAD40", Offset = "0x9F9F40", VA = "0x1809FAD40", Slot = "4")]
		get
		{
			return default(ControllerType);
		}
	}

	[Token(Token = "0x60058FF")]
	[Address(RVA = "0x9FA930", Offset = "0x9F9B30", VA = "0x1809FA930")]
	public PreviewSimpleEffect Find(string label)
	{
		return null;
	}

	[Token(Token = "0x6005900")]
	[Address(RVA = "0x9FAC70", Offset = "0x9F9E70", VA = "0x1809FAC70")]
	public PreviewSimpleEffectController(PreviewResourceController resourceController, PreviewPrefabController prefabController, PreviewCameraController cameraController)
	{
	}

	[Token(Token = "0x6005901")]
	[Address(RVA = "0x9FAD80", Offset = "0x9F9F80", VA = "0x1809FAD80", Slot = "5")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__9))]
	public IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x6005902")]
	[Address(RVA = "0x9FAC60", Offset = "0x9F9E60", VA = "0x1809FAC60", Slot = "6")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6005903")]
	[Address(RVA = "0x9FAAA0", Offset = "0x9F9CA0", VA = "0x1809FAAA0", Slot = "7")]
	public void Release()
	{
	}

	[Token(Token = "0x6005904")]
	[Address(RVA = "0x9FADD0", Offset = "0x9F9FD0", VA = "0x1809FADD0")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__12))]
	public IEnumerator ySetup(string label, string path)
	{
		return null;
	}

	[Token(Token = "0x6005905")]
	[Address(RVA = "0x9FA9C0", Offset = "0x9F9BC0", VA = "0x1809FA9C0")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__13))]
	public IEnumerator Play(string label, GameObject target, DuelPreviewAsset duelPreviewAsset, bool hasShakeCamera, bool useSubCamera = false, float overrideDuration = 0f)
	{
		return null;
	}
}
