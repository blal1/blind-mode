using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSpine;

public class PhysicsConstraintInertiaTimeline : PhysicsConstraintTimeline
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Protected_Virtual_Single_PhysicsConstraint_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Protected_Virtual_Single_PhysicsConstraint_0;

	private static readonly IntPtr NativeMethodInfoPtr_Set_Protected_Virtual_Void_PhysicsConstraint_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Global_Protected_Virtual_Boolean_PhysicsConstraintData_0;

	static PhysicsConstraintInertiaTimeline()
	{
		Il2CppClassPointerStore<PhysicsConstraintInertiaTimeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "PhysicsConstraintInertiaTimeline");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsConstraintInertiaTimeline>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsConstraintInertiaTimeline>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_Setup_Protected_Virtual_Single_PhysicsConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsConstraintInertiaTimeline>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_Get_Protected_Virtual_Single_PhysicsConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsConstraintInertiaTimeline>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_Set_Protected_Virtual_Void_PhysicsConstraint_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsConstraintInertiaTimeline>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_Global_Protected_Virtual_Boolean_PhysicsConstraintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsConstraintInertiaTimeline>.NativeClassPtr, 100663457);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 841347, RefRangeEnd = 841349, XrefRangeStart = 841346, XrefRangeEnd = 841347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PhysicsConstraintInertiaTimeline(int frameCount, int bezierCount, int physicsConstraintIndex)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsConstraintInertiaTimeline>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&frameCount);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &bezierCount;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &physicsConstraintIndex;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override float Setup(PhysicsConstraint constraint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Setup_Protected_Virtual_Single_PhysicsConstraint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe override float Get(PhysicsConstraint constraint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Get_Protected_Virtual_Single_PhysicsConstraint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe override void Set(PhysicsConstraint constraint, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Set_Protected_Virtual_Void_PhysicsConstraint_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override bool Global(PhysicsConstraintData constraint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Global_Protected_Virtual_Boolean_PhysicsConstraintData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public PhysicsConstraintInertiaTimeline(IntPtr pointer)
		: base(pointer)
	{
	}
}
