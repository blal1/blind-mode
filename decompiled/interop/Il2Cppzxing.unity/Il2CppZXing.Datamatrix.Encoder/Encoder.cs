using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppZXing.Datamatrix.Encoder;

public class Encoder : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_encode_Public_Abstract_Virtual_New_Void_EncoderContext_0;

	static Encoder()
	{
		Il2CppClassPointerStore<Encoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Datamatrix.Encoder", "Encoder");
		NativeMethodInfoPtr_encode_Public_Abstract_Virtual_New_Void_EncoderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100664507);
	}

	[CallerCount(0)]
	public unsafe virtual void encode(EncoderContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_encode_Public_Abstract_Virtual_New_Void_EncoderContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Encoder(IntPtr pointer)
		: base(pointer)
	{
	}
}
