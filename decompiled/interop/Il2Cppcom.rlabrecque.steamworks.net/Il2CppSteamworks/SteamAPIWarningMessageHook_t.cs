using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppSteamworks;

public sealed class SteamAPIWarningMessageHook_t : Il2CppSystem.MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_StringBuilder_0;

	static SteamAPIWarningMessageHook_t()
	{
		Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "SteamAPIWarningMessageHook_t");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr, 100663449);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 687835, RefRangeEnd = 687873, XrefRangeStart = 687832, XrefRangeEnd = 687835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SteamAPIWarningMessageHook_t(Il2CppSystem.Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(int nSeverity, StringBuilder pchDebugText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nSeverity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchDebugText);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SteamAPIWarningMessageHook_t(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator SteamAPIWarningMessageHook_t(System.Action<int, StringBuilder> P_0)
	{
		return DelegateSupport.ConvertDelegate<SteamAPIWarningMessageHook_t>((System.Delegate)P_0);
	}

	public static SteamAPIWarningMessageHook_t operator +(SteamAPIWarningMessageHook_t P_0, SteamAPIWarningMessageHook_t P_1)
	{
		return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<SteamAPIWarningMessageHook_t>();
	}

	public static SteamAPIWarningMessageHook_t operator -(SteamAPIWarningMessageHook_t P_0, SteamAPIWarningMessageHook_t P_1)
	{
		object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<SteamAPIWarningMessageHook_t>();
		}
		return (SteamAPIWarningMessageHook_t)obj;
	}
}
