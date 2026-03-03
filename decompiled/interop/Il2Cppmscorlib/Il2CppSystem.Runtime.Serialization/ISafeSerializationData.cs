using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Serialization;

public class ISafeSerializationData : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CompleteDeserialization_Public_Abstract_Virtual_New_Void_Object_0;

	static ISafeSerializationData()
	{
		Il2CppClassPointerStore<ISafeSerializationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ISafeSerializationData");
		NativeMethodInfoPtr_CompleteDeserialization_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISafeSerializationData>.NativeClassPtr, 100670743);
	}

	[CallerCount(0)]
	public unsafe virtual void CompleteDeserialization(Object deserialized)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)deserialized);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CompleteDeserialization_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ISafeSerializationData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
