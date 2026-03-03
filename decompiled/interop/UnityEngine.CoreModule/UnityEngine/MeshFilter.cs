using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class MeshFilter : Component
{
	private delegate IntPtr get_sharedMesh_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_mesh_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private static readonly IntPtr NativeMethodInfoPtr_DontStripMeshFilter_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_sharedMesh_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly get_sharedMesh_InjectedDelegate get_sharedMesh_InjectedDelegateField;

	private static readonly set_mesh_InjectedDelegate set_mesh_InjectedDelegateField;

	public unsafe Mesh sharedMesh
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Mesh>(get_sharedMesh_Injected(intPtr));
		}
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1178065, RefRangeEnd = 1178078, XrefRangeStart = 1178057, XrefRangeEnd = 1178065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Mesh mesh
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1178086, RefRangeEnd = 1178101, XrefRangeStart = 1178078, XrefRangeEnd = 1178086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_mesh_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	static MeshFilter()
	{
		Il2CppClassPointerStore<MeshFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MeshFilter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr);
		NativeMethodInfoPtr_DontStripMeshFilter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100664922);
		NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100664923);
		NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100664924);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100664925);
		NativeMethodInfoPtr_set_sharedMesh_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100664926);
		NativeMethodInfoPtr_get_mesh_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100664927);
		get_sharedMesh_InjectedDelegateField = IL2CPP.ResolveICall<get_sharedMesh_InjectedDelegate>("UnityEngine.MeshFilter::get_sharedMesh_Injected");
		set_mesh_InjectedDelegateField = IL2CPP.ResolveICall<set_mesh_InjectedDelegate>("UnityEngine.MeshFilter::set_mesh_Injected");
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DontStripMeshFilter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DontStripMeshFilter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MeshFilter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178101, XrefRangeEnd = 1178103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sharedMesh_Injected_Private_Static_Void_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178103, XrefRangeEnd = 1178105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr get_mesh_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mesh_Injected_Private_Static_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public MeshFilter(IntPtr pointer)
		: base(pointer)
	{
	}

	public static IntPtr get_sharedMesh_Injected(IntPtr _unity_self)
	{
		return get_sharedMesh_InjectedDelegateField(_unity_self);
	}

	public static void set_mesh_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_mesh_InjectedDelegateField(_unity_self, value);
	}
}
