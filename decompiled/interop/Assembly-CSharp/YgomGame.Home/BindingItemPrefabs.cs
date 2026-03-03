using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomGame.Home;

[Token(Token = "0x2000D3D")]
public class BindingItemPrefabs : MonoBehaviour, IAsyncProgressContainer, ILoadingIconHandler
{
	[Token(Token = "0x2000D3E")]
	private class bindConponentItem
	{
		[Token(Token = "0x4009E4A")]
		[FieldOffset(Offset = "0x10")]
		public string prefabPath;

		[Token(Token = "0x4009E4B")]
		[FieldOffset(Offset = "0x18")]
		public BindingItemPrefabsUtil.BindingItemPrefabType itemType;

		[Token(Token = "0x4009E4C")]
		[FieldOffset(Offset = "0x20")]
		public string paramKey;

		[Token(Token = "0x4009E4D")]
		[FieldOffset(Offset = "0x28")]
		public string paramValue;

		[Token(Token = "0x4009E4E")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, string> paramDict;

		[Token(Token = "0x600502E")]
		[Address(RVA = "0x97DA60", Offset = "0x97CC60", VA = "0x18097DA60")]
		public string BuildParam(bool flare = true)
		{
			return null;
		}

		[Token(Token = "0x600502F")]
		[Address(RVA = "0x97DBA0", Offset = "0x97CDA0", VA = "0x18097DBA0")]
		public bindConponentItem()
		{
		}
	}

	[Token(Token = "0x2000D40")]
	[CompilerGenerated]
	private sealed class _003CySequence_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009E54")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009E55")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009E56")]
		[FieldOffset(Offset = "0x20")]
		public BindingItemPrefabs _003C_003E4__this;

		[Token(Token = "0x4009E57")]
		[FieldOffset(Offset = "0x28")]
		private bool _003Cflare_003E5__2;

		[Token(Token = "0x4009E58")]
		[FieldOffset(Offset = "0x30")]
		private List<uint> _003CcrcList_003E5__3;

		[Token(Token = "0x4009E59")]
		[FieldOffset(Offset = "0x38")]
		private List<IAsyncProgressContent> _003CasyncContents_003E5__4;

		[Token(Token = "0x17000B8D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005039")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B8E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600503B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005036")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySequence_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005037")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005038")]
		[Address(RVA = "0x97C110", Offset = "0x97B310", VA = "0x18097C110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600503A")]
		[Address(RVA = "0x97D290", Offset = "0x97C490", VA = "0x18097D290", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009E41")]
	[FieldOffset(Offset = "0x20")]
	private List<IAsyncProgressContent> m_AsyncProgressContents;

	[Token(Token = "0x4009E42")]
	private const string prefPathBase = "Prefabs/Notification/Topics/Prefabs/";

	[Token(Token = "0x4009E43")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_Path;

	[Token(Token = "0x4009E44")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private BindingGameObjectEx.FitMode m_PrefabFitMode;

	[Token(Token = "0x4009E45")]
	[FieldOffset(Offset = "0x34")]
	private uint m_Crc;

	[Token(Token = "0x4009E46")]
	[FieldOffset(Offset = "0x38")]
	private Action<BindingItemPrefabs> m_HandleOnFailedCallback;

	[Token(Token = "0x4009E48")]
	[FieldOffset(Offset = "0x48")]
	private IEnumerator m_SequenceRoutine;

	[Token(Token = "0x4009E49")]
	[FieldOffset(Offset = "0x50")]
	private List<bindConponentItem> bindConponentItems;

	[Token(Token = "0x17000B89")]
	public IReadOnlyList<IAsyncProgressContent> asyncProgressContents
	{
		[Token(Token = "0x6005020")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B8A")]
	public bool handleOnFailed
	{
		[Token(Token = "0x6005023")]
		[Address(RVA = "0x965B60", Offset = "0x964D60", VA = "0x180965B60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000B8B")]
	public Action<BindingItemPrefabs> handleOnFailedCallback
	{
		[Token(Token = "0x6005024")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		set
		{
		}
	}

	[Token(Token = "0x17000B8C")]
	public bool visible
	{
		[Token(Token = "0x6005027")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000073")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6005025")]
		[Address(RVA = "0x965AC0", Offset = "0x964CC0", VA = "0x180965AC0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005026")]
		[Address(RVA = "0x965B70", Offset = "0x964D70", VA = "0x180965B70", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6005021")]
	[Address(RVA = "0x9654F0", Offset = "0x9646F0", VA = "0x1809654F0")]
	private void ClearProgressContent()
	{
	}

	[Token(Token = "0x6005022")]
	[Address(RVA = "0x965410", Offset = "0x964610", VA = "0x180965410")]
	private void AssignProgressContent(IAsyncProgressContent progressContent)
	{
	}

	[Token(Token = "0x6005028")]
	[Address(RVA = "0x965550", Offset = "0x964750", VA = "0x180965550", Slot = "6")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6005029")]
	[Address(RVA = "0x965A30", Offset = "0x964C30", VA = "0x180965A30")]
	private void Update()
	{
	}

	[Token(Token = "0x600502A")]
	[Address(RVA = "0x965570", Offset = "0x964770", VA = "0x180965570")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x600502B")]
	[Address(RVA = "0x965C10", Offset = "0x964E10", VA = "0x180965C10")]
	[IteratorStateMachine(typeof(_003CySequence_003Ed__25))]
	private IEnumerator ySequence()
	{
		return null;
	}

	[Token(Token = "0x600502C")]
	[Address(RVA = "0x965660", Offset = "0x964860", VA = "0x180965660")]
	private void SwitchTargetActivate(bool isPref)
	{
	}

	[Token(Token = "0x600502D")]
	[Address(RVA = "0x965A40", Offset = "0x964C40", VA = "0x180965A40")]
	public BindingItemPrefabs()
	{
	}
}
