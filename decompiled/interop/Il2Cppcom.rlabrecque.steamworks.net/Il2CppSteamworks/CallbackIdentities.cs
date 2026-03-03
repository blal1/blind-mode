using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppSteamworks;

public class CallbackIdentities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetCallbackIdentity_Public_Static_Int32_Type_0;

	static CallbackIdentities()
	{
		Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "CallbackIdentities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr);
		NativeMethodInfoPtr_GetCallbackIdentity_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr, 100663423);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 687429, RefRangeEnd = 687431, XrefRangeStart = 687422, XrefRangeEnd = 687429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCallbackIdentity(Il2CppSystem.Type callbackStruct)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callbackStruct);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCallbackIdentity_Public_Static_Int32_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public CallbackIdentities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
