using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem;

namespace Il2CppSteamworks;

public class InteropHelp : Il2CppSystem.Object
{
	public class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

		static UTF8StringHandle()
		{
			Il2CppClassPointerStore<UTF8StringHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, "UTF8StringHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF8StringHandle>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8StringHandle>.NativeClassPtr, 100663430);
			NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8StringHandle>.NativeClassPtr, 100663431);
		}

		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 687442, RefRangeEnd = 687475, XrefRangeStart = 687431, XrefRangeEnd = 687442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UTF8StringHandle(string str)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF8StringHandle>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687475, XrefRangeEnd = 687479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public UTF8StringHandle(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_TestIfPlatformSupported_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestIfAvailableClient_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PtrToStringUTF8_Public_Static_String_IntPtr_0;

	static InteropHelp()
	{
		Il2CppClassPointerStore<InteropHelp>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "InteropHelp");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr);
		NativeMethodInfoPtr_TestIfPlatformSupported_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_TestIfAvailableClient_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_PtrToStringUTF8_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100663429);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TestIfPlatformSupported()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestIfPlatformSupported_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(42)]
	[CachedScanResults(RefRangeStart = 687482, RefRangeEnd = 687524, XrefRangeStart = 687479, XrefRangeEnd = 687482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TestIfAvailableClient()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestIfAvailableClient_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 687537, RefRangeEnd = 687541, XrefRangeStart = 687524, XrefRangeEnd = 687537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string PtrToStringUTF8(System.IntPtr nativeUtf8)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nativeUtf8);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PtrToStringUTF8_Public_Static_String_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public InteropHelp(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
