using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001C8")]
public abstract class EventBase : IDisposable
{
	[Token(Token = "0x20001C9")]
	[Flags]
	internal enum EventPropagation
	{
		[Token(Token = "0x400082C")]
		None = 0,
		[Token(Token = "0x400082D")]
		Bubbles = 1,
		[Token(Token = "0x400082E")]
		TricklesDown = 2,
		[Token(Token = "0x400082F")]
		SkipDisabledElements = 4,
		[Token(Token = "0x4000830")]
		BubblesOrTricklesDown = 3
	}

	[Token(Token = "0x20001CA")]
	[Flags]
	private enum LifeCycleStatus
	{
		[Token(Token = "0x4000832")]
		None = 0,
		[Token(Token = "0x4000833")]
		PropagationStopped = 1,
		[Token(Token = "0x4000834")]
		ImmediatePropagationStopped = 2,
		[Token(Token = "0x4000835")]
		Dispatching = 4,
		[Token(Token = "0x4000836")]
		Pooled = 8,
		[Token(Token = "0x4000837")]
		IMGUIEventIsValid = 0x10,
		[Token(Token = "0x4000838")]
		PropagateToIMGUI = 0x20,
		[Token(Token = "0x4000839")]
		Dispatched = 0x40,
		[Token(Token = "0x400083A")]
		Processed = 0x80,
		[Token(Token = "0x400083B")]
		ProcessedByFocusController = 0x100
	}

	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x0")]
	private static long s_LastTypeId;

	[Token(Token = "0x4000820")]
	[FieldOffset(Offset = "0x8")]
	private static ulong s_NextEventId;

	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x48")]
	private IEventHandler m_CurrentTarget;

	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x50")]
	private Event m_ImguiEvent;

	[Token(Token = "0x17000248")]
	public virtual long eventTypeId
	{
		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0x1E84F80", Offset = "0x1E84180", VA = "0x181E84F80", Slot = "5")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000249")]
	internal int eventCategories
	{
		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700024A")]
	public long timestamp
	{
		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x178F430", Offset = "0x178E630", VA = "0x18178F430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700024B")]
	internal ulong eventId
	{
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x7320F0", Offset = "0x7312F0", VA = "0x1807320F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700024C")]
	private ulong triggerEventId
	{
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x980A50", Offset = "0x97FC50", VA = "0x180980A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700024D")]
	internal EventPropagation propagation
	{
		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		[CompilerGenerated]
		get
		{
			return default(EventPropagation);
		}
		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700024E")]
	private LifeCycleStatus lifeCycleStatus
	{
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0")]
		[CompilerGenerated]
		get
		{
			return default(LifeCycleStatus);
		}
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x9941B0", Offset = "0x9933B0", VA = "0x1809941B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700024F")]
	public bool bubbles
	{
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x2B11CB0", Offset = "0x2B10EB0", VA = "0x182B11CB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x1FA79E0", Offset = "0x1FA6BE0", VA = "0x181FA79E0")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000250")]
	public bool tricklesDown
	{
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x2B11D90", Offset = "0x2B10F90", VA = "0x182B11D90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0x1FA79C0", Offset = "0x1FA6BC0", VA = "0x181FA79C0")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000251")]
	internal bool skipDisabledElements
	{
		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x2B11D80", Offset = "0x2B10F80", VA = "0x182B11D80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x2B120D0", Offset = "0x2B112D0", VA = "0x182B120D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000252")]
	internal bool bubblesOrTricklesDown
	{
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x2B11CA0", Offset = "0x2B10EA0", VA = "0x182B11CA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000253")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal VisualElement elementTarget
	{
		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000254")]
	public IEventHandler target
	{
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x2B120F0", Offset = "0x2B112F0", VA = "0x182B120F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000255")]
	public bool isPropagationStopped
	{
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x2B11D10", Offset = "0x2B10F10", VA = "0x182B11D10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x2B12030", Offset = "0x2B11230", VA = "0x182B12030")]
		private set
		{
		}
	}

	[Token(Token = "0x17000256")]
	public bool isImmediatePropagationStopped
	{
		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x2B11D00", Offset = "0x2B10F00", VA = "0x182B11D00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x2B12010", Offset = "0x2B11210", VA = "0x182B12010")]
		private set
		{
		}
	}

	[Token(Token = "0x17000257")]
	internal PropagationPhase propagationPhase
	{
		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x409CD0", Offset = "0x408ED0", VA = "0x180409CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000258")]
	public virtual IEventHandler currentTarget
	{
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x287DC00", Offset = "0x287CE00", VA = "0x18287DC00", Slot = "11")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x2B11DA0", Offset = "0x2B10FA0", VA = "0x182B11DA0", Slot = "12")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000259")]
	public bool dispatch
	{
		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x2B11CC0", Offset = "0x2B10EC0", VA = "0x182B11CC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0x2B11EE0", Offset = "0x2B110E0", VA = "0x182B11EE0")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700025A")]
	private bool dispatched
	{
		[Token(Token = "0x6000D11")]
		[Address(RVA = "0x2B11CD0", Offset = "0x2B10ED0", VA = "0x182B11CD0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x2B11F00", Offset = "0x2B11100", VA = "0x182B11F00")]
		set
		{
		}
	}

	[Token(Token = "0x1700025B")]
	internal bool processed
	{
		[Token(Token = "0x6000D13")]
		[Address(RVA = "0x2B11D60", Offset = "0x2B10F60", VA = "0x182B11D60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x2B12090", Offset = "0x2B11290", VA = "0x182B12090")]
		private set
		{
		}
	}

	[Token(Token = "0x1700025C")]
	internal bool processedByFocusController
	{
		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x2B11D50", Offset = "0x2B10F50", VA = "0x182B11D50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x2B12070", Offset = "0x2B11270", VA = "0x182B12070")]
		set
		{
		}
	}

	[Token(Token = "0x1700025D")]
	internal bool propagateToIMGUI
	{
		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x2B11D70", Offset = "0x2B10F70", VA = "0x182B11D70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x2B120B0", Offset = "0x2B112B0", VA = "0x182B120B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700025E")]
	private bool imguiEventIsValid
	{
		[Token(Token = "0x6000D19")]
		[Address(RVA = "0x2B11CE0", Offset = "0x2B10EE0", VA = "0x182B11CE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x2B11F20", Offset = "0x2B11120", VA = "0x182B11F20")]
		set
		{
		}
	}

	[Token(Token = "0x1700025F")]
	public Event imguiEvent
	{
		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x2B11CF0", Offset = "0x2B10EF0", VA = "0x182B11CF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x2B11F40", Offset = "0x2B11140", VA = "0x182B11F40")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000260")]
	public Vector2 originalMousePosition
	{
		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x2B11D20", Offset = "0x2B10F20", VA = "0x182B11D20")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0xA352F0", Offset = "0xA344F0", VA = "0x180A352F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000261")]
	protected bool pooled
	{
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x2B11D40", Offset = "0x2B10F40", VA = "0x182B11D40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x2B12050", Offset = "0x2B11250", VA = "0x182B12050")]
		set
		{
		}
	}

	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0x2B11BA0", Offset = "0x2B10DA0", VA = "0x182B11BA0")]
	protected static long RegisterEventType()
	{
		return default(long);
	}

	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x980A50", Offset = "0x97FC50", VA = "0x180980A50")]
	internal void SetTriggerEventId(ulong id)
	{
	}

	[Token(Token = "0x6000CF5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	[Obsolete("Override PreDispatch(IPanel panel) instead.")]
	protected virtual void PreDispatch()
	{
	}

	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0x202F990", Offset = "0x202EB90", VA = "0x18202F990", Slot = "7")]
	protected internal virtual void PreDispatch(IPanel panel)
	{
	}

	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	[Obsolete("Override PostDispatch(IPanel panel) instead.")]
	protected virtual void PostDispatch()
	{
	}

	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x2B11B70", Offset = "0x2B10D70", VA = "0x182B11B70", Slot = "9")]
	protected internal virtual void PostDispatch(IPanel panel)
	{
	}

	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x2B11980", Offset = "0x2B10B80", VA = "0x182B11980", Slot = "10")]
	internal virtual void Dispatch([NotNull] BaseVisualElementPanel panel)
	{
	}

	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x2B11C00", Offset = "0x2B10E00", VA = "0x182B11C00")]
	public void StopPropagation()
	{
	}

	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x2B11BF0", Offset = "0x2B10DF0", VA = "0x182B11BF0")]
	public void StopImmediatePropagation()
	{
	}

	[Token(Token = "0x6000D10")]
	[Address(RVA = "0x2B11AF0", Offset = "0x2B10CF0", VA = "0x182B11AF0")]
	internal void MarkReceivedByDispatcher()
	{
	}

	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x2B119D0", Offset = "0x2B10BD0", VA = "0x182B119D0", Slot = "13")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x6000D20")]
	[Address(RVA = "0x2B119E0", Offset = "0x2B10BE0", VA = "0x182B119E0")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x2B11C60", Offset = "0x2B10E60", VA = "0x182B11C60")]
	protected EventBase()
	{
	}

	[Token(Token = "0x6000D22")]
	[Address(RVA = "0x2B11C10", Offset = "0x2B10E10", VA = "0x182B11C10")]
	internal EventBase(EventCategory category)
	{
	}

	[Token(Token = "0x6000D25")]
	internal abstract void Acquire();

	[Token(Token = "0x6000D26")]
	public abstract void Dispose();
}
[Token(Token = "0x20001CB")]
[EventCategory(EventCategory.Default)]
public abstract class EventBase<T> : EventBase where T : EventBase<T>, new()
{
	[Token(Token = "0x400083C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly long s_TypeId;

	[Token(Token = "0x400083D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ObjectPool<T> s_Pool;

	[Token(Token = "0x400083E")]
	[FieldOffset(Offset = "0x0")]
	private int m_RefCount;

	[Token(Token = "0x400083F")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly EventCategory EventCategory;

	[Token(Token = "0x17000262")]
	public override long eventTypeId
	{
		[Token(Token = "0x6000D30")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x6000D27")]
	internal static void SetCreateFunction(Func<T> createMethod)
	{
	}

	[Token(Token = "0x6000D28")]
	protected EventBase()
	{
	}

	[Token(Token = "0x6000D29")]
	public static long TypeId()
	{
		return default(long);
	}

	[Token(Token = "0x6000D2A")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000D2B")]
	public static T GetPooled()
	{
		return null;
	}

	[Token(Token = "0x6000D2C")]
	internal static T GetPooled(EventBase e)
	{
		return null;
	}

	[Token(Token = "0x6000D2D")]
	private static void ReleasePooled(T evt)
	{
	}

	[Token(Token = "0x6000D2E")]
	internal override void Acquire()
	{
	}

	[Token(Token = "0x6000D2F")]
	public sealed override void Dispose()
	{
	}
}
