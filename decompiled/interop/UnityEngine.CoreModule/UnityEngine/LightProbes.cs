using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEngine;

public sealed class LightProbes : Object
{
	private delegate void TetrahedralizeDelegate();

	private delegate void TetrahedralizeAsyncDelegate();

	private delegate int GetCountDelegate();

	private delegate void GetInterpolatedProbe_InjectedDelegate([In] System.IntPtr position, System.IntPtr renderer, [Out] System.IntPtr probe);

	private delegate bool AreLightProbesAllowed_InjectedDelegate(System.IntPtr renderer);

	private delegate void CalculateInterpolatedLightAndOcclusionProbes_Internal_InjectedDelegate(System.IntPtr positions, int positionsCount, System.IntPtr lightProbes, System.IntPtr occlusionProbes);

	private delegate System.IntPtr GetSharedLightProbesForScene_InjectedDelegate([In] System.IntPtr scene);

	private delegate System.IntPtr GetInstantiatedLightProbesForScene_InjectedDelegate([In] System.IntPtr scene);

	private delegate void get_positions_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void GetPositionsSelf_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate bool SetPositionsSelf_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positions, bool checkForDuplicatePositions);

	private delegate void get_bakedProbes_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_bakedProbes_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate int get_count_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_countSelf_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_cellCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_cellCountSelf_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr_lightProbesUpdated;

	private static readonly System.IntPtr NativeFieldInfoPtr_tetrahedralizationCompleted;

	private static readonly System.IntPtr NativeFieldInfoPtr_needsRetetrahedralization;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CallLightProbesUpdatedFunction_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0;

	private static readonly TetrahedralizeDelegate TetrahedralizeDelegateField;

	private static readonly TetrahedralizeAsyncDelegate TetrahedralizeAsyncDelegateField;

	private static readonly GetCountDelegate GetCountDelegateField;

	private static readonly GetInterpolatedProbe_InjectedDelegate GetInterpolatedProbe_InjectedDelegateField;

	private static readonly AreLightProbesAllowed_InjectedDelegate AreLightProbesAllowed_InjectedDelegateField;

	private static readonly CalculateInterpolatedLightAndOcclusionProbes_Internal_InjectedDelegate CalculateInterpolatedLightAndOcclusionProbes_Internal_InjectedDelegateField;

	private static readonly GetSharedLightProbesForScene_InjectedDelegate GetSharedLightProbesForScene_InjectedDelegateField;

	private static readonly GetInstantiatedLightProbesForScene_InjectedDelegate GetInstantiatedLightProbesForScene_InjectedDelegateField;

	private static readonly get_positions_InjectedDelegate get_positions_InjectedDelegateField;

	private static readonly GetPositionsSelf_InjectedDelegate GetPositionsSelf_InjectedDelegateField;

	private static readonly SetPositionsSelf_InjectedDelegate SetPositionsSelf_InjectedDelegateField;

	private static readonly get_bakedProbes_InjectedDelegate get_bakedProbes_InjectedDelegateField;

	private static readonly set_bakedProbes_InjectedDelegate set_bakedProbes_InjectedDelegateField;

	private static readonly get_count_InjectedDelegate get_count_InjectedDelegateField;

	private static readonly get_countSelf_InjectedDelegate get_countSelf_InjectedDelegateField;

	private static readonly get_cellCount_InjectedDelegate get_cellCount_InjectedDelegateField;

	private static readonly get_cellCountSelf_InjectedDelegate get_cellCountSelf_InjectedDelegateField;

	public unsafe static Il2CppSystem.Action lightProbesUpdated
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lightProbesUpdated, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lightProbesUpdated, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action tetrahedralizationCompleted
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tetrahedralizationCompleted, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tetrahedralizationCompleted, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action needsRetetrahedralization
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_needsRetetrahedralization, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_needsRetetrahedralization, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector3> positions
	{
		get
		{
			Unsafe.SkipInit(out BlittableArrayWrapper ret);
			Il2CppStructArray<Vector3> result;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_positions_Injected(intPtr, out ret);
			}
			finally
			{
				Unsafe.SkipInit(out Il2CppStructArray<Vector3> array);
				ret.Unmarshal(ref *(Il2CppArrayBase<Vector3>*)(&array));
				result = array;
			}
			return result;
		}
	}

	public unsafe Il2CppStructArray<SphericalHarmonicsL2> bakedProbes
	{
		get
		{
			Unsafe.SkipInit(out BlittableArrayWrapper ret);
			Il2CppStructArray<SphericalHarmonicsL2> result;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_bakedProbes_Injected(intPtr, out ret);
			}
			finally
			{
				Unsafe.SkipInit(out Il2CppStructArray<SphericalHarmonicsL2> array);
				ret.Unmarshal(ref *(Il2CppArrayBase<SphericalHarmonicsL2>*)(&array));
				result = array;
			}
			return result;
		}
		set
		{
			//IL_0018: Expected O, but got Ref
			//IL_001f: Expected O, but got Ref
			//IL_002b: Expected O, but got Ref
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out Il2CppSystem.Span<SphericalHarmonicsL2> span);
			((Il2CppSystem.Span<SphericalHarmonicsL2>)(&span))._002Ector((Il2CppArrayBase<SphericalHarmonicsL2>)(object)value);
			fixed (SphericalHarmonicsL2* begin = &((Il2CppSystem.Span<SphericalHarmonicsL2>)(&span)).GetPinnableReference())
			{
				ManagedSpanWrapper value2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<SphericalHarmonicsL2>)(&span)).Length);
				set_bakedProbes_Injected(intPtr, ref value2);
			}
		}
	}

	public int count
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_count_Injected(intPtr);
		}
	}

	public int countSelf
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_countSelf_Injected(intPtr);
		}
	}

	public int cellCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_cellCount_Injected(intPtr);
		}
	}

	public int cellCountSelf
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_cellCountSelf_Injected(intPtr);
		}
	}

	public Il2CppStructArray<float> coefficients
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
		}
	}

	static LightProbes()
	{
		Il2CppClassPointerStore<LightProbes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightProbes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbes>.NativeClassPtr);
		NativeFieldInfoPtr_lightProbesUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, "lightProbesUpdated");
		NativeFieldInfoPtr_tetrahedralizationCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, "tetrahedralizationCompleted");
		NativeFieldInfoPtr_needsRetetrahedralization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, "needsRetetrahedralization");
		NativeMethodInfoPtr_Internal_CallLightProbesUpdatedFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664431);
		NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664432);
		NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664433);
		TetrahedralizeDelegateField = IL2CPP.ResolveICall<TetrahedralizeDelegate>("UnityEngine.LightProbes::Tetrahedralize");
		TetrahedralizeAsyncDelegateField = IL2CPP.ResolveICall<TetrahedralizeAsyncDelegate>("UnityEngine.LightProbes::TetrahedralizeAsync");
		GetCountDelegateField = IL2CPP.ResolveICall<GetCountDelegate>("UnityEngine.LightProbes::GetCount");
		GetInterpolatedProbe_InjectedDelegateField = IL2CPP.ResolveICall<GetInterpolatedProbe_InjectedDelegate>("UnityEngine.LightProbes::GetInterpolatedProbe_Injected");
		AreLightProbesAllowed_InjectedDelegateField = IL2CPP.ResolveICall<AreLightProbesAllowed_InjectedDelegate>("UnityEngine.LightProbes::AreLightProbesAllowed_Injected");
		CalculateInterpolatedLightAndOcclusionProbes_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CalculateInterpolatedLightAndOcclusionProbes_Internal_InjectedDelegate>("UnityEngine.LightProbes::CalculateInterpolatedLightAndOcclusionProbes_Internal_Injected");
		GetSharedLightProbesForScene_InjectedDelegateField = IL2CPP.ResolveICall<GetSharedLightProbesForScene_InjectedDelegate>("UnityEngine.LightProbes::GetSharedLightProbesForScene_Injected");
		GetInstantiatedLightProbesForScene_InjectedDelegateField = IL2CPP.ResolveICall<GetInstantiatedLightProbesForScene_InjectedDelegate>("UnityEngine.LightProbes::GetInstantiatedLightProbesForScene_Injected");
		get_positions_InjectedDelegateField = IL2CPP.ResolveICall<get_positions_InjectedDelegate>("UnityEngine.LightProbes::get_positions_Injected");
		GetPositionsSelf_InjectedDelegateField = IL2CPP.ResolveICall<GetPositionsSelf_InjectedDelegate>("UnityEngine.LightProbes::GetPositionsSelf_Injected");
		SetPositionsSelf_InjectedDelegateField = IL2CPP.ResolveICall<SetPositionsSelf_InjectedDelegate>("UnityEngine.LightProbes::SetPositionsSelf_Injected");
		get_bakedProbes_InjectedDelegateField = IL2CPP.ResolveICall<get_bakedProbes_InjectedDelegate>("UnityEngine.LightProbes::get_bakedProbes_Injected");
		set_bakedProbes_InjectedDelegateField = IL2CPP.ResolveICall<set_bakedProbes_InjectedDelegate>("UnityEngine.LightProbes::set_bakedProbes_Injected");
		get_count_InjectedDelegateField = IL2CPP.ResolveICall<get_count_InjectedDelegate>("UnityEngine.LightProbes::get_count_Injected");
		get_countSelf_InjectedDelegateField = IL2CPP.ResolveICall<get_countSelf_InjectedDelegate>("UnityEngine.LightProbes::get_countSelf_Injected");
		get_cellCount_InjectedDelegateField = IL2CPP.ResolveICall<get_cellCount_InjectedDelegate>("UnityEngine.LightProbes::get_cellCount_Injected");
		get_cellCountSelf_InjectedDelegateField = IL2CPP.ResolveICall<get_cellCountSelf_InjectedDelegate>("UnityEngine.LightProbes::get_cellCountSelf_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173317, XrefRangeEnd = 1173319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CallLightProbesUpdatedFunction()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CallLightProbesUpdatedFunction_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173319, XrefRangeEnd = 1173321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CallTetrahedralizationCompletedFunction()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173321, XrefRangeEnd = 1173323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CallNeedsRetetrahedralizationFunction()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LightProbes(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_lightProbesUpdated(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_lightProbesUpdated(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_tetrahedralizationCompleted(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_tetrahedralizationCompleted(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_needsRetetrahedralization(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_needsRetetrahedralization(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void Tetrahedralize()
	{
		TetrahedralizeDelegateField();
	}

	public static void TetrahedralizeAsync()
	{
		TetrahedralizeAsyncDelegateField();
	}

	public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe)
	{
		GetInterpolatedProbe_Injected(ref position, MarshalledUnityObject.Marshal(renderer), out probe);
	}

	public static bool AreLightProbesAllowed(Renderer renderer)
	{
		return AreLightProbesAllowed_Injected(MarshalledUnityObject.Marshal(renderer));
	}

	public static void CalculateInterpolatedLightAndOcclusionProbes(Il2CppStructArray<Vector3> positions, Il2CppStructArray<SphericalHarmonicsL2> lightProbes, Il2CppStructArray<Vector4> occlusionProbes)
	{
		if (positions == null)
		{
			throw new Il2CppSystem.ArgumentNullException("positions");
		}
		if (lightProbes == null && occlusionProbes == null)
		{
			throw new Il2CppSystem.ArgumentException("Argument lightProbes and occlusionProbes cannot both be null.");
		}
		if (lightProbes != null && ((Il2CppArrayBase)lightProbes).Length < ((Il2CppArrayBase)positions).Length)
		{
			throw new Il2CppSystem.ArgumentException("lightProbes", "Argument lightProbes has less elements than positions");
		}
		if (occlusionProbes != null && ((Il2CppArrayBase)occlusionProbes).Length < ((Il2CppArrayBase)positions).Length)
		{
			throw new Il2CppSystem.ArgumentException("occlusionProbes", "Argument occlusionProbes has less elements than positions");
		}
		CalculateInterpolatedLightAndOcclusionProbes_Internal(positions, ((Il2CppArrayBase)positions).Length, lightProbes, occlusionProbes);
	}

	public static void CalculateInterpolatedLightAndOcclusionProbes(List<Vector3> positions, List<SphericalHarmonicsL2> lightProbes, List<Vector4> occlusionProbes)
	{
		if (positions == null)
		{
			throw new Il2CppSystem.ArgumentNullException("positions");
		}
		if (lightProbes == null && occlusionProbes == null)
		{
			throw new Il2CppSystem.ArgumentException("Argument lightProbes and occlusionProbes cannot both be null.");
		}
		if (lightProbes != null)
		{
			NoAllocHelpers.EnsureListElemCount(lightProbes, positions.Count);
		}
		if (occlusionProbes != null)
		{
			NoAllocHelpers.EnsureListElemCount(occlusionProbes, positions.Count);
		}
		CalculateInterpolatedLightAndOcclusionProbes_Internal((Il2CppStructArray<Vector3>)(object)NoAllocHelpers.ExtractArrayFromList(positions), positions.Count, (Il2CppStructArray<SphericalHarmonicsL2>)(object)NoAllocHelpers.ExtractArrayFromList(lightProbes), (Il2CppStructArray<Vector4>)(object)NoAllocHelpers.ExtractArrayFromList(occlusionProbes));
	}

	public unsafe static void CalculateInterpolatedLightAndOcclusionProbes_Internal(Il2CppStructArray<Vector3> positions, int positionsCount, Il2CppStructArray<SphericalHarmonicsL2> lightProbes, Il2CppStructArray<Vector4> occlusionProbes)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		//IL_0033: Expected O, but got Ref
		//IL_0041: Expected O, but got Ref
		//IL_0051: Expected O, but got Ref
		//IL_0058: Expected O, but got Ref
		//IL_0066: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector3> span);
		((Il2CppSystem.Span<Vector3>)(&span))._002Ector((Il2CppArrayBase<Vector3>)(object)positions);
		fixed (Vector3* begin = &((Il2CppSystem.Span<Vector3>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector3>)(&span)).Length);
			Unsafe.SkipInit(out Il2CppSystem.Span<SphericalHarmonicsL2> span2);
			((Il2CppSystem.Span<SphericalHarmonicsL2>)(&span2))._002Ector((Il2CppArrayBase<SphericalHarmonicsL2>)(object)lightProbes);
			fixed (SphericalHarmonicsL2* begin2 = &((Il2CppSystem.Span<SphericalHarmonicsL2>)(&span2)).GetPinnableReference())
			{
				ManagedSpanWrapper lightProbes2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.Span<SphericalHarmonicsL2>)(&span2)).Length);
				Unsafe.SkipInit(out Il2CppSystem.Span<Vector4> span3);
				((Il2CppSystem.Span<Vector4>)(&span3))._002Ector((Il2CppArrayBase<Vector4>)(object)occlusionProbes);
				fixed (Vector4* begin3 = &((Il2CppSystem.Span<Vector4>)(&span3)).GetPinnableReference())
				{
					ManagedSpanWrapper occlusionProbes2 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.Span<Vector4>)(&span3)).Length);
					CalculateInterpolatedLightAndOcclusionProbes_Internal_Injected(ref managedSpanWrapper, positionsCount, ref lightProbes2, ref occlusionProbes2);
				}
			}
		}
	}

	public static LightProbes GetSharedLightProbesForScene(Scene scene)
	{
		return Unmarshal.UnmarshalUnityObject<LightProbes>(GetSharedLightProbesForScene_Injected(ref scene));
	}

	public static LightProbes GetInstantiatedLightProbesForScene(Scene scene)
	{
		return Unmarshal.UnmarshalUnityObject<LightProbes>(GetInstantiatedLightProbesForScene_Injected(ref scene));
	}

	public unsafe Il2CppStructArray<Vector3> GetPositionsSelf()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Vector3> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetPositionsSelf_Injected(intPtr, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<Vector3> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<Vector3>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe bool SetPositionsSelf(Il2CppStructArray<Vector3> positions, bool checkForDuplicatePositions)
	{
		//IL_0018: Expected O, but got Ref
		//IL_001f: Expected O, but got Ref
		//IL_002b: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector3> span);
		((Il2CppSystem.Span<Vector3>)(&span))._002Ector((Il2CppArrayBase<Vector3>)(object)positions);
		bool result;
		fixed (Vector3* begin = &((Il2CppSystem.Span<Vector3>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector3>)(&span)).Length);
			result = SetPositionsSelf_Injected(intPtr, ref managedSpanWrapper, checkForDuplicatePositions);
		}
		return result;
	}

	public static int GetCount()
	{
		return GetCountDelegateField();
	}

	public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, Il2CppStructArray<float> coefficients)
	{
	}

	public unsafe static void GetInterpolatedProbe_Injected([In] ref Vector3 position, System.IntPtr renderer, out SphericalHarmonicsL2 probe)
	{
		GetInterpolatedProbe_InjectedDelegateField((nint)Unsafe.AsPointer(ref position), renderer, (nint)Unsafe.AsPointer(ref probe));
	}

	public static bool AreLightProbesAllowed_Injected(System.IntPtr renderer)
	{
		return AreLightProbesAllowed_InjectedDelegateField(renderer);
	}

	public unsafe static void CalculateInterpolatedLightAndOcclusionProbes_Internal_Injected(ref ManagedSpanWrapper positions, int positionsCount, ref ManagedSpanWrapper lightProbes, ref ManagedSpanWrapper occlusionProbes)
	{
		CalculateInterpolatedLightAndOcclusionProbes_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref positions), positionsCount, (nint)Unsafe.AsPointer(ref lightProbes), (nint)Unsafe.AsPointer(ref occlusionProbes));
	}

	public unsafe static System.IntPtr GetSharedLightProbesForScene_Injected([In] ref Scene scene)
	{
		return GetSharedLightProbesForScene_InjectedDelegateField((nint)Unsafe.AsPointer(ref scene));
	}

	public unsafe static System.IntPtr GetInstantiatedLightProbesForScene_Injected([In] ref Scene scene)
	{
		return GetInstantiatedLightProbesForScene_InjectedDelegateField((nint)Unsafe.AsPointer(ref scene));
	}

	public unsafe static void get_positions_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		get_positions_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetPositionsSelf_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		GetPositionsSelf_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static bool SetPositionsSelf_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper positions, bool checkForDuplicatePositions)
	{
		return SetPositionsSelf_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref positions), checkForDuplicatePositions);
	}

	public unsafe static void get_bakedProbes_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		get_bakedProbes_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_bakedProbes_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_bakedProbes_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static int get_count_Injected(System.IntPtr _unity_self)
	{
		return get_count_InjectedDelegateField(_unity_self);
	}

	public static int get_countSelf_Injected(System.IntPtr _unity_self)
	{
		return get_countSelf_InjectedDelegateField(_unity_self);
	}

	public static int get_cellCount_Injected(System.IntPtr _unity_self)
	{
		return get_cellCount_InjectedDelegateField(_unity_self);
	}

	public static int get_cellCountSelf_Injected(System.IntPtr _unity_self)
	{
		return get_cellCountSelf_InjectedDelegateField(_unity_self);
	}
}
