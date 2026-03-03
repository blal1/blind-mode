using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x200002F")]
internal sealed class DataBindingManager : IDisposable
{
	[Token(Token = "0x2000030")]
	private readonly struct BindingRequest
	{
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x0")]
		public readonly BindingId bindingId;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x98")]
		public readonly Binding binding;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0xA0")]
		public readonly bool shouldProcess;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2976890", Offset = "0x2975A90", VA = "0x182976890")]
		public BindingRequest(in BindingId bindingId, Binding binding, bool shouldProcess = true)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x29767B0", Offset = "0x29759B0", VA = "0x1829767B0")]
		public BindingRequest CancelRequest()
		{
			return default(BindingRequest);
		}
	}

	[Token(Token = "0x2000031")]
	private struct BindingDataCollection : IDisposable
	{
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<BindingId, BindingData> m_BindingPerId;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x8")]
		private List<BindingData> m_Bindings;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2975AB0", Offset = "0x2974CB0", VA = "0x182975AB0")]
		public static BindingDataCollection Create()
		{
			return default(BindingDataCollection);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x29758A0", Offset = "0x2974AA0", VA = "0x1829758A0")]
		public void AddBindingData(BindingData bindingData)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2975E60", Offset = "0x2975060", VA = "0x182975E60")]
		public bool TryGetBindingData(in BindingId bindingId, out BindingData data)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2975CA0", Offset = "0x2974EA0", VA = "0x182975CA0")]
		public bool RemoveBindingData(BindingData bindingData)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1FA2BC0", Offset = "0x1FA1DC0", VA = "0x181FA2BC0")]
		public List<BindingData> GetBindings()
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2975C60", Offset = "0x2974E60", VA = "0x182975C60")]
		public int GetBindingCount()
		{
			return default(int);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2975B80", Offset = "0x2974D80", VA = "0x182975B80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x2000032")]
	internal class BindingData
	{
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x10")]
		public long version;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x18")]
		public BindingTarget target;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0xB8")]
		public Binding binding;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0xC0")]
		private DataSourceContext m_LastContext;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x160")]
		public BindingResult? m_SourceToUILastUpdate;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x178")]
		public BindingResult? m_UIToSourceLastUpdate;

		[Token(Token = "0x17000033")]
		public object localDataSource
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x4C15C0", Offset = "0x4C07C0", VA = "0x1804C15C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x4C19D0", Offset = "0x4C0BD0", VA = "0x1804C19D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public DataSourceContext context
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x2976000", Offset = "0x2975200", VA = "0x182976000")]
			set
			{
			}
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2975F40", Offset = "0x2975140", VA = "0x182975F40")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public BindingData()
		{
		}
	}

	[Token(Token = "0x2000033")]
	internal readonly struct ChangesFromUI
	{
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x0")]
		public readonly long version;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x8")]
		public readonly Binding binding;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x10")]
		public readonly BindingData bindingData;

		[Token(Token = "0x17000035")]
		public bool IsValid
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x2979470", Offset = "0x2978670", VA = "0x182979470")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2979420", Offset = "0x2978620", VA = "0x182979420")]
		public ChangesFromUI(BindingData bindingData)
		{
		}
	}

	[Token(Token = "0x2000034")]
	private class HierarchyBindingTracker : IDisposable
	{
		[Token(Token = "0x2000035")]
		private class HierarchicalBindingsSorter : HierarchyTraversal
		{
			[Token(Token = "0x17000036")]
			public HashSet<VisualElement> boundElements
			{
				[Token(Token = "0x60001C1")]
				[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001C2")]
				[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000037")]
			public List<VisualElement> results
			{
				[Token(Token = "0x60001C3")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001C4")]
				[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x2993370", Offset = "0x2992570", VA = "0x182993370", Slot = "5")]
			public override void TraverseRecursive(VisualElement element, int depth)
			{
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
			public HierarchicalBindingsSorter()
			{
			}
		}

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x10")]
		private readonly BaseVisualElementPanel m_Panel;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x18")]
		private readonly HierarchicalBindingsSorter m_BindingSorter;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<VisualElement, BindingDataCollection> m_BindingDataPerElement;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x28")]
		private readonly HashSet<VisualElement> m_BoundElements;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<VisualElement> m_OrderedBindings;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x38")]
		private bool m_IsDirty;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x40")]
		private EventCallback<PropertyChangedEvent, Dictionary<VisualElement, BindingDataCollection>> m_OnPropertyChanged;

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x29936F0", Offset = "0x29928F0", VA = "0x1829936F0")]
		public int GetTrackedElementsCount()
		{
			return default(int);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2993600", Offset = "0x2992800", VA = "0x182993600")]
		public List<VisualElement> GetBoundElements()
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x29943A0", Offset = "0x29935A0", VA = "0x1829943A0")]
		public HierarchyBindingTracker(BaseVisualElementPanel panel)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x96E7E0", Offset = "0x96D9E0", VA = "0x18096E7E0")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2994330", Offset = "0x2993530", VA = "0x182994330")]
		public bool TryGetBindingCollection(VisualElement element, out BindingDataCollection collection)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2993730", Offset = "0x2992930", VA = "0x182993730")]
		public bool IsTrackingElement(VisualElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2993E50", Offset = "0x2993050", VA = "0x182993E50")]
		public void StartTrackingBinding(VisualElement element, BindingData binding)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2993790", Offset = "0x2992990", VA = "0x182993790")]
		private void OnPropertyChanged(PropertyChangedEvent evt, Dictionary<VisualElement, BindingDataCollection> bindingCollection)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x29940D0", Offset = "0x29932D0", VA = "0x1829940D0")]
		public void StopTrackingBinding(VisualElement element, BindingData binding)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2994270", Offset = "0x2993470", VA = "0x182994270")]
		public void StopTrackingElement(VisualElement element)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2993440", Offset = "0x2992640", VA = "0x182993440", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2993D80", Offset = "0x2992F80", VA = "0x182993D80")]
		private void OrderBindings(VisualElement root)
		{
		}
	}

	[Token(Token = "0x2000036")]
	private class HierarchyDataSourceTracker : IDisposable
	{
		[Token(Token = "0x2000037")]
		private class SourceInfo
		{
			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x10")]
			private HashSet<PropertyPath> m_DetectedChanges;

			[Token(Token = "0x17000038")]
			public long lastVersion
			{
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x178F430", Offset = "0x178E630", VA = "0x18178F430")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000039")]
			public int refCount
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700003A")]
			public HashSet<PropertyPath> detectedChanges
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x2997F30", Offset = "0x2997130", VA = "0x182997F30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003B")]
			public HashSet<PropertyPath> detectedChangesNoAlloc
			{
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public SourceInfo()
			{
			}
		}

		[Token(Token = "0x2000038")]
		private class InvalidateDataSourcesTraversal : HierarchyTraversal
		{
			[Token(Token = "0x4000130")]
			[FieldOffset(Offset = "0x10")]
			private readonly HierarchyDataSourceTracker m_DataSourceTracker;

			[Token(Token = "0x4000131")]
			[FieldOffset(Offset = "0x18")]
			private readonly HashSet<VisualElement> m_VisitedElements;

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x2997560", Offset = "0x2996760", VA = "0x182997560")]
			public InvalidateDataSourcesTraversal(HierarchyDataSourceTracker dataSourceTracker)
			{
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x2997270", Offset = "0x2996470", VA = "0x182997270")]
			public void Invalidate(List<VisualElement> addedOrMovedElements, HashSet<VisualElement> removedElements)
			{
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x2997460", Offset = "0x2996660", VA = "0x182997460", Slot = "5")]
			public override void TraverseRecursive(VisualElement element, int depth)
			{
			}
		}

		[Token(Token = "0x2000039")]
		private class ObjectComparer : IEqualityComparer<object>
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x2997660", Offset = "0x2996860", VA = "0x182997660", Slot = "4")]
			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CSystem_002EObject_003E_002EEquals(object x, object y)
			{
				return default(bool);
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x29977F0", Offset = "0x29969F0", VA = "0x1829977F0", Slot = "5")]
			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CSystem_002EObject_003E_002EGetHashCode(object obj)
			{
				return default(int);
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public ObjectComparer()
			{
			}
		}

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<SourceInfo> m_SourceInfosPool;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x18")]
		private readonly DataBindingManager m_DataBindingManager;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<VisualElement, DataSourceContext> m_ResolvedHierarchicalDataSourceContext;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<Binding, int> m_BindingRefCount;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<object, SourceInfo> m_SourceInfos;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x38")]
		private readonly HashSet<object> m_SourcesToRemove;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x40")]
		private readonly InvalidateDataSourcesTraversal m_InvalidateResolvedDataSources;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x48")]
		private readonly EventHandler<BindablePropertyChangedEventArgs> m_Handler;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x50")]
		private readonly EventCallback<PropertyChangedEvent, VisualElement> m_VisualElementHandler;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2995480", Offset = "0x2994680", VA = "0x182995480")]
		private SourceInfo GetPooledSourceInfo()
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2996510", Offset = "0x2995710", VA = "0x182996510")]
		private void ReleasePooledSourceInfo(SourceInfo info)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2996A90", Offset = "0x2995C90", VA = "0x182996A90")]
		public HierarchyDataSourceTracker(DataBindingManager manager)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2995D60", Offset = "0x2994F60", VA = "0x182995D60")]
		internal void IncreaseBindingRefCount(ref BindingData bindingData)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x29948E0", Offset = "0x2993AE0", VA = "0x1829948E0")]
		internal void DecreaseBindingRefCount(ref BindingData bindingData)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2995EA0", Offset = "0x29950A0", VA = "0x182995EA0")]
		internal void IncreaseRefCount(object dataSource)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2996380", Offset = "0x2995580", VA = "0x182996380")]
		private void OnVisualElementPropertyChanged(PropertyChangedEvent evt, VisualElement element)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2994A40", Offset = "0x2993C40", VA = "0x182994A40")]
		internal void DecreaseRefCount(object dataSource)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2995D10", Offset = "0x2994F10", VA = "0x182995D10")]
		public int GetTrackedDataSourcesCount()
		{
			return default(int);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2994CD0", Offset = "0x2993ED0", VA = "0x182994CD0")]
		public HashSet<PropertyPath> GetChangesFromSource(object dataSource)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2994540", Offset = "0x2993740", VA = "0x182994540")]
		public void ClearChangesFromSource(object dataSource)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x29960F0", Offset = "0x29952F0", VA = "0x1829960F0")]
		public void InvalidateCachedDataSource(HashSet<VisualElement> elements, HashSet<VisualElement> removedElements)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2995560", Offset = "0x2994760", VA = "0x182995560")]
		public DataSourceContext GetResolvedDataSourceContext(VisualElement element, BindingData bindingData)
		{
			return default(DataSourceContext);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2996660", Offset = "0x2995860", VA = "0x182996660")]
		private void TrackPropertyChanges(object sender, BindablePropertyChangedEventArgs args)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x29967D0", Offset = "0x29959D0", VA = "0x1829967D0")]
		private void TrackPropertyChanges(object sender, PropertyPath propertyPath)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2996950", Offset = "0x2995B50", VA = "0x182996950")]
		public bool TryGetLastVersion(object source, out long version)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x29969F0", Offset = "0x2995BF0", VA = "0x1829969F0")]
		public void UpdateVersion(object source, long version)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2994D50", Offset = "0x2993F50", VA = "0x182994D50")]
		internal DataSourceContext GetHierarchicalDataSourceContext(VisualElement element)
		{
			return default(DataSourceContext);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2996600", Offset = "0x2995800", VA = "0x182996600")]
		internal void RemoveHierarchyDataSourceContextFromElement(VisualElement element)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2994BF0", Offset = "0x2993DF0", VA = "0x182994BF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x29945E0", Offset = "0x29937E0", VA = "0x1829945E0")]
		public void ClearSourceCache()
		{
		}
	}

	[Token(Token = "0x200003A")]
	private struct IgnoreUIChangesData
	{
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x0")]
		public VisualElement element;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x8")]
		public Binding binding;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x10")]
		public BindingId bindingId;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2996DA0", Offset = "0x2995FA0", VA = "0x182996DA0")]
		public bool ShouldIgnoreChange(VisualElement ve, Binding b, BindingId id)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200003B")]
	public struct IgnoreUIChangesScope : IDisposable
	{
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x0")]
		private IgnoreUIChangesData m_ScopeData;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0xA8")]
		private DataBindingManager manager;

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2996F50", Offset = "0x2996150", VA = "0x182996F50")]
		internal IgnoreUIChangesScope(DataBindingManager manager, VisualElement target, BindingId bindingId, Binding binding)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2996E30", Offset = "0x2996030", VA = "0x182996E30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x10")]
	private readonly List<BindingData> m_BindingDataLocalPool;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x0")]
	private static readonly PropertyName k_RequestBindingPropertyName;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x8")]
	private static readonly BindingId k_ClearBindingsToken;

	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0xA0")]
	internal static BindingLogLevel globalLogLevel;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x18")]
	private BindingLogLevel? m_LogLevel;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0xA8")]
	private static readonly List<BindingData> s_Empty;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x20")]
	private readonly BaseVisualElementPanel m_Panel;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x28")]
	private readonly HierarchyDataSourceTracker m_DataSourceTracker;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x30")]
	private readonly HierarchyBindingTracker m_BindingsTracker;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<ChangesFromUI> m_DetectedChangesFromUI;

	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x40")]
	private IgnoreUIChangesData m_IgnoreUIChangesData;

	[Token(Token = "0x17000032")]
	internal BindingLogLevel logLevel
	{
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2990F60", Offset = "0x2990160", VA = "0x182990F60")]
		get
		{
			return default(BindingLogLevel);
		}
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2990FF0", Offset = "0x29901F0", VA = "0x182990FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x298F650", Offset = "0x298E850", VA = "0x18298F650")]
	internal void ResetLogLevel()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x2990C90", Offset = "0x298FE90", VA = "0x182990C90")]
	internal DataBindingManager(BaseVisualElementPanel panel)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x298DF40", Offset = "0x298D140", VA = "0x18298DF40")]
	internal int GetTrackedDataSourcesCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x298FCC0", Offset = "0x298EEC0", VA = "0x18298FCC0")]
	internal bool TryGetLastVersion(object source, out long version)
	{
		return default(bool);
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x2990A20", Offset = "0x298FC20", VA = "0x182990A20")]
	internal void UpdateVersion(object source, long version)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x298CE50", Offset = "0x298C050", VA = "0x18298CE50")]
	internal void CacheUIBindingResult(BindingData bindingData, BindingResult result)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x298FC20", Offset = "0x298EE20", VA = "0x18298FC20")]
	internal bool TryGetLastUIBindingResult(BindingData bindingData, out BindingResult result)
	{
		return default(bool);
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x298CDB0", Offset = "0x298BFB0", VA = "0x18298CDB0")]
	internal void CacheSourceBindingResult(BindingData bindingData, BindingResult result)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x298FB80", Offset = "0x298ED80", VA = "0x18298FB80")]
	internal bool TryGetLastSourceBindingResult(BindingData bindingData, out BindingResult result)
	{
		return default(bool);
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x298DDD0", Offset = "0x298CFD0", VA = "0x18298DDD0")]
	internal DataSourceContext GetResolvedDataSourceContext(VisualElement element, BindingData bindingData)
	{
		return default(DataSourceContext);
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x298DA70", Offset = "0x298CC70", VA = "0x18298DA70")]
	internal int GetBoundElementsCount()
	{
		return default(int);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x298DAC0", Offset = "0x298CCC0", VA = "0x18298DAC0")]
	internal IEnumerable<VisualElement> GetBoundElements()
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x298DF90", Offset = "0x298D190", VA = "0x18298DF90")]
	public IgnoreUIChangesScope IgnoreChangesScope(VisualElement target, BindingId bindingId, Binding binding)
	{
		return default(IgnoreUIChangesScope);
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x2844C00", Offset = "0x2843E00", VA = "0x182844C00")]
	internal List<ChangesFromUI> GetChangedDetectedFromUI()
	{
		return null;
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x298DBC0", Offset = "0x298CDC0", VA = "0x18298DBC0")]
	internal HashSet<PropertyPath> GetChangedDetectedFromSource(object dataSource)
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x298D200", Offset = "0x298C400", VA = "0x18298D200")]
	internal void ClearChangesFromSource(object dataSource)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x298D980", Offset = "0x298CB80", VA = "0x18298D980")]
	internal List<BindingData> GetBindingData(VisualElement element)
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x298F870", Offset = "0x298EA70", VA = "0x18298F870")]
	internal bool TryGetBindingData(VisualElement element, in BindingId bindingId, out BindingData bindingData)
	{
		return default(bool);
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x298E6C0", Offset = "0x298D8C0", VA = "0x18298E6C0")]
	internal void RegisterBinding(VisualElement element, in BindingId bindingId, Binding binding)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x298FD70", Offset = "0x298EF70", VA = "0x18298FD70")]
	internal void UnregisterBinding(VisualElement element, in BindingId bindingId)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x298F6B0", Offset = "0x298E8B0", VA = "0x18298F6B0")]
	internal void TransferBindingRequests(VisualElement element)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x298E100", Offset = "0x298D300", VA = "0x18298E100")]
	public void InvalidateCachedDataSource(HashSet<VisualElement> addedOrMovedElements, HashSet<VisualElement> removedElements)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x298D820", Offset = "0x298CA20", VA = "0x18298D820", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x298D2C0", Offset = "0x298C4C0", VA = "0x18298D2C0")]
	private static void CreateBindingRequest(VisualElement target, in BindingId bindingId, Binding binding, bool isTransferring)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x298E120", Offset = "0x298D320", VA = "0x18298E120")]
	public void ProcessBindingRequests(VisualElement element)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x298CEF0", Offset = "0x298C0F0", VA = "0x18298CEF0")]
	private void ClearAllBindings(VisualElement element)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x298CCE0", Offset = "0x298BEE0", VA = "0x18298CCE0")]
	internal static bool AnyPendingBindingRequests(VisualElement element)
	{
		return default(bool);
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x298F950", Offset = "0x298EB50", VA = "0x18298F950")]
	internal static bool TryGetBindingRequest(VisualElement element, in BindingId bindingId, out Binding binding)
	{
		return default(bool);
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x298D800", Offset = "0x298CA00", VA = "0x18298D800")]
	public void DirtyBindingOrder()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x298F660", Offset = "0x298E860", VA = "0x18298F660")]
	public void TrackDataSource(object previous, object current)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x298D2A0", Offset = "0x298C4A0", VA = "0x18298D2A0")]
	public void ClearSourceCache()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x298DC50", Offset = "0x298CE50", VA = "0x18298DC50")]
	public BindingData GetPooledBindingData(BindingTarget target, Binding binding)
	{
		return null;
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x298F4E0", Offset = "0x298E6E0", VA = "0x18298F4E0")]
	public void ReleasePoolBindingData(BindingData data)
	{
	}
}
