using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppZXing.Common;

namespace Il2CppZXing.Rendering;

public class IBarcodeRenderer<TOutput> : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_TOutput_BitMatrix_BarcodeFormat_String_EncodingOptions_0;

	static IBarcodeRenderer()
	{
		Il2CppClassPointerStore<IBarcodeRenderer<TOutput>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Rendering", "IBarcodeRenderer`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutput>.NativeClassPtr)) })).TypeHandle.value);
		NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_TOutput_BitMatrix_BarcodeFormat_String_EncodingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBarcodeRenderer<TOutput>>.NativeClassPtr, 100663551);
	}

	[CallerCount(0)]
	public unsafe virtual TOutput Render(BitMatrix matrix, BarcodeFormat format, string content, EncodingOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		*(BarcodeFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_TOutput_BitMatrix_BarcodeFormat_String_EncodingOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TOutput>(intPtr2, false, true);
	}

	public IBarcodeRenderer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
