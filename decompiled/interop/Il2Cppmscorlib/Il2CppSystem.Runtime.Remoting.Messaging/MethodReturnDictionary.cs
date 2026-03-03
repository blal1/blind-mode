using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging;

public class MethodReturnDictionary : MessageDictionary
{
	private static readonly System.IntPtr NativeFieldInfoPtr_InternalReturnKeys;

	private static readonly System.IntPtr NativeFieldInfoPtr_InternalExceptionKeys;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodReturnMessage_0;

	public unsafe static Il2CppStringArray InternalReturnKeys
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InternalReturnKeys, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InternalReturnKeys, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray InternalExceptionKeys
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InternalExceptionKeys, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InternalExceptionKeys, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static MethodReturnDictionary()
	{
		Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MethodReturnDictionary");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr);
		NativeFieldInfoPtr_InternalReturnKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr, "InternalReturnKeys");
		NativeFieldInfoPtr_InternalExceptionKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr, "InternalExceptionKeys");
		NativeMethodInfoPtr__ctor_Public_Void_IMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr, 100670472);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 796955, RefRangeEnd = 796957, XrefRangeStart = 796941, XrefRangeEnd = 796955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MethodReturnDictionary(IMethodReturnMessage message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MethodReturnDictionary(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
