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

[Token(Token = "0x200144D")]
public class BindingProfileFrameIcon : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x200144E")]
	[CompilerGenerated]
	private sealed class _003CyBindingRoutine_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C642")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C643")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C644")]
		[FieldOffset(Offset = "0x20")]
		public BindingProfileFrameIcon _003C_003E4__this;

		[Token(Token = "0x400C645")]
		[FieldOffset(Offset = "0x28")]
		public int baseId;

		[Token(Token = "0x400C646")]
		[FieldOffset(Offset = "0x2C")]
		public bool isLarge;

		[Token(Token = "0x400C647")]
		[FieldOffset(Offset = "0x30")]
		public int frameId;

		[Token(Token = "0x400C648")]
		[FieldOffset(Offset = "0x34")]
		public bool async;

		[Token(Token = "0x400C649")]
		[FieldOffset(Offset = "0x38")]
		private string _003CbaseSpritePath_003E5__2;

		[Token(Token = "0x400C64A")]
		[FieldOffset(Offset = "0x40")]
		private string _003CframeSpritePath_003E5__3;

		[Token(Token = "0x400C64B")]
		[FieldOffset(Offset = "0x48")]
		private string _003CframeMatPath_003E5__4;

		[Token(Token = "0x1700137C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007E85")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700137D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007E87")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007E82")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingRoutine_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007E83")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007E84")]
		[Address(RVA = "0xC81B20", Offset = "0xC80D20", VA = "0x180C81B20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007E86")]
		[Address(RVA = "0xC82470", Offset = "0xC81670", VA = "0x180C82470", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C636")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_MatLabelFrameTex;

	[Token(Token = "0x400C637")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int m_BaseId;

	[Token(Token = "0x400C638")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int m_FrameId;

	[Token(Token = "0x400C639")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool m_IsLarge;

	[Token(Token = "0x400C63A")]
	[FieldOffset(Offset = "0x31")]
	private bool m_Async;

	[Token(Token = "0x400C63B")]
	[FieldOffset(Offset = "0x34")]
	private uint m_BaseSpriteCrc;

	[Token(Token = "0x400C63C")]
	[FieldOffset(Offset = "0x38")]
	private uint m_FrameSpriteCrc;

	[Token(Token = "0x400C63D")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_FrameMatCrc;

	[Token(Token = "0x400C63E")]
	[FieldOffset(Offset = "0x40")]
	private Image m_ImageCache;

	[Token(Token = "0x400C63F")]
	[FieldOffset(Offset = "0x48")]
	private Material m_ModiedMaterial;

	[Token(Token = "0x400C640")]
	[FieldOffset(Offset = "0x50")]
	private IEnumerator m_BindingRoutine;

	[Token(Token = "0x17001377")]
	public int baseId
	{
		[Token(Token = "0x6007E6A")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007E6B")]
		[Address(RVA = "0xC6E050", Offset = "0xC6D250", VA = "0x180C6E050")]
		set
		{
		}
	}

	[Token(Token = "0x17001378")]
	public int frameId
	{
		[Token(Token = "0x6007E6C")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007E6D")]
		[Address(RVA = "0xC6E060", Offset = "0xC6D260", VA = "0x180C6E060")]
		set
		{
		}
	}

	[Token(Token = "0x17001379")]
	public bool isLarge
	{
		[Token(Token = "0x6007E6E")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007E6F")]
		[Address(RVA = "0xC6E070", Offset = "0xC6D270", VA = "0x180C6E070")]
		set
		{
		}
	}

	[Token(Token = "0x1700137A")]
	private Image image
	{
		[Token(Token = "0x6007E70")]
		[Address(RVA = "0xC6DF10", Offset = "0xC6D110", VA = "0x180C6DF10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700137B")]
	public bool visible
	{
		[Token(Token = "0x6007E71")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x140000A1")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6007E72")]
		[Address(RVA = "0xC6DE70", Offset = "0xC6D070", VA = "0x180C6DE70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007E73")]
		[Address(RVA = "0xC6DFB0", Offset = "0xC6D1B0", VA = "0x180C6DFB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007E74")]
	[Address(RVA = "0xC6DA70", Offset = "0xC6CC70", VA = "0x180C6DA70", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007E75")]
	[Address(RVA = "0xC6D970", Offset = "0xC6CB70", VA = "0x180C6D970")]
	public static BindingProfileFrameIcon Binding(Image target, int baseId = 0, int frameId = 0, bool isLarge = false, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007E76")]
	[Address(RVA = "0xC6D9D0", Offset = "0xC6CBD0", VA = "0x180C6D9D0")]
	public static BindingProfileFrameIcon Binding(GameObject target, int baseId, int frameId, bool isLarge = false, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007E77")]
	[Address(RVA = "0xC6D810", Offset = "0xC6CA10", VA = "0x180C6D810")]
	public static BindingProfileFrameIcon BindingBase(Image target, int baseId, bool isLarge = false, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007E78")]
	[Address(RVA = "0xC6D770", Offset = "0xC6C970", VA = "0x180C6D770")]
	public static BindingProfileFrameIcon BindingBase(GameObject target, int baseId, bool isLarge = false, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007E79")]
	[Address(RVA = "0xC6D870", Offset = "0xC6CA70", VA = "0x180C6D870")]
	public static BindingProfileFrameIcon BindingFrame(Image target, int frameId, bool isLarge = false, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007E7A")]
	[Address(RVA = "0xC6D8D0", Offset = "0xC6CAD0", VA = "0x180C6D8D0")]
	public static BindingProfileFrameIcon BindingFrame(GameObject target, int frameId, bool isLarge = false, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007E7B")]
	[Address(RVA = "0xC6D6E0", Offset = "0xC6C8E0", VA = "0x180C6D6E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007E7C")]
	[Address(RVA = "0xC6DD40", Offset = "0xC6CF40", VA = "0x180C6DD40")]
	public void SourceChanged()
	{
	}

	[Token(Token = "0x6007E7D")]
	[Address(RVA = "0xC6DE00", Offset = "0xC6D000", VA = "0x180C6DE00")]
	private void Update()
	{
	}

	[Token(Token = "0x6007E7E")]
	[Address(RVA = "0xC6DC00", Offset = "0xC6CE00", VA = "0x180C6DC00", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007E7F")]
	[Address(RVA = "0xC6E080", Offset = "0xC6D280", VA = "0x180C6E080")]
	[IteratorStateMachine(typeof(_003CyBindingRoutine_003Ed__38))]
	private IEnumerator yBindingRoutine(int baseId, int frameId, bool isLarge, bool async)
	{
		return null;
	}

	[Token(Token = "0x6007E80")]
	[Address(RVA = "0xC6DAA0", Offset = "0xC6CCA0", VA = "0x180C6DAA0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007E81")]
	[Address(RVA = "0xC6DE10", Offset = "0xC6D010", VA = "0x180C6DE10")]
	public BindingProfileFrameIcon()
	{
	}
}
