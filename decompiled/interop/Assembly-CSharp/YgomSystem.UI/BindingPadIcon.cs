using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.Utility;

namespace YgomSystem.UI;

[Token(Token = "0x200051D")]
[RequireComponent(typeof(Image))]
[AddComponentMenu("Ygom/UI/Binding/BindingPadIcon")]
public class BindingPadIcon : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x200051E")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		[Token(Token = "0x4001911")]
		[FieldOffset(Offset = "0x10")]
		public BindingPadIcon _003C_003E4__this;

		[Token(Token = "0x4001912")]
		[FieldOffset(Offset = "0x18")]
		public bool iconLoadFinished;

		[Token(Token = "0x4001913")]
		[FieldOffset(Offset = "0x20")]
		public Sprite iconSprite;

		[Token(Token = "0x6002133")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass34_0()
		{
		}

		[Token(Token = "0x6002134")]
		[Address(RVA = "0x6464F0", Offset = "0x6456F0", VA = "0x1806464F0")]
		internal void _003CySequence_003Eb__0(Sprite sprite)
		{
		}

		[Token(Token = "0x6002135")]
		[Address(RVA = "0x646570", Offset = "0x645770", VA = "0x180646570")]
		internal void _003CySequence_003Eb__1(Sprite sprite)
		{
		}

		[Token(Token = "0x6002136")]
		[Address(RVA = "0x6465F0", Offset = "0x6457F0", VA = "0x1806465F0")]
		internal void _003CySequence_003Eb__2(Sprite sprite)
		{
		}
	}

	[Token(Token = "0x200051F")]
	[CompilerGenerated]
	private sealed class _003CySequence_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001914")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001915")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001916")]
		[FieldOffset(Offset = "0x20")]
		public BindingPadIcon _003C_003E4__this;

		[Token(Token = "0x4001917")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

		[Token(Token = "0x17000361")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600213A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000362")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600213C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002137")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySequence_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002138")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002139")]
		[Address(RVA = "0x646FD0", Offset = "0x6461D0", VA = "0x180646FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600213B")]
		[Address(RVA = "0x6473B0", Offset = "0x6465B0", VA = "0x1806473B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001909")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ShortcutIcon.Mode m_Mode;

	[Token(Token = "0x400190A")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private SelectorManager.KeyType m_KeyType;

	[Token(Token = "0x400190B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SelectorManager.AnalogType m_AnalogType;

	[Token(Token = "0x400190C")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private ShortcutIcon.AnalogDirection m_AnalogDirection;

	[Token(Token = "0x400190D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SelectorManager.MouseType m_MouseType;

	[Token(Token = "0x400190E")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private GamePadIconUtil.Variation m_IconVariation;

	[Token(Token = "0x400190F")]
	[FieldOffset(Offset = "0x38")]
	private IEnumerator m_SequenceRoutine;

	[Token(Token = "0x1700035A")]
	public ShortcutIcon.Mode mode
	{
		[Token(Token = "0x600211C")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(ShortcutIcon.Mode);
		}
		[Token(Token = "0x600211D")]
		[Address(RVA = "0x6334B0", Offset = "0x6326B0", VA = "0x1806334B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700035B")]
	public SelectorManager.KeyType keyType
	{
		[Token(Token = "0x600211E")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		get
		{
			return default(SelectorManager.KeyType);
		}
		[Token(Token = "0x600211F")]
		[Address(RVA = "0x6334A0", Offset = "0x6326A0", VA = "0x1806334A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700035C")]
	public SelectorManager.AnalogType analogType
	{
		[Token(Token = "0x6002120")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		get
		{
			return default(SelectorManager.AnalogType);
		}
		[Token(Token = "0x6002121")]
		[Address(RVA = "0x633480", Offset = "0x632680", VA = "0x180633480")]
		set
		{
		}
	}

	[Token(Token = "0x1700035D")]
	public ShortcutIcon.AnalogDirection analogDirection
	{
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0")]
		get
		{
			return default(ShortcutIcon.AnalogDirection);
		}
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x633470", Offset = "0x632670", VA = "0x180633470")]
		set
		{
		}
	}

	[Token(Token = "0x1700035E")]
	public SelectorManager.MouseType mouseType
	{
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		get
		{
			return default(SelectorManager.MouseType);
		}
		[Token(Token = "0x6002125")]
		[Address(RVA = "0x6334C0", Offset = "0x6326C0", VA = "0x1806334C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700035F")]
	public GamePadIconUtil.Variation iconVariation
	{
		[Token(Token = "0x6002126")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0")]
		get
		{
			return default(GamePadIconUtil.Variation);
		}
		[Token(Token = "0x6002127")]
		[Address(RVA = "0x633490", Offset = "0x632690", VA = "0x180633490")]
		set
		{
		}
	}

	[Token(Token = "0x17000360")]
	public bool visible
	{
		[Token(Token = "0x6002128")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400002D")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6002129")]
		[Address(RVA = "0x633310", Offset = "0x632510", VA = "0x180633310", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600212A")]
		[Address(RVA = "0x6333D0", Offset = "0x6325D0", VA = "0x1806333D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600212B")]
	[Address(RVA = "0x633090", Offset = "0x632290", VA = "0x180633090", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600212C")]
	[Address(RVA = "0x633010", Offset = "0x632210", VA = "0x180633010")]
	public static BindingPadIcon BindingAsKey(GameObject target, SelectorManager.KeyType keyType, GamePadIconUtil.Variation iconVariation = GamePadIconUtil.Variation.Var00)
	{
		return null;
	}

	[Token(Token = "0x600212D")]
	[Address(RVA = "0x633300", Offset = "0x632500", VA = "0x180633300")]
	private void Update()
	{
	}

	[Token(Token = "0x600212E")]
	[Address(RVA = "0x6330E0", Offset = "0x6322E0", VA = "0x1806330E0", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x600212F")]
	[Address(RVA = "0x6334D0", Offset = "0x6326D0", VA = "0x1806334D0")]
	[IteratorStateMachine(typeof(_003CySequence_003Ed__34))]
	private IEnumerator ySequence()
	{
		return null;
	}

	[Token(Token = "0x6002130")]
	[Address(RVA = "0x6331D0", Offset = "0x6323D0", VA = "0x1806331D0")]
	private void SourceChange()
	{
	}

	[Token(Token = "0x6002131")]
	[Address(RVA = "0x6330B0", Offset = "0x6322B0", VA = "0x1806330B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002132")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public BindingPadIcon()
	{
	}
}
