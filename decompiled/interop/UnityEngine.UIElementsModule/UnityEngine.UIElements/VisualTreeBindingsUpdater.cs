using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000047")]
internal class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
{
	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x0")]
	private static readonly PropertyName s_BindingRequestObjectVEPropertyName;

	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x4")]
	private static readonly PropertyName s_AdditionalBindingObjectVEPropertyName;

	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string s_Description;

	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x10")]
	private static readonly ProfilerMarker s_ProfilerMarker;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x18")]
	private static readonly ProfilerMarker s_ProfilerBindingRequestsMarker;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x20")]
	private static ProfilerMarker s_MarkerUpdate;

	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x28")]
	private static ProfilerMarker s_MarkerPoll;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x40")]
	private readonly HashSet<VisualElement> m_ElementsWithBindings;

	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x48")]
	private readonly HashSet<VisualElement> m_ElementsToAdd;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x50")]
	private readonly HashSet<VisualElement> m_ElementsToRemove;

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x58")]
	private long m_LastUpdateTime;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x60")]
	private HashSet<VisualElement> m_ElementsToBind;

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x70")]
	private List<IBinding> updatedBindings;

	[Token(Token = "0x17000042")]
	public override ProfilerMarker profilerMarker
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x29B1370", Offset = "0x29B0570", VA = "0x1829B1370", Slot = "12")]
		get
		{
			return default(ProfilerMarker);
		}
	}

	[Token(Token = "0x17000043")]
	public static bool disableBindingsThrottling
	{
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x29B1320", Offset = "0x29B0520", VA = "0x1829B1320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000044")]
	public Dictionary<object, object> temporaryObjectCache
	{
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x29AFC00", Offset = "0x29AEE00", VA = "0x1829AFC00")]
	private IBinding GetBindingObjectFromElement(VisualElement ve)
	{
		return null;
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x29B02D0", Offset = "0x29AF4D0", VA = "0x1829B02D0")]
	private void StartTracking(VisualElement ve)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x29B0470", Offset = "0x29AF670", VA = "0x1829B0470")]
	private void StopTracking(VisualElement ve)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x29AFB70", Offset = "0x29AED70", VA = "0x1829AFB70")]
	public static IBinding GetAdditionalBinding(VisualElement ve)
	{
		return null;
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x29B01A0", Offset = "0x29AF3A0", VA = "0x1829B01A0")]
	private void StartTrackingRecursive(VisualElement ve)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x29B0350", Offset = "0x29AF550", VA = "0x1829B0350")]
	private void StopTrackingRecursive(VisualElement ve)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x29AFD40", Offset = "0x29AEF40", VA = "0x1829AFD40", Slot = "15")]
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x29AFD10", Offset = "0x29AEF10", VA = "0x1829AFD10", Slot = "16")]
	protected override void OnHierarchyChange(VisualElement ve, HierarchyChangeType type)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x29AFB10", Offset = "0x29AED10", VA = "0x1829AFB10")]
	private static long CurrentTime()
	{
		return default(long);
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x29B00B0", Offset = "0x29AF2B0", VA = "0x1829B00B0")]
	public static bool ShouldProcessBindings(long startTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x29AFE30", Offset = "0x29AF030", VA = "0x1829AFE30")]
	public void PerformTrackingOperations()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x29B09C0", Offset = "0x29AFBC0", VA = "0x1829B09C0", Slot = "14")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x29B04F0", Offset = "0x29AF6F0", VA = "0x1829B04F0")]
	private void UpdateBindings()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x29AFB50", Offset = "0x29AED50", VA = "0x1829AFB50", Slot = "13")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x29B1180", Offset = "0x29B0380", VA = "0x1829B1180")]
	public VisualTreeBindingsUpdater()
	{
	}
}
