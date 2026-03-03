using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;
using UnityEngine.U2D;

namespace UnityEngine.Tilemaps;

public sealed class TilemapRenderer : Renderer
{
	public enum SortOrder
	{
		BottomLeft,
		BottomRight,
		TopLeft,
		TopRight
	}

	public enum Mode
	{
		Chunk,
		Individual,
		SRPBatch
	}

	public enum DetectChunkCullingBounds
	{
		Auto,
		Manual
	}

	private delegate void get_chunkSize_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_chunkSize_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_chunkCullingBounds_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_chunkCullingBounds_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate int get_maxChunkCount_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxChunkCount_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate int get_maxFrameAge_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxFrameAge_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate SortOrder get_sortOrder_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_sortOrder_InjectedDelegate(IntPtr _unity_self, SortOrder value);

	private delegate Mode get_mode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_mode_InjectedDelegate(IntPtr _unity_self, Mode value);

	private delegate DetectChunkCullingBounds get_detectChunkCullingBounds_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_detectChunkCullingBounds_InjectedDelegate(IntPtr _unity_self, DetectChunkCullingBounds value);

	private delegate SpriteMaskInteraction get_maskInteraction_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maskInteraction_InjectedDelegate(IntPtr _unity_self, SpriteMaskInteraction value);

	private static readonly IntPtr NativeMethodInfoPtr_RegisterSpriteAtlasRegistered_Internal_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnregisterSpriteAtlasRegistered_Internal_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnSpriteAtlasRegistered_Internal_Void_SpriteAtlas_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnSpriteAtlasRegistered_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly get_chunkSize_InjectedDelegate get_chunkSize_InjectedDelegateField;

	private static readonly set_chunkSize_InjectedDelegate set_chunkSize_InjectedDelegateField;

	private static readonly get_chunkCullingBounds_InjectedDelegate get_chunkCullingBounds_InjectedDelegateField;

	private static readonly set_chunkCullingBounds_InjectedDelegate set_chunkCullingBounds_InjectedDelegateField;

	private static readonly get_maxChunkCount_InjectedDelegate get_maxChunkCount_InjectedDelegateField;

	private static readonly set_maxChunkCount_InjectedDelegate set_maxChunkCount_InjectedDelegateField;

	private static readonly get_maxFrameAge_InjectedDelegate get_maxFrameAge_InjectedDelegateField;

	private static readonly set_maxFrameAge_InjectedDelegate set_maxFrameAge_InjectedDelegateField;

	private static readonly get_sortOrder_InjectedDelegate get_sortOrder_InjectedDelegateField;

	private static readonly set_sortOrder_InjectedDelegate set_sortOrder_InjectedDelegateField;

	private static readonly get_mode_InjectedDelegate get_mode_InjectedDelegateField;

	private static readonly set_mode_InjectedDelegate set_mode_InjectedDelegateField;

	private static readonly get_detectChunkCullingBounds_InjectedDelegate get_detectChunkCullingBounds_InjectedDelegateField;

	private static readonly set_detectChunkCullingBounds_InjectedDelegate set_detectChunkCullingBounds_InjectedDelegateField;

	private static readonly get_maskInteraction_InjectedDelegate get_maskInteraction_InjectedDelegateField;

	private static readonly set_maskInteraction_InjectedDelegate set_maskInteraction_InjectedDelegateField;

	public Vector3Int chunkSize
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_chunkSize_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_chunkSize_Injected(intPtr, ref value);
		}
	}

	public Vector3 chunkCullingBounds
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_chunkCullingBounds_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_chunkCullingBounds_Injected(intPtr, ref value);
		}
	}

	public int maxChunkCount
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxChunkCount_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxChunkCount_Injected(intPtr, value);
		}
	}

	public int maxFrameAge
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxFrameAge_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxFrameAge_Injected(intPtr, value);
		}
	}

	public SortOrder sortOrder
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sortOrder_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sortOrder_Injected(intPtr, value);
		}
	}

	public Mode mode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_mode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_mode_Injected(intPtr, value);
		}
	}

	public DetectChunkCullingBounds detectChunkCullingBounds
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_detectChunkCullingBounds_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_detectChunkCullingBounds_Injected(intPtr, value);
		}
	}

	public SpriteMaskInteraction maskInteraction
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maskInteraction_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maskInteraction_Injected(intPtr, value);
		}
	}

	static TilemapRenderer()
	{
		Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TilemapRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr);
		NativeMethodInfoPtr_RegisterSpriteAtlasRegistered_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_UnregisterSpriteAtlasRegistered_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_OnSpriteAtlasRegistered_Internal_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_OnSpriteAtlasRegistered_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr, 100663347);
		get_chunkSize_InjectedDelegateField = IL2CPP.ResolveICall<get_chunkSize_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_chunkSize_Injected");
		set_chunkSize_InjectedDelegateField = IL2CPP.ResolveICall<set_chunkSize_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_chunkSize_Injected");
		get_chunkCullingBounds_InjectedDelegateField = IL2CPP.ResolveICall<get_chunkCullingBounds_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_chunkCullingBounds_Injected");
		set_chunkCullingBounds_InjectedDelegateField = IL2CPP.ResolveICall<set_chunkCullingBounds_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_chunkCullingBounds_Injected");
		get_maxChunkCount_InjectedDelegateField = IL2CPP.ResolveICall<get_maxChunkCount_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_maxChunkCount_Injected");
		set_maxChunkCount_InjectedDelegateField = IL2CPP.ResolveICall<set_maxChunkCount_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_maxChunkCount_Injected");
		get_maxFrameAge_InjectedDelegateField = IL2CPP.ResolveICall<get_maxFrameAge_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_maxFrameAge_Injected");
		set_maxFrameAge_InjectedDelegateField = IL2CPP.ResolveICall<set_maxFrameAge_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_maxFrameAge_Injected");
		get_sortOrder_InjectedDelegateField = IL2CPP.ResolveICall<get_sortOrder_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_sortOrder_Injected");
		set_sortOrder_InjectedDelegateField = IL2CPP.ResolveICall<set_sortOrder_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_sortOrder_Injected");
		get_mode_InjectedDelegateField = IL2CPP.ResolveICall<get_mode_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_mode_Injected");
		set_mode_InjectedDelegateField = IL2CPP.ResolveICall<set_mode_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_mode_Injected");
		get_detectChunkCullingBounds_InjectedDelegateField = IL2CPP.ResolveICall<get_detectChunkCullingBounds_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_detectChunkCullingBounds_Injected");
		set_detectChunkCullingBounds_InjectedDelegateField = IL2CPP.ResolveICall<set_detectChunkCullingBounds_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_detectChunkCullingBounds_Injected");
		get_maskInteraction_InjectedDelegateField = IL2CPP.ResolveICall<get_maskInteraction_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_maskInteraction_Injected");
		set_maskInteraction_InjectedDelegateField = IL2CPP.ResolveICall<set_maskInteraction_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_maskInteraction_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285460, XrefRangeEnd = 1285467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterSpriteAtlasRegistered()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterSpriteAtlasRegistered_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285467, XrefRangeEnd = 1285474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterSpriteAtlasRegistered()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterSpriteAtlasRegistered_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285474, XrefRangeEnd = 1285482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSpriteAtlasRegistered(SpriteAtlas atlas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)atlas);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSpriteAtlasRegistered_Internal_Void_SpriteAtlas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285482, XrefRangeEnd = 1285484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnSpriteAtlasRegistered_Injected(IntPtr _unity_self, IntPtr atlas)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &atlas;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSpriteAtlasRegistered_Injected_Private_Static_Void_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TilemapRenderer(IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void get_chunkSize_Injected(IntPtr _unity_self, out Vector3Int ret)
	{
		get_chunkSize_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_chunkSize_Injected(IntPtr _unity_self, [In] ref Vector3Int value)
	{
		set_chunkSize_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_chunkCullingBounds_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_chunkCullingBounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_chunkCullingBounds_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_chunkCullingBounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static int get_maxChunkCount_Injected(IntPtr _unity_self)
	{
		return get_maxChunkCount_InjectedDelegateField(_unity_self);
	}

	public static void set_maxChunkCount_Injected(IntPtr _unity_self, int value)
	{
		set_maxChunkCount_InjectedDelegateField(_unity_self, value);
	}

	public static int get_maxFrameAge_Injected(IntPtr _unity_self)
	{
		return get_maxFrameAge_InjectedDelegateField(_unity_self);
	}

	public static void set_maxFrameAge_Injected(IntPtr _unity_self, int value)
	{
		set_maxFrameAge_InjectedDelegateField(_unity_self, value);
	}

	public static SortOrder get_sortOrder_Injected(IntPtr _unity_self)
	{
		return get_sortOrder_InjectedDelegateField(_unity_self);
	}

	public static void set_sortOrder_Injected(IntPtr _unity_self, SortOrder value)
	{
		set_sortOrder_InjectedDelegateField(_unity_self, value);
	}

	public static Mode get_mode_Injected(IntPtr _unity_self)
	{
		return get_mode_InjectedDelegateField(_unity_self);
	}

	public static void set_mode_Injected(IntPtr _unity_self, Mode value)
	{
		set_mode_InjectedDelegateField(_unity_self, value);
	}

	public static DetectChunkCullingBounds get_detectChunkCullingBounds_Injected(IntPtr _unity_self)
	{
		return get_detectChunkCullingBounds_InjectedDelegateField(_unity_self);
	}

	public static void set_detectChunkCullingBounds_Injected(IntPtr _unity_self, DetectChunkCullingBounds value)
	{
		set_detectChunkCullingBounds_InjectedDelegateField(_unity_self, value);
	}

	public static SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self)
	{
		return get_maskInteraction_InjectedDelegateField(_unity_self);
	}

	public static void set_maskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction value)
	{
		set_maskInteraction_InjectedDelegateField(_unity_self, value);
	}
}
