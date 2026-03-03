using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine;

public sealed class SparseTexture : Texture
{
	private delegate void Internal_CreateDelegate(System.IntPtr mono, int width, int height, GraphicsFormat format, TextureColorSpace colorSpace, int mipCount);

	private delegate int get_tileWidth_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_tileHeight_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_isCreated_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void UpdateTile_InjectedDelegate(System.IntPtr _unity_self, int tileX, int tileY, int miplevel, System.IntPtr data);

	private delegate void UpdateTileRaw_InjectedDelegate(System.IntPtr _unity_self, int tileX, int tileY, int miplevel, System.IntPtr data);

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngine.SparseTexture::Internal_Create");

	private static readonly get_tileWidth_InjectedDelegate get_tileWidth_InjectedDelegateField = IL2CPP.ResolveICall<get_tileWidth_InjectedDelegate>("UnityEngine.SparseTexture::get_tileWidth_Injected");

	private static readonly get_tileHeight_InjectedDelegate get_tileHeight_InjectedDelegateField = IL2CPP.ResolveICall<get_tileHeight_InjectedDelegate>("UnityEngine.SparseTexture::get_tileHeight_Injected");

	private static readonly get_isCreated_InjectedDelegate get_isCreated_InjectedDelegateField = IL2CPP.ResolveICall<get_isCreated_InjectedDelegate>("UnityEngine.SparseTexture::get_isCreated_Injected");

	private static readonly UpdateTile_InjectedDelegate UpdateTile_InjectedDelegateField = IL2CPP.ResolveICall<UpdateTile_InjectedDelegate>("UnityEngine.SparseTexture::UpdateTile_Injected");

	private static readonly UpdateTileRaw_InjectedDelegate UpdateTileRaw_InjectedDelegateField = IL2CPP.ResolveICall<UpdateTileRaw_InjectedDelegate>("UnityEngine.SparseTexture::UpdateTileRaw_Injected");

	public int tileWidth
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_tileWidth_Injected(intPtr);
		}
	}

	public int tileHeight
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_tileHeight_Injected(intPtr);
		}
	}

	public bool isCreated
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isCreated_Injected(intPtr);
		}
	}

	public static void Internal_Create(SparseTexture mono, int width, int height, GraphicsFormat format, TextureColorSpace colorSpace, int mipCount)
	{
		Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono), width, height, format, colorSpace, mipCount);
	}

	public unsafe void UpdateTile(int tileX, int tileY, int miplevel, Il2CppStructArray<Color32> data)
	{
		//IL_001c: Expected O, but got Ref
		//IL_0023: Expected O, but got Ref
		//IL_002f: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Color32> span);
		((Il2CppSystem.Span<Color32>)(&span))._002Ector((Il2CppArrayBase<Color32>)(object)data);
		fixed (Color32* begin = &((Il2CppSystem.Span<Color32>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper data2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Color32>)(&span)).Length);
			UpdateTile_Injected(intPtr, tileX, tileY, miplevel, ref data2);
		}
	}

	public unsafe void UpdateTileRaw(int tileX, int tileY, int miplevel, Il2CppStructArray<byte> data)
	{
		//IL_001c: Expected O, but got Ref
		//IL_0023: Expected O, but got Ref
		//IL_002f: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<byte> span);
		((Il2CppSystem.Span<byte>)(&span))._002Ector((Il2CppArrayBase<byte>)(object)data);
		fixed (byte* begin = &((Il2CppSystem.Span<byte>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper data2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<byte>)(&span)).Length);
			UpdateTileRaw_Injected(intPtr, tileX, tileY, miplevel, ref data2);
		}
	}

	public void UnloadTile(int tileX, int tileY, int miplevel)
	{
		UpdateTileRaw(tileX, tileY, miplevel, null);
	}

	public bool ValidateFormat(TextureFormat format, int width, int height)
	{
		bool flag = ValidateFormat(format);
		if (flag && TextureFormat.PVRTC_RGB2 <= format && format <= TextureFormat.PVRTC_RGBA4 && (width != height || !Mathf.IsPowerOfTwo(width)))
		{
			throw new UnityException(Il2CppSystem.String.Format("'{0}' demands texture to be square and have power-of-two dimensions", (Il2CppSystem.Object)((Il2CppSystem.Object)format).ToString()));
		}
		return flag;
	}

	public bool ValidateFormat(GraphicsFormat format, int width, int height)
	{
		bool flag = ValidateFormat(format, GraphicsFormatUsage.Sparse);
		if (flag && GraphicsFormatUtility.IsPVRTCFormat(format) && (width != height || !Mathf.IsPowerOfTwo(width)))
		{
			throw new UnityException(Il2CppSystem.String.Format("'{0}' demands texture to be square and have power-of-two dimensions", (Il2CppSystem.Object)((Il2CppSystem.Object)format).ToString()));
		}
		return flag;
	}

	public bool ValidateSize(int width, int height, GraphicsFormat format)
	{
		if (GraphicsFormatUtility.GetBlockSize(format) * (width / GraphicsFormatUtility.GetBlockWidth(format)) * (height / GraphicsFormatUtility.GetBlockHeight(format)) < 65536)
		{
			Debug.LogError("SparseTexture creation failed. The minimum size in bytes of a SparseTexture is 64KB.", this);
			return false;
		}
		return true;
	}

	public static void ValidateIsNotCrunched(TextureFormat textureFormat)
	{
		if (GraphicsFormatUtility.IsCrunchFormat(textureFormat))
		{
			throw new Il2CppSystem.ArgumentException("Crunched SparseTexture is not supported.");
		}
	}

	public static int get_tileWidth_Injected(System.IntPtr _unity_self)
	{
		return get_tileWidth_InjectedDelegateField(_unity_self);
	}

	public static int get_tileHeight_Injected(System.IntPtr _unity_self)
	{
		return get_tileHeight_InjectedDelegateField(_unity_self);
	}

	public static bool get_isCreated_Injected(System.IntPtr _unity_self)
	{
		return get_isCreated_InjectedDelegateField(_unity_self);
	}

	public unsafe static void UpdateTile_Injected(System.IntPtr _unity_self, int tileX, int tileY, int miplevel, ref ManagedSpanWrapper data)
	{
		UpdateTile_InjectedDelegateField(_unity_self, tileX, tileY, miplevel, (nint)Unsafe.AsPointer(ref data));
	}

	public unsafe static void UpdateTileRaw_Injected(System.IntPtr _unity_self, int tileX, int tileY, int miplevel, ref ManagedSpanWrapper data)
	{
		UpdateTileRaw_InjectedDelegateField(_unity_self, tileX, tileY, miplevel, (nint)Unsafe.AsPointer(ref data));
	}
}
