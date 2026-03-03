using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.XR;

public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor>
{
	[StructLayout(LayoutKind.Explicit)]
	public struct MeshTransformList
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Self;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Static_Void_IntPtr_0;

		[FieldOffset(0)]
		public readonly System.IntPtr m_Self;

		static MeshTransformList()
		{
			Il2CppClassPointerStore<MeshTransformList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr, "MeshTransformList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshTransformList>.NativeClassPtr);
			NativeFieldInfoPtr_m_Self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTransformList>.NativeClassPtr, "m_Self");
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTransformList>.NativeClassPtr, 100663403);
			NativeMethodInfoPtr_Dispose_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTransformList>.NativeClassPtr, 100663404);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411317, XrefRangeEnd = 1411319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411319, XrefRangeEnd = 1411321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose(System.IntPtr self)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&self);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MeshTransformList>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public new static class BindingsMarshaller
	{
	}

	private delegate bool GetMeshInfosAsList_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr meshInfos);

	private delegate void GetMeshInfosAsFixedArray_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void GenerateMeshAsync_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr meshId, System.IntPtr mesh, System.IntPtr meshCollider, MeshVertexAttributes attributes, System.IntPtr onMeshGenerationComplete, MeshGenerationOptions options);

	private delegate float get_meshDensity_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_meshDensity_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool SetBoundingVolume_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr origin, [In] System.IntPtr extents);

	private delegate System.IntPtr GetUpdatedMeshTransforms_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeMeshReadyDelegate_Private_Void_MeshGenerationResult_Action_1_MeshGenerationResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly GetMeshInfosAsList_InjectedDelegate GetMeshInfosAsList_InjectedDelegateField;

	private static readonly GetMeshInfosAsFixedArray_InjectedDelegate GetMeshInfosAsFixedArray_InjectedDelegateField;

	private static readonly GenerateMeshAsync_InjectedDelegate GenerateMeshAsync_InjectedDelegateField;

	private static readonly get_meshDensity_InjectedDelegate get_meshDensity_InjectedDelegateField;

	private static readonly set_meshDensity_InjectedDelegate set_meshDensity_InjectedDelegateField;

	private static readonly SetBoundingVolume_InjectedDelegate SetBoundingVolume_InjectedDelegateField;

	private static readonly GetUpdatedMeshTransforms_InjectedDelegate GetUpdatedMeshTransforms_InjectedDelegateField;

	public float meshDensity
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_meshDensity_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_meshDensity_Injected(intPtr, value);
		}
	}

	static XRMeshSubsystem()
	{
		Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRMeshSubsystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr);
		NativeMethodInfoPtr_InvokeMeshReadyDelegate_Private_Void_MeshGenerationResult_Action_1_MeshGenerationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr, 100663402);
		GetMeshInfosAsList_InjectedDelegateField = IL2CPP.ResolveICall<GetMeshInfosAsList_InjectedDelegate>("UnityEngine.XR.XRMeshSubsystem::GetMeshInfosAsList_Injected");
		GetMeshInfosAsFixedArray_InjectedDelegateField = IL2CPP.ResolveICall<GetMeshInfosAsFixedArray_InjectedDelegate>("UnityEngine.XR.XRMeshSubsystem::GetMeshInfosAsFixedArray_Injected");
		GenerateMeshAsync_InjectedDelegateField = IL2CPP.ResolveICall<GenerateMeshAsync_InjectedDelegate>("UnityEngine.XR.XRMeshSubsystem::GenerateMeshAsync_Injected");
		get_meshDensity_InjectedDelegateField = IL2CPP.ResolveICall<get_meshDensity_InjectedDelegate>("UnityEngine.XR.XRMeshSubsystem::get_meshDensity_Injected");
		set_meshDensity_InjectedDelegateField = IL2CPP.ResolveICall<set_meshDensity_InjectedDelegate>("UnityEngine.XR.XRMeshSubsystem::set_meshDensity_Injected");
		SetBoundingVolume_InjectedDelegateField = IL2CPP.ResolveICall<SetBoundingVolume_InjectedDelegate>("UnityEngine.XR.XRMeshSubsystem::SetBoundingVolume_Injected");
		GetUpdatedMeshTransforms_InjectedDelegateField = IL2CPP.ResolveICall<GetUpdatedMeshTransforms_InjectedDelegate>("UnityEngine.XR.XRMeshSubsystem::GetUpdatedMeshTransforms_Injected");
	}

	[CallerCount(0)]
	public unsafe void InvokeMeshReadyDelegate(MeshGenerationResult result, Il2CppSystem.Action<MeshGenerationResult> onMeshGenerationComplete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onMeshGenerationComplete);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeMeshReadyDelegate_Private_Void_MeshGenerationResult_Action_1_MeshGenerationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411321, XrefRangeEnd = 1411324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XRMeshSubsystem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRMeshSubsystem(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void GenerateMeshAsync(MeshId meshId, Mesh mesh, MeshCollider meshCollider, MeshVertexAttributes attributes, Il2CppSystem.Action<MeshGenerationResult> onMeshGenerationComplete)
	{
		GenerateMeshAsync(meshId, mesh, meshCollider, attributes, onMeshGenerationComplete, MeshGenerationOptions.None);
	}

	public void GenerateMeshAsync(MeshId meshId, Mesh mesh, MeshCollider meshCollider, MeshVertexAttributes attributes, Il2CppSystem.Action<MeshGenerationResult> onMeshGenerationComplete, MeshGenerationOptions options)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GenerateMeshAsync_Injected(intPtr, ref meshId, Object.MarshalledUnityObject.Marshal(mesh), Object.MarshalledUnityObject.Marshal(meshCollider), attributes, onMeshGenerationComplete, options);
	}

	public bool SetBoundingVolume(Vector3 origin, Vector3 extents)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetBoundingVolume_Injected(intPtr, ref origin, ref extents);
	}

	public System.IntPtr GetUpdatedMeshTransforms()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetUpdatedMeshTransforms_Injected(intPtr);
	}

	public unsafe static bool GetMeshInfosAsList_Injected(System.IntPtr _unity_self, ref BlittableListWrapper meshInfos)
	{
		return GetMeshInfosAsList_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref meshInfos));
	}

	public unsafe static void GetMeshInfosAsFixedArray_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		GetMeshInfosAsFixedArray_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GenerateMeshAsync_Injected(System.IntPtr _unity_self, [In] ref MeshId meshId, System.IntPtr mesh, System.IntPtr meshCollider, MeshVertexAttributes attributes, Il2CppSystem.Action<MeshGenerationResult> onMeshGenerationComplete, MeshGenerationOptions options)
	{
		GenerateMeshAsync_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref meshId), mesh, meshCollider, attributes, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onMeshGenerationComplete), options);
	}

	public static float get_meshDensity_Injected(System.IntPtr _unity_self)
	{
		return get_meshDensity_InjectedDelegateField(_unity_self);
	}

	public static void set_meshDensity_Injected(System.IntPtr _unity_self, float value)
	{
		set_meshDensity_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static bool SetBoundingVolume_Injected(System.IntPtr _unity_self, [In] ref Vector3 origin, [In] ref Vector3 extents)
	{
		return SetBoundingVolume_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref origin), (nint)Unsafe.AsPointer(ref extents));
	}

	public static System.IntPtr GetUpdatedMeshTransforms_Injected(System.IntPtr _unity_self)
	{
		return GetUpdatedMeshTransforms_InjectedDelegateField(_unity_self);
	}
}
