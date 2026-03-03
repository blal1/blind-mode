using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.InputSystem.LowLevel;

public static class InputRuntimeExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_DeviceCommand_Public_Static_Int64_IInputRuntime_Int32_byref_TCommand_0<TCommand>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_DeviceCommand_Public_Static_Int64_IInputRuntime_Int32_byref_TCommand_0, Il2CppClassPointerStore<InputRuntimeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCommand>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_DeviceCommand_Public_Static_Int64_IInputRuntime_Int32_byref_TCommand_0;

	static InputRuntimeExtensions()
	{
		Il2CppClassPointerStore<InputRuntimeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "InputRuntimeExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputRuntimeExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_DeviceCommand_Public_Static_Int64_IInputRuntime_Int32_byref_TCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRuntimeExtensions>.NativeClassPtr, 100667719);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009271, RefRangeEnd = 1009272, XrefRangeStart = 1009268, XrefRangeEnd = 1009271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long DeviceCommand<TCommand>(this IInputRuntime runtime, int deviceId, ref TCommand command) where TCommand : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)runtime);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deviceId;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TCommand, object>(ref command));
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_DeviceCommand_Public_Static_Int64_IInputRuntime_Int32_byref_TCommand_0<TCommand>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<TCommand, object>(ref command) = ((intPtr4 == (System.IntPtr)0) ? ((TCommand)null) : IL2CPP.PointerToValueGeneric<TCommand>(intPtr4, false, false));
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	public InputRuntimeExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
