using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Hierarchy;

[StructLayout(LayoutKind.Explicit)]
public struct HierarchyNodeChildrenAlloc
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("Unity.Hierarchy.HierarchyNodeChildrenAlloc+<Reserved>e__FixedBuffer")]
	public struct _Reserved_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public int FixedElementField;

		static _Reserved_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_Reserved_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HierarchyNodeChildrenAlloc>.NativeClassPtr, "<Reserved>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_Reserved_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Reserved_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_Reserved_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_Size;

	private static readonly System.IntPtr NativeFieldInfoPtr_Capacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_RemovedCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_Reserved;

	[FieldOffset(0)]
	public System.IntPtr Ptr;

	[FieldOffset(8)]
	public int Size;

	[FieldOffset(12)]
	public int Capacity;

	[FieldOffset(16)]
	public int RemovedCount;

	[FieldOffset(20)]
	public _Reserved_e__FixedBuffer Reserved;

	static HierarchyNodeChildrenAlloc()
	{
		Il2CppClassPointerStore<HierarchyNodeChildrenAlloc>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "HierarchyNodeChildrenAlloc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyNodeChildrenAlloc>.NativeClassPtr);
		NativeFieldInfoPtr_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyNodeChildrenAlloc>.NativeClassPtr, "Ptr");
		NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyNodeChildrenAlloc>.NativeClassPtr, "Size");
		NativeFieldInfoPtr_Capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyNodeChildrenAlloc>.NativeClassPtr, "Capacity");
		NativeFieldInfoPtr_RemovedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyNodeChildrenAlloc>.NativeClassPtr, "RemovedCount");
		NativeFieldInfoPtr_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyNodeChildrenAlloc>.NativeClassPtr, "Reserved");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HierarchyNodeChildrenAlloc>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
