using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct LODGroupCullingData
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.LODGroupCullingData+<percentageFlags>e__FixedBuffer")]
	public struct _percentageFlags_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool FixedElementField;

		static _percentageFlags_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_percentageFlags_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr, "<percentageFlags>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_percentageFlags_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_percentageFlags_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_percentageFlags_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.LODGroupCullingData+<sqrDistances>e__FixedBuffer")]
	public struct _sqrDistances_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public float FixedElementField;

		static _sqrDistances_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_sqrDistances_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr, "<sqrDistances>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_sqrDistances_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_sqrDistances_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_sqrDistances_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.LODGroupCullingData+<transitionDistances>e__FixedBuffer")]
	public struct _transitionDistances_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public float FixedElementField;

		static _transitionDistances_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_transitionDistances_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr, "<transitionDistances>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_transitionDistances_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_transitionDistances_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_transitionDistances_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceReferencePoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_sqrDistances;

	private static readonly System.IntPtr NativeFieldInfoPtr_transitionDistances;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_percentageFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceLODMask;

	[FieldOffset(0)]
	public float3 worldSpaceReferencePoint;

	[FieldOffset(12)]
	public int lodCount;

	[FieldOffset(16)]
	public _sqrDistances_e__FixedBuffer sqrDistances;

	[FieldOffset(48)]
	public _transitionDistances_e__FixedBuffer transitionDistances;

	[FieldOffset(80)]
	public float worldSpaceSize;

	[FieldOffset(84)]
	public _percentageFlags_e__FixedBuffer percentageFlags;

	[FieldOffset(92)]
	public byte forceLODMask;

	static LODGroupCullingData()
	{
		Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "LODGroupCullingData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr);
		NativeFieldInfoPtr_worldSpaceReferencePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr, "worldSpaceReferencePoint");
		NativeFieldInfoPtr_lodCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr, "lodCount");
		NativeFieldInfoPtr_sqrDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr, "sqrDistances");
		NativeFieldInfoPtr_transitionDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr, "transitionDistances");
		NativeFieldInfoPtr_worldSpaceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr, "worldSpaceSize");
		NativeFieldInfoPtr_percentageFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr, "percentageFlags");
		NativeFieldInfoPtr_forceLODMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr, "forceLODMask");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LODGroupCullingData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
