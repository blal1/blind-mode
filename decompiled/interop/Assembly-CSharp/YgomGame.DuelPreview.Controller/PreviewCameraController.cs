using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;
using YgomSystem.Effect;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000E94")]
public class PreviewCameraController : IPreviewPlayerControllerRequireGob, IPreviewPlayerController, IMainCameraOperation
{
	[Token(Token = "0x2000E95")]
	[CompilerGenerated]
	private sealed class _003CLoadShake_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A3B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A3B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A3B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PreviewCameraController _003C_003E4__this;

		[Token(Token = "0x17000D7F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005814")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D80")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005816")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005811")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadShake_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005812")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005813")]
		[Address(RVA = "0x9C3850", Offset = "0x9C2A50", VA = "0x1809C3850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005815")]
		[Address(RVA = "0x9C38F0", Offset = "0x9C2AF0", VA = "0x1809C38F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E96")]
	[CompilerGenerated]
	private sealed class _003CPlayShake_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A3B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A3B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A3B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PreviewCameraController _003C_003E4__this;

		[Token(Token = "0x400A3B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string label;

		[Token(Token = "0x17000D81")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600581A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D82")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600581C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005817")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlayShake_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005818")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005819")]
		[Address(RVA = "0x9C3930", Offset = "0x9C2B30", VA = "0x1809C3930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600581B")]
		[Address(RVA = "0x9C3A60", Offset = "0x9C2C60", VA = "0x1809C3A60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E97")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A3B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A3B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000D83")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005820")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D84")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005822")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600581D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600581E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600581F")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005821")]
		[Address(RVA = "0x9C7DD0", Offset = "0x9C6FD0", VA = "0x1809C7DD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A3A8")]
	private const string k_CameraShakeSettingPath = "Duel/ScriptableObject/CameraShakerSetting";

	[Token(Token = "0x400A3A9")]
	private const string k_ELabel_BaseCamera = "PreviewBaseCamera";

	[Token(Token = "0x400A3AA")]
	private const string k_ELabel_SubCamera = "PreviewSubCamera";

	[Token(Token = "0x400A3AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly PreviewResourceController m_PreviewResourceController;

	[Token(Token = "0x400A3AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Camera m_PreviewCamera;

	[Token(Token = "0x400A3AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Camera m_PreviewSubCamera;

	[Token(Token = "0x400A3AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3[] m_PreviewCameraOrgTran;

	[Token(Token = "0x400A3AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3[] m_PreviewSubCameraOrgTran;

	[Token(Token = "0x400A3B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PreviewCameraRunner m_CameraBehaviour;

	[Token(Token = "0x17000D7C")]
	public Camera previewCamera
	{
		[Token(Token = "0x60057FA")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D7D")]
	public Camera previewSubCamera
	{
		[Token(Token = "0x60057FB")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D7E")]
	public ControllerType controllerType
	{
		[Token(Token = "0x60057FC")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "6")]
		get
		{
			return default(ControllerType);
		}
	}

	[Token(Token = "0x60057FD")]
	[Address(RVA = "0x9BE930", Offset = "0x9BDB30", VA = "0x1809BE930")]
	public Camera GetCamera(bool hasShakeCamera, bool hasScreenEffect, bool useSubCamera = false)
	{
		return null;
	}

	[Token(Token = "0x60057FE")]
	[Address(RVA = "0x9BE950", Offset = "0x9BDB50", VA = "0x1809BE950")]
	public int GetLayer(Camera camera)
	{
		return default(int);
	}

	[Token(Token = "0x60057FF")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public PreviewCameraController(PreviewResourceController previewResourceController)
	{
	}

	[Token(Token = "0x6005800")]
	[Address(RVA = "0x9BE3B0", Offset = "0x9BD5B0", VA = "0x1809BE3B0", Slot = "4")]
	public void BindGob(params GameObject[] gobs)
	{
	}

	[Token(Token = "0x6005801")]
	[Address(RVA = "0x9BF040", Offset = "0x9BE240", VA = "0x1809BF040", Slot = "5")]
	public void UnbindGob()
	{
	}

	[Token(Token = "0x6005802")]
	[Address(RVA = "0x9BF090", Offset = "0x9BE290", VA = "0x1809BF090", Slot = "7")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__20))]
	public IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x6005803")]
	[Address(RVA = "0x9BF030", Offset = "0x9BE230", VA = "0x1809BF030", Slot = "8")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6005804")]
	[Address(RVA = "0x9BEC60", Offset = "0x9BDE60", VA = "0x1809BEC60", Slot = "9")]
	public void Release()
	{
	}

	[Token(Token = "0x6005805")]
	[Address(RVA = "0x9BF010", Offset = "0x9BE210", VA = "0x1809BF010")]
	public void Setup()
	{
	}

	[Token(Token = "0x6005806")]
	[Address(RVA = "0x9BEF00", Offset = "0x9BE100", VA = "0x1809BEF00")]
	public void SetupCamera(Camera camera, [Optional] ScreenEffect screenEffect)
	{
	}

	[Token(Token = "0x6005807")]
	[Address(RVA = "0x9BE570", Offset = "0x9BD770", VA = "0x1809BE570")]
	private static void CopyToCameraSetting(Camera targetCamera, Camera sourceCamera)
	{
	}

	[Token(Token = "0x6005808")]
	[Address(RVA = "0x9BEB60", Offset = "0x9BDD60", VA = "0x1809BEB60")]
	[IteratorStateMachine(typeof(_003CLoadShake_003Ed__26))]
	public IEnumerator LoadShake()
	{
		return null;
	}

	[Token(Token = "0x6005809")]
	[Address(RVA = "0x9BEBD0", Offset = "0x9BDDD0", VA = "0x1809BEBD0")]
	[IteratorStateMachine(typeof(_003CPlayShake_003Ed__27))]
	public IEnumerator PlayShake(string label)
	{
		return null;
	}

	[Token(Token = "0x600580A")]
	[Address(RVA = "0x9BDF50", Offset = "0x9BD150", VA = "0x1809BDF50")]
	public void ActivateRender()
	{
	}

	[Token(Token = "0x600580B")]
	[Address(RVA = "0x9BE5F0", Offset = "0x9BD7F0", VA = "0x1809BE5F0")]
	public void DeactivateRender()
	{
	}

	[Token(Token = "0x600580C")]
	[Address(RVA = "0x9BE890", Offset = "0x9BDA90", VA = "0x1809BE890")]
	private void ExportTranInfo(Transform targetTran, Vector3[] tranInfo)
	{
	}

	[Token(Token = "0x600580D")]
	[Address(RVA = "0x9BE9E0", Offset = "0x9BDBE0", VA = "0x1809BE9E0")]
	private void ImportTranInfo(Transform targetTran, Vector3[] tranInfo)
	{
	}

	[Token(Token = "0x600580E")]
	[Address(RVA = "0x9BEAA0", Offset = "0x9BDCA0", VA = "0x1809BEAA0")]
	private void ImportTranInfo(Transform targetTran, Transform fromTran)
	{
	}

	[Token(Token = "0x600580F")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "10")]
	public void UpdateOperation(MainCameraOrganizer mainCamera)
	{
	}

	[Token(Token = "0x6005810")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
	public void LateUpdateOperation(MainCameraOrganizer mainCamera)
	{
	}
}
