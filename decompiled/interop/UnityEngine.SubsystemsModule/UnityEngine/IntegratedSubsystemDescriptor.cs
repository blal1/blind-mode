using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine;

public class IntegratedSubsystemDescriptor : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	public unsafe virtual string id
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271717, XrefRangeEnd = 1271718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public System.IntPtr UnityEngine_002EISubsystemDescriptorImpl_002Eptr
	{
		get
		{
			return m_Ptr;
		}
		set
		{
			m_Ptr = value;
		}
	}

	static IntegratedSubsystemDescriptor()
	{
		Il2CppClassPointerStore<IntegratedSubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "IntegratedSubsystemDescriptor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegratedSubsystemDescriptor>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedSubsystemDescriptor>.NativeClassPtr, "m_Ptr");
		NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystemDescriptor>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystemDescriptor>.NativeClassPtr, 100663307);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntegratedSubsystemDescriptor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegratedSubsystemDescriptor>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IntegratedSubsystemDescriptor(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ISubsystem UnityEngine_002EISubsystemDescriptor_002ECreate()
	{
		return this.CreateImpl();
	}
}
public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor where TSubsystem : IntegratedSubsystem
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static IntegratedSubsystemDescriptor()
	{
		Il2CppClassPointerStore<IntegratedSubsystemDescriptor<TSubsystem>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "IntegratedSubsystemDescriptor`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSubsystem>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegratedSubsystemDescriptor<TSubsystem>>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystemDescriptor<TSubsystem>>.NativeClassPtr, 100663308);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntegratedSubsystemDescriptor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegratedSubsystemDescriptor<TSubsystem>>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IntegratedSubsystemDescriptor(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public override ISubsystem CreateImpl()
	{
		return (ISubsystem)(object)Create();
	}

	public TSubsystem Create()
	{
		System.IntPtr ptr = SubsystemDescriptorBindings.Create(base.m_Ptr);
		TSubsystem val = ((Il2CppObjectBase)SubsystemManager.GetIntegratedSubsystemByPtr(ptr)).Cast<TSubsystem>();
		if (val != null)
		{
			val.m_SubsystemDescriptor = (ISubsystemDescriptor)(object)this;
		}
		return val;
	}
}
