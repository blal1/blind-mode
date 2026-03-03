using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

public sealed class DetailPrototype
{
	private delegate bool ValidateDetailPrototype_InjectedDelegate(System.IntPtr prototype, [Out] System.IntPtr errorMessage);

	private static readonly ValidateDetailPrototype_InjectedDelegate ValidateDetailPrototype_InjectedDelegateField = IL2CPP.ResolveICall<ValidateDetailPrototype_InjectedDelegate>("UnityEngine.DetailPrototype::ValidateDetailPrototype_Injected");

	public GameObject prototype
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Texture2D prototypeTexture
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float minWidth
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float maxWidth
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float minHeight
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float maxHeight
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public int noiseSeed
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float noiseSpread
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float density
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float bendFactor
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float holeEdgePadding
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Color healthyColor
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Color dryColor
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public DetailRenderMode renderMode
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public bool usePrototypeMesh
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public bool useInstancing
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float targetCoverage
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public bool useDensityScaling
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float alignToGround
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float positionJitter
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public bool Equals(Il2CppSystem.Object obj)
	{
		return Equals(((Il2CppObjectBase)obj).TryCast<DetailPrototype>());
	}

	public override int GetHashCode()
	{
		return ((Il2CppSystem.Object)this).GetHashCode();
	}

	public bool Equals(DetailPrototype other)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public bool Validate()
	{
		string errorMessage;
		return ValidateDetailPrototype(this, out errorMessage);
	}

	public bool Validate(out string errorMessage)
	{
		return ValidateDetailPrototype(this, out errorMessage);
	}

	public static bool ValidateDetailPrototype(DetailPrototype prototype, out string errorMessage)
	{
		if (prototype == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)prototype, "prototype");
		}
		Unsafe.SkipInit(out ManagedSpanWrapper errorMessage2);
		try
		{
			return ValidateDetailPrototype_Injected(prototype, out errorMessage2);
		}
		finally
		{
			errorMessage = OutStringMarshaller.GetStringAndDispose(errorMessage2);
		}
	}

	public static bool IsModeSupportedByRenderPipeline(DetailRenderMode renderMode, bool useInstancing, out string errorMessage)
	{
		if (GraphicsSettings.currentRenderPipeline != null)
		{
			if (renderMode == DetailRenderMode.GrassBillboard && GraphicsSettings.GetDefaultShader(DefaultShaderType.TerrainDetailGrassBillboard) == null)
			{
				errorMessage = "The current render pipeline does not support Billboard details. Details will not be rendered.";
				return false;
			}
			if (renderMode == DetailRenderMode.VertexLit && !useInstancing && GraphicsSettings.GetDefaultShader(DefaultShaderType.TerrainDetailLit) == null)
			{
				errorMessage = "The current render pipeline does not support VertexLit details. Details will be rendered using the default shader.";
				return false;
			}
			if (renderMode == DetailRenderMode.Grass && GraphicsSettings.GetDefaultShader(DefaultShaderType.TerrainDetailGrass) == null)
			{
				errorMessage = "The current render pipeline does not support Grass details. Details will be rendered using the default shader without alpha test and animation.";
				return false;
			}
		}
		errorMessage = Il2CppSystem.String.Empty;
		return true;
	}

	public unsafe static bool ValidateDetailPrototype_Injected(DetailPrototype prototype, out ManagedSpanWrapper errorMessage)
	{
		return ValidateDetailPrototype_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prototype), (nint)Unsafe.AsPointer(ref errorMessage));
	}
}
