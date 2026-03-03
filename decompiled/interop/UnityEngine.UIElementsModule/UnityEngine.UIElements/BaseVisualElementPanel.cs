using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.UIElements.Layout;

namespace UnityEngine.UIElements;

[Token(Token = "0x200028F")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal abstract class BaseVisualElementPanel : IPanel, IDisposable, IGroupBox
{
	[Token(Token = "0x4000A33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private UIElementsBridge m_UIElementsBridge;

	[Token(Token = "0x4000A34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_Scale;

	[Token(Token = "0x4000A35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal LayoutConfig layoutConfig;

	[Token(Token = "0x4000A36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float m_PixelsPerPoint;

	[Token(Token = "0x4000A39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	internal IPanelRenderer panelRenderer;

	[Token(Token = "0x4000A40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	internal ElementUnderPointer m_TopElementUnderPointers;

	[Token(Token = "0x4000A42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool m_IsFlat;

	[Token(Token = "0x4000A45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<IPanel> beforeUpdate;

	[Token(Token = "0x1700033D")]
	public abstract UnityEngine.EventInterests IMGUIEventInterests
	{
		[Token(Token = "0x600116B")]
		get;
		[Token(Token = "0x600116C")]
		set;
	}

	[Token(Token = "0x1700033E")]
	public abstract ScriptableObject ownerObject
	{
		[Token(Token = "0x600116D")]
		get;
		[Token(Token = "0x600116E")]
		protected set;
	}

	[Token(Token = "0x1700033F")]
	public abstract SavePersistentViewData saveViewData
	{
		[Token(Token = "0x600116F")]
		get;
	}

	[Token(Token = "0x17000340")]
	public abstract GetViewDataDictionary getViewDataDictionary
	{
		[Token(Token = "0x6001170")]
		get;
	}

	[Token(Token = "0x17000341")]
	public abstract int IMGUIContainersCount
	{
		[Token(Token = "0x6001171")]
		get;
		[Token(Token = "0x6001172")]
		set;
	}

	[Token(Token = "0x17000342")]
	public abstract FocusController focusController
	{
		[Token(Token = "0x6001173")]
		get;
		[Token(Token = "0x6001174")]
		set;
	}

	[Token(Token = "0x17000343")]
	public abstract IMGUIContainer rootIMGUIContainer
	{
		[Token(Token = "0x6001175")]
		get;
	}

	[Token(Token = "0x17000344")]
	internal UIElementsBridge uiElementsBridge
	{
		[Token(Token = "0x6001178")]
		[Address(RVA = "0x2B296E0", Offset = "0x2B288E0", VA = "0x182B296E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000345")]
	internal float scale
	{
		[Token(Token = "0x6001182")]
		[Address(RVA = "0x278B6A0", Offset = "0x278A8A0", VA = "0x18278B6A0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001183")]
		[Address(RVA = "0x2B29A70", Offset = "0x2B28C70", VA = "0x182B29A70")]
		set
		{
		}
	}

	[Token(Token = "0x17000346")]
	public float scaledPixelsPerPoint
	{
		[Token(Token = "0x6001184")]
		[Address(RVA = "0x2B296D0", Offset = "0x2B288D0", VA = "0x182B296D0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000347")]
	public float referenceSpritePixelsPerUnit
	{
		[Token(Token = "0x6001185")]
		[Address(RVA = "0x1FEBF60", Offset = "0x1FEB160", VA = "0x181FEBF60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001186")]
		[Address(RVA = "0x1FF41F0", Offset = "0x1FF33F0", VA = "0x181FF41F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000348")]
	internal PanelClearSettings clearSettings
	{
		[Token(Token = "0x6001187")]
		[Address(RVA = "0x2B296B0", Offset = "0x2B288B0", VA = "0x182B296B0")]
		[CompilerGenerated]
		get
		{
			return default(PanelClearSettings);
		}
		[Token(Token = "0x6001188")]
		[Address(RVA = "0x2B29A10", Offset = "0x2B28C10", VA = "0x182B29A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000349")]
	internal bool duringLayoutPhase
	{
		[Token(Token = "0x6001189")]
		[Address(RVA = "0x449800", Offset = "0x448A00", VA = "0x180449800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600118A")]
		[Address(RVA = "0x449850", Offset = "0x448A50", VA = "0x180449850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700034A")]
	internal abstract uint version
	{
		[Token(Token = "0x600118B")]
		get;
	}

	[Token(Token = "0x1700034B")]
	internal abstract uint hierarchyVersion
	{
		[Token(Token = "0x600118C")]
		get;
	}

	[Token(Token = "0x1700034C")]
	internal virtual RepaintData repaintData
	{
		[Token(Token = "0x600118F")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001190")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410", Slot = "35")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700034D")]
	internal virtual ICursorManager cursorManager
	{
		[Token(Token = "0x6001191")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001192")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0", Slot = "37")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700034E")]
	public ContextualMenuManager contextualMenuManager
	{
		[Token(Token = "0x6001193")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001194")]
		[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x1700034F")]
	internal virtual DataBindingManager dataBindingManager
	{
		[Token(Token = "0x6001195")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001196")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10", Slot = "40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000350")]
	public abstract VisualElement visualTree
	{
		[Token(Token = "0x6001197")]
		get;
	}

	[Token(Token = "0x17000351")]
	public abstract EventDispatcher dispatcher
	{
		[Token(Token = "0x6001198")]
		get;
		[Token(Token = "0x6001199")]
		set;
	}

	[Token(Token = "0x17000352")]
	internal abstract IScheduler scheduler
	{
		[Token(Token = "0x600119B")]
		get;
	}

	[Token(Token = "0x17000353")]
	internal abstract IStylePropertyAnimationSystem styleAnimationSystem
	{
		[Token(Token = "0x600119C")]
		get;
		[Token(Token = "0x600119D")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		set;
	}

	[Token(Token = "0x17000354")]
	public abstract ContextType contextType
	{
		[Token(Token = "0x600119E")]
		get;
	}

	[Token(Token = "0x17000355")]
	internal bool disposed
	{
		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x150BFD0", Offset = "0x150B1D0", VA = "0x18150BFD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60011A2")]
		[Address(RVA = "0x22D7510", Offset = "0x22D6710", VA = "0x1822D7510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000356")]
	public bool isFlat
	{
		[Token(Token = "0x60011AA")]
		[Address(RVA = "0x56D880", Offset = "0x56CA80", VA = "0x18056D880")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x2B29A20", Offset = "0x2B28C20", VA = "0x182B29A20")]
		set
		{
		}
	}

	[Token(Token = "0x17000357")]
	public abstract AtlasBase atlas
	{
		[Token(Token = "0x60011B0")]
		get;
		[Token(Token = "0x60011B1")]
		set;
	}

	[Token(Token = "0x14000027")]
	internal event Action<BaseVisualElementPanel> panelDisposed
	{
		[Token(Token = "0x6001176")]
		[Address(RVA = "0x2B29600", Offset = "0x2B28800", VA = "0x182B29600")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001177")]
		[Address(RVA = "0x2B29960", Offset = "0x2B28B60", VA = "0x182B29960")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000028")]
	internal event Action isFlatChanged
	{
		[Token(Token = "0x60011A8")]
		[Address(RVA = "0x2B29550", Offset = "0x2B28750", VA = "0x182B29550")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60011A9")]
		[Address(RVA = "0x2B298B0", Offset = "0x2B28AB0", VA = "0x182B298B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000029")]
	internal event Action atlasChanged
	{
		[Token(Token = "0x60011AD")]
		[Address(RVA = "0x2B293F0", Offset = "0x2B285F0", VA = "0x182B293F0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60011AE")]
		[Address(RVA = "0x2B29750", Offset = "0x2B28950", VA = "0x182B29750")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400002A")]
	internal event HierarchyEvent hierarchyChanged
	{
		[Token(Token = "0x60011B2")]
		[Address(RVA = "0x2B294A0", Offset = "0x2B286A0", VA = "0x182B294A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60011B3")]
		[Address(RVA = "0x2B29800", Offset = "0x2B28A00", VA = "0x182B29800")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6001179")]
	[Address(RVA = "0x2B29270", Offset = "0x2B28470", VA = "0x182B29270")]
	protected BaseVisualElementPanel()
	{
	}

	[Token(Token = "0x600117A")]
	[Address(RVA = "0x2B288B0", Offset = "0x2B27AB0", VA = "0x182B288B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600117B")]
	[Address(RVA = "0x2B28920", Offset = "0x2B27B20", VA = "0x182B28920", Slot = "22")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x600117C")]
	public abstract void Repaint(Event e);

	[Token(Token = "0x600117D")]
	public abstract void ValidateFocus();

	[Token(Token = "0x600117E")]
	public abstract void ValidateLayout();

	[Token(Token = "0x600117F")]
	public abstract void UpdateAnimations();

	[Token(Token = "0x6001180")]
	public abstract void UpdateBindings();

	[Token(Token = "0x6001181")]
	public abstract void ApplyStyles();

	[Token(Token = "0x600118D")]
	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag);

	[Token(Token = "0x600118E")]
	internal abstract void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase);

	[Token(Token = "0x600119A")]
	[Address(RVA = "0x2B28E00", Offset = "0x2B28000", VA = "0x182B28E00")]
	internal void SendEvent(EventBase e, DispatchMode dispatchMode = DispatchMode.Default)
	{
	}

	[Token(Token = "0x600119F")]
	public abstract VisualElement Pick(Vector2 point);

	[Token(Token = "0x60011A0")]
	public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked);

	[Token(Token = "0x60011A3")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase);

	[Token(Token = "0x60011A4")]
	[Address(RVA = "0x2B28AD0", Offset = "0x2B27CD0", VA = "0x182B28AD0")]
	internal VisualElement GetTopElementUnderPointer(int pointerId)
	{
		return null;
	}

	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x2B28B70", Offset = "0x2B27D70", VA = "0x182B28B70")]
	internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent)
	{
		return null;
	}

	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x2B287A0", Offset = "0x2B279A0", VA = "0x182B287A0")]
	internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent)
	{
	}

	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x2B287E0", Offset = "0x2B279E0", VA = "0x182B287E0")]
	internal void CommitElementUnderPointers()
	{
	}

	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x2B28EE0", Offset = "0x2B280E0", VA = "0x182B28EE0")]
	internal void SetSpecializedHierarchyFlagsUpdater()
	{
	}

	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x2B28B00", Offset = "0x2B27D00", VA = "0x182B28B00")]
	protected void InvokeAtlasChanged()
	{
	}

	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x2B28B40", Offset = "0x2B27D40", VA = "0x182B28B40")]
	internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType, [Optional] IReadOnlyList<VisualElement> additionalContext)
	{
	}

	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x2B28B20", Offset = "0x2B27D20", VA = "0x182B28B20")]
	internal void InvokeBeforeUpdate()
	{
	}

	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x2B28FF0", Offset = "0x2B281F0", VA = "0x182B28FF0")]
	internal void UpdateElementUnderPointers()
	{
	}

	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	private void UnityEngine_002EUIElements_002EIGroupBox_002EOnOptionAdded(IGroupBoxOption option)
	{
	}

	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "10")]
	private void UnityEngine_002EUIElements_002EIGroupBox_002EOnOptionRemoved(IGroupBoxOption option)
	{
	}

	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x2B28DB0", Offset = "0x2B27FB0", VA = "0x182B28DB0", Slot = "53")]
	public virtual void Render()
	{
	}

	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x2B28860", Offset = "0x2B27A60", VA = "0x182B28860", Slot = "54")]
	internal virtual IGenericMenu CreateMenu()
	{
		return null;
	}
}
