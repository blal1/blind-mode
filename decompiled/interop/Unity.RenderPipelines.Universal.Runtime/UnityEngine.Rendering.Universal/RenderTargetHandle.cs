using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

[StructLayout(LayoutKind.Explicit)]
public struct RenderTargetHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr__id_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__rtid_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_CameraTarget;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rtid_Private_set_Void_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rtid_Private_get_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraTarget_Internal_Static_RenderTargetHandle_byref_CameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Identifier_Public_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasInternalRenderTargetId_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_RenderTargetHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetHandle_RenderTargetHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetHandle_RenderTargetHandle_0;

	[FieldOffset(0)]
	public int _id_k__BackingField;

	[FieldOffset(8)]
	public RenderTargetIdentifier _rtid_k__BackingField;

	public unsafe static RenderTargetHandle CameraTarget
	{
		get
		{
			Unsafe.SkipInit(out RenderTargetHandle result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CameraTarget, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CameraTarget, (void*)(&value));
		}
	}

	public unsafe int id
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_id_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RenderTargetIdentifier rtid
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rtid_Private_get_RenderTargetIdentifier_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rtid_Private_set_Void_RenderTargetIdentifier_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static RenderTargetHandle()
	{
		Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RenderTargetHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr);
		NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, "<id>k__BackingField");
		NativeFieldInfoPtr__rtid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, "<rtid>k__BackingField");
		NativeFieldInfoPtr_CameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, "CameraTarget");
		NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665431);
		NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665432);
		NativeMethodInfoPtr_set_rtid_Private_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665433);
		NativeMethodInfoPtr_get_rtid_Private_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665434);
		NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665435);
		NativeMethodInfoPtr__ctor_Public_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665436);
		NativeMethodInfoPtr_GetCameraTarget_Internal_Static_RenderTargetHandle_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665437);
		NativeMethodInfoPtr_Init_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665438);
		NativeMethodInfoPtr_Init_Public_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665439);
		NativeMethodInfoPtr_Identifier_Public_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665440);
		NativeMethodInfoPtr_HasInternalRenderTargetId_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665441);
		NativeMethodInfoPtr_Equals_Public_Boolean_RenderTargetHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665442);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665443);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665444);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetHandle_RenderTargetHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665445);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetHandle_RenderTargetHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665446);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098957, XrefRangeEnd = 1098960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTargetHandle(RenderTargetIdentifier renderTargetIdentifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&renderTargetIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098960, XrefRangeEnd = 1098984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTargetHandle(RTHandle rtHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rtHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RTHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098984, XrefRangeEnd = 1098990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTargetHandle GetCameraTarget(ref CameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraTarget_Internal_Static_RenderTargetHandle_byref_CameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTargetHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098990, XrefRangeEnd = 1098994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(string shaderProperty)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderProperty);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098994, XrefRangeEnd = 1098997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(RenderTargetIdentifier renderTargetIdentifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&renderTargetIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_RenderTargetIdentifier_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098997, XrefRangeEnd = 1099005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTargetIdentifier Identifier()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Identifier_Public_RenderTargetIdentifier_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099005, XrefRangeEnd = 1099008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasInternalRenderTargetId()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasInternalRenderTargetId_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1099015, RefRangeEnd = 1099018, XrefRangeStart = 1099008, XrefRangeEnd = 1099015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(RenderTargetHandle other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_RenderTargetHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099018, XrefRangeEnd = 1099024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099024, XrefRangeEnd = 1099027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099027, XrefRangeEnd = 1099031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(RenderTargetHandle c1, RenderTargetHandle c2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c1);
		*(RenderTargetHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetHandle_RenderTargetHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099031, XrefRangeEnd = 1099035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(RenderTargetHandle c1, RenderTargetHandle c2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c1);
		*(RenderTargetHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetHandle_RenderTargetHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
