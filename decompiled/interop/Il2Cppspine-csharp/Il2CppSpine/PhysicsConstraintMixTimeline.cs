using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSpine;

public class PhysicsConstraintMixTimeline : PhysicsConstraintTimeline
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Protected_Virtual_Single_PhysicsConstraint_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Protected_Virtual_Single_PhysicsConstraint_0;

	private static readonly IntPtr NativeMethodInfoPtr_Set_Protected_Virtual_Void_PhysicsConstraint_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Global_Protected_Virtual_Boolean_PhysicsConstraintData_0;

	static PhysicsConstraintMixTimeline()
	{
		Il2CppClassPointerStore<PhysicsConstraintMixTimeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "PhysicsConstraintMixTimeline");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsConstraintMixTimeline>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsConstraintMixTimeline>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_Setup_Protected_Virtual_Single_PhysicsConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsConstraintMixTimeline>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_Get_Protected_Virtual_Single_PhysicsConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsConstraintMixTimeline>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_Set_Protected_Virtual_Void_PhysicsConstraint_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsConstraintMixTimeline>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_Global_Protected_Virtual_Boolean_PhysicsConstraintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsConstraintMixTimeline>.NativeClassPtr, 100663487);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 841365, RefRangeEnd = 841367, XrefRangeStart = 841364, XrefRangeEnd = 841365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PhysicsConstraintMixTimeline(int frameCount, int bezierCount, int physicsConstraintIndex)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsConstraintMixTimeline>.NativeClassPtr))
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

	public PhysicsConstraintMixTimeline(IntPtr pointer)
		: base(pointer)
	{
	}
}
