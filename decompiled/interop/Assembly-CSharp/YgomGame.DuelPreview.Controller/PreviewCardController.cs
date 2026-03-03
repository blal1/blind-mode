using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000E99")]
public class PreviewCardController : IPreviewPlayerControllerRequireGob, IPreviewPlayerController
{
	[Token(Token = "0x2000E9A")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A3C2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A3C3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000D89")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005837")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D8A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005839")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005834")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005835")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005836")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005838")]
		[Address(RVA = "0x9C7D90", Offset = "0x9C6F90", VA = "0x1809C7D90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A3BD")]
	private const string k_CardModelPath = "Duel/Models/CardModelWrapper";

	[Token(Token = "0x400A3BE")]
	[FieldOffset(Offset = "0x10")]
	private readonly PreviewResourceController m_ResourceController;

	[Token(Token = "0x400A3BF")]
	[FieldOffset(Offset = "0x18")]
	private readonly PreviewPrefabController m_PrefabController;

	[Token(Token = "0x400A3C0")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_CardRoot;

	[Token(Token = "0x400A3C1")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, (GameObject root, CardModel model)> m_CardMap;

	[Token(Token = "0x17000D88")]
	public ControllerType controllerType
	{
		[Token(Token = "0x600582A")]
		[Address(RVA = "0x443230", Offset = "0x442430", VA = "0x180443230", Slot = "6")]
		get
		{
			return default(ControllerType);
		}
	}

	[Token(Token = "0x600582B")]
	[Address(RVA = "0x9BFA70", Offset = "0x9BEC70", VA = "0x1809BFA70")]
	public (GameObject, CardModel) TryGetCard(string label)
	{
		return default((GameObject, CardModel));
	}

	[Token(Token = "0x600582C")]
	[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
	public PreviewCardController(PreviewResourceController resourceController, PreviewPrefabController prefabController)
	{
	}

	[Token(Token = "0x600582D")]
	[Address(RVA = "0x9BF5B0", Offset = "0x9BE7B0", VA = "0x1809BF5B0", Slot = "4")]
	public void BindGob(params GameObject[] gobs)
	{
	}

	[Token(Token = "0x600582E")]
	[Address(RVA = "0x615660", Offset = "0x614860", VA = "0x180615660", Slot = "5")]
	public void UnbindGob()
	{
	}

	[Token(Token = "0x600582F")]
	[Address(RVA = "0x9BFB50", Offset = "0x9BED50", VA = "0x1809BFB50", Slot = "7")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__11))]
	public IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x6005830")]
	[Address(RVA = "0x9BF8E0", Offset = "0x9BEAE0", VA = "0x1809BF8E0", Slot = "8")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6005831")]
	[Address(RVA = "0x9BF640", Offset = "0x9BE840", VA = "0x1809BF640", Slot = "9")]
	public void Release()
	{
	}

	[Token(Token = "0x6005832")]
	[Address(RVA = "0x9BF650", Offset = "0x9BE850", VA = "0x1809BF650")]
	public void SpawnCard(Action<GameObject, CardModel> onComplete, string label, int mrk = 0, int protector = 0, int premire = 0)
	{
	}

	[Token(Token = "0x6005833")]
	[Address(RVA = "0x9BF5E0", Offset = "0x9BE7E0", VA = "0x1809BF5E0")]
	public bool LoadCheckResource()
	{
		return default(bool);
	}
}
