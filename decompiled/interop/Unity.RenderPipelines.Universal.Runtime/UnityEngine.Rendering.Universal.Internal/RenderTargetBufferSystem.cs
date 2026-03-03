using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.Internal;

public sealed class RenderTargetBufferSystem : Il2CppSystem.Object
{
	public sealed class SwapBuffer : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rtMSAA;

		private static readonly System.IntPtr NativeFieldInfoPtr_rtResolve;

		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_msaa;

		public unsafe RTHandle rtMSAA
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rtMSAA);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rtMSAA)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RTHandle rtResolve
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rtResolve);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rtResolve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int msaa
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_msaa);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_msaa)) = value;
			}
		}

		static SwapBuffer()
		{
			Il2CppClassPointerStore<SwapBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "SwapBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwapBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_rtMSAA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBuffer>.NativeClassPtr, "rtMSAA");
			NativeFieldInfoPtr_rtResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBuffer>.NativeClassPtr, "rtResolve");
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBuffer>.NativeClassPtr, "name");
			NativeFieldInfoPtr_msaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBuffer>.NativeClassPtr, "msaa");
		}

		public SwapBuffer(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SwapBuffer()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwapBuffer>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_A;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_B;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AisBackBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Desc;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FilterMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AllowMSAA;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_backBuffer_Private_get_byref_SwapBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frontBuffer_Private_get_byref_SwapBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PeekBackBuffer_Public_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBackBuffer_Public_RTHandle_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFrontBuffer_Public_RTHandle_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Swap_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReAllocate_Private_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraSettings_Public_Void_RenderTextureDescriptor_FilterMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBufferA_Public_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableMSAA_Public_Void_Boolean_0;

	public unsafe SwapBuffer m_A
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_A);
			return new SwapBuffer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwapBuffer>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_A), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SwapBuffer>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe SwapBuffer m_B
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_B);
			return new SwapBuffer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwapBuffer>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_B), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SwapBuffer>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe static bool m_AisBackBuffer
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_AisBackBuffer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_AisBackBuffer, (void*)(&value));
		}
	}

	public unsafe static RenderTextureDescriptor m_Desc
	{
		get
		{
			Unsafe.SkipInit(out RenderTextureDescriptor result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Desc, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Desc, (void*)(&value));
		}
	}

	public unsafe FilterMode m_FilterMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FilterMode);
			return *(FilterMode*)num;
		}
		set
		{
			*(FilterMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FilterMode)) = value;
		}
	}

	public unsafe bool m_AllowMSAA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllowMSAA);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllowMSAA)) = value;
		}
	}

	public unsafe ref SwapBuffer backBuffer
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113704, XrefRangeEnd = 1113708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_backBuffer_Private_get_byref_SwapBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(SwapBuffer*)intPtr2;
		}
	}

	public unsafe ref SwapBuffer frontBuffer
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113708, XrefRangeEnd = 1113712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frontBuffer_Private_get_byref_SwapBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(SwapBuffer*)intPtr2;
		}
	}

	static RenderTargetBufferSystem()
	{
		Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "RenderTargetBufferSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr);
		NativeFieldInfoPtr_m_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "m_A");
		NativeFieldInfoPtr_m_B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "m_B");
		NativeFieldInfoPtr_m_AisBackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "m_AisBackBuffer");
		NativeFieldInfoPtr_m_Desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "m_Desc");
		NativeFieldInfoPtr_m_FilterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "m_FilterMode");
		NativeFieldInfoPtr_m_AllowMSAA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "m_AllowMSAA");
		NativeMethodInfoPtr_get_backBuffer_Private_get_byref_SwapBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666483);
		NativeMethodInfoPtr_get_frontBuffer_Private_get_byref_SwapBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666484);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666485);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666486);
		NativeMethodInfoPtr_PeekBackBuffer_Public_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666487);
		NativeMethodInfoPtr_GetBackBuffer_Public_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666488);
		NativeMethodInfoPtr_GetFrontBuffer_Public_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666489);
		NativeMethodInfoPtr_Swap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666490);
		NativeMethodInfoPtr_ReAllocate_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666491);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666492);
		NativeMethodInfoPtr_SetCameraSettings_Public_Void_RenderTextureDescriptor_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666493);
		NativeMethodInfoPtr_GetBufferA_Public_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666494);
		NativeMethodInfoPtr_EnableMSAA_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666495);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1113721, RefRangeEnd = 1113722, XrefRangeStart = 1113712, XrefRangeEnd = 1113721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTargetBufferSystem(string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1113726, RefRangeEnd = 1113727, XrefRangeStart = 1113722, XrefRangeEnd = 1113726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1113735, RefRangeEnd = 1113737, XrefRangeStart = 1113727, XrefRangeEnd = 1113735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTHandle PeekBackBuffer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PeekBackBuffer_Public_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1113746, RefRangeEnd = 1113751, XrefRangeStart = 1113737, XrefRangeEnd = 1113746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTHandle GetBackBuffer(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBackBuffer_Public_RTHandle_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1113773, RefRangeEnd = 1113774, XrefRangeStart = 1113751, XrefRangeEnd = 1113773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTHandle GetFrontBuffer(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFrontBuffer_Public_RTHandle_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1113778, RefRangeEnd = 1113779, XrefRangeStart = 1113774, XrefRangeEnd = 1113778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Swap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Swap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1113798, RefRangeEnd = 1113800, XrefRangeStart = 1113779, XrefRangeEnd = 1113798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReAllocate(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReAllocate_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1113804, RefRangeEnd = 1113805, XrefRangeStart = 1113800, XrefRangeEnd = 1113804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113805, XrefRangeEnd = 1113817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCameraSettings(RenderTextureDescriptor desc, FilterMode filterMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&desc);
		*(FilterMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraSettings_Public_Void_RenderTextureDescriptor_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe RTHandle GetBufferA()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBufferA_Public_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1113822, RefRangeEnd = 1113823, XrefRangeStart = 1113817, XrefRangeEnd = 1113822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableMSAA(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableMSAA_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderTargetBufferSystem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
