using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppZXing.OneD;

public class UPCEANWriter : OneDimensionalCodeWriter
{
	private static readonly IntPtr NativeMethodInfoPtr_get_DefaultMargin_Public_Virtual_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe override int DefaultMargin
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_DefaultMargin_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static UPCEANWriter()
	{
		Il2CppClassPointerStore<UPCEANWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "UPCEANWriter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UPCEANWriter>.NativeClassPtr);
		NativeMethodInfoPtr_get_DefaultMargin_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEANWriter>.NativeClassPtr, 100664228);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEANWriter>.NativeClassPtr, 100664229);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1423973, RefRangeEnd = 1423976, XrefRangeStart = 1423939, XrefRangeEnd = 1423973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UPCEANWriter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UPCEANWriter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UPCEANWriter(IntPtr pointer)
		: base(pointer)
	{
	}
}
