using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class InstanceCullerBurst : Il2CppSystem.Object
{
	[ObfuscatedName("UnityEngine.Rendering.InstanceCullerBurst+SetupCullingJobInput_00000142$PostfixBurstDelegate")]
	public sealed class MulticastDelegateNInternalSealedVoSiObObObObObUnique : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_0;

		static MulticastDelegateNInternalSealedVoSiObObObObObUnique()
		{
			Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoSiObObObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceCullerBurst>.NativeClassPtr, "SetupCullingJobInput_00000142$PostfixBurstDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoSiObObObObObUnique>.NativeClassPtr, 100663596);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoSiObObObObObUnique>.NativeClassPtr, 100663597);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070045, XrefRangeEnd = 1070048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastDelegateNInternalSealedVoSiObObObObObUnique(Il2CppSystem.Object A_1, System.IntPtr A_2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoSiObObObObObUnique>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)A_1);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &A_2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(float lodBias, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, float* screenRelativeMetric)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&lodBias);
			*(BatchCullingContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = context;
			*(ReceiverPlanes**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = receiverPlanes;
			*(ReceiverSphereCuller**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = receiverSphereCuller;
			*(FrustumPlaneCuller**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = frustumPlaneCuller;
			*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = screenRelativeMetric;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MulticastDelegateNInternalSealedVoSiObObObObObUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.InstanceCullerBurst+SetupCullingJobInput_00000142$BurstDirectCall")]
	public static class ObjectNInternalAbstractSealedInPoUnique : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_0;

		public unsafe static System.IntPtr Pointer
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Pointer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Pointer, (void*)(&value));
			}
		}

		static ObjectNInternalAbstractSealedInPoUnique()
		{
			Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceCullerBurst>.NativeClassPtr, "SetupCullingJobInput_00000142$BurstDirectCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr);
			NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr, "Pointer");
			NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr, 100663598);
			NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr, 100663599);
			NativeMethodInfoPtr_Invoke_Public_Static_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr, 100663600);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070048, XrefRangeEnd = 1070067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFunctionPointerDiscard(ref System.IntPtr A_0)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref A_0);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070067, XrefRangeEnd = 1070086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr GetFunctionPointer()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1070109, RefRangeEnd = 1070110, XrefRangeStart = 1070086, XrefRangeEnd = 1070109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke(float lodBias, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, float* screenRelativeMetric)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&lodBias);
			*(BatchCullingContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = context;
			*(ReceiverPlanes**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = receiverPlanes;
			*(ReceiverSphereCuller**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = receiverSphereCuller;
			*(FrustumPlaneCuller**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = frustumPlaneCuller;
			*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = screenRelativeMetric;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Static_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ObjectNInternalAbstractSealedInPoUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCullingJobInput_Public_Static_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_PDM_0;

	static InstanceCullerBurst()
	{
		Il2CppClassPointerStore<InstanceCullerBurst>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceCullerBurst");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceCullerBurst>.NativeClassPtr);
		NativeMethodInfoPtr_SetupCullingJobInput_Public_Static_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullerBurst>.NativeClassPtr, 100663594);
		NativeMethodInfoPtr_Method_Internal_Static_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullerBurst>.NativeClassPtr, 100663595);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070111, RefRangeEnd = 1070112, XrefRangeStart = 1070110, XrefRangeEnd = 1070111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCullingJobInput(float lodBias, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, float* screenRelativeMetric)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&lodBias);
		*(BatchCullingContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = context;
		*(ReceiverPlanes**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = receiverPlanes;
		*(ReceiverSphereCuller**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = receiverSphereCuller;
		*(FrustumPlaneCuller**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = frustumPlaneCuller;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = screenRelativeMetric;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCullingJobInput_Public_Static_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070112, XrefRangeEnd = 1070119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_PDM_0(float lodBias, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, float* screenRelativeMetric)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&lodBias);
		*(BatchCullingContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = context;
		*(ReceiverPlanes**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = receiverPlanes;
		*(ReceiverSphereCuller**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = receiverSphereCuller;
		*(FrustumPlaneCuller**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = frustumPlaneCuller;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = screenRelativeMetric;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_Single_ptr_BatchCullingContext_ptr_ReceiverPlanes_ptr_ReceiverSphereCuller_ptr_FrustumPlaneCuller_ptr_Single_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InstanceCullerBurst(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
