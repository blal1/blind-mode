using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.LowLevel;

public static class InputUpdate : Il2CppSystem.Object
{
	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateStepCount
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_WasUpdated;

		private static readonly System.IntPtr NativeFieldInfoPtr__value_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_value_Private_set_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeUpdate_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool m_WasUpdated;

		[FieldOffset(4)]
		public uint _value_k__BackingField;

		public unsafe uint value
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_value_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 376349, RefRangeEnd = 376359, XrefRangeStart = 376349, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_value_Private_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static UpdateStepCount()
		{
			Il2CppClassPointerStore<UpdateStepCount>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputUpdate>.NativeClassPtr, "UpdateStepCount");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateStepCount>.NativeClassPtr);
			NativeFieldInfoPtr_m_WasUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStepCount>.NativeClassPtr, "m_WasUpdated");
			NativeFieldInfoPtr__value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStepCount>.NativeClassPtr, "<value>k__BackingField");
			NativeMethodInfoPtr_get_value_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStepCount>.NativeClassPtr, 100667751);
			NativeMethodInfoPtr_set_value_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStepCount>.NativeClassPtr, 100667752);
			NativeMethodInfoPtr_OnBeforeUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStepCount>.NativeClassPtr, 100667753);
			NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStepCount>.NativeClassPtr, 100667754);
		}

		[CallerCount(0)]
		public unsafe void OnBeforeUpdate()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeUpdate_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe void OnUpdate()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateStepCount>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct SerializedState
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_lastUpdateType;

		private static readonly System.IntPtr NativeFieldInfoPtr_playerUpdateStepCount;

		[FieldOffset(0)]
		public InputUpdateType lastUpdateType;

		[FieldOffset(4)]
		public UpdateStepCount playerUpdateStepCount;

		static SerializedState()
		{
			Il2CppClassPointerStore<SerializedState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputUpdate>.NativeClassPtr, "SerializedState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedState>.NativeClassPtr);
			NativeFieldInfoPtr_lastUpdateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedState>.NativeClassPtr, "lastUpdateType");
			NativeFieldInfoPtr_playerUpdateStepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedState>.NativeClassPtr, "playerUpdateStepCount");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializedState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_UpdateStepCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_LatestUpdateType;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PlayerUpdateStepCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeUpdate_Internal_Static_Void_InputUpdateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Internal_Static_Void_InputUpdateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_SerializedState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Restore_Public_Static_Void_SerializedState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpdateTypeForPlayer_Public_Static_InputUpdateType_InputUpdateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerUpdate_Public_Static_Boolean_InputUpdateType_0;

	public unsafe static uint s_UpdateStepCount
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_UpdateStepCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_UpdateStepCount, (void*)(&value));
		}
	}

	public unsafe static InputUpdateType s_LatestUpdateType
	{
		get
		{
			Unsafe.SkipInit(out InputUpdateType result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_LatestUpdateType, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_LatestUpdateType, (void*)(&value));
		}
	}

	public unsafe static UpdateStepCount s_PlayerUpdateStepCount
	{
		get
		{
			Unsafe.SkipInit(out UpdateStepCount result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PlayerUpdateStepCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PlayerUpdateStepCount, (void*)(&value));
		}
	}

	static InputUpdate()
	{
		Il2CppClassPointerStore<InputUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "InputUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputUpdate>.NativeClassPtr);
		NativeFieldInfoPtr_s_UpdateStepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputUpdate>.NativeClassPtr, "s_UpdateStepCount");
		NativeFieldInfoPtr_s_LatestUpdateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputUpdate>.NativeClassPtr, "s_LatestUpdateType");
		NativeFieldInfoPtr_s_PlayerUpdateStepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputUpdate>.NativeClassPtr, "s_PlayerUpdateStepCount");
		NativeMethodInfoPtr_OnBeforeUpdate_Internal_Static_Void_InputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUpdate>.NativeClassPtr, 100667745);
		NativeMethodInfoPtr_OnUpdate_Internal_Static_Void_InputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUpdate>.NativeClassPtr, 100667746);
		NativeMethodInfoPtr_Save_Public_Static_SerializedState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUpdate>.NativeClassPtr, 100667747);
		NativeMethodInfoPtr_Restore_Public_Static_Void_SerializedState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUpdate>.NativeClassPtr, 100667748);
		NativeMethodInfoPtr_GetUpdateTypeForPlayer_Public_Static_InputUpdateType_InputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUpdate>.NativeClassPtr, 100667749);
		NativeMethodInfoPtr_IsPlayerUpdate_Public_Static_Boolean_InputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUpdate>.NativeClassPtr, 100667750);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009276, RefRangeEnd = 1009277, XrefRangeStart = 1009272, XrefRangeEnd = 1009276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnBeforeUpdate(InputUpdateType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeUpdate_Internal_Static_Void_InputUpdateType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009281, RefRangeEnd = 1009282, XrefRangeStart = 1009277, XrefRangeEnd = 1009281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnUpdate(InputUpdateType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Internal_Static_Void_InputUpdateType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009282, XrefRangeEnd = 1009284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SerializedState Save()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_SerializedState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SerializedState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1009288, RefRangeEnd = 1009290, XrefRangeStart = 1009284, XrefRangeEnd = 1009288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Restore(SerializedState state)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Restore_Public_Static_Void_SerializedState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1009290, RefRangeEnd = 1009294, XrefRangeStart = 1009290, XrefRangeEnd = 1009290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputUpdateType GetUpdateTypeForPlayer(this InputUpdateType mask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mask);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpdateTypeForPlayer_Public_Static_InputUpdateType_InputUpdateType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InputUpdateType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009294, RefRangeEnd = 1009295, XrefRangeStart = 1009294, XrefRangeEnd = 1009294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPlayerUpdate(this InputUpdateType updateType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&updateType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPlayerUpdate_Public_Static_Boolean_InputUpdateType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public InputUpdate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
