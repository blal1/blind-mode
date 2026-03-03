using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace UnityEngine;

public class WWWForm : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dDash;

	private static readonly System.IntPtr NativeFieldInfoPtr_crlf;

	private static readonly System.IntPtr NativeFieldInfoPtr_contentTypeHeader;

	private static readonly System.IntPtr NativeFieldInfoPtr_dispositionHeader;

	private static readonly System.IntPtr NativeFieldInfoPtr_endQuote;

	private static readonly System.IntPtr NativeFieldInfoPtr_fileNameField;

	private static readonly System.IntPtr NativeFieldInfoPtr_ampersand;

	private static readonly System.IntPtr NativeFieldInfoPtr_equal;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultEncoding_Internal_Static_get_Encoding_0;

	public unsafe static Il2CppStructArray<byte> dDash
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dDash, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dDash, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> crlf
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_crlf, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_crlf, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> contentTypeHeader
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_contentTypeHeader, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_contentTypeHeader, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> dispositionHeader
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dispositionHeader, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dispositionHeader, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> endQuote
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_endQuote, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_endQuote, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> fileNameField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fileNameField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fileNameField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> ampersand
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ampersand, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ampersand, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> equal
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_equal, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_equal, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Encoding DefaultEncoding
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408153, XrefRangeEnd = 1408154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultEncoding_Internal_Static_get_Encoding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
		}
	}

	public Dictionary<string, string> headers
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Il2CppStructArray<byte> data
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static WWWForm()
	{
		Il2CppClassPointerStore<WWWForm>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine", "WWWForm");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WWWForm>.NativeClassPtr);
		NativeFieldInfoPtr_dDash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "dDash");
		NativeFieldInfoPtr_crlf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "crlf");
		NativeFieldInfoPtr_contentTypeHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "contentTypeHeader");
		NativeFieldInfoPtr_dispositionHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "dispositionHeader");
		NativeFieldInfoPtr_endQuote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "endQuote");
		NativeFieldInfoPtr_fileNameField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "fileNameField");
		NativeFieldInfoPtr_ampersand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "ampersand");
		NativeFieldInfoPtr_equal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "equal");
		NativeMethodInfoPtr_get_DefaultEncoding_Internal_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, 100663302);
	}

	public WWWForm(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void AddField(string fieldName, string value)
	{
		AddField(fieldName, value, Encoding.UTF8);
	}

	public void AddField(string fieldName, string value, Encoding e)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void AddField(string fieldName, int i)
	{
		AddField(fieldName, i.ToString());
	}

	public void AddBinaryData(string fieldName, Il2CppStructArray<byte> contents)
	{
		AddBinaryData(fieldName, contents, null, null);
	}

	public void AddBinaryData(string fieldName, Il2CppStructArray<byte> contents, string fileName)
	{
		AddBinaryData(fieldName, contents, fileName, null);
	}

	public void AddBinaryData(string fieldName, Il2CppStructArray<byte> contents, string fileName, string mimeType)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
