namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

public enum PassBreakReason
{
	NotOptimized,
	TargetSizeMismatch,
	NextPassReadsTexture,
	NextPassTargetsTexture,
	NonRasterPass,
	DifferentDepthTextures,
	AttachmentLimitReached,
	SubPassLimitReached,
	EndOfGraph,
	FRStateMismatch,
	Merged,
	Count
}
