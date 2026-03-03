using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

public class GraphicsTexture
{
	public static class BindingsMarshaller
	{
	}

	private delegate GraphicsTextureState get_state_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetActive_InjectedDelegate();

	private delegate void SetActive_InjectedDelegate(System.IntPtr target);

	private delegate void ReleaseBuffer_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ReleaseBufferOnMain_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool UploadBuffer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, ulong size);

	private delegate bool UploadBuffer_Array_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data);

	private static readonly get_state_InjectedDelegate get_state_InjectedDelegateField = IL2CPP.ResolveICall<get_state_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::get_state_Injected");

	private static readonly GetActive_InjectedDelegate GetActive_InjectedDelegateField = IL2CPP.ResolveICall<GetActive_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::GetActive_Injected");

	private static readonly SetActive_InjectedDelegate SetActive_InjectedDelegateField = IL2CPP.ResolveICall<SetActive_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::SetActive_Injected");

	private static readonly ReleaseBuffer_InjectedDelegate ReleaseBuffer_InjectedDelegateField = IL2CPP.ResolveICall<ReleaseBuffer_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::ReleaseBuffer_Injected");

	private static readonly ReleaseBufferOnMain_InjectedDelegate ReleaseBufferOnMain_InjectedDelegateField = IL2CPP.ResolveICall<ReleaseBufferOnMain_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::ReleaseBufferOnMain_Injected");

	private static readonly UploadBuffer_InjectedDelegate UploadBuffer_InjectedDelegateField = IL2CPP.ResolveICall<UploadBuffer_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::UploadBuffer_Injected");

	private static readonly UploadBuffer_Array_InjectedDelegate UploadBuffer_Array_InjectedDelegateField = IL2CPP.ResolveICall<UploadBuffer_Array_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::UploadBuffer_Array_Injected");

	public GraphicsTextureState state
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			return get_state_Injected(intPtr);
		}
	}

	public static GraphicsTexture active
	{
		get
		{
			return GetActive();
		}
		set
		{
			SetActive(value);
		}
	}

	~GraphicsTexture()
	{
		try
		{
			Dispose(disposing: false);
		}
		finally
		{
			((Il2CppSystem.Object)this).Finalize();
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		Il2CppSystem.GC.SuppressFinalize((Il2CppSystem.Object)(object)this);
	}

	public void Dispose(bool disposing)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void UploadData(System.IntPtr data, int size)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void UploadData(Il2CppStructArray<byte> data)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static GraphicsTexture GetActive()
	{
		System.IntPtr active_Injected = GetActive_Injected();
		return (active_Injected == (System.IntPtr)0) ? null : BindingsMarshaller.ConvertToManaged(active_Injected);
	}

	public static void SetActive(GraphicsTexture target)
	{
		SetActive_Injected((target == null) ? ((System.IntPtr)0) : BindingsMarshaller.ConvertToNative(target));
	}

	public void ReleaseBuffer()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		ReleaseBuffer_Injected(intPtr);
	}

	public void ReleaseBufferOnMain()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		ReleaseBufferOnMain_Injected(intPtr);
	}

	public bool UploadBuffer(System.IntPtr data, ulong size)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return UploadBuffer_Injected(intPtr, data, size);
	}

	public unsafe bool UploadBuffer_Array(Il2CppStructArray<byte> data)
	{
		//IL_0018: Expected O, but got Ref
		//IL_001f: Expected O, but got Ref
		//IL_002b: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<byte> span);
		((Il2CppSystem.Span<byte>)(&span))._002Ector((Il2CppArrayBase<byte>)(object)data);
		bool result;
		fixed (byte* begin = &((Il2CppSystem.Span<byte>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper data2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<byte>)(&span)).Length);
			result = UploadBuffer_Array_Injected(intPtr, ref data2);
		}
		return result;
	}

	public static GraphicsTextureState get_state_Injected(System.IntPtr _unity_self)
	{
		return get_state_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr GetActive_Injected()
	{
		return GetActive_InjectedDelegateField();
	}

	public static void SetActive_Injected(System.IntPtr target)
	{
		SetActive_InjectedDelegateField(target);
	}

	public static void ReleaseBuffer_Injected(System.IntPtr _unity_self)
	{
		ReleaseBuffer_InjectedDelegateField(_unity_self);
	}

	public static void ReleaseBufferOnMain_Injected(System.IntPtr _unity_self)
	{
		ReleaseBufferOnMain_InjectedDelegateField(_unity_self);
	}

	public static bool UploadBuffer_Injected(System.IntPtr _unity_self, System.IntPtr data, ulong size)
	{
		return UploadBuffer_InjectedDelegateField(_unity_self, data, size);
	}

	public unsafe static bool UploadBuffer_Array_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper data)
	{
		return UploadBuffer_Array_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref data));
	}
}
