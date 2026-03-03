using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Profiling;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000049")]
internal class VisualTreeDataBindingsUpdater : BaseVisualTreeUpdater
{
	[Token(Token = "0x200004A")]
	private readonly struct VersionInfo
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly object source;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly long version;

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x29AFAE0", Offset = "0x29AECE0", VA = "0x1829AFAE0")]
		public VersionInfo(object source, long version)
		{
		}
	}

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ProfilerMarker s_UpdateProfilerMarker;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker s_ProcessBindingRequestsProfilerMarker;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly ProfilerMarker s_ProcessDataSourcesProfilerMarker;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly ProfilerMarker s_ShouldUpdateBindingProfilerMarker;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly ProfilerMarker s_UpdateBindingProfilerMarker;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly BindingUpdater m_Updater;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly List<VisualElement> m_BindingRegistrationRequests;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly HashSet<VisualElement> m_DataSourceChangedRequests;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly HashSet<VisualElement> m_RemovedElements;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly List<VisualElement> m_BoundsElement;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly List<VersionInfo> m_VersionChanges;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly HashSet<object> m_TrackedObjects;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly HashSet<Binding> m_RanUpdate;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly HashSet<object> m_KnownSources;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly HashSet<Binding> m_DirtyBindings;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private BaseVisualElementPanel m_AttachedPanel;

	[Token(Token = "0x17000045")]
	private DataBindingManager bindingManager
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x29B4220", Offset = "0x29B3420", VA = "0x1829B4220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000046")]
	public override ProfilerMarker profilerMarker
	{
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x29B4260", Offset = "0x29B3460", VA = "0x1829B4260", Slot = "12")]
		get
		{
			return default(ProfilerMarker);
		}
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x29B3F50", Offset = "0x29B3150", VA = "0x1829B3F50")]
	public VisualTreeDataBindingsUpdater()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x29B1A50", Offset = "0x29B0C50", VA = "0x1829B1A50")]
	protected void OnHierarchyChange(VisualElement ve, HierarchyChangeType type, [Optional] IReadOnlyList<VisualElement> additionalContext)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x29B1ED0", Offset = "0x29B10D0", VA = "0x1829B1ED0", Slot = "15")]
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x29B13C0", Offset = "0x29B05C0", VA = "0x1829B13C0")]
	private void CacheAndLogBindingResult(bool appliedOnUiCache, in DataBindingManager.BindingData bindingData, in BindingResult result)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x29B1910", Offset = "0x29B0B10", VA = "0x1829B1910")]
	private void LogResult(in BindingResult result)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x29B2CF0", Offset = "0x29B1EF0", VA = "0x1829B2CF0", Slot = "14")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x29B1610", Offset = "0x29B0810", VA = "0x1829B1610")]
	private (bool, long) GetDataSourceVersion(object source)
	{
		return default((bool, long));
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x29B1780", Offset = "0x29B0980", VA = "0x1829B1780")]
	private bool IsPrefix(in PropertyPath prefix, in PropertyPath path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x29B21A0", Offset = "0x29B13A0", VA = "0x1829B21A0")]
	private void ProcessDataSourceChangedRequests()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x29B1DE0", Offset = "0x29B0FE0", VA = "0x1829B1DE0")]
	private void OnPanelChanged(BaseVisualElementPanel p)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x29B1590", Offset = "0x29B0790", VA = "0x1829B1590", Slot = "13")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x29B1FC0", Offset = "0x29B11C0", VA = "0x1829B1FC0")]
	private void ProcessAllBindingRequests()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x29B2150", Offset = "0x29B1350", VA = "0x1829B2150")]
	private void ProcessBindingRequests(VisualElement element)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x29B2440", Offset = "0x29B1640", VA = "0x1829B2440")]
	private void ProcessPropertyChangedEvents(HashSet<Binding> ranUpdate)
	{
	}
}
