Shader "Custom/NoiseMap"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_Noise ("Noise", 2D) = "white" {}
		_Intensity("Intensity", Float) = 1
		_Frequency("Frequency", Float) = 1
	}
	SubShader
	{
		Cull Off ZWrite Off ZTest Always

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			sampler2D _MainTex;
			sampler2D _Noise;

			float _Intensity;
			float _Frequency;

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}
			


			fixed4 frag (v2f i) : SV_Target
			{
				float4 noise = tex2D(_Noise, i.uv - _Time.xy * _Frequency);

				float2 finalUV = i.uv;

				finalUV.y -= noise.xy*_Intensity;

				fixed4 col = tex2D(_MainTex, finalUV);

				return col;
			}
			ENDCG
		}
	}
}
