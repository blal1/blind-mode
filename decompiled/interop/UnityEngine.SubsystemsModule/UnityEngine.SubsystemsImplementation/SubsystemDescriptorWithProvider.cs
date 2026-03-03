using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.SubsystemsImplementation;

public class SubsystemDescriptorWithProvider : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__id_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe string _id_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe virtual string id
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		set
		{
			_id_k__BackingField = value;
		}
	}

	public Il2CppSystem.Type providerType
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Il2CppSystem.Type subsystemTypeOverride
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static SubsystemDescriptorWithProvider()
	{
		Il2CppClassPointerStore<SubsystemDescriptorWithProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine.SubsystemsImplementation", "SubsystemDescriptorWithProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemDescriptorWithProvider>.NativeClassPtr);
		NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptorWithProvider>.NativeClassPtr, "<id>k__BackingField");
		NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorWithProvider>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorWithProvider>.NativeClassPtr, 100663333);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SubsystemDescriptorWithProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubsystemDescriptorWithProvider>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SubsystemDescriptorWithProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ISubsystem UnityEngine_002EISubsystemDescriptor_002ECreate()
	{
		return this.CreateImpl();
	}
}
