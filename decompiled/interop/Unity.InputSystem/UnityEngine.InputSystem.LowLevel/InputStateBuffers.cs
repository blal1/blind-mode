using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct InputStateBuffers
{
	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct DoubleBuffers
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_deviceToBufferMapping;

		private static readonly System.IntPtr NativeFieldInfoPtr_deviceCount;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_valid_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFrontBuffer_Public_Void_Int32_ptr_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetBackBuffer_Public_Void_Int32_ptr_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFrontBuffer_Public_ptr_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetBackBuffer_Public_ptr_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SwapBuffers_Public_Void_Int32_0;

		[FieldOffset(0)]
		public System.IntPtr deviceToBufferMapping;

		[FieldOffset(8)]
		public int deviceCount;

		public unsafe bool valid
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 804380, RefRangeEnd = 804398, XrefRangeStart = 804380, XrefRangeEnd = 804398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_valid_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static DoubleBuffers()
		{
			Il2CppClassPointerStore<DoubleBuffers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, "DoubleBuffers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleBuffers>.NativeClassPtr);
			NativeFieldInfoPtr_deviceToBufferMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleBuffers>.NativeClassPtr, "deviceToBufferMapping");
			NativeFieldInfoPtr_deviceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleBuffers>.NativeClassPtr, "deviceCount");
			NativeMethodInfoPtr_get_valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBuffers>.NativeClassPtr, 100667854);
			NativeMethodInfoPtr_SetFrontBuffer_Public_Void_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBuffers>.NativeClassPtr, 100667855);
			NativeMethodInfoPtr_SetBackBuffer_Public_Void_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBuffers>.NativeClassPtr, 100667856);
			NativeMethodInfoPtr_GetFrontBuffer_Public_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBuffers>.NativeClassPtr, 100667857);
			NativeMethodInfoPtr_GetBackBuffer_Public_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBuffers>.NativeClassPtr, 100667858);
			NativeMethodInfoPtr_SwapBuffers_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBuffers>.NativeClassPtr, 100667859);
		}

		[CallerCount(0)]
		public unsafe void SetFrontBuffer(int deviceIndex, void* ptr)
		{
			System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
			*ptr2 = (nint)(&deviceIndex);
			*(void**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = ptr;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFrontBuffer_Public_Void_Int32_ptr_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr2, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe void SetBackBuffer(int deviceIndex, void* ptr)
		{
			System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
			*ptr2 = (nint)(&deviceIndex);
			*(void**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = ptr;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBackBuffer_Public_Void_Int32_ptr_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr2, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1009884, RefRangeEnd = 1009887, XrefRangeStart = 1009884, XrefRangeEnd = 1009884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void* GetFrontBuffer(int deviceIndex)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&deviceIndex);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFrontBuffer_Public_ptr_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (void*)result;
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1009887, RefRangeEnd = 1009891, XrefRangeStart = 1009887, XrefRangeEnd = 1009887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void* GetBackBuffer(int deviceIndex)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&deviceIndex);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBackBuffer_Public_ptr_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (void*)result;
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1009892, RefRangeEnd = 1009894, XrefRangeStart = 1009891, XrefRangeEnd = 1009892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapBuffers(int deviceIndex)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&deviceIndex);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwapBuffers_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DoubleBuffers>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_sizePerBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultStateBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseMaskBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetMaskBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AllBuffers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerStateBuffers;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultStateBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_NoiseMaskBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ResetMaskBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CurrentBuffers;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDoubleBuffersFor_Public_DoubleBuffers_InputUpdateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFrontBufferForDevice_Public_Static_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBackBufferForDevice_Public_Static_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchTo_Public_Static_Void_InputStateBuffers_InputUpdateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateAll_Public_Void_Il2CppReferenceArray_1_InputDevice_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUpDeviceToBufferMappings_Private_Static_DoubleBuffers_Int32_byref_ptr_Byte_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeAll_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MigrateAll_Public_Void_Il2CppReferenceArray_1_InputDevice_Int32_InputStateBuffers_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MigrateDoubleBuffer_Private_Static_Void_DoubleBuffers_Il2CppReferenceArray_1_InputDevice_Int32_DoubleBuffers_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MigrateSingleBuffer_Private_Static_Void_ptr_Void_Il2CppReferenceArray_1_InputDevice_Int32_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSizeOfSingleStateBuffer_Private_Static_UInt32_Il2CppReferenceArray_1_InputDevice_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextDeviceOffset_Private_Static_UInt32_UInt32_InputDevice_0;

	[FieldOffset(0)]
	public uint sizePerBuffer;

	[FieldOffset(4)]
	public uint totalSize;

	[FieldOffset(8)]
	public System.IntPtr defaultStateBuffer;

	[FieldOffset(16)]
	public System.IntPtr noiseMaskBuffer;

	[FieldOffset(24)]
	public System.IntPtr resetMaskBuffer;

	[FieldOffset(32)]
	public System.IntPtr m_AllBuffers;

	[FieldOffset(40)]
	public DoubleBuffers m_PlayerStateBuffers;

	public unsafe static void* s_DefaultStateBuffer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultStateBuffer, (void*)(&intPtr));
			return *(void**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultStateBuffer, value);
		}
	}

	public unsafe static void* s_NoiseMaskBuffer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_NoiseMaskBuffer, (void*)(&intPtr));
			return *(void**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_NoiseMaskBuffer, value);
		}
	}

	public unsafe static void* s_ResetMaskBuffer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ResetMaskBuffer, (void*)(&intPtr));
			return *(void**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ResetMaskBuffer, value);
		}
	}

	public unsafe static DoubleBuffers s_CurrentBuffers
	{
		get
		{
			Unsafe.SkipInit(out DoubleBuffers result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CurrentBuffers, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CurrentBuffers, (void*)(&value));
		}
	}

	static InputStateBuffers()
	{
		Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "InputStateBuffers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr);
		NativeFieldInfoPtr_sizePerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, "sizePerBuffer");
		NativeFieldInfoPtr_totalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, "totalSize");
		NativeFieldInfoPtr_defaultStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, "defaultStateBuffer");
		NativeFieldInfoPtr_noiseMaskBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, "noiseMaskBuffer");
		NativeFieldInfoPtr_resetMaskBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, "resetMaskBuffer");
		NativeFieldInfoPtr_m_AllBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, "m_AllBuffers");
		NativeFieldInfoPtr_m_PlayerStateBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, "m_PlayerStateBuffers");
		NativeFieldInfoPtr_s_DefaultStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, "s_DefaultStateBuffer");
		NativeFieldInfoPtr_s_NoiseMaskBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, "s_NoiseMaskBuffer");
		NativeFieldInfoPtr_s_ResetMaskBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, "s_ResetMaskBuffer");
		NativeFieldInfoPtr_s_CurrentBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, "s_CurrentBuffers");
		NativeMethodInfoPtr_GetDoubleBuffersFor_Public_DoubleBuffers_InputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, 100667842);
		NativeMethodInfoPtr_GetFrontBufferForDevice_Public_Static_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, 100667843);
		NativeMethodInfoPtr_GetBackBufferForDevice_Public_Static_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, 100667844);
		NativeMethodInfoPtr_SwitchTo_Public_Static_Void_InputStateBuffers_InputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, 100667845);
		NativeMethodInfoPtr_AllocateAll_Public_Void_Il2CppReferenceArray_1_InputDevice_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, 100667846);
		NativeMethodInfoPtr_SetUpDeviceToBufferMappings_Private_Static_DoubleBuffers_Int32_byref_ptr_Byte_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, 100667847);
		NativeMethodInfoPtr_FreeAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, 100667848);
		NativeMethodInfoPtr_MigrateAll_Public_Void_Il2CppReferenceArray_1_InputDevice_Int32_InputStateBuffers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, 100667849);
		NativeMethodInfoPtr_MigrateDoubleBuffer_Private_Static_Void_DoubleBuffers_Il2CppReferenceArray_1_InputDevice_Int32_DoubleBuffers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, 100667850);
		NativeMethodInfoPtr_MigrateSingleBuffer_Private_Static_Void_ptr_Void_Il2CppReferenceArray_1_InputDevice_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, 100667851);
		NativeMethodInfoPtr_ComputeSizeOfSingleStateBuffer_Private_Static_UInt32_Il2CppReferenceArray_1_InputDevice_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, 100667852);
		NativeMethodInfoPtr_NextDeviceOffset_Private_Static_UInt32_UInt32_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, 100667853);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009894, RefRangeEnd = 1009895, XrefRangeStart = 1009894, XrefRangeEnd = 1009894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&updateType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDoubleBuffersFor_Public_DoubleBuffers_InputUpdateType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DoubleBuffers*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1009897, RefRangeEnd = 1009917, XrefRangeStart = 1009895, XrefRangeEnd = 1009897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* GetFrontBufferForDevice(int deviceIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deviceIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFrontBufferForDevice_Public_Static_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009919, RefRangeEnd = 1009920, XrefRangeStart = 1009917, XrefRangeEnd = 1009919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* GetBackBufferForDevice(int deviceIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deviceIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBackBufferForDevice_Public_Static_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1009923, RefRangeEnd = 1009928, XrefRangeStart = 1009920, XrefRangeEnd = 1009923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SwitchTo(InputStateBuffers buffers, InputUpdateType update)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&buffers);
		*(InputUpdateType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &update;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchTo_Public_Static_Void_InputStateBuffers_InputUpdateType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009931, RefRangeEnd = 1009932, XrefRangeStart = 1009928, XrefRangeEnd = 1009931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllocateAll(Il2CppReferenceArray<InputDevice> devices, int deviceCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)devices);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deviceCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateAll_Public_Void_Il2CppReferenceArray_1_InputDevice_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer)
	{
		//IL_0066->IL0068: Incompatible stack types: I vs O
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&deviceCount);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<byte*, object>(ref bufferPtr));
		*(System.IntPtr**)num = &intPtr;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizePerBuffer;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mappingTableSizePerBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUpDeviceToBufferMappings_Private_Static_DoubleBuffers_Int32_byref_ptr_Byte_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<byte*, object>(ref bufferPtr) = ((intPtr4 == (System.IntPtr)0) ? null : ((object)new byte*(intPtr4)));
		return *(DoubleBuffers*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1009938, RefRangeEnd = 1009941, XrefRangeStart = 1009932, XrefRangeEnd = 1009938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeAll()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeAll_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009953, RefRangeEnd = 1009954, XrefRangeStart = 1009941, XrefRangeEnd = 1009953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MigrateAll(Il2CppReferenceArray<InputDevice> devices, int deviceCount, InputStateBuffers oldBuffers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)devices);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deviceCount;
		*(InputStateBuffers**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldBuffers;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MigrateAll_Public_Void_Il2CppReferenceArray_1_InputDevice_Int32_InputStateBuffers_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009965, RefRangeEnd = 1009966, XrefRangeStart = 1009954, XrefRangeEnd = 1009965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MigrateDoubleBuffer(DoubleBuffers newBuffer, Il2CppReferenceArray<InputDevice> devices, int deviceCount, DoubleBuffers oldBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&newBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)devices);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &deviceCount;
		*(DoubleBuffers**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MigrateDoubleBuffer_Private_Static_Void_DoubleBuffers_Il2CppReferenceArray_1_InputDevice_Int32_DoubleBuffers_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1009974, RefRangeEnd = 1009977, XrefRangeStart = 1009966, XrefRangeEnd = 1009974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MigrateSingleBuffer(void* newBuffer, Il2CppReferenceArray<InputDevice> devices, int deviceCount, void* oldBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)newBuffer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)devices);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &deviceCount;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = oldBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MigrateSingleBuffer_Private_Static_Void_ptr_Void_Il2CppReferenceArray_1_InputDevice_Int32_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009977, XrefRangeEnd = 1009983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ComputeSizeOfSingleStateBuffer(Il2CppReferenceArray<InputDevice> devices, int deviceCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)devices);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deviceCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeSizeOfSingleStateBuffer_Private_Static_UInt32_Il2CppReferenceArray_1_InputDevice_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1009989, RefRangeEnd = 1009993, XrefRangeStart = 1009983, XrefRangeEnd = 1009989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint NextDeviceOffset(uint currentOffset, InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&currentOffset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextDeviceOffset_Private_Static_UInt32_UInt32_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputStateBuffers>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
