using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono;

public class ISystemDependencyProvider : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_CertificateProvider_Public_Abstract_Virtual_New_get_ISystemCertificateProvider_0;

	public unsafe virtual ISystemCertificateProvider CertificateProvider
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_CertificateProvider_Public_Abstract_Virtual_New_get_ISystemCertificateProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ISystemCertificateProvider>(intPtr2) : null;
		}
	}

	static ISystemDependencyProvider()
	{
		Il2CppClassPointerStore<ISystemDependencyProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "ISystemDependencyProvider");
		NativeMethodInfoPtr_get_CertificateProvider_Public_Abstract_Virtual_New_get_ISystemCertificateProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISystemDependencyProvider>.NativeClassPtr, 100663369);
	}

	public ISystemDependencyProvider(IntPtr pointer)
		: base(pointer)
	{
	}
}
