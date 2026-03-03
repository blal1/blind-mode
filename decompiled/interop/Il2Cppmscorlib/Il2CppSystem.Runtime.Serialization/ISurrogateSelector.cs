using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization;

public class ISurrogateSelector : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetSurrogate_Public_Abstract_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0;

	static ISurrogateSelector()
	{
		Il2CppClassPointerStore<ISurrogateSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ISurrogateSelector");
		NativeMethodInfoPtr_GetSurrogate_Public_Abstract_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISurrogateSelector>.NativeClassPtr, 100670585);
	}

	[CallerCount(0)]
	public unsafe virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSurrogate_Public_Abstract_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		selector = ((num3 == 0) ? null : new ISurrogateSelector(num3));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr2) : null;
	}

	public ISurrogateSelector(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
