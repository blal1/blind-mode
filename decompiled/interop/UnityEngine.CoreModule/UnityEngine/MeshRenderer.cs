using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine;

public class MeshRenderer : Renderer
{
	private delegate IntPtr get_additionalVertexStreams_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_additionalVertexStreams_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate IntPtr get_enlightenVertexStream_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_enlightenVertexStream_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate int get_subMeshStartIndex_InjectedDelegate(IntPtr _unity_self);

	private static readonly IntPtr NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly get_additionalVertexStreams_InjectedDelegate get_additionalVertexStreams_InjectedDelegateField;

	private static readonly set_additionalVertexStreams_InjectedDelegate set_additionalVertexStreams_InjectedDelegateField;

	private static readonly get_enlightenVertexStream_InjectedDelegate get_enlightenVertexStream_InjectedDelegateField;

	private static readonly set_enlightenVertexStream_InjectedDelegate set_enlightenVertexStream_InjectedDelegateField;

	private static readonly get_subMeshStartIndex_InjectedDelegate get_subMeshStartIndex_InjectedDelegateField;

	public Mesh additionalVertexStreams
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Mesh>(get_additionalVertexStreams_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_additionalVertexStreams_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Mesh enlightenVertexStream
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Mesh>(get_enlightenVertexStream_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enlightenVertexStream_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public int subMeshStartIndex
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_subMeshStartIndex_Injected(intPtr);
		}
	}

	static MeshRenderer()
	{
		Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MeshRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr);
		NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100664931);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100664932);
		get_additionalVertexStreams_InjectedDelegateField = IL2CPP.ResolveICall<get_additionalVertexStreams_InjectedDelegate>("UnityEngine.MeshRenderer::get_additionalVertexStreams_Injected");
		set_additionalVertexStreams_InjectedDelegateField = IL2CPP.ResolveICall<set_additionalVertexStreams_InjectedDelegate>("UnityEngine.MeshRenderer::set_additionalVertexStreams_Injected");
		get_enlightenVertexStream_InjectedDelegateField = IL2CPP.ResolveICall<get_enlightenVertexStream_InjectedDelegate>("UnityEngine.MeshRenderer::get_enlightenVertexStream_Injected");
		set_enlightenVertexStream_InjectedDelegateField = IL2CPP.ResolveICall<set_enlightenVertexStream_InjectedDelegate>("UnityEngine.MeshRenderer::set_enlightenVertexStream_Injected");
		get_subMeshStartIndex_InjectedDelegateField = IL2CPP.ResolveICall<get_subMeshStartIndex_InjectedDelegate>("UnityEngine.MeshRenderer::get_subMeshStartIndex_Injected");
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DontStripMeshRenderer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MeshRenderer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MeshRenderer(IntPtr pointer)
		: base(pointer)
	{
	}

	public static IntPtr get_additionalVertexStreams_Injected(IntPtr _unity_self)
	{
		return get_additionalVertexStreams_InjectedDelegateField(_unity_self);
	}

	public static void set_additionalVertexStreams_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_additionalVertexStreams_InjectedDelegateField(_unity_self, value);
	}

	public static IntPtr get_enlightenVertexStream_Injected(IntPtr _unity_self)
	{
		return get_enlightenVertexStream_InjectedDelegateField(_unity_self);
	}

	public static void set_enlightenVertexStream_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_enlightenVertexStream_InjectedDelegateField(_unity_self, value);
	}

	public static int get_subMeshStartIndex_Injected(IntPtr _unity_self)
	{
		return get_subMeshStartIndex_InjectedDelegateField(_unity_self);
	}
}
