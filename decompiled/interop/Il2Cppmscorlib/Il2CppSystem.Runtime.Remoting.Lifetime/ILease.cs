using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Lifetime;

public class ILease : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Abstract_Virtual_New_get_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentState_Public_Abstract_Virtual_New_get_LeaseState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RenewOnCallTime_Public_Abstract_Virtual_New_get_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Renew_Public_Abstract_Virtual_New_TimeSpan_TimeSpan_0;

	public unsafe virtual TimeSpan CurrentLeaseTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Abstract_Virtual_New_get_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual LeaseState CurrentState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_CurrentState_Public_Abstract_Virtual_New_get_LeaseState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LeaseState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual TimeSpan RenewOnCallTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_RenewOnCallTime_Public_Abstract_Virtual_New_get_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ILease()
	{
		Il2CppClassPointerStore<ILease>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "ILease");
		NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Abstract_Virtual_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100670037);
		NativeMethodInfoPtr_get_CurrentState_Public_Abstract_Virtual_New_get_LeaseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100670038);
		NativeMethodInfoPtr_get_RenewOnCallTime_Public_Abstract_Virtual_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100670039);
		NativeMethodInfoPtr_Renew_Public_Abstract_Virtual_New_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100670040);
	}

	[CallerCount(0)]
	public unsafe virtual TimeSpan Renew(TimeSpan renewalTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&renewalTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Renew_Public_Abstract_Virtual_New_TimeSpan_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ILease(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
