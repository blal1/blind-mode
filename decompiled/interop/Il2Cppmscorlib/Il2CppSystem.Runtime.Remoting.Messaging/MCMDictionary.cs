using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging;

public class MCMDictionary : MessageDictionary
{
	private static readonly System.IntPtr NativeFieldInfoPtr_InternalKeys;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;

	public unsafe static Il2CppStringArray InternalKeys
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InternalKeys, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InternalKeys, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static MCMDictionary()
	{
		Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MCMDictionary");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr);
		NativeFieldInfoPtr_InternalKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr, "InternalKeys");
		NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr, 100670420);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 796392, RefRangeEnd = 796393, XrefRangeStart = 796385, XrefRangeEnd = 796392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MCMDictionary(IMethodMessage message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MCMDictionary(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
