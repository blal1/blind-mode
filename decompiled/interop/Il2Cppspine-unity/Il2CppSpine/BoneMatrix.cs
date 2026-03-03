using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppSpine;

[StructLayout(LayoutKind.Explicit)]
public struct BoneMatrix
{
	private static readonly System.IntPtr NativeFieldInfoPtr_a;

	private static readonly System.IntPtr NativeFieldInfoPtr_b;

	private static readonly System.IntPtr NativeFieldInfoPtr_c;

	private static readonly System.IntPtr NativeFieldInfoPtr_d;

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSetupWorld_Public_Static_BoneMatrix_BoneData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInheritedInternal_Private_Static_BoneMatrix_BoneData_BoneMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BoneData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Bone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformMatrix_Public_BoneMatrix_BoneMatrix_0;

	[FieldOffset(0)]
	public float a;

	[FieldOffset(4)]
	public float b;

	[FieldOffset(8)]
	public float c;

	[FieldOffset(12)]
	public float d;

	[FieldOffset(16)]
	public float x;

	[FieldOffset(20)]
	public float y;

	static BoneMatrix()
	{
		Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine", "BoneMatrix");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr);
		NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr, "a");
		NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr, "b");
		NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr, "c");
		NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr, "d");
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr, "y");
		NativeMethodInfoPtr_CalculateSetupWorld_Public_Static_BoneMatrix_BoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_GetInheritedInternal_Private_Static_BoneMatrix_BoneData_BoneMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr__ctor_Public_Void_BoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr__ctor_Public_Void_Bone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_TransformMatrix_Public_BoneMatrix_BoneMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr, 100663303);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 850070, RefRangeEnd = 850072, XrefRangeStart = 850068, XrefRangeEnd = 850070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BoneMatrix CalculateSetupWorld(BoneData boneData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boneData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateSetupWorld_Public_Static_BoneMatrix_BoneData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BoneMatrix*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 850125, RefRangeEnd = 850126, XrefRangeStart = 850072, XrefRangeEnd = 850125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BoneMatrix GetInheritedInternal(BoneData boneData, BoneMatrix parentMatrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boneData);
		*(BoneMatrix**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parentMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInheritedInternal_Private_Static_BoneMatrix_BoneData_BoneMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BoneMatrix*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850126, XrefRangeEnd = 850133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BoneMatrix(BoneData boneData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boneData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BoneData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850133, XrefRangeEnd = 850140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BoneMatrix(Bone bone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Bone_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe BoneMatrix TransformMatrix(BoneMatrix local)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&local);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformMatrix_Public_BoneMatrix_BoneMatrix_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BoneMatrix*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoneMatrix>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
