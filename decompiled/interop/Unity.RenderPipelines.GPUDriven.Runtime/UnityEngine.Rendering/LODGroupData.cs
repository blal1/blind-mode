using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct LODGroupData
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.LODGroupData+<fadeTransitionWidth>e__FixedBuffer")]
	public struct _fadeTransitionWidth_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public float FixedElementField;

		static _fadeTransitionWidth_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_fadeTransitionWidth_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LODGroupData>.NativeClassPtr, "<fadeTransitionWidth>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_fadeTransitionWidth_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_fadeTransitionWidth_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_fadeTransitionWidth_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.LODGroupData+<screenRelativeTransitionHeights>e__FixedBuffer")]
	public struct _screenRelativeTransitionHeights_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public float FixedElementField;

		static _screenRelativeTransitionHeights_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_screenRelativeTransitionHeights_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LODGroupData>.NativeClassPtr, "<screenRelativeTransitionHeights>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_screenRelativeTransitionHeights_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_screenRelativeTransitionHeights_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_screenRelativeTransitionHeights_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_valid;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenRelativeTransitionHeights;

	private static readonly System.IntPtr NativeFieldInfoPtr_fadeTransitionWidth;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool valid;

	[FieldOffset(4)]
	public int lodCount;

	[FieldOffset(8)]
	public int rendererCount;

	[FieldOffset(12)]
	public _screenRelativeTransitionHeights_e__FixedBuffer screenRelativeTransitionHeights;

	[FieldOffset(44)]
	public _fadeTransitionWidth_e__FixedBuffer fadeTransitionWidth;

	static LODGroupData()
	{
		Il2CppClassPointerStore<LODGroupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "LODGroupData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODGroupData>.NativeClassPtr);
		NativeFieldInfoPtr_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupData>.NativeClassPtr, "valid");
		NativeFieldInfoPtr_lodCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupData>.NativeClassPtr, "lodCount");
		NativeFieldInfoPtr_rendererCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupData>.NativeClassPtr, "rendererCount");
		NativeFieldInfoPtr_screenRelativeTransitionHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupData>.NativeClassPtr, "screenRelativeTransitionHeights");
		NativeFieldInfoPtr_fadeTransitionWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupData>.NativeClassPtr, "fadeTransitionWidth");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LODGroupData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
