using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Burst;

public sealed class BurstCompilerOptions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ForceDisableBurstCompilation;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceBurstCompilationSynchronously;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSecondaryUnityProcess;

	private static readonly System.IntPtr NativeFieldInfoPtr__enableBurstCompilation;

	private static readonly System.IntPtr NativeFieldInfoPtr__enableBurstSafetyChecks;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsGlobal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__OptionsChanged_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsGlobal_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EnableBurstCompilation_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableBurstCompilation_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableBurstSafetyChecks_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OptionsChanged_Internal_get_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAttribute_Private_Static_Boolean_MemberInfo_byref_BurstCompileAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBurstCompileAttribute_Private_Static_BurstCompileAttribute_MemberInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasBurstCompileAttribute_Internal_Static_Boolean_MemberInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnOptionsChanged_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaybeTriggerRecompilation_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsSecondaryUnityProcess_Private_Static_Boolean_0;

	public unsafe static bool ForceDisableBurstCompilation
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ForceDisableBurstCompilation, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ForceDisableBurstCompilation, (void*)(&value));
		}
	}

	public unsafe static bool ForceBurstCompilationSynchronously
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ForceBurstCompilationSynchronously, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ForceBurstCompilationSynchronously, (void*)(&value));
		}
	}

	public unsafe static bool IsSecondaryUnityProcess
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsSecondaryUnityProcess, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsSecondaryUnityProcess, (void*)(&value));
		}
	}

	public unsafe bool _enableBurstCompilation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enableBurstCompilation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enableBurstCompilation)) = value;
		}
	}

	public unsafe bool _enableBurstSafetyChecks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enableBurstSafetyChecks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enableBurstSafetyChecks)) = value;
		}
	}

	public unsafe bool _IsGlobal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsGlobal_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsGlobal_k__BackingField)) = value;
		}
	}

	public unsafe Il2CppSystem.Action _OptionsChanged_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OptionsChanged_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OptionsChanged_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool IsGlobal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsGlobal_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool EnableBurstCompilation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EnableBurstCompilation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959084, XrefRangeEnd = 959094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EnableBurstCompilation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool EnableBurstSafetyChecks
	{
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EnableBurstSafetyChecks_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppSystem.Action OptionsChanged
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OptionsChanged_Internal_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
	}

	static BurstCompilerOptions()
	{
		Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstCompilerOptions");
		NativeFieldInfoPtr_ForceDisableBurstCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "ForceDisableBurstCompilation");
		NativeFieldInfoPtr_ForceBurstCompilationSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "ForceBurstCompilationSynchronously");
		NativeFieldInfoPtr_IsSecondaryUnityProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "IsSecondaryUnityProcess");
		NativeFieldInfoPtr__enableBurstCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "_enableBurstCompilation");
		NativeFieldInfoPtr__enableBurstSafetyChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "_enableBurstSafetyChecks");
		NativeFieldInfoPtr__IsGlobal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "<IsGlobal>k__BackingField");
		NativeFieldInfoPtr__OptionsChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "<OptionsChanged>k__BackingField");
		NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_get_IsGlobal_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_get_EnableBurstCompilation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_set_EnableBurstCompilation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_set_EnableBurstSafetyChecks_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_get_OptionsChanged_Internal_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_TryGetAttribute_Private_Static_Boolean_MemberInfo_byref_BurstCompileAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_GetBurstCompileAttribute_Private_Static_BurstCompileAttribute_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_HasBurstCompileAttribute_Internal_Static_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_OnOptionsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_MaybeTriggerRecompilation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_CheckIsSecondaryUnityProcess_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663339);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959073, XrefRangeEnd = 959084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BurstCompilerOptions(bool isGlobal)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isGlobal);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959094, XrefRangeEnd = 959101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)member);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetAttribute_Private_Static_Boolean_MemberInfo_byref_BurstCompileAttribute_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		attribute = ((num3 == 0) ? null : new BurstCompileAttribute(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 959135, RefRangeEnd = 959138, XrefRangeStart = 959101, XrefRangeEnd = 959135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)memberInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBurstCompileAttribute_Private_Static_BurstCompileAttribute_MemberInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BurstCompileAttribute>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959138, XrefRangeEnd = 959149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasBurstCompileAttribute(MemberInfo member)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)member);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasBurstCompileAttribute_Internal_Static_Boolean_MemberInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void OnOptionsChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnOptionsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MaybeTriggerRecompilation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaybeTriggerRecompilation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckIsSecondaryUnityProcess()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIsSecondaryUnityProcess_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public BurstCompilerOptions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
