//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;


namespace ANEffectsLibrary
{
	
	/// <summary>An effect that inverts all colors.</summary>
	public class InvertColorEffect : ShaderEffect {
		public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(InvertColorEffect), 0);
		public InvertColorEffect() {
			PixelShader pixelShader = new PixelShader();
			pixelShader.UriSource = Global.MakePackUri("Effects/Shaders/InvertColorEffect.ps");
			this.PixelShader = pixelShader;

			this.UpdateShaderValue(InputProperty);
		}
		public Brush Input {
			get {
				return ((Brush)(this.GetValue(InputProperty)));
			}
			set {
				this.SetValue(InputProperty, value);
			}
		}
	}
}
