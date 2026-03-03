using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct SubMeshDescriptor
{
	private static readonly System.IntPtr NativeFieldInfoPtr__bounds_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__topology_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__indexStart_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__indexCount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__baseVertex_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__firstVertex_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__vertexCount_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_topology_Public_get_MeshTopology_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_indexStart_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_baseVertex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_firstVertex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	[FieldOffset(0)]
	public Bounds _bounds_k__BackingField;

	[FieldOffset(24)]
	public MeshTopology _topology_k__BackingField;

	[FieldOffset(28)]
	public int _indexStart_k__BackingField;

	[FieldOffset(32)]
	public int _indexCount_k__BackingField;

	[FieldOffset(36)]
	public int _baseVertex_k__BackingField;

	[FieldOffset(40)]
	public int _firstVertex_k__BackingField;

	[FieldOffset(44)]
	public int _vertexCount_k__BackingField;

	public unsafe Bounds bounds
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_bounds_k__BackingField = value;
		}
	}

	public unsafe MeshTopology topology
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_topology_Public_get_MeshTopology_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(MeshTopology*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_topology_k__BackingField = value;
		}
	}

	public unsafe int indexStart
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_indexStart_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_indexStart_k__BackingField = value;
		}
	}

	public unsafe int indexCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_indexCount_k__BackingField = value;
		}
	}

	public unsafe int baseVertex
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_baseVertex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_baseVertex_k__BackingField = value;
		}
	}

	public unsafe int firstVertex
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80842, RefRangeEnd = 80843, XrefRangeStart = 80842, XrefRangeEnd = 80843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_firstVertex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_firstVertex_k__BackingField = value;
		}
	}

	public unsafe int vertexCount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_vertexCount_k__BackingField = value;
		}
	}

	static SubMeshDescriptor()
	{
		Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SubMeshDescriptor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr);
		NativeFieldInfoPtr__bounds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<bounds>k__BackingField");
		NativeFieldInfoPtr__topology_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<topology>k__BackingField");
		NativeFieldInfoPtr__indexStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<indexStart>k__BackingField");
		NativeFieldInfoPtr__indexCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<indexCount>k__BackingField");
		NativeFieldInfoPtr__baseVertex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<baseVertex>k__BackingField");
		NativeFieldInfoPtr__firstVertex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<firstVertex>k__BackingField");
		NativeFieldInfoPtr__vertexCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<vertexCount>k__BackingField");
		NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667662);
		NativeMethodInfoPtr_get_topology_Public_get_MeshTopology_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667663);
		NativeMethodInfoPtr_get_indexStart_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667664);
		NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667665);
		NativeMethodInfoPtr_get_baseVertex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667666);
		NativeMethodInfoPtr_get_firstVertex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667667);
		NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667668);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667669);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231817, XrefRangeEnd = 1231853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
