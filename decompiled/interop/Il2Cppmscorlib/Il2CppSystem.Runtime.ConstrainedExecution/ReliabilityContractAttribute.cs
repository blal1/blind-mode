using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.ConstrainedExecution;

public sealed class ReliabilityContractAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__ConsistencyGuarantee_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Cer_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Consistency_Cer_0;

	public unsafe Consistency _ConsistencyGuarantee_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConsistencyGuarantee_k__BackingField);
			return *(Consistency*)num;
		}
		set
		{
			*(Consistency*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConsistencyGuarantee_k__BackingField)) = value;
		}
	}

	public unsafe Cer _Cer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Cer_k__BackingField);
			return *(Cer*)num;
		}
		set
		{
			*(Cer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Cer_k__BackingField)) = value;
		}
	}

	static ReliabilityContractAttribute()
	{
		Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ConstrainedExecution", "ReliabilityContractAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__ConsistencyGuarantee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr, "<ConsistencyGuarantee>k__BackingField");
		NativeFieldInfoPtr__Cer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr, "<Cer>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_Consistency_Cer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr, 100671358);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805484, XrefRangeEnd = 805485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&consistencyGuarantee);
		*(Cer**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Consistency_Cer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ReliabilityContractAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
