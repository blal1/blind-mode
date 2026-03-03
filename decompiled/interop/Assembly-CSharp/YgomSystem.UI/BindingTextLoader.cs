using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu.Common;

namespace YgomSystem.UI;

[Token(Token = "0x2000523")]
[AddComponentMenu("Ygom/UI/Binding/Binding TextLoader")]
public class BindingTextLoader : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x2000524")]
	[CompilerGenerated]
	private sealed class _003CyRoutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001925")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001926")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001927")]
		[FieldOffset(Offset = "0x20")]
		public BindingTextLoader _003C_003E4__this;

		[Token(Token = "0x4001928")]
		[FieldOffset(Offset = "0x28")]
		private List<string>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x4001929")]
		[FieldOffset(Offset = "0x40")]
		private string _003CloadTextGroup_003E5__3;

		[Token(Token = "0x17000369")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600216C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600216E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002168")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyRoutine_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002169")]
		[Address(RVA = "0x646EF0", Offset = "0x6460F0", VA = "0x180646EF0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600216A")]
		[Address(RVA = "0x646900", Offset = "0x645B00", VA = "0x180646900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600216B")]
		[Address(RVA = "0x646F80", Offset = "0x646180", VA = "0x180646F80")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x600216D")]
		[Address(RVA = "0x646EB0", Offset = "0x6460B0", VA = "0x180646EB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001921")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Binding[] m_BindingTexts;

	[Token(Token = "0x4001922")]
	[FieldOffset(Offset = "0x28")]
	private List<string> m_LoadTextGroups;

	[Token(Token = "0x4001923")]
	[FieldOffset(Offset = "0x30")]
	private IEnumerator m_Routine;

	[Token(Token = "0x17000368")]
	public bool visible
	{
		[Token(Token = "0x600215A")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400002E")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x600215B")]
		[Address(RVA = "0x634220", Offset = "0x633420", VA = "0x180634220", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600215C")]
		[Address(RVA = "0x6342C0", Offset = "0x6334C0", VA = "0x1806342C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600215D")]
	[Address(RVA = "0x633F50", Offset = "0x633150", VA = "0x180633F50", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600215E")]
	[Address(RVA = "0x633B40", Offset = "0x632D40", VA = "0x180633B40")]
	private void Awake()
	{
	}

	[Token(Token = "0x600215F")]
	[Address(RVA = "0x634190", Offset = "0x633390", VA = "0x180634190")]
	private void Update()
	{
	}

	[Token(Token = "0x6002160")]
	[Address(RVA = "0x6340A0", Offset = "0x6332A0", VA = "0x1806340A0", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6002161")]
	[Address(RVA = "0x634360", Offset = "0x633560", VA = "0x180634360")]
	[IteratorStateMachine(typeof(_003CyRoutine_003Ed__12))]
	private IEnumerator yRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002162")]
	[Address(RVA = "0x633C30", Offset = "0x632E30", VA = "0x180633C30")]
	private string GetGroupId(Binding target)
	{
		return null;
	}

	[Token(Token = "0x6002163")]
	[Address(RVA = "0x633DE0", Offset = "0x632FE0", VA = "0x180633DE0")]
	private string GetGroupId(BindingTextMeshProUGUI target)
	{
		return null;
	}

	[Token(Token = "0x6002164")]
	[Address(RVA = "0x633E40", Offset = "0x633040", VA = "0x180633E40")]
	private string GetGroupId(BindingTextMeshPro target)
	{
		return null;
	}

	[Token(Token = "0x6002165")]
	[Address(RVA = "0x633EA0", Offset = "0x6330A0", VA = "0x180633EA0")]
	private string GetGruopId(Binding binding, string textId)
	{
		return null;
	}

	[Token(Token = "0x6002166")]
	[Address(RVA = "0x633F80", Offset = "0x633180", VA = "0x180633F80")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002167")]
	[Address(RVA = "0x6341A0", Offset = "0x6333A0", VA = "0x1806341A0")]
	public BindingTextLoader()
	{
	}
}
