using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public static class ShaderInput : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct LightData
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_position;

		private static readonly System.IntPtr NativeFieldInfoPtr_color;

		private static readonly System.IntPtr NativeFieldInfoPtr_attenuation;

		private static readonly System.IntPtr NativeFieldInfoPtr_spotDirection;

		private static readonly System.IntPtr NativeFieldInfoPtr_occlusionProbeChannels;

		private static readonly System.IntPtr NativeFieldInfoPtr_layerMask;

		[FieldOffset(0)]
		public Vector4 position;

		[FieldOffset(16)]
		public Vector4 color;

		[FieldOffset(32)]
		public Vector4 attenuation;

		[FieldOffset(48)]
		public Vector4 spotDirection;

		[FieldOffset(64)]
		public Vector4 occlusionProbeChannels;

		[FieldOffset(80)]
		public uint layerMask;

		static LightData()
		{
			Il2CppClassPointerStore<LightData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderInput>.NativeClassPtr, "LightData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightData>.NativeClassPtr);
			NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "position");
			NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "color");
			NativeFieldInfoPtr_attenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "attenuation");
			NativeFieldInfoPtr_spotDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "spotDirection");
			NativeFieldInfoPtr_occlusionProbeChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "occlusionProbeChannels");
			NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "layerMask");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	static ShaderInput()
	{
		Il2CppClassPointerStore<ShaderInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipeline.Universal.ShaderLibrary.dll", "UnityEngine.Rendering.Universal", "ShaderInput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderInput>.NativeClassPtr);
	}

	public ShaderInput(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
