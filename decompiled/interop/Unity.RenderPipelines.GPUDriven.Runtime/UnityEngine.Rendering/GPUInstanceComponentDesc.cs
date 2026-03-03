using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GPUInstanceComponentDesc
{
	private static readonly System.IntPtr NativeFieldInfoPtr_propertyID;

	private static readonly System.IntPtr NativeFieldInfoPtr_byteSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOverriden;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPerInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceType;

	private static readonly System.IntPtr NativeFieldInfoPtr_componentGroup;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_Boolean_InstanceType_InstanceComponentGroup_0;

	[FieldOffset(0)]
	public int propertyID;

	[FieldOffset(4)]
	public int byteSize;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool isOverriden;

	[FieldOffset(9)]
	[MarshalAs(UnmanagedType.U1)]
	public bool isPerInstance;

	[FieldOffset(12)]
	public InstanceType instanceType;

	[FieldOffset(16)]
	public InstanceComponentGroup componentGroup;

	static GPUInstanceComponentDesc()
	{
		Il2CppClassPointerStore<GPUInstanceComponentDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "GPUInstanceComponentDesc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUInstanceComponentDesc>.NativeClassPtr);
		NativeFieldInfoPtr_propertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceComponentDesc>.NativeClassPtr, "propertyID");
		NativeFieldInfoPtr_byteSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceComponentDesc>.NativeClassPtr, "byteSize");
		NativeFieldInfoPtr_isOverriden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceComponentDesc>.NativeClassPtr, "isOverriden");
		NativeFieldInfoPtr_isPerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceComponentDesc>.NativeClassPtr, "isPerInstance");
		NativeFieldInfoPtr_instanceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceComponentDesc>.NativeClassPtr, "instanceType");
		NativeFieldInfoPtr_componentGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceComponentDesc>.NativeClassPtr, "componentGroup");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_Boolean_InstanceType_InstanceComponentGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceComponentDesc>.NativeClassPtr, 100663675);
	}

	[CallerCount(0)]
	public unsafe GPUInstanceComponentDesc(int inPropertyID, int inByteSize, bool inIsOverriden, bool inPerInstance, InstanceType inInstanceType, InstanceComponentGroup inComponentType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&inPropertyID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inByteSize;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inIsOverriden;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inPerInstance;
		*(InstanceType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &inInstanceType;
		*(InstanceComponentGroup**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &inComponentType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_Boolean_InstanceType_InstanceComponentGroup_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUInstanceComponentDesc>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
