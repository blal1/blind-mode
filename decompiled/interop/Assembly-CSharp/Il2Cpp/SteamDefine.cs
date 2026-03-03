using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSteamworks;
using Il2CppSystem;

namespace Il2Cpp;

public class SteamDefine : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AppId;

	private static readonly System.IntPtr NativeFieldInfoPtr_CryptoHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_HashSalt;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static AppId_t AppId
	{
		get
		{
			Unsafe.SkipInit(out AppId_t result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AppId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AppId, (void*)(&value));
		}
	}

	public unsafe static string CryptoHash
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CryptoHash, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CryptoHash, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string HashSalt
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HashSalt, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HashSalt, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static SteamDefine()
	{
		Il2CppClassPointerStore<SteamDefine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SteamDefine");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamDefine>.NativeClassPtr);
		NativeFieldInfoPtr_AppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDefine>.NativeClassPtr, "AppId");
		NativeFieldInfoPtr_CryptoHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDefine>.NativeClassPtr, "CryptoHash");
		NativeFieldInfoPtr_HashSalt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDefine>.NativeClassPtr, "HashSalt");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamDefine>.NativeClassPtr, 100664090);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SteamDefine()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamDefine>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SteamDefine(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
