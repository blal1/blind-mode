using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppSteamworks;

public class CallResult : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_OnRunCallResult_Internal_Abstract_Virtual_New_Void_IntPtr_Boolean_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUnregistered_Internal_Abstract_Virtual_New_Void_0;

	static CallResult()
	{
		Il2CppClassPointerStore<CallResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "CallResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallResult>.NativeClassPtr);
		NativeMethodInfoPtr_OnRunCallResult_Internal_Abstract_Virtual_New_Void_IntPtr_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_SetUnregistered_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult>.NativeClassPtr, 100663422);
	}

	[CallerCount(0)]
	public unsafe virtual void OnRunCallResult(System.IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&pvParam);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bFailed;
		*(ulong**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamAPICall;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnRunCallResult_Internal_Abstract_Virtual_New_Void_IntPtr_Boolean_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetUnregistered()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetUnregistered_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CallResult(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
