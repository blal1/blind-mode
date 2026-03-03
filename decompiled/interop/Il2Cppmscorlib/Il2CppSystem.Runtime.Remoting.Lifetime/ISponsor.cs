using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Lifetime;

public class ISponsor : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Renewal_Public_Abstract_Virtual_New_TimeSpan_ILease_0;

	static ISponsor()
	{
		Il2CppClassPointerStore<ISponsor>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "ISponsor");
		NativeMethodInfoPtr_Renewal_Public_Abstract_Virtual_New_TimeSpan_ILease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISponsor>.NativeClassPtr, 100670041);
	}

	[CallerCount(0)]
	public unsafe virtual TimeSpan Renewal(ILease lease)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lease);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Renewal_Public_Abstract_Virtual_New_TimeSpan_ILease_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ISponsor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
