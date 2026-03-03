using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class SkinnedMeshRenderer : Renderer
{
	private delegate SkinQuality get_quality_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_quality_InjectedDelegate(System.IntPtr _unity_self, SkinQuality value);

	private delegate bool get_updateWhenOffscreen_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_updateWhenOffscreen_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_forceMatrixRecalculationPerRender_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_forceMatrixRecalculationPerRender_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void set_rootBone_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate System.IntPtr get_bones_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bones_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate System.IntPtr get_sharedMesh_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_sharedMesh_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate bool get_skinnedMotionVectors_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_skinnedMotionVectors_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float GetBlendShapeWeight_InjectedDelegate(System.IntPtr _unity_self, int index);

	private delegate void SetBlendShapeWeight_InjectedDelegate(System.IntPtr _unity_self, int index, float value);

	private delegate void BakeMesh_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr mesh, bool useScale);

	private delegate System.IntPtr GetVertexBufferImpl_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetPreviousVertexBufferImpl_InjectedDelegate(System.IntPtr _unity_self);

	private delegate GraphicsBuffer.Target get_vertexBufferTarget_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_vertexBufferTarget_InjectedDelegate(System.IntPtr _unity_self, GraphicsBuffer.Target value);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rootBone_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rootBone_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly get_quality_InjectedDelegate get_quality_InjectedDelegateField;

	private static readonly set_quality_InjectedDelegate set_quality_InjectedDelegateField;

	private static readonly get_updateWhenOffscreen_InjectedDelegate get_updateWhenOffscreen_InjectedDelegateField;

	private static readonly set_updateWhenOffscreen_InjectedDelegate set_updateWhenOffscreen_InjectedDelegateField;

	private static readonly get_forceMatrixRecalculationPerRender_InjectedDelegate get_forceMatrixRecalculationPerRender_InjectedDelegateField;

	private static readonly set_forceMatrixRecalculationPerRender_InjectedDelegate set_forceMatrixRecalculationPerRender_InjectedDelegateField;

	private static readonly set_rootBone_InjectedDelegate set_rootBone_InjectedDelegateField;

	private static readonly get_bones_InjectedDelegate get_bones_InjectedDelegateField;

	private static readonly set_bones_InjectedDelegate set_bones_InjectedDelegateField;

	private static readonly get_sharedMesh_InjectedDelegate get_sharedMesh_InjectedDelegateField;

	private static readonly set_sharedMesh_InjectedDelegate set_sharedMesh_InjectedDelegateField;

	private static readonly get_skinnedMotionVectors_InjectedDelegate get_skinnedMotionVectors_InjectedDelegateField;

	private static readonly set_skinnedMotionVectors_InjectedDelegate set_skinnedMotionVectors_InjectedDelegateField;

	private static readonly GetBlendShapeWeight_InjectedDelegate GetBlendShapeWeight_InjectedDelegateField;

	private static readonly SetBlendShapeWeight_InjectedDelegate SetBlendShapeWeight_InjectedDelegateField;

	private static readonly BakeMesh_InjectedDelegate BakeMesh_InjectedDelegateField;

	private static readonly GetVertexBufferImpl_InjectedDelegate GetVertexBufferImpl_InjectedDelegateField;

	private static readonly GetPreviousVertexBufferImpl_InjectedDelegate GetPreviousVertexBufferImpl_InjectedDelegateField;

	private static readonly get_vertexBufferTarget_InjectedDelegate get_vertexBufferTarget_InjectedDelegateField;

	private static readonly set_vertexBufferTarget_InjectedDelegate set_vertexBufferTarget_InjectedDelegateField;

	public unsafe Transform rootBone
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1178113, RefRangeEnd = 1178114, XrefRangeStart = 1178105, XrefRangeEnd = 1178113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rootBone_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_rootBone_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public SkinQuality quality
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_quality_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_quality_Injected(intPtr, value);
		}
	}

	public bool updateWhenOffscreen
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_updateWhenOffscreen_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_updateWhenOffscreen_Injected(intPtr, value);
		}
	}

	public bool forceMatrixRecalculationPerRender
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_forceMatrixRecalculationPerRender_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceMatrixRecalculationPerRender_Injected(intPtr, value);
		}
	}

	public Il2CppReferenceArray<Transform> bones
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bones_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bones_Injected(intPtr, value);
		}
	}

	public Mesh sharedMesh
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Mesh>(get_sharedMesh_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sharedMesh_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public bool skinnedMotionVectors
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_skinnedMotionVectors_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_skinnedMotionVectors_Injected(intPtr, value);
		}
	}

	public GraphicsBuffer.Target vertexBufferTarget
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_vertexBufferTarget_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_vertexBufferTarget_Injected(intPtr, value);
		}
	}

	static SkinnedMeshRenderer()
	{
		Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SkinnedMeshRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr);
		NativeMethodInfoPtr_get_rootBone_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100664928);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100664929);
		NativeMethodInfoPtr_get_rootBone_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100664930);
		get_quality_InjectedDelegateField = IL2CPP.ResolveICall<get_quality_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::get_quality_Injected");
		set_quality_InjectedDelegateField = IL2CPP.ResolveICall<set_quality_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::set_quality_Injected");
		get_updateWhenOffscreen_InjectedDelegateField = IL2CPP.ResolveICall<get_updateWhenOffscreen_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::get_updateWhenOffscreen_Injected");
		set_updateWhenOffscreen_InjectedDelegateField = IL2CPP.ResolveICall<set_updateWhenOffscreen_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::set_updateWhenOffscreen_Injected");
		get_forceMatrixRecalculationPerRender_InjectedDelegateField = IL2CPP.ResolveICall<get_forceMatrixRecalculationPerRender_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::get_forceMatrixRecalculationPerRender_Injected");
		set_forceMatrixRecalculationPerRender_InjectedDelegateField = IL2CPP.ResolveICall<set_forceMatrixRecalculationPerRender_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::set_forceMatrixRecalculationPerRender_Injected");
		set_rootBone_InjectedDelegateField = IL2CPP.ResolveICall<set_rootBone_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::set_rootBone_Injected");
		get_bones_InjectedDelegateField = IL2CPP.ResolveICall<get_bones_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::get_bones_Injected");
		set_bones_InjectedDelegateField = IL2CPP.ResolveICall<set_bones_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::set_bones_Injected");
		get_sharedMesh_InjectedDelegateField = IL2CPP.ResolveICall<get_sharedMesh_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::get_sharedMesh_Injected");
		set_sharedMesh_InjectedDelegateField = IL2CPP.ResolveICall<set_sharedMesh_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::set_sharedMesh_Injected");
		get_skinnedMotionVectors_InjectedDelegateField = IL2CPP.ResolveICall<get_skinnedMotionVectors_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::get_skinnedMotionVectors_Injected");
		set_skinnedMotionVectors_InjectedDelegateField = IL2CPP.ResolveICall<set_skinnedMotionVectors_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::set_skinnedMotionVectors_Injected");
		GetBlendShapeWeight_InjectedDelegateField = IL2CPP.ResolveICall<GetBlendShapeWeight_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::GetBlendShapeWeight_Injected");
		SetBlendShapeWeight_InjectedDelegateField = IL2CPP.ResolveICall<SetBlendShapeWeight_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::SetBlendShapeWeight_Injected");
		BakeMesh_InjectedDelegateField = IL2CPP.ResolveICall<BakeMesh_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::BakeMesh_Injected");
		GetVertexBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetVertexBufferImpl_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::GetVertexBufferImpl_Injected");
		GetPreviousVertexBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetPreviousVertexBufferImpl_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::GetPreviousVertexBufferImpl_Injected");
		get_vertexBufferTarget_InjectedDelegateField = IL2CPP.ResolveICall<get_vertexBufferTarget_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::get_vertexBufferTarget_Injected");
		set_vertexBufferTarget_InjectedDelegateField = IL2CPP.ResolveICall<set_vertexBufferTarget_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::set_vertexBufferTarget_Injected");
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkinnedMeshRenderer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178114, XrefRangeEnd = 1178116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_rootBone_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rootBone_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SkinnedMeshRenderer(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public float GetBlendShapeWeight(int index)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetBlendShapeWeight_Injected(intPtr, index);
	}

	public void SetBlendShapeWeight(int index, float value)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetBlendShapeWeight_Injected(intPtr, index, value);
	}

	public void BakeMesh(Mesh mesh)
	{
		BakeMesh(mesh, useScale: false);
	}

	public void BakeMesh(Mesh mesh, bool useScale)
	{
		if ((object)mesh == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mesh, "mesh");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = MarshalledUnityObject.MarshalNotNull(mesh);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mesh, "mesh");
		}
		BakeMesh_Injected(intPtr, intPtr2, useScale);
	}

	public GraphicsBuffer GetVertexBuffer()
	{
		if (this == null)
		{
			throw new Il2CppSystem.NullReferenceException();
		}
		return GetVertexBufferImpl();
	}

	public GraphicsBuffer GetPreviousVertexBuffer()
	{
		if (this == null)
		{
			throw new Il2CppSystem.NullReferenceException();
		}
		return GetPreviousVertexBufferImpl();
	}

	public GraphicsBuffer GetVertexBufferImpl()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr vertexBufferImpl_Injected = GetVertexBufferImpl_Injected(intPtr);
		return (vertexBufferImpl_Injected == (System.IntPtr)0) ? null : GraphicsBuffer.BindingsMarshaller.ConvertToManaged(vertexBufferImpl_Injected);
	}

	public GraphicsBuffer GetPreviousVertexBufferImpl()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr previousVertexBufferImpl_Injected = GetPreviousVertexBufferImpl_Injected(intPtr);
		return (previousVertexBufferImpl_Injected == (System.IntPtr)0) ? null : GraphicsBuffer.BindingsMarshaller.ConvertToManaged(previousVertexBufferImpl_Injected);
	}

	public static SkinQuality get_quality_Injected(System.IntPtr _unity_self)
	{
		return get_quality_InjectedDelegateField(_unity_self);
	}

	public static void set_quality_Injected(System.IntPtr _unity_self, SkinQuality value)
	{
		set_quality_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_updateWhenOffscreen_Injected(System.IntPtr _unity_self)
	{
		return get_updateWhenOffscreen_InjectedDelegateField(_unity_self);
	}

	public static void set_updateWhenOffscreen_Injected(System.IntPtr _unity_self, bool value)
	{
		set_updateWhenOffscreen_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_forceMatrixRecalculationPerRender_Injected(System.IntPtr _unity_self)
	{
		return get_forceMatrixRecalculationPerRender_InjectedDelegateField(_unity_self);
	}

	public static void set_forceMatrixRecalculationPerRender_Injected(System.IntPtr _unity_self, bool value)
	{
		set_forceMatrixRecalculationPerRender_InjectedDelegateField(_unity_self, value);
	}

	public static void set_rootBone_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_rootBone_InjectedDelegateField(_unity_self, value);
	}

	public static Il2CppReferenceArray<Transform> get_bones_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = get_bones_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr) : null;
	}

	public static void set_bones_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<Transform> value)
	{
		set_bones_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
	}

	public static System.IntPtr get_sharedMesh_Injected(System.IntPtr _unity_self)
	{
		return get_sharedMesh_InjectedDelegateField(_unity_self);
	}

	public static void set_sharedMesh_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_sharedMesh_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_skinnedMotionVectors_Injected(System.IntPtr _unity_self)
	{
		return get_skinnedMotionVectors_InjectedDelegateField(_unity_self);
	}

	public static void set_skinnedMotionVectors_Injected(System.IntPtr _unity_self, bool value)
	{
		set_skinnedMotionVectors_InjectedDelegateField(_unity_self, value);
	}

	public static float GetBlendShapeWeight_Injected(System.IntPtr _unity_self, int index)
	{
		return GetBlendShapeWeight_InjectedDelegateField(_unity_self, index);
	}

	public static void SetBlendShapeWeight_Injected(System.IntPtr _unity_self, int index, float value)
	{
		SetBlendShapeWeight_InjectedDelegateField(_unity_self, index, value);
	}

	public static void BakeMesh_Injected(System.IntPtr _unity_self, System.IntPtr mesh, bool useScale)
	{
		BakeMesh_InjectedDelegateField(_unity_self, mesh, useScale);
	}

	public static System.IntPtr GetVertexBufferImpl_Injected(System.IntPtr _unity_self)
	{
		return GetVertexBufferImpl_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr GetPreviousVertexBufferImpl_Injected(System.IntPtr _unity_self)
	{
		return GetPreviousVertexBufferImpl_InjectedDelegateField(_unity_self);
	}

	public static GraphicsBuffer.Target get_vertexBufferTarget_Injected(System.IntPtr _unity_self)
	{
		return get_vertexBufferTarget_InjectedDelegateField(_unity_self);
	}

	public static void set_vertexBufferTarget_Injected(System.IntPtr _unity_self, GraphicsBuffer.Target value)
	{
		set_vertexBufferTarget_InjectedDelegateField(_unity_self, value);
	}
}
