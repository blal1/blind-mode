using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono;

public class SystemDependencyProvider : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_syncRoot;

	private static readonly System.IntPtr NativeFieldInfoPtr__CertificateProvider_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_SystemDependencyProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Mono_ISystemDependencyProvider_get_CertificateProvider_Private_Virtual_Final_New_get_ISystemCertificateProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CertificateProvider_Public_get_SystemCertificateProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_X509Pal_Public_get_X509PalImpl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	public unsafe static SystemDependencyProvider instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SystemDependencyProvider>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Object syncRoot
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_syncRoot, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_syncRoot, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SystemCertificateProvider _CertificateProvider_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CertificateProvider_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SystemCertificateProvider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CertificateProvider_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static SystemDependencyProvider Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862321, XrefRangeEnd = 862326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_SystemDependencyProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SystemDependencyProvider>(intPtr2) : null;
		}
	}

	public unsafe virtual ISystemCertificateProvider Mono_002EISystemDependencyProvider_002ECertificateProvider
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Mono_ISystemDependencyProvider_get_CertificateProvider_Private_Virtual_Final_New_get_ISystemCertificateProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISystemCertificateProvider>(intPtr2) : null;
		}
	}

	public unsafe SystemCertificateProvider CertificateProvider
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CertificateProvider_Public_get_SystemCertificateProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SystemCertificateProvider>(intPtr2) : null;
		}
	}

	public unsafe X509PalImpl X509Pal
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862358, XrefRangeEnd = 862363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_X509Pal_Public_get_X509PalImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509PalImpl>(intPtr2) : null;
		}
	}

	static SystemDependencyProvider()
	{
		Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono", "SystemDependencyProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr);
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, "syncRoot");
		NativeFieldInfoPtr__CertificateProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, "<CertificateProvider>k__BackingField");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_SystemDependencyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_Mono_ISystemDependencyProvider_get_CertificateProvider_Private_Virtual_Final_New_get_ISystemCertificateProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_get_CertificateProvider_Public_get_SystemCertificateProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_get_X509Pal_Public_get_X509PalImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, 100663312);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 862355, RefRangeEnd = 862358, XrefRangeStart = 862326, XrefRangeEnd = 862355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862363, XrefRangeEnd = 862373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SystemDependencyProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SystemDependencyProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
