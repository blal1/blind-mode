using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public sealed class OcclusionTestComputeShader : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cs;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionDebugKeyword;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_ComputeShader_0;

	public unsafe ComputeShader cs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe LocalKeyword occlusionDebugKeyword
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionDebugKeyword);
			return new LocalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionDebugKeyword), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static OcclusionTestComputeShader()
	{
		Il2CppClassPointerStore<OcclusionTestComputeShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "OcclusionTestComputeShader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionTestComputeShader>.NativeClassPtr);
		NativeFieldInfoPtr_cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionTestComputeShader>.NativeClassPtr, "cs");
		NativeFieldInfoPtr_occlusionDebugKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionTestComputeShader>.NativeClassPtr, "occlusionDebugKeyword");
		NativeMethodInfoPtr_Init_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionTestComputeShader>.NativeClassPtr, 100663969);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074343, RefRangeEnd = 1074344, XrefRangeStart = 1074338, XrefRangeEnd = 1074343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(ComputeShader cs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_ComputeShader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public OcclusionTestComputeShader(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public OcclusionTestComputeShader()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OcclusionTestComputeShader>.NativeClassPtr))
	{
	}
}
