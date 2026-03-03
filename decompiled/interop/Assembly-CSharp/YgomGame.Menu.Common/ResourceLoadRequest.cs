using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x20014A0")]
public class ResourceLoadRequest : MonoBehaviour, IAsyncProgressContent
{
	[Token(Token = "0x20014A1")]
	[CompilerGenerated]
	private sealed class _003CyLoad_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ResourceLoadRequest _003C_003E4__this;

		[Token(Token = "0x1700139C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007FFE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700139D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008000")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007FFB")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyLoad_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007FFC")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007FFD")]
		[Address(RVA = "0xC824B0", Offset = "0xC816B0", VA = "0x180C824B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007FFF")]
		[Address(RVA = "0xC82700", Offset = "0xC81900", VA = "0x180C82700", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C71F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string m_Path;

	[Token(Token = "0x400C720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string m_AssetContainerLabel;

	[Token(Token = "0x400C721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool m_Immediate;

	[Token(Token = "0x400C722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool m_Hold;

	[Token(Token = "0x400C723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	private bool m_DisabledErrorNotify;

	[Token(Token = "0x400C724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private uint m_Crc;

	[Token(Token = "0x400C725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private IEnumerator m_Loadroutine;

	[Token(Token = "0x400C726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Action<ResourceLoadRequest> m_OnFinishCallback;

	[Token(Token = "0x1700139A")]
	public bool isExistsAssetContainerLabel
	{
		[Token(Token = "0x6007FEE")]
		[Address(RVA = "0x866DC0", Offset = "0x865FC0", VA = "0x180866DC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700139B")]
	public bool isValidAsset
	{
		[Token(Token = "0x6007FEF")]
		[Address(RVA = "0xC7DCC0", Offset = "0xC7CEC0", VA = "0x180C7DCC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007FF0")]
	[Address(RVA = "0xC7DC20", Offset = "0xC7CE20", VA = "0x180C7DC20", Slot = "4")]
	private bool YgomGame_002EMenu_002ECommon_002EIAsyncProgressContent_002EIsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007FF1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	private void YgomGame_002EMenu_002ECommon_002EIAsyncProgressContent_002EProgressUpdate()
	{
	}

	[Token(Token = "0x6007FF2")]
	[Address(RVA = "0xC7D240", Offset = "0xC7C440", VA = "0x180C7D240")]
	public Type CheckResourceType(params Type[] checkTypes)
	{
		return null;
	}

	[Token(Token = "0x6007FF3")]
	[Address(RVA = "0xC7D6E0", Offset = "0xC7C8E0", VA = "0x180C7D6E0")]
	public bool TryGetAssetSize(out Vector2 size)
	{
		return default(bool);
	}

	[Token(Token = "0x6007FF4")]
	[Address(RVA = "0xC7D380", Offset = "0xC7C580", VA = "0x180C7D380")]
	public static void Load(GameObject owner, string resourcePath, bool async = true, [Optional] Action<ResourceLoadRequest> onFinishCallback, bool hold = false, bool disabledErrorNotify = false)
	{
	}

	[Token(Token = "0x6007FF5")]
	[Address(RVA = "0xC7D550", Offset = "0xC7C750", VA = "0x180C7D550")]
	private void Load()
	{
	}

	[Token(Token = "0x6007FF6")]
	[Address(RVA = "0xC7DD70", Offset = "0xC7CF70", VA = "0x180C7DD70")]
	[IteratorStateMachine(typeof(_003CyLoad_003Ed__18))]
	private IEnumerator yLoad()
	{
		return null;
	}

	[Token(Token = "0x6007FF7")]
	[Address(RVA = "0xC7D630", Offset = "0xC7C830", VA = "0x180C7D630")]
	private void OnFinish()
	{
	}

	[Token(Token = "0x6007FF8")]
	[Address(RVA = "0xC7D5D0", Offset = "0xC7C7D0", VA = "0x180C7D5D0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007FF9")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ResourceLoadRequest()
	{
	}
}
