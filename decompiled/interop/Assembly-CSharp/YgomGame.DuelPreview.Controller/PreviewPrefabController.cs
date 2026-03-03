using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.Timeline;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000EA8")]
public class PreviewPrefabController : IPreviewPlayerControllerRequireGob, IPreviewPlayerController
{
	[Token(Token = "0x2000EA9")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A41A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A41B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000DA1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60058AD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DA2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60058AF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60058AA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60058AB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60058AC")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60058AE")]
		[Address(RVA = "0x9FFB30", Offset = "0x9FED30", VA = "0x1809FFB30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly DuelPreviewPlayer.Option m_Option;

	[Token(Token = "0x400A414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PreviewResourceController m_ResourceController;

	[Token(Token = "0x400A415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PreviewCameraController m_CameraController;

	[Token(Token = "0x400A416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject m_SpawnRoot;

	[Token(Token = "0x400A417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<string, GameObject> m_CloneMap;

	[Token(Token = "0x400A418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<string, bool> m_DonePlayMap;

	[Token(Token = "0x400A419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<object> m_Mods;

	[Token(Token = "0x17000DA0")]
	public ControllerType controllerType
	{
		[Token(Token = "0x6005892")]
		[Address(RVA = "0x4446D0", Offset = "0x4438D0", VA = "0x1804446D0", Slot = "6")]
		get
		{
			return default(ControllerType);
		}
	}

	[Token(Token = "0x6005893")]
	[Address(RVA = "0x9F89E0", Offset = "0x9F7BE0", VA = "0x1809F89E0")]
	public bool LoadCheckResource(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6005894")]
	[Address(RVA = "0x9F8840", Offset = "0x9F7A40", VA = "0x1809F8840")]
	public bool IsDonePlay(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6005895")]
	[Address(RVA = "0x9F9640", Offset = "0x9F8840", VA = "0x1809F9640")]
	public PreviewPrefabController(DuelPreviewPlayer.Option option, PreviewResourceController resourceController, PreviewCameraController cameraController)
	{
	}

	[Token(Token = "0x6005896")]
	[Address(RVA = "0x9F83C0", Offset = "0x9F75C0", VA = "0x1809F83C0", Slot = "4")]
	public void BindGob(params GameObject[] gobs)
	{
	}

	[Token(Token = "0x6005897")]
	[Address(RVA = "0x9F9620", Offset = "0x9F8820", VA = "0x1809F9620", Slot = "5")]
	public void UnbindGob()
	{
	}

	[Token(Token = "0x6005898")]
	[Address(RVA = "0x9F9710", Offset = "0x9F8910", VA = "0x1809F9710", Slot = "7")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__14))]
	public IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x6005899")]
	[Address(RVA = "0x9F9440", Offset = "0x9F8640", VA = "0x1809F9440", Slot = "8")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600589A")]
	[Address(RVA = "0x9F8C90", Offset = "0x9F7E90", VA = "0x1809F8C90", Slot = "9")]
	public void Release()
	{
	}

	[Token(Token = "0x600589B")]
	[Address(RVA = "0x9F8CA0", Offset = "0x9F7EA0", VA = "0x1809F8CA0")]
	public void ResistModes(List<object> resistMods)
	{
	}

	[Token(Token = "0x600589C")]
	[Address(RVA = "0x9F8EE0", Offset = "0x9F80E0", VA = "0x1809F8EE0")]
	public GameObject Spawn(string path, string label, Vector3 worldPos, Vector3 rotation, Vector3 localScale)
	{
		return null;
	}

	[Token(Token = "0x600589D")]
	[Address(RVA = "0x9F8290", Offset = "0x9F7490", VA = "0x1809F8290")]
	public void Assign(string label, GameObject assignObj, bool withSetParent = false)
	{
	}

	[Token(Token = "0x600589E")]
	[Address(RVA = "0x9F8050", Offset = "0x9F7250", VA = "0x1809F8050")]
	private void ApplyMod(string label, GameObject target)
	{
	}

	[Token(Token = "0x600589F")]
	[Address(RVA = "0x9F8A40", Offset = "0x9F7C40", VA = "0x1809F8A40")]
	public void OnDonePlay(string label)
	{
	}

	[Token(Token = "0x60058A0")]
	[Address(RVA = "0x9F84D0", Offset = "0x9F76D0", VA = "0x1809F84D0")]
	public GameObject Find(string label, [Optional] string path)
	{
		return null;
	}

	[Token(Token = "0x60058A1")]
	public T Find<T>(string label) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60058A2")]
	[Address(RVA = "0x9F83F0", Offset = "0x9F75F0", VA = "0x1809F83F0")]
	public void Destroy(string label)
	{
	}

	[Token(Token = "0x60058A3")]
	[Address(RVA = "0x9F8BF0", Offset = "0x9F7DF0", VA = "0x1809F8BF0")]
	public void PlayTm(string label)
	{
	}

	[Token(Token = "0x60058A4")]
	[Address(RVA = "0x9F8470", Offset = "0x9F7670", VA = "0x1809F8470")]
	public LabeledPlayableController FindLabeledTm(string label)
	{
		return null;
	}

	[Token(Token = "0x60058A5")]
	[Address(RVA = "0x9F8AF0", Offset = "0x9F7CF0", VA = "0x1809F8AF0")]
	public void PlayTmLabel(string label, string tmLabel)
	{
	}

	[Token(Token = "0x60058A6")]
	[Address(RVA = "0x9F8750", Offset = "0x9F7950", VA = "0x1809F8750")]
	public void GoToEndTm(string label)
	{
	}

	[Token(Token = "0x60058A7")]
	[Address(RVA = "0x9F88B0", Offset = "0x9F7AB0", VA = "0x1809F88B0")]
	public bool IsPlayingTm(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x60058A8")]
	[Address(RVA = "0x9F8E80", Offset = "0x9F8080", VA = "0x1809F8E80")]
	private void SetupTm(LabeledPlayableController lpd)
	{
	}

	[Token(Token = "0x60058A9")]
	[Address(RVA = "0x9F8D10", Offset = "0x9F7F10", VA = "0x1809F8D10")]
	private void SetupTm(PlayableDirector pd)
	{
	}
}
