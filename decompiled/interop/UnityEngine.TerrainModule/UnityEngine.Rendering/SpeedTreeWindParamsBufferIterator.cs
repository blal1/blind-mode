using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct SpeedTreeWindParamsBufferIterator
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.SpeedTreeWindParamsBufferIterator+<uintParamOffsets>e__FixedBuffer")]
	public struct _uintParamOffsets_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public int FixedElementField;

		static _uintParamOffsets_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_uintParamOffsets_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpeedTreeWindParamsBufferIterator>.NativeClassPtr, "<uintParamOffsets>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_uintParamOffsets_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_uintParamOffsets_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_uintParamOffsets_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_bufferPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_uintParamOffsets;

	private static readonly System.IntPtr NativeFieldInfoPtr_uintStride;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementsCount;

	[FieldOffset(0)]
	public System.IntPtr bufferPtr;

	[FieldOffset(8)]
	public _uintParamOffsets_e__FixedBuffer uintParamOffsets;

	[FieldOffset(72)]
	public int uintStride;

	[FieldOffset(76)]
	public int elementOffset;

	[FieldOffset(80)]
	public int elementsCount;

	static SpeedTreeWindParamsBufferIterator()
	{
		Il2CppClassPointerStore<SpeedTreeWindParamsBufferIterator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine.Rendering", "SpeedTreeWindParamsBufferIterator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeedTreeWindParamsBufferIterator>.NativeClassPtr);
		NativeFieldInfoPtr_bufferPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTreeWindParamsBufferIterator>.NativeClassPtr, "bufferPtr");
		NativeFieldInfoPtr_uintParamOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTreeWindParamsBufferIterator>.NativeClassPtr, "uintParamOffsets");
		NativeFieldInfoPtr_uintStride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTreeWindParamsBufferIterator>.NativeClassPtr, "uintStride");
		NativeFieldInfoPtr_elementOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTreeWindParamsBufferIterator>.NativeClassPtr, "elementOffset");
		NativeFieldInfoPtr_elementsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTreeWindParamsBufferIterator>.NativeClassPtr, "elementsCount");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpeedTreeWindParamsBufferIterator>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
