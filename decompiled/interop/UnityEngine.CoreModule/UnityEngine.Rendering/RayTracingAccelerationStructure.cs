using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

public sealed class RayTracingAccelerationStructure : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct BuildSettings
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__buildFlags_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__relativeOrigin_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_buildFlags_Public_set_Void_RayTracingAccelerationStructureBuildFlags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_relativeOrigin_Public_set_Void_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[FieldOffset(0)]
		public RayTracingAccelerationStructureBuildFlags _buildFlags_k__BackingField;

		[FieldOffset(4)]
		public Vector3 _relativeOrigin_k__BackingField;

		public unsafe RayTracingAccelerationStructureBuildFlags buildFlags
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_buildFlags_Public_set_Void_RayTracingAccelerationStructureBuildFlags_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe Vector3 relativeOrigin
		{
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_relativeOrigin_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static BuildSettings()
		{
			Il2CppClassPointerStore<BuildSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, "BuildSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildSettings>.NativeClassPtr);
			NativeFieldInfoPtr__buildFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildSettings>.NativeClassPtr, "<buildFlags>k__BackingField");
			NativeFieldInfoPtr__relativeOrigin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildSettings>.NativeClassPtr, "<relativeOrigin>k__BackingField");
			NativeMethodInfoPtr_set_buildFlags_Public_set_Void_RayTracingAccelerationStructureBuildFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildSettings>.NativeClassPtr, 100667752);
			NativeMethodInfoPtr_set_relativeOrigin_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildSettings>.NativeClassPtr, 100667753);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildSettings>.NativeClassPtr, 100667754);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232555, XrefRangeEnd = 1232557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildSettings()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_RayTracingAccelerationStructure_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_RayTracingAccelerationStructure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100667755);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(RayTracingAccelerationStructure rayTracingAccelerationStructure)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rayTracingAccelerationStructure);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_RayTracingAccelerationStructure_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum RayTracingModeMask
	{
		Nothing = 0,
		Static = 2,
		DynamicTransform = 4,
		DynamicGeometry = 8,
		Everything = 14
	}

	public enum ManagementMode
	{
		Manual,
		Automatic
	}

	private delegate void Build_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr buildSettings);

	private delegate void AddVFXInstances_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr targetRenderer, System.IntPtr vfxSystemMasks);

	private delegate void RemoveVFXInstances_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr targetRenderer);

	private delegate void UpdateInstancePropertyBlock_InjectedDelegate(System.IntPtr _unity_self, int handle, System.IntPtr properties);

	private delegate ulong GetSize_InjectedDelegate(System.IntPtr _unity_self);

	private delegate uint GetInstanceCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ClearInstances_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void RemoveInstance_Renderer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr targetRenderer);

	private delegate void RemoveInstance_InstanceID_InjectedDelegate(System.IntPtr _unity_self, int instanceID);

	private delegate void UpdateInstanceTransform_Renderer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr renderer);

	private delegate void UpdateInstanceTransform_Handle_InjectedDelegate(System.IntPtr _unity_self, int handle, [In] System.IntPtr matrix);

	private delegate void UpdateInstanceMask_Renderer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr renderer, uint mask);

	private delegate void UpdateInstanceMask_Handle_InjectedDelegate(System.IntPtr _unity_self, int handle, uint mask);

	private delegate void UpdateInstanceID_Renderer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr renderer, uint id);

	private delegate void UpdateInstanceID_Handle_InjectedDelegate(System.IntPtr _unity_self, int handle, uint id);

	private delegate int AddInstanceSubMeshFlagsArray_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr targetRenderer, System.IntPtr subMeshFlags, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, uint id);

	private delegate bool CheckMaterialEnablesInstancing_InjectedDelegate(System.IntPtr material);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Static_Void_RayTracingAccelerationStructure_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Injected_Private_Static_Void_IntPtr_0;

	public const string obsoleteBuildMsg1 = "Method Update is deprecated and it will be removed in Unity 2024.1. Use Build instead (UnityUpgradable) -> Build()";

	public const string obsoleteBuildMsg2 = "Method Update is deprecated and it will be removed in Unity 2024.1. Use Build instead (UnityUpgradable) -> Build(*)";

	public const string obsoleteRendererMsg = "This AddInstance method is deprecated and will be removed and it will be removed in Unity 2024.1. Please use the alternative AddInstance method for adding Renderers to the acceleration structure.";

	public const string obsoleteAABBMsg1 = "This AddInstance method is deprecated and it will be removed in Unity 2024.1. Please use the alternative AddInstance method for adding procedural geometry (AABBs) to the acceleration structure.";

	public const string obsoleteAABBMsg2 = "This AddInstance method is deprecated and it will be removed in Unity 2024.1. Please use the alternative AddInstance method for adding procedural geometry (AABBs) to the acceleration structure.";

	private static readonly Build_InjectedDelegate Build_InjectedDelegateField;

	private static readonly AddVFXInstances_InjectedDelegate AddVFXInstances_InjectedDelegateField;

	private static readonly RemoveVFXInstances_InjectedDelegate RemoveVFXInstances_InjectedDelegateField;

	private static readonly UpdateInstancePropertyBlock_InjectedDelegate UpdateInstancePropertyBlock_InjectedDelegateField;

	private static readonly GetSize_InjectedDelegate GetSize_InjectedDelegateField;

	private static readonly GetInstanceCount_InjectedDelegate GetInstanceCount_InjectedDelegateField;

	private static readonly ClearInstances_InjectedDelegate ClearInstances_InjectedDelegateField;

	private static readonly RemoveInstance_Renderer_InjectedDelegate RemoveInstance_Renderer_InjectedDelegateField;

	private static readonly RemoveInstance_InstanceID_InjectedDelegate RemoveInstance_InstanceID_InjectedDelegateField;

	private static readonly UpdateInstanceTransform_Renderer_InjectedDelegate UpdateInstanceTransform_Renderer_InjectedDelegateField;

	private static readonly UpdateInstanceTransform_Handle_InjectedDelegate UpdateInstanceTransform_Handle_InjectedDelegateField;

	private static readonly UpdateInstanceMask_Renderer_InjectedDelegate UpdateInstanceMask_Renderer_InjectedDelegateField;

	private static readonly UpdateInstanceMask_Handle_InjectedDelegate UpdateInstanceMask_Handle_InjectedDelegateField;

	private static readonly UpdateInstanceID_Renderer_InjectedDelegate UpdateInstanceID_Renderer_InjectedDelegateField;

	private static readonly UpdateInstanceID_Handle_InjectedDelegate UpdateInstanceID_Handle_InjectedDelegateField;

	private static readonly AddInstanceSubMeshFlagsArray_InjectedDelegate AddInstanceSubMeshFlagsArray_InjectedDelegateField;

	private static readonly CheckMaterialEnablesInstancing_InjectedDelegate CheckMaterialEnablesInstancing_InjectedDelegateField;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	static RayTracingAccelerationStructure()
	{
		Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RayTracingAccelerationStructure");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, "m_Ptr");
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, 100667748);
		NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, 100667749);
		NativeMethodInfoPtr_Destroy_Private_Static_Void_RayTracingAccelerationStructure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, 100667750);
		NativeMethodInfoPtr_Destroy_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, 100667751);
		Build_InjectedDelegateField = IL2CPP.ResolveICall<Build_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::Build_Injected");
		AddVFXInstances_InjectedDelegateField = IL2CPP.ResolveICall<AddVFXInstances_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::AddVFXInstances_Injected");
		RemoveVFXInstances_InjectedDelegateField = IL2CPP.ResolveICall<RemoveVFXInstances_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::RemoveVFXInstances_Injected");
		UpdateInstancePropertyBlock_InjectedDelegateField = IL2CPP.ResolveICall<UpdateInstancePropertyBlock_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstancePropertyBlock_Injected");
		GetSize_InjectedDelegateField = IL2CPP.ResolveICall<GetSize_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::GetSize_Injected");
		GetInstanceCount_InjectedDelegateField = IL2CPP.ResolveICall<GetInstanceCount_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::GetInstanceCount_Injected");
		ClearInstances_InjectedDelegateField = IL2CPP.ResolveICall<ClearInstances_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::ClearInstances_Injected");
		RemoveInstance_Renderer_InjectedDelegateField = IL2CPP.ResolveICall<RemoveInstance_Renderer_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::RemoveInstance_Renderer_Injected");
		RemoveInstance_InstanceID_InjectedDelegateField = IL2CPP.ResolveICall<RemoveInstance_InstanceID_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::RemoveInstance_InstanceID_Injected");
		UpdateInstanceTransform_Renderer_InjectedDelegateField = IL2CPP.ResolveICall<UpdateInstanceTransform_Renderer_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstanceTransform_Renderer_Injected");
		UpdateInstanceTransform_Handle_InjectedDelegateField = IL2CPP.ResolveICall<UpdateInstanceTransform_Handle_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstanceTransform_Handle_Injected");
		UpdateInstanceMask_Renderer_InjectedDelegateField = IL2CPP.ResolveICall<UpdateInstanceMask_Renderer_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstanceMask_Renderer_Injected");
		UpdateInstanceMask_Handle_InjectedDelegateField = IL2CPP.ResolveICall<UpdateInstanceMask_Handle_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstanceMask_Handle_Injected");
		UpdateInstanceID_Renderer_InjectedDelegateField = IL2CPP.ResolveICall<UpdateInstanceID_Renderer_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstanceID_Renderer_Injected");
		UpdateInstanceID_Handle_InjectedDelegateField = IL2CPP.ResolveICall<UpdateInstanceID_Handle_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstanceID_Handle_Injected");
		AddInstanceSubMeshFlagsArray_InjectedDelegateField = IL2CPP.ResolveICall<AddInstanceSubMeshFlagsArray_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::AddInstanceSubMeshFlagsArray_Injected");
		CheckMaterialEnablesInstancing_InjectedDelegateField = IL2CPP.ResolveICall<CheckMaterialEnablesInstancing_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::CheckMaterialEnablesInstancing_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232557, XrefRangeEnd = 1232564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232564, XrefRangeEnd = 1232567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232567, XrefRangeEnd = 1232570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(RayTracingAccelerationStructure accelStruct)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)accelStruct);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Private_Static_Void_RayTracingAccelerationStructure_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232570, XrefRangeEnd = 1232572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy_Injected(System.IntPtr accelStruct)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&accelStruct);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RayTracingAccelerationStructure(System.IntPtr pointer)
		: base(pointer)
	{
	}

	~RayTracingAccelerationStructure()
	{
		Dispose(disposing: false);
	}

	public void Release()
	{
		Dispose();
	}

	public void Build()
	{
		Build(new BuildSettings());
	}

	public void Build(Vector3 relativeOrigin)
	{
		BuildSettings buildSettings = new BuildSettings();
		buildSettings.relativeOrigin = relativeOrigin;
		BuildSettings buildSettings2 = buildSettings;
		Build(buildSettings2);
	}

	public int AddInstance(Renderer targetRenderer, Il2CppStructArray<RayTracingSubMeshFlags> subMeshFlags, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] uint id)
	{
		return AddInstanceSubMeshFlagsArray(targetRenderer, subMeshFlags, enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
	}

	public void RemoveInstance(Renderer targetRenderer)
	{
		RemoveInstance_Renderer(targetRenderer);
	}

	public void RemoveInstance(int handle)
	{
		RemoveInstance_InstanceID(handle);
	}

	public void UpdateInstanceTransform(Renderer renderer)
	{
		UpdateInstanceTransform_Renderer(renderer);
	}

	public void UpdateInstanceTransform(int handle, Matrix4x4 matrix)
	{
		UpdateInstanceTransform_Handle(handle, matrix);
	}

	public void UpdateInstanceID(Renderer renderer, uint instanceID)
	{
		UpdateInstanceID_Renderer(renderer, instanceID);
	}

	public void UpdateInstanceID(int handle, uint instanceID)
	{
		UpdateInstanceID_Handle(handle, instanceID);
	}

	public void UpdateInstanceMask(Renderer renderer, uint mask)
	{
		UpdateInstanceMask_Renderer(renderer, mask);
	}

	public void UpdateInstanceMask(int handle, uint mask)
	{
		UpdateInstanceMask_Handle(handle, mask);
	}

	public void Build(BuildSettings buildSettings)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Build_Injected(intPtr, ref buildSettings);
	}

	public unsafe void AddVFXInstances(Renderer targetRenderer, Il2CppStructArray<uint> vfxSystemMasks)
	{
		//IL_003c: Expected O, but got Ref
		//IL_0043: Expected O, but got Ref
		//IL_004f: Expected O, but got Ref
		if ((object)targetRenderer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(targetRenderer, "targetRenderer");
		}
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(targetRenderer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(targetRenderer, "targetRenderer");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<uint> span);
		((Il2CppSystem.Span<uint>)(&span))._002Ector((Il2CppArrayBase<uint>)(object)vfxSystemMasks);
		fixed (uint* begin = &((Il2CppSystem.Span<uint>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper vfxSystemMasks2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<uint>)(&span)).Length);
			AddVFXInstances_Injected(intPtr, intPtr2, ref vfxSystemMasks2);
		}
	}

	public void RemoveVFXInstances(Renderer targetRenderer)
	{
		if ((object)targetRenderer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(targetRenderer, "targetRenderer");
		}
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(targetRenderer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(targetRenderer, "targetRenderer");
		}
		RemoveVFXInstances_Injected(intPtr, intPtr2);
	}

	public void UpdateInstancePropertyBlock(int handle, MaterialPropertyBlock properties)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		UpdateInstancePropertyBlock_Injected(intPtr, handle, (properties == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties));
	}

	public ulong GetSize()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetSize_Injected(intPtr);
	}

	public uint GetInstanceCount()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetInstanceCount_Injected(intPtr);
	}

	public void ClearInstances()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ClearInstances_Injected(intPtr);
	}

	public void RemoveInstance_Renderer(Renderer targetRenderer)
	{
		if ((object)targetRenderer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(targetRenderer, "targetRenderer");
		}
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(targetRenderer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(targetRenderer, "targetRenderer");
		}
		RemoveInstance_Renderer_Injected(intPtr, intPtr2);
	}

	public void RemoveInstance_InstanceID(int instanceID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RemoveInstance_InstanceID_Injected(intPtr, instanceID);
	}

	public void UpdateInstanceTransform_Renderer(Renderer renderer)
	{
		if ((object)renderer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(renderer, "renderer");
		}
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(renderer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(renderer, "renderer");
		}
		UpdateInstanceTransform_Renderer_Injected(intPtr, intPtr2);
	}

	public void UpdateInstanceTransform_Handle(int handle, Matrix4x4 matrix)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		UpdateInstanceTransform_Handle_Injected(intPtr, handle, ref matrix);
	}

	public void UpdateInstanceMask_Renderer(Renderer renderer, uint mask)
	{
		if ((object)renderer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(renderer, "renderer");
		}
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(renderer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(renderer, "renderer");
		}
		UpdateInstanceMask_Renderer_Injected(intPtr, intPtr2, mask);
	}

	public void UpdateInstanceMask_Handle(int handle, uint mask)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		UpdateInstanceMask_Handle_Injected(intPtr, handle, mask);
	}

	public void UpdateInstanceID_Renderer(Renderer renderer, uint id)
	{
		if ((object)renderer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(renderer, "renderer");
		}
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(renderer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(renderer, "renderer");
		}
		UpdateInstanceID_Renderer_Injected(intPtr, intPtr2, id);
	}

	public void UpdateInstanceID_Handle(int handle, uint id)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		UpdateInstanceID_Handle_Injected(intPtr, handle, id);
	}

	public unsafe int AddInstanceSubMeshFlagsArray(Renderer targetRenderer, Il2CppStructArray<RayTracingSubMeshFlags> subMeshFlags, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] uint id)
	{
		//IL_003c: Expected O, but got Ref
		//IL_0043: Expected O, but got Ref
		//IL_004f: Expected O, but got Ref
		if ((object)targetRenderer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(targetRenderer, "targetRenderer");
		}
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(targetRenderer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(targetRenderer, "targetRenderer");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<RayTracingSubMeshFlags> span);
		((Il2CppSystem.Span<RayTracingSubMeshFlags>)(&span))._002Ector((Il2CppArrayBase<RayTracingSubMeshFlags>)(object)subMeshFlags);
		int result;
		fixed (RayTracingSubMeshFlags* begin = &((Il2CppSystem.Span<RayTracingSubMeshFlags>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper subMeshFlags2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RayTracingSubMeshFlags>)(&span)).Length);
			result = AddInstanceSubMeshFlagsArray_Injected(intPtr, intPtr2, ref subMeshFlags2, enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
		}
		return result;
	}

	public static bool CheckMaterialEnablesInstancing(Material material)
	{
		return CheckMaterialEnablesInstancing_Injected(Object.MarshalledUnityObject.Marshal(material));
	}

	public void Update()
	{
		new Il2CppSystem.NotSupportedException("Method Update is deprecated and it will be removed in Unity 2024.1. Use Build instead (UnityUpgradable) -> Build()");
	}

	public void Update(Vector3 relativeOrigin)
	{
		new Il2CppSystem.NotSupportedException("Method Update is deprecated and it will be removed in Unity 2024.1. Use Build instead (UnityUpgradable) -> Build(*)");
	}

	public void AddInstance(Renderer targetRenderer, [Optional] Il2CppStructArray<bool> subMeshMask, [Optional] Il2CppStructArray<bool> subMeshTransparencyFlags, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] uint id)
	{
		new Il2CppSystem.NotSupportedException("This AddInstance method is deprecated and will be removed and it will be removed in Unity 2024.1. Please use the alternative AddInstance method for adding Renderers to the acceleration structure.");
	}

	public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds, [Optional] uint id)
	{
		new Il2CppSystem.NotSupportedException("This AddInstance method is deprecated and it will be removed in Unity 2024.1. Please use the alternative AddInstance method for adding procedural geometry (AABBs) to the acceleration structure.");
	}

	public int AddInstance(GraphicsBuffer aabbBuffer, uint aabbCount, bool dynamicData, Matrix4x4 matrix, Material material, bool opaqueMaterial, MaterialPropertyBlock properties, [Optional] uint mask, [Optional] uint id)
	{
		throw new Il2CppSystem.NotSupportedException("This AddInstance method is deprecated and it will be removed in Unity 2024.1. Please use the alternative AddInstance method for adding procedural geometry (AABBs) to the acceleration structure.");
	}

	public unsafe static void Build_Injected(System.IntPtr _unity_self, [In] ref BuildSettings buildSettings)
	{
		Build_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref buildSettings));
	}

	public unsafe static void AddVFXInstances_Injected(System.IntPtr _unity_self, System.IntPtr targetRenderer, ref ManagedSpanWrapper vfxSystemMasks)
	{
		AddVFXInstances_InjectedDelegateField(_unity_self, targetRenderer, (nint)Unsafe.AsPointer(ref vfxSystemMasks));
	}

	public static void RemoveVFXInstances_Injected(System.IntPtr _unity_self, System.IntPtr targetRenderer)
	{
		RemoveVFXInstances_InjectedDelegateField(_unity_self, targetRenderer);
	}

	public static void UpdateInstancePropertyBlock_Injected(System.IntPtr _unity_self, int handle, System.IntPtr properties)
	{
		UpdateInstancePropertyBlock_InjectedDelegateField(_unity_self, handle, properties);
	}

	public static ulong GetSize_Injected(System.IntPtr _unity_self)
	{
		return GetSize_InjectedDelegateField(_unity_self);
	}

	public static uint GetInstanceCount_Injected(System.IntPtr _unity_self)
	{
		return GetInstanceCount_InjectedDelegateField(_unity_self);
	}

	public static void ClearInstances_Injected(System.IntPtr _unity_self)
	{
		ClearInstances_InjectedDelegateField(_unity_self);
	}

	public static void RemoveInstance_Renderer_Injected(System.IntPtr _unity_self, System.IntPtr targetRenderer)
	{
		RemoveInstance_Renderer_InjectedDelegateField(_unity_self, targetRenderer);
	}

	public static void RemoveInstance_InstanceID_Injected(System.IntPtr _unity_self, int instanceID)
	{
		RemoveInstance_InstanceID_InjectedDelegateField(_unity_self, instanceID);
	}

	public static void UpdateInstanceTransform_Renderer_Injected(System.IntPtr _unity_self, System.IntPtr renderer)
	{
		UpdateInstanceTransform_Renderer_InjectedDelegateField(_unity_self, renderer);
	}

	public unsafe static void UpdateInstanceTransform_Handle_Injected(System.IntPtr _unity_self, int handle, [In] ref Matrix4x4 matrix)
	{
		UpdateInstanceTransform_Handle_InjectedDelegateField(_unity_self, handle, (nint)Unsafe.AsPointer(ref matrix));
	}

	public static void UpdateInstanceMask_Renderer_Injected(System.IntPtr _unity_self, System.IntPtr renderer, uint mask)
	{
		UpdateInstanceMask_Renderer_InjectedDelegateField(_unity_self, renderer, mask);
	}

	public static void UpdateInstanceMask_Handle_Injected(System.IntPtr _unity_self, int handle, uint mask)
	{
		UpdateInstanceMask_Handle_InjectedDelegateField(_unity_self, handle, mask);
	}

	public static void UpdateInstanceID_Renderer_Injected(System.IntPtr _unity_self, System.IntPtr renderer, uint id)
	{
		UpdateInstanceID_Renderer_InjectedDelegateField(_unity_self, renderer, id);
	}

	public static void UpdateInstanceID_Handle_Injected(System.IntPtr _unity_self, int handle, uint id)
	{
		UpdateInstanceID_Handle_InjectedDelegateField(_unity_self, handle, id);
	}

	public unsafe static int AddInstanceSubMeshFlagsArray_Injected(System.IntPtr _unity_self, System.IntPtr targetRenderer, ref ManagedSpanWrapper subMeshFlags, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, uint id)
	{
		return AddInstanceSubMeshFlagsArray_InjectedDelegateField(_unity_self, targetRenderer, (nint)Unsafe.AsPointer(ref subMeshFlags), enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
	}

	public static bool CheckMaterialEnablesInstancing_Injected(System.IntPtr material)
	{
		return CheckMaterialEnablesInstancing_InjectedDelegateField(material);
	}
}
