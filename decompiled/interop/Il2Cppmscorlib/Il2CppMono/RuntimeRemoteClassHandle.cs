using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono;

[StructLayout(LayoutKind.Explicit)]
public struct RuntimeRemoteClassHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr_value;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ProxyClass_Internal_get_RuntimeClassHandle_0;

	[FieldOffset(0)]
	public System.IntPtr value;

	public unsafe RuntimeClassHandle ProxyClass
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 696511, RefRangeEnd = 696514, XrefRangeStart = 696511, XrefRangeEnd = 696511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ProxyClass_Internal_get_RuntimeClassHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RuntimeClassHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static RuntimeRemoteClassHandle()
	{
		Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeRemoteClassHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr);
		NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr, "value");
		NativeMethodInfoPtr_get_ProxyClass_Internal_get_RuntimeClassHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr, 100663378);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
