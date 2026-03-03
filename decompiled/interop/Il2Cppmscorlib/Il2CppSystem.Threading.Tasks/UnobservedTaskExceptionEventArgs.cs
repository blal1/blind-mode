using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks;

public class UnobservedTaskExceptionEventArgs : EventArgs
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_exception;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_observed;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AggregateException_0;

	public unsafe AggregateException m_exception
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_exception);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AggregateException>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_exception)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_observed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_observed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_observed)) = value;
		}
	}

	static UnobservedTaskExceptionEventArgs()
	{
		Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "UnobservedTaskExceptionEventArgs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr);
		NativeFieldInfoPtr_m_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr, "m_exception");
		NativeFieldInfoPtr_m_observed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr, "m_observed");
		NativeMethodInfoPtr__ctor_Public_Void_AggregateException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr, 100668450);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776208, XrefRangeEnd = 776227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnobservedTaskExceptionEventArgs(AggregateException exception)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AggregateException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UnobservedTaskExceptionEventArgs(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
