using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public static class TerrainCallbacks : Il2CppSystem.Object
{
	public sealed class HeightmapChangedCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_RectInt_Boolean_0;

		static HeightmapChangedCallback()
		{
			Il2CppClassPointerStore<HeightmapChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "HeightmapChangedCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightmapChangedCallback>.NativeClassPtr, 100663309);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightmapChangedCallback>.NativeClassPtr, 100663310);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272025, XrefRangeEnd = 1272029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeightmapChangedCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeightmapChangedCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(Terrain terrain, RectInt heightRegion, bool synched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrain);
			*(RectInt**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightRegion;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &synched;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_RectInt_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public HeightmapChangedCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator HeightmapChangedCallback(System.Action<Terrain, RectInt, bool> P_0)
		{
			return DelegateSupport.ConvertDelegate<HeightmapChangedCallback>((System.Delegate)P_0);
		}

		public static HeightmapChangedCallback operator +(HeightmapChangedCallback P_0, HeightmapChangedCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<HeightmapChangedCallback>();
		}

		public static HeightmapChangedCallback operator -(HeightmapChangedCallback P_0, HeightmapChangedCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<HeightmapChangedCallback>();
			}
			return (HeightmapChangedCallback)obj;
		}
	}

	public sealed class TextureChangedCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_String_RectInt_Boolean_0;

		static TextureChangedCallback()
		{
			Il2CppClassPointerStore<TextureChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "TextureChangedCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureChangedCallback>.NativeClassPtr, 100663311);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_String_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureChangedCallback>.NativeClassPtr, 100663312);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272029, XrefRangeEnd = 1272033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureChangedCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureChangedCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrain);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(textureName);
			*(RectInt**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &texelRegion;
			*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &synched;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_String_RectInt_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public TextureChangedCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator TextureChangedCallback(System.Action<Terrain, string, RectInt, bool> P_0)
		{
			return DelegateSupport.ConvertDelegate<TextureChangedCallback>((System.Delegate)P_0);
		}

		public static TextureChangedCallback operator +(TextureChangedCallback P_0, TextureChangedCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<TextureChangedCallback>();
		}

		public static TextureChangedCallback operator -(TextureChangedCallback P_0, TextureChangedCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<TextureChangedCallback>();
			}
			return (TextureChangedCallback)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_heightmapChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeHeightmapChangedCallback_Internal_Static_Void_TerrainData_RectInt_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeTextureChangedCallback_Internal_Static_Void_TerrainData_String_RectInt_Boolean_0;

	public unsafe static HeightmapChangedCallback heightmapChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_heightmapChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeightmapChangedCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_heightmapChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static TextureChangedCallback textureChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_textureChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureChangedCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_textureChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TerrainCallbacks()
	{
		Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine", "TerrainCallbacks");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr);
		NativeFieldInfoPtr_heightmapChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "heightmapChanged");
		NativeFieldInfoPtr_textureChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "textureChanged");
		NativeMethodInfoPtr_InvokeHeightmapChangedCallback_Internal_Static_Void_TerrainData_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_InvokeTextureChangedCallback_Internal_Static_Void_TerrainData_String_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, 100663308);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272033, XrefRangeEnd = 1272044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainData);
		*(RectInt**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightRegion;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &synched;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeHeightmapChangedCallback_Internal_Static_Void_TerrainData_RectInt_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272044, XrefRangeEnd = 1272055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(textureName);
		*(RectInt**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &texelRegion;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &synched;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeTextureChangedCallback_Internal_Static_Void_TerrainData_String_RectInt_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TerrainCallbacks(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_heightmapChanged(HeightmapChangedCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_heightmapChanged(HeightmapChangedCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_textureChanged(TextureChangedCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_textureChanged(TextureChangedCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
