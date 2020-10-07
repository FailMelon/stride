﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Stride Shader Mixin Code Generator.
// To generate it yourself, please install Stride.VisualStudio.Package .vsix
// and re-save the associated .sdfx.
// </auto-generated>

using System;
using Stride.Core;
using Stride.Rendering;
using Stride.Graphics;
using Stride.Shaders;
using Stride.Core.Mathematics;
using Buffer = Stride.Graphics.Buffer;

using Stride.Rendering.Data;
using Stride.Rendering.Lights;
namespace Stride.Rendering.Voxels.VoxelGI
{
    internal static partial class ShaderMixins
    {
        internal partial class LightVoxelEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "LightVoxelShader");
                if (context.GetParam(LightVoxelShaderKeys.diffuseMarcher) != null)
                {

                    {
                        var __mixinToCompose__ = context.GetParam(LightVoxelShaderKeys.diffuseMarcher);
                        var __subMixin = new ShaderMixinSource();
                        context.PushComposition(mixin, "diffuseMarcher", __subMixin);
                        context.Mixin(__subMixin, __mixinToCompose__);
                        context.PopComposition();
                    }
                }
                if (context.GetParam(LightVoxelShaderKeys.specularMarcher) != null)
                {

                    {
                        var __mixinToCompose__ = context.GetParam(LightVoxelShaderKeys.specularMarcher);
                        var __subMixin = new ShaderMixinSource();
                        context.PushComposition(mixin, "specularMarcher", __subMixin);
                        context.Mixin(__subMixin, __mixinToCompose__);
                        context.PopComposition();
                    }
                }
                if (context.GetParam(MarchAttributesKeys.AttributeSamplers) != null)
                {
                    foreach(var attr in context.GetParam(MarchAttributesKeys.AttributeSamplers))

                    {

                        {
                            var __mixinToCompose__ = (attr);
                            var __subMixin = new ShaderMixinSource();
                            context.PushCompositionArray(mixin, "AttributeSamplers", __subMixin);
                            context.Mixin(__subMixin, __mixinToCompose__);
                            context.PopComposition();
                        }
                    }
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("LightVoxelEffect", new LightVoxelEffect());
            }
        }
    }
}