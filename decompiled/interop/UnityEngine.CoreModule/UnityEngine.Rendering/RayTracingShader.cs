using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

public sealed class RayTracingShader : Object
{
	private delegate float get_maxRecursionDepth_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetFloat_InjectedDelegate(System.IntPtr _unity_self, int nameID, float val);

	private delegate void SetInt_InjectedDelegate(System.IntPtr _unity_self, int nameID, int val);

	private delegate void SetVector_InjectedDelegate(System.IntPtr _unity_self, int nameID, [In] System.IntPtr val);

	private delegate void SetMatrix_InjectedDelegate(System.IntPtr _unity_self, int nameID, [In] System.IntPtr val);

	private delegate void SetFloatArray_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr values);

	private delegate void SetIntArray_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr values);

	private delegate void SetVectorArray_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr values);

	private delegate void SetMatrixArray_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr values);

	private delegate void SetTexture_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr texture);

	private delegate void SetBuffer_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr buffer);

	private delegate void SetGraphicsBuffer_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr buffer);

	private delegate void SetGraphicsBufferHandle_InjectedDelegate(System.IntPtr _unity_self, int nameID, [In] System.IntPtr bufferHandle);

	private delegate void SetConstantComputeBuffer_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr buffer, int offset, int size);

	private delegate void SetConstantGraphicsBuffer_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr buffer, int offset, int size);

	private delegate void SetAccelerationStructure_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr accelerationStructure);

	private delegate void SetShaderPass_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr passName);

	private delegate void SetTextureFromGlobal_InjectedDelegate(System.IntPtr _unity_self, int nameID, int globalTextureNameID);

	private delegate void Dispatch_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr rayGenFunctionName, int width, int height, int depth, System.IntPtr camera);

	private delegate void DispatchIndirect_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr rayGenFunctionName, System.IntPtr argsBuffer, uint argsOffset, System.IntPtr camera);

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly get_maxRecursionDepth_InjectedDelegate get_maxRecursionDepth_InjectedDelegateField;

	private static readonly SetFloat_InjectedDelegate SetFloat_InjectedDelegateField;

	private static readonly SetInt_InjectedDelegate SetInt_InjectedDelegateField;

	private static readonly SetVector_InjectedDelegate SetVector_InjectedDelegateField;

	private static readonly SetMatrix_InjectedDelegate SetMatrix_InjectedDelegateField;

	private static readonly SetFloatArray_InjectedDelegate SetFloatArray_InjectedDelegateField;

	private static readonly SetIntArray_InjectedDelegate SetIntArray_InjectedDelegateField;

	private static readonly SetVectorArray_InjectedDelegate SetVectorArray_InjectedDelegateField;

	private static readonly SetMatrixArray_InjectedDelegate SetMatrixArray_InjectedDelegateField;

	private static readonly SetTexture_InjectedDelegate SetTexture_InjectedDelegateField;

	private static readonly SetBuffer_InjectedDelegate SetBuffer_InjectedDelegateField;

	private static readonly SetGraphicsBuffer_InjectedDelegate SetGraphicsBuffer_InjectedDelegateField;

	private static readonly SetGraphicsBufferHandle_InjectedDelegate SetGraphicsBufferHandle_InjectedDelegateField;

	private static readonly SetConstantComputeBuffer_InjectedDelegate SetConstantComputeBuffer_InjectedDelegateField;

	private static readonly SetConstantGraphicsBuffer_InjectedDelegate SetConstantGraphicsBuffer_InjectedDelegateField;

	private static readonly SetAccelerationStructure_InjectedDelegate SetAccelerationStructure_InjectedDelegateField;

	private static readonly SetShaderPass_InjectedDelegate SetShaderPass_InjectedDelegateField;

	private static readonly SetTextureFromGlobal_InjectedDelegate SetTextureFromGlobal_InjectedDelegateField;

	private static readonly Dispatch_InjectedDelegate Dispatch_InjectedDelegateField;

	private static readonly DispatchIndirect_InjectedDelegate DispatchIndirect_InjectedDelegateField;

	public float maxRecursionDepth
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxRecursionDepth_Injected(intPtr);
		}
	}

	static RayTracingShader()
	{
		Il2CppClassPointerStore<RayTracingShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RayTracingShader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracingShader>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingShader>.NativeClassPtr, 100668871);
		get_maxRecursionDepth_InjectedDelegateField = IL2CPP.ResolveICall<get_maxRecursionDepth_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::get_maxRecursionDepth_Injected");
		SetFloat_InjectedDelegateField = IL2CPP.ResolveICall<SetFloat_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetFloat_Injected");
		SetInt_InjectedDelegateField = IL2CPP.ResolveICall<SetInt_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetInt_Injected");
		SetVector_InjectedDelegateField = IL2CPP.ResolveICall<SetVector_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetVector_Injected");
		SetMatrix_InjectedDelegateField = IL2CPP.ResolveICall<SetMatrix_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetMatrix_Injected");
		SetFloatArray_InjectedDelegateField = IL2CPP.ResolveICall<SetFloatArray_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetFloatArray_Injected");
		SetIntArray_InjectedDelegateField = IL2CPP.ResolveICall<SetIntArray_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetIntArray_Injected");
		SetVectorArray_InjectedDelegateField = IL2CPP.ResolveICall<SetVectorArray_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetVectorArray_Injected");
		SetMatrixArray_InjectedDelegateField = IL2CPP.ResolveICall<SetMatrixArray_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetMatrixArray_Injected");
		SetTexture_InjectedDelegateField = IL2CPP.ResolveICall<SetTexture_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetTexture_Injected");
		SetBuffer_InjectedDelegateField = IL2CPP.ResolveICall<SetBuffer_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetBuffer_Injected");
		SetGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<SetGraphicsBuffer_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetGraphicsBuffer_Injected");
		SetGraphicsBufferHandle_InjectedDelegateField = IL2CPP.ResolveICall<SetGraphicsBufferHandle_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetGraphicsBufferHandle_Injected");
		SetConstantComputeBuffer_InjectedDelegateField = IL2CPP.ResolveICall<SetConstantComputeBuffer_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetConstantComputeBuffer_Injected");
		SetConstantGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<SetConstantGraphicsBuffer_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetConstantGraphicsBuffer_Injected");
		SetAccelerationStructure_InjectedDelegateField = IL2CPP.ResolveICall<SetAccelerationStructure_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetAccelerationStructure_Injected");
		SetShaderPass_InjectedDelegateField = IL2CPP.ResolveICall<SetShaderPass_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetShaderPass_Injected");
		SetTextureFromGlobal_InjectedDelegateField = IL2CPP.ResolveICall<SetTextureFromGlobal_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetTextureFromGlobal_Injected");
		Dispatch_InjectedDelegateField = IL2CPP.ResolveICall<Dispatch_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::Dispatch_Injected");
		DispatchIndirect_InjectedDelegateField = IL2CPP.ResolveICall<DispatchIndirect_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::DispatchIndirect_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240536, XrefRangeEnd = 1240540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RayTracingShader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RayTracingShader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RayTracingShader(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void SetFloat(int nameID, float val)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetFloat_Injected(intPtr, nameID, val);
	}

	public void SetInt(int nameID, int val)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetInt_Injected(intPtr, nameID, val);
	}

	public void SetVector(int nameID, Vector4 val)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetVector_Injected(intPtr, nameID, ref val);
	}

	public void SetMatrix(int nameID, Matrix4x4 val)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetMatrix_Injected(intPtr, nameID, ref val);
	}

	public unsafe void SetFloatArray(int nameID, Il2CppStructArray<float> values)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0020: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<float> span);
		((Il2CppSystem.Span<float>)(&span))._002Ector((Il2CppArrayBase<float>)(object)values);
		fixed (float* begin = &((Il2CppSystem.Span<float>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper values2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<float>)(&span)).Length);
			SetFloatArray_Injected(intPtr, nameID, ref values2);
		}
	}

	public unsafe void SetIntArray(int nameID, Il2CppStructArray<int> values)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0020: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<int> span);
		((Il2CppSystem.Span<int>)(&span))._002Ector((Il2CppArrayBase<int>)(object)values);
		fixed (int* begin = &((Il2CppSystem.Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper values2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<int>)(&span)).Length);
			SetIntArray_Injected(intPtr, nameID, ref values2);
		}
	}

	public unsafe void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0020: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector4> span);
		((Il2CppSystem.Span<Vector4>)(&span))._002Ector((Il2CppArrayBase<Vector4>)(object)values);
		fixed (Vector4* begin = &((Il2CppSystem.Span<Vector4>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper values2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector4>)(&span)).Length);
			SetVectorArray_Injected(intPtr, nameID, ref values2);
		}
	}

	public unsafe void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0020: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Matrix4x4> span);
		((Il2CppSystem.Span<Matrix4x4>)(&span))._002Ector((Il2CppArrayBase<Matrix4x4>)(object)values);
		fixed (Matrix4x4* begin = &((Il2CppSystem.Span<Matrix4x4>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper values2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Matrix4x4>)(&span)).Length);
			SetMatrixArray_Injected(intPtr, nameID, ref values2);
		}
	}

	public void SetTexture(int nameID, Texture texture)
	{
		if ((object)texture == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(texture, "texture");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = MarshalledUnityObject.MarshalNotNull(texture);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(texture, "texture");
		}
		SetTexture_Injected(intPtr, nameID, intPtr2);
	}

	public void SetBuffer(int nameID, ComputeBuffer buffer)
	{
		if (buffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = ComputeBuffer.BindingsMarshaller.ConvertToNative(buffer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		SetBuffer_Injected(intPtr, nameID, intPtr2);
	}

	public void SetGraphicsBuffer(int nameID, GraphicsBuffer buffer)
	{
		if (buffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = GraphicsBuffer.BindingsMarshaller.ConvertToNative(buffer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		SetGraphicsBuffer_Injected(intPtr, nameID, intPtr2);
	}

	public void SetGraphicsBufferHandle(int nameID, GraphicsBufferHandle bufferHandle)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetGraphicsBufferHandle_Injected(intPtr, nameID, ref bufferHandle);
	}

	public void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
	{
		if (buffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = ComputeBuffer.BindingsMarshaller.ConvertToNative(buffer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		SetConstantComputeBuffer_Injected(intPtr, nameID, intPtr2, offset, size);
	}

	public void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
	{
		if (buffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = GraphicsBuffer.BindingsMarshaller.ConvertToNative(buffer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		SetConstantGraphicsBuffer_Injected(intPtr, nameID, intPtr2, offset, size);
	}

	public void SetAccelerationStructure(int nameID, RayTracingAccelerationStructure accelerationStructure)
	{
		if (accelerationStructure == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(accelerationStructure, "accelerationStructure");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(accelerationStructure);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(accelerationStructure, "accelerationStructure");
		}
		SetAccelerationStructure_Injected(intPtr, nameID, intPtr2);
	}

	public unsafe void SetShaderPass(string passName)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(passName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(passName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetShaderPass_Injected(intPtr, ref managedSpanWrapper);
					return;
				}
			}
			SetShaderPass_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public void SetTextureFromGlobal(int nameID, int globalTextureNameID)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetTextureFromGlobal_Injected(intPtr, nameID, globalTextureNameID);
	}

	public unsafe void Dispatch(string rayGenFunctionName, int width, int height, int depth, [Optional] Camera camera)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(rayGenFunctionName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(rayGenFunctionName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					Dispatch_Injected(intPtr, ref managedSpanWrapper, width, height, depth, MarshalledUnityObject.Marshal(camera));
					return;
				}
			}
			Dispatch_Injected(intPtr, ref managedSpanWrapper, width, height, depth, MarshalledUnityObject.Marshal(camera));
		}
		finally
		{
		}
	}

	public unsafe void DispatchIndirect(string rayGenFunctionName, GraphicsBuffer argsBuffer, [Optional] uint argsOffset, [Optional] Camera camera)
	{
		//IL_0037: Expected O, but got Ref
		//IL_0043: Expected O, but got Ref
		//The blocks IL_0048, IL_0054, IL_005f are reachable both inside and outside the pinned region starting at IL_0037. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if (argsBuffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(argsBuffer, "argsBuffer");
		}
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper rayGenFunctionName2;
			System.IntPtr intPtr2;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(rayGenFunctionName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(rayGenFunctionName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					rayGenFunctionName2 = ref managedSpanWrapper;
					intPtr2 = GraphicsBuffer.BindingsMarshaller.ConvertToNative(argsBuffer);
					if (intPtr2 == (System.IntPtr)0)
					{
						UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(argsBuffer, "argsBuffer");
					}
					DispatchIndirect_Injected(intPtr, ref rayGenFunctionName2, intPtr2, argsOffset, MarshalledUnityObject.Marshal(camera));
					return;
				}
			}
			rayGenFunctionName2 = ref managedSpanWrapper;
			intPtr2 = GraphicsBuffer.BindingsMarshaller.ConvertToNative(argsBuffer);
			if (intPtr2 == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(argsBuffer, "argsBuffer");
			}
			DispatchIndirect_Injected(intPtr, ref rayGenFunctionName2, intPtr2, argsOffset, MarshalledUnityObject.Marshal(camera));
		}
		finally
		{
		}
	}

	public void SetBuffer(int nameID, GraphicsBuffer buffer)
	{
		SetGraphicsBuffer(nameID, buffer);
	}

	public void SetBuffer(int nameID, GraphicsBufferHandle bufferHandle)
	{
		SetGraphicsBufferHandle(nameID, bufferHandle);
	}

	public void SetFloat(string name, float val)
	{
		SetFloat(Shader.PropertyToID(name), val);
	}

	public void SetInt(string name, int val)
	{
		SetInt(Shader.PropertyToID(name), val);
	}

	public void SetVector(string name, Vector4 val)
	{
		SetVector(Shader.PropertyToID(name), val);
	}

	public void SetMatrix(string name, Matrix4x4 val)
	{
		SetMatrix(Shader.PropertyToID(name), val);
	}

	public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
	{
		SetVectorArray(Shader.PropertyToID(name), values);
	}

	public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
	{
		SetMatrixArray(Shader.PropertyToID(name), values);
	}

	public void SetFloats(string name, Il2CppStructArray<float> values)
	{
		SetFloatArray(Shader.PropertyToID(name), values);
	}

	public void SetFloats(string name, params float[] values)
	{
		SetFloats(name, new Il2CppStructArray<float>(values));
	}

	public void SetFloats(int nameID, Il2CppStructArray<float> values)
	{
		SetFloatArray(nameID, values);
	}

	public void SetFloats(int nameID, params float[] values)
	{
		SetFloats(nameID, new Il2CppStructArray<float>(values));
	}

	public void SetInts(string name, Il2CppStructArray<int> values)
	{
		SetIntArray(Shader.PropertyToID(name), values);
	}

	public void SetInts(string name, params int[] values)
	{
		SetInts(name, new Il2CppStructArray<int>(values));
	}

	public void SetInts(int nameID, Il2CppStructArray<int> values)
	{
		SetIntArray(nameID, values);
	}

	public void SetInts(int nameID, params int[] values)
	{
		SetInts(nameID, new Il2CppStructArray<int>(values));
	}

	public void SetBool(string name, bool val)
	{
		SetInt(Shader.PropertyToID(name), val ? 1 : 0);
	}

	public void SetBool(int nameID, bool val)
	{
		SetInt(nameID, val ? 1 : 0);
	}

	public void SetTexture(string name, Texture texture)
	{
		SetTexture(Shader.PropertyToID(name), texture);
	}

	public void SetBuffer(string name, ComputeBuffer buffer)
	{
		SetBuffer(Shader.PropertyToID(name), buffer);
	}

	public void SetBuffer(string name, GraphicsBuffer buffer)
	{
		SetBuffer(Shader.PropertyToID(name), buffer);
	}

	public void SetBuffer(string name, GraphicsBufferHandle bufferHandle)
	{
		SetBuffer(Shader.PropertyToID(name), bufferHandle);
	}

	public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
	{
		SetConstantComputeBuffer(nameID, buffer, offset, size);
	}

	public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size)
	{
		SetConstantComputeBuffer(Shader.PropertyToID(name), buffer, offset, size);
	}

	public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
	{
		SetConstantGraphicsBuffer(nameID, buffer, offset, size);
	}

	public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size)
	{
		SetConstantGraphicsBuffer(Shader.PropertyToID(name), buffer, offset, size);
	}

	public void SetAccelerationStructure(string name, RayTracingAccelerationStructure accelerationStructure)
	{
		SetAccelerationStructure(Shader.PropertyToID(name), accelerationStructure);
	}

	public void SetTextureFromGlobal(string name, string globalTextureName)
	{
		SetTextureFromGlobal(Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
	}

	public static float get_maxRecursionDepth_Injected(System.IntPtr _unity_self)
	{
		return get_maxRecursionDepth_InjectedDelegateField(_unity_self);
	}

	public static void SetFloat_Injected(System.IntPtr _unity_self, int nameID, float val)
	{
		SetFloat_InjectedDelegateField(_unity_self, nameID, val);
	}

	public static void SetInt_Injected(System.IntPtr _unity_self, int nameID, int val)
	{
		SetInt_InjectedDelegateField(_unity_self, nameID, val);
	}

	public unsafe static void SetVector_Injected(System.IntPtr _unity_self, int nameID, [In] ref Vector4 val)
	{
		SetVector_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void SetMatrix_Injected(System.IntPtr _unity_self, int nameID, [In] ref Matrix4x4 val)
	{
		SetMatrix_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void SetFloatArray_Injected(System.IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values)
	{
		SetFloatArray_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref values));
	}

	public unsafe static void SetIntArray_Injected(System.IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values)
	{
		SetIntArray_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref values));
	}

	public unsafe static void SetVectorArray_Injected(System.IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values)
	{
		SetVectorArray_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref values));
	}

	public unsafe static void SetMatrixArray_Injected(System.IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values)
	{
		SetMatrixArray_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref values));
	}

	public static void SetTexture_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr texture)
	{
		SetTexture_InjectedDelegateField(_unity_self, nameID, texture);
	}

	public static void SetBuffer_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr buffer)
	{
		SetBuffer_InjectedDelegateField(_unity_self, nameID, buffer);
	}

	public static void SetGraphicsBuffer_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr buffer)
	{
		SetGraphicsBuffer_InjectedDelegateField(_unity_self, nameID, buffer);
	}

	public unsafe static void SetGraphicsBufferHandle_Injected(System.IntPtr _unity_self, int nameID, [In] ref GraphicsBufferHandle bufferHandle)
	{
		SetGraphicsBufferHandle_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref bufferHandle));
	}

	public static void SetConstantComputeBuffer_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr buffer, int offset, int size)
	{
		SetConstantComputeBuffer_InjectedDelegateField(_unity_self, nameID, buffer, offset, size);
	}

	public static void SetConstantGraphicsBuffer_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr buffer, int offset, int size)
	{
		SetConstantGraphicsBuffer_InjectedDelegateField(_unity_self, nameID, buffer, offset, size);
	}

	public static void SetAccelerationStructure_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr accelerationStructure)
	{
		SetAccelerationStructure_InjectedDelegateField(_unity_self, nameID, accelerationStructure);
	}

	public unsafe static void SetShaderPass_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper passName)
	{
		SetShaderPass_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref passName));
	}

	public static void SetTextureFromGlobal_Injected(System.IntPtr _unity_self, int nameID, int globalTextureNameID)
	{
		SetTextureFromGlobal_InjectedDelegateField(_unity_self, nameID, globalTextureNameID);
	}

	public unsafe static void Dispatch_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper rayGenFunctionName, int width, int height, int depth, System.IntPtr camera)
	{
		Dispatch_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref rayGenFunctionName), width, height, depth, camera);
	}

	public unsafe static void DispatchIndirect_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper rayGenFunctionName, System.IntPtr argsBuffer, uint argsOffset, System.IntPtr camera)
	{
		DispatchIndirect_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref rayGenFunctionName), argsBuffer, argsOffset, camera);
	}
}
